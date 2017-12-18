using System;

namespace Newbe.Mahua
{
    public class Clock : IClock
    {
        public static DateTime Now => ClockInstance.Now;

        public static DateTimeOffset NowOffset => ClockInstance.NowOffset;

        DateTime IClock.Now => DateTime.Now;

        DateTimeOffset IClock.NowOffset => DateTimeOffset.Now;

        internal static IClock ClockInstance { get; set; } = new Clock();

        public static DateTime ConvertMillisecondsToDateTime(long milliseconds)
        {
            var re = new DateTime(1970, 1, 1, 0, 0, 0).ToLocalTime()
                .AddSeconds(milliseconds);
            return re;
        }

        public static DateTime ConvertSecondsToDateTime(long seconds)
        {
            var re = new DateTime(1970, 1, 1, 0, 0, 0).ToLocalTime()
                .AddMilliseconds(seconds);
            return re;
        }
    }
}
