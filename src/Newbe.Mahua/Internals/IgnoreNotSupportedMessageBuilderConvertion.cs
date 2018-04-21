using Newbe.Mahua.Messages;

namespace Newbe.Mahua.Internals
{
    internal class IgnoreNotSupportedMessageBuilderConvertion :
        INotSupportedMessageBuilderConvertion
    {
        public void Handle<T>() where T : IMessageBuilder
        {
            // do nothing
        }
    }
}
