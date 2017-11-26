using Autofac;
using Newbe.Mahua.MPQ.NativeApi;

namespace Newbe.Mahua.MPQ.Native
{
    public class MpqNativeModule : IMahuaModule
    {
        Module[] IMahuaModule.GetModules()
        {
            return new Module[] { new AmandaApiModule() };
        }

        private class AmandaApiModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                builder.RegisterType<MpqApi>().As<IMpqApi>().InstancePerLifetimeScope();
            }
        }
    }
}
