using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newbe.Mahua.NativeApi;


// this file is generate from tools, do not change this file
// generate time 2019/01/23 

namespace Newbe.Mahua.CQP
{
    public class CqpMahuaApiHandler : IPlatformMahuaApiHandler
    {

        private readonly IMahuaCenter _mahuaCenter;
        private readonly ICqpApi _cqpApi;
        private readonly ICqpAuthCodeContainer _cqpAuthCodeContainer;

        public CqpMahuaApiHandler(
            IMahuaCenter mahuaCenter,
            ICqpApi cqpApi,
            ICqpAuthCodeContainer cqpAuthCodeContainer)
        {
            _mahuaCenter = mahuaCenter;
            _cqpApi = cqpApi;
            _cqpAuthCodeContainer = cqpAuthCodeContainer;
        }
        public Task Run(string typeCode, IReadOnlyDictionary<string, object> data)
        {
            switch (typeCode)
            {
                case "CQ_sendPrivateMsg":
                    var CQ_sendPrivateMsgResult =
                    _cqpApi.CQ_sendPrivateMsg(AuthCode: _cqpAuthCodeContainer.AuthCode, QQID: Convert.ToInt64(data["QQID"]), msg: data["msg"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new CQ_sendPrivateMsgApiOut
                    { Result = CQ_sendPrivateMsgResult });
                case "CQ_sendGroupMsg":
                    var CQ_sendGroupMsgResult =
                    _cqpApi.CQ_sendGroupMsg(AuthCode: _cqpAuthCodeContainer.AuthCode, 群号: Convert.ToInt64(data["群号"]), msg: data["msg"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new CQ_sendGroupMsgApiOut
                    { Result = CQ_sendGroupMsgResult });
                case "CQ_sendDiscussMsg":
                    var CQ_sendDiscussMsgResult =
                    _cqpApi.CQ_sendDiscussMsg(AuthCode: _cqpAuthCodeContainer.AuthCode, 讨论组号: Convert.ToInt64(data["讨论组号"]), msg: data["msg"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new CQ_sendDiscussMsgApiOut
                    { Result = CQ_sendDiscussMsgResult });
                case "CQ_deleteMsg":
                    var CQ_deleteMsgResult =
                    _cqpApi.CQ_deleteMsg(AuthCode: _cqpAuthCodeContainer.AuthCode, MsgId: Convert.ToInt64(data["MsgId"]));
                    return _mahuaCenter.HandleMahuaOutput(new CQ_deleteMsgApiOut
                    { Result = CQ_deleteMsgResult });
                case "CQ_sendLikeV2":
                    var CQ_sendLikeV2Result =
                    _cqpApi.CQ_sendLikeV2(AuthCode: _cqpAuthCodeContainer.AuthCode, QQID: Convert.ToInt64(data["QQID"]), times: Convert.ToInt32(data["times"]));
                    return _mahuaCenter.HandleMahuaOutput(new CQ_sendLikeV2ApiOut
                    { Result = CQ_sendLikeV2Result });
                case "CQ_getCookies":
                    var CQ_getCookiesResult =
                    _cqpApi.CQ_getCookies(AuthCode: _cqpAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new CQ_getCookiesApiOut
                    { Result = CQ_getCookiesResult });
                case "CQ_getRecord":
                    var CQ_getRecordResult =
                    _cqpApi.CQ_getRecord(AuthCode: _cqpAuthCodeContainer.AuthCode, file: data["file"].ToString(), outformat: data["outformat"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new CQ_getRecordApiOut
                    { Result = CQ_getRecordResult });
                case "CQ_getCsrfToken":
                    var CQ_getCsrfTokenResult =
                    _cqpApi.CQ_getCsrfToken(AuthCode: _cqpAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new CQ_getCsrfTokenApiOut
                    { Result = CQ_getCsrfTokenResult });
                case "CQ_getAppDirectory":
                    var CQ_getAppDirectoryResult =
                    _cqpApi.CQ_getAppDirectory(AuthCode: _cqpAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new CQ_getAppDirectoryApiOut
                    { Result = CQ_getAppDirectoryResult });
                case "CQ_getLoginQQ":
                    var CQ_getLoginQQResult =
                    _cqpApi.CQ_getLoginQQ(AuthCode: _cqpAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new CQ_getLoginQQApiOut
                    { Result = CQ_getLoginQQResult });
                case "CQ_getLoginNick":
                    var CQ_getLoginNickResult =
                    _cqpApi.CQ_getLoginNick(AuthCode: _cqpAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new CQ_getLoginNickApiOut
                    { Result = CQ_getLoginNickResult });
                case "CQ_setGroupKick":
                    var CQ_setGroupKickResult =
                    _cqpApi.CQ_setGroupKick(AuthCode: _cqpAuthCodeContainer.AuthCode, 群号: Convert.ToInt64(data["群号"]), QQID: Convert.ToInt64(data["QQID"]), 拒绝再加群: Convert.ToBoolean(data["拒绝再加群"]));
                    return _mahuaCenter.HandleMahuaOutput(new CQ_setGroupKickApiOut
                    { Result = CQ_setGroupKickResult });
                case "CQ_setGroupBan":
                    var CQ_setGroupBanResult =
                    _cqpApi.CQ_setGroupBan(AuthCode: _cqpAuthCodeContainer.AuthCode, 群号: Convert.ToInt64(data["群号"]), QQID: Convert.ToInt64(data["QQID"]), 禁言时间: Convert.ToInt64(data["禁言时间"]));
                    return _mahuaCenter.HandleMahuaOutput(new CQ_setGroupBanApiOut
                    { Result = CQ_setGroupBanResult });
                case "CQ_setGroupAdmin":
                    var CQ_setGroupAdminResult =
                    _cqpApi.CQ_setGroupAdmin(AuthCode: _cqpAuthCodeContainer.AuthCode, 群号: Convert.ToInt64(data["群号"]), QQID: Convert.ToInt64(data["QQID"]), 成为管理员: Convert.ToBoolean(data["成为管理员"]));
                    return _mahuaCenter.HandleMahuaOutput(new CQ_setGroupAdminApiOut
                    { Result = CQ_setGroupAdminResult });
                case "CQ_setGroupSpecialTitle":
                    var CQ_setGroupSpecialTitleResult =
                    _cqpApi.CQ_setGroupSpecialTitle(AuthCode: _cqpAuthCodeContainer.AuthCode, 群号: Convert.ToInt64(data["群号"]), QQID: Convert.ToInt64(data["QQID"]), 头衔: data["头衔"].ToString(), 过期时间: Convert.ToInt64(data["过期时间"]));
                    return _mahuaCenter.HandleMahuaOutput(new CQ_setGroupSpecialTitleApiOut
                    { Result = CQ_setGroupSpecialTitleResult });
                case "CQ_setGroupWholeBan":
                    var CQ_setGroupWholeBanResult =
                    _cqpApi.CQ_setGroupWholeBan(AuthCode: _cqpAuthCodeContainer.AuthCode, 群号: Convert.ToInt64(data["群号"]), 开启禁言: Convert.ToBoolean(data["开启禁言"]));
                    return _mahuaCenter.HandleMahuaOutput(new CQ_setGroupWholeBanApiOut
                    { Result = CQ_setGroupWholeBanResult });
                case "CQ_setGroupAnonymousBan":
                    var CQ_setGroupAnonymousBanResult =
                    _cqpApi.CQ_setGroupAnonymousBan(AuthCode: _cqpAuthCodeContainer.AuthCode, 群号: Convert.ToInt64(data["群号"]), 匿名: data["匿名"].ToString(), 禁言时间: Convert.ToInt64(data["禁言时间"]));
                    return _mahuaCenter.HandleMahuaOutput(new CQ_setGroupAnonymousBanApiOut
                    { Result = CQ_setGroupAnonymousBanResult });
                case "CQ_setGroupAnonymous":
                    var CQ_setGroupAnonymousResult =
                    _cqpApi.CQ_setGroupAnonymous(AuthCode: _cqpAuthCodeContainer.AuthCode, 群号: Convert.ToInt64(data["群号"]), 开启匿名: Convert.ToBoolean(data["开启匿名"]));
                    return _mahuaCenter.HandleMahuaOutput(new CQ_setGroupAnonymousApiOut
                    { Result = CQ_setGroupAnonymousResult });
                case "CQ_setGroupCard":
                    var CQ_setGroupCardResult =
                    _cqpApi.CQ_setGroupCard(AuthCode: _cqpAuthCodeContainer.AuthCode, 群号: Convert.ToInt64(data["群号"]), QQID: Convert.ToInt64(data["QQID"]), 新名片_昵称: data["新名片_昵称"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new CQ_setGroupCardApiOut
                    { Result = CQ_setGroupCardResult });
                case "CQ_setGroupLeave":
                    var CQ_setGroupLeaveResult =
                    _cqpApi.CQ_setGroupLeave(AuthCode: _cqpAuthCodeContainer.AuthCode, 群号: Convert.ToInt64(data["群号"]), 是否解散: Convert.ToBoolean(data["是否解散"]));
                    return _mahuaCenter.HandleMahuaOutput(new CQ_setGroupLeaveApiOut
                    { Result = CQ_setGroupLeaveResult });
                case "CQ_setDiscussLeave":
                    var CQ_setDiscussLeaveResult =
                    _cqpApi.CQ_setDiscussLeave(AuthCode: _cqpAuthCodeContainer.AuthCode, 讨论组号: Convert.ToInt64(data["讨论组号"]));
                    return _mahuaCenter.HandleMahuaOutput(new CQ_setDiscussLeaveApiOut
                    { Result = CQ_setDiscussLeaveResult });
                case "CQ_setFriendAddRequest":
                    var CQ_setFriendAddRequestResult =
                    _cqpApi.CQ_setFriendAddRequest(AuthCode: _cqpAuthCodeContainer.AuthCode, 请求反馈标识: data["请求反馈标识"].ToString(), 反馈类型: Convert.ToInt32(data["反馈类型"]), 备注: data["备注"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new CQ_setFriendAddRequestApiOut
                    { Result = CQ_setFriendAddRequestResult });
                case "CQ_setGroupAddRequestV2":
                    var CQ_setGroupAddRequestV2Result =
                    _cqpApi.CQ_setGroupAddRequestV2(AuthCode: _cqpAuthCodeContainer.AuthCode, 请求反馈标识: data["请求反馈标识"].ToString(), 请求类型: Convert.ToInt32(data["请求类型"]), 反馈类型: Convert.ToInt32(data["反馈类型"]), 理由: data["理由"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new CQ_setGroupAddRequestV2ApiOut
                    { Result = CQ_setGroupAddRequestV2Result });
                case "CQ_addLog":
                    var CQ_addLogResult =
                    _cqpApi.CQ_addLog(AuthCode: _cqpAuthCodeContainer.AuthCode, 优先级: Convert.ToInt32(data["优先级"]), 类型: data["类型"].ToString(), 内容: data["内容"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new CQ_addLogApiOut
                    { Result = CQ_addLogResult });
                case "CQ_setFatal":
                    var CQ_setFatalResult =
                    _cqpApi.CQ_setFatal(AuthCode: _cqpAuthCodeContainer.AuthCode, 错误信息: data["错误信息"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new CQ_setFatalApiOut
                    { Result = CQ_setFatalResult });
                case "CQ_getGroupMemberInfoV2":
                    var CQ_getGroupMemberInfoV2Result =
                    _cqpApi.CQ_getGroupMemberInfoV2(AuthCode: _cqpAuthCodeContainer.AuthCode, 群号: Convert.ToInt64(data["群号"]), QQID: Convert.ToInt64(data["QQID"]), 不使用缓存: Convert.ToBoolean(data["不使用缓存"]));
                    return _mahuaCenter.HandleMahuaOutput(new CQ_getGroupMemberInfoV2ApiOut
                    { Result = CQ_getGroupMemberInfoV2Result });
                case "CQ_getGroupMemberList":
                    var CQ_getGroupMemberListResult =
                    _cqpApi.CQ_getGroupMemberList(AuthCode: _cqpAuthCodeContainer.AuthCode, 群号: Convert.ToInt64(data["群号"]));
                    return _mahuaCenter.HandleMahuaOutput(new CQ_getGroupMemberListApiOut
                    { Result = CQ_getGroupMemberListResult });
                case "CQ_getGroupList":
                    var CQ_getGroupListResult =
                    _cqpApi.CQ_getGroupList(AuthCode: _cqpAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new CQ_getGroupListApiOut
                    { Result = CQ_getGroupListResult });
                case "CQ_getStrangerInfo":
                    var CQ_getStrangerInfoResult =
                    _cqpApi.CQ_getStrangerInfo(AuthCode: _cqpAuthCodeContainer.AuthCode, QQID: Convert.ToInt64(data["QQID"]), 不使用缓存: Convert.ToBoolean(data["不使用缓存"]));
                    return _mahuaCenter.HandleMahuaOutput(new CQ_getStrangerInfoApiOut
                    { Result = CQ_getStrangerInfoResult });

                default:
                    throw new ArgumentOutOfRangeException(nameof(typeCode));
            }
        }
    }
    /// <summary>
    /// api out of method CQ_sendPrivateMsg
    /// </summary>
    public class CQ_sendPrivateMsgApiOut : CqpApiOutput
    {
        public int Result { get; set; }
        public override string TypeCode => nameof(CQ_sendPrivateMsgApiOut);
    }
    /// <summary>
    /// api out of method CQ_sendGroupMsg
    /// </summary>
    public class CQ_sendGroupMsgApiOut : CqpApiOutput
    {
        public int Result { get; set; }
        public override string TypeCode => nameof(CQ_sendGroupMsgApiOut);
    }
    /// <summary>
    /// api out of method CQ_sendDiscussMsg
    /// </summary>
    public class CQ_sendDiscussMsgApiOut : CqpApiOutput
    {
        public int Result { get; set; }
        public override string TypeCode => nameof(CQ_sendDiscussMsgApiOut);
    }
    /// <summary>
    /// api out of method CQ_deleteMsg
    /// </summary>
    public class CQ_deleteMsgApiOut : CqpApiOutput
    {
        public int Result { get; set; }
        public override string TypeCode => nameof(CQ_deleteMsgApiOut);
    }
    /// <summary>
    /// api out of method CQ_sendLikeV2
    /// </summary>
    public class CQ_sendLikeV2ApiOut : CqpApiOutput
    {
        public int Result { get; set; }
        public override string TypeCode => nameof(CQ_sendLikeV2ApiOut);
    }
    /// <summary>
    /// api out of method CQ_getCookies
    /// </summary>
    public class CQ_getCookiesApiOut : CqpApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(CQ_getCookiesApiOut);
    }
    /// <summary>
    /// api out of method CQ_getRecord
    /// </summary>
    public class CQ_getRecordApiOut : CqpApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(CQ_getRecordApiOut);
    }
    /// <summary>
    /// api out of method CQ_getCsrfToken
    /// </summary>
    public class CQ_getCsrfTokenApiOut : CqpApiOutput
    {
        public int Result { get; set; }
        public override string TypeCode => nameof(CQ_getCsrfTokenApiOut);
    }
    /// <summary>
    /// api out of method CQ_getAppDirectory
    /// </summary>
    public class CQ_getAppDirectoryApiOut : CqpApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(CQ_getAppDirectoryApiOut);
    }
    /// <summary>
    /// api out of method CQ_getLoginQQ
    /// </summary>
    public class CQ_getLoginQQApiOut : CqpApiOutput
    {
        public long Result { get; set; }
        public override string TypeCode => nameof(CQ_getLoginQQApiOut);
    }
    /// <summary>
    /// api out of method CQ_getLoginNick
    /// </summary>
    public class CQ_getLoginNickApiOut : CqpApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(CQ_getLoginNickApiOut);
    }
    /// <summary>
    /// api out of method CQ_setGroupKick
    /// </summary>
    public class CQ_setGroupKickApiOut : CqpApiOutput
    {
        public int Result { get; set; }
        public override string TypeCode => nameof(CQ_setGroupKickApiOut);
    }
    /// <summary>
    /// api out of method CQ_setGroupBan
    /// </summary>
    public class CQ_setGroupBanApiOut : CqpApiOutput
    {
        public int Result { get; set; }
        public override string TypeCode => nameof(CQ_setGroupBanApiOut);
    }
    /// <summary>
    /// api out of method CQ_setGroupAdmin
    /// </summary>
    public class CQ_setGroupAdminApiOut : CqpApiOutput
    {
        public int Result { get; set; }
        public override string TypeCode => nameof(CQ_setGroupAdminApiOut);
    }
    /// <summary>
    /// api out of method CQ_setGroupSpecialTitle
    /// </summary>
    public class CQ_setGroupSpecialTitleApiOut : CqpApiOutput
    {
        public int Result { get; set; }
        public override string TypeCode => nameof(CQ_setGroupSpecialTitleApiOut);
    }
    /// <summary>
    /// api out of method CQ_setGroupWholeBan
    /// </summary>
    public class CQ_setGroupWholeBanApiOut : CqpApiOutput
    {
        public int Result { get; set; }
        public override string TypeCode => nameof(CQ_setGroupWholeBanApiOut);
    }
    /// <summary>
    /// api out of method CQ_setGroupAnonymousBan
    /// </summary>
    public class CQ_setGroupAnonymousBanApiOut : CqpApiOutput
    {
        public int Result { get; set; }
        public override string TypeCode => nameof(CQ_setGroupAnonymousBanApiOut);
    }
    /// <summary>
    /// api out of method CQ_setGroupAnonymous
    /// </summary>
    public class CQ_setGroupAnonymousApiOut : CqpApiOutput
    {
        public int Result { get; set; }
        public override string TypeCode => nameof(CQ_setGroupAnonymousApiOut);
    }
    /// <summary>
    /// api out of method CQ_setGroupCard
    /// </summary>
    public class CQ_setGroupCardApiOut : CqpApiOutput
    {
        public int Result { get; set; }
        public override string TypeCode => nameof(CQ_setGroupCardApiOut);
    }
    /// <summary>
    /// api out of method CQ_setGroupLeave
    /// </summary>
    public class CQ_setGroupLeaveApiOut : CqpApiOutput
    {
        public int Result { get; set; }
        public override string TypeCode => nameof(CQ_setGroupLeaveApiOut);
    }
    /// <summary>
    /// api out of method CQ_setDiscussLeave
    /// </summary>
    public class CQ_setDiscussLeaveApiOut : CqpApiOutput
    {
        public int Result { get; set; }
        public override string TypeCode => nameof(CQ_setDiscussLeaveApiOut);
    }
    /// <summary>
    /// api out of method CQ_setFriendAddRequest
    /// </summary>
    public class CQ_setFriendAddRequestApiOut : CqpApiOutput
    {
        public int Result { get; set; }
        public override string TypeCode => nameof(CQ_setFriendAddRequestApiOut);
    }
    /// <summary>
    /// api out of method CQ_setGroupAddRequestV2
    /// </summary>
    public class CQ_setGroupAddRequestV2ApiOut : CqpApiOutput
    {
        public int Result { get; set; }
        public override string TypeCode => nameof(CQ_setGroupAddRequestV2ApiOut);
    }
    /// <summary>
    /// api out of method CQ_addLog
    /// </summary>
    public class CQ_addLogApiOut : CqpApiOutput
    {
        public int Result { get; set; }
        public override string TypeCode => nameof(CQ_addLogApiOut);
    }
    /// <summary>
    /// api out of method CQ_setFatal
    /// </summary>
    public class CQ_setFatalApiOut : CqpApiOutput
    {
        public int Result { get; set; }
        public override string TypeCode => nameof(CQ_setFatalApiOut);
    }
    /// <summary>
    /// api out of method CQ_getGroupMemberInfoV2
    /// </summary>
    public class CQ_getGroupMemberInfoV2ApiOut : CqpApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(CQ_getGroupMemberInfoV2ApiOut);
    }
    /// <summary>
    /// api out of method CQ_getGroupMemberList
    /// </summary>
    public class CQ_getGroupMemberListApiOut : CqpApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(CQ_getGroupMemberListApiOut);
    }
    /// <summary>
    /// api out of method CQ_getGroupList
    /// </summary>
    public class CQ_getGroupListApiOut : CqpApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(CQ_getGroupListApiOut);
    }
    /// <summary>
    /// api out of method CQ_getStrangerInfo
    /// </summary>
    public class CQ_getStrangerInfoApiOut : CqpApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(CQ_getStrangerInfoApiOut);
    }
}
