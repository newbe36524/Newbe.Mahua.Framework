using System.ComponentModel;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// 插件初始化事件
    /// </summary>
    [Description("插件初始化事件")]
    public interface IInitializationMahuaEvent : IMahuaEvent
    {
        /// <summary>
        /// 初始化插件
        /// </summary>
        /// <param name="context"></param>
        void Initialized(InitializedContext context);
    }

    /// <summary>
    /// 初始化插件
    /// </summary>
    public class InitializedContext
    {
    }
}