using System;
using System.ComponentModel;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// 群文件上传事件
    /// </summary>
    [Description("群文件上传事件")]
    public interface IGroupUploadedMahuaEvent : IMahuaEvent
    {
        /// <summary>
        /// 处理事件
        /// </summary>
        /// <param name="context"></param>
        void ProcessGroupUploaded(GroupUploadedContext context);
    }

    /// <summary>
    /// 事件上下文
    /// </summary>
    public class GroupUploadedContext
    {
        /// <summary>
        /// 事件时间
        /// </summary>
        public DateTime SendTime { get; set; }

        /// <summary>
        /// 事件所属群
        /// </summary>
        public string FromGroup { get; set; }

        /// <summary>
        /// 上传者QQ
        /// </summary>
        public string FromQq { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        public string File { get; set; }
    }
}