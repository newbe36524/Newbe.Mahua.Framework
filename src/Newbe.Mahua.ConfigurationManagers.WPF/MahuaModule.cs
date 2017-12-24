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
        public void Show(ILifetimeScope lifetimeScope)
        {
            var win = lifetimeScope.Resolve<MainWindow>();
            win.ResizeMode = ResizeMode.NoResize;
            win.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            win.ShowDialog();
        }
    }
}
