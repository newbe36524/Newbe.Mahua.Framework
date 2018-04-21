using Newbe.Mahua.Messages;

namespace Newbe.Mahua.MPQ.Messages
{
    public class DiscussMessageFlowFactory : IDiscussMessageFlowFactory
    {
        private readonly IDiscussMessageStep _discussMessageStep;
        private readonly IMpqMessage _message;

        public DiscussMessageFlowFactory(
            IDiscussMessageStep discussMessageStep,
            IMpqMessage message)
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
