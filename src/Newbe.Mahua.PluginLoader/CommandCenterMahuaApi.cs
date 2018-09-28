using Autofac;
using Newbe.Mahua.Apis;
using Newbe.Mahua.Commands;
using Newbe.Mahua.Messages;
using System;
using System.Collections.Generic;

namespace Newbe.Mahua
{
    /// <summary>
    /// 通过<see cref="ICommandCenter"/>实现对API的调用
    /// </summary>
    internal class CommandCenterMahuaApi : IMahuaApi
    {
        private readonly IContainerSaver _containerSaver;
        private readonly ICommandCenter _commandCenter;

        public CommandCenterMahuaApi(
            IContainerSaver containerSaver,
            ICommandCenter commandCenter)
        {
            _containerSaver = containerSaver;
            _commandCenter = commandCenter;
        }

        public bool DeleteMessage(long messageId, string toGroup, int type)
        {
            var re = _commandCenter
            .HandleWithResult<DeleteMessageApiMahuaCommand, DeleteMessageApiMahuaCommandResult>(
            new DeleteMessageApiMahuaCommand
            {
                 MessageId = messageId,
                 TargetId = toGroup,
                 Type = type
            });
            return re.IsDeleted;
        }

        public void SendPrivateMessage(string toQq, string message, IMessageCancelToken token)
        {
            var re = _commandCenter
            .HandleWithResult<SendPrivateMessageApiMahuaCommand, SendPrivateMessageApiMahuaCommandResult>(
            new SendPrivateMessageApiMahuaCommand
            {
                Message = message,
                ToQq = toQq,
            });
            token.TargetId = toQq;
            token.MessageId = re.MessageId;
        }

        public void SendGroupMessage(string toGroup, string message, IMessageCancelToken token)
        {
            var re = _commandCenter.HandleWithResult<SendGroupMessageApiMahuaCommand, SendGroupMessageApiMahuaCommandResult>(
                    new SendGroupMessageApiMahuaCommand
                    {
                        Message = message,
                        ToGroup = toGroup,
                    });
            token.TargetId = toGroup;
            token.MessageId = re.MessageId;
        }

        public void SendDiscussMessage(string toDiscuss, string message, IMessageCancelToken token)
        {
            var re = _commandCenter
                .HandleWithResult<SendDiscussMessageApiMahuaCommand, SendDiscussMessageApiMahuaCommandResult>(
                    new SendDiscussMessageApiMahuaCommand
                    {
                        Message = message,
                        ToDiscuss = toDiscuss,
                    });
            token.TargetId = toDiscuss;
            token.MessageId = re.MessageId;
        }

        public void SendPrivateMessage(string toQq, string message)
        {
            _commandCenter.HandleWithResult<SendPrivateMessageApiMahuaCommand, SendPrivateMessageApiMahuaCommandResult>(
                    new SendPrivateMessageApiMahuaCommand
                    {
                        Message = message,
                        ToQq = toQq,
                    });
        }

        public void SendGroupMessage(string toGroup, string message)
        {
            _commandCenter.HandleWithResult<SendGroupMessageApiMahuaCommand, SendGroupMessageApiMahuaCommandResult>(
                    new SendGroupMessageApiMahuaCommand
                    {
                        Message = message,
                        ToGroup = toGroup,
                    });
        }

        public void SendDiscussMessage(string toDiscuss, string message)
        {
            _commandCenter.HandleWithResult<SendDiscussMessageApiMahuaCommand, SendDiscussMessageApiMahuaCommandResult>(
                    new SendDiscussMessageApiMahuaCommand
                    {
                        Message = message,
                        ToDiscuss = toDiscuss,
                    });
        }

        public void SendLike(string toQq)
        {
            _commandCenter.Handle(new SendLikeApiMahuaCommand
            {
                ToQq = toQq,
            });
        }

        public string GetCookies()
        {
            var re = _commandCenter
                .HandleWithResult<GetCookiesApiMahuaCommand, GetCookiesApiMahuaCommandResult>(
                    new GetCookiesApiMahuaCommand());
            var cookies = re.Cookies;
            return cookies;
        }

        public string GetBkn()
        {
            var re =
                _commandCenter.HandleWithResult<GetBknApiMahuaCommand, GetBknApiMahuaCommandResult>(
                    new GetBknApiMahuaCommand());
            var bkn = re.Bkn;
            return bkn;
        }

        public string GetLoginQq()
        {
            var re =
                _commandCenter.HandleWithResult<GetLoginQqApiMahuaCommand, GetLoginQqApiMahuaCommandResult>(
                    new GetLoginQqApiMahuaCommand());
            var bkn = re.Qq;
            return bkn;
        }

        public string GetLoginNick()
        {
            var re =
                _commandCenter.HandleWithResult<GetLoginNickApiMahuaCommand, GetLoginNickApiMahuaCommandResult>(
                    new GetLoginNickApiMahuaCommand());
            var bkn = re.Nick;
            return bkn;
        }

        public void KickGroupMember(string toGroup, string toQq, bool rejectForever)
        {
            _commandCenter.Handle(new KickGroupMemberApiMahuaCommand
            {
                ToQq = toQq,
                ToGroup = toGroup,
                RejectForever = rejectForever
            });
        }

        public void BanGroupMember(string toGroup, string toQq, TimeSpan duration)
        {
            _commandCenter.Handle(new BanGroupMemberApiMahuaCommand
            {
                ToQq = toQq,
                ToGroup = toGroup,
                Duration = duration
            });
        }

        public void RemoveBanGroupMember(string toGroup, string toQq)
        {
            _commandCenter.Handle(new RemoveBanGroupMemberApiMahuaCommand
            {
                ToGroup = toGroup,
                ToQq = toQq
            });
        }

        public void EnableGroupAdmin(string toGroup, string toQq)
        {
            _commandCenter.Handle(new EnableGroupAdminApiMahuaCommand
            {
                ToQq = toQq,
                ToGroup = toGroup,
            });
        }

        public void DisableGroupAdmin(string toGroup, string toQq)
        {
            _commandCenter.Handle(new DisableGroupAdminApiMahuaCommand
            {
                ToQq = toQq,
                ToGroup = toGroup,
            });
        }

        public void SetGroupMemberSpecialTitle(string toGroup, string toQq, string specialTitle, TimeSpan duration)
        {
            _commandCenter.Handle(new SetGroupMemberSpecialTitleApiMahuaCommand
            {
                ToQq = toQq,
                ToGroup = toGroup,
                Duration = duration,
                SpecialTitle = specialTitle
            });
        }

        public void SetBanAllGroupMembersOption(string toGroup, bool enabled)
        {
            _commandCenter.Handle(new SetBanAllGroupMembersOptionApiMahuaCommand
            {
                ToGroup = toGroup,
                Enabled = enabled
            });
        }

        public void BanGroupAnonymousMember(string toGroup, string anonymous, TimeSpan duration)
        {
            _commandCenter.Handle(new BanGroupAnonymousMemberApiMahuaCommand
            {
                ToGroup = toGroup,
                Anonymous = anonymous,
                Duration = duration,
            });
        }

        public void SetGroupAnonymousOption(string toGroup, bool enabled)
        {
            _commandCenter.Handle(new SetGroupAnonymousOptionApiMahuaCommand
            {
                ToGroup = toGroup,
                Enabled = enabled,
            });
        }

        public void SetGroupMemberCard(string toGroup, string toQq, string groupMemberCard)
        {
            _commandCenter.Handle(new SetGroupMemberCardApiMahuaCommand
            {
                ToGroup = toGroup,
                ToQq = toQq,
                GroupMemberCard = groupMemberCard,
            });
        }

        public void LeaveGroup(string toGroup)
        {
            _commandCenter.Handle(new LeaveGroupApiMahuaCommand
            {
                ToGroup = toGroup,
            });
        }

        public void DissolveGroup(string toGroup)
        {
            _commandCenter.Handle(new DissolveGroupApiMahuaCommand
            {
                ToGroup = toGroup,
            });
        }

        public void LeaveDiscuss(string toDiscuss)
        {
            _commandCenter.Handle(new LeaveDiscussApiMahuaCommand
            {
                ToDiscuss = toDiscuss,
            });
        }

        public void AcceptFriendAddingRequest(string addingFriendRequestId, string fromQq, string friendRemark)
        {
            _commandCenter.Handle(new AcceptFriendAddingRequestApiMahuaCommand
            {
                AddingFriendRequestId = addingFriendRequestId,
                FromQq = fromQq,
                FriendRemark = friendRemark,
            });
        }

        public void RejectFriendAddingRequest(string addingFriendRequestId, string fromQq)
        {
            _commandCenter.Handle(new RejectFriendAddingRequestApiMahuaCommand
            {
                AddingFriendRequestId = addingFriendRequestId,
                FromQq = fromQq,
            });
        }

        public void AcceptGroupJoiningRequest(string groupJoiningRequestId, string toGroup, string fromQq)
        {
            _commandCenter.Handle(new AcceptGroupJoiningRequestApiMahuaCommand
            {
                GroupJoiningRequestId = groupJoiningRequestId,
                ToGroup = toGroup,
                FromQq = fromQq,
            });
        }

        public void RejectGroupJoiningRequest(
            string groupJoiningRequestId,
            string toGroup,
            string fromQq,
            string reason)
        {
            _commandCenter.Handle(new RejectGroupJoiningRequestApiMahuaCommand
            {
                GroupJoiningRequestId = groupJoiningRequestId,
                ToGroup = toGroup,
                FromQq = fromQq,
                Reason = reason,
            });
        }

        public void AcceptGroupJoiningInvitation(string groupJoiningInvitationId, string toGroup, string fromQq)
        {
            _commandCenter.Handle(new AcceptGroupJoiningInvitationApiMahuaCommand
            {
                GroupJoiningInvitationId = groupJoiningInvitationId,
                ToGroup = toGroup,
                FromQq = fromQq
            });
        }

        public void RejectGroupJoiningInvitation(
            string groupJoiningInvitationId,
            string toGroup,
            string fromQq,
            string reason)
        {
            _commandCenter.Handle(new RejectGroupJoiningInvitationApiMahuaCommand
            {
                GroupJoiningInvitationId = groupJoiningInvitationId,
                ToGroup = toGroup,
                FromQq = fromQq,
                Reason = reason,
            });
        }

        public void BanFriend(string toQq)
        {
            _commandCenter.Handle(new BanFriendApiMahuaCommand
            {
                ToQq = toQq,
            });
        }

        public void RemoveBanFriend(string toQq)
        {
            _commandCenter.Handle(new RemoveBanFriendApiMahuaCommand
            {
                ToQq = toQq,
            });
        }

        public void SetNotice(string toGroup, string title, string content)
        {
            _commandCenter.Handle(new SetNoticeApiMahuaCommand
            {
                ToGroup = toGroup,
                Title = title,
                Content = content,
            });
        }

        public void RemoveFriend(string toQq)
        {
            _commandCenter.Handle(new RemoveFriendApiMahuaCommand
            {
                ToQq = toQq,
            });
        }

        public void JoinGroup(string toGroup, string reason)
        {
            _commandCenter.Handle(new JoinGroupApiMahuaCommand
            {
                ToGroup = toGroup,
                Reason = reason,
            });
        }

        public ModelWithSourceString<IEnumerable<GroupMemberInfo>> GetGroupMemebersWithModel(string toGroup)
        {
            var re = _commandCenter
                .HandleWithResult<GetGroupMemebersWithModelApiMahuaCommand, GetGroupMemebersWithModelApiMahuaCommandResult>(
                    new GetGroupMemebersWithModelApiMahuaCommand
                    {
                        ToGroup = toGroup,
                    });
            var reModelWithSourceString = re.ModelWithSourceString;
            return reModelWithSourceString;
        }

        public ModelWithSourceString<IEnumerable<GroupInfo>> GetGroupsWithModel()
        {
            var re = _commandCenter
                .HandleWithResult<GetGroupsWithModelApiMahuaCommand, GetGroupsWithModelApiMahuaCommandResult>(
                    new GetGroupsWithModelApiMahuaCommand
                    {
                    });
            var reModelWithSourceString = re.ModelWithSourceString;
            return reModelWithSourceString;
        }

        public string GetGroupMemebers(string toGroup)
        {
            var re = _commandCenter
                .HandleWithResult<GetGroupMemebersApiMahuaCommand, GetGroupMemebersApiMahuaCommandResult>(
                    new GetGroupMemebersApiMahuaCommand
                    {
                    });
            var groupMemebersString = re.GroupMemebersString;
            return groupMemebersString;
        }

        public string GetGroups()
        {
            var re = _commandCenter
                .HandleWithResult<GetGroupsApiMahuaCommand, GetGroupsApiMahuaCommandResult>(
                    new GetGroupsApiMahuaCommand
                    {
                    });
            var groupsString = re.GroupsString;
            return groupsString;
        }

        public string GetFriends()
        {
            var re = _commandCenter
                .HandleWithResult<GetFriendsApiMahuaCommand, GetFriendsApiMahuaCommandResult>(
                    new GetFriendsApiMahuaCommand
                    {
                    });
            var friendsString = re.FriendsString;
            return friendsString;
        }

        public void SendGroupJoiningInvitation(string toQq, string toGroup)
        {
            _commandCenter.Handle(new SendGroupJoiningInvitationApiMahuaCommand
            {
                ToGroup = toGroup,
                ToQq = toQq,
            });
        }

        public string CreateDiscuss()
        {
            var re = _commandCenter
                .HandleWithResult<CreateDiscussApiMahuaCommand, CreateDiscussApiMahuaCommandResult>(
                    new CreateDiscussApiMahuaCommand
                    {
                    });
            var discussId = re.DiscussId;
            return discussId;
        }

        public void KickDiscussMember(string toDiscuss, string toQq)
        {
            _commandCenter.Handle(new KickDiscussMemberApiMahuaCommand
            {
                ToQq = toQq,
                ToDiscuss = toDiscuss,
            });
        }

        public void SendDiscussJoiningInvitation(string toQq, string toDiscuss)
        {
            _commandCenter.Handle(new SendDiscussJoiningInvitationApiMahuaCommand
            {
                ToQq = toQq,
                ToDiscuss = toDiscuss,
            });
        }

        public string GetDiscusses()
        {
            var re = _commandCenter
                .HandleWithResult<GetDiscussesApiMahuaCommand, GetDiscussesApiMahuaCommandResult>(
                    new GetDiscussesApiMahuaCommand
                    {
                    });
            var discussesString = re.DiscussesString;
            return discussesString;
        }

        public ILifetimeScope GetContainer()
        {
            return GetLifetimeScope();
        }

        public void SetContainer(ILifetimeScope container)
        {
            SetLifetimeScope(container);
        }

        public ILifetimeScope GetLifetimeScope()
        {
            return _containerSaver.GetLifetimeScope();
        }

        public void SetLifetimeScope(ILifetimeScope container)
        {
            _containerSaver.SetLifetimeScope(container);
        }

        public IContainer GetSourceContainer()
        {
            return _containerSaver.GetSourceContainer();
        }

        public void SetSourceContainer(IContainer container)
        {
            _containerSaver.SetSourceContainer(container);
        }
    }
}
