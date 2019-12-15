using Autofac;
using Newbe.Mahua.Mpq;

namespace Newbe.Mahua.MPQ
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
                builder.RegisterPlatformApiHandler<MpqMahuaApiHandler>(MahuaPlatform.Mpq);
            }
        }
    }
}