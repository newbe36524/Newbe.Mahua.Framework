using Autofac;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CleverQQ.Native
{
    public class CleverQQNativeModule : IMahuaModule
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
                builder.RegisterType<CleverQQApi>().As<ICleverQqApi>().InstancePerLifetimeScope();
            }
        }
    }
}
