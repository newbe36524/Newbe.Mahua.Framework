using System;
using Newbe.Mahua.MPQ.NativeApi;

namespace Newbe.Mahua.MPQ
{
    internal class MahuaApi : IMahuaApi
    {
        private static readonly int MsgType好友 = 1;
        private static readonly int MsgType群 = 2;
        private static readonly int MsgType讨论组 = 3;
        private static readonly int MsgType群临时会话 = 4;
        private static readonly int MsgType讨论组临时会话 = 5;
        private readonly IMyPcqqApi _myPcqqApi;
        private readonly IQqContainer _qqContainer;

        public MahuaApi(IMyPcqqApi myPcqqApi, IQqContainer qqContainer)
        {
            _myPcqqApi = myPcqqApi;
            _qqContainer = qqContainer;
        }

        private string Qq => _qqContainer.ReceivedQq.ToString();

        public void SendPrivateMessage(long toQq, string message)
        {
            //todo 发送好友消息看看是否要区别不同的类别
            _myPcqqApi.Api_SendMsg(Qq, MsgType好友, 0, null, toQq.ToString(), message);
        }

        public void SendGroupMessage(long toGroup, string message)
        {
            _myPcqqApi.Api_SendMsg(Qq, MsgType群, 0, toGroup.ToString(), null, message);
        }

        public void SendDiscussMessage(long toDiscuss, string message)
        {
            _myPcqqApi.Api_SendMsg(Qq, MsgType讨论组, 0, toDiscuss.ToString(), null, message);
        }

        public void SendLike(long toQq)
        {
            _myPcqqApi.Api_Like(Qq, toQq.ToString());
        }

        public string GetCookies()
        {
            return _myPcqqApi.Api_GetCookies(Qq);
        }

        public int GetCsrfToken()
        {
            return int.Parse(_myPcqqApi.Api_GetBkn32(Qq));
        }

        public long GetLoginQq()
        {
            return long.Parse(Qq);
        }

        public string GetLoginNick()
        {
            return _myPcqqApi.Api_GetNick(Qq);
        }

        public void KickGroupMember(long toGroup, long toQq, bool rejectForever)
        {
            _myPcqqApi.Api_Kick(Qq, toGroup.ToString(), toQq.ToString());
        }

        public void BanGroupMember(long toGroup, long toQq, TimeSpan duration)
        {
            var durationTotalSeconds = (int) duration.TotalSeconds;
            if (durationTotalSeconds <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(duration));
            }
            _myPcqqApi.Api_Shutup(Qq, toGroup.ToString(), toQq.ToString(), durationTotalSeconds);
        }

        public void RemoveBanGroupMember(long toGroup, long toQq)
        {
            _myPcqqApi.Api_Shutup(Qq, toGroup.ToString(), toQq.ToString(), 0);
        }

        [NotSupportedMahuaApi]
        public void EnableGroupAdmin(long toGroup, long toQq)
        {
            throw new NotImplementedException();
        }

        [NotSupportedMahuaApi]
        public void DisableGroupAdmin(long toGroup, long toQq)
        {
            throw new NotImplementedException();
        }

        [NotSupportedMahuaApi]
        public void SetGroupMemberSpecialTitle(long toGroup, long toQq, string specialTitle, TimeSpan duration)
        {
            throw new NotImplementedException();
        }

        [NotSupportedMahuaApi]
        public void SetBanAllGroupMembersOption(long toGroup, bool enabled)
        {
            throw new NotImplementedException();
        }

        [NotSupportedMahuaApi]
        public void BanGroupAnonymousMember(long toGroup, string anonymous, TimeSpan duration)
        {
            throw new NotImplementedException();
        }

        [NotSupportedMahuaApi]
        public void SetGroupAnonymousOption(long toGroup, bool enabled)
        {
            throw new NotImplementedException();
        }

        public void SetGroupMemberCard(long toGroup, long toQq, string groupMemberCard)
        {
            _myPcqqApi.Api_SetNameCard(Qq, toGroup.ToString(), toQq.ToString(), groupMemberCard);
        }

        public void LeaveGroup(long toGroup)
        {
            _myPcqqApi.Api_QuitGroup(Qq, toGroup.ToString());
        }

        [NotSupportedMahuaApi]
        public void DissolveGroup(long toGroup)
        {
            throw new NotImplementedException();
        }

        public void LeaveDiscuss(long toDiscuss)
        {
            _myPcqqApi.Api_QuitDG(Qq, toDiscuss.ToString());
        }

        [NotSupportedMahuaApi]
        public void AcceptFriendAddingRequest(string addingFriendRequestId, string friendRemark)
        {
            throw new NotImplementedException();
        }

        [NotSupportedMahuaApi]
        public void RejectFriendAddingRequest(string addingFriendRequestId)
        {
            throw new NotImplementedException();
        }

        [NotSupportedMahuaApi]
        public void AcceptGroupJoiningRequest(string groupJoiningRequestId)
        {
            throw new NotImplementedException();
        }

        [NotSupportedMahuaApi]
        public void RejectGroupJoiningRequest(string groupJoiningRequestId, string reason)
        {
            throw new NotImplementedException();
        }

        [NotSupportedMahuaApi]
        public void AcceptGroupJoiningInvitation(string groupJoiningInvitationId)
        {
            throw new NotImplementedException();
        }

        [NotSupportedMahuaApi]
        public void RejectGroupJoiningInvitation(string groupJoiningInvitationId, string reason)
        {
            throw new NotImplementedException();
        }

        public void BanFriend(long toQq)
        {
            _myPcqqApi.Api_Ban(Qq, toQq.ToString());
        }

        public void RemoveBanFriend(long toQq)
        {
            _myPcqqApi.Api_DBan(Qq, toQq.ToString());
        }

        public void SetNotice(long toGroup, string title, string content)
        {
            _myPcqqApi.Api_SetNotice(Qq, toGroup.ToString(), title, content);
        }

        public void RemoveFriend(long toQq)
        {
            _myPcqqApi.Api_DelFriend(Qq, toQq.ToString());
        }

        public void JoinGroup(long toGroup, string reason)
        {
            _myPcqqApi.Api_JoinGroup(Qq, toGroup.ToString(), reason);
        }

        public string GetGroupMemebers(long toGroup)
        {
            return _myPcqqApi.Api_GetGroupMemberA(Qq, toGroup.ToString());
        }

        public string GetGroups()
        {
            return _myPcqqApi.Api_GetGroupListB(Qq);
        }

        public string GetFriends()
        {
            return _myPcqqApi.Api_GetFriendList(Qq);
        }

        public void SendGroupJoiningInvitation(long toQq, long toGroup)
        {
            _myPcqqApi.Api_GroupInvitation(Qq, toQq.ToString(), toGroup.ToString());
        }

        public string CreateDiscuss()
        {
            return _myPcqqApi.Api_CreateDG(Qq);
        }

        public void KickDiscussMember(long toDiscuss, long toQq)
        {
            _myPcqqApi.Api_KickDG(Qq, toDiscuss.ToString(), toQq.ToString());
        }

        public void SendDiscussJoiningInvitation(long toQq, long toDiscuss)
        {
            _myPcqqApi.Api_DGInvitation(Qq, toDiscuss.ToString(), toQq.ToString());
        }

        public string GetDiscusses()
        {
            return _myPcqqApi.Api_GetDGList(Qq);
        }
    }
}