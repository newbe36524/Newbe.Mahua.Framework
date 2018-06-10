using System.ComponentModel;
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
        /// 调用不受支持的Api的行为。默认为<see cref="ThrowsNotSupportedMahuaApiConvertion{NotSupportMahuaPlatformExpcetion}"/>
        /// </summary>
        public static INotSupportedMahuaApiConvertion NotSupportedMahuaApiConvertion { get; set; } =
            MahuaConvertions.NotSupportedMahuaApiConvertions
                .GetThrowsNotSupportedMahuaApiConvertion<NotSupportMahuaPlatformException>();

        /// <summary>
        /// 调用不受支持的MessageBuilder的行为。默认为<see cref="IgnoreNotSupportedMessageBuilderConvertion"/>
        /// </summary>
        public static INotSupportedMessageBuilderConvertion NotSupportedMessageBuilderConvertion { get; set; } =
            MahuaConvertions.NotSupportedMessageBuilderConvertions.IgnoreNotSupportedMessageBuilderConvertion;

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
            /// 启用诊断，默认为false
            /// </summary>
            [DefaultValue(false)]
            public static bool EnableDiagnostics { get; set; }
        }

        /// <summary>
        /// 默认API的作者名称
        /// </summary>
        public static string DefaultApiHandlerAuthorName => "Newbe";

        /// <summary>
        /// 生命周期，详细见 Autofac相关文档，http://autofac.readthedocs.io/en/latest/lifetime/working-with-scopes.html
        /// </summary>
        public static class LifeTimeScopes
        {
            /// <summary>
            /// RobotSession生命周期的范围
            /// </summary>
            public static readonly string RobotSession = "RobotSession";
        }
    }
}
