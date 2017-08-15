using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System;
using System.Collections.Generic;

namespace Newbe.Mahua.CQP.Commands
{
    internal class GroupUploadedCommandHandler : ICommandHandler<GroupUploadedCommand>
    {
        private readonly IEnumerable<IGroupUploadedMahuaEvent> _groupUploadedMahuaEvents;

        public GroupUploadedCommandHandler(IEnumerable<IGroupUploadedMahuaEvent> groupUploadedMahuaEvents)
        {
            _groupUploadedMahuaEvents = groupUploadedMahuaEvents;
        }

        public void Handle(GroupUploadedCommand command)
        {
            _groupUploadedMahuaEvents.Handle(x => x.ProcessGroupUploaded(new GroupUploadedContext
            {
                File = command.File,
                FromGroup = command.GroupNum.ToString(),
                FromQq = command.FromQq.ToString(),
                SendTime = command.SendTime,
            }));
        }
    }

    internal class GroupUploadedCommand : CqpCommand
    {
        public DateTime SendTime { get; set; }
        public long FromQq { get; set; }
        public long GroupNum { get; set; }
        public string File { get; set; }
    }
}
