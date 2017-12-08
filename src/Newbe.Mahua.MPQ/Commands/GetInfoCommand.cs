using Newbe.Mahua.Commands;
using System.Runtime.Serialization;

namespace Newbe.Mahua.MPQ.Commands
{
    public class GetInfoCommandHandler : ICommandHandler<GetInfoCommand, GetInfoCommandResult>
    {
        public GetInfoCommandResult Handle(GetInfoCommand message)
        {
            return new GetInfoCommandResult
            {
                Info = "todo"
            };

            // todo
        }
    }

    [DataContract]
    public class GetInfoCommand : MpqCommand<GetInfoCommandResult>
    {
    }

    [DataContract]
    public class GetInfoCommandResult : MpqCommandResult
    {
        [DataMember]
        public string Info { get; set; }
    }
}
