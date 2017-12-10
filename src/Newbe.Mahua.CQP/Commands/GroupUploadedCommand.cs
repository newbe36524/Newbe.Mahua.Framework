using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Newbe.Mahua.CQP.Commands
{
    [DataContract]
    public class GroupUploadedCommand : CqpCommand
    {
        [DataMember]
        public DateTime SendTime { get; set; }

        [DataMember]
        public long FromQq { get; set; }

        [DataMember]
        public long GroupNum { get; set; }

        [DataMember]
        public string File { get; set; }
    }

    internal class GroupUploadedCommandHandler : ICommandHandler<GroupUploadedCommand>
    {
        private readonly IEnumerable<IGroupUploadedMahuaEvent> _groupUploadedMahuaEvents;

        public GroupUploadedCommandHandler(IEnumerable<IGroupUploadedMahuaEvent> groupUploadedMahuaEvents)
        {
            _groupUploadedMahuaEvents = groupUploadedMahuaEvents;
        }

        public void Handle(GroupUploadedCommand message)
        {
            _groupUploadedMahuaEvents.Handle(x => x.ProcessGroupUploaded(new GroupUploadedContext
            {
                File = message.File,
                FromGroup = message.GroupNum.ToString(),
                FromQq = message.FromQq.ToString(),
                SendTime = message.SendTime,
            }));
        }
    }
}
