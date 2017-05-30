namespace Newbe.Mahua.Framework.MahuaEvents
{
    public interface IPrivateMessageReceivedMahuaEvent : IMahuaEvent
    {
        void ProcessPrivateMessage(int subType, int sendTime, long fromQQ, string msg, int font);
    }
}