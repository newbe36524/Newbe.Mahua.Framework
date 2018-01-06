using Newbe.Mahua.Apis;
using Newbe.Mahua.MPQ.NativeApi;

namespace Newbe.Mahua.MPQ.Apis
{
    public class KickDiscussMemberApiMahuaCommandHandler
        : MpqApiMahuaCommandHandlerBase<KickDiscussMemberApiMahuaCommand>
    {
        public KickDiscussMemberApiMahuaCommandHandler(
            IMpqApi mpqApi,
            IQqSession qqSession,
            IEventFunOutput eventFunOutput)
            : base(mpqApi, qqSession, eventFunOutput)
        {
        }

        public override void Handle(KickDiscussMemberApiMahuaCommand message)
        {
            MpqApi.Api_KickDG(CurrentQq, message.ToQq, message.ToDiscuss);
        }
    }
}
