using Newtonsoft.Json;
using Refit;
using System.Threading.Tasks;

namespace Newbe.Mahua.Samples.OkexRobot.OkexApi
{
    public interface IOrderApi : IOkexApi
    {
        [Post("/v1/order_info.do")]
        Task<GetOrdersOutput> GetOrders(
            [Body(BodySerializationMethod.UrlEncoded)]
            GetOrdersInput input);

        [Post("/v1/order_history.do")]
        Task<OrderHistory> GetOrderHistory(
            [Body(BodySerializationMethod.UrlEncoded)]
            GetOrderHistoryInput input);
    }

    public class GetOrderHistoryInput : OkexInput
    {
        [AliasAs("symbol")]
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [AliasAs("status")]
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("current_page")]
        [AliasAs("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("page_length")]
        [AliasAs("page_length")]
        public int PageLength { get; set; }

        public enum GetOrderHistoryInputStatus
        {
            UnFinished = 0,
            Finished = 1,
        }
    }

    public class OrderHistory
    {
        // ReSharper disable once InconsistentNaming
        public int Currency_Page { get; set; }
        public Order[] Orders { get; set; }

        // ReSharper disable once InconsistentNaming
        public int Page_Length { get; set; }
        public bool Result { get; set; }
        public int Total { get; set; }
    }

    public class GetOrdersInput : OkexInput
    {
        [AliasAs("symbol")]
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        // ReSharper disable once InconsistentNaming
        [AliasAs("order_id")]
        [JsonProperty("order_id")]
        public string Order_Id { get; set; }
    }

    public class GetOrdersOutput
    {
        public bool Result { get; set; }
        public Order[] Orders { get; set; }
    }

    public class Order
    {
        public decimal Amount { get; set; }
        [JsonProperty("create_date")] public long CreateDate { get; set; }
        [JsonProperty("deal_amount")] public decimal DealAmount { get; set; }
        [JsonProperty("avg_price")] public decimal AvgPrice { get; set; }
        [JsonProperty("order_id")] public int OrderId { get; set; }
        public decimal Price { get; set; }
        public OrderStatus Status { get; set; }
        public string Symbol { get; set; }
        public OrderType Type { get; set; }

        public enum OrderType
        {
            // ReSharper disable once InconsistentNaming
            Buy_Market,

            // ReSharper disable once InconsistentNaming
            Sell_Market,
            Buy,
            Sell,
        }

        public enum OrderStatus
        {
            /// <summary>
            /// 已撤单
            /// </summary>
            Canceled = -1,

            /// <summary>
            /// 未成交
            /// </summary>
            Doing = 0,

            /// <summary>
            /// 部分成交
            /// </summary>
            Some = 1,

            /// <summary>
            /// 完全成交
            /// </summary>
            Finished = 2,

            /// <summary>
            /// 撤单中
            /// </summary>
            Canceling = 3,
        }
    }
}
