using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System.Collections.Generic;

namespace Newbe.Mahua.MPQ.EventFuns
{
    /// <summary>
    /// 用户启用本插件 返回20可拒绝启用 其他返回值均视为允许启用
    /// </summary>
    public class EventFun12001 : IEventFun
    {
        private readonly IEnumerable<IPluginEnabledMahuaEvent> _pluginEnabledMahuaEvents;

        public EventFun12001(
            IEnumerable<IPluginEnabledMahuaEvent> pluginEnabledMahuaEvents)
        {
            _pluginEnabledMahuaEvents = pluginEnabledMahuaEvents;
        }

        public int EventFun { get; } = 12001;

        public void Handle(EventFunInput eventFunInput)
        {
            _pluginEnabledMahuaEvents
                .Handle(x => x.Enabled(new PluginEnabledContext { }));
        }
    }
}
