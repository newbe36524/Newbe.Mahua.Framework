using Newbe.Mahua.Messages;

namespace Newbe.Mahua.MPQ.Messages
{
    public class PrivateMessageCancelTokenFactory : IMessageCancelTokenFactory
    {
        private readonly MessageCancelToken.Factory _factory;

        public PrivateMessageCancelTokenFactory(MessageCancelToken.Factory factory)
        {
            _factory = factory;
        }

        public IMessageCancelToken CreateToken()
        {
            _factory().MessageType = 1;
            return _factory();
        }
    }
}
