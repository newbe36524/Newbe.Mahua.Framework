using System.IO;
using System.Text;
using System.Threading.Tasks;
using Newbe.Mahua.NativeApiClassfy.Services;

namespace Newbe.Mahua.NativeApiClassfy.Jobs.HttpApiInputControllers
{
    public class QQLightJob : IJob
    {
        private readonly ISourceFileProvider _sourceFileProvider;
        private readonly INativeApiInfoProvider _nativeApiInfoProvider;
        private readonly IHttpApiInputModelsGenerator _httpApiInputModelsGenerator;

        public QQLightJob(
            IHttpApiInputModelsGenerator httpApiInputModelsGenerator,
            INativeApiInfoProvider nativeApiInfoProvider,
            ISourceFileProvider sourceFileProvider)
        {
            _httpApiInputModelsGenerator = httpApiInputModelsGenerator;
            _nativeApiInfoProvider = nativeApiInfoProvider;
            _sourceFileProvider = sourceFileProvider;
        }

        public Task Run()
        {
            var nativeApiInfo = _nativeApiInfoProvider.Get(MahuaPlatform.QQLight);
            var nativeApiIn = _httpApiInputModelsGenerator.Generate(new HttpApiInputModelsGeneratorInput
            {
                NativeApiInfo = nativeApiInfo,
                MahuaPlatform = MahuaPlatform.QQLight,
                SkipProperties = new[] {"AuthCode"},
            });
            var code = CodeFormatter.FormatCode(nativeApiIn);
            var filename = Path.Combine(_sourceFileProvider.GetBasePath(),
                "Newbe.Mahua.InputReceivers.HttpApi/Services/Controllers/QQLightController.cs");
            File.WriteAllText(filename,
                code,
                Encoding.UTF8);

            return Task.CompletedTask;
        }
    }
}