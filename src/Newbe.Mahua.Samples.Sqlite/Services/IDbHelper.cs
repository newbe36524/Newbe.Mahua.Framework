using System.Data.Common;
using System.Threading.Tasks;

namespace Newbe.Mahua.Samples.Sqlite.Services
{
    public interface IDbHelper
    {
        /// <summary>
        /// 初始化数据库
        /// </summary>
        Task InitDbAsync();

        /// <summary>
        /// 获取数据库链接
        /// </summary>
        /// <returns></returns>
        Task<DbConnection> CreateDbConnectionAsync();
    }
}
