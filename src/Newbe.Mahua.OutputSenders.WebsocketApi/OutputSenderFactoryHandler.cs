using System.Threading.Tasks;
using Newbe.Mahua.IpcShared.WebsocketApi;

namespace Newbe.Mahua.OutputSenders.WebsocketApi
{
    internal class OutputSenderFactoryHandler : IOutputSenderFactoryHandler
    {
        private readonly IMahuaWebsocketClientManager _mahuaWebsocketClientManager;

        public OutputSenderFactoryHandler(
            IMahuaWebsocketClientManager mahuaWebsocketClientManager)
        {
            _mahuaWebsocketClientManager = mahuaWebsocketClientManager;
        }

        public IOutputSender Create(MahuaOutputConfig config)
        {
            return new OutputSender(_mahuaWebsocketClientManager);
        }

        internal class OutputSender : IOutputSender
        {
            private readonly IMahuaWebsocketClientManager _mahuaWebsocketClientManager;

            public OutputSender(
                IMahuaWebsocketClientManager mahuaWebsocketClientManager)
            {
                _mahuaWebsocketClientManager = mahuaWebsocketClientManager;
            }

            public Task Handle(IOutput output)
            {
                return _mahuaWebsocketClientManager.SendOutput(output);
            }
        }
    }
}