using Autofac;

namespace Newbe.Mahua.Amanda
{
    public class AmandaMahuaModule : IMahuaModule
    {
        Module[] IMahuaModule.GetModules()
        {
            return new Module[] {new CqpModule(),};
        }


        private class CqpModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<MahuaApi>().As<IMahuaApi>().SingleInstance();
            }
        }
    }
}