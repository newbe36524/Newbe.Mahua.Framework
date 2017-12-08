using System;

namespace Newbe.Mahua
{
    public interface IClock
    {
        DateTime Now { get; }

        DateTimeOffset NowOffset { get; }
    }
}
