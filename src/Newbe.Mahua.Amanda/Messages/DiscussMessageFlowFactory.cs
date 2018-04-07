using Newbe.Mahua.Messages;

namespace Newbe.Mahua.Amanda.Messages
{
    public class DiscussMessageFlowFactory : IDiscussMessageFlowFactory
    {
        private readonly IDiscussMessageStep _discussMessageStep;
        private readonly IAmandaMessage _message;

        public DiscussMessageFlowFactory(
            IDiscussMessageStep discussMessageStep,
            IAmandaMessage message)
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
