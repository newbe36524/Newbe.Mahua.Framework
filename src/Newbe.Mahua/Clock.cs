using System;

namespace Newbe.Mahua
{
    public class Clock : IClock
    {
        public static DateTime Now => ClockInstance.Now;

        public static DateTimeOffset NowOffset => ClockInstance.NowOffset;

        DateTime IClock.Now => Now;

        DateTimeOffset IClock.NowOffset => NowOffset;

        internal static IClock ClockInstance { get; set; }
    }
}
