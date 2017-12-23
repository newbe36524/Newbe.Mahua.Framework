using Autofac;
using Newbe.Mahua.CQP.Commands;

namespace Newbe.Mahua.CQP
{
    public class MahuaModule : IMahuaModule
    {
        Module[] IMahuaModule.GetModules()
        {
            return new Module[] { new CqpModule(), new CommandHandlersModule() };
        }

        internal class CommandHandlersModule : Module
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
            }
        }

        internal class CqpModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<GroupInfoSerializer>().AsImplementedInterfaces();
                builder.RegisterType<GroupMemberInfoSerializer>().AsImplementedInterfaces();
                builder.RegisterType<MahuaApi>().As<IMahuaApi>().InstancePerLifetimeScope();
            }
        }
    }
}
