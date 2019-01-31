using System;

namespace Newbe.Mahua.OutputSenders.HttpApi
{
    public class HttpApiConfig
    {
        public string Url { get; set; }
        public string[] Urls { get; set; }
        public TimeSpan Timeout { get; set; }
    }
}