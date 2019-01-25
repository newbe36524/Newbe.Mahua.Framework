using Autofac;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Native
{
    public class MahuaModule : IMahuaModule
    {
        Module[] IMahuaModule.GetModules()
        {
            return new Module[] { new QqLightApiModule() };
        }

        private class QqLightApiModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                builder.RegisterType<QQLightApi>().As<IQQLightApi>().InstancePerLifetimeScope();
                builder.RegisterType<QqLightAuthCodeContainer>().As<IQqLightAuthCodeContainer>().SingleInstance();
            }
        }
    }
}
