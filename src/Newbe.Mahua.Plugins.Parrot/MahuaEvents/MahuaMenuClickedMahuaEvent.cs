
using Newbe.Mahua.MahuaEvents;
using System.Diagnostics;

namespace Newbe.Mahua.Plugins.Parrot.MahuaEvents
{
    /// <summary>
    /// 菜单点击事件
    /// </summary>
    public class MahuaMenuClickedMahuaEvent
        : IMahuaMenuClickedMahuaEvent
    {
        private readonly IMahuaApi _mahuaApi;

        public MahuaMenuClickedMahuaEvent(
            IMahuaApi mahuaApi)
        {
            _mahuaApi = mahuaApi;
        }

        public void ProcessManhuaMenuClicked(MahuaMenuClickedContext context)
        {
            // context.Menu 被选中到底菜单
            ShowNewbe();
        }

        private static void ShowNewbe()
        {
            Process.Start("http://www.newbe.pro");
        }
    }
}
