using Newbe.Mahua.Messages;
using Newbe.Mahua.QQLight.Apis;

namespace Newbe.Mahua.QQLight.Messages
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
            _factory().MessageType = QqLightConstants.MsgType群消息;
            return _factory();
        }
    }
}
