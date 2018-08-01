using Newbe.Mahua.Logging;
using Newbe.Mahua.MahuaEvents;

namespace Newbe.Mahua.Samples.HotUpdate.MahuaEvents
{
    public class PluginHotUpgradedMahuaEvent : IPluginHotUpgradedMahuaEvent
    {
        private static readonly ILog Logger = LogProvider.For<PluginHotUpgradedMahuaEvent>();

        public void HotUpgraded(PluginHotUpgradedContext context)
        {
            Logger.Info("更新完毕，感谢月落大佬的奇妙点子");
        }
    }
}
