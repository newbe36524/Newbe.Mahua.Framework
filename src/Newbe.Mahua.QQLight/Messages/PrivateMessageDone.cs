using Newbe.Mahua.Messages.Steps;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Messages
{
    public class PrivateMessageDone : IPrivateMessageDone
    {
        private readonly IMahuaApi _mahuaApi;
        private readonly IQqLightMessage _message;
        private readonly IQqLightApi _QqLightApi;

        public PrivateMessageDone(
            IMahuaApi mahuaApi,
            IQqLightMessage message,
            IQqLightApi QqLightApi)
        {
            _mahuaApi = mahuaApi;
            _message = message;
            _QqLightApi = QqLightApi;
        }

        public void Done()
        {
            if (_message.Shake)
            {
                _QqLightApi.Api_SendShake(_message.Target);
            }
            else
            {
                _mahuaApi.SendPrivateMessage(_message.Target, _message.GetMessage());
            }
        }
    }
}
