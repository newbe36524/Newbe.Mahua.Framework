using Newbe.Mahua.Messages;

namespace Newbe.Mahua.CQP.Messages
{
    public class PrivateMessageFlowFactory : IPrivateMessageFlowFactory
    {
        private readonly IPrivateMessageStep _privateMessageStep;
        private readonly IMessageBuilder _messageBuilder;

        public PrivateMessageFlowFactory(
            IPrivateMessageStep privateMessageStep,
            IMessageBuilder messageBuilder)
        {
            _privateMessageStep = privateMessageStep;
            _messageBuilder = messageBuilder;
        }

        public IPrivateMessageStep Begin(string qq)
        {
            _messageBuilder.Target = qq;
            return _privateMessageStep;
        }
    }
}
