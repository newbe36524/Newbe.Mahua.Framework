using Newbe.Mahua.Messages;
using Newbe.Mahua.Messages.Steps;

namespace Newbe.Mahua.CQP.Messages
{
    public class PrivateMessageDone : IPrivateMessageDone
    {
        private readonly IMahuaApi _mahuaApi;
        private readonly IMessageBuilder _messageBuilder;

        public PrivateMessageDone(
            IMahuaApi mahuaApi,
            IMessageBuilder messageBuilder)
        {
            _mahuaApi = mahuaApi;
            _messageBuilder = messageBuilder;
        }

        public void Done()
        {
            _mahuaApi.SendPrivateMessage(_messageBuilder.Target, _messageBuilder.GetMessage());
        }
    }
}
