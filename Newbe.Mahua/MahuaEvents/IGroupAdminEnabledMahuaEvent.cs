using System;
using System.ComponentModel;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// 任命新管理员事件
    /// </summary>
    [Description("任命新管理员事件")]
    public interface IGroupAdminEnabledMahuaEvent : IMahuaEvent
    {
        /// <summary>
        /// 处理事件
        /// </summary>
        /// <param name="context"></param>
        void ProcessGroupAdminEnabled(GroupAdminEnabledContext context);
    }

    /// <summary>
    /// 事件上下文
    /// </summary>
    public class GroupAdminEnabledContext
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
        /// 被任命为管理员的QQ
        /// </summary>
        public string ToQq { get; set; }
    }
}