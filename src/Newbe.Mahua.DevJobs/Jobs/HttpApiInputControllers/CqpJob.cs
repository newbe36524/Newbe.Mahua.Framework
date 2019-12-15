using System.IO;
using System.Text;
using System.Threading.Tasks;
using Newbe.Mahua.NativeApiClassfy.Services;

namespace Newbe.Mahua.NativeApiClassfy.Jobs.HttpApiInputControllers
{
    public class CqpJob : IJob
    {
        private readonly ISourceFileProvider _sourceFileProvider;
        private readonly INativeApiInfoProvider _nativeApiInfoProvider;
        private readonly IHttpApiInputModelsGenerator _httpApiInputModelsGenerator;

        public CqpJob(
            INativeApiInfoProvider nativeApiInfoProvider,
            IHttpApiInputModelsGenerator httpApiInputModelsGenerator,
            ISourceFileProvider sourceFileProvider)
        {
            _nativeApiInfoProvider = nativeApiInfoProvider;
            _httpApiInputModelsGenerator = httpApiInputModelsGenerator;
            _sourceFileProvider = sourceFileProvider;
        }

        public Task Run()
        {
            var nativeApiInfo = _nativeApiInfoProvider.Get(MahuaPlatform.Cqp);
            var nativeApiIn = _httpApiInputModelsGenerator.Generate(new HttpApiInputModelsGeneratorInput
            {
                NativeApiInfo = nativeApiInfo,
                MahuaPlatform = MahuaPlatform.Cqp,
                SkipProperties = new[] {"AuthCode"},
            });
            var code = CodeFormatter.FormatCode(nativeApiIn);
            var filename = Path.Combine(_sourceFileProvider.GetBasePath(),
                "Newbe.Mahua.InputReceivers.HttpApi/Services/Controllers/CqpController.cs");
            File.WriteAllText(filename,
                code,
                Encoding.UTF8);
            return Task.CompletedTask;
        }
    }
}