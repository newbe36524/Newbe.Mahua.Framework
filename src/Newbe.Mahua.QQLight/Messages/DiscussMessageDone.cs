using Newbe.Mahua.Messages;
using Newbe.Mahua.Messages.Steps;

namespace Newbe.Mahua.QQLight.Messages
{
    public class DiscussMessageDone : IDiscussMessageDone, IWithCancelable
    {
        private readonly IMahuaApi _mahuaApi;
        private readonly IQqLightMessage _message;

        public DiscussMessageDone(
            IMahuaApi mahuaApi,
            IQqLightMessage message)
        {
            _mahuaApi = mahuaApi;
            _message = message;
        }

        public void Done()
        {
            _mahuaApi.SendDiscussMessage(_message.Target, _message.GetMessage());
        }

        public void WithCancelToken(IMessageCancelToken token)
        {
            _mahuaApi.SendDiscussMessage(_message.Target, _message.GetMessage(), token);
        }
    }
}
