using Newbe.Mahua.Messages;

namespace Newbe.Mahua.CleverQQ.Messages
{
    public class PrivateMessageFlowFactory : IPrivateMessageFlowFactory
    {
        private readonly IPrivateMessageStep _privateMessageStep;
        private readonly ICleverQQMessage _message;

        public PrivateMessageFlowFactory(
            IPrivateMessageStep privateMessageStep,
            ICleverQQMessage message)
        {
            _privateMessageStep = privateMessageStep;
            _message = message;
        }

        public IPrivateMessageStep Begin(string qq)
        {
            _message.Target = qq;
            return _privateMessageStep;
        }
    }
}
