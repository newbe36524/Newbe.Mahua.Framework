using System;
using System.Collections.Generic;
using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;

namespace Newbe.Mahua.Amanda.Commands
{
    internal class InitializationCommandHandler : CommandHandlerBase<InitializationCommand>
    {
        private readonly IEnumerable<IInitializationMahuaEvent> _initializationMahuaEvents;

        public InitializationCommandHandler(IEnumerable<IInitializationMahuaEvent> initializationMahuaEvents)
        {
            _initializationMahuaEvents = initializationMahuaEvents;
        }

        protected override void HandleCore(InitializationCommand command)
        {
            _initializationMahuaEvents.Handle(x => x.Initialized(new InitializedContext()));
        }
    }

    [Serializable]
    internal class InitializationCommand : AmandaCommand
    {
    }
}