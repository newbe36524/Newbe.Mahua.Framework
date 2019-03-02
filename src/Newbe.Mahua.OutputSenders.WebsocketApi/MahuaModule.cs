using Autofac;
using Newbe.Mahua.IpcShared.WebsocketApi;

namespace Newbe.Mahua.OutputSenders.WebsocketApi
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
                builder.RegisterType<MahuaWebsocketClientManager>()
                    .As<IMahuaWebsocketClientManager>()
                    .SingleInstance();

                builder.RegisterOutputSenderFactoryHandler<OutputSenderFactoryHandler>("websocket");
            }
        }
    }
}