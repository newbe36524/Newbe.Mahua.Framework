using Refit;
using System.Threading.Tasks;

namespace Newbe.Mahua.Samples.OkexRobot.OkexApi
{
    public interface ITickerApi : IOkexApi
    {
        [Get("/v1/ticker.do")]
        Task<TickerOutput> GetTicker(string symbol);
    }


    public class TickerOutput
    {
        public long Date { get; set; }
        public Ticker Ticker { get; set; }
    }

    public class Ticker
    {
        public decimal Buy { get; set; }
        public decimal High { get; set; }
        public decimal Last { get; set; }
        public decimal Low { get; set; }
        public decimal Sell { get; set; }
        public decimal Vol { get; set; }
    }

}
