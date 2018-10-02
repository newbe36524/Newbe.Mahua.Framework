namespace Newbe.Mahua.Messages.CancelMessage
{
    /// <summary>
    /// 撤回消息使用的令牌
    /// </summary>
    public interface IMessageCancelToken
    {
        /// <summary>
        /// 撤回该令牌对应的消息
        /// </summary>
        void Cancel();
    }
}
