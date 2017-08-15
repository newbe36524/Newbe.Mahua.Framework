using System;
using System.Collections.Generic;
using System.Linq;
using Newbe.Mahua.CQP.Internals;

namespace Newbe.Mahua.CQP
{
    internal class GroupMemberInfoSerializer : IGroupMemberInfoSerializer
    {
        public IEnumerable<GroupMemberInfo> DeserializeGroupMemberInfos(string sourceStr)
        {
            var list = new List<GroupMemberInfo>();
            var re = Enumerable.Empty<GroupMemberInfo>();
            if (ConvertStrToGroupMemberInfos(sourceStr, ref list))
            {
                re = list;
            }
            return re;
        }


        /// <summary>
        /// 转换_ansihex到群成员信息
        /// </summary>
        /// <param name="source">源字节集</param>
        /// <param name="gm">群成员</param>
        /// <returns></returns>
        private static bool ConvertAnsiHexToGroupMemberInfo(byte[] source, ref GroupMemberInfo gm)
        {
            if (source?.Length < 40)
            {
                return false;
            }
            var u = new Unpack(source);
            gm.Group = u.GetLong().ToString();
            gm.Qq = u.GetLong().ToString();
            gm.NickName = u.GetLenStr();
            gm.InGroupName = u.GetLenStr();
            gm.Gender = u.GetInt() == 0 ? Gender.Male : Gender.Female;
            gm.Age = u.GetInt();
            gm.Area = u.GetLenStr();
            gm.JoinTime = new DateTime(1970, 1, 1, 0, 0, 0).ToLocalTime()
                .AddSeconds(u.GetInt());
            gm.LastSpeakingTime = new DateTime(1970, 1, 1, 0, 0, 0).ToLocalTime()
                .AddSeconds(u.GetInt());
            gm.Level = u.GetLenStr();
            var manager = u.GetInt();
            switch (manager)
            {
                case 3:
                    gm.Authority = GroupMemberAuthority.Leader;
                    break;
                case 2:
                    gm.Authority = GroupMemberAuthority.Manager;
                    break;
                default:
                    gm.Authority = GroupMemberAuthority.Normal;
                    break;
            }
            gm.HasBadRecord = (u.GetInt() == 1);
            gm.SpecialTitle = u.GetLenStr();
            gm.TitleExpirationTime = TimeSpan.FromSeconds(u.GetInt());
            gm.CanModifyInGroupName = (u.GetInt() == 1);
            return true;
        }

        /// <summary>
        /// 转换_文本到群成员列表信息
        /// </summary>
        /// <param name="source">源</param>
        /// <param name="lsGm">群成员列表</param>
        /// <returns></returns>
        private static bool ConvertStrToGroupMemberInfos(string source, ref List<GroupMemberInfo> lsGm)
        {
            if (source == string.Empty)
                return false;
            var data = source.DeBase64();
            if (data?.Length < 10)
            {
                return false;
            }
            var u = new Unpack(data);
            var count = u.GetInt();
            for (var i = 0; i < count; i++)
            {
                if (u.Len() <= 0)
                {
                    return false;
                }
                var gm = new GroupMemberInfo();
                if (!ConvertAnsiHexToGroupMemberInfo(u.GetToken(), ref gm))
                {
                    return false;
                }
                lsGm.Add(gm);
            }
            return true;
        }
    }
}