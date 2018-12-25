using Newbe.Mahua.Messages;
using Newbe.Mahua.Messages.CancelMessage;
using Newbe.Mahua.Messages.Steps;

namespace Newbe.Mahua.CQP.Messages
{
    public class DiscussMessageDone : IDiscussMessageDone
    {
        private readonly IMahuaApi _mahuaApi;
        private readonly IMessage _message;

        public DiscussMessageDone(
            IMahuaApi mahuaApi,
            IMessage message)
        {
            _mahuaApi = mahuaApi;
            _message = message;
        }

        public void Done()
        {
            _mahuaApi.SendDiscussMessage(_message.Target, _message.GetMessage());
        }

        public IMessageCancelToken DoneWithToken()
        {
            var token = _mahuaApi.SendDiscussMessageWithCancelToken(_message.Target, _message.GetMessage());
            return token;
        }
    }
}