using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System.Collections.Generic;

namespace Newbe.Mahua.CleverQQ.IrEvents
{
    /// <summary>
    /// 用户禁用本插件 无权拒绝
    /// </summary>
    public class IrEvent12002 : IIrEvent
    {
        private readonly IEnumerable<IPluginDisabledMahuaEvent> _pluginDisabledMahuaEvents;

        public IrEvent12002(
            IEnumerable<IPluginDisabledMahuaEvent> pluginDisabledMahuaEvents)
        {
            _pluginDisabledMahuaEvents = pluginDisabledMahuaEvents;
        }

        public int IrEventCode { get; } = 12002;

        public void Handle(IrEventInput eventFunInput)
        {
            _pluginDisabledMahuaEvents
                .Handle(x => x.Disable(new PluginDisabledContext()));
        }
    }
}
