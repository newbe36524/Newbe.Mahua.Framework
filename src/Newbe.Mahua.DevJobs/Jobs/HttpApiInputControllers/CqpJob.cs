using System.IO;
using System.Text;
using System.Threading.Tasks;
using Newbe.Mahua.NativeApiClassfy.Services;

namespace Newbe.Mahua.NativeApiClassfy.Jobs.HttpApiInputControllers
{
    public class CqpJob : IJob
    {
        private readonly INativeApiInfoProvider _nativeApiInfoProvider;
        private readonly IHttpApiInputModelsGenerator _httpApiInputModelsGenerator;

        public CqpJob(
            INativeApiInfoProvider nativeApiInfoProvider,
            IHttpApiInputModelsGenerator httpApiInputModelsGenerator)
        {
            _nativeApiInfoProvider = nativeApiInfoProvider;
            _httpApiInputModelsGenerator = httpApiInputModelsGenerator;
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
            File.WriteAllText("../Newbe.Mahua.InputReceivers.HttpApi/Services/Controllers/CqpController.cs",
                code,
                Encoding.UTF8);
            return Task.CompletedTask;
        }
    }
}