namespace Newbe.Mahua
{
    /// <summary>
    /// 用于在后续的程序集中加载<see cref="Autofac.Module"/>模块
    /// </summary>
    public interface IMahuaModule
    {
        /// <summary>
        /// 返回需要注册的<see cref="Autofac.Module"/>模块
        /// </summary>
        /// <returns></returns>
        Autofac.Module[] GetModules();
    }
}
