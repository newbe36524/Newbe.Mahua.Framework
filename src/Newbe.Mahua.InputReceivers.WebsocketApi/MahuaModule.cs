using Autofac;
using Newbe.Mahua.InputReceivers.WebsocketApi.Services;
using Newbe.Mahua.IpcShared.WebsocketApi;

namespace Newbe.Mahua.InputReceivers.WebsocketApi
{
    public class MahuaModule : IMahuaModule
    {
        public Module[] GetModules()
        {
            return new Module[]
            {
                new WebsocketApiModule()
            };
        }

        public class WebsocketApiModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                builder.RegisterType<WebHostContainer>()
                    .AsImplementedInterfaces()
                    .SingleInstance();

                builder.RegisterType<WebsocketInputReceiver>()
                    .AsSelf();

                builder.RegisterType<MahuaWebsocketClient>()
                    .AsSelf();

                builder.RegisterType<MahuaWebsocketClientManager>()
                    .As<IMahuaWebsocketClientManager>()
                    .SingleInstance();

                builder.RegisterInputReceiverFactoryHandler<InputReceiverFactoryHandler>("websocket");
            }
        }
    }
}