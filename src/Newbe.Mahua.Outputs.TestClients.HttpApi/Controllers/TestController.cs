using System;
using System.Collections.ObjectModel;
using Microsoft.AspNetCore.Mvc;
using Newbe.Mahua.Outputs.TestClients.HttpApi.Logging;
using Newtonsoft.Json;

namespace Newbe.Mahua.Outputs.TestClients.HttpApi.Controllers
{
    public class TestController : Controller
    {
        private static readonly ILog Logger = LogProvider.For<TestController>();

        [HttpPost("api/ReceiveMahuaOutput")]
        public string ReceiveMahuaOutput(
            [FromBody] ReadOnlyDictionary<string, object> data)
        {
            var msg = JsonConvert.SerializeObject(data);
            Logger.Info(msg);
            Console.WriteLine(msg);
            return msg;
        }
    }
}