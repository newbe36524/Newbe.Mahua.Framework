using Newbe.Mahua.Apis;
using Newbe.Mahua.CleverQQ.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class SetNoticeApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<SetNoticeApiMahuaCommand>
    {
        public SetNoticeApiMahuaCommandHandler(
            ICleverQQApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIrEventOutput eventFunOutput)
            : base(cleverqqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(SetNoticeApiMahuaCommand message)
        {
            CleverQQApi.Api_PBGroupNotic(CurrentQq, message.ToGroup, message.Title, message.Content);
        }
    }
}
