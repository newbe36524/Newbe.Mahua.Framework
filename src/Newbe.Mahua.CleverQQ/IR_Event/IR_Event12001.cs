using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System.Collections.Generic;

namespace Newbe.Mahua.CleverQQ.IR_Event
{
    /// <summary>
    /// 用户启用本插件 返回20可拒绝启用 其他返回值均视为允许启用
    /// </summary>
    public class IR_Event12001 : IIR_Event
    {
        private readonly IEnumerable<IPluginEnabledMahuaEvent> _pluginEnabledMahuaEvents;

        public IR_Event12001(
            IEnumerable<IPluginEnabledMahuaEvent> pluginEnabledMahuaEvents)
        {
            _pluginEnabledMahuaEvents = pluginEnabledMahuaEvents;
        }

        public int IR_Event { get; } = 12001;

        public void Handle(IR_EventInput eventFunInput)
        {
            _pluginEnabledMahuaEvents
                .Handle(x => x.Enabled(new PluginEnabledContext { }));
        }
    }
}
