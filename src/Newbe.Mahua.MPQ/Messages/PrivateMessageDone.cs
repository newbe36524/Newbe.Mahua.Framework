using System.IO;
using System.Linq;
using Newbe.Mahua.Messages;
using Newbe.Mahua.Messages.CancelMessage;
using Newbe.Mahua.Messages.Steps;
using Newbe.Mahua.MPQ.Messages.CancelMessage;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.MPQ.Messages
{
    public class PrivateMessageDone : IPrivateMessageDone, IMessageBuildStep
    {
        private readonly IMahuaApi _mahuaApi;
        private readonly IMpqMessage _message;
        private readonly IMpqApi _mpqApi;
        private readonly IRobotSessionContext _robotSessionContext;

        public PrivateMessageDone(
            IMahuaApi mahuaApi,
            IMpqMessage message,
            IMpqApi mpqApi,
            IRobotSessionContext robotSessionContext)
        {
            _mahuaApi = mahuaApi;
            _message = message;
            _mpqApi = mpqApi;
            _robotSessionContext = robotSessionContext;
        }

        public void Done()
        {
            if (_message.Shake)
            {
                _mpqApi.Api_SendShake(_robotSessionContext.CurrentQq, _message.Target);
            }
            else
            {
                var msg = CreateMessage();
                _mahuaApi.SendPrivateMessage(_message.Target, msg);
            }
        }

        public IMessageCancelToken DoneWithToken()
        {
            if (_message.Shake)
            {
                _mpqApi.Api_SendShake(_robotSessionContext.CurrentQq, _message.Target);
            }
            else
            {
                var msg = CreateMessage();
                return _mahuaApi.SendPrivateMessageWithCancelToken(_message.Target, msg);
            }

            return MpqCancelMessageToken.EmptyActionToken;
        }

        private string CreateMessage()
        {
            var msg = _message.GetMessage();
            if (_message.Images.Any())
            {
                _message.Images.Upload(file =>
                    _mpqApi.Api_UploadPic(
                        _robotSessionContext.CurrentQq,
                        1,
                        _message.Target,
                        File.ReadAllBytes(file)));
                msg = _message.Images.Formate(msg);
            }

            return msg;
        }
    }
}