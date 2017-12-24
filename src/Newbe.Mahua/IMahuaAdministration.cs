using Autofac;

namespace Newbe.Mahua
{
    /// <summary>
    /// 设置中心接口
    /// </summary>
    public interface IMahuaAdministration
    {
        /// <summary>
        /// 打开设置中心
        /// </summary>
        /// <param name="lifetimeScope"></param>
        void Show(ILifetimeScope lifetimeScope);
    }
}
