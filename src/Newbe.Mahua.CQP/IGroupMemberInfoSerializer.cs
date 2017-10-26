using System.Collections.Generic;

namespace Newbe.Mahua.CQP
{
    /// <summary>
    /// 成员信息序列化
    /// </summary>
    /// <remarks>该结构根据不同的<see cref="MahuaPlatform"/>需要进行专用化开发</remarks>
    internal interface IGroupMemberInfoSerializer
    {
        /// <summary>
        /// 将特定的字符串反序列化为<see cref="IEnumerable{GroupMemberInfo}"/>
        /// </summary>
        /// <param name="sourceStr"></param>
        /// <returns></returns>
        IEnumerable<GroupMemberInfo> DeserializeGroupMemberInfos(string sourceStr);
    }
}