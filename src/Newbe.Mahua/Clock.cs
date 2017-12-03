using System;

namespace Newbe.Mahua
{
    public class Clock : IClock
    {
        internal static IClock ClockInstance { get; set; }
        public static DateTime Now => ClockInstance.Now;
        public static DateTimeOffset NowOffset => ClockInstance.NowOffset;
        DateTime IClock.Now => Now;

        DateTimeOffset IClock.NowOffset => NowOffset;
    }
}
