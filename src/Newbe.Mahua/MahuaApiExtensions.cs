using System.Linq;

namespace Newbe.Mahua
{
    /// <summary>
    /// <see cref="IMahuaApi"/>相关的扩展方法
    /// </summary>
    public static class MahuaApiExtensions
    {
        /// <summary>
        /// 取群成员信息
        /// </summary>
        /// <param name="api">api</param>
        /// <param name="fromGroup">目标群</param>
        /// <param name="fromQq">目标QQ</param>
        /// <returns></returns>
        public static GroupMemberInfo GetGroupMemberInfo(this IMahuaApi api, string fromGroup, string fromQq)
        {
            return api.GetGroupMemebersWithModel(fromGroup).Model.FirstOrDefault(x => x.Qq == fromQq);
        }
    }
}
