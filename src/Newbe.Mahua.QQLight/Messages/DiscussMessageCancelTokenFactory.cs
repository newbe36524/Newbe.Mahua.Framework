using Newbe.Mahua.Messages;
using Newbe.Mahua.QQLight.Apis;

namespace Newbe.Mahua.QQLight.Messages
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
            _factory().MessageType = QqLightConstants.MsgType讨论组消息;
            return _factory();
        }
    }
}
