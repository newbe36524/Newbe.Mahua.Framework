using System;
using Newbe.Mahua.CQP.NativeApi;

namespace Newbe.Mahua.CQP
{
    public class MahuaApi : IMahuaApi
    {
        private static readonly int AcceptType请求通过 = 1;
        private static readonly int AcceptType请求拒绝 = 2;
        private static readonly int RequestType请求群添加 = 1;
        private static readonly int RequestType请求群邀请 = 2;

        private readonly ICoolQApi _coolQApi;
        private readonly ICqpAuthCodeContainer _cqpAuthCodeContainer;

        public MahuaApi(ICoolQApi coolQApi, ICqpAuthCodeContainer cqpAuthCodeContainer)
        {
            _coolQApi = coolQApi;
            _cqpAuthCodeContainer = cqpAuthCodeContainer;
        }

        private int AuthCode => _cqpAuthCodeContainer.AuthCode;

        public void SendPrivateMessage(string toQq, string message)
        {
            _coolQApi.CQ_sendPrivateMsg(AuthCode, Convert.ToInt64(toQq), message);
        }

        public void SendGroupMessage(string toGroup, string message)
        {
            _coolQApi.CQ_sendGroupMsg(AuthCode, Convert.ToInt64(toGroup), message);
        }

        public void SendDiscussMessage(string toDiscuss, string message)
        {
            _coolQApi.CQ_sendDiscussMsg(AuthCode, Convert.ToInt64(toDiscuss), message);
        }

        public void SendLike(string toQq)
        {
            _coolQApi.CQ_sendLikeV2(AuthCode, Convert.ToInt64(toQq), 1);
        }

        public string GetCookies()
        {
            return _coolQApi.CQ_getCookies(AuthCode);
        }

        public string GetBkn()
        {
            return _coolQApi.CQ_getCsrfToken(AuthCode).ToString();
        }

        public string GetLoginQq()
        {
            return _coolQApi.CQ_getLoginQQ(AuthCode).ToString();
        }

        public string GetLoginNick()
        {
            return _coolQApi.CQ_getLoginNick(AuthCode);
        }

        public void KickGroupMember(string toGroup, string toQq, bool rejectForever)
        {
            _coolQApi.CQ_setGroupKick(AuthCode, Convert.ToInt64(toGroup), Convert.ToInt64(toQq), rejectForever);
        }

        public void BanGroupMember(string toGroup, string toQq, TimeSpan duration)
        {
            var durationTotalSeconds = (long) duration.TotalSeconds;
            if (durationTotalSeconds <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(duration));
            }
            _coolQApi.CQ_setGroupBan(AuthCode, Convert.ToInt64(toGroup), Convert.ToInt64(toQq), durationTotalSeconds);
        }

        public void RemoveBanGroupMember(string toGroup, string toQq)
        {
            _coolQApi.CQ_setGroupBan(AuthCode, Convert.ToInt64(toGroup), Convert.ToInt64(toQq), 0);
        }

        public void EnableGroupAdmin(string toGroup, string toQq)
        {
            _coolQApi.CQ_setGroupAdmin(AuthCode, Convert.ToInt64(toGroup), Convert.ToInt64(toQq), true);
        }

        public void DisableGroupAdmin(string toGroup, string toQq)
        {
            _coolQApi.CQ_setGroupAdmin(AuthCode, Convert.ToInt64(toGroup), Convert.ToInt64(toQq), false);
        }

        public void SetGroupMemberSpecialTitle(string toGroup, string toQq, string specialTitle, TimeSpan duration)
        {
            var total = duration == TimeSpan.MaxValue ? -1 : (long) duration.TotalSeconds;
            _coolQApi.CQ_setGroupSpecialTitle(AuthCode, Convert.ToInt64(toGroup), Convert.ToInt64(toQq), specialTitle,
                total);
        }

        public void SetBanAllGroupMembersOption(string toGroup, bool enabled)
        {
            _coolQApi.CQ_setGroupWholeBan(AuthCode, Convert.ToInt64(toGroup), enabled);
        }

        public void BanGroupAnonymousMember(string toGroup, string anonymous, TimeSpan duration)
        {
            _coolQApi.CQ_setGroupAnonymousBan(AuthCode, Convert.ToInt64(toGroup), anonymous,
                (long) duration.TotalSeconds);
        }

        public void SetGroupAnonymousOption(string toGroup, bool enabled)
        {
            _coolQApi.CQ_setGroupAnonymous(AuthCode, Convert.ToInt64(toGroup), enabled);
        }

        public void SetGroupMemberCard(string toGroup, string toQq, string groupMemberCard)
        {
            _coolQApi.CQ_setGroupCard(AuthCode, Convert.ToInt64(toGroup), Convert.ToInt64(toQq), groupMemberCard);
        }

        public void LeaveGroup(string toGroup)
        {
            _coolQApi.CQ_setGroupLeave(AuthCode, Convert.ToInt64(toGroup), false);
        }

        public void DissolveGroup(string toGroup)
        {
            _coolQApi.CQ_setGroupLeave(AuthCode, Convert.ToInt64(toGroup), true);
        }

        public void LeaveDiscuss(string toDiscuss)
        {
            _coolQApi.CQ_setDiscussLeave(AuthCode, Convert.ToInt64(toDiscuss));
        }

        public void AcceptFriendAddingRequest(string addingFriendRequestId, string friendRemark)
        {
            _coolQApi.CQ_setFriendAddRequest(AuthCode, addingFriendRequestId, MahuaApi.AcceptType请求通过, friendRemark);
        }

        public void RejectFriendAddingRequest(string addingFriendRequestId)
        {
            _coolQApi.CQ_setFriendAddRequest(AuthCode, addingFriendRequestId, MahuaApi.AcceptType请求拒绝, null);
        }

        public void AcceptGroupJoiningRequest(string groupJoiningRequestId)
        {
            _coolQApi.CQ_setGroupAddRequestV2(AuthCode, groupJoiningRequestId, MahuaApi.RequestType请求群添加,
                MahuaApi.AcceptType请求通过,
                null);
        }

        public void RejectGroupJoiningRequest(string groupJoiningRequestId, string reason)
        {
            _coolQApi.CQ_setGroupAddRequestV2(AuthCode, groupJoiningRequestId, MahuaApi.RequestType请求群添加,
                MahuaApi.AcceptType请求拒绝,
                reason);
        }

        public void AcceptGroupJoiningInvitation(string groupJoiningInvitationId)
        {
            _coolQApi.CQ_setGroupAddRequestV2(AuthCode, groupJoiningInvitationId, MahuaApi.RequestType请求群邀请,
                MahuaApi.AcceptType请求通过, null);
        }

        public void RejectGroupJoiningInvitation(string groupJoiningInvitationId, string reason)
        {
            _coolQApi.CQ_setGroupAddRequestV2(AuthCode, groupJoiningInvitationId, MahuaApi.RequestType请求群邀请,
                MahuaApi.AcceptType请求拒绝,
                reason);
        }

        [NotSupportedMahuaApi]
        public void BanFriend(string toQq)
        {
            MahuaGlobal.NotSupportedMahuaApiConvertion.Handle();
        }

        [NotSupportedMahuaApi]
        public void RemoveBanFriend(string toQq)
        {
            MahuaGlobal.NotSupportedMahuaApiConvertion.Handle();
        }

        [NotSupportedMahuaApi]
        public void SetNotice(string toGroup, string title, string content)
        {
            MahuaGlobal.NotSupportedMahuaApiConvertion.Handle();
        }

        [NotSupportedMahuaApi]
        public void RemoveFriend(string toQq)
        {
            MahuaGlobal.NotSupportedMahuaApiConvertion.Handle();
        }

        [NotSupportedMahuaApi]
        public void JoinGroup(string toGroup, string reason)
        {
            MahuaGlobal.NotSupportedMahuaApiConvertion.Handle();
        }

        [NotSupportedMahuaApi]
        public string GetGroupMemebers(string toGroup)
        {
            MahuaGlobal.NotSupportedMahuaApiConvertion.Handle();
            return default(string);
        }

        [NotSupportedMahuaApi]
        public string GetGroups()
        {
            MahuaGlobal.NotSupportedMahuaApiConvertion.Handle();
            return default(string);
        }

        [NotSupportedMahuaApi]
        public string GetFriends()
        {
            MahuaGlobal.NotSupportedMahuaApiConvertion.Handle();
            return default(string);
        }

        [NotSupportedMahuaApi]
        public void SendGroupJoiningInvitation(string toQq, string toGroup)
        {
            MahuaGlobal.NotSupportedMahuaApiConvertion.Handle();
        }

        [NotSupportedMahuaApi]
        public string CreateDiscuss()
        {
            MahuaGlobal.NotSupportedMahuaApiConvertion.Handle();
            return default(string);
        }

        [NotSupportedMahuaApi]
        public void KickDiscussMember(string toDiscuss, string toQq)
        {
            MahuaGlobal.NotSupportedMahuaApiConvertion.Handle();
        }

        [NotSupportedMahuaApi]
        public void SendDiscussJoiningInvitation(string toQq, string toDiscuss)
        {
            MahuaGlobal.NotSupportedMahuaApiConvertion.Handle();
        }

        [NotSupportedMahuaApi]
        public string GetDiscusses()
        {
            MahuaGlobal.NotSupportedMahuaApiConvertion.Handle();
            return default(string);

        }
    }
}