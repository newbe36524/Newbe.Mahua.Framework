using Newbe.Mahua.MahuaEvents;
using System;

namespace $rootnamespace$
{
    /// <summary>
    /// 解除群管理员事件
    /// </summary>
    public class GroupAdminDisabledMahuaEvent
        : IGroupAdminDisabledMahuaEvent
    {
        private readonly IMahuaApi _mahuaApi;

        public $safeitemname$(
            IMahuaApi mahuaApi)
        {
            _mahuaApi = mahuaApi;
        }

        public void ProcessGroupAdminDisabled(GroupAdminDisabledContext context)
        {
            // todo 填充处理逻辑
            throw new NotImplementedException();

            // 不要忘记在MahuaModule中注册
        }
    }
}
