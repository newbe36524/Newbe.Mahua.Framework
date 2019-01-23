using System.IO;
using System.Text;
using System.Threading.Tasks;
using Newbe.Mahua.NativeApiClassfy.Services;

namespace Newbe.Mahua.NativeApiClassfy.Jobs.HttpApiInputControllers
{
    public class MpqJob : IJob
    {
        private readonly INativeApiInfoProvider _nativeApiInfoProvider;
        private readonly IHttpApiInputModelsGenerator _httpApiInputModelsGenerator;

        public MpqJob(
            IHttpApiInputModelsGenerator httpApiInputModelsGenerator,
            INativeApiInfoProvider nativeApiInfoProvider)
        {
            _httpApiInputModelsGenerator = httpApiInputModelsGenerator;
            _nativeApiInfoProvider = nativeApiInfoProvider;
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
            File.WriteAllText("../Newbe.Mahua.InputReceivers.HttpApi/Services/Controllers/MpqController.cs",
                code,
                Encoding.UTF8);

            return Task.CompletedTask;
        }
    }
}