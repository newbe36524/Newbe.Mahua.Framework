using System;
using Newbe.Mahua.Commands;

namespace Newbe.Mahua.Amanda.Commands
{
    internal class GroupMemberDecreaseCommandHandler : CommandHandlerBase<GroupMemberDecreaseCommand>
    {
        protected override void HandleCore(GroupMemberDecreaseCommand command)
        {
            throw new NotImplementedException();
        }
    }

    [Serializable]
    internal class GroupMemberDecreaseCommand : AmandaCommand
    {
        public string Type { get; set; }
        public string Fromgroup { get; set; }
        public string Fromqq { get; set; }
        public string OperatorQq { get; set; }
    }
}