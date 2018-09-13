using Newbe.Mahua.Messages;

namespace Newbe.Mahua.CleverQQ.Messages
{
    public class DiscussMessageFlowFactory : IDiscussMessageFlowFactory
    {
        private readonly IDiscussMessageStep _discussMessageStep;
        private readonly ICleverQQMessage _message;

        public DiscussMessageFlowFactory(
            IDiscussMessageStep discussMessageStep,
            ICleverQQMessage message)
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
