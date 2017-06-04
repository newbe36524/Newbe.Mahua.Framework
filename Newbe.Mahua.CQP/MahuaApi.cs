using System;
using Newbe.Mahua.CQP.NativeApi;

namespace Newbe.Mahua.CQP
{
    public class MahuaApi : IMahuaApi
    {
        public const int 请求通过 = 1;
        public const int 请求拒绝 = 2;
        public const int 请求群添加 = 1;
        public const int 请求群邀请 = 2;

        private readonly ICoolQApi _coolQApi;
        private readonly ICqpAuthCodeContainer _cqpAuthCodeContainer;

        public MahuaApi(ICoolQApi coolQApi, ICqpAuthCodeContainer cqpAuthCodeContainer)
        {
            _coolQApi = coolQApi;
            _cqpAuthCodeContainer = cqpAuthCodeContainer;
        }

        private int AuthCode => _cqpAuthCodeContainer.AuthCode;

        public void SendPrivateMessage(long toQq, string message)
        {
            _coolQApi.CQ_sendPrivateMsg(AuthCode, toQq, message);
        }

        public void SendGroupMessage(long toGroup, string message)
        {
            _coolQApi.CQ_sendGroupMsg(AuthCode, toGroup, message);
        }

        public void SendDiscussMessage(long toDiscuss, string message)
        {
            _coolQApi.CQ_sendDiscussMsg(AuthCode, toDiscuss, message);
        }

        public void SendLike(long toQq)
        {
            _coolQApi.CQ_sendLikeV2(AuthCode, toQq, 1);
        }

        public string GetCookies()
        {
            return _coolQApi.CQ_getCookies(AuthCode);
        }

        public int GetCsrfToken()
        {
            return _coolQApi.CQ_getCsrfToken(AuthCode);
        }

        public long GetLoginQq()
        {
            return _coolQApi.CQ_getLoginQQ(AuthCode);
        }

        public string GetLoginNick()
        {
            return _coolQApi.CQ_getLoginNick(AuthCode);
        }

        public string GetRecord(string file, string outformat)
        {
            return _coolQApi.CQ_getRecord(AuthCode, file, outformat);
        }

        public void KickGroupMember(long toGroup, long toQq, bool rejectForever)
        {
            _coolQApi.CQ_setGroupKick(AuthCode, toGroup, toQq, rejectForever);
        }

        public void BanGroupMember(long toGroup, long toQq, TimeSpan duration)
        {
            var durationTotalSeconds = (long) duration.TotalSeconds;
            if (durationTotalSeconds <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(duration));
            }
            _coolQApi.CQ_setGroupBan(AuthCode, toGroup, toQq, durationTotalSeconds);
        }

        public void RemoveBanGroupMember(long toGroup, long toQq)
        {
            _coolQApi.CQ_setGroupBan(AuthCode, toGroup, toQq, 0);
        }

        public void EnableGroupAdmin(long toGroup, long toQq)
        {
            _coolQApi.CQ_setGroupAdmin(AuthCode, toGroup, toQq, true);
        }

        public void DisableGroupAdmin(long toGroup, long toQq)
        {
            _coolQApi.CQ_setGroupAdmin(AuthCode, toGroup, toQq, false);
        }

        public void SetGroupMemberSpecialTitle(long toGroup, long toQq, string specialTitle, TimeSpan duration)
        {
            var total = duration == TimeSpan.MaxValue ? -1 : (long) duration.TotalSeconds;
            _coolQApi.CQ_setGroupSpecialTitle(AuthCode, toGroup, toQq, specialTitle, total);
        }

        public void SetBanAllGroupMembersOption(long toGroup, bool enabled)
        {
            _coolQApi.CQ_setGroupWholeBan(AuthCode, toGroup, enabled);
        }

        public void BanGroupAnonymousMember(long toGroup, string anonymous, TimeSpan duration)
        {
            _coolQApi.CQ_setGroupAnonymousBan(AuthCode, toGroup, anonymous, (long) duration.TotalSeconds);
        }

        public void SetGroupAnonymousOption(long toGroup, bool enabled)
        {
            _coolQApi.CQ_setGroupAnonymous(AuthCode, toGroup, enabled);
        }

        public void SetGroupMemberCard(long toGroup, long toQq, string groupMemberCard)
        {
            _coolQApi.CQ_setGroupCard(AuthCode, toGroup, toQq, groupMemberCard);
        }

        public void LeaveGroup(long toGroup)
        {
            _coolQApi.CQ_setGroupLeave(AuthCode, toGroup, false);
        }

        public void DissolveGroup(long toGroup)
        {
            _coolQApi.CQ_setGroupLeave(AuthCode, toGroup, true);
        }

        public void LeaveDiscuss(long toDiscuss)
        {
            _coolQApi.CQ_setDiscussLeave(AuthCode, toDiscuss);
        }

        public void AcceptFriendAddingRequest(string addingFriendRequestId, string friendRemark)
        {
            _coolQApi.CQ_setFriendAddRequest(AuthCode, addingFriendRequestId, MahuaApi.请求通过, friendRemark);
        }

        public void RejectFriendAddingRequest(string addingFriendRequestId)
        {
            _coolQApi.CQ_setFriendAddRequest(AuthCode, addingFriendRequestId, MahuaApi.请求拒绝, null);
        }

        public void AcceptGroupJoiningRequest(string groupJoiningRequestId)
        {
            _coolQApi.CQ_setGroupAddRequestV2(AuthCode, groupJoiningRequestId, MahuaApi.请求群添加, MahuaApi.请求通过, null);
        }

        public void RejectGroupJoiningRequest(string groupJoiningRequestId, string reason)
        {
            _coolQApi.CQ_setGroupAddRequestV2(AuthCode, groupJoiningRequestId, MahuaApi.请求群添加, MahuaApi.请求拒绝, reason);
        }

        public void AcceptGroupJoiningInvitation(string groupJoiningInvitationId)
        {
            _coolQApi.CQ_setGroupAddRequestV2(AuthCode, groupJoiningInvitationId, MahuaApi.请求群邀请, MahuaApi.请求通过, null);
        }

        public void RejectGroupJoiningInvitation(string groupJoiningInvitationId, string reason)
        {
            _coolQApi.CQ_setGroupAddRequestV2(AuthCode, groupJoiningInvitationId, MahuaApi.请求群邀请, MahuaApi.请求拒绝,
                reason);
        }

        [NotSupportedMahuaApi]
        public void BanFriend(long toQq)
        {
            throw new NotImplementedException();
        }

        [NotSupportedMahuaApi]
        public void RemoveBanFriend(long toQq)
        {
            throw new NotImplementedException();
        }

        [NotSupportedMahuaApi]
        public void SetNotice(long toGroup, string title, string content)
        {
            throw new NotImplementedException();
        }

        [NotSupportedMahuaApi]
        public string GetNotices(long toGroup)
        {
            throw new NotImplementedException();
        }

        [NotSupportedMahuaApi]
        public void RemoveFriend(long toQq)
        {
            throw new NotImplementedException();
        }

        [NotSupportedMahuaApi]
        public void JoinGroup(long toGroup, string reason)
        {
            throw new NotImplementedException();
        }

        [NotSupportedMahuaApi]
        public string GetGroupMemebers(long toGroup)
        {
            throw new NotImplementedException();
        }

        [NotSupportedMahuaApi]
        public string GetGroups(long toGroup)
        {
            throw new NotImplementedException();
        }

        [NotSupportedMahuaApi]
        public string GetFriends()
        {
            throw new NotImplementedException();
        }

        [NotSupportedMahuaApi]
        public void SendGroupJoiningInvitation(long toQq, long toGroup)
        {
            throw new NotImplementedException();
        }

        [NotSupportedMahuaApi]
        public string CreateDiscuss()
        {
            throw new NotImplementedException();
        }

        [NotSupportedMahuaApi]
        public void KickDiscussMember(long toDiscuss, long toQq)
        {
            throw new NotImplementedException();
        }

        [NotSupportedMahuaApi]
        public void SendDiscussJoiningInvitation(long toQq, long toDiscuss)
        {
            throw new NotImplementedException();
        }

        [NotSupportedMahuaApi]
        public string GetDiscusses()
        {
            throw new NotImplementedException();
        }
    }
}