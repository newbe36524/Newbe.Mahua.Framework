using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System.Collections.Generic;

namespace Newbe.Mahua.CleverQQ.IR_Event
{
    /// <summary>
    /// 用户禁用本插件 无权拒绝
    /// </summary>
    public class IR_Event12002 : IIR_Event
    {
        private readonly IEnumerable<IPluginDisabledMahuaEvent> _pluginDisabledMahuaEvents;

        public IR_Event12002(
            IEnumerable<IPluginDisabledMahuaEvent> pluginDisabledMahuaEvents)
        {
            _pluginDisabledMahuaEvents = pluginDisabledMahuaEvents;
        }

        public int IR_Event { get; } = 12002;

        public void Handle(IR_EventInput eventFunInput)
        {
            _pluginDisabledMahuaEvents
                .Handle(x => x.Disable(new PluginDisabledContext()));
        }
    }
}
