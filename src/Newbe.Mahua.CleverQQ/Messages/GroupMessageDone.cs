using Newbe.Mahua.Messages.Steps;
using Newbe.Mahua.CleverQQ.NativeApi;
using System.IO;
using System.Linq;

namespace Newbe.Mahua.CleverQQ.Messages
{
    public class GroupMessageDone : IGroupMessageDone
    {
        private readonly IMahuaApi _mahuaApi;
        private readonly ICleverQQMessage _message;
        private readonly ICleverQQApi _cleverqqApi;
        private readonly IRobotSessionContext _robotSessionContext;

        public GroupMessageDone(
            IMahuaApi mahuaApi,
            ICleverQQMessage message,
            ICleverQQApi cleverqqApi,
            IRobotSessionContext robotSessionContext)
        {
            _mahuaApi = mahuaApi;
            _message = message;
            _cleverqqApi = cleverqqApi;
            _robotSessionContext = robotSessionContext;
        }

        public void Done()
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
            _mahuaApi.SendGroupMessage(_message.Target, msg);
        }
    }
}
