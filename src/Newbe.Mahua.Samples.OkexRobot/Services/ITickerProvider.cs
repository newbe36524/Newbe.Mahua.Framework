using Newbe.Mahua.Samples.OkexRobot.OkexApi;

namespace Newbe.Mahua.Samples.OkexRobot.Services
{
    public interface ITickerProvider
    {
        Ticker GetTikcer(string symbol);
    }
}
