using Newbe.Mahua.Messages;

namespace Newbe.Mahua.CQP.Messages
{
    public class DiscussMessageCancelTokenFactory : IMessageCancelTokenFactory
    {
        private readonly MessageCancelToken.Factory _factory;

        public DiscussMessageCancelTokenFactory(MessageCancelToken.Factory factory)
        {
            _factory = factory;
        }

        public IMessageCancelToken CreateToken()
        {
            _factory().MessageType = 3;
            return _factory();
        }
    }
}
