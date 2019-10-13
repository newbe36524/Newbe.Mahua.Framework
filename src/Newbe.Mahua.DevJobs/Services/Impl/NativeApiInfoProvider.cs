using System;
using System.Collections.Concurrent;
using System.IO;

namespace Newbe.Mahua.NativeApiClassfy.Services.Impl
{
    public class NativeApiInfoProvider : INativeApiInfoProvider
    {
        private readonly INativeApiInfoResolver _nativeApiInfoResolver;

        public NativeApiInfoProvider(
            INativeApiInfoResolver nativeApiInfoResolver)
        {
            _nativeApiInfoResolver = nativeApiInfoResolver;
        }

        ConcurrentDictionary<MahuaPlatform, NativeApiInfo> Cache =
            new ConcurrentDictionary<MahuaPlatform, NativeApiInfo>();

        public NativeApiInfo Get(MahuaPlatform mahuaPlatform)
        {
            var re = Cache.GetOrAdd(mahuaPlatform, ResolveNativeApiInfo);
            return re;
        }

        private NativeApiInfo ResolveNativeApiInfo(MahuaPlatform mahuaPlatform)
        {
            string filename;
            switch (mahuaPlatform)
            {
                case MahuaPlatform.Cqp:
                    filename = "../Newbe.Mahua/NativeApi/ICqpApi.cs";
                    break;
                case MahuaPlatform.Mpq:
                    filename = "../Newbe.Mahua/NativeApi/IMpqApi.cs";
                    break;
                case MahuaPlatform.QQLight:
                    filename = "../Newbe.Mahua/NativeApi/IQQLightApi.cs";
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(mahuaPlatform), mahuaPlatform, null);
            }

            var apiSourceFile = File.ReadAllText(filename);
            var nativeApiInfo = _nativeApiInfoResolver.GetMahuaApiInfo(apiSourceFile);
            return nativeApiInfo;
        }
    }
}