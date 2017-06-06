using Autofac;
using Newbe.Mahua.MPQ.Commands;
using Newbe.Mahua.MPQ.NativeApi;

namespace Newbe.Mahua.MPQ
{
    public class MpqMahuaModule : IMahuaModule
    {
        Module[] IMahuaModule.GetModules()
        {
            return new Module[] {new CqpModule(), new CommandModule(), new CommandHandlersModule()};
        }

        internal class CommandModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
            }
        }

        internal class CommandHandlersModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<InfoCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<EventFunCommandHandler>().AsImplementedInterfaces();
            }
        }

        internal class CqpModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<MyPcqqApi>().As<IMyPcqqApi>().SingleInstance();
                builder.RegisterType<MahuaApi>().As<IMahuaApi>().InstancePerLifetimeScope();
                builder.RegisterType<QqContainer>().As<IQqContainer>().InstancePerLifetimeScope();
            }
        }
    }
}