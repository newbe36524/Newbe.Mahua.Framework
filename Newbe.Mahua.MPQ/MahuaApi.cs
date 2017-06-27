using System;
using System.Collections.Generic;
using System.ComponentModel;
using Autofac;
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
        private ILifetimeScope _container;

        public MahuaApi(IMyPcqqApi myPcqqApi, IQqContainer qqContainer)
        {
            _myPcqqApi = myPcqqApi;
            _qqContainer = qqContainer;
        }

        private string Qq => _qqContainer.ReceivedQq.ToString();

        public void SendPrivateMessage(string toQq, string message)
        {
            //todo 发送好友消息看看是否要区别不同的类别
            _myPcqqApi.Api_SendMsg(Qq, MsgType好友, 0, null, toQq, message);
        }

        public void SendGroupMessage(string toGroup, string message)
        {
            _myPcqqApi.Api_SendMsg(Qq, MsgType群, 0, toGroup, null, message);
        }

        public void SendDiscussMessage(string toDiscuss, string message)
        {
            _myPcqqApi.Api_SendMsg(Qq, MsgType讨论组, 0, toDiscuss, null, message);
        }

        public void SendLike(string toQq)
        {
            _myPcqqApi.Api_Like(Qq, toQq);
        }

        public string GetCookies()
        {
            return _myPcqqApi.Api_GetCookies(Qq);
        }

        public string GetBkn()
        {
            return _myPcqqApi.Api_GetBkn32(Qq);
        }

        public string GetLoginQq()
        {
            return Qq;
        }

        public string GetLoginNick()
        {
            return _myPcqqApi.Api_GetNick(Qq);
        }

        public void KickGroupMember(string toGroup, string toQq, bool rejectForever)
        {
            _myPcqqApi.Api_Kick(Qq, toGroup, toQq);
        }

        public void BanGroupMember(string toGroup, string toQq, TimeSpan duration)
        {
            var durationTotalSeconds = (int) duration.TotalSeconds;
            if (durationTotalSeconds <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(duration));
            }
            _myPcqqApi.Api_Shutup(Qq, toGroup, toQq, durationTotalSeconds);
        }

        public void RemoveBanGroupMember(string toGroup, string toQq)
        {
            _myPcqqApi.Api_Shutup(Qq, toGroup, toQq, 0);
        }

        [NotSupportedMahuaApi]
        public void EnableGroupAdmin(string toGroup, string toQq)
        {
            MahuaGlobal.NotSupportedMahuaApiConvertion.Handle();
        }

        [NotSupportedMahuaApi]
        public void DisableGroupAdmin(string toGroup, string toQq)
        {
            MahuaGlobal.NotSupportedMahuaApiConvertion.Handle();
        }

        [NotSupportedMahuaApi]
        public void SetGroupMemberSpecialTitle(string toGroup, string toQq, string specialTitle, TimeSpan duration)
        {
            MahuaGlobal.NotSupportedMahuaApiConvertion.Handle();
        }

        [NotSupportedMahuaApi]
        public void SetBanAllGroupMembersOption(string toGroup, bool enabled)
        {
            MahuaGlobal.NotSupportedMahuaApiConvertion.Handle();
        }

        [NotSupportedMahuaApi]
        public void BanGroupAnonymousMember(string toGroup, string anonymous, TimeSpan duration)
        {
            MahuaGlobal.NotSupportedMahuaApiConvertion.Handle();
        }

        [NotSupportedMahuaApi]
        public void SetGroupAnonymousOption(string toGroup, bool enabled)
        {
            MahuaGlobal.NotSupportedMahuaApiConvertion.Handle();
        }

        public void SetGroupMemberCard(string toGroup, string toQq, string groupMemberCard)
        {
            _myPcqqApi.Api_SetNameCard(Qq, toGroup, toQq, groupMemberCard);
        }

        public void LeaveGroup(string toGroup)
        {
            _myPcqqApi.Api_QuitGroup(Qq, toGroup);
        }

        [NotSupportedMahuaApi]
        public void DissolveGroup(string toGroup)
        {
            MahuaGlobal.NotSupportedMahuaApiConvertion.Handle();
        }

        public void LeaveDiscuss(string toDiscuss)
        {
            _myPcqqApi.Api_QuitDG(Qq, toDiscuss);
        }

        [NotSupportedMahuaApi]
        public void AcceptFriendAddingRequest(string addingFriendRequestId, string fromQq, string friendRemark)
        {
            MahuaGlobal.NotSupportedMahuaApiConvertion.Handle();
        }

        [NotSupportedMahuaApi]
        public void RejectFriendAddingRequest(string addingFriendRequestId, string fromQq)
        {
            MahuaGlobal.NotSupportedMahuaApiConvertion.Handle();
        }

        [NotSupportedMahuaApi]
        public void AcceptGroupJoiningRequest(string groupJoiningRequestId, string toGroup, string fromQq)
        {
            MahuaGlobal.NotSupportedMahuaApiConvertion.Handle();
        }

        [NotSupportedMahuaApi]
        public void RejectGroupJoiningRequest(string groupJoiningRequestId, string toGroup, string fromQq,
            string reason)
        {
            MahuaGlobal.NotSupportedMahuaApiConvertion.Handle();
        }

        [NotSupportedMahuaApi]
        public void AcceptGroupJoiningInvitation(string groupJoiningInvitationId, string toGroup, string fromQq)
        {
            MahuaGlobal.NotSupportedMahuaApiConvertion.Handle();
        }

        [NotSupportedMahuaApi]
        public void RejectGroupJoiningInvitation(string groupJoiningInvitationId, string toGroup, string fromQq,
            string reason)
        {
            MahuaGlobal.NotSupportedMahuaApiConvertion.Handle();
        }

        public void BanFriend(string toQq)
        {
            _myPcqqApi.Api_Ban(Qq, toQq);
        }

        public void RemoveBanFriend(string toQq)
        {
            _myPcqqApi.Api_DBan(Qq, toQq);
        }

        public void SetNotice(string toGroup, string title, string content)
        {
            _myPcqqApi.Api_SetNotice(Qq, toGroup, title, content);
        }

        public void RemoveFriend(string toQq)
        {
            _myPcqqApi.Api_DelFriend(Qq, toQq);
        }

        public void JoinGroup(string toGroup, string reason)
        {
            _myPcqqApi.Api_JoinGroup(Qq, toGroup, reason);
        }

        [NotSupportedMahuaApi]
        public ModelWithSourceString<IEnumerable<GroupMemberInfo>> GetGroupMemebersWithModel(string toGroup)
        {
            MahuaGlobal.NotSupportedMahuaApiConvertion.Handle();
            return default(ModelWithSourceString<IEnumerable<GroupMemberInfo>>);
        }

        [NotSupportedMahuaApi]
        public ModelWithSourceString<IEnumerable<GroupInfo>> GetGroupsWithModel()
        {
            MahuaGlobal.NotSupportedMahuaApiConvertion.Handle();
            return default(ModelWithSourceString<IEnumerable<GroupInfo>>);
        }

        public string GetGroupMemebers(string toGroup)
        {
            return _myPcqqApi.Api_GetGroupMemberA(Qq, toGroup);
        }

        public string GetGroups()
        {
            return _myPcqqApi.Api_GetGroupListB(Qq);
        }

        public string GetFriends()
        {
            return _myPcqqApi.Api_GetFriendList(Qq);
        }

        public void SendGroupJoiningInvitation(string toQq, string toGroup)
        {
            _myPcqqApi.Api_GroupInvitation(Qq, toQq, toGroup);
        }

        public string CreateDiscuss()
        {
            return _myPcqqApi.Api_CreateDG(Qq);
        }

        public void KickDiscussMember(string toDiscuss, string toQq)
        {
            _myPcqqApi.Api_KickDG(Qq, toDiscuss, toQq);
        }

        public void SendDiscussJoiningInvitation(string toQq, string toDiscuss)
        {
            _myPcqqApi.Api_DGInvitation(Qq, toDiscuss, toQq);
        }

        public string GetDiscusses()
        {
            return _myPcqqApi.Api_GetDGList(Qq);
        }

        public ILifetimeScope GetContainer()
        {
            return _container;
        }

        public void SetContainer(ILifetimeScope container)
        {
            _container = container;
        }
    }
}