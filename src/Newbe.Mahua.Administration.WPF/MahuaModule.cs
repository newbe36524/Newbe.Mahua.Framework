using Autofac;
using System.Windows;

namespace Newbe.Mahua.Administration.WPF
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
                builder.RegisterType<WpfAdministration>()
                    .As<IMahuaAdministration>()
                    .SingleInstance();
                builder.RegisterType<MainWindow>()
                    .AsSelf();
            }
        }
    }

    public class WpfAdministration : IMahuaAdministration
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
