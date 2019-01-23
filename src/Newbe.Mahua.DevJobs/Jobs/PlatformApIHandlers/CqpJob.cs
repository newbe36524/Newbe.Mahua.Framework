using System.IO;
using System.Text;
using System.Threading.Tasks;
using Newbe.Mahua.NativeApiClassfy.Services;

namespace Newbe.Mahua.NativeApiClassfy.Jobs.PlatformApIHandlers
{
    public class CqpJob : IJob
    {
        private readonly IApiHandlerGenerator _apiHandlerGenerator;
        private readonly INativeApiInfoProvider _nativeApiInfoProvider;

        public CqpJob(
            IApiHandlerGenerator apiHandlerGenerator,
            INativeApiInfoProvider nativeApiInfoProvider)
        {
            _apiHandlerGenerator = apiHandlerGenerator;
            _nativeApiInfoProvider = nativeApiInfoProvider;
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

            File.WriteAllText("../Newbe.Mahua.CQP/CqpMahuaApiHandler.cs",
                CodeFormatter.FormatCode(apiHandler),
                Encoding.UTF8);
            return Task.CompletedTask;
        }
    }
}