using Autofac;
using Newbe.Mahua.MPQ.Commands;

namespace Newbe.Mahua.MPQ
{
    public class MpqMahuaModule : IMahuaModule
    {
        public Module[] GetModules()
        {
            return new Module[] { new MpqCommandHandlerModule(), new MpqApiModule() };
        }

        private class MpqCommandHandlerModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<AboutCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<EndCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<EventFunCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<GetInfoCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<SetCommandHandler>().AsImplementedInterfaces();
            }
        }

        private class MpqApiModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<MahuaApi>().As<IMahuaApi>().InstancePerLifetimeScope();
                builder.RegisterType<QqSession>().As<IQqSession>().InstancePerLifetimeScope();
            }
        }
    }
}
