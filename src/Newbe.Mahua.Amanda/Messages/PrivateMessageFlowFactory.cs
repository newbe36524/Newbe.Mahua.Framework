using Newbe.Mahua.Messages;

namespace Newbe.Mahua.Amanda.Messages
{
    public class PrivateMessageFlowFactory : IPrivateMessageFlowFactory
    {
        private readonly IPrivateMessageStep _privateMessageStep;
        private readonly IAmandaMessage _message;

        public PrivateMessageFlowFactory(
            IPrivateMessageStep privateMessageStep,
            IAmandaMessage message)
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
