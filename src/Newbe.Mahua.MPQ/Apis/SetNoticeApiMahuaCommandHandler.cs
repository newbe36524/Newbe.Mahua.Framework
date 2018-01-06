using Newbe.Mahua.Apis;
using Newbe.Mahua.MPQ.NativeApi;

namespace Newbe.Mahua.MPQ.Apis
{
    public class SetNoticeApiMahuaCommandHandler
        : MpqApiMahuaCommandHandlerBase<SetNoticeApiMahuaCommand>
    {
        public SetNoticeApiMahuaCommandHandler(
            IMpqApi mpqApi,
            IQqSession qqSession,
            IEventFunOutput eventFunOutput)
            : base(mpqApi, qqSession, eventFunOutput)
        {
        }

        public override void Handle(SetNoticeApiMahuaCommand message)
        {
            MpqApi.Api_SetNotice(CurrentQq, message.ToGroup, message.Title, message.Content);
        }
    }
}
