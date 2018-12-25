
using Newbe.Mahua.MahuaEvents;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace Newbe.Mahua.Plugins.Parrot.MahuaEvents
{
    /// <summary>
    /// 菜单点击事件
    /// </summary>
    public class MahuaMenuClickedMahuaEvent
        : IMahuaMenuClickedMahuaEvent
    {
        public MahuaMenuClickedMahuaEvent()
        {
        }

        public void ProcessManhuaMenuClicked(MahuaMenuClickedContext context)
        {
            // context.Menu 被选中到底菜单
            ShowNewbe();
        }

        [SuppressMessage("ReSharper", "S1075")]
        private static void ShowNewbe()
        {
            Process.Start("http://www.newbe.pro");
        }
    }
}
