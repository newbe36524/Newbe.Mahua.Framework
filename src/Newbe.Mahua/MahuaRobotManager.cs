using System.ComponentModel;

namespace Newbe.Mahua
{
    /// <summary>
    /// 机器人实例管理器
    /// </summary>
    public static class MahuaRobotManager
    {
        public static IMahuaRobotManager Instance
        {
            get;
            [EditorBrowsable(EditorBrowsableState.Never)]
            set;
        }
    }
}
