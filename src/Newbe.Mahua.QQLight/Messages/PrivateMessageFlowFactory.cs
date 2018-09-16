using Newbe.Mahua.Messages;

namespace Newbe.Mahua.QQLight.Messages
{
    public class PrivateMessageFlowFactory : IPrivateMessageFlowFactory
    {
        private readonly IPrivateMessageStep _privateMessageStep;
        private readonly IQqLightMessage _message;

        public PrivateMessageFlowFactory(
            IPrivateMessageStep privateMessageStep,
            IQqLightMessage message)
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
