using Newbe.Mahua.Messages.Steps;
using Newbe.Mahua.MPQ.NativeApi;
using System.IO;
using System.Linq;

namespace Newbe.Mahua.MPQ.Messages
{
    public class PrivateMessageDone : IPrivateMessageDone
    {
        private readonly IMahuaApi _mahuaApi;
        private readonly IMpqMessage _message;
        private readonly IMpqApi _mpqApi;
        private readonly IQqSession _qqSession;

        public PrivateMessageDone(
            IMahuaApi mahuaApi,
            IMpqMessage message,
            IMpqApi mpqApi,
            IQqSession qqSession)
        {
            _mahuaApi = mahuaApi;
            _message = message;
            _mpqApi = mpqApi;
            _qqSession = qqSession;
        }

        public void Done()
        {
            if (_message.Shake)
            {
                _mpqApi.Api_SendShake(_qqSession.CurrentQq, _message.Target);
            }
            else
            {
                var msg = _message.GetMessage();
                if (_message.Images.Any())
                {
                    _message.Images.Upload(file =>
                        _mpqApi.Api_UploadPic(
                            _qqSession.CurrentQq,
                            1,
                            _message.Target,
                            File.ReadAllBytes(file)));
                    msg = _message.Images.Formate(msg);
                }
                _mahuaApi.SendPrivateMessage(_message.Target, msg);
            }
        }
    }
}
