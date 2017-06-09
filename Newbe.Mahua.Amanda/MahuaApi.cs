using System;
using Newbe.Mahua.Amanda.NativeApi;

namespace Newbe.Mahua.Amanda
{
    internal class MahuaApi : IMahuaApi
    {
        private readonly string MsgType好友消息 = "1";
        private readonly string MsgType群消息 = "2";
        private readonly string MsgType群临时消息 = "3";
        private readonly string MsgType讨论组消息 = "4";
        private readonly string MsgType讨论组临时消息 = "5";

        private readonly int Operation同意 = 1;
        private readonly int Operation拒绝 = 2;
        private readonly int Operation忽略 = 3;
        private readonly IAmadaApi _amadaApi;

        public MahuaApi(IAmadaApi amadaApi)
        {
            _amadaApi = amadaApi;
        }

        public void SendPrivateMessage(string toQq, string message)
        {
            _amadaApi.Api_SendMsg(MsgType好友消息, null, toQq, message);
        }

        public void SendGroupMessage(string toGroup, string message)
        {
            _amadaApi.Api_SendMsg(MsgType群消息, toGroup, null, message);
        }

        public void SendDiscussMessage(string toDiscuss, string message)
        {
            _amadaApi.Api_SendMsg(MsgType讨论组消息, toDiscuss, null, message);
        }

        public void SendLike(string toQq)
        {
            _amadaApi.Api_SendPraise(toQq);
        }

        public string GetCookies()
        {
            return _amadaApi.Api_GetCookies();
        }

        public string GetCsrfToken()
        {
            return _amadaApi.Api_Getbkn();
        }

        public string GetLoginQq()
        {
            return _amadaApi.Api_GetLoginQQ();
        }

        public string GetLoginNick()
        {
            return _amadaApi.Api_GetNick(_amadaApi.Api_GetLoginQQ());
        }

        public void KickGroupMember(string toGroup, string toQq, bool rejectForever)
        {
            _amadaApi.Api_RemoveMember(toGroup, toQq, rejectForever);
        }

        public void BanGroupMember(string toGroup, string toQq, TimeSpan duration)
        {
            _amadaApi.Api_Ban(toGroup, toQq, (int) duration.TotalSeconds);
        }

        public void RemoveBanGroupMember(string toGroup, string toQq)
        {
            _amadaApi.Api_Ban(toGroup, toQq, 0);
        }

        public void EnableGroupAdmin(string toGroup, string toQq)
        {
            _amadaApi.Api_SetManager(toGroup, toQq, true);
        }

        public void DisableGroupAdmin(string toGroup, string toQq)
        {
            _amadaApi.Api_SetManager(toGroup, toQq, false);
        }

        [NotSupportedMahuaApi]
        public void SetGroupMemberSpecialTitle(string toGroup, string toQq, string specialTitle, TimeSpan duration)
        {
            MahuaGlobal.NotSupportedMahuaApiConvertion.Handle();
        }

        public void SetBanAllGroupMembersOption(string toGroup, bool enabled)
        {
            _amadaApi.Api_BanGroup(toGroup, enabled);
        }

        [NotSupportedMahuaApi]
        public void BanGroupAnonymousMember(string toGroup, string anonymous, TimeSpan duration)
        {
            MahuaGlobal.NotSupportedMahuaApiConvertion.Handle();
        }

        public void SetGroupAnonymousOption(string toGroup, bool enabled)
        {
            _amadaApi.Api_SetAnony(toGroup, enabled);
        }

        public void SetGroupMemberCard(string toGroup, string toQq, string groupMemberCard)
        {
            _amadaApi.Api_SetGroupCard(toGroup, toQq, groupMemberCard);
        }

        public void LeaveGroup(string toGroup)
        {
            _amadaApi.Api_QuitGroup(toGroup);
        }

        public void DissolveGroup(string toGroup)
        {
            _amadaApi.Api_RemoveGroup(toGroup);
        }

        public void LeaveDiscuss(string toDiscuss)
        {
            _amadaApi.Api_QuitDiscussGroup(toDiscuss);
        }

        [NotSupportedMahuaApi]
        public void AcceptFriendAddingRequest(string addingFriendRequestId, string friendRemark)
        {
            MahuaGlobal.NotSupportedMahuaApiConvertion.Handle();
        }

        [NotSupportedMahuaApi]
        public void RejectFriendAddingRequest(string addingFriendRequestId)
        {
            MahuaGlobal.NotSupportedMahuaApiConvertion.Handle();
        }

        public void AcceptGroupJoiningRequest(string groupJoiningRequestId)
        {
            _amadaApi.Api_SetGroupAdd(null, null, groupJoiningRequestId, Operation同意, null);
        }

        public void RejectGroupJoiningRequest(string groupJoiningRequestId, string reason)
        {
            _amadaApi.Api_SetGroupAdd(null, null, groupJoiningRequestId, Operation拒绝, reason);
        }

        [NotSupportedMahuaApi]
        public void AcceptGroupJoiningInvitation(string groupJoiningInvitationId)
        {
            MahuaGlobal.NotSupportedMahuaApiConvertion.Handle();
        }

        [NotSupportedMahuaApi]
        public void RejectGroupJoiningInvitation(string groupJoiningInvitationId, string reason)
        {
            MahuaGlobal.NotSupportedMahuaApiConvertion.Handle();
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

        public void RemoveFriend(string toQq)
        {
            _amadaApi.Api_DeleteFriend(toQq);
        }

        public void JoinGroup(string toGroup, string reason)
        {
            _amadaApi.Api_AddGroup(toGroup, reason);
        }

        public string GetGroupMemebers(string toGroup)
        {
            return _amadaApi.Api_GetGroupMemberList(toGroup);
        }

        public string GetGroups()
        {
            return _amadaApi.Api_GetGroupList();
        }

        public string GetFriends()
        {
            return _amadaApi.Api_GetFriendList();
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