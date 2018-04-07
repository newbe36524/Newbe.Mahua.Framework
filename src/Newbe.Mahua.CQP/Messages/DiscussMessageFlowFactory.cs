using Newbe.Mahua.Messages;

namespace Newbe.Mahua.CQP.Messages
{
    public class DiscussMessageFlowFactory : IDiscussMessageFlowFactory
    {
        private readonly IDiscussMessageStep _discussMessageStep;
        private readonly IMessageBuilder _messageBuilder;

        public DiscussMessageFlowFactory(
            IDiscussMessageStep discussMessageStep,
            IMessageBuilder messageBuilder)
        {
            _discussMessageStep = discussMessageStep;
            _messageBuilder = messageBuilder;
        }

        public IDiscussMessageStep Begin(string discuss)
        {
            _messageBuilder.Target = discuss;
            return _discussMessageStep;
        }
    }
}
