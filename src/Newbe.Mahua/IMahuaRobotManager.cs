namespace Newbe.Mahua
{
    /// <summary>
    /// 机器人实例管理器
    /// </summary>
    public interface IMahuaRobotManager
    {
        /// <summary>
        /// 创建会话
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// 多QQ机器人平台则返回第一个QQ
        /// </remarks>
        IRobotSession CreateSession();

        /// <summary>
        /// 创建会话
        /// </summary>
        /// <param name="qq">指定的QQ机器人</param>
        /// <returns></returns>
        /// <exception cref="QqNotFoundException">指定的QQ不存在</exception>
        IRobotSession CreateSession(string qq);
    }
}
