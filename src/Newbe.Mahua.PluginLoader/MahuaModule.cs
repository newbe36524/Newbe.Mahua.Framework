using Autofac;
using Newbe.Mahua.Impl;

namespace Newbe.Mahua
{
    public class MahuaModule : IMahuaModule
    {
        Module[] IMahuaModule.GetModules()
        {
            return new Module[]
            {
                new PluginLoaderModule()
            };
        }

        private class PluginLoaderModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);

                builder.RegisterType<InputReceiverFactory>()
                    .AsImplementedInterfaces()
                    .SingleInstance();

                builder.RegisterType<OutputSenderFactory>()
                    .AsImplementedInterfaces()
                    .SingleInstance();

                builder.RegisterType<OutputHandler>()
                    .AsImplementedInterfaces()
                    .SingleInstance();

                builder.RegisterOutputSenderFactoryHandler<LoggingOutputSenderFactoryHandler>("logging");

                builder.RegisterType<InputHandler>()
                    .AsImplementedInterfaces()
                    .SingleInstance();

                builder.RegisterType<JsonFileMahuaConfigProvider>()
                    .AsImplementedInterfaces()
                    .SingleInstance();
            }
        }
    }
}