using Hangfire;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Newbe.Mahua.Samples.LiveGirl.Services.Impl
{
    public class Livegirl : ILivegirl
    {
        private static readonly string JobId = "jobid";

        private readonly IMahuaApi _mahuaApi;
        private readonly ILiveRoom _liveRoom;

        public Livegirl(
            IMahuaApi mahuaApi,
            ILiveRoom liveRoom)
        {
            _mahuaApi = mahuaApi;
            _liveRoom = liveRoom;
        }

        public Task StartAsync()
        {
            // 添加定时任务
            // 每个整点触发
            RecurringJob.AddOrUpdate(JobId, () => SendMessage(), () => Cron.HourInterval(1));

            // 使用浏览器打开定时任务的地址
            Process.Start("http://localhost:65238/hangfire/recurring");
            return Task.FromResult(0);
        }

        public Task StopAsnyc()
        {
            // 移除定时任务
            RecurringJob.RemoveIfExists(JobId);
            return Task.FromResult(0);
        }

        public void SendMessage()
        {
            // 如果直播间状态为正在直播，则发送消息
            if (_liveRoom.IsOnLive())
            {
                _mahuaApi.SendGroupMessage("610394020", "群主正在女装，前往观望？https://live.bilibili.com/7834872");
            }
        }
    }
}
