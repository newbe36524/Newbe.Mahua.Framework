using Newbe.Mahua.Messages;
using Newbe.Mahua.Messages.Steps;

namespace Newbe.Mahua.CQP.Messages
{
    public class GroupMessageDone : IGroupMessageDone
    {
        private readonly IMahuaApi _mahuaApi;
        private readonly IMessageBuilder _messageBuilder;

        public GroupMessageDone(
            IMahuaApi mahuaApi,
            IMessageBuilder messageBuilder)
        {
            _mahuaApi = mahuaApi;
            _messageBuilder = messageBuilder;
        }

        public void Done()
        {
            _mahuaApi.SendGroupMessage(_messageBuilder.Target, _messageBuilder.GetMessage());
        }
    }
}
