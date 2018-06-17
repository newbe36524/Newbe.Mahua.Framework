using Newbe.Mahua.MahuaEvents;
using Newbe.Mahua.Samples.OkexRobot.Common;

namespace Newbe.Mahua.Samples.OkexRobot.MahuaEvents
{
    public abstract class MasterPrivateMessageEventBase : IPrivateMessageReceivedMahuaEvent
    {
        public IMahuaApi MahuaApi { get; }

        protected MasterPrivateMessageEventBase(
            IMahuaApi mahuaApi)
        {
            MahuaApi = mahuaApi;
        }

        public void ProcessPrivateMessage(PrivateMessageReceivedContext context)
        {
            if (context.FromQq == SystemOptions.Instance.MasterQq)
            {
                const string prefix = "ok#";
                if (context.Message.StartsWith(prefix))
                {
                    if (MenuCode == context.Message.Substring(prefix.Length))
                    {
                        HandleCore(context);
                    }
                }
            }
        }

        public abstract void HandleCore(PrivateMessageReceivedContext context);
        public abstract string MenuCode { get; }
    }
}
