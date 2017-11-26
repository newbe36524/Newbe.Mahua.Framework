using Newbe.Mahua.Commands;
using System.Runtime.Serialization;

namespace Newbe.Mahua.MPQ.Commands
{
    public class EndCommandHandler : ICommandHandler<EndCommand, EndCommandResult>
    {
        public EndCommandResult Handle(EndCommand message)
        {
            throw new System.NotImplementedException();
        }
    }

    [DataContract]
    public class EndCommand : MpqCommand<EndCommandResult>
    {
    }

    [DataContract]
    public class EndCommandResult : MpqCommandResult
    {
        [DataMember]
        public int Result { get; set; }
    }
}
