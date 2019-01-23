using Autofac;

namespace Newbe.Mahua.CleverQQ
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
                builder.RegisterPlatformApiHandler<CleverQQMahuaApiHandler>(MahuaPlatform.CleverQQ);
            }
        }
    }
}