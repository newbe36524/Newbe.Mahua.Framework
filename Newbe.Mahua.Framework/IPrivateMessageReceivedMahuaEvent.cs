namespace Newbe.Mahua.Framework
{
    public interface IPrivateMessageReceivedMahuaEvent : IMahuaEvent
    {
        void ProcessPrivateMessage(int subType, int sendTime, long fromQQ, string msg, int font);
    }
}