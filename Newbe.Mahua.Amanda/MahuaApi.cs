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
            _amadaApi.Api_发送消息(MsgType好友消息, null, toQq.ToString(), message);
        }

        public void SendGroupMessage(long toGroup, string message)
        {
            _amadaApi.Api_发送消息(MsgType群消息, toGroup.ToString(), null, message);
        }

        public void SendDiscussMessage(long toDiscuss, string message)
        {
            _amadaApi.Api_发送消息(MsgType讨论组消息, toDiscuss.ToString(), null, message);
        }

        public void SendLike(long toQq)
        {
            _amadaApi.Api_点赞(toQq.ToString());
        }

        public string GetCookies()
        {
            return _amadaApi.Api_取Cookies();
        }

        public string GetCsrfToken()
        {
            return _amadaApi.Api_取bkn();
        }

        public long GetLoginQq()
        {
            return long.Parse(_amadaApi.Api_取登录QQ());
        }

        public string GetLoginNick()
        {
            return _amadaApi.Api_取昵称(_amadaApi.Api_取登录QQ());
        }

        public void KickGroupMember(long toGroup, long toQq, bool rejectForever)
        {
            _amadaApi.Api_移除群成员(toGroup.ToString(), toQq.ToString(), rejectForever);
        }

        public void BanGroupMember(long toGroup, long toQq, TimeSpan duration)
        {
            _amadaApi.Api_禁言(toGroup.ToString(), toQq.ToString(), (int) duration.TotalSeconds);
        }

        public void RemoveBanGroupMember(long toGroup, long toQq)
        {
            _amadaApi.Api_禁言(toGroup.ToString(), toQq.ToString(), 0);
        }

        public void EnableGroupAdmin(long toGroup, long toQq)
        {
            _amadaApi.Api_置群管理(toGroup.ToString(), toQq.ToString(), true);
        }

        public void DisableGroupAdmin(long toGroup, long toQq)
        {
            _amadaApi.Api_置群管理(toGroup.ToString(), toQq.ToString(), false);
        }

        [NotSupportedMahuaApi]
        public void SetGroupMemberSpecialTitle(long toGroup, long toQq, string specialTitle, TimeSpan duration)
        {
            throw new NotImplementedException();
        }

        public void SetBanAllGroupMembersOption(long toGroup, bool enabled)
        {
            _amadaApi.Api_置全群禁言(toGroup.ToString(), enabled);
        }

        [NotSupportedMahuaApi]
        public void BanGroupAnonymousMember(long toGroup, string anonymous, TimeSpan duration)
        {
            throw new NotImplementedException();
        }

        public void SetGroupAnonymousOption(long toGroup, bool enabled)
        {
            _amadaApi.Api_置群匿名(toGroup.ToString(), enabled);
        }

        public void SetGroupMemberCard(long toGroup, long toQq, string groupMemberCard)
        {
            _amadaApi.Api_修改群名片(toGroup.ToString(), toQq.ToString(), groupMemberCard);
        }

        public void LeaveGroup(long toGroup)
        {
            _amadaApi.Api_退出群(toGroup.ToString());
        }

        public void DissolveGroup(long toGroup)
        {
            _amadaApi.Api_解散群(toGroup.ToString());
        }

        public void LeaveDiscuss(long toDiscuss)
        {
            _amadaApi.Api_退出讨论组(toDiscuss.ToString());
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
            _amadaApi.Api_置群添加请求(null, null, groupJoiningRequestId, Operation同意, null);
        }

        public void RejectGroupJoiningRequest(string groupJoiningRequestId, string reason)
        {
            _amadaApi.Api_置群添加请求(null, null, groupJoiningRequestId, Operation拒绝, reason);
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
            _amadaApi.Api_删除好友(toQq.ToString());
        }

        public void JoinGroup(long toGroup, string reason)
        {
            _amadaApi.Api_加群(toGroup.ToString(), reason);
        }

        public string GetGroupMemebers(long toGroup)
        {
            return _amadaApi.Api_取群成员列表(toGroup.ToString());
        }

        public string GetGroups()
        {
            return _amadaApi.Api_取群列表();
        }

        public string GetFriends()
        {
            return _amadaApi.Api_取好友列表();
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