using Autofac;
using System.Threading.Tasks;

namespace Newbe.Mahua.Samples.OkexRobot.Services
{
    public interface IWebHost
    {
        /// <summary>
        /// 启动Web服务
        /// </summary>
        /// <param name="baseUrl"></param>
        /// <param name="lifetimeScope"></param>
        Task StartAsync(string baseUrl, ILifetimeScope lifetimeScope);

        /// <summary>
        /// 停止
        /// </summary>
        Task StopAsync();
    }
}
