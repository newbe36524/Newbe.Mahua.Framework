using Newbe.Mahua.Amanda.NativeApi;
using Newbe.Mahua.Messages.Steps;

namespace Newbe.Mahua.Amanda.Messages
{
    public class PrivateMessageDone : IPrivateMessageDone
    {
        private readonly IMahuaApi _mahuaApi;
        private readonly IAmandaMessage _message;
        private readonly IAmandaApi _amandaApi;

        public PrivateMessageDone(
            IMahuaApi mahuaApi,
            IAmandaMessage message,
            IAmandaApi amandaApi)
        {
            _mahuaApi = mahuaApi;
            _message = message;
            _amandaApi = amandaApi;
        }

        public void Done()
        {
            if (_message.Shake)
            {
                _amandaApi.Api_SendShake(_message.Target);
            }
            else
            {
                _mahuaApi.SendPrivateMessage(_message.Target, _message.GetMessage());
            }
        }
    }
}
