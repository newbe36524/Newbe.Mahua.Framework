using Newbe.Mahua.MahuaEvents;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Newbe.Mahua.Administration.WPF
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IMahuaMenuProvider _mahuaMenuProvider;
        private readonly IEnumerable<IMahuaMenuClickedMahuaEvent> _manhuaMenuClickedMahuaEvents;

        public MainWindow(
            IMahuaMenuProvider mahuaMenuProvider,
            IEnumerable<IMahuaMenuClickedMahuaEvent> manhuaMenuClickedMahuaEvents)
        {
            _mahuaMenuProvider = mahuaMenuProvider;
            _manhuaMenuClickedMahuaEvents = manhuaMenuClickedMahuaEvents;
            InitializeComponent();
            InitMenus();
        }

        private void InitMenus()
        {
            var menus = _mahuaMenuProvider.GetMenus();
            var buttons = menus.Select(x =>
            {
                var button = new Button
                {
                    Content = x.Text,
                };
                button.Click += (sender, args) =>
                {
                    foreach (var manhuaMenuClickedMahuaEvent in _manhuaMenuClickedMahuaEvents)
                    {
                        manhuaMenuClickedMahuaEvent.ProcessManhuaMenuClicked(new MahuaMenuClickedContext
                        {
                            ClickedTime = Clock.Now,
                            Menu = x
                        });
                    }
                };
                return button;
            }).ToArray();
            var panel = new StackPanel();
            foreach (var button in buttons)
            {
                panel.Children.Add(button);
            }

            this.Content = panel;
        }
    }
}
