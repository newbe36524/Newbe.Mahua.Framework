using Autofac;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CQP.Native
{
    public class MahuaModule : IMahuaModule
    {
        public Module[] GetModules()
        {
            return new Module[] { new CqpModule(), };
        }

        private class CqpModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<CqpApi>().As<ICqpApi>();
                builder.RegisterType<CqpAuthCodeContainer>().As<ICqpAuthCodeContainer>().SingleInstance();
            }
        }
    }
}
