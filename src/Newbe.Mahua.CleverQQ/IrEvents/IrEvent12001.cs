using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System.Collections.Generic;

namespace Newbe.Mahua.CleverQQ.IrEvents
{
    /// <summary>
    /// 用户启用本插件 返回20可拒绝启用 其他返回值均视为允许启用
    /// </summary>
    public class IrEvent12001 : IIrEvent
    {
        private readonly IEnumerable<IPluginEnabledMahuaEvent> _pluginEnabledMahuaEvents;

        public IrEvent12001(
            IEnumerable<IPluginEnabledMahuaEvent> pluginEnabledMahuaEvents)
        {
            _pluginEnabledMahuaEvents = pluginEnabledMahuaEvents;
        }

        public int IrEventCode { get; } = 12001;

        public void Handle(IrEventInput eventFunInput)
        {
            _pluginEnabledMahuaEvents
                .Handle(x => x.Enabled(new PluginEnabledContext { }));
        }
    }
}
