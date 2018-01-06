using Newbe.Mahua.Apis;
using Newbe.Mahua.Logging;

namespace Newbe.Mahua.Samples.ApiExtensions.MahuaApis
{
    public class SetNoticeApiMahuaCommandHandler : IApiCommandHandler<SetNoticeApiMahuaCommand>
    {
        public void Handle(SetNoticeApiMahuaCommand message)
        {
            var logger = LogProvider.For<SetNoticeApiMahuaCommandHandler>();

            // 将公告写入到日志当中
            logger.Info(message.Content);
        }
    }
}
