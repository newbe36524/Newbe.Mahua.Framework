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
                new MahuaRobotManagerModule(),
            };
        }

        private class PluginLoaderModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder
                    .RegisterType<CommandCenter>()
                    .Named<ICommandCenter>("commandCenter");
                builder
                    .RegisterDecorator<ICommandCenter>((c, inner) => new ExceptionHandleCommandCenter(inner),
                        "commandCenter");

                
            }
        }

        private class LoggedCommandCenterModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<HandlerExceptionHandler>().AsImplementedInterfaces();
                builder.RegisterType<LoggedExceptionOccuredMahuaEvent>().AsImplementedInterfaces();
            }
        }

        private class MahuaApiModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<ContainerSaver>().As<IContainerSaver>().InstancePerLifetimeScope();
                builder.RegisterType<CommandCenterMahuaApi>().As<IMahuaApi>().InstancePerLifetimeScope();
            }
        }

        private class MahuaRobotManagerModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<RobotSessionContext>()
                    .As<IRobotSessionContext>()
                    .InstancePerMatchingLifetimeScope(MahuaGlobal.LifeTimeScopes.RobotSession);
                builder.Register(t => MahuaRobotManager.Instance).As<IMahuaRobotManager>();
            }
        }
    }
}
