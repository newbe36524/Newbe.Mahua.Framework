using Newbe.Mahua.Commands;

namespace Newbe.Mahua.MPQ.Commands
{
    internal class EndCommandHandler : CommandHandlerBase<EndCommand>
    {
        protected override void HandleCore(EndCommand command)
        {
            throw new System.NotImplementedException();
        }
    }

    internal class EndCommand : MqpCommand
    {
    }
}