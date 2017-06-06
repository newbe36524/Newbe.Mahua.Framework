using Newbe.Mahua.Commands;

namespace Newbe.Mahua.MPQ.Commands
{
    internal class SetCommandHandler : CommandHandlerBase<SetCommand>
    {
        protected override void HandleCore(SetCommand command)
        {
            throw new System.NotImplementedException();
        }
    }

    internal class SetCommand : MqpCommand
    {
    }
}