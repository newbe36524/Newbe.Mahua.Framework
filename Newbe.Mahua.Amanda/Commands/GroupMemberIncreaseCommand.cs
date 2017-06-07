using System;
using Newbe.Mahua.Commands;

namespace Newbe.Mahua.Amanda.Commands
{
    internal class GroupMemberIncreaseCommandHandler : CommandHandlerBase<GroupMemberIncreaseCommand>
    {
        protected override void HandleCore(GroupMemberIncreaseCommand command)
        {
            throw new NotImplementedException();
        }
    }

    [Serializable]
    internal class GroupMemberIncreaseCommand : AmandaCommand
    {
        public string Type { get; set; }
        public string Fromgroup { get; set; }
        public string Fromqq { get; set; }
        public string OperatorQq { get; set; }
    }
}