using Newbe.Mahua.Apis;
using Newbe.Mahua.CleverQQ.NativeApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Serialization;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class GetGroupMemebersWithModelApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<GetGroupMemebersWithModelApiMahuaCommand, GetGroupMemebersWithModelApiMahuaCommandResult>
    {
        public GetGroupMemebersWithModelApiMahuaCommandHandler(
            ICleverQQApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIR_EventOutput eventFunOutput)
            : base(cleverqqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override GetGroupMemebersWithModelApiMahuaCommandResult Handle(
            GetGroupMemebersWithModelApiMahuaCommand message)
        {
            var json = CleverQQApi.Api_GetGroupMemberList(CurrentQq, message.ToGroup);
            if (string.IsNullOrEmpty(json))
            {
                return new GetGroupMemebersWithModelApiMahuaCommandResult
                {
                    ModelWithSourceString = new ModelWithSourceString<IEnumerable<GroupMemberInfo>>
                    {
                        SourceString = json,
                        Model = Enumerable.Empty<GroupMemberInfo>()
                    }
                };
            }

            var js = new JavaScriptSerializer
            {
                MaxJsonLength = int.MaxValue
            };
            var infos = js.Deserialize<GroupMemberInfoListJson>(json);

            var modelWithSourceString = new ModelWithSourceString<IEnumerable<GroupMemberInfo>>
            {
                SourceString = json,
                Model = infos.Mems
                    .Select(x => new GroupMemberInfo
                    {
                        Group = message.ToGroup,

                        // todo age
                        Age = 0,

                        // todo Area
                        Area = string.Empty,
                        Authority = GetGroupMemberAuthority(x.Role),

                        // todo CanModifyInGroupName
                        CanModifyInGroupName = false,
                        Gender = GetGender(x.G),

                        // todo CanModifyInGroupName
                        HasBadRecord = false,
                        InGroupName = x.Card,
                        JoinTime = Clock.ConvertSecondsToDateTime(x.Join_time),
                        LastSpeakingTime = Clock.ConvertSecondsToDateTime(x.Last_speak_time),
                        Level = x.Lv.Level.ToString(),
                        NickName = x.Nick,
                        Qq = x.Uin.ToString(),

                        // todo SpecialTitle
                        SpecialTitle = string.Empty,

                        // todo TitleExpirationTime
                        TitleExpirationTime = TimeSpan.MinValue
                    }).ToArray(),
            };
            var re = new GetGroupMemebersWithModelApiMahuaCommandResult
            {
                ModelWithSourceString = modelWithSourceString,
            };
            return re;
        }

        private GroupMemberAuthority GetGroupMemberAuthority(int role)
        {
            switch (role)
            {
                case 2: return GroupMemberAuthority.Manager;
                case 3: return GroupMemberAuthority.Leader;
                default:
                    return GroupMemberAuthority.Normal;
            }
        }

        private Gender GetGender(GroupMemberSex? gender)
        {
            switch (gender)
            {
                case GroupMemberSex.Male:
                    return Gender.Male;
                case GroupMemberSex.Female:
                    return Gender.Female;
                default:
                    return Gender.Unknow;
            }
        }

        public class GroupMemberInfoListJson
        {
            /// <summary>
            /// 管理员最大人数
            /// </summary>
            public int Adm_max { get; set; }

            /// <summary>
            /// 管理员人数
            /// </summary>
            public int Adm_num { get; set; }

            /// <summary>
            /// 人数
            /// </summary>
            public int Count { get; set; }

            /// <summary>
            /// 响应结果
            /// </summary>
            public int Ec { get; set; }

            /// <summary>
            /// 等级信息
            /// </summary>
            public Levelname Levelname { get; set; }

            /// <summary>
            /// 群人数上限
            /// </summary>
            public int Max_count { get; set; }

            /// <summary>
            /// 群成员信息
            /// </summary>
            public Mem[] Mems { get; set; }

            /// <summary>
            /// 当前查询结果
            /// </summary>
            public int Search_count { get; set; }

            /// <summary>
            /// 服务器当前时间戳(毫秒)
            /// </summary>
            public int Svr_time { get; set; }

            /// <summary>
            /// todo 不知道什么值
            /// </summary>
            public int Vecsize { get; set; }
        }

        public class Levelname : Dictionary<string, string>
        {
        }

        public enum GroupMemberSex
        {
            Male = 0,
            Female = 1,
            NotSetted = 255,
        }

        public class Mem
        {
            /// <summary>
            /// 群名片
            /// </summary>
            public string Card { get; set; }

            /// <summary>
            /// todo 不知道
            /// </summary>
            public int Flag { get; set; }

            /// <summary>
            /// 性别
            /// </summary>
            public GroupMemberSex? G { get; set; }

            /// <summary>
            /// 入群时间毫秒时间戳
            /// </summary>
            public int Join_time { get; set; }

            /// <summary>
            /// 最近发言时间毫秒时间戳
            /// </summary>
            public int Last_speak_time { get; set; }

            /// <summary>
            /// 群员等级信息
            /// </summary>
            public Lv Lv { get; set; }

            /// <summary>
            /// 昵称
            /// </summary>
            public string Nick { get; set; }

            /// <summary>
            /// Q龄
            /// </summary>
            public int Qage { get; set; }

            /// <summary>
            /// 群员身份,3群主，2管理员，普通成员
            /// </summary>
            public int Role { get; set; }

            /// <summary>
            /// todo 不知道
            /// </summary>
            public string Tags { get; set; }

            /// <summary>
            /// QQ号
            /// </summary>
            public long Uin { get; set; }
        }

        /// <summary>
        /// 群员等级信息
        /// </summary>
        public class Lv
        {
            /// <summary>
            /// 等级
            /// </summary>
            public int Level { get; set; }

            /// <summary>
            /// 群积分
            /// </summary>
            public int Point { get; set; }
        }
    }
}
