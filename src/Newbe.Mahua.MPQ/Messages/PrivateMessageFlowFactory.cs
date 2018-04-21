using Newbe.Mahua.Messages;

namespace Newbe.Mahua.MPQ.Messages
{
    public class PrivateMessageFlowFactory : IPrivateMessageFlowFactory
    {
        private readonly IPrivateMessageStep _privateMessageStep;
        private readonly IMpqMessage _message;

        public PrivateMessageFlowFactory(
            IPrivateMessageStep privateMessageStep,
            IMpqMessage message)
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
