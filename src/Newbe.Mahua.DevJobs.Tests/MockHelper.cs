using System;
using Newbe.Mahua.NativeApiClassfy.Services;

namespace Newbe.Mahua.NativeApiClassfy.Tests
{
    public static class MockHelper
    {
        public static IClock CreateClock(DateTime now)
        {
            return new MockClock(now);
        }

        private class MockClock : IClock
        {
            public MockClock(DateTime now)
            {
                Now = now;
            }

            public DateTime Now { get; }
        }
    }
}