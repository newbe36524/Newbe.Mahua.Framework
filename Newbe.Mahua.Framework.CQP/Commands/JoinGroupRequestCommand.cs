using System;
using System.Collections.Generic;
using Newbe.Mahua.Framework.Commands;
using Newbe.Mahua.Framework.MahuaEvents;

namespace Newbe.Mahua.Framework.CQP.Commands
{
    internal class JoinGroupRequestCommandHandler : CommandHandlerBase<JoinGroupRequestCommand>
    {
        private readonly IEnumerable<IGroupJoiningRequestMahuaEvent> _joinGroupRequestMahuaEvents;

        public JoinGroupRequestCommandHandler(IEnumerable<IGroupJoiningRequestMahuaEvent> joinGroupRequestMahuaEvents)
        {
            _joinGroupRequestMahuaEvents = joinGroupRequestMahuaEvents;
        }

        protected override void HandleCore(JoinGroupRequestCommand command)
        {
            _joinGroupRequestMahuaEvents.Handle(x => x.ProcessJoinGroupRequest(new GroupJoiningRequestContext
            {
                SendTime = command.SendTime,
                FromQq = command.FromQq,
                FromGroup = command.FromGroup,
                Message = command.Message,
            }));
        }
    }

    [Serializable]
    internal class JoinGroupRequestCommand : CqpCommand
    {
        public DateTime SendTime { get; set; }
        public long FromGroup { get; set; }
        public long FromQq { get; set; }
        public string Message { get; set; }
    }
}