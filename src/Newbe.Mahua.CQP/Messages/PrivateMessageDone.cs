using Newbe.Mahua.Messages;
using Newbe.Mahua.Messages.Steps;

namespace Newbe.Mahua.CQP.Messages
{
    public class PrivateMessageDone : IPrivateMessageDone
    {
        private readonly IMahuaApi _mahuaApi;
        private readonly IMessage _message;

        public PrivateMessageDone(
            IMahuaApi mahuaApi,
            IMessage message)
        {
            _mahuaApi = mahuaApi;
            _message = message;
        }

        public void Done()
        {
            _mahuaApi.SendPrivateMessage(_message.Target, _message.GetMessage());
        }
    }
}
