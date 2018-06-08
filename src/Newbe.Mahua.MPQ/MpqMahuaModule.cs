using Autofac;
using Newbe.Mahua.Apis;
using Newbe.Mahua.Messages;
using Newbe.Mahua.Messages.Builders;
using Newbe.Mahua.Messages.Steps;
using Newbe.Mahua.MPQ.Apis;
using Newbe.Mahua.MPQ.Commands;
using Newbe.Mahua.MPQ.EventFuns;
using Newbe.Mahua.MPQ.Messages;
using Newbe.Mahua.MPQ.Messages.Builders;

namespace Newbe.Mahua.MPQ
{
    public class MpqMahuaModule : IMahuaModule
    {
        public Module[] GetModules()
        {
            return new Module[]
            {
                new MpqModule(),
                new MpqCommandHandlerModule(),
                new MpqApiModule(),
                new ApiCommandHandlersModule(),
                new MpqEventFunModule(),
                new MessageBuilderStepModule(),
                new MessageBuilderModule(),
            };
        }

        private class MpqModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<QqProvider>().As<IQqProvider>();
            }
        }

        private class MpqCommandHandlerModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<AboutCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<EndCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<EventFunCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<GetInfoCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<ConfigurationManagerCommandHandler>().AsImplementedInterfaces();
            }
        }

        private class MpqApiModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<EventFunOutput>().As<IEventFunOutput>().InstancePerLifetimeScope();
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

        private class MpqEventFunModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<EventFun1>().AsImplementedInterfaces().Keyed<IEventFun>(1);
                builder.RegisterType<EventFun2>().AsImplementedInterfaces().Keyed<IEventFun>(2);
                builder.RegisterType<EventFun3>().AsImplementedInterfaces().Keyed<IEventFun>(3);
                builder.RegisterType<EventFun4>().AsImplementedInterfaces().Keyed<IEventFun>(4);
                builder.RegisterType<EventFun5>().AsImplementedInterfaces().Keyed<IEventFun>(5);
                builder.RegisterType<EventFun1000>().AsImplementedInterfaces().Keyed<IEventFun>(1000);
                builder.RegisterType<EventFun1001>().AsImplementedInterfaces().Keyed<IEventFun>(1001);
                builder.RegisterType<EventFun1002>().AsImplementedInterfaces().Keyed<IEventFun>(1002);
                builder.RegisterType<EventFun1003>().AsImplementedInterfaces().Keyed<IEventFun>(1003);
                builder.RegisterType<EventFun1004>().AsImplementedInterfaces().Keyed<IEventFun>(1004);
                builder.RegisterType<EventFun1005>().AsImplementedInterfaces().Keyed<IEventFun>(1005);
                builder.RegisterType<EventFun1006>().AsImplementedInterfaces().Keyed<IEventFun>(1006);
                builder.RegisterType<EventFun1007>().AsImplementedInterfaces().Keyed<IEventFun>(1007);
                builder.RegisterType<EventFun1008>().AsImplementedInterfaces().Keyed<IEventFun>(1008);
                builder.RegisterType<EventFun2001>().AsImplementedInterfaces().Keyed<IEventFun>(2001);
                builder.RegisterType<EventFun2002>().AsImplementedInterfaces().Keyed<IEventFun>(2002);
                builder.RegisterType<EventFun2003>().AsImplementedInterfaces().Keyed<IEventFun>(2003);
                builder.RegisterType<EventFun2005>().AsImplementedInterfaces().Keyed<IEventFun>(2005);
                builder.RegisterType<EventFun2006>().AsImplementedInterfaces().Keyed<IEventFun>(2006);
                builder.RegisterType<EventFun2007>().AsImplementedInterfaces().Keyed<IEventFun>(2007);
                builder.RegisterType<EventFun2008>().AsImplementedInterfaces().Keyed<IEventFun>(2008);
                builder.RegisterType<EventFun2009>().AsImplementedInterfaces().Keyed<IEventFun>(2009);
                builder.RegisterType<EventFun2010>().AsImplementedInterfaces().Keyed<IEventFun>(2010);
                builder.RegisterType<EventFun2011>().AsImplementedInterfaces().Keyed<IEventFun>(2011);
                builder.RegisterType<EventFun2012>().AsImplementedInterfaces().Keyed<IEventFun>(2012);
                builder.RegisterType<EventFun2013>().AsImplementedInterfaces().Keyed<IEventFun>(2013);
                builder.RegisterType<EventFun2014>().AsImplementedInterfaces().Keyed<IEventFun>(2014);
                builder.RegisterType<EventFun2015>().AsImplementedInterfaces().Keyed<IEventFun>(2015);
                builder.RegisterType<EventFun2016>().AsImplementedInterfaces().Keyed<IEventFun>(2016);
                builder.RegisterType<EventFun2017>().AsImplementedInterfaces().Keyed<IEventFun>(2017);
                builder.RegisterType<EventFun2018>().AsImplementedInterfaces().Keyed<IEventFun>(2018);
                builder.RegisterType<EventFun2019>().AsImplementedInterfaces().Keyed<IEventFun>(2019);
                builder.RegisterType<EventFun10000>().AsImplementedInterfaces().Keyed<IEventFun>(10000);
                builder.RegisterType<EventFun10001>().AsImplementedInterfaces().Keyed<IEventFun>(10001);
                builder.RegisterType<EventFun11000>().AsImplementedInterfaces().Keyed<IEventFun>(11000);
                builder.RegisterType<EventFun11001>().AsImplementedInterfaces().Keyed<IEventFun>(11001);
                builder.RegisterType<EventFun11002>().AsImplementedInterfaces().Keyed<IEventFun>(11002);
                builder.RegisterType<EventFun11003>().AsImplementedInterfaces().Keyed<IEventFun>(11003);
                builder.RegisterType<EventFun11004>().AsImplementedInterfaces().Keyed<IEventFun>(11004);
                builder.RegisterType<EventFun12000>().AsImplementedInterfaces().Keyed<IEventFun>(12000);
                builder.RegisterType<EventFun12001>().AsImplementedInterfaces().Keyed<IEventFun>(12001);
                builder.RegisterType<EventFun12002>().AsImplementedInterfaces().Keyed<IEventFun>(12002);
                builder.RegisterType<EventFun12003>().AsImplementedInterfaces().Keyed<IEventFun>(12003);
                builder.RegisterType<EventFun80001>().AsImplementedInterfaces().Keyed<IEventFun>(80001);
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
                builder.RegisterType<MpqMessage>().As<IMpqMessage>().InstancePerLifetimeScope();
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
                builder.RegisterType<MpqMessageBuilder>().As<IAt>().InstancePerLifetimeScope();
                builder.RegisterType<MpqMessageBuilder>().As<IAtAll>().InstancePerLifetimeScope();
                builder.RegisterType<MpqMessageBuilder>().As<IBFace>().InstancePerLifetimeScope();
                builder.RegisterType<MpqMessageBuilder>().As<IEmoji>().InstancePerLifetimeScope();
                builder.RegisterType<MpqMessageBuilder>().As<IFace>().InstancePerLifetimeScope();
                builder.RegisterType<MpqMessageBuilder>().As<IImage>().InstancePerLifetimeScope();
                builder.RegisterType<MpqMessageBuilder>().As<IRecord>().InstancePerLifetimeScope();
                builder.RegisterType<MpqMessageBuilder>().As<ISFace>().InstancePerLifetimeScope();
                builder.RegisterType<MpqMessageBuilder>().As<IShake>().InstancePerLifetimeScope();
                builder.RegisterType<MpqMessageBuilder>().As<IText>().InstancePerLifetimeScope();
            }
        }
    }
}
