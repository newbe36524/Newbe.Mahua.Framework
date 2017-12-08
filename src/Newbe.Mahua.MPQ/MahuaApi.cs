using Autofac;
using Newbe.Mahua.MPQ.NativeApi;
using System;
using System.Collections.Generic;

namespace Newbe.Mahua.MPQ
{
    public class MahuaApi : IMahuaApi
    {
        private readonly IMpqApi _mpqApi;
        private readonly IQqSession _qqSession;
        private readonly IEventFunOutput _eventFunOutput;
        private ILifetimeScope _container;

        public MahuaApi(
            IMpqApi mpqApi,
            IQqSession qqSession,
            IEventFunOutput eventFunOutput)
        {
            _mpqApi = mpqApi;
            _qqSession = qqSession;
            _eventFunOutput = eventFunOutput;
        }

        public void SendPrivateMessage(string toQq, string message)
        {
            _mpqApi.Api_SendMsg(_qqSession.CurrentQq, 1, 0, null, toQq, message);
        }

        public void SendGroupMessage(string toGroup, string message)
        {
            _mpqApi.Api_SendMsg(_qqSession.CurrentQq, 2, 0, toGroup, null, message);
        }

        public void SendDiscussMessage(string toDiscuss, string message)
        {
            _mpqApi.Api_SendMsg(_qqSession.CurrentQq, 3, 0, toDiscuss, null, message);
        }

        [NotSupportedMahuaApi]
        public void SendLike(string toQq)
        {
            MahuaGlobal.NotSupportedMahuaApiConvertion.Handle();
        }

        public string GetCookies()
        {
            return _mpqApi.Api_GetCookies(_qqSession.CurrentQq);
        }

        public string GetBkn()
        {
            throw new NotImplementedException();
        }

        public string GetLoginQq()
        {
            return _qqSession.CurrentQq;
        }

        public string GetLoginNick()
        {
            var re = _mpqApi.Api_GetNick(_qqSession.CurrentQq);
            return re;
        }

        public void KickGroupMember(string toGroup, string toQq, bool rejectForever)
        {
            // todo notsupport rejectForever
            _mpqApi.Api_Kick(_qqSession.CurrentQq, toGroup, toQq);
        }

        public void BanGroupMember(string toGroup, string toQq, TimeSpan duration)
        {
            _mpqApi.Api_Shutup(_qqSession.CurrentQq, toGroup, toQq, (int)duration.TotalSeconds);
        }

        public void RemoveBanGroupMember(string toGroup, string toQq)
        {
            _mpqApi.Api_Shutup(_qqSession.CurrentQq, toGroup, toQq, 0);
        }

        public void EnableGroupAdmin(string toGroup, string toQq)
        {
            throw new NotImplementedException();
        }

        public void DisableGroupAdmin(string toGroup, string toQq)
        {
            throw new NotImplementedException();
        }

        [NotSupportedMahuaApi]
        public void SetGroupMemberSpecialTitle(string toGroup, string toQq, string specialTitle, TimeSpan duration)
        {
            MahuaGlobal.NotSupportedMahuaApiConvertion.Handle();
        }

        public void SetBanAllGroupMembersOption(string toGroup, bool enabled)
        {
            _mpqApi.Api_Shutup(_qqSession.CurrentQq, toGroup, null, 0);
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
            _mpqApi.Api_SetNameCard(_qqSession.CurrentQq, toGroup, toQq, groupMemberCard);
        }

        public void LeaveGroup(string toGroup)
        {
            _mpqApi.Api_QuitGroup(_qqSession.CurrentQq, toGroup);
        }

        public void DissolveGroup(string toGroup)
        {
            _mpqApi.Api_QuitGroup(_qqSession.CurrentQq, toGroup);
        }

        public void LeaveDiscuss(string toDiscuss)
        {
            _mpqApi.Api_QuitDG(_qqSession.CurrentQq, toDiscuss);
        }

        public void AcceptFriendAddingRequest(string addingFriendRequestId, string fromQq, string friendRemark)
        {
            // todo addingFriendRequestId
            _eventFunOutput.Result = 1;
        }

        public void RejectFriendAddingRequest(string addingFriendRequestId, string fromQq)
        {
            // todo addingFriendRequestId
            _eventFunOutput.Result = 2;
        }

        public void AcceptGroupJoiningRequest(string groupJoiningRequestId, string toGroup, string fromQq)
        {
            // todo groupJoiningRequestId
            _eventFunOutput.Result = 1;
        }

        public void RejectGroupJoiningRequest(
            string groupJoiningRequestId,
            string toGroup,
            string fromQq,
            string reason)
        {
            // todo groupJoiningRequestId
            _eventFunOutput.Result = 2;
        }

        public void AcceptGroupJoiningInvitation(string groupJoiningInvitationId, string toGroup, string fromQq)
        {
            // todo groupJoiningInvitationId
            _eventFunOutput.Result = 1;
        }

        public void RejectGroupJoiningInvitation(
            string groupJoiningInvitationId,
            string toGroup,
            string fromQq,
            string reason)
        {
            // todo groupJoiningInvitationId
            _eventFunOutput.Result = 2;
        }

        public void BanFriend(string toQq)
        {
            _mpqApi.Api_Ban(_qqSession.CurrentQq, toQq);
        }

        public void RemoveBanFriend(string toQq)
        {
            _mpqApi.Api_DBan(_qqSession.CurrentQq, toQq);
        }

        public void SetNotice(string toGroup, string title, string content)
        {
            _mpqApi.Api_SetNotice(_qqSession.CurrentQq, toGroup, title, content);
        }

        public void RemoveFriend(string toQq)
        {
            _mpqApi.Api_DelFriend(_qqSession.CurrentQq, toQq);
        }

        public void JoinGroup(string toGroup, string reason)
        {
            _mpqApi.Api_JoinGroup(_qqSession.CurrentQq, toGroup, reason);
        }

        public ModelWithSourceString<IEnumerable<GroupMemberInfo>> GetGroupMemebersWithModel(string toGroup)
        {
            throw new NotImplementedException();
        }

        public ModelWithSourceString<IEnumerable<GroupInfo>> GetGroupsWithModel()
        {
            throw new NotImplementedException();
        }

        public string GetGroupMemebers(string toGroup)
        {
            throw new NotImplementedException();
        }

        public string GetGroups()
        {
            throw new NotImplementedException();
        }

        public string GetFriends()
        {
            throw new NotImplementedException();
        }

        public void SendGroupJoiningInvitation(string toQq, string toGroup)
        {
            throw new NotImplementedException();
        }

        public string CreateDiscuss()
        {
            throw new NotImplementedException();
        }

        public void KickDiscussMember(string toDiscuss, string toQq)
        {
            throw new NotImplementedException();
        }

        public void SendDiscussJoiningInvitation(string toQq, string toDiscuss)
        {
            throw new NotImplementedException();
        }

        public string GetDiscusses()
        {
            throw new NotImplementedException();
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
