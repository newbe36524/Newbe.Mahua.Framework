using System;
using System.IO;
using System.Linq;

namespace Newbe.Mahua
{
    /// <summary>
    /// 全局信息
    /// </summary>
    public static class MahuaGlobal
    {
        // ReSharper disable once InconsistentNaming
        private static readonly Lazy<MahuaPlatform> currentPlatform =
            new Lazy<MahuaPlatform>(() =>
            {
                return new IPlatformResolver[]
                        {new CqpPlatformResolver(), new MpqPlatformResolver(), new AmandaPlatformResolver()}
                    .First(x => x.IsThis()).MahuaPlatform;
            });

        /// <summary>
        /// 当前机器人平台
        /// </summary>
        public static MahuaPlatform CurrentPlatform => currentPlatform.Value;

        private static string GetCurrentDir() => Environment.CurrentDirectory;

        #region IPlatformResolver

        internal interface IPlatformResolver
        {
            MahuaPlatform MahuaPlatform { get; }
            bool IsThis();
        }

        class CqpPlatformResolver : IPlatformResolver
        {
            public MahuaPlatform MahuaPlatform { get; } = MahuaPlatform.Cqp;

            public bool IsThis()
            {
                var currentDir = GetCurrentDir();
                return File.Exists(Path.Combine(currentDir, "CQA.exe")) ||
                       File.Exists(Path.Combine(currentDir, "CQP.exe"));
            }
        }

        class MpqPlatformResolver : IPlatformResolver
        {
            public MahuaPlatform MahuaPlatform { get; } = MahuaPlatform.Mpq;

            public bool IsThis()
            {
                var currentDir = GetCurrentDir();
                return File.Exists(Path.Combine(currentDir, "Core.exe"));
            }
        }

        class AmandaPlatformResolver : IPlatformResolver
        {
            public MahuaPlatform MahuaPlatform { get; } = MahuaPlatform.Amanda;

            public bool IsThis()
            {
                var currentDir = GetCurrentDir();
                return File.Exists(Path.Combine(currentDir, "Amanda.exe"));
            }
        }

        #endregion
    }
}