﻿using System;
using System.Collections.Generic;
using Newbe.Mahua.Framework.Commands;
using Newbe.Mahua.Framework.MahuaEvents;

namespace Newbe.Mahua.Framework.CQP.Commands
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
            _groupUploadedMahuaEvents.Handle(x => x.ProcessGroupUploaded(command.SendTime, command.GroupNum,
                command.FromQq, command.File));
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