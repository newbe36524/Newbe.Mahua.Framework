using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newbe.Mahua.Framework.MPQ
{
    class MahuaApi : IMahuaApi
    {
        void IMahuaApi.SendPrivateMessage(long toQq, string message)
        {
            throw new NotImplementedException();
        }

        void IMahuaApi.SendGroupMessage(long toGroup, string message)
        {
            throw new NotImplementedException();
        }

        void IMahuaApi.SendDiscussMessage(long toDiscuss, string message)
        {
            throw new NotImplementedException();
        }

        int IMahuaApi.SendLike(long toQq)
        {
            throw new NotImplementedException();
        }

        string IMahuaApi.GetCookies()
        {
            throw new NotImplementedException();
        }

        int IMahuaApi.GetCsrfToken()
        {
            throw new NotImplementedException();
        }

        long IMahuaApi.GetLoginQq()
        {
            throw new NotImplementedException();
        }

        string IMahuaApi.GetLoginNick()
        {
            throw new NotImplementedException();
        }

        string IMahuaApi.GetRecord(string file, string outformat)
        {
            throw new NotImplementedException();
        }

        void IMahuaApi.KickGroupMember(long toGroup, long toQq, bool rejectForever)
        {
            throw new NotImplementedException();
        }

        void IMahuaApi.BanGroupMember(long toGroup, long toQq, TimeSpan duration)
        {
            throw new NotImplementedException();
        }

        void IMahuaApi.RemoveBanGroupMember(long toGroup, long toQq)
        {
            throw new NotImplementedException();
        }

        void IMahuaApi.EnableGroupAdmin(long toGroup, long toQq)
        {
            throw new NotImplementedException();
        }

        void IMahuaApi.DisableGroupAdmin(long toGroup, long toQq)
        {
            throw new NotImplementedException();
        }

        void IMahuaApi.SetGroupMemberSpecialTitle(long toGroup, long toQq, string specialTitle, TimeSpan duration)
        {
            throw new NotImplementedException();
        }

        void IMahuaApi.SetBanAllGroupMembersOption(long toGroup, bool enabled)
        {
            throw new NotImplementedException();
        }

        int IMahuaApi.SetGroupAnonymousBan(long toGroup, string anonymous, TimeSpan duration)
        {
            throw new NotImplementedException();
        }

        int IMahuaApi.SetGroupAnonymousOption(long toGroup, bool enabled)
        {
            throw new NotImplementedException();
        }

        void IMahuaApi.SetGroupMemberCard(long toGroup, long toQq, string groupMemberCard)
        {
            throw new NotImplementedException();
        }

        void IMahuaApi.LeaveGroup(long toGroup)
        {
            throw new NotImplementedException();
        }

        void IMahuaApi.DissolveGroup(long toGroup)
        {
            throw new NotImplementedException();
        }

        int IMahuaApi.LeaveDiscuss(long toDiscuss)
        {
            throw new NotImplementedException();
        }

        void IMahuaApi.AcceptFriendAddingRequest(string addingFriendRequestId, string friendRemark)
        {
            throw new NotImplementedException();
        }

        void IMahuaApi.RejectFriendAddingRequest(string addingFriendRequestId)
        {
            throw new NotImplementedException();
        }

        void IMahuaApi.AcceptGroupJoiningRequest(string groupJoiningRequestId)
        {
            throw new NotImplementedException();
        }

        void IMahuaApi.RejectGroupJoiningRequest(string groupJoiningRequestId, string reason)
        {
            throw new NotImplementedException();
        }

        void IMahuaApi.AcceptGroupJoiningInvitation(string groupJoiningInvitationId)
        {
            throw new NotImplementedException();
        }

        void IMahuaApi.RejectGroupJoiningInvitation(string groupJoiningInvitationId, string reason)
        {
            throw new NotImplementedException();
        }
    }
}