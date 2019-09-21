using System;
using System.ComponentModel;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// 机器人平台退出事件
    /// </summary>
    [Obsolete("该事件由于拼写错误，将在下一个 breaking change 的版本中移除，请改用 IPlatformExitedMahuaEvent Newbe36524 2019年9月21日20:22:41")]
    [Description("机器人平台退出事件")]
    public interface IPlatfromExitedMahuaEvent : IMahuaEvent
    {
        /// <summary>
        /// 处理事件
        /// </summary>
        /// <param name="context"></param>
        void Exited(PlatfromExitedContext context);
    }

    /// <summary>
    /// 事件上下文
    /// </summary>
    [Obsolete("该事件由于拼写错误，将在下一个 breaking change 的版本中移除，请改用 IPlatformExitedMahuaEvent Newbe36524 2019年9月21日20:22:41")]
    public class PlatfromExitedContext
    {
    }
}