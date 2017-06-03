using System;
using Newbe.Mahua.MahuaEvents;

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
            _mahuaApi.SendPrivateMessage(context.FromQq, context.Message);
        }
    }
}