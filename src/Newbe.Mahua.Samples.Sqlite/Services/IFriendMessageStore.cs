using System;
using System.Threading.Tasks;

namespace Newbe.Mahua.Samples.Sqlite.Services
{
    /// <summary>
    /// 好友消息存储
    /// </summary>
    public interface IFriendMessageStore
    {
        /// <summary>
        /// 获取消息数量
        /// </summary>
        /// <returns></returns>
        Task<int> GetCountAsync();

        /// <summary>
        /// 保存好友消息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task InsertAsync(InsertFriendMessageInput input);
    }

    public class InsertFriendMessageInput
    {
        /// <summary>
        /// QQ
        /// </summary>
        public string Qq { get; set; }

        /// <summary>
        /// 消息内容
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 收到消息的事件
        /// </summary>
        public DateTimeOffset ReceivedTime { get; set; }
    }
}
