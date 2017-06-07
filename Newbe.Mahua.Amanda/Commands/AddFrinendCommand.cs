using System;
using Newbe.Mahua.Commands;

namespace Newbe.Mahua.Amanda.Commands
{
    internal class AddFrinendCommandHandler : CommandHandlerBase<AddFrinendCommand>
    {
        protected override void HandleCore(AddFrinendCommand command)
        {
            throw new NotImplementedException();
        }
    }

    [Serializable]
    internal class AddFrinendCommand : AmandaCommand
    {
        public string Fromqq { get; set; }
        public string Reason { get; set; }
    }
}