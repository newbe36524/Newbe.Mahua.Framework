using Newbe.Mahua.Messages;

namespace Newbe.Mahua.QQLight.Messages
{
    public class DiscussMessageFlowFactory : IDiscussMessageFlowFactory
    {
        private readonly IDiscussMessageStep _discussMessageStep;
        private readonly IQqLightMessage _message;

        public DiscussMessageFlowFactory(
            IDiscussMessageStep discussMessageStep,
            IQqLightMessage message)
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
