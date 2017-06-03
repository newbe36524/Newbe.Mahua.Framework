namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// 机器人平台退出
    /// </summary>
    public interface IPlatfromExitedMahuaEvent : IMahuaEvent
    {
        /// <summary>
        /// 机器人平台退出
        /// </summary>
        /// <param name="context"></param>
        void Exited(PlatfromExitedContext context);
    }

    public class PlatfromExitedContext
    {
    }
}