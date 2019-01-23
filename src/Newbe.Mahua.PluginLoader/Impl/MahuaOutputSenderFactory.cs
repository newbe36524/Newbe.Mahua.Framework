using System.Collections.Generic;
using System.Linq;
using Autofac.Features.Indexed;

namespace Newbe.Mahua.Impl
{
    internal class OutputSenderFactory : IOutputSenderFactory
    {
        private readonly IMahuaConfigProvider _mahuaConfigProvider;
        private readonly IIndex<string, IOutputSenderFactoryHandler> _handlers;

        public OutputSenderFactory(
            IMahuaConfigProvider mahuaConfigProvider,
            IIndex<string, IOutputSenderFactoryHandler> handlers)
        {
            _mahuaConfigProvider = mahuaConfigProvider;
            _handlers = handlers;
        }

        public IEnumerable<IOutputSender> Create()
        {
            var configs = _mahuaConfigProvider.GetOutputsConfig();
            // TODO handle exception if there is no handler
            var re = configs.Select(config => _handlers[config.Type].Create(config))
                .ToArray();
            return re;
        }
    }
}