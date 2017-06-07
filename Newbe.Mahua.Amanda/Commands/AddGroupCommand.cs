using System;
using Newbe.Mahua.Commands;

namespace Newbe.Mahua.Amanda.Commands
{
    internal class AddGroupCommandHandler : CommandHandlerBase<AddGroupCommand>
    {
        protected override void HandleCore(AddGroupCommand command)
        {
            throw new NotImplementedException();
        }
    }

    [Serializable]
    internal class AddGroupCommand : AmandaCommand
    {
        public string Type { get; set; }
        public string Fromgroup { get; set; }
        public string Fromqq { get; set; }
        public string InvatorQq { get; set; }
        public string MoreMsg { get; set; }
        public string Seq { get; set; }
    }
}