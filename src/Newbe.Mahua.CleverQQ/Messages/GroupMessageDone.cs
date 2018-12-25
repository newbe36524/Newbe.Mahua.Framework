using System.IO;
using System.Linq;
using Newbe.Mahua.Messages;
using Newbe.Mahua.Messages.CancelMessage;
using Newbe.Mahua.Messages.Steps;

namespace Newbe.Mahua.CleverQQ.Messages
{
    public class GroupMessageDone : IGroupMessageDone
    {
        private readonly IMahuaApi _mahuaApi;
        private readonly ICleverQQMessage _message;

        public GroupMessageDone(
            IMahuaApi mahuaApi,
            ICleverQQMessage message)
        {
            _mahuaApi = mahuaApi;
            _message = message;
        }

        public void Done()
        {
            var msg = CreateMessage();
            _mahuaApi.SendGroupMessage(_message.Target, msg);
        }

        public IMessageCancelToken DoneWithToken()
        {
            var msg = CreateMessage();
            return _mahuaApi.SendGroupMessageWithCancelToken(_message.Target, msg);
        }

        private string CreateMessage()
        {
            return  _message.GetMessage();
        }
    }
}