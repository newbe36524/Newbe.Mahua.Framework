using System.IO;
using System.Linq;
using Newbe.Mahua.CleverQQ.Messages.CancelMessage;
using Newbe.Mahua.Messages;
using Newbe.Mahua.Messages.CancelMessage;
using Newbe.Mahua.Messages.Steps;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CleverQQ.Messages
{
    public class PrivateMessageDone : IPrivateMessageDone
    {
        private readonly ICleverQqApi _cleverQqApi;
        private readonly IMahuaApi _mahuaApi;
        private readonly ICleverQQMessage _message;
        private readonly IRobotSessionContext _robotSessionContext;

        public PrivateMessageDone(
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
            if (_message.Shake)
            {
                _cleverQqApi.Api_ShakeWindow(_robotSessionContext.CurrentQq, _message.Target);
            }
            else
            {
                _mahuaApi.SendPrivateMessage(_message.Target, _message.GetMessage());
            }
        }

        public IMessageCancelToken DoneWithToken()
        {
            if (_message.Shake)
            {
                _cleverQqApi.Api_ShakeWindow(_robotSessionContext.CurrentQq, _message.Target);
            }
            else
            {
                return _mahuaApi.SendPrivateMessageWithCancelToken(_message.Target,  _message.GetMessage());
            }

            return CleverQqMessageCancelToken.EmptyActionToken;
        }
    }
}