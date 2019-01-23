using System.Net;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Newbe.Mahua.InputReceivers.HttpApi.Services
{
    internal class WebHostContainer : IWebHostContainer
    {
        private IWebHost _instance;
        private bool _initialized;
        private readonly object _locker = new object();

        public IWebHost CreateInstance(HttpApiConfig config)
        {
            if (_initialized)
            {
                return _instance;
            }

            lock (_locker)
            {
                if (_initialized)
                {
                    return _instance;
                }

                _instance = WebHost.CreateDefaultBuilder()
                    .UseKestrel(options => { options.Listen(IPAddress.Parse(config.Ip), config.Port); })
                    .UseStartup<Startup>()
                    .Build();
                _initialized = true;
            }

            return _instance;
        }
    }
}