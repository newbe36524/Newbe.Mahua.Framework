using Newbe.Mahua.Messages.Steps;
using Newbe.Mahua.MPQ.NativeApi;
using System.IO;
using System.Linq;

namespace Newbe.Mahua.MPQ.Messages
{
    public class GroupMessageDone : IGroupMessageDone
    {
        private readonly IMahuaApi _mahuaApi;
        private readonly IMpqMessage _message;
        private readonly IMpqApi _mpqApi;
        private readonly IQqSession _qqSession;

        public GroupMessageDone(
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
            var msg = _message.GetMessage();
            if (_message.Images.Any())
            {
                _message.Images.Upload(file =>
                    _mpqApi.Api_UploadPic(
                        _qqSession.CurrentQq,
                        2,
                        _message.Target,
                        File.ReadAllBytes(file)));
                msg = _message.Images.Formate(msg);
            }
            _mahuaApi.SendGroupMessage(_message.Target, msg);
        }
    }
}
