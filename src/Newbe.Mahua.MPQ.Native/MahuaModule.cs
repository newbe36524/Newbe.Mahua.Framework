using Autofac;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.MPQ.Native
{
    public class MahuaModule : IMahuaModule
    {
        Module[] IMahuaModule.GetModules()
        {
            return new Module[] { new MpqApiModule() };
        }

        private class MpqApiModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<MpqApi>().As<IMpqApi>().InstancePerLifetimeScope();
            }
        }
    }
}
