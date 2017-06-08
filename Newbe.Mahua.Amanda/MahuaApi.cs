using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public void SendPrivateMessage(long toQq, string message)
        {
            _amadaApi.Api_SendMsg(MsgType好友消息, null, toQq.ToString(), message);
        }

        public void SendGroupMessage(long toGroup, string message)
        {
            _amadaApi.Api_SendMsg(MsgType群消息, toGroup.ToString(), null, message);
        }

        public void SendDiscussMessage(long toDiscuss, string message)
        {
            _amadaApi.Api_SendMsg(MsgType讨论组消息, toDiscuss.ToString(), null, message);
        }

        public void SendLike(long toQq)
        {
            _amadaApi.Api_SendPraise(toQq.ToString());
        }

        public string GetCookies()
        {
            return _amadaApi.Api_GetCookies();
        }

        public string GetCsrfToken()
        {
            return _amadaApi.Api_Getbkn();
        }

        public long GetLoginQq()
        {
            return long.Parse(_amadaApi.Api_GetLoginQQ());
        }

        public string GetLoginNick()
        {
            return _amadaApi.Api_GetNick(_amadaApi.Api_GetLoginQQ());
        }

        public void KickGroupMember(long toGroup, long toQq, bool rejectForever)
        {
            _amadaApi.Api_RemoveMember(toGroup.ToString(), toQq.ToString(), rejectForever);
        }

        public void BanGroupMember(long toGroup, long toQq, TimeSpan duration)
        {
            _amadaApi.Api_Ban(toGroup.ToString(), toQq.ToString(), (int) duration.TotalSeconds);
        }

        public void RemoveBanGroupMember(long toGroup, long toQq)
        {
            _amadaApi.Api_Ban(toGroup.ToString(), toQq.ToString(), 0);
        }

        public void EnableGroupAdmin(long toGroup, long toQq)
        {
            _amadaApi.Api_SetManager(toGroup.ToString(), toQq.ToString(), true);
        }

        public void DisableGroupAdmin(long toGroup, long toQq)
        {
            _amadaApi.Api_SetManager(toGroup.ToString(), toQq.ToString(), false);
        }

        [NotSupportedMahuaApi]
        public void SetGroupMemberSpecialTitle(long toGroup, long toQq, string specialTitle, TimeSpan duration)
        {
            throw new NotImplementedException();
        }

        public void SetBanAllGroupMembersOption(long toGroup, bool enabled)
        {
            _amadaApi.Api_BanGroup(toGroup.ToString(), enabled);
        }

        [NotSupportedMahuaApi]
        public void BanGroupAnonymousMember(long toGroup, string anonymous, TimeSpan duration)
        {
            throw new NotImplementedException();
        }

        public void SetGroupAnonymousOption(long toGroup, bool enabled)
        {
            _amadaApi.Api_SetAnony(toGroup.ToString(), enabled);
        }

        public void SetGroupMemberCard(long toGroup, long toQq, string groupMemberCard)
        {
            _amadaApi.Api_SetGroupCard(toGroup.ToString(), toQq.ToString(), groupMemberCard);
        }

        public void LeaveGroup(long toGroup)
        {
            _amadaApi.Api_QuitGroup(toGroup.ToString());
        }

        public void DissolveGroup(long toGroup)
        {
            _amadaApi.Api_RemoveGroup(toGroup.ToString());
        }

        public void LeaveDiscuss(long toDiscuss)
        {
            _amadaApi.Api_QuitDiscussGroup(toDiscuss.ToString());
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
            throw new NotImplementedException();
        }

        [NotSupportedMahuaApi]
        public void RejectGroupJoiningInvitation(string groupJoiningInvitationId, string reason)
        {
            throw new NotImplementedException();
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

        public void RemoveFriend(long toQq)
        {
            _amadaApi.Api_DeleteFriend(toQq.ToString());
        }

        public void JoinGroup(long toGroup, string reason)
        {
            _amadaApi.Api_AddGroup(toGroup.ToString(), reason);
        }

        public string GetGroupMemebers(long toGroup)
        {
            return _amadaApi.Api_GetGroupMemberList(toGroup.ToString());
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