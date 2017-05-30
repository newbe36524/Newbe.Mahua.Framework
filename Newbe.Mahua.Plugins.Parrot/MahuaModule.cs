using Autofac;
using Newbe.Mahua.Framework;
using Newbe.Mahua.Framework.MahuaEvents;

namespace Newbe.Mahua.Plugins.Parrot
{
    public class MahuaModule : IMahuaModule
    {
        public Module[] GetModules()
        {
            return new Module[] {new PluginModule(),};
        }

        private class PluginModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<PluginInfo>().As<IPluginInfo>();
                builder.RegisterType<PrivateMessageReceivedMahuaEvent>().As<IPrivateMessageReceivedMahuaEvent>();
            }
        }
    }
}