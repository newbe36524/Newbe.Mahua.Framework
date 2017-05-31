using System;
using Newbe.Mahua.Framework;
using Newbe.Mahua.Framework.MahuaEvents;

namespace Newbe.Mahua.Plugins.Parrot
{
    public class PrivateMessageReceivedMahuaEvent : IPrivateMessageReceivedMahuaEvent
    {
        private readonly IMahuaApi _mahuaApi;

        public PrivateMessageReceivedMahuaEvent(IMahuaApi mahuaApi)
        {
            _mahuaApi = mahuaApi;
        }

        void IPrivateMessageReceivedMahuaEvent.ProcessPrivateMessage(PrivateMessageReceivedContext context)
        {
            _mahuaApi.SendPrivateMsg(context.FromQq, context.Message);
        }
    }
}