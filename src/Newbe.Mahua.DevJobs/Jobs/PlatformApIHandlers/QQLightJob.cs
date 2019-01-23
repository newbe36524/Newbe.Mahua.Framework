using System.IO;
using System.Text;
using System.Threading.Tasks;
using Newbe.Mahua.NativeApiClassfy.Services;

namespace Newbe.Mahua.NativeApiClassfy.Jobs.PlatformApIHandlers
{
    public class QQLightJob : IJob
    {
        private readonly IApiHandlerGenerator _apiHandlerGenerator;
        private readonly INativeApiInfoProvider _nativeApiInfoProvider;

        public QQLightJob(
            IApiHandlerGenerator apiHandlerGenerator,
            INativeApiInfoProvider nativeApiInfoProvider)
        {
            _apiHandlerGenerator = apiHandlerGenerator;
            _nativeApiInfoProvider = nativeApiInfoProvider;
        }

        public Task Run()
        {
            var nativeApiInfo = _nativeApiInfoProvider.Get(MahuaPlatform.QQLight);
            var apiHandler = _apiHandlerGenerator.Generate(new ApiHandlerGeneratorInput
            {
                Namespace = "Newbe.Mahua.QQLight",
                NativeApiInfo = nativeApiInfo,
                ApiOutBaseName = "QQLightApiOutput",
                ApiHandlerClassName = "QQLightMahuaApiHandler",
                AuthCodeContainerInterfaceName = "IQqLightAuthCodeContainer",
            });

            File.WriteAllText("../Newbe.Mahua.QQLight/QQLightMahuaApiHandler.cs",
                CodeFormatter.FormatCode(apiHandler),
                Encoding.UTF8);
            return Task.CompletedTask;
        }
    }
}