using System.IO;
using System.Text;
using System.Threading.Tasks;
using Newbe.Mahua.NativeApiClassfy.Services;

namespace Newbe.Mahua.NativeApiClassfy.Jobs.PlatformApIHandlers
{
    public class CqpJob : IJob
    {
        private readonly ISourceFileProvider _sourceFileProvider;
        private readonly IApiHandlerGenerator _apiHandlerGenerator;
        private readonly INativeApiInfoProvider _nativeApiInfoProvider;

        public CqpJob(
            IApiHandlerGenerator apiHandlerGenerator,
            INativeApiInfoProvider nativeApiInfoProvider,
            ISourceFileProvider sourceFileProvider)
        {
            _apiHandlerGenerator = apiHandlerGenerator;
            _nativeApiInfoProvider = nativeApiInfoProvider;
            _sourceFileProvider = sourceFileProvider;
        }

        public Task Run()
        {
            var nativeApiInfo = _nativeApiInfoProvider.Get(MahuaPlatform.Cqp);
            var apiHandler = _apiHandlerGenerator.Generate(new ApiHandlerGeneratorInput
            {
                Namespace = "Newbe.Mahua.CQP",
                NativeApiInfo = nativeApiInfo,
                ApiOutBaseName = "CqpApiOutput",
                ApiHandlerClassName = "CqpMahuaApiHandler",
                AuthCodeContainerInterfaceName = "ICqpAuthCodeContainer",
            });

            var filename = Path.Combine(_sourceFileProvider.GetBasePath(),
                "Newbe.Mahua.CQP/CqpMahuaApiHandler.cs");
            File.WriteAllText(filename,
                CodeFormatter.FormatCode(apiHandler),
                Encoding.UTF8);

            return Task.CompletedTask;
        }
    }
}