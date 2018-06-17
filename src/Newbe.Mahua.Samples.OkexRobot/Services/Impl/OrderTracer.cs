using Newbe.Mahua.Samples.OkexRobot.Common;
using Newbe.Mahua.Samples.OkexRobot.OkexApi;
using System.Collections.Generic;
using System.Linq;

namespace Newbe.Mahua.Samples.OkexRobot.Services.Impl
{
    public class OrderTracer : IOrderTracer
    {
        private readonly IUserAssetService _userAssetService;
        private readonly IOkexApiFactory _okexApiFactory;
        private readonly ITickerProvider _tickerProvider;

        public OrderTracer(
            IUserAssetService userAssetService,
            IOkexApiFactory okexApiFactory,
            ITickerProvider tickerProvider)
        {
            _userAssetService = userAssetService;
            _okexApiFactory = okexApiFactory;
            _tickerProvider = tickerProvider;
        }
        private static readonly List<int> FinishedOrders = new List<int>();
        private static readonly object Locker = new object();
        public void ReportFinishedOrders()
        {
            var userAssets = _userAssetService.GetUserAssets();
            var systemOptions = SystemOptions.Instance;
            var list = new List<Order>();
            using (var session = MahuaRobotManager.Instance.CreateSession())
            {
                var api = session.MahuaApi;
                foreach (var kv in userAssets)
                {
                    if (kv.Key == "usdt")
                    {
                        continue;
                    }
                    var market = $"{kv.Key}_usdt";
                    var input = new GetOrderHistoryInput
                    {
                        CurrentPage = 1,
                        PageLength = 100,
                        Status = (int)GetOrderHistoryInput.GetOrderHistoryInputStatus.Finished,
                        Symbol = market
                    }.WithSign();
                    var orderHistory = _okexApiFactory.Create<IOrderApi>().GetOrderHistory(input).GetAwaiter().GetResult();
                    if (orderHistory.Result)
                    {
                        list.AddRange(orderHistory.Orders);
                    }
                    else
                    {
                        api.SendPrivateMessage(systemOptions.MasterQq, $"get {market} orders failed");
                    }
                }

                lock (Locker)
                {
                    if (!FinishedOrders.Any())
                    {
                        FinishedOrders.AddRange(list.Select(x => x.OrderId));
                    }
                    else
                    {
                        var newOrders = list.Where(x => !FinishedOrders.Contains(x.OrderId)).ToArray();
                        foreach (var order in newOrders)
                        {
                            var ticker = _tickerProvider.GetTikcer(order.Symbol);
                            if (order.Status == Order.OrderStatus.Finished)
                            {
                                api.SendPrivateMessage(systemOptions.MasterQq)
                                    .Text($"{order.Symbol} {order.Type:G} FINISHED")
                                    .Newline()
                                    .Text($"Price:{order.Price:E6}")
                                    .Newline()
                                    .Text($"Amount:{order.DealAmount:e2}/{order.Amount:e2} ")
                                    .Newline()
                                    .Text($"USD:{order.Amount * ticker.Last:0000000.00}")
                                    .Done();
                            }
                            else
                            {
                                api.SendPrivateMessage(systemOptions.MasterQq)
                                    .Text($"{order.Symbol} {order.Type:G} FINISHED")
                                    .Newline()
                                    .Text($"Price:{order.Price:E6}")
                                    .Newline()
                                    .Text($"Amount:{order.DealAmount:e2}/{order.Amount:e2} ")
                                    .Newline()
                                    .Text($"USD:{order.DealAmount * ticker.Last:0000000.00}")
                                    .Done();
                            }
                        }
                        FinishedOrders.AddRange(newOrders.Select(x => x.OrderId).ToArray());
                    }
                }
            }
        }
    }
}
