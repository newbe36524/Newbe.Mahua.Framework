using System;
using Newbe.Mahua.Framework;

namespace Newbe.Mahua.Plugins.Parrot
{
    public class PrivateMessageReceivedMahuaEvent : IPrivateMessageReceivedMahuaEvent
    {
        private readonly IMahuaApi _mahuaApi;

        public PrivateMessageReceivedMahuaEvent(IMahuaApi mahuaApi)
        {
            _mahuaApi = mahuaApi;
        }

        void IPrivateMessageReceivedMahuaEvent.ProcessPrivateMessage(int subType, int sendTime, long fromQQ, string msg,
            int font)
        {
            _mahuaApi.SendPrivateMsg(fromQQ, msg);
        }
    }
}