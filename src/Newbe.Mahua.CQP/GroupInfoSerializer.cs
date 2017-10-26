using System;
using System.Collections.Generic;
using System.Linq;
using Newbe.Mahua.CQP.Internals;

namespace Newbe.Mahua.CQP
{
    internal class GroupInfoSerializer : IGroupInfoSerializer
    {
        IEnumerable<GroupInfo> IGroupInfoSerializer.DeserializeGroupInfos(string source)
        {
            if (string.IsNullOrEmpty(source))
            {
                throw new ArgumentNullException(nameof(source));
            }
            var data = source.DeBase64();
            var empty = Enumerable.Empty<GroupInfo>();
            if (data.Length < 10)
            {
                return empty;
            }
            var unpack = new Unpack(data);
            var count = unpack.GetInt();
            if (count <= 0)
            {
                return empty;
            }
            var tokens = new List<byte[]>();
            for (int i = 0; i < count; i++)
            {
                tokens.Add(unpack.GetToken());
            }
            var re = tokens.Select(GetGroupInfo).Where(x => x != null).ToList();
            return re;
        }

        private static GroupInfo GetGroupInfo(byte[] bs)
        {
            if (bs.Length <= 10)
            {
                return null;
            }
            var unpack = new Unpack(bs);
            var re = new GroupInfo
            {
                Group = unpack.GetLong().ToString(),
                Name = unpack.GetLenStr()
            };
            return re;
        }
    }
}