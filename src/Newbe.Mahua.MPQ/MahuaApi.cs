using Autofac;
using Newbe.Mahua.Logging;
using Newbe.Mahua.MPQ.NativeApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Serialization;

namespace Newbe.Mahua.MPQ
{
    public class MahuaApi : IMahuaApi
    {
        private static readonly ILog Logger = LogProvider.For<MahuaApi>();
        private readonly IMpqApi _mpqApi;
        private readonly IQqSession _qqSession;
        private readonly IEventFunOutput _eventFunOutput;
        private ILifetimeScope _lifetimeScope;
        private IContainer _container;

        public MahuaApi(
            IMpqApi mpqApi,
            IQqSession qqSession,
            IEventFunOutput eventFunOutput)
        {
            _mpqApi = mpqApi;
            _qqSession = qqSession;
            _eventFunOutput = eventFunOutput;
        }

        public void SendPrivateMessage(string toQq, string message)
        {
            _mpqApi.Api_SendMsg(_qqSession.CurrentQq, 1, 0, null, toQq, message);
        }

        public void SendGroupMessage(string toGroup, string message)
        {
            _mpqApi.Api_SendMsg(_qqSession.CurrentQq, 2, 0, toGroup, null, message);
        }

        public void SendDiscussMessage(string toDiscuss, string message)
        {
            _mpqApi.Api_SendMsg(_qqSession.CurrentQq, 3, 0, toDiscuss, null, message);
        }

        [NotSupportedMahuaApi]
        public void SendLike(string toQq)
        {
            MahuaGlobal.NotSupportedMahuaApiConvertion.Handle();
        }

        public string GetCookies()
        {
            return _mpqApi.Api_GetCookies(_qqSession.CurrentQq);
        }

        public string GetBkn()
        {
            return _mpqApi.Api_GetBkn32(_qqSession.CurrentQq);
        }

        public string GetLoginQq()
        {
            return _qqSession.CurrentQq;
        }

        public string GetLoginNick()
        {
            var re = _mpqApi.Api_GetNick(_qqSession.CurrentQq);
            return re;
        }

        public void KickGroupMember(string toGroup, string toQq, bool rejectForever)
        {
            // todo notsupport rejectForever
            _mpqApi.Api_Kick(_qqSession.CurrentQq, toGroup, toQq);
        }

        public void BanGroupMember(string toGroup, string toQq, TimeSpan duration)
        {
            _mpqApi.Api_Shutup(_qqSession.CurrentQq, toGroup, toQq, (int)duration.TotalSeconds);
        }

        public void RemoveBanGroupMember(string toGroup, string toQq)
        {
            _mpqApi.Api_Shutup(_qqSession.CurrentQq, toGroup, toQq, 0);
        }

        [NotSupportedMahuaApi]
        public void EnableGroupAdmin(string toGroup, string toQq)
        {
            MahuaGlobal.NotSupportedMahuaApiConvertion.Handle();
        }

        [NotSupportedMahuaApi]
        public void DisableGroupAdmin(string toGroup, string toQq)
        {
            MahuaGlobal.NotSupportedMahuaApiConvertion.Handle();
        }

        [NotSupportedMahuaApi]
        public void SetGroupMemberSpecialTitle(string toGroup, string toQq, string specialTitle, TimeSpan duration)
        {
            MahuaGlobal.NotSupportedMahuaApiConvertion.Handle();
        }

        public void SetBanAllGroupMembersOption(string toGroup, bool enabled)
        {
            _mpqApi.Api_Shutup(_qqSession.CurrentQq, toGroup, null, 0);
        }

        [NotSupportedMahuaApi]
        public void BanGroupAnonymousMember(string toGroup, string anonymous, TimeSpan duration)
        {
            MahuaGlobal.NotSupportedMahuaApiConvertion.Handle();
        }

        [NotSupportedMahuaApi]
        public void SetGroupAnonymousOption(string toGroup, bool enabled)
        {
            MahuaGlobal.NotSupportedMahuaApiConvertion.Handle();
        }

        public void SetGroupMemberCard(string toGroup, string toQq, string groupMemberCard)
        {
            _mpqApi.Api_SetNameCard(_qqSession.CurrentQq, toGroup, toQq, groupMemberCard);
        }

        public void LeaveGroup(string toGroup)
        {
            _mpqApi.Api_QuitGroup(_qqSession.CurrentQq, toGroup);
        }

        public void DissolveGroup(string toGroup)
        {
            _mpqApi.Api_QuitGroup(_qqSession.CurrentQq, toGroup);
        }

        public void LeaveDiscuss(string toDiscuss)
        {
            _mpqApi.Api_QuitDG(_qqSession.CurrentQq, toDiscuss);
        }

        public void AcceptFriendAddingRequest(string addingFriendRequestId, string fromQq, string friendRemark)
        {
            // todo addingFriendRequestId
            _eventFunOutput.Result = 1;
        }

        public void RejectFriendAddingRequest(string addingFriendRequestId, string fromQq)
        {
            // todo addingFriendRequestId
            _eventFunOutput.Result = 2;
        }

        public void AcceptGroupJoiningRequest(string groupJoiningRequestId, string toGroup, string fromQq)
        {
            // todo groupJoiningRequestId
            _eventFunOutput.Result = 1;
        }

        public void RejectGroupJoiningRequest(
            string groupJoiningRequestId,
            string toGroup,
            string fromQq,
            string reason)
        {
            // todo groupJoiningRequestId
            _eventFunOutput.Result = 2;
        }

        public void AcceptGroupJoiningInvitation(string groupJoiningInvitationId, string toGroup, string fromQq)
        {
            // todo groupJoiningInvitationId
            _eventFunOutput.Result = 1;
        }

        public void RejectGroupJoiningInvitation(
            string groupJoiningInvitationId,
            string toGroup,
            string fromQq,
            string reason)
        {
            // todo groupJoiningInvitationId
            _eventFunOutput.Result = 2;
        }

        public void BanFriend(string toQq)
        {
            _mpqApi.Api_Ban(_qqSession.CurrentQq, toQq);
        }

        public void RemoveBanFriend(string toQq)
        {
            _mpqApi.Api_DBan(_qqSession.CurrentQq, toQq);
        }

        public void SetNotice(string toGroup, string title, string content)
        {
            _mpqApi.Api_SetNotice(_qqSession.CurrentQq, toGroup, title, content);
        }

        public void RemoveFriend(string toQq)
        {
            _mpqApi.Api_DelFriend(_qqSession.CurrentQq, toQq);
        }

        public void JoinGroup(string toGroup, string reason)
        {
            _mpqApi.Api_JoinGroup(_qqSession.CurrentQq, toGroup, reason);
        }

        public ModelWithSourceString<IEnumerable<GroupMemberInfo>> GetGroupMemebersWithModel(string toGroup)
        {
            var json = _mpqApi.Api_GetGroupMemberA(_qqSession.CurrentQq, toGroup);
            Logger.Debug(json);
            if (string.IsNullOrEmpty(json))
            {
                return new ModelWithSourceString<IEnumerable<GroupMemberInfo>>
                {
                    SourceString = json,
                    Model = Enumerable.Empty<GroupMemberInfo>()
                };
            }
            var js = new JavaScriptSerializer
            {
                MaxJsonLength = int.MaxValue
            };
            var infos = js.Deserialize<GroupMemberInfoListJson>(json);

            var re = new ModelWithSourceString<IEnumerable<GroupMemberInfo>>
            {
                SourceString = json,
                Model = infos.Mems
                    .Select(x => new GroupMemberInfo
                    {
                        Group = toGroup,

                        // todo age
                        Age = 0,

                        // todo Area
                        Area = string.Empty,
                        Authority = x.Role == 3
                            ? GroupMemberAuthority.Leader
                            : x.Role == 2
                                ? GroupMemberAuthority.Manager
                                : GroupMemberAuthority.Normal,

                        // todo CanModifyInGroupName
                        CanModifyInGroupName = false,
                        Gender = !x.G.HasValue
                            ? Gender.Unknow
                            : x.G == GroupMemberSex.Female
                                ? Gender.Female
                                : Gender.Male,

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
                    })
                    .ToArray(),
            };
            return re;
        }

        public ModelWithSourceString<IEnumerable<GroupInfo>> GetGroupsWithModel()
        {
            var json = _mpqApi.Api_GetGroupListB(_qqSession.CurrentQq);
            if (string.IsNullOrEmpty(json))
            {
                return new ModelWithSourceString<IEnumerable<GroupInfo>>
                {
                    Model = Enumerable.Empty<GroupInfo>(),
                    SourceString = json
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
            return new ModelWithSourceString<IEnumerable<GroupInfo>>
            {
                SourceString = json,
                Model = re
            };
        }

        public string GetGroupMemebers(string toGroup)
        {
            return _mpqApi.Api_GetGroupMemberA(_qqSession.CurrentQq, toGroup);
        }

        public string GetGroups()
        {
            return _mpqApi.Api_GetGroupListB(_qqSession.CurrentQq);
        }

        public string GetFriends()
        {
            return _mpqApi.Api_GetFriendList(_qqSession.CurrentQq);
        }

        public void SendGroupJoiningInvitation(string toQq, string toGroup)
        {
            _mpqApi.Api_GroupInvitation(_qqSession.CurrentQq, toQq, toGroup);
        }

        public string CreateDiscuss()
        {
            return _mpqApi.Api_CreateDG(_qqSession.CurrentQq);
        }

        public void KickDiscussMember(string toDiscuss, string toQq)
        {
            _mpqApi.Api_KickDG(_qqSession.CurrentQq, toQq, toDiscuss);
        }

        public void SendDiscussJoiningInvitation(string toQq, string toDiscuss)
        {
            _mpqApi.Api_DGInvitation(_qqSession.CurrentQq, toQq, toDiscuss);
        }

        public string GetDiscusses()
        {
            var dblist = _mpqApi.Api_GetDGList(_qqSession.CurrentQq);
            return dblist;
        }

        public ILifetimeScope GetContainer()
        {
            return GetLifetimeScope();
        }

        public void SetContainer(ILifetimeScope container)
        {
            SetLifetimeScope(container);
        }

        public ILifetimeScope GetLifetimeScope()
        {
            return _lifetimeScope;
        }

        public void SetLifetimeScope(ILifetimeScope container)
        {
            _lifetimeScope = container;
        }

        public IContainer GetSourceContainer()
        {
            return _container;
        }

        public void SetSourceContainer(IContainer container)
        {
            _container = container;
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
