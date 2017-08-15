using Newbe.Mahua.Commands;

namespace Newbe.Mahua.MPQ.Commands
{
    internal class EndCommandHandler : ICommandHandler<EndCommand>
    {
        public void Handle(EndCommand command)
        {
            throw new System.NotImplementedException();
        }
    }

    internal class EndCommand : MpqCommand
    {
    }
}
