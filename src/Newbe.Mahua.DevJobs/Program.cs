using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Newbe.Mahua.NativeApiClassfy.Services;
using Newbe.Mahua.NativeApiClassfy.Services.Impl;

namespace Newbe.Mahua.NativeApiClassfy
{
    internal class Program
    {
        private static Task Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<NativeApiInfoResolver>()
                .AsImplementedInterfaces()
                .SingleInstance();
            builder.RegisterType<ApiHandlerGenerator>()
                .AsImplementedInterfaces()
                .SingleInstance();
            builder.RegisterType<HttpApiInputModelsGenerator>()
                .AsImplementedInterfaces()
                .SingleInstance();
            builder.RegisterType<CodeGenerator>()
                .AsImplementedInterfaces()
                .SingleInstance();
            builder.RegisterType<NativeApiInfoProvider>()
                .AsImplementedInterfaces()
                .SingleInstance();
            builder.RegisterType<SystemClock>()
                .As<IClock>()
                .SingleInstance();

            foreach (var jobType in typeof(Program).Assembly.GetTypes()
                .Where(x => x.GetInterface(nameof(IJob)) != null))
            {
                builder.RegisterType(jobType)
                    .As<IJob>();
            }

            var container = builder.Build();
            var codeGenerator = container.Resolve<ICodeGenerator>();
            return codeGenerator.Generate();
        }
    }
}