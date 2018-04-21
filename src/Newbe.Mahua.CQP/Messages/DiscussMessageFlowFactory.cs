using Newbe.Mahua.Messages;

namespace Newbe.Mahua.CQP.Messages
{
    public class DiscussMessageFlowFactory : IDiscussMessageFlowFactory
    {
        private readonly IDiscussMessageStep _discussMessageStep;
        private readonly IMessage _message;

        public DiscussMessageFlowFactory(
            IDiscussMessageStep discussMessageStep,
            IMessage message)
        {
            _discussMessageStep = discussMessageStep;
            _message = message;
        }

        public IDiscussMessageStep Begin(string discuss)
        {
            _message.Target = discuss;
            return _discussMessageStep;
        }
    }
}
