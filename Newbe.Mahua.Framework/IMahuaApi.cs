namespace Newbe.Mahua.Framework
{
    public interface IMahuaApi
    {
        /// <summary>
        ///     发送好友消息
        /// </summary>
        /// <param name="qqId">目标QQ号</param>
        /// <param name="content">消息内容</param>
        /// <returns></returns>
        int SendPrivateMsg(long qqId, string content);
    }
}