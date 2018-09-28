using Newbe.Mahua.Messages;
using Newbe.Mahua.QQLight.Apis;

namespace Newbe.Mahua.QQLight.Messages
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
            _factory().MessageType = QqLightConstants.MsgType好友消息;
            return _factory();
        }
    }
}
