using Newbe.Mahua.Internals;

namespace Newbe.Mahua
{
    /// <summary>
    /// 全局信息
    /// </summary>
    public static class MahuaGlobal
    {
        /// <summary>
        /// 当前机器人平台
        /// </summary>
        /// <exception cref="NotSupportMahuaPlatformException"></exception>
        public static MahuaPlatform CurrentPlatform => MahuaPlatformValueProvider.CurrentPlatform.Value;

        /// <summary>
        /// 调用标记为<see cref="NotSupportedMahuaApiAttribute"/>的Api的行为。默认为<see cref="ThrowsNotSupportedMahuaApiConvertion{NotSupportMahuaPlatformExpcetion}"/>
        /// </summary>
        public static INotSupportedMahuaApiConvertion NotSupportedMahuaApiConvertion { get; set; } =
            MahuaConvertions.NotSupportedMahuaApiConvertions
                .GetThrowsNotSupportedMahuaApiConvertion<NotSupportMahuaPlatformException>();

        /// <summary>
        /// 诊断
        /// </summary>
        public static class DiagnosticsConvertion
        {
            static DiagnosticsConvertion()
            {
#if DEBUG
                EnableDiagnostics = true;
#endif
#if !DEBUG
                EnableDiagnostics = false;
#endif
            }

            /// <summary>
            /// 启用诊断
            /// </summary>
            public static bool EnableDiagnostics { get; set; }
        }
    }
}
