using Autofac;
using Newbe.Mahua.CQP.Commands;
using Newbe.Mahua.CQP.NativeApi;

namespace Newbe.Mahua.CQP
{
    public class CqpMahuaModule : IMahuaModule
    {
        Module[] IMahuaModule.GetModules()
        {
            return new Module[] {new CqpModule(), new CommandModule(), new CommandHandlersModule()};
        }

        private class CommandModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<AddFriendRequestCommand>().AsImplementedInterfaces();
                builder.RegisterType<AppInfoCommand>().AsImplementedInterfaces();
                builder.RegisterType<CoolQExitedCommand>().AsImplementedInterfaces();
                builder.RegisterType<DisabledCommand>().AsImplementedInterfaces();
                builder.RegisterType<DiscussGroupMessageCommand>().AsImplementedInterfaces();
                builder.RegisterType<EnabledCommand>().AsImplementedInterfaces();
                builder.RegisterType<FriendsAddedCommand>().AsImplementedInterfaces();
                builder.RegisterType<GroupAdminChangeCommand>().AsImplementedInterfaces();
                builder.RegisterType<GroupMemberDecreasedCommand>().AsImplementedInterfaces();
                builder.RegisterType<GroupMemberIncreasedCommand>().AsImplementedInterfaces();
                builder.RegisterType<GroupMessageCommand>().AsImplementedInterfaces();
                builder.RegisterType<GroupUploadedCommand>().AsImplementedInterfaces();
                builder.RegisterType<InitializeCommand>().AsImplementedInterfaces();
                builder.RegisterType<GroupJoiningInvitationCommand>().AsImplementedInterfaces();
                builder.RegisterType<GroupJoiningRequestCommand>().AsImplementedInterfaces();
                builder.RegisterType<PrivateMessageCommand>().AsImplementedInterfaces();
            }
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
            }
        }

        private class CqpModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<CoolQApi>().As<ICoolQApi>();
                builder.RegisterType<MahuaApi>().As<IMahuaApi>().SingleInstance();
                builder.RegisterType<CqpAuthCodeContainer>().As<ICqpAuthCodeContainer>().SingleInstance();
            }
        }
    }
}