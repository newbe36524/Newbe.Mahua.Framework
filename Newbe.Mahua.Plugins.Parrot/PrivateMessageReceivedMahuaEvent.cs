using System;
using Newbe.Mahua.Framework;
using Newbe.Mahua.Framework.MahuaEvents;
using Newbe.Mahua.Framework.MahuaEvents.Enums;

namespace Newbe.Mahua.Plugins.Parrot
{
    public class PrivateMessageReceivedMahuaEvent : IPrivateMessageReceivedMahuaEvent
    {
        private readonly IMahuaApi _mahuaApi;

        public PrivateMessageReceivedMahuaEvent(IMahuaApi mahuaApi)
        {
            _mahuaApi = mahuaApi;
        }

        void IPrivateMessageReceivedMahuaEvent.ProcessPrivateMessage(PrivateMessageFromType subType, DateTime sendTime,
            long fromQq, string msg)
        {
            throw new NotImplementedException();
        }
    }
}