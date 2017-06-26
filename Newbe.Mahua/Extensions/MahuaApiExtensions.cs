using System;
using System.Collections.Generic;
using System.Linq;
using Autofac;

namespace Newbe.Mahua.Extensions
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
        /// <param name="groupId">目标群</param>
        /// <param name="qqId">目标QQ</param>
        /// <returns></returns>
        public static GroupMemberInfo GetGroupMemberInfo(this IMahuaApi api,
            string groupId, string qqId)
        {
            return api.GetGroupMemberList(groupId).Model.FirstOrDefault(x => x.Qq == qqId);
        }

        /// <summary>
        /// 取群成员列表
        /// </summary>
        /// <param name="api">api</param>
        /// <param name="groupId">目标群</param>
        /// <returns></returns>
        public static ModelWithSourceString<IEnumerable<GroupMemberInfo>> GetGroupMemberList(this IMahuaApi api,
            string groupId)
        {
            var source = api.GetGroupMemebers(groupId);
            if (!api.GetContainer().TryResolve(typeof(IGroupMemberInfoSerializer),
                out object groupMemberInfoSerializer))
            {
                MahuaGlobal.NotSupportedMahuaApiConvertion.Handle();
                return default(ModelWithSourceString<IEnumerable<GroupMemberInfo>>);
            }
            var re = new ModelWithSourceString<IEnumerable<GroupMemberInfo>>
            {
                SourceString = source,
                Model = ((IGroupMemberInfoSerializer) groupMemberInfoSerializer).DeserializeGroupMemberInfos(source)
            };
            return re;
        }
    }
}