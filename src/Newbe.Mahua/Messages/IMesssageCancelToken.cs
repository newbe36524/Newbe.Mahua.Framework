using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newbe.Mahua.Messages
{
    public interface IMessageCancelToken
    {
        /// <summary>
        /// 消息ID
        /// </summary>
        long MessageId { get; set; }

        /// <summary>
        /// 目标ID(私聊对象QQ号,群号,讨论组名称)
        /// </summary>
        string TargetId { get; set; }

        /// <summary>
        /// 消息类型
        /// </summary>
        int MessageType { get; set; }

        void Cancel();
    }
}
