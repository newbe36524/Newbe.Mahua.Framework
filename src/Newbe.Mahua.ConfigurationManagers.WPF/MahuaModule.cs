using Autofac;
using System.Windows;

namespace Newbe.Mahua.ConfigurationManagers.WPF
{
    public class MahuaModule : IMahuaModule
    {
        public Module[] GetModules()
        {
            return new Module[]
            {
                new WpfConfigurationManagersModule(),
            };
        }

        private class WpfConfigurationManagersModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<WpfConfigurationManager>()
                    .As<IMahuaConfigurationManager>()
                    .SingleInstance();
                builder.RegisterType<MainWindow>()
                    .AsSelf();
            }
        }
    }

    public class WpfConfigurationManager : IMahuaConfigurationManager
    {
        private readonly Application _app = new Application();

        public void Show(ILifetimeScope lifetimeScope)
        {
            var win = lifetimeScope.Resolve<MainWindow>();
            _app.Run(win);
        }
    }
}
