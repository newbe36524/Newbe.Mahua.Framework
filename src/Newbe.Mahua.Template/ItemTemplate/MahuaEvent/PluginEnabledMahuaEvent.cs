using Newbe.Mahua.MahuaEvents;
using System;

namespace $rootnamespace$
{
    /// <summary>
    /// 插件被启用事件
    /// </summary>
    public class PluginEnabledMahuaEvent
        : IPluginEnabledMahuaEvent
    {
        private readonly IMahuaApi _mahuaApi;

        public $safeitemname$(
            IMahuaApi mahuaApi)
        {
            _mahuaApi = mahuaApi;
        }

        public void Enabled(PluginEnabledContext context)
        {
            // todo 填充处理逻辑
            throw new NotImplementedException();

            // 不要忘记在MahuaModule中注册
        }
    }
}
