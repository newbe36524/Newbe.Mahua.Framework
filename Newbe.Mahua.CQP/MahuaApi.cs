using System;
using Newbe.Mahua.CQP.NativeApi;

namespace Newbe.Mahua.CQP
{
    public class MahuaApi : IMahuaApi
    {
        private readonly ICoolQApi _coolQApi;
        private readonly ICqpAuthCodeContainer _cqpAuthCodeContainer;

        public MahuaApi(ICoolQApi coolQApi, ICqpAuthCodeContainer cqpAuthCodeContainer)
        {
            _coolQApi = coolQApi;
            _cqpAuthCodeContainer = cqpAuthCodeContainer;
        }

        public void SendPrivateMessage(long toQq, string message)
        {
            throw new NotImplementedException();
        }

        public void SendGroupMessage(long toGroup, string message)
        {
            throw new NotImplementedException();
        }

        public void SendDiscussMessage(long toDiscuss, string message)
        {
            throw new NotImplementedException();
        }

        public int SendLike(long toQq)
        {
            throw new NotImplementedException();
        }

        public string GetCookies()
        {
            throw new NotImplementedException();
        }

        public int GetCsrfToken()
        {
            throw new NotImplementedException();
        }

        public long GetLoginQq()
        {
            throw new NotImplementedException();
        }

        public string GetLoginNick()
        {
            throw new NotImplementedException();
        }

        public string GetRecord(string file, string outformat)
        {
            throw new NotImplementedException();
        }

        public void KickGroupMember(long toGroup, long toQq, bool rejectForever)
        {
            throw new NotImplementedException();
        }

        public void BanGroupMember(long toGroup, long toQq, TimeSpan duration)
        {
            throw new NotImplementedException();
        }

        public void RemoveBanGroupMember(long toGroup, long toQq)
        {
            throw new NotImplementedException();
        }

        public void EnableGroupAdmin(long toGroup, long toQq)
        {
            throw new NotImplementedException();
        }

        public void DisableGroupAdmin(long toGroup, long toQq)
        {
            throw new NotImplementedException();
        }

        public void SetGroupMemberSpecialTitle(long toGroup, long toQq, string specialTitle, TimeSpan duration)
        {
            throw new NotImplementedException();
        }

        public void SetBanAllGroupMembersOption(long toGroup, bool enabled)
        {
            throw new NotImplementedException();
        }

        public int SetGroupAnonymousBan(long toGroup, string anonymous, TimeSpan duration)
        {
            throw new NotImplementedException();
        }

        public int SetGroupAnonymousOption(long toGroup, bool enabled)
        {
            throw new NotImplementedException();
        }

        public void SetGroupMemberCard(long toGroup, long toQq, string groupMemberCard)
        {
            throw new NotImplementedException();
        }

        public void LeaveGroup(long toGroup)
        {
            throw new NotImplementedException();
        }

        public void DissolveGroup(long toGroup)
        {
            throw new NotImplementedException();
        }

        public int LeaveDiscuss(long toDiscuss)
        {
            throw new NotImplementedException();
        }

        public void AcceptFriendAddingRequest(string addingFriendRequestId, string friendRemark)
        {
            throw new NotImplementedException();
        }

        public void RejectFriendAddingRequest(string addingFriendRequestId)
        {
            throw new NotImplementedException();
        }

        public void AcceptGroupJoiningRequest(string groupJoiningRequestId)
        {
            throw new NotImplementedException();
        }

        public void RejectGroupJoiningRequest(string groupJoiningRequestId, string reason)
        {
            throw new NotImplementedException();
        }

        public void AcceptGroupJoiningInvitation(string groupJoiningInvitationId)
        {
            throw new NotImplementedException();
        }

        public void RejectGroupJoiningInvitation(string groupJoiningInvitationId, string reason)
        {
            throw new NotImplementedException();
        }
    }
}