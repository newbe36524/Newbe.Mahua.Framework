using System;
using Newbe.Mahua.Commands;

namespace Newbe.Mahua.Amanda.Commands
{
    internal class InformationCommandHandler : CommandHandlerBase<InformationCommand>
    {
        protected override void HandleCore(InformationCommand command)
        {
            throw new System.NotImplementedException();
        }
    }

    [Serializable]
    internal class InformationCommand : AmandaCommand
    {
    }

    [Serializable]
    public class InformationCommandResult : MahuaCommandResult
    {
        public string Info { get; set; }
    }
}