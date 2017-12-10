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
    }
}
