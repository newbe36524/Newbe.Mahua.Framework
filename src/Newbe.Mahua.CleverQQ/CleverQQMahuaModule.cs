using Autofac;
using Newbe.Mahua.Apis;
using Newbe.Mahua.CleverQQ.Apis;
using Newbe.Mahua.CleverQQ.Commands;
using Newbe.Mahua.CleverQQ.IrEvents;
using Newbe.Mahua.CleverQQ.Messages;
using Newbe.Mahua.CleverQQ.Messages.Builders;
using Newbe.Mahua.Messages;
using Newbe.Mahua.Messages.Builders;
using Newbe.Mahua.Messages.Steps;

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
                builder.RegisterType<IrDestroyPluginCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<EventFunCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<IrCreateCommandHandler>().AsImplementedInterfaces();
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
                builder.RegisterType<IrEventInputOutput>().As<IIrEventOutput>().InstancePerLifetimeScope();
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
                builder.RegisterType<IrEvent1>().AsImplementedInterfaces().Keyed<IIrEvent>(1);
                builder.RegisterType<IrEvent2>().AsImplementedInterfaces().Keyed<IIrEvent>(2);
                builder.RegisterType<IrEvent3>().AsImplementedInterfaces().Keyed<IIrEvent>(3);
                builder.RegisterType<IrEvent4>().AsImplementedInterfaces().Keyed<IIrEvent>(4);
                builder.RegisterType<IrEvent5>().AsImplementedInterfaces().Keyed<IIrEvent>(5);
                builder.RegisterType<IrEvent6>().AsImplementedInterfaces().Keyed<IIrEvent>(6);
                builder.RegisterType<IrEvent100>().AsImplementedInterfaces().Keyed<IIrEvent>(100);
                builder.RegisterType<IrEvent101>().AsImplementedInterfaces().Keyed<IIrEvent>(101);
                builder.RegisterType<IrEvent104>().AsImplementedInterfaces().Keyed<IIrEvent>(104);
                builder.RegisterType<IrEvent105>().AsImplementedInterfaces().Keyed<IIrEvent>(105);
                builder.RegisterType<IrEvent106>().AsImplementedInterfaces().Keyed<IIrEvent>(106);
                builder.RegisterType<IrEvent107>().AsImplementedInterfaces().Keyed<IIrEvent>(107);
                builder.RegisterType<IrEvent201>().AsImplementedInterfaces().Keyed<IIrEvent>(201);
                builder.RegisterType<IrEvent202>().AsImplementedInterfaces().Keyed<IIrEvent>(202);
                builder.RegisterType<IrEvent203>().AsImplementedInterfaces().Keyed<IIrEvent>(203);
                builder.RegisterType<IrEvent204>().AsImplementedInterfaces().Keyed<IIrEvent>(204);
                builder.RegisterType<IrEvent205>().AsImplementedInterfaces().Keyed<IIrEvent>(205);
                builder.RegisterType<IrEvent206>().AsImplementedInterfaces().Keyed<IIrEvent>(206);
                builder.RegisterType<IrEvent207>().AsImplementedInterfaces().Keyed<IIrEvent>(207);
                builder.RegisterType<IrEvent208>().AsImplementedInterfaces().Keyed<IIrEvent>(208);
                builder.RegisterType<IrEvent209>().AsImplementedInterfaces().Keyed<IIrEvent>(209);
                builder.RegisterType<IrEvent210>().AsImplementedInterfaces().Keyed<IIrEvent>(210);
                builder.RegisterType<IrEvent211>().AsImplementedInterfaces().Keyed<IIrEvent>(211);
                builder.RegisterType<IrEvent212>().AsImplementedInterfaces().Keyed<IIrEvent>(212);
                builder.RegisterType<IrEvent213>().AsImplementedInterfaces().Keyed<IIrEvent>(213);
                builder.RegisterType<IrEvent214>().AsImplementedInterfaces().Keyed<IIrEvent>(214);
                builder.RegisterType<IrEvent215>().AsImplementedInterfaces().Keyed<IIrEvent>(215);
                builder.RegisterType<IrEvent216>().AsImplementedInterfaces().Keyed<IIrEvent>(216);
                builder.RegisterType<IrEvent217>().AsImplementedInterfaces().Keyed<IIrEvent>(217);
                builder.RegisterType<IrEvent218>().AsImplementedInterfaces().Keyed<IIrEvent>(218);
                builder.RegisterType<IrEvent219>().AsImplementedInterfaces().Keyed<IIrEvent>(219);
                builder.RegisterType<IrEvent220>().AsImplementedInterfaces().Keyed<IIrEvent>(220);
                builder.RegisterType<IrEvent221>().AsImplementedInterfaces().Keyed<IIrEvent>(221);
                builder.RegisterType<IrEvent1100>().AsImplementedInterfaces().Keyed<IIrEvent>(1100);
                builder.RegisterType<IrEvent1101>().AsImplementedInterfaces().Keyed<IIrEvent>(1101);
                builder.RegisterType<IrEvent1102>().AsImplementedInterfaces().Keyed<IIrEvent>(1102);
                builder.RegisterType<IrEvent1103>().AsImplementedInterfaces().Keyed<IIrEvent>(1103);
                builder.RegisterType<IrEvent1104>().AsImplementedInterfaces().Keyed<IIrEvent>(1104);
                builder.RegisterType<IrEvent10000>().AsImplementedInterfaces().Keyed<IIrEvent>(10000);
                builder.RegisterType<IrEvent10001>().AsImplementedInterfaces().Keyed<IIrEvent>(10001);
                builder.RegisterType<IrEvent12000>().AsImplementedInterfaces().Keyed<IIrEvent>(12000);
                builder.RegisterType<IrEvent12001>().AsImplementedInterfaces().Keyed<IIrEvent>(12001);
                builder.RegisterType<IrEvent12002>().AsImplementedInterfaces().Keyed<IIrEvent>(12002);
                builder.RegisterType<IrEvent12003>().AsImplementedInterfaces().Keyed<IIrEvent>(12003);
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
