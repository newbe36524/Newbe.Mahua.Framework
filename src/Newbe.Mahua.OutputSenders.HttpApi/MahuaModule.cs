using Autofac;

namespace Newbe.Mahua.OutputSenders.HttpApi
{
    public class MahuaModule : IMahuaModule
    {
        public Module[] GetModules()
        {
            return new Module[]
            {
                new HttpApiModule()
            };
        }

        public class HttpApiModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                builder.RegisterType<HttpApiOutputSender>()
                    .AsSelf();

                builder.RegisterOutputSenderFactoryHandler<FactoryHandler>("http");
            }
        }
    }
}