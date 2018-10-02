using System.IO;
using System.Linq;
using Newbe.Mahua.Messages;
using Newbe.Mahua.Messages.CancelMessage;
using Newbe.Mahua.Messages.Steps;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CleverQQ.Messages
{
    public class DiscussMessageDone : IDiscussMessageDone, IMessageBuildStep
    {
        private readonly ICleverQqApi _cleverqqApi;
        private readonly IMahuaApi _mahuaApi;
        private readonly ICleverQQMessage _message;
        private readonly IRobotSessionContext _robotSessionContext;

        public DiscussMessageDone(
            IMahuaApi mahuaApi,
            ICleverQQMessage message,
            ICleverQqApi cleverqqApi,
            IRobotSessionContext robotSessionContext)
        {
            _mahuaApi = mahuaApi;
            _message = message;
            _cleverqqApi = cleverqqApi;
            _robotSessionContext = robotSessionContext;
        }

        public void Done()
        {
            var msg = CreateMessage();
            _mahuaApi.SendPrivateMessage(_message.Target, msg);
        }

        public IMessageCancelToken DoneWithToken()
        {
            var msg = CreateMessage();
            return _mahuaApi.SendPrivateMessageWithCancelToken(_message.Target, msg);
        }

        private string CreateMessage()
        {
            var msg = _message.GetMessage();
            if (_message.Images.Any())
            {
                _message.Images.Upload(file =>
                    _cleverqqApi.Api_UpLoadPic(
                        _robotSessionContext.CurrentQq,
                        2,
                        _message.Target,
                        File.ReadAllBytes(file)));
                msg = _message.Images.Formate(msg);
            }

            return msg;
        }
    }
}