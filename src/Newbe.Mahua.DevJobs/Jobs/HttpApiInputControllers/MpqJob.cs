using System.IO;
using System.Text;
using System.Threading.Tasks;
using Newbe.Mahua.NativeApiClassfy.Services;

namespace Newbe.Mahua.NativeApiClassfy.Jobs.HttpApiInputControllers
{
    public class MpqJob : IJob
    {
        private readonly ISourceFileProvider _sourceFileProvider;
        private readonly INativeApiInfoProvider _nativeApiInfoProvider;
        private readonly IHttpApiInputModelsGenerator _httpApiInputModelsGenerator;

        public MpqJob(
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
            var nativeApiInfo = _nativeApiInfoProvider.Get(MahuaPlatform.Mpq);
            var nativeApiIn = _httpApiInputModelsGenerator.Generate(new HttpApiInputModelsGeneratorInput
            {
                NativeApiInfo = nativeApiInfo,
                MahuaPlatform = MahuaPlatform.Mpq
            });
            var code = CodeFormatter.FormatCode(nativeApiIn);
            var filename = Path.Combine(_sourceFileProvider.GetBasePath(),
                "Newbe.Mahua.InputReceivers.HttpApi/Services/Controllers/MpqController.cs");
            File.WriteAllText(filename,
                code,
                Encoding.UTF8);

            return Task.CompletedTask;
        }
    }
}