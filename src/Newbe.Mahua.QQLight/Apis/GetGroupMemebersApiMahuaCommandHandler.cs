using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class GetGroupMemebersApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<GetGroupMemebersApiMahuaCommand, GetGroupMemebersApiMahuaCommandResult>
    {
        public GetGroupMemebersApiMahuaCommandHandler(
            IQqLightApi QqLightApi)
            : base(QqLightApi)
        {
        }

        public override GetGroupMemebersApiMahuaCommandResult Handle(GetGroupMemebersApiMahuaCommand message)
        {
            var groupMemebersString = QqLightApi.Api_GetGroupMemberList(message.ToGroup);
            var re = new GetGroupMemebersApiMahuaCommandResult
            {
                GroupMemebersString = groupMemebersString
            };
            return re;
        }
    }
}
