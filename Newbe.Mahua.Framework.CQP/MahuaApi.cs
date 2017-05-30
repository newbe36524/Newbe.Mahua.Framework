using System;
using Newbe.Mahua.Framework.CQP.NativeApi;

namespace Newbe.Mahua.Framework.CQP
{
    public class MahuaApi : IMahuaApi
    {
        private readonly ICoolQApi _coolQApi;
        private readonly ICqpAuthCodeContainer _cqpAuthCodeContainer;

        public MahuaApi(ICoolQApi coolQApi, ICqpAuthCodeContainer cqpAuthCodeContainer)
        {
            _coolQApi = coolQApi;
            _cqpAuthCodeContainer = cqpAuthCodeContainer;
        }

        int IMahuaApi.SendPrivateMsg(long qqId, string content)
        {
            return _coolQApi.CQ_sendPrivateMsg(_cqpAuthCodeContainer.AuthCode, qqId, content);
        }
    }
}