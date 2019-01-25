using Newbe.Mahua.Internals;

namespace Newbe.Mahua
{
    /// <summary>
    ///     全局信息
    /// </summary>
    public static class MahuaGlobal
    {
        /// <summary>
        ///     当前机器人平台
        /// </summary>
        /// <exception cref="NotSupportMahuaPlatformException"></exception>
        public static MahuaPlatform CurrentPlatform => MahuaPlatformValueProvider.CurrentPlatform.Value;
    }
}