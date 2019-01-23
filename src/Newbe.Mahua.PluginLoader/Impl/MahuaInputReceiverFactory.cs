using System.Collections.Generic;
using System.Linq;
using Autofac.Features.Indexed;

namespace Newbe.Mahua.Impl
{
    internal class InputReceiverFactory : IInputReceiverFactory
    {
        private readonly IMahuaConfigProvider _mahuaConfigProvider;
        private readonly IIndex<string, IInputReceiverFactoryHandler> _handlers;

        public InputReceiverFactory(
            IMahuaConfigProvider mahuaConfigProvider,
            IIndex<string,IInputReceiverFactoryHandler> handlers)
        {
            _mahuaConfigProvider = mahuaConfigProvider;
            _handlers = handlers;
        }

        public IEnumerable<IInputReceiver> Create()
        {
            var configs = _mahuaConfigProvider.GetInputsConfig();
            // TODO handle exception if there is no handler
            var re = configs.Select(config => _handlers[config.Type].Create(config))
                .ToArray();
            return re;
        }
    }
}