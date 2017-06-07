using System;
using Newbe.Mahua.Commands;

namespace Newbe.Mahua.Amanda.Commands
{
    internal class BecomeFriendsCommandHandler : CommandHandlerBase<BecomeFriendsCommand>
    {
        protected override void HandleCore(BecomeFriendsCommand command)
        {
            throw new NotImplementedException();
        }
    }

    [Serializable]
    internal class BecomeFriendsCommand : AmandaCommand
    {
        public string Fromqq { get; set; }
    }
}