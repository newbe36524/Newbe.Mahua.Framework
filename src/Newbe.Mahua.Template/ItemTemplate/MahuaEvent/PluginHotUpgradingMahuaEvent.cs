using Newbe.Mahua.MahuaEvents;
using System;

namespace $rootnamespace$
{
    /// <summary>
    /// 开始插件热更新事件
    /// </summary>
    public class PluginHotUpgradingMahuaEvent
        : IPluginHotUpgradingMahuaEvent
    {
        private readonly IMahuaApi _mahuaApi;

        public $safeitemname$(
            IMahuaApi mahuaApi)
        {
            _mahuaApi = mahuaApi;
        }

        public void HotUpgrading(PluginHotUpgradingContext context)
        {
            // todo 填充处理逻辑
            throw new NotImplementedException();

            // 不要忘记在MahuaModule中注册
        }
    }
}
