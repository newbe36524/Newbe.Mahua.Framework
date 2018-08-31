using Autofac;
using Newbe.Mahua.QQLight.NativeApi;

namespace Newbe.Mahua.QQLight.Native
{
    public class QqLightMahuaModule : IMahuaModule
    {
        Module[] IMahuaModule.GetModules()
        {
            return new Module[] { new QqLightApiModule() };
        }

        private class QqLightApiModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                builder.RegisterType<QqLightApi>().As<IQqLightApi>().InstancePerLifetimeScope();
                builder.RegisterType<QqLightAuthCodeContainer>().As<IQqLightAuthCodeContainer>().SingleInstance();
            }
        }
    }
}
