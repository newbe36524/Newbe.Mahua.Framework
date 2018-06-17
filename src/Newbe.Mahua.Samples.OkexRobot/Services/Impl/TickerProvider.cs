using Newbe.Mahua.Samples.OkexRobot.Common;
using Newbe.Mahua.Samples.OkexRobot.OkexApi;
using System.Collections.Concurrent;

namespace Newbe.Mahua.Samples.OkexRobot.Services.Impl
{
    public class TickerProvider : ITickerProvider
    {
        private readonly IOkexApiFactory _okexApiFactory;

        public TickerProvider(
            IOkexApiFactory okexApiFactory)
        {
            _okexApiFactory = okexApiFactory;
        }

        private static readonly ConcurrentDictionary<string, LocalCache<Ticker>>
            Cache = new ConcurrentDictionary<string, LocalCache<Ticker>>();
        private static readonly Ticker UsdtTicker = new Ticker
        {
            Last = 1,
            Buy = 1,
            High = 1,
            Low = 1,
            Sell = 1,
            Vol = 0
        };
        public Ticker GetTikcer(string symbol)
        {
            if (symbol == "usdt_usdt")
            {
                return UsdtTicker;
            }
            var localCache = Cache.GetOrAdd(symbol, s => new LocalCache<Ticker>());
            var ticker = localCache.Get(60 * 10, () =>
            {
                var tickerOutput = _okexApiFactory.Create<ITickerApi>().GetTicker(symbol).GetAwaiter().GetResult();
                return tickerOutput.Ticker;
            });
            return ticker;
        }
    }
}
