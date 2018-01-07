using Newbe.Mahua.Apis;
using Newbe.Mahua.Logging;
using Newtonsoft.Json;

namespace Newbe.Mahua.CQP.ApiExtensions.Apis
{
    /// <summary>
    /// 发布群公告
    /// </summary>
    public class SetNoticeApiMahuaCommandHandler
        : IApiCommandHandler<SetNoticeApiMahuaCommand>
    {
        private readonly IMahuaApi _mahuaApi;
        private readonly IQqGroupApi _qqGroupApi;

        public SetNoticeApiMahuaCommandHandler(
            IMahuaApi mahuaApi,
            IQqGroupApi qqGroupApi)
        {
            _mahuaApi = mahuaApi;
            _qqGroupApi = qqGroupApi;
        }

        public void Handle(SetNoticeApiMahuaCommand message)
        {
            var setNoticeResult = _qqGroupApi.SetNotice(new SetNoticeInput
            {
                Bkn = _mahuaApi.GetBkn(),
                Qid = message.ToGroup,
                Title = message.Title,
                Text = message.Content
            })
                .GetAwaiter()
                .GetResult();
            LogProvider.For<SetNoticeApiMahuaCommandHandler>().Debug(JsonConvert.SerializeObject(setNoticeResult));
        }
    }
}
