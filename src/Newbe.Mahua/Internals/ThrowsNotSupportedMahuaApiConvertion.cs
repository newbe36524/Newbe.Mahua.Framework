using System;

namespace Newbe.Mahua.Internals
{
    internal class ThrowsNotSupportedMahuaApiConvertion<T> : INotSupportedMahuaApiConvertion where T : Exception, new()
    {
        void INotSupportedMahuaApiConvertion.Handle()
        {
            throw ThrowDefaultException();
        }

        public T1 Handle<T1>(T1 defaultValue)
        {
            throw ThrowDefaultException();
        }

        public T1 Handle<T1>()
        {
            throw ThrowDefaultException();
        }

        private static T ThrowDefaultException()
        {
            throw new T();
        }
    }
}
