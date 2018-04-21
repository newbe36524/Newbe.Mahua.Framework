using Newbe.Mahua.Messages;
using System;

namespace Newbe.Mahua.Internals
{
    public class ThrowsNotSupportedMessageBuilderConvertion<TException> :
        INotSupportedMessageBuilderConvertion
        where TException : Exception, new()
    {
        public void Handle<T>() where T : IMessageBuilder
        {
            throw new TException();
        }
    }
}
