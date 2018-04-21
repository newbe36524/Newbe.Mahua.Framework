using Autofac;
using Newbe.Mahua.Commands;
using Newbe.Mahua.Commands.ExceptionHandles;

namespace Newbe.Mahua
{
    public class PluginLoaderMahuaModule : IMahuaModule
    {
        Module[] IMahuaModule.GetModules()
        {
            return new Module[]
            {
                new PluginLoaderModule(),
                new LoggedCommandCenterModule(),
                new MahuaApiModule(),
            };
        }

        public class PluginLoaderModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder
                    .RegisterType<CommandCenter>()
                    .Named<ICommandCenter>("commandcenter");
                builder
                    .RegisterDecorator<ICommandCenter>((c, inner) => new ExceptionHandleCommandCenter(inner),
                        "commandcenter");
            }
        }

        public class LoggedCommandCenterModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<HandlerExceptionHandler>().AsImplementedInterfaces();
                builder.RegisterType<LoggedExceptionOccuredMahuaEvent>().AsImplementedInterfaces();
            }
        }

        public class MahuaApiModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<ContainerSaver>().As<IContainerSaver>().InstancePerLifetimeScope();
                builder.RegisterType<CommandCenterMahuaApi>().As<IMahuaApi>().InstancePerLifetimeScope();
            }
        }
    }
}
