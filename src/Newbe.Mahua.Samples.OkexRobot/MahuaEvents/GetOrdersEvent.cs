using Newbe.Mahua.MahuaEvents;
using Newbe.Mahua.Samples.OkexRobot.OkexApi;
using Newbe.Mahua.Samples.OkexRobot.Services;
using System.Collections.Generic;
using System.Linq;

namespace Newbe.Mahua.Samples.OkexRobot.MahuaEvents
{
    public class GetOrdersEvent
        : MasterPrivateMessageEventBase
    {
        private readonly IOkexApiFactory _okexApiFactory;
        private readonly IUserAssetService _assetService;
        private readonly ITickerProvider _tickerProvider;
        public override string MenuCode => "2";

        public GetOrdersEvent(
            IMahuaApi mahuaApi,
            IOkexApiFactory okexApiFactory,
            IUserAssetService assetService,
            ITickerProvider tickerProvider) : base(mahuaApi)
        {
            _okexApiFactory = okexApiFactory;
            _assetService = assetService;
            _tickerProvider = tickerProvider;
        }

        public override void HandleCore(PrivateMessageReceivedContext context)
        {
            MahuaApi.SendPrivateMessage(context.FromQq)
                .Text("Begin Get User Orders")
                .Done();

            var userAssets = _assetService.GetUserAssets();
            if (userAssets.Any())
            {
                var orderApi = _okexApiFactory.Create<IOrderApi>();
                var orders = new List<Order>();
                var assets = userAssets.OrderByDescending(x => x.Value.AsUsdt).ToArray();
                foreach (var kv in assets)
                {
                    if (kv.Key == "usdt")
                    {
                        continue;
                    }
                    var market = $"{kv.Key}_usdt";
                    var getOrdersInput = new GetOrdersInput
                    {
                        Order_Id = "-1",
                        Symbol = market,
                    }.WithSign();
                    var output = orderApi.GetOrders(getOrdersInput).GetAwaiter().GetResult();
                    if (output.Result)
                    {
                        orders.AddRange(output.Orders);
                    }
                    else
                    {
                        MahuaApi.SendPrivateMessage(context.FromQq)
                            .Text($"{market} No Orders")
                            .Done();
                    }
                }

                foreach (var order in orders.Where(x => x.Status == Order.OrderStatus.Doing || x.Status == Order.OrderStatus.Some))
                {
                    var dealPercetion = order.DealAmount / order.Amount * 100M;
                    var ticker = _tickerProvider.GetTikcer(order.Symbol);
                    MahuaApi.SendPrivateMessage(context.FromQq)
                        .Text($"{order.Symbol} {order.Type:G}")
                        .Newline()
                        .Text($"Price:{order.Price:E6}")
                        .Newline()
                        .Text($"Amount:({dealPercetion:###.00}){order.DealAmount:e2}/{order.Amount:e2} ")
                        .Newline()
                        .Text($"USD:{order.DealAmount * ticker.Last:0000000.00}/{order.Amount * ticker.Last:0000000.00}")
                        .Done();
                }
            }
            else
            {
                MahuaApi.SendPrivateMessage(context.FromQq)
                    .Text("No Orders")
                    .Done();
            }
        }
    }
}
