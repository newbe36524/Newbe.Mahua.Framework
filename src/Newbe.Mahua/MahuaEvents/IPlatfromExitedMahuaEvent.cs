using System.ComponentModel;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// 机器人平台退出事件
    /// </summary>
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
    public class PlatfromExitedContext
    {
    }
}