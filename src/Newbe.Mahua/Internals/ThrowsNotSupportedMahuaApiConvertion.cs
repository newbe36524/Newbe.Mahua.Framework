using System;

namespace Newbe.Mahua.Internals
{
    internal class ThrowsNotSupportedMahuaApiConvertion<T> : INotSupportedMahuaApiConvertion where T : Exception, new()
    {
        void INotSupportedMahuaApiConvertion.Handle()
        {
            throw new T();
        }
    }
}