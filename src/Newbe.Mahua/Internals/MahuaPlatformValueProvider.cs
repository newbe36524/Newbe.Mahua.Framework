using System;
using System.IO;
using System.Linq;

namespace Newbe.Mahua.Internals
{
    /// <summary>
    /// 当前插件平台信息读取
    /// </summary>
    internal static class MahuaPlatformValueProvider
    {
        internal static readonly Lazy<MahuaPlatform> CurrentPlatform =
            new Lazy<MahuaPlatform>(() =>
            {
                var mahuaPlatform = new IPlatformResolver[]
                    {
                        new CqpPlatformResolver(),
                        new MpqPlatformResolver(),
                        new AmandaPlatformResolver(),
                        new QqLightPlatformResolver(),
                        new CleverQQPlatformResolver()
                    }
                    .FirstOrDefault(x => x.IsThis())?.MahuaPlatform;
                if (mahuaPlatform == null)
                {
                    throw new NotSupportMahuaPlatformException();
                }
                return mahuaPlatform.Value;
            });

        private static string GetCurrentDir() => Environment.CurrentDirectory;

        #region IPlatformResolver

        private class CqpPlatformResolver : IPlatformResolver
        {
            public MahuaPlatform MahuaPlatform { get; } = MahuaPlatform.Cqp;

            public bool IsThis()
            {
                var currentDir = GetCurrentDir();
                return File.Exists(Path.Combine(currentDir, "CQA.exe")) ||
                       File.Exists(Path.Combine(currentDir, "CQP.exe"));
            }
        }

        private class MpqPlatformResolver : IPlatformResolver
        {
            public MahuaPlatform MahuaPlatform { get; } = MahuaPlatform.Mpq;

            public bool IsThis()
            {
                var currentDir = GetCurrentDir();
                return File.Exists(Path.Combine(currentDir, "Core.exe"));
            }
        }

        private class AmandaPlatformResolver : IPlatformResolver
        {
            public MahuaPlatform MahuaPlatform { get; } = MahuaPlatform.Amanda;

            public bool IsThis()
            {
                var currentDir = GetCurrentDir();
                return File.Exists(Path.Combine(currentDir, "Amanda.exe"));
            }
        }

       	private class CleverQQPlatformResolver : IPlatformResolver
        {
            public MahuaPlatform MahuaPlatform { get; } = MahuaPlatform.CleverQQ;

            public bool IsThis()
            {
                var currentDir = GetCurrentDir();
                return File.Exists(Path.Combine(currentDir, "CleverQQ Pro.exe"));
            }
        }
        
   	private class QqLightPlatformResolver : IPlatformResolver
        {
            public MahuaPlatform MahuaPlatform { get; } = MahuaPlatform.QqLight;

            public bool IsThis()
            {
                var currentDir = GetCurrentDir();
                return File.Exists(Path.Combine(currentDir, "QQLight.exe"));
            }
        }


        #endregion
    }
}
