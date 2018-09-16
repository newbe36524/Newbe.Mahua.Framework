using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class SetBanAllGroupMembersOptionApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<SetBanAllGroupMembersOptionApiMahuaCommand>
    {
        public SetBanAllGroupMembersOptionApiMahuaCommandHandler(
            ICleverQqApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIrEventOutput eventFunOutput)
            : base(cleverqqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(SetBanAllGroupMembersOptionApiMahuaCommand message)
        {
            CleverQQApi.Api_ShutUP(CurrentQq, message.ToGroup, null, 0);
        }
    }
}
