using Autofac;
using Newbe.Mahua.Agents.HttpApi.Services;
using Newbe.Mahua.InputReceivers.HttpApi.Services;

namespace Newbe.Mahua.InputReceivers.HttpApi
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
                builder.RegisterType<WebHostContainer>()
                    .AsImplementedInterfaces()
                    .SingleInstance();

                builder.RegisterType<HttpApiInputReceiver>()
                    .AsSelf();

                builder.RegisterInputReceiverFactoryHandler<HttpFactoryHandler>("http");
            }
        }
    }
}