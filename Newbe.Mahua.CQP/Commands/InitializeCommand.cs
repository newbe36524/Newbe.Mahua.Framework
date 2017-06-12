using System;
using System.Collections.Generic;
using Newbe.Mahua.Commands;
using Newbe.Mahua.CQP.NativeApi;
using Newbe.Mahua.MahuaEvents;

namespace Newbe.Mahua.CQP.Commands
{
    internal class InitializeCommandHandler : CommandHandlerBase<InitializeCommand>
    {
        private readonly ICqpAuthCodeContainer _cqpAuthCodeContainer;
        private readonly IEnumerable<IInitializationMahuaEvent> _initializationMahuaEvents;

        public InitializeCommandHandler(ICqpAuthCodeContainer cqpAuthCodeContainer,
            IEnumerable<IInitializationMahuaEvent> initializationMahuaEvents)
        {
            _cqpAuthCodeContainer = cqpAuthCodeContainer;
            _initializationMahuaEvents = initializationMahuaEvents;
        }

        protected override void HandleCore(InitializeCommand command)
        {
            _cqpAuthCodeContainer.AuthCode = command.AuthCode;
            _initializationMahuaEvents.Handle(x => x.Initialized(new InitializedContext()));
        }
    }

    [Serializable]
    internal class InitializeCommand : CqpCommand
    {
        public int AuthCode { get; set; }
    }
}