using Autofac;
using Newbe.Mahua.Amanda.NativeApi;

namespace Newbe.Mahua.Amanda.Native
{
    public class AmandaMahuaModule : IMahuaModule
    {
        Module[] IMahuaModule.GetModules()
        {
            return new Module[] { new AmandaApiModule() };
        }

        private class AmandaApiModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<AmadaApi>().As<IAmadaApi>().InstancePerLifetimeScope();
            }
        }
    }
}
