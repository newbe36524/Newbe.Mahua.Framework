using System;

namespace Newbe.Mahua.NativeApiClassfy.Services.Impl
{
    public class SystemClock : IClock
    {
        public DateTime Now => DateTime.Now;
    }
}