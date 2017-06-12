using Autofac;
using Newbe.Mahua.Commands;
using Newbe.Mahua.Commands.Impl;

namespace Newbe.Mahua
{
    class PluginLoaderMahuaModule : IMahuaModule
    {
        Module[] IMahuaModule.GetModules()
        {
            return new Module[] {new PluginLoaderModule(),};
        }

        public class PluginLoaderModule : Autofac.Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<CommandCenter>().As<ICommandCenter>();
            }
        }
    }
}