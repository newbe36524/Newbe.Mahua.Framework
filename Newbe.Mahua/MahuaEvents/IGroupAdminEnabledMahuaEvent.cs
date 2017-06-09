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
        void ProcessGroupAdminEnabled(GroupAdminEnabledContext context);
    }

    public class GroupAdminEnabledContext
    {
        public DateTime SendTime { get; set; }
        public string FromGroup { get; set; }
        public string ToQq { get; set; }
    }
}