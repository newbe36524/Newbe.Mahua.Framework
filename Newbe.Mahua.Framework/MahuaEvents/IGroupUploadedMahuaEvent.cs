using System;

namespace Newbe.Mahua.Framework.MahuaEvents
{
    public interface IGroupUploadedMahuaEvent : IMahuaEvent
    {
        void ProcessGroupUploaded(DateTime sendTime, long fromGroup, long fromQQ, string file);
    }
}