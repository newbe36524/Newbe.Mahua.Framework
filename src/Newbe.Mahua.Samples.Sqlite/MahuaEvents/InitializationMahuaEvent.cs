using Newbe.Mahua.MahuaEvents;
using Newbe.Mahua.Samples.Sqlite.Services;

namespace Newbe.Mahua.Samples.Sqlite.MahuaEvents
{
    /// <summary>
    /// 插件初始化事件
    /// </summary>
    public class InitializationMahuaEvent
        : IInitializationMahuaEvent
    {
        private readonly IDbHelper _dbHelper;

        public InitializationMahuaEvent(
            IDbHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        public void Initialized(InitializedContext context)
        {
            // 插件初始化时，初始化数据库
            // 此处采用异步操作，可以避免插件初始化超时的问题
            _dbHelper.InitDbAsync();
        }
    }
}
