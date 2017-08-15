using Autofac;
using Newbe.Mahua.Commands;

namespace Newbe.Mahua
{
    internal class PluginLoaderMahuaModule : IMahuaModule
    {
        Module[] IMahuaModule.GetModules()
        {
            return new Module[] { new PluginLoaderModule(), };
        }

        public class PluginLoaderModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<CommandCenter>().As<ICommandCenter>();
            }
        }
    }
}
