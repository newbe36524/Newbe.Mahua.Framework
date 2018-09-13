using Autofac;
using Newbe.Mahua.Apis;
using Newbe.Mahua.Messages;
using Newbe.Mahua.Messages.Builders;
using Newbe.Mahua.Messages.Steps;
using Newbe.Mahua.CleverQQ.Apis;
using Newbe.Mahua.CleverQQ.Commands;
using Newbe.Mahua.CleverQQ.IR_Event;
using Newbe.Mahua.CleverQQ.Messages;
using Newbe.Mahua.CleverQQ.Messages.Builders;

namespace Newbe.Mahua.CleverQQ
{
    public class CleverQQMahuaModule : IMahuaModule
    {
        public Module[] GetModules()
        {
            return new Module[]
            {
                new CleverQQModule(),
                new CleverQQCommandHandlerModule(),
                new CleverQQApiModule(),
                new ApiCommandHandlersModule(),
                new CleverQQEventFunModule(),
                new MessageBuilderStepModule(),
                new MessageBuilderModule(),
            };
        }

        private class CleverQQModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<QqProvider>().As<IQqProvider>();
            }
        }

        private class CleverQQCommandHandlerModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<IR_DestroyPluginCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<EventFunCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<IR_CreateCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<ConfigurationManagerCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<PluginHotUpgradingCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<PluginHotUpgradedCommandHandler>().AsImplementedInterfaces();
            }
        }

        private class CleverQQApiModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<IR_EventInputOutput>().As<IIR_EventOutput>().InstancePerLifetimeScope();
            }
        }

        private class ApiCommandHandlersModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterMahuaApi<AcceptFriendAddingRequestApiMahuaCommandHandler, AcceptFriendAddingRequestApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<AcceptGroupJoiningInvitationApiMahuaCommandHandler, AcceptGroupJoiningInvitationApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<AcceptGroupJoiningRequestApiMahuaCommandHandler, AcceptGroupJoiningRequestApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<BanFriendApiMahuaCommandHandler, BanFriendApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<BanGroupMemberApiMahuaCommandHandler, BanGroupMemberApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<CreateDiscussApiMahuaCommandHandler, CreateDiscussApiMahuaCommand, CreateDiscussApiMahuaCommandResult>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<DissolveGroupApiMahuaCommandHandler, DissolveGroupApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<GetBknApiMahuaCommandHandler, GetBknApiMahuaCommand, GetBknApiMahuaCommandResult>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<GetCookiesApiMahuaCommandHandler, GetCookiesApiMahuaCommand, GetCookiesApiMahuaCommandResult>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<GetDiscussesApiMahuaCommandHandler, GetDiscussesApiMahuaCommand, GetDiscussesApiMahuaCommandResult>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<GetFriendsApiMahuaCommandHandler, GetFriendsApiMahuaCommand, GetFriendsApiMahuaCommandResult>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<GetGroupMemebersApiMahuaCommandHandler, GetGroupMemebersApiMahuaCommand, GetGroupMemebersApiMahuaCommandResult>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<GetGroupMemebersWithModelApiMahuaCommandHandler, GetGroupMemebersWithModelApiMahuaCommand, GetGroupMemebersWithModelApiMahuaCommandResult>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<GetGroupsApiMahuaCommandHandler, GetGroupsApiMahuaCommand, GetGroupsApiMahuaCommandResult>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<GetGroupsWithModelApiMahuaCommandHandler, GetGroupsWithModelApiMahuaCommand, GetGroupsWithModelApiMahuaCommandResult>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<GetLoginNickApiMahuaCommandHandler, GetLoginNickApiMahuaCommand, GetLoginNickApiMahuaCommandResult>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<GetLoginQqApiMahuaCommandHandler, GetLoginQqApiMahuaCommand, GetLoginQqApiMahuaCommandResult>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<JoinGroupApiMahuaCommandHandler, JoinGroupApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<KickDiscussMemberApiMahuaCommandHandler, KickDiscussMemberApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<KickGroupMemberApiMahuaCommandHandler, KickGroupMemberApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<LeaveDiscussApiMahuaCommandHandler, LeaveDiscussApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<LeaveGroupApiMahuaCommandHandler, LeaveGroupApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<RejectFriendAddingRequestApiMahuaCommandHandler, RejectFriendAddingRequestApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<RejectGroupJoiningInvitationApiMahuaCommandHandler, RejectGroupJoiningInvitationApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<RejectGroupJoiningRequestApiMahuaCommandHandler, RejectGroupJoiningRequestApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<RemoveBanFriendApiMahuaCommandHandler, RemoveBanFriendApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<RemoveBanGroupMemberApiMahuaCommandHandler, RemoveBanGroupMemberApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<RemoveFriendApiMahuaCommandHandler, RemoveFriendApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<SendDiscussJoiningInvitationApiMahuaCommandHandler, SendDiscussJoiningInvitationApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<SendDiscussMessageApiMahuaCommandHandler, SendDiscussMessageApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<SendGroupJoiningInvitationApiMahuaCommandHandler, SendGroupJoiningInvitationApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<SendGroupMessageApiMahuaCommandHandler, SendGroupMessageApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<SendPrivateMessageApiMahuaCommandHandler, SendPrivateMessageApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<SetBanAllGroupMembersOptionApiMahuaCommandHandler, SetBanAllGroupMembersOptionApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<SetGroupMemberCardApiMahuaCommandHandler, SetGroupMemberCardApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<SetNoticeApiMahuaCommandHandler, SetNoticeApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
            }
        }

        private class CleverQQEventFunModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<IR_Event1>().AsImplementedInterfaces().Keyed<IIR_Event>(1);
                builder.RegisterType<IR_Event2>().AsImplementedInterfaces().Keyed<IIR_Event>(2);
                builder.RegisterType<IR_Event3>().AsImplementedInterfaces().Keyed<IIR_Event>(3);
                builder.RegisterType<IR_Event4>().AsImplementedInterfaces().Keyed<IIR_Event>(4);
                builder.RegisterType<IR_Event5>().AsImplementedInterfaces().Keyed<IIR_Event>(5);
                builder.RegisterType<IR_Event6>().AsImplementedInterfaces().Keyed<IIR_Event>(6);
                builder.RegisterType<IR_Event100>().AsImplementedInterfaces().Keyed<IIR_Event>(100);
                builder.RegisterType<IR_Event101>().AsImplementedInterfaces().Keyed<IIR_Event>(101);
                builder.RegisterType<IR_Event104>().AsImplementedInterfaces().Keyed<IIR_Event>(104);
                builder.RegisterType<IR_Event105>().AsImplementedInterfaces().Keyed<IIR_Event>(105);
                builder.RegisterType<IR_Event106>().AsImplementedInterfaces().Keyed<IIR_Event>(106);
                builder.RegisterType<IR_Event107>().AsImplementedInterfaces().Keyed<IIR_Event>(107);
                builder.RegisterType<IR_Event201>().AsImplementedInterfaces().Keyed<IIR_Event>(201);
                builder.RegisterType<IR_Event202>().AsImplementedInterfaces().Keyed<IIR_Event>(202);
                builder.RegisterType<IR_Event203>().AsImplementedInterfaces().Keyed<IIR_Event>(203);
                builder.RegisterType<IR_Event204>().AsImplementedInterfaces().Keyed<IIR_Event>(204);
                builder.RegisterType<IR_Event205>().AsImplementedInterfaces().Keyed<IIR_Event>(205);
                builder.RegisterType<IR_Event206>().AsImplementedInterfaces().Keyed<IIR_Event>(206);
                builder.RegisterType<IR_Event207>().AsImplementedInterfaces().Keyed<IIR_Event>(207);
                builder.RegisterType<IR_Event208>().AsImplementedInterfaces().Keyed<IIR_Event>(208);
                builder.RegisterType<IR_Event209>().AsImplementedInterfaces().Keyed<IIR_Event>(209);
                builder.RegisterType<IR_Event210>().AsImplementedInterfaces().Keyed<IIR_Event>(210);
                builder.RegisterType<IR_Event211>().AsImplementedInterfaces().Keyed<IIR_Event>(211);
                builder.RegisterType<IR_Event212>().AsImplementedInterfaces().Keyed<IIR_Event>(212);
                builder.RegisterType<IR_Event213>().AsImplementedInterfaces().Keyed<IIR_Event>(213);
                builder.RegisterType<IR_Event214>().AsImplementedInterfaces().Keyed<IIR_Event>(214);
                builder.RegisterType<IR_Event215>().AsImplementedInterfaces().Keyed<IIR_Event>(215);
                builder.RegisterType<IR_Event216>().AsImplementedInterfaces().Keyed<IIR_Event>(216);
                builder.RegisterType<IR_Event217>().AsImplementedInterfaces().Keyed<IIR_Event>(217);
                builder.RegisterType<IR_Event218>().AsImplementedInterfaces().Keyed<IIR_Event>(218);
                builder.RegisterType<IR_Event219>().AsImplementedInterfaces().Keyed<IIR_Event>(219);
                builder.RegisterType<IR_Event220>().AsImplementedInterfaces().Keyed<IIR_Event>(220);
                builder.RegisterType<IR_Event221>().AsImplementedInterfaces().Keyed<IIR_Event>(221);
                builder.RegisterType<IR_Event1100>().AsImplementedInterfaces().Keyed<IIR_Event>(1100);
                builder.RegisterType<IR_Event1101>().AsImplementedInterfaces().Keyed<IIR_Event>(1101);
                builder.RegisterType<IR_Event1102>().AsImplementedInterfaces().Keyed<IIR_Event>(1102);
                builder.RegisterType<IR_Event1103>().AsImplementedInterfaces().Keyed<IIR_Event>(1103);
                builder.RegisterType<IR_Event1104>().AsImplementedInterfaces().Keyed<IIR_Event>(1104);
                builder.RegisterType<IR_Event10000>().AsImplementedInterfaces().Keyed<IIR_Event>(10000);
                builder.RegisterType<IR_Event10001>().AsImplementedInterfaces().Keyed<IIR_Event>(10001);
                builder.RegisterType<IR_Event12000>().AsImplementedInterfaces().Keyed<IIR_Event>(12000);
                builder.RegisterType<IR_Event12001>().AsImplementedInterfaces().Keyed<IIR_Event>(12001);
                builder.RegisterType<IR_Event12002>().AsImplementedInterfaces().Keyed<IIR_Event>(12002);
                builder.RegisterType<IR_Event12003>().AsImplementedInterfaces().Keyed<IIR_Event>(12003);
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
                builder.RegisterType<CleverQQMessage>().As<ICleverQQMessage>().InstancePerLifetimeScope();
                builder.RegisterType<PrivateMessageDone>().As<IPrivateMessageDone>().InstancePerLifetimeScope();
                builder.RegisterType<PrivateMessageFlowFactory>().As<IPrivateMessageFlowFactory>()
                    .InstancePerLifetimeScope();
                builder.RegisterType<PrivateMessageStep>().As<IPrivateMessageStep>().InstancePerLifetimeScope();
                builder.RegisterType<PrivateMessageStep2>().As<IPrivateMessageStep2>().InstancePerLifetimeScope();
            }
        }

        private class MessageBuilderModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<CleverQQMessageBuilder>().As<IAt>().InstancePerLifetimeScope();
                builder.RegisterType<CleverQQMessageBuilder>().As<IAtAll>().InstancePerLifetimeScope();
                builder.RegisterType<CleverQQMessageBuilder>().As<IBFace>().InstancePerLifetimeScope();
                builder.RegisterType<CleverQQMessageBuilder>().As<IEmoji>().InstancePerLifetimeScope();
                builder.RegisterType<CleverQQMessageBuilder>().As<IFace>().InstancePerLifetimeScope();
                builder.RegisterType<CleverQQMessageBuilder>().As<IImage>().InstancePerLifetimeScope();
                builder.RegisterType<CleverQQMessageBuilder>().As<IRecord>().InstancePerLifetimeScope();
                builder.RegisterType<CleverQQMessageBuilder>().As<ISFace>().InstancePerLifetimeScope();
                builder.RegisterType<CleverQQMessageBuilder>().As<IShake>().InstancePerLifetimeScope();
                builder.RegisterType<CleverQQMessageBuilder>().As<IText>().InstancePerLifetimeScope();
            }
        }
    }
}
