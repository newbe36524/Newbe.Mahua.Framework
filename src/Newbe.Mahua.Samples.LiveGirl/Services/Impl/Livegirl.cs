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
            RecurringJob.AddOrUpdate(JobId, () => SendMessage(), () => Cron.HourInterval(1));
            Process.Start("http://localhost:65238/hangfire/recurring");
            return Task.FromResult(0);
        }

        public Task StopAsnyc()
        {
            RecurringJob.RemoveIfExists(JobId);
            return Task.FromResult(0);
        }

        public void SendMessage()
        {
            if (_liveRoom.IsOnLive())
            {
                _mahuaApi.SendGroupMessage("610394020", "群主正在女装，前往观望？https://live.bilibili.com/7834872");
            }
        }
    }
}
