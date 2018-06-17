using Newbe.Mahua.MahuaEvents;

namespace Newbe.Mahua.Samples.OkexRobot.MahuaEvents
{
    public class GetMenuEvent : MasterPrivateMessageEventBase
    {
        public GetMenuEvent(IMahuaApi mahuaApi) : base(mahuaApi)
        {
        }

        public override void HandleCore(PrivateMessageReceivedContext context)
        {
            MahuaApi.SendPrivateMessage(context.FromQq)
                .Text("0:Get Menu").Newline()
                .Text("1:Get Asset").Newline()
                .Text("2:Get Orders")
                .Done();
        }

        public override string MenuCode => "0";
    }
}
