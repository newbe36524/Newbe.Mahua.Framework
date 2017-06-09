using System;
using System.ComponentModel;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// 解除群管理员事件
    /// </summary>
    [Description("解除群管理员事件")]
    public interface IGroupAdminDisabledMahuaEvent : IMahuaEvent
    {
        void ProcessGroupAdminDisabled(GroupAdminDisabledContext context);
    }

    public class GroupAdminDisabledContext
    {
        public DateTime SendTime { get; set; }
        public string FromGroup { get; set; }
        public string ToQq { get; set; }
    }
}