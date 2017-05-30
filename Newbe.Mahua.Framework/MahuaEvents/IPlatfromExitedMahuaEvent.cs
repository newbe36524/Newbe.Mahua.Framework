namespace Newbe.Mahua.Framework.MahuaEvents
{
    /// <summary>
    /// 机器人平台退出
    /// </summary>
    public interface IPlatfromExitedMahuaEvent : IMahuaEvent
    {
        /// <summary>
        /// 机器人平台退出
        /// </summary>
        void Exited();
    }
}