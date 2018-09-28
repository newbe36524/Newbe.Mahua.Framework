using Newbe.Mahua.Messages;

namespace Newbe.Mahua.CleverQQ.Messages
{
    public class GroupMessageCancelTokenFactory : IMessageCancelTokenFactory
    {
        private readonly MessageCancelToken.Factory _factory;

        public GroupMessageCancelTokenFactory(MessageCancelToken.Factory factory)
        {
            _factory = factory;
        }

        public IMessageCancelToken CreateToken()
        {
            _factory().MessageType = 2;
            return _factory();
        }
    }
}
