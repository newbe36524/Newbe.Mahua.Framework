namespace Newbe.Mahua.Samples.OkexRobot.Common
{
    public class SystemOptions
    {
        public static SystemOptions Instance { get; set; }


        public string MasterQq { get; set; } = "472158246";
        public string ApiKey { get; set; }
        public string SecretKey { get; set; }
        public string HttpProxyUri { get; set; } = "http://127.0.0.1:1080";
        public string HangdireDashboardUri { get; set; } = "http://localhost:64238";
    }
}
