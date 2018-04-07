using Newbe.Mahua.Messages;
using Newbe.Mahua.Messages.Steps;

namespace Newbe.Mahua.CQP.Messages
{
    public class DiscussMessageDone : IDiscussMessageDone
    {
        private readonly IMahuaApi _mahuaApi;
        private readonly IMessageBuilder _messageBuilder;

        public DiscussMessageDone(
            IMahuaApi mahuaApi,
            IMessageBuilder messageBuilder)
        {
            _mahuaApi = mahuaApi;
            _messageBuilder = messageBuilder;
        }

        public void Done()
        {
            _mahuaApi.SendDiscussMessage(_messageBuilder.Target, _messageBuilder.GetMessage());
        }
    }
}
