using Autofac;
using Newbe.Mahua.Logging;

namespace Newbe.Mahua
{
    public static class AutofacExtensions
    {
        private static readonly ILog Logger = LogProvider.GetLogger(typeof(AutofacExtensions));

        public static void RegisterInputReceiverFactoryHandler<T>(this ContainerBuilder builder, string type)
            where T : IInputReceiverFactoryHandler
        {
            Logger.Info($"register {typeof(T).Name} for {type}");
            builder.RegisterType<T>().Keyed<IInputReceiverFactoryHandler>(type);
        }

        public static void RegisterOutputSenderFactoryHandler<T>(this ContainerBuilder builder, string type)
            where T : IOutputSenderFactoryHandler
        {
            Logger.Info($"register {typeof(T).Name} for {type}");
            builder.RegisterType<T>().Keyed<IOutputSenderFactoryHandler>(type);
        }
        
        public static void RegisterPlatformApiHandler<T>(this ContainerBuilder builder, MahuaPlatform mahuaPlatform)
            where T : IPlatformMahuaApiHandler
        {
            Logger.Info($"register {typeof(T).Name} for {mahuaPlatform}");
            builder.RegisterType<T>().Keyed<IPlatformMahuaApiHandler>(mahuaPlatform);
        }
    }
}