using System.Threading.Tasks;
using Newbe.Mahua.Logging;
using Newtonsoft.Json;

namespace Newbe.Mahua.Impl
{
    internal class LoggingOutputSender : IOutputSender
    {
        private static readonly ILog Logger = LogProvider.For<OutputHandler>();

        public Task Handle(IOutput output)
        {
            Logger.Debug(JsonConvert.SerializeObject(output));
            return Task.CompletedTask;
        }
    }
}