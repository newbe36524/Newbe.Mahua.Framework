using Newbe.Mahua.Messages;
using Newbe.Mahua.Messages.Steps;

namespace Newbe.Mahua.CQP.Messages
{
    public class GroupMessageDone : IGroupMessageDone, IWithCancelable
    {
        private readonly IMahuaApi _mahuaApi;
        private readonly IMessage _message;

        public GroupMessageDone(
            IMahuaApi mahuaApi,
            IMessage message)
        {
            _mahuaApi = mahuaApi;
            _message = message;
        }

        public void Done()
        {
            _mahuaApi.SendGroupMessage(_message.Target, _message.GetMessage());
        }

        public void WithCancelToken(IMessageCancelToken token)
        {
            _mahuaApi.SendGroupMessage(_message.Target, _message.GetMessage(), token);
        }
    }
}
