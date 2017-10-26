using Autofac;
using Newbe.Mahua.CQP.NativeApi;

namespace Newbe.Mahua.CQP.Native
{
    public class MahuaModule : IMahuaModule
    {
        public Module[] GetModules()
        {
            return new Module[] { new CqpModule(), };
        }
        internal class CqpModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<CoolQApi>().As<ICoolQApi>();
                builder.RegisterType<CqpAuthCodeContainer>().As<ICqpAuthCodeContainer>().SingleInstance();
            }
        }
    }
}
