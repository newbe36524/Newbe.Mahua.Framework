using Autofac;

namespace Newbe.Mahua.QQLight
{
    public class MahuaModule : IMahuaModule
    {
        Module[] IMahuaModule.GetModules()
        {
            return new Module[]
            {
                new CoreModule()
            };
        }
        
        private class CoreModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterPlatformApiHandler<QQLightMahuaApiHandler>(MahuaPlatform.QQLight);
            }
        }
    }
}