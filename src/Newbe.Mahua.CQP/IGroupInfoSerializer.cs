using System.Collections.Generic;

namespace Newbe.Mahua.CQP
{
    /// <summary>
    /// 群信息序列化
    /// </summary>
    internal interface IGroupInfoSerializer
    {
        /// <summary>
        /// 将特定的字符串反序列化为<see cref="IEnumerable{GroupInfo}"/>
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        IEnumerable<GroupInfo> DeserializeGroupInfos(string source);
    }
}