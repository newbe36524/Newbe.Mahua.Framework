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
        /// <param name="fromGroup">目标群</param>
        /// <param name="fromQq">目标QQ</param>
        /// <returns></returns>
        public static GroupMemberInfo GetGroupMemberInfo(this IMahuaApi api,
            string fromGroup, string fromQq)
        {
            return api.GetGroupMemebersWithModel(fromGroup).Model.FirstOrDefault(x => x.Qq == fromQq);
        }

        /// <summary>
        /// 取群成员列表
        /// </summary>
        /// <param name="api">api</param>
        /// <param name="fromGroup">目标群</param>
        /// <returns></returns>
        public static ModelWithSourceString<IEnumerable<GroupMemberInfo>> GetGroupMemebersWithModel(this IMahuaApi api,
            string fromGroup)
        {
            var source = api.GetGroupMemebers(fromGroup);
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

        /// <summary>
        /// 获取群列表
        /// </summary>
        /// <param name="api"></param>
        /// <returns></returns>
        public static ModelWithSourceString<IEnumerable<GroupInfo>> GetGroupsWithModel(this IMahuaApi api)
        {
            var source = api.GetGroups();
            if (!api.GetContainer().TryResolve(typeof(IGroupInfoSerializer),
                out object ser))
            {
                MahuaGlobal.NotSupportedMahuaApiConvertion.Handle();
                return default(ModelWithSourceString<IEnumerable<GroupInfo>>);
            }
            var re = new ModelWithSourceString<IEnumerable<GroupInfo>>
            {
                SourceString = source,
                Model = ((IGroupInfoSerializer) ser).DeserializeGroupInfos(source),
            };
            return re;
        }
    }
}