using System;
using Newbe.Mahua.Framework.MahuaEvents.Enums;

namespace Newbe.Mahua.Framework.MahuaEvents
{
    public interface IGroupMemberChangedMahuaEvent : IMahuaEvent
    {
        void ProcessGroupMemberChanged(DateTime sendTime, GroupMemberChangedType groupMemberChangedType, long fromGroup,
            long toQq);
    }

    public interface IGroupMemberIncreasedMahuaEvent : IMahuaEvent
    {
        void ProcessGroupMemberIncreased(
            DateTime sendTime,
            GroupMemberIncreasedReason groupMemberIncreasedReason,
            long fromGroup,
            long fromQq,
            long toQq);
    }

    public interface IGroupMemberDecreasedMahuaEvent : IMahuaEvent
    {
        void ProcessGroupMemberDecreased(
            DateTime sendTime,
            GroupMemberDecreasedReason groupMemberDecreasedReason,
            long fromGroup,
            long fromQq,
            long toQq);
    }
}