using System;

namespace Newbe.Mahua.NativeApiClassfy.Services
{
    public interface IClock
    {
        DateTime Now { get; }
    }
}