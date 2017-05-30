using System;
using Newbe.Mahua.Framework.CQP.NativeApi;

namespace Newbe.Mahua.Framework.CQP
{
    public class MahuaApi : IMahuaApi
    {
        private readonly ICoolQApi _coolQApi;

        public MahuaApi(ICoolQApi coolQApi)
        {
            _coolQApi = coolQApi;
        }

        int IMahuaApi.SendPrivateMsg(long qqId, string content)
        {
            return _coolQApi.SendPrivateMsg(qqId, content);
        }
    }
}