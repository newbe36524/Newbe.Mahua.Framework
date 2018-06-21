using Hangfire;
using Newbe.Mahua.MahuaEvents;
using Newbe.Mahua.Samples.OkexRobot.Common;
using Newbe.Mahua.Samples.OkexRobot.Services;
using Newbe.Mahua.Samples.OkexRobot.Services.Impl;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;

namespace Newbe.Mahua.Samples.OkexRobot.MahuaEvents
{
    /// <summary>
    /// 插件初始化事件
    /// </summary>
    public class InitializationMahuaEvent
        : IInitializationMahuaEvent
    {
        private readonly IMahuaApi _mahuaApi;
        private readonly IWebHost _webHost;
        private readonly IUserAssetTracer _userAssetTracer;
        private readonly IOrderTracer _orderTracer;

        public InitializationMahuaEvent(
            IMahuaApi mahuaApi,
            IWebHost webHost,
            IUserAssetTracer userAssetTracer,
            IOrderTracer orderTracer)
        {
            _mahuaApi = mahuaApi;
            _webHost = webHost;
            _userAssetTracer = userAssetTracer;
            _orderTracer = orderTracer;
        }

        public void Initialized(InitializedContext context)
        {
            var settingJsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data", "setting.json");
            var options = new SystemOptions();
            if (File.Exists(settingJsonPath))
            {
                options = JsonConvert.DeserializeObject<SystemOptions>(File.ReadAllText(settingJsonPath));
            }
            SystemOptions.Instance = options;
            // 在本地地址上启动Web服务，可以根据需求改变端口
            _webHost.StartAsync(options.HangdireDashboardUri, _mahuaApi.GetSourceContainer());

            // 定时记录资产
            RecurringJob.AddOrUpdate(nameof(IUserAssetTracer), () => _userAssetTracer.Recode(), Cron.MinuteInterval(10));

            // 定时检测订单成交变化
            RecurringJob.AddOrUpdate(nameof(OrderTracer), () => _orderTracer.ReportFinishedOrders(), () => Cron.MinuteInterval(5));

            // 定时报告资产变化
            foreach (var hour in HoursInChina)
            {
                RecurringJob.AddOrUpdate(nameof(IUserAssetTracer) + hour,
                    () => _userAssetTracer.Report(), () => Cron.Daily((hour - 8 + 24) % 24));
            }

            Process.Start($"{options.HangdireDashboardUri}/hangfire/recurring");
        }
        private static readonly int[] HoursInChina = { 5, 11, 17, 23 };
    }
}
