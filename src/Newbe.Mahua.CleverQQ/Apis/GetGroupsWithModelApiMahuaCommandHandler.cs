using Newbe.Mahua.Apis;
using Newbe.Mahua.CleverQQ.NativeApi;
using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Serialization;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class GetGroupsWithModelApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<GetGroupsWithModelApiMahuaCommand, GetGroupsWithModelApiMahuaCommandResult>
    {
        public GetGroupsWithModelApiMahuaCommandHandler(
            ICleverQQApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIrEventOutput eventFunOutput)
            : base(cleverqqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override GetGroupsWithModelApiMahuaCommandResult Handle(GetGroupsWithModelApiMahuaCommand message)
        {
            var json = CleverQQApi.Api_GetGroupList(CurrentQq);
            if (string.IsNullOrEmpty(json))
            {
                return new GetGroupsWithModelApiMahuaCommandResult
                {
                    ModelWithSourceString = new ModelWithSourceString<IEnumerable<GroupInfo>>
                    {
                        Model = Enumerable.Empty<GroupInfo>(),
                        SourceString = json
                    }
                };
            }

            var js = new JavaScriptSerializer
            {
                MaxJsonLength = int.MaxValue
            };
            var groupInfos = js.Deserialize<GroupInfoJsonList>(json);
            var re = groupInfos.Join
                .Select(x => new GroupInfo
                {
                    Group = x.Gc.ToString(),
                    Name = x.Gn
                })
                .ToArray();
            var modelWithSourceString = new ModelWithSourceString<IEnumerable<GroupInfo>>
            {
                SourceString = json,
                Model = re
            };
            var getGroupsWithModelApiMahuaCommandResult = new GetGroupsWithModelApiMahuaCommandResult
            {
                ModelWithSourceString = modelWithSourceString
            };
            return getGroupsWithModelApiMahuaCommandResult;
        }

        public class GroupInfoJsonList
        {
            public int Ec { get; set; }

            /// <summary>
            /// 群列表
            /// </summary>
            public GroupInfoJson[] Join { get; set; }
        }

        public class GroupInfoJson
        {
            /// <summary>
            /// 群号
            /// </summary>
            public long Gc { get; set; }

            /// <summary>
            /// 群名称
            /// </summary>
            public string Gn { get; set; }

            /// <summary>
            /// 群主QQ
            /// </summary>
            public long Owner { get; set; }
        }
    }
}
