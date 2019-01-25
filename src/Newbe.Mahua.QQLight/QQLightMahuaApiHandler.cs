using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newbe.Mahua.NativeApi;


// this file is generate from tools, do not change this file
// generate time 2019/01/23 

namespace Newbe.Mahua.QQLight
{
    public class QQLightMahuaApiHandler : IPlatformMahuaApiHandler
    {

        private readonly IMahuaCenter _mahuaCenter;
        private readonly IQQLightApi _qQLightApi;
        private readonly IQqLightAuthCodeContainer _qqLightAuthCodeContainer;

        public QQLightMahuaApiHandler(
            IMahuaCenter mahuaCenter,
            IQQLightApi qQLightApi,
            IQqLightAuthCodeContainer qqLightAuthCodeContainer)
        {
            _mahuaCenter = mahuaCenter;
            _qQLightApi = qQLightApi;
            _qqLightAuthCodeContainer = qqLightAuthCodeContainer;
        }
        public Task Run(string typeCode, IReadOnlyDictionary<string, object> data)
        {
            switch (typeCode)
            {
                case "Api_SendPraise":
                    _qQLightApi.Api_SendPraise(QQ号: data["QQ号"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_SendShake":
                    _qQLightApi.Api_SendShake(QQ号: data["QQ号"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_Getbkn":
                    var Api_GetbknResult =
                    _qQLightApi.Api_Getbkn(AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetbknApiOut
                    { Result = Api_GetbknResult });
                case "Api_QuitGroup":
                    _qQLightApi.Api_QuitGroup(群号: data["群号"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_QuitDiscussGroup":
                    _qQLightApi.Api_QuitDiscussGroup(讨论组号: data["讨论组号"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_SetSignature":
                    _qQLightApi.Api_SetSignature(个性签名: data["个性签名"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_SetDiscussName":
                    _qQLightApi.Api_SetDiscussName(讨论组号: data["讨论组号"].ToString(), 名称: data["名称"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_BanGroup":
                    _qQLightApi.Api_BanGroup(群号: data["群号"].ToString(), 是否全群禁言: Convert.ToBoolean(data["是否全群禁言"]), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_RemoveGroup":
                    _qQLightApi.Api_RemoveGroup(群号: data["群号"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_SetManager":
                    _qQLightApi.Api_SetManager(群号: data["群号"].ToString(), QQ号: data["QQ号"].ToString(), 是否设置为管理员: Convert.ToBoolean(data["是否设置为管理员"]), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_Ban":
                    _qQLightApi.Api_Ban(群号: data["群号"].ToString(), QQ: data["QQ"].ToString(), 禁言时长: Convert.ToInt32(data["禁言时长"]), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_SetAnony":
                    _qQLightApi.Api_SetAnony(群号: data["群号"].ToString(), 是否允许匿名聊天: Convert.ToBoolean(data["是否允许匿名聊天"]), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_RemoveMember":
                    _qQLightApi.Api_RemoveMember(群号: data["群号"].ToString(), QQ号: data["QQ号"].ToString(), 是否不再接收加群申请: Convert.ToBoolean(data["是否不再接收加群申请"]), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_GetCookies":
                    var Api_GetCookiesResult =
                    _qQLightApi.Api_GetCookies(AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetCookiesApiOut
                    { Result = Api_GetCookiesResult });
                case "Api_GetClientKey":
                    var Api_GetClientKeyResult =
                    _qQLightApi.Api_GetClientKey(AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetClientKeyApiOut
                    { Result = Api_GetClientKeyResult });
                case "Api_GetLoginQQ":
                    var Api_GetLoginQQResult =
                    _qQLightApi.Api_GetLoginQQ(AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetLoginQQApiOut
                    { Result = Api_GetLoginQQResult });
                case "Api_GetPluginState":
                    var Api_GetPluginStateResult =
                    _qQLightApi.Api_GetPluginState(AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetPluginStateApiOut
                    { Result = Api_GetPluginStateResult });
                case "Api_GetPath":
                    var Api_GetPathResult =
                    _qQLightApi.Api_GetPath(AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetPathApiOut
                    { Result = Api_GetPathResult });
                case "Api_SendMsg":
                    _qQLightApi.Api_SendMsg(类型: Convert.ToInt32(data["类型"]), 群组: data["群组"].ToString(), QQ号: data["QQ号"].ToString(), 内容: data["内容"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_SetGroupAdd":
                    _qQLightApi.Api_SetGroupAdd(群号: data["群号"].ToString(), QQ号: data["QQ号"].ToString(), Seq: data["Seq"].ToString(), 操作方式: Convert.ToInt32(data["操作方式"]), 拒绝理由: data["拒绝理由"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_SetFriendAdd":
                    _qQLightApi.Api_SetFriendAdd(QQ号: data["QQ号"].ToString(), 操作方式: Convert.ToInt32(data["操作方式"]), 拒绝理由: data["拒绝理由"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_SendLog":
                    _qQLightApi.Api_SendLog(类型: data["类型"].ToString(), 内容: data["内容"].ToString(), 字体颜色: Convert.ToInt32(data["字体颜色"]), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_SetFriendName":
                    _qQLightApi.Api_SetFriendName(好友QQ: data["好友QQ"].ToString(), 备注名: data["备注名"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_DeleteFriend":
                    _qQLightApi.Api_DeleteFriend(好友QQ: data["好友QQ"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_AddGroup":
                    _qQLightApi.Api_AddGroup(群号: data["群号"].ToString(), 附加信息: data["附加信息"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_AddFriend":
                    _qQLightApi.Api_AddFriend(目标QQ: data["目标QQ"].ToString(), 附加信息: data["附加信息"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_163Music":
                    var Api_163MusicResult =
                    _qQLightApi.Api_163Music(歌曲ID: data["歌曲ID"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_163MusicApiOut
                    { Result = Api_163MusicResult });
                case "Api_QQMusic":
                    var Api_QQMusicResult =
                    _qQLightApi.Api_QQMusic(歌曲ID: data["歌曲ID"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_QQMusicApiOut
                    { Result = Api_QQMusicResult });
                case "Api_JsonMusic":
                    var Api_JsonMusicResult =
                    _qQLightApi.Api_JsonMusic(歌曲ID: data["歌曲ID"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_JsonMusicApiOut
                    { Result = Api_JsonMusicResult });
                case "Api_Error":
                    var Api_ErrorResult =
                    _qQLightApi.Api_Error(Code: data["Code"].ToString(), Str: data["Str"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_ErrorApiOut
                    { Result = Api_ErrorResult });
                case "Api_GetGroupCard":
                    var Api_GetGroupCardResult =
                    _qQLightApi.Api_GetGroupCard(群号: data["群号"].ToString(), QQ号: data["QQ号"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetGroupCardApiOut
                    { Result = Api_GetGroupCardResult });
                case "Api_GetNick":
                    var Api_GetNickResult =
                    _qQLightApi.Api_GetNick(QQ号: data["QQ号"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetNickApiOut
                    { Result = Api_GetNickResult });
                case "Api_SetGroupCard":
                    _qQLightApi.Api_SetGroupCard(群号: data["群号"].ToString(), QQ号: data["QQ号"].ToString(), 新名片: data["新名片"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_GetPraiseNum":
                    var Api_GetPraiseNumResult =
                    _qQLightApi.Api_GetPraiseNum(QQ号: data["QQ号"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetPraiseNumApiOut
                    { Result = Api_GetPraiseNumResult });
                case "Api_GetFriendList":
                    var Api_GetFriendListResult =
                    _qQLightApi.Api_GetFriendList(AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetFriendListApiOut
                    { Result = Api_GetFriendListResult });
                case "Api_GetGroupList":
                    var Api_GetGroupListResult =
                    _qQLightApi.Api_GetGroupList(AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetGroupListApiOut
                    { Result = Api_GetGroupListResult });
                case "Api_GetGroupMemberList":
                    var Api_GetGroupMemberListResult =
                    _qQLightApi.Api_GetGroupMemberList(群号: data["群号"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetGroupMemberListApiOut
                    { Result = Api_GetGroupMemberListResult });
                case "Api_GetQQInfo":
                    var Api_GetQQInfoResult =
                    _qQLightApi.Api_GetQQInfo(QQ号: data["QQ号"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetQQInfoApiOut
                    { Result = Api_GetQQInfoResult });
                case "Api_GetGroupInfo":
                    var Api_GetGroupInfoResult =
                    _qQLightApi.Api_GetGroupInfo(群号: data["群号"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetGroupInfoApiOut
                    { Result = Api_GetGroupInfoResult });
                case "Api_Restart":
                    var Api_RestartResult =
                    _qQLightApi.Api_Restart(AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_RestartApiOut
                    { Result = Api_RestartResult });
                case "Api_UpdatePlugin":
                    var Api_UpdatePluginResult =
                    _qQLightApi.Api_UpdatePlugin(AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_UpdatePluginApiOut
                    { Result = Api_UpdatePluginResult });
                case "Api_DeleteMsg":
                    var Api_DeleteMsgResult =
                    _qQLightApi.Api_DeleteMsg(群号: data["群号"].ToString(), 消息ID: data["消息ID"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_DeleteMsgApiOut
                    { Result = Api_DeleteMsgResult });
                case "Api_SetQQState":
                    var Api_SetQQStateResult =
                    _qQLightApi.Api_SetQQState(类型: Convert.ToInt32(data["类型"]), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_SetQQStateApiOut
                    { Result = Api_SetQQStateResult });
                case "Api_InviteFriend":
                    _qQLightApi.Api_InviteFriend(群号: data["群号"].ToString(), 好友QQ: data["好友QQ"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_GetQQinfo_v2":
                    var Api_GetQQinfo_v2Result =
                    _qQLightApi.Api_GetQQinfo_v2(QQ号: data["QQ号"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetQQinfo_v2ApiOut
                    { Result = Api_GetQQinfo_v2Result });
                case "Api_UpLoadPic":
                    var Api_UpLoadPicResult =
                    _qQLightApi.Api_UpLoadPic(类型: Convert.ToInt32(data["类型"]), 对象: data["对象"].ToString(), 图片字节集: data["图片字节集"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_UpLoadPicApiOut
                    { Result = Api_UpLoadPicResult });

                default:
                    throw new ArgumentOutOfRangeException(nameof(typeCode));
            }
        }
    }
    /// <summary>
    /// api out of method Api_Getbkn
    /// </summary>
    public class Api_GetbknApiOut : QQLightApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetbknApiOut);
    }
    /// <summary>
    /// api out of method Api_GetCookies
    /// </summary>
    public class Api_GetCookiesApiOut : QQLightApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetCookiesApiOut);
    }
    /// <summary>
    /// api out of method Api_GetClientKey
    /// </summary>
    public class Api_GetClientKeyApiOut : QQLightApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetClientKeyApiOut);
    }
    /// <summary>
    /// api out of method Api_GetLoginQQ
    /// </summary>
    public class Api_GetLoginQQApiOut : QQLightApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetLoginQQApiOut);
    }
    /// <summary>
    /// api out of method Api_GetPluginState
    /// </summary>
    public class Api_GetPluginStateApiOut : QQLightApiOutput
    {
        public bool Result { get; set; }
        public override string TypeCode => nameof(Api_GetPluginStateApiOut);
    }
    /// <summary>
    /// api out of method Api_GetPath
    /// </summary>
    public class Api_GetPathApiOut : QQLightApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetPathApiOut);
    }
    /// <summary>
    /// api out of method Api_163Music
    /// </summary>
    public class Api_163MusicApiOut : QQLightApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_163MusicApiOut);
    }
    /// <summary>
    /// api out of method Api_QQMusic
    /// </summary>
    public class Api_QQMusicApiOut : QQLightApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_QQMusicApiOut);
    }
    /// <summary>
    /// api out of method Api_JsonMusic
    /// </summary>
    public class Api_JsonMusicApiOut : QQLightApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_JsonMusicApiOut);
    }
    /// <summary>
    /// api out of method Api_Error
    /// </summary>
    public class Api_ErrorApiOut : QQLightApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_ErrorApiOut);
    }
    /// <summary>
    /// api out of method Api_GetGroupCard
    /// </summary>
    public class Api_GetGroupCardApiOut : QQLightApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetGroupCardApiOut);
    }
    /// <summary>
    /// api out of method Api_GetNick
    /// </summary>
    public class Api_GetNickApiOut : QQLightApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetNickApiOut);
    }
    /// <summary>
    /// api out of method Api_GetPraiseNum
    /// </summary>
    public class Api_GetPraiseNumApiOut : QQLightApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetPraiseNumApiOut);
    }
    /// <summary>
    /// api out of method Api_GetFriendList
    /// </summary>
    public class Api_GetFriendListApiOut : QQLightApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetFriendListApiOut);
    }
    /// <summary>
    /// api out of method Api_GetGroupList
    /// </summary>
    public class Api_GetGroupListApiOut : QQLightApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetGroupListApiOut);
    }
    /// <summary>
    /// api out of method Api_GetGroupMemberList
    /// </summary>
    public class Api_GetGroupMemberListApiOut : QQLightApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetGroupMemberListApiOut);
    }
    /// <summary>
    /// api out of method Api_GetQQInfo
    /// </summary>
    public class Api_GetQQInfoApiOut : QQLightApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetQQInfoApiOut);
    }
    /// <summary>
    /// api out of method Api_GetGroupInfo
    /// </summary>
    public class Api_GetGroupInfoApiOut : QQLightApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetGroupInfoApiOut);
    }
    /// <summary>
    /// api out of method Api_Restart
    /// </summary>
    public class Api_RestartApiOut : QQLightApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_RestartApiOut);
    }
    /// <summary>
    /// api out of method Api_UpdatePlugin
    /// </summary>
    public class Api_UpdatePluginApiOut : QQLightApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_UpdatePluginApiOut);
    }
    /// <summary>
    /// api out of method Api_DeleteMsg
    /// </summary>
    public class Api_DeleteMsgApiOut : QQLightApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_DeleteMsgApiOut);
    }
    /// <summary>
    /// api out of method Api_SetQQState
    /// </summary>
    public class Api_SetQQStateApiOut : QQLightApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_SetQQStateApiOut);
    }
    /// <summary>
    /// api out of method Api_GetQQinfo_v2
    /// </summary>
    public class Api_GetQQinfo_v2ApiOut : QQLightApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetQQinfo_v2ApiOut);
    }
    /// <summary>
    /// api out of method Api_UpLoadPic
    /// </summary>
    public class Api_UpLoadPicApiOut : QQLightApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_UpLoadPicApiOut);
    }
}
