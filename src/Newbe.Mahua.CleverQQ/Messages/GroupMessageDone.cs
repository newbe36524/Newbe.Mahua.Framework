using System.IO;
using System.Linq;
using Newbe.Mahua.Messages;
using Newbe.Mahua.Messages.CancelMessage;
using Newbe.Mahua.Messages.Steps;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CleverQQ.Messages
{
    public class GroupMessageDone : IGroupMessageDone, IMessageBuildStep
    {
        private readonly ICleverQqApi _cleverQqApi;
        private readonly IMahuaApi _mahuaApi;
        private readonly ICleverQQMessage _message;
        private readonly IRobotSessionContext _robotSessionContext;

        public GroupMessageDone(
            IMahuaApi mahuaApi,
            ICleverQQMessage message,
            ICleverQqApi cleverQqApi,
            IRobotSessionContext robotSessionContext)
        {
            _mahuaApi = mahuaApi;
            _message = message;
            _cleverQqApi = cleverQqApi;
            _robotSessionContext = robotSessionContext;
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