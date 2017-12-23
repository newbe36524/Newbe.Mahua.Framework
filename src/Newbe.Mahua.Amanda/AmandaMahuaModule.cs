using Autofac;
using Newbe.Mahua.Amanda.Commands;

namespace Newbe.Mahua.Amanda
{
    public class AmandaMahuaModule : IMahuaModule
    {
        Module[] IMahuaModule.GetModules()
        {
            return new Module[] { new AmandaApiModule(), new AmandaCommandHandlerModule() };
        }

        private class AmandaCommandHandlerModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<AddFrinendCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<AddGroupCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<AdminChangeCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<BecomeFriendsCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<GetNewMsgCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<GetQqWalletDataCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<GroupMemberDecreaseCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<GroupMemberIncreaseCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<InformationCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<InitializationCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<ConfigurationManagerCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<PluginStartCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<PluginStopCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<UpdataCookiesCommandHandler>().AsImplementedInterfaces();
            }
        }

        private class AmandaApiModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<MahuaApi>().As<IMahuaApi>().InstancePerLifetimeScope();
            }
        }
    }
}
