using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Newbe.Mahua.Amanda.Commands
{
    [DataContract]
    public class InitializationCommand : AmandaCommand
    {
    }

    internal class InitializationCommandHandler : ICommandHandler<InitializationCommand>
    {
        private readonly IEnumerable<IInitializationMahuaEvent> _initializationMahuaEvents;

        public InitializationCommandHandler(IEnumerable<IInitializationMahuaEvent> initializationMahuaEvents)
        {
            _initializationMahuaEvents = initializationMahuaEvents;
        }

        public void Handle(InitializationCommand message)
        {
            _initializationMahuaEvents.Handle(x => x.Initialized(new InitializedContext()));
        }
    }
}
