namespace Newbe.Mahua.MPQ
{
    public class EventFunInput
    {
        /// <summary>
        /// 被邀请入群事件下该值为1时即对象为不良成员
        /// </summary>
        public int EventAdditionType { get; set; }

        /// <summary>
        /// 信息的源头  群号,好友QQ,讨论组ID,临时会话对象QQ等
        /// </summary>
        public string FromNum { get; set; }

        /// <summary>
        /// 主动触发这条信息的对象 T人时为T人的管理员QQ
        /// </summary>
        public string EventOperator { get; set; }

        /// <summary>
        /// 被动接受这条信息的对象 T人时为被T对象的QQ
        /// </summary>
        public string Triggee { get; set; }

        /// <summary>
        /// 视情况而定的信息内容  申请入群时为入群理由,添加好友为附加信息,T人之类的为空
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 经过解密后的封包字节数据或json结构信息
        /// </summary>
        public string RawMessage { get; set; }
    }
}
