using Newbe.Mahua.MahuaEvents;
using System;

namespace Newbe.Mahua.Samples.HotUpdate.MahuaEvents
{
    public class PluginHotUpgradingMahuaEvent : IPluginHotUpgradingMahuaEvent
    {
        public void HotUpgrading(
            PluginHotUpgradingContext context)
        {
            if (DateTime.Now.Second % 2 == 0)
            {
                context.Canceled = true;
                context.Reason = "月老板说，该时辰不利于更新！";
            }
        }
    }
}
