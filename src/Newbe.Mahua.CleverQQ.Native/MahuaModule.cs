using Autofac;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CleverQQ.Native
{
    public class MahuaModule : IMahuaModule
    {
        Module[] IMahuaModule.GetModules()
        {
            return new Module[] { new CleverQQApiModule() };
        }

        private class CleverQQApiModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<CleverQQApi>().As<ICleverQQApi>().InstancePerLifetimeScope();
            }
        }
    }
}
