using System;
using System.Collections.Generic;
using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;

namespace Newbe.Mahua.CQP.Commands
{
    internal class GroupUploadedCommandHandler : CommandHandlerBase<GroupUploadedCommand>
    {
        private readonly IEnumerable<IGroupUploadedMahuaEvent> _groupUploadedMahuaEvents;

        public GroupUploadedCommandHandler(IEnumerable<IGroupUploadedMahuaEvent> groupUploadedMahuaEvents)
        {
            _groupUploadedMahuaEvents = groupUploadedMahuaEvents;
        }

        protected override void HandleCore(GroupUploadedCommand command)
        {
            _groupUploadedMahuaEvents.Handle(x => x.ProcessGroupUploaded(new GroupUploadedContext
            {
                File = command.File,
                FromGroup = command.GroupNum,
                FromQq = command.FromQq,
                SendTime = command.SendTime,
            }));
        }
    }

    [Serializable]
    internal class GroupUploadedCommand : CqpCommand
    {
        public DateTime SendTime { get; set; }
        public long FromQq { get; set; }
        public long GroupNum { get; set; }
        public string File { get; set; }
    }
}