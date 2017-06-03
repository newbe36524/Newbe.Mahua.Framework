using Autofac;
using Newbe.Mahua.MPQ.NativeApi;

namespace Newbe.Mahua.MPQ
{
    public class MpqMahuaModule : IMahuaModule
    {
        Module[] IMahuaModule.GetModules()
        {
            return new Module[] {new CqpModule(), new CommandModule(), new CommandHandlersModule()};
        }

        private class CommandModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
            }
        }

        private class CommandHandlersModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
            }
        }

        private class CqpModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<MyPcqqApi>().As<IMyPcqqApi>().SingleInstance();
                builder.RegisterType<MahuaApi>().As<IMahuaApi>().SingleInstance();
            }
        }
    }
}