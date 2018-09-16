using Newbe.Mahua.Messages.Steps;
using System.IO;
using System.Linq;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CleverQQ.Messages
{
    public class DiscussMessageDone : IDiscussMessageDone
    {
        private readonly IMahuaApi _mahuaApi;
        private readonly ICleverQQMessage _message;
        private readonly ICleverQqApi _cleverqqApi;
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
            _mahuaApi.SendPrivateMessage(_message.Target, msg);
        }
    }
}
