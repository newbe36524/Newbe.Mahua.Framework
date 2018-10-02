using Autofac;
using Newbe.Mahua.Apis;
using Newbe.Mahua.CQP.Apis;
using Newbe.Mahua.CQP.Commands;
using Newbe.Mahua.CQP.Messages;
using Newbe.Mahua.CQP.Messages.Builders;
using Newbe.Mahua.CQP.Messages.CancelMessage;
using Newbe.Mahua.Messages;
using Newbe.Mahua.Messages.Builders;
using Newbe.Mahua.Messages.CancelMessage;
using Newbe.Mahua.Messages.Steps;

namespace Newbe.Mahua.CQP
{
    public class CqpMahuaModule : IMahuaModule
    {
        Module[] IMahuaModule.GetModules()
        {
            return new Module[]
            {
                new CqpModule(),
                new CommandHandlersModule(),
                new ApiCommandHandlersModule(),
                new MessageBuilderStepModule(),
                new MessageBuilderModule(),
            };
        }

        private class CommandHandlersModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<AddFriendRequestCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<AppInfoCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<CoolQExitedCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<DisabledCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<DiscussGroupMessageCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<EnabledCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<FriendsAddedCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<GroupAdminChangeCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<GroupMemberDecreasedCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<GroupMemberIncreasedCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<GroupMessageCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<GroupUploadedCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<InitializeCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<GroupJoiningInvitationCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<GroupJoiningRequestCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<PrivateMessageCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<ConfigurationManagerCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<PluginHotUpgradingCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<PluginHotUpgradedCommandHandler>().AsImplementedInterfaces();
            }
        }

        private class ApiCommandHandlersModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder
                    .RegisterMahuaApi<AcceptFriendAddingRequestApiMahuaMahuaCommandHandler,
                        AcceptFriendAddingRequestApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder
                    .RegisterMahuaApi<AcceptGroupJoiningInvitationApiMahuaMahuaCommandHandler,
                        AcceptGroupJoiningInvitationApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder
                    .RegisterMahuaApi<AcceptGroupJoiningRequestApiMahuaMahuaCommandHandler,
                        AcceptGroupJoiningRequestApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder
                    .RegisterMahuaApi<BanGroupAnonymousMemberApiMahuaMahuaCommandHandler,
                        BanGroupAnonymousMemberApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<BanGroupMemberApiMahuaMahuaCommandHandler, BanGroupMemberApiMahuaCommand>(
                    MahuaGlobal.DefaultApiHandlerAuthorName);
                builder
                    .RegisterMahuaApi<DisableGroupAdminApiMahuaMahuaCommandHandler, DisableGroupAdminApiMahuaCommand>(
                        MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<DissolveGroupApiMahuaMahuaCommandHandler, DissolveGroupApiMahuaCommand>(
                    MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<EnableGroupAdminApiMahuaMahuaCommandHandler, EnableGroupAdminApiMahuaCommand>(
                    MahuaGlobal.DefaultApiHandlerAuthorName);
                builder
                    .RegisterMahuaApi<GetBknApiMahuaCommandHandler, GetBknApiMahuaCommand, GetBknApiMahuaCommandResult>(
                        MahuaGlobal.DefaultApiHandlerAuthorName);
                builder
                    .RegisterMahuaApi<GetCookiesApiMahuaCommandHandler, GetCookiesApiMahuaCommand,
                        GetCookiesApiMahuaCommandResult>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder
                    .RegisterMahuaApi<GetGroupMemebersApiMahuaCommandHandler, GetGroupMemebersApiMahuaCommand,
                        GetGroupMemebersApiMahuaCommandResult>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder
                    .RegisterMahuaApi<GetGroupMemebersWithModelApiMahuaCommandHandler,
                        GetGroupMemebersWithModelApiMahuaCommand, GetGroupMemebersWithModelApiMahuaCommandResult>(
                        MahuaGlobal.DefaultApiHandlerAuthorName);
                builder
                    .RegisterMahuaApi<GetGroupsApiMahuaCommandHandler, GetGroupsApiMahuaCommand,
                        GetGroupsApiMahuaCommandResult>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder
                    .RegisterMahuaApi<GetGroupsWithModelApiMahuaCommandHandler, GetGroupsWithModelApiMahuaCommand,
                        GetGroupsWithModelApiMahuaCommandResult>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder
                    .RegisterMahuaApi<GetLoginNickApiMahuaCommandHandler, GetLoginNickApiMahuaCommand,
                        GetLoginNickApiMahuaCommandResult>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder
                    .RegisterMahuaApi<GetLoginQqApiMahuaCommandHandler, GetLoginQqApiMahuaCommand,
                        GetLoginQqApiMahuaCommandResult>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<KickGroupMemberApiMahuaMahuaCommandHandler, KickGroupMemberApiMahuaCommand>(
                    MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<LeaveDiscussApiMahuaMahuaCommandHandler, LeaveDiscussApiMahuaCommand>(
                    MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<LeaveGroupApiMahuaMahuaCommandHandler, LeaveGroupApiMahuaCommand>(MahuaGlobal
                    .DefaultApiHandlerAuthorName);
                builder
                    .RegisterMahuaApi<RejectFriendAddingRequestApiMahuaMahuaCommandHandler,
                        RejectFriendAddingRequestApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder
                    .RegisterMahuaApi<RejectGroupJoiningInvitationApiMahuaMahuaCommandHandler,
                        RejectGroupJoiningInvitationApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder
                    .RegisterMahuaApi<RejectGroupJoiningRequestApiMahuaMahuaCommandHandler,
                        RejectGroupJoiningRequestApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder
                    .RegisterMahuaApi<RemoveBanGroupMemberApiMahuaMahuaCommandHandler,
                        RemoveBanGroupMemberApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder
                    .RegisterMahuaApi<SendDiscussMessageApiMahuaCommandHandler, SendDiscussMessageApiMahuaCommand,
                        SendDiscussMessageApiMahuaCommandResult>(
                        MahuaGlobal.DefaultApiHandlerAuthorName);
                builder
                    .RegisterMahuaApi<SendGroupMessageApiMahuaMahuaCommandHandler, SendGroupMessageApiMahuaCommand,
                        SendGroupMessageApiMahuaCommandResult>(
                        MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<SendLikeApiMahuaMahuaCommandHandler, SendLikeApiMahuaCommand>(MahuaGlobal
                    .DefaultApiHandlerAuthorName);
                builder
                    .RegisterMahuaApi<SendPrivateMessageApiMahuaMahuaCommandHandler, SendPrivateMessageApiMahuaCommand,
                        SendPrivateMessageApiMahuaCommandResult>(
                        MahuaGlobal.DefaultApiHandlerAuthorName);
                builder
                    .RegisterMahuaApi<SetBanAllGroupMembersOptionApiMahuaMahuaCommandHandler,
                        SetBanAllGroupMembersOptionApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder
                    .RegisterMahuaApi<SetGroupAnonymousOptionApiMahuaMahuaCommandHandler,
                        SetGroupAnonymousOptionApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder
                    .RegisterMahuaApi<SetGroupMemberCardApiMahuaMahuaCommandHandler, SetGroupMemberCardApiMahuaCommand>(
                        MahuaGlobal.DefaultApiHandlerAuthorName);
                builder
                    .RegisterMahuaApi<SetGroupMemberSpecialTitleApiMahuaMahuaCommandHandler,
                        SetGroupMemberSpecialTitleApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
            }
        }

        private class CqpModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<GroupInfoSerializer>().AsImplementedInterfaces();
                builder.RegisterType<GroupMemberInfoSerializer>().AsImplementedInterfaces();
                builder.RegisterType<QqProvider>().As<IQqProvider>();
            }
        }

        private class MessageBuilderStepModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<DiscussMessageDone>().As<IDiscussMessageDone>().InstancePerLifetimeScope();
                builder.RegisterType<DiscussMessageFlowFactory>().As<IDiscussMessageFlowFactory>()
                    .InstancePerLifetimeScope();
                builder.RegisterType<DiscussMessageStep>().As<IDiscussMessageStep>().InstancePerLifetimeScope();
                builder.RegisterType<DiscussMessageStep2>().As<IDiscussMessageStep2>().InstancePerLifetimeScope();
                builder.RegisterType<GroupMessageDone>().As<IGroupMessageDone>().InstancePerLifetimeScope();
                builder.RegisterType<GroupMessageFlowFactory>().As<IGroupMessageFlowFactory>()
                    .InstancePerLifetimeScope();
                builder.RegisterType<GroupMessageStep>().As<IGroupMessageStep>().InstancePerLifetimeScope();
                builder.RegisterType<GroupMessageStep2>().As<IGroupMessageStep2>().InstancePerLifetimeScope();
                builder.RegisterType<Message>().As<IMessage>().InstancePerLifetimeScope();
                builder.RegisterType<PrivateMessageDone>().As<IPrivateMessageDone>().InstancePerLifetimeScope();
                builder.RegisterType<PrivateMessageFlowFactory>().As<IPrivateMessageFlowFactory>()
                    .InstancePerLifetimeScope();
                builder.RegisterType<PrivateMessageStep>().As<IPrivateMessageStep>().InstancePerLifetimeScope();
                builder.RegisterType<PrivateMessageStep2>().As<IPrivateMessageStep2>().InstancePerLifetimeScope();
                builder.RegisterType<CqpMessageCancelToken>().AsSelf().InstancePerDependency();
            }
        }

        private class MessageBuilderModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<CqpMessageBuilder>().As<IAt>().InstancePerLifetimeScope();
                builder.RegisterType<CqpMessageBuilder>().As<IAtAll>().InstancePerLifetimeScope();
                builder.RegisterType<CqpMessageBuilder>().As<IBFace>().InstancePerLifetimeScope();
                builder.RegisterType<CqpMessageBuilder>().As<IEmoji>().InstancePerLifetimeScope();
                builder.RegisterType<CqpMessageBuilder>().As<IFace>().InstancePerLifetimeScope();
                builder.RegisterType<CqpMessageBuilder>().As<IImage>().InstancePerLifetimeScope();
                builder.RegisterType<CqpMessageBuilder>().As<IRecord>().InstancePerLifetimeScope();
                builder.RegisterType<CqpMessageBuilder>().As<ISFace>().InstancePerLifetimeScope();
                builder.RegisterType<CqpMessageBuilder>().As<IShake>().InstancePerLifetimeScope();
                builder.RegisterType<CqpMessageBuilder>().As<IText>().InstancePerLifetimeScope();
            }
        }
    }
}