using Newbe.Mahua.Apis;
using Newbe.Mahua.MPQ.NativeApi;

namespace Newbe.Mahua.MPQ.Apis
{
    public class JoinGroupApiMahuaCommandHandler
        : MpqApiMahuaCommandHandlerBase<JoinGroupApiMahuaCommand>
    {
        public JoinGroupApiMahuaCommandHandler(
            IMpqApi mpqApi,
            IQqSession qqSession,
            IEventFunOutput eventFunOutput)
            : base(mpqApi, qqSession, eventFunOutput)
        {
        }

        public override void Handle(JoinGroupApiMahuaCommand message)
        {
            MpqApi.Api_JoinGroup(CurrentQq, message.ToGroup, message.Reason);
        }
    }
}
