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
            throw new NotImplementedException();
        }

        public void SendDiscussMessage(string toDiscuss, string message)
        {
            throw new NotImplementedException();
        }

        public void SendLike(string toQq)
        {
            throw new NotImplementedException();
        }

        public string GetCookies()
        {
            throw new NotImplementedException();
        }

        public string GetBkn()
        {
            throw new NotImplementedException();
        }

        public string GetLoginQq()
        {
            throw new NotImplementedException();
        }

        public string GetLoginNick()
        {
            throw new NotImplementedException();
        }

        public void KickGroupMember(string toGroup, string toQq, bool rejectForever)
        {
            throw new NotImplementedException();
        }

        public void BanGroupMember(string toGroup, string toQq, TimeSpan duration)
        {
            throw new NotImplementedException();
        }

        public void RemoveBanGroupMember(string toGroup, string toQq)
        {
            throw new NotImplementedException();
        }

        public void EnableGroupAdmin(string toGroup, string toQq)
        {
            throw new NotImplementedException();
        }

        public void DisableGroupAdmin(string toGroup, string toQq)
        {
            throw new NotImplementedException();
        }

        public void SetGroupMemberSpecialTitle(string toGroup, string toQq, string specialTitle, TimeSpan duration)
        {
            throw new NotImplementedException();
        }

        public void SetBanAllGroupMembersOption(string toGroup, bool enabled)
        {
            throw new NotImplementedException();
        }

        public void BanGroupAnonymousMember(string toGroup, string anonymous, TimeSpan duration)
        {
            throw new NotImplementedException();
        }

        public void SetGroupAnonymousOption(string toGroup, bool enabled)
        {
            throw new NotImplementedException();
        }

        public void SetGroupMemberCard(string toGroup, string toQq, string groupMemberCard)
        {
            throw new NotImplementedException();
        }

        public void LeaveGroup(string toGroup)
        {
            throw new NotImplementedException();
        }

        public void DissolveGroup(string toGroup)
        {
            throw new NotImplementedException();
        }

        public void LeaveDiscuss(string toDiscuss)
        {
            throw new NotImplementedException();
        }

        public void AcceptFriendAddingRequest(string addingFriendRequestId, string fromQq, string friendRemark)
        {
            throw new NotImplementedException();
        }

        public void RejectFriendAddingRequest(string addingFriendRequestId, string fromQq)
        {
            throw new NotImplementedException();
        }

        public void AcceptGroupJoiningRequest(string groupJoiningRequestId, string toGroup, string fromQq)
        {
            throw new NotImplementedException();
        }

        public void RejectGroupJoiningRequest(string groupJoiningRequestId, string toGroup, string fromQq, string reason)
        {
            throw new NotImplementedException();
        }

        public void AcceptGroupJoiningInvitation(string groupJoiningInvitationId, string toGroup, string fromQq)
        {
            throw new NotImplementedException();
        }

        public void RejectGroupJoiningInvitation(string groupJoiningInvitationId, string toGroup, string fromQq, string reason)
        {
            throw new NotImplementedException();
        }

        public void BanFriend(string toQq)
        {
            throw new NotImplementedException();
        }

        public void RemoveBanFriend(string toQq)
        {
            throw new NotImplementedException();
        }

        public void SetNotice(string toGroup, string title, string content)
        {
            throw new NotImplementedException();
        }

        public void RemoveFriend(string toQq)
        {
            throw new NotImplementedException();
        }

        public void JoinGroup(string toGroup, string reason)
        {
            throw new NotImplementedException();
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
