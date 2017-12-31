using System.Threading.Tasks;

namespace Newbe.Mahua.Samples.LiveGirl.Services
{
    /// <summary>
    /// B站直播姬
    /// </summary>
    public interface ILivegirl
    {
        /// <summary>
        /// 启动
        /// </summary>
        /// <returns></returns>
        Task StartAsync();

        /// <summary>
        /// 停止
        /// </summary>
        /// <returns></returns>
        Task StopAsnyc();
    }
}
