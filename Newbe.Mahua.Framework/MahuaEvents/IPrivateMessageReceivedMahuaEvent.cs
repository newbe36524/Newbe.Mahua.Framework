namespace Newbe.Mahua.Framework.MahuaEvents
{
    /// <summary>
    /// 接受到私聊消息
    /// </summary>
    public interface IPrivateMessageReceivedMahuaEvent : IMahuaEvent
    {
        void ProcessPrivateMessage(int subType, int sendTime, long fromQQ, string msg, int font);
    }
}