using Newbe.Mahua.Messages;
using Newbe.Mahua.Messages.CancelMessage;
using Newbe.Mahua.Messages.Steps;
using Newbe.Mahua.NativeApi;
using Newbe.Mahua.QQLight.Messages.CancelMessage;

namespace Newbe.Mahua.QQLight.Messages
{
    public class PrivateMessageDone : IPrivateMessageDone, IMessageBuildStep
    {
        private readonly IMahuaApi _mahuaApi;
        private readonly IQqLightMessage _message;
        private readonly IQqLightApi _qqLightApi;

        public PrivateMessageDone(
            IMahuaApi mahuaApi,
            IQqLightMessage message,
            IQqLightApi qqLightApi)
        {
            _mahuaApi = mahuaApi;
            _message = message;
            _qqLightApi = qqLightApi;
        }

        public void Done()
        {
            if (_message.Shake)
            {
                _qqLightApi.Api_SendShake(_message.Target);
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
                _qqLightApi.Api_SendShake(_message.Target);
            }
            else
            {
                return _mahuaApi.SendPrivateMessageWithCancelToken(_message.Target, _message.GetMessage());
            }

            return QqLightMessageCancelToken.EmptyActionToken;
        }
    }
}