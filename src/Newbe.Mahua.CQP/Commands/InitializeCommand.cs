using Newbe.Mahua.Commands;
using Newbe.Mahua.CQP.NativeApi;
using Newbe.Mahua.MahuaEvents;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Newbe.Mahua.CQP.Commands
{
    internal class InitializeCommandHandler : ICommandHandler<InitializeCommand>
    {
        private readonly ICqpAuthCodeContainer _cqpAuthCodeContainer;
        private readonly IEnumerable<IInitializationMahuaEvent> _initializationMahuaEvents;

        public InitializeCommandHandler(ICqpAuthCodeContainer cqpAuthCodeContainer,
            IEnumerable<IInitializationMahuaEvent> initializationMahuaEvents)
        {
            _cqpAuthCodeContainer = cqpAuthCodeContainer;
            _initializationMahuaEvents = initializationMahuaEvents;
        }

        public void Handle(InitializeCommand command)
        {
            _cqpAuthCodeContainer.AuthCode = command.AuthCode;
            _initializationMahuaEvents.Handle(x => x.Initialized(new InitializedContext()));
        }
    }

    [DataContract]
    public class InitializeCommand : CqpCommand
    {
        [DataMember]
        public int AuthCode { get; set; }
    }
}
