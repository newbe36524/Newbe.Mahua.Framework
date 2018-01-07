using Autofac;
using System.ComponentModel;

namespace Newbe.Mahua
{
    public interface IContainerSaver
    {
        /// <summary>
        /// 获取当前上下文运行的容器
        /// </summary>
        /// <returns></returns>
        [Description("获取当前上下文运行的容器")]
        ILifetimeScope GetLifetimeScope();

        /// <summary>
        /// 设置当前上下文运行的容器
        /// </summary>
        /// <param name="container"></param>
        [Description("设置当前上下文运行的容器")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        void SetLifetimeScope(ILifetimeScope container);

        /// <summary>
        /// 获取全局的容器
        /// </summary>
        /// <returns></returns>
        [Description("获取全局的容器")]
        Autofac.IContainer GetSourceContainer();

        /// <summary>
        /// 设置全局的容器
        /// </summary>
        /// <param name="container"></param>
        [Description("设置全局的容器")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        void SetSourceContainer(Autofac.IContainer container);
    }
}
