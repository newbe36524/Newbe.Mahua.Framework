using Newbe.Mahua.Messages;

namespace Newbe.Mahua.CQP.Messages
{
    public class PrivateMessageFlowFactory : IPrivateMessageFlowFactory
    {
        private readonly IPrivateMessageStep _privateMessageStep;
        private readonly IMessage _message;

        public PrivateMessageFlowFactory(
            IPrivateMessageStep privateMessageStep,
            IMessage message)
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
