using Newbe.Mahua.Commands;
using System.Runtime.Serialization;

namespace Newbe.Mahua.MPQ.Commands
{
    public class SetCommandHandler : ICommandHandler<SetCommand>
    {
        public void Handle(SetCommand message)
        {
            throw new System.NotImplementedException();
        }
    }

    [DataContract]
    public class SetCommand : MpqCommand
    {
    }
}
