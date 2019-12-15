using System;
using System.Collections.Concurrent;
using System.IO;

namespace Newbe.Mahua.NativeApiClassfy.Services.Impl
{
    public class NativeApiInfoProvider : INativeApiInfoProvider
    {
        private readonly ISourceFileProvider _sourceFileProvider;
        private readonly INativeApiInfoResolver _nativeApiInfoResolver;

        public NativeApiInfoProvider(
            ISourceFileProvider sourceFileProvider,
            INativeApiInfoResolver nativeApiInfoResolver)
        {
            _sourceFileProvider = sourceFileProvider;
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
            var basePath = _sourceFileProvider.GetBasePath();
            var filePath = mahuaPlatform switch
            {
                MahuaPlatform.Cqp => "Newbe.Mahua/NativeApi/ICqpApi.cs",
                MahuaPlatform.Mpq => "Newbe.Mahua/NativeApi/IMpqApi.cs",
                MahuaPlatform.QQLight => "Newbe.Mahua/NativeApi/IQQLightApi.cs",
                MahuaPlatform.Amanda => throw new NotSupportedException(),
                MahuaPlatform.CleverQQ => throw new NotSupportedException(),
                _ => throw new ArgumentOutOfRangeException(nameof(mahuaPlatform), mahuaPlatform, null)
            };

            var filename = Path.Combine(basePath, filePath);

            var apiSourceFile = File.ReadAllText(filename);
            var nativeApiInfo = _nativeApiInfoResolver.GetMahuaApiInfo(apiSourceFile);
            return nativeApiInfo;
        }
    }
}