using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.MPQ
{
    public class MpqMahuaApiHandler : IPlatformMahuaApiHandler
    {

        private readonly IMahuaCenter _mahuaCenter;
        private readonly IMpqApi _mpqApi;

        public MpqMahuaApiHandler(
            IMahuaCenter mahuaCenter,
            IMpqApi mpqApi)
        {
            _mahuaCenter = mahuaCenter;
            _mpqApi = mpqApi;
        }
        public Task Run(string typeCode, IReadOnlyDictionary<string, object> data)
        {
            switch (typeCode)
            {
                case "Api_GetGtk_Bkn":
                    var Api_GetGtk_BknResult =
                    _mpqApi.Api_GetGtk_Bkn(响应的QQ: data["响应的QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetGtk_BknApiOut
                    { Result = Api_GetGtk_BknResult });
                case "Api_GetBkn32":
                    var Api_GetBkn32Result =
                    _mpqApi.Api_GetBkn32(响应的QQ: data["响应的QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetBkn32ApiOut
                    { Result = Api_GetBkn32Result });
                case "Api_GetLdw":
                    var Api_GetLdwResult =
                    _mpqApi.Api_GetLdw(响应的QQ: data["响应的QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetLdwApiOut
                    { Result = Api_GetLdwResult });
                case "Api_GetRunPath":
                    var Api_GetRunPathResult =
                    _mpqApi.Api_GetRunPath();
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetRunPathApiOut
                    { Result = Api_GetRunPathResult });
                case "Api_GetOnlineQQlist":
                    var Api_GetOnlineQQlistResult =
                    _mpqApi.Api_GetOnlineQQlist();
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetOnlineQQlistApiOut
                    { Result = Api_GetOnlineQQlistResult });
                case "Api_GetQQlist":
                    var Api_GetQQlistResult =
                    _mpqApi.Api_GetQQlist();
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetQQlistApiOut
                    { Result = Api_GetQQlistResult });
                case "Api_GetSessionkey":
                    var Api_GetSessionkeyResult =
                    _mpqApi.Api_GetSessionkey(响应的QQ: data["响应的QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetSessionkeyApiOut
                    { Result = Api_GetSessionkeyResult });
                case "Api_GetClientkey":
                    var Api_GetClientkeyResult =
                    _mpqApi.Api_GetClientkey(响应的QQ: data["响应的QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetClientkeyApiOut
                    { Result = Api_GetClientkeyResult });
                case "Api_GetLongClientkey":
                    var Api_GetLongClientkeyResult =
                    _mpqApi.Api_GetLongClientkey(响应的QQ: data["响应的QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetLongClientkeyApiOut
                    { Result = Api_GetLongClientkeyResult });
                case "Api_GetCookies":
                    var Api_GetCookiesResult =
                    _mpqApi.Api_GetCookies(响应的QQ: data["响应的QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetCookiesApiOut
                    { Result = Api_GetCookiesResult });
                case "Api_GetPrefix":
                    var Api_GetPrefixResult =
                    _mpqApi.Api_GetPrefix();
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetPrefixApiOut
                    { Result = Api_GetPrefixResult });
                case "Api_Cache_NameCard":
                    _mpqApi.Api_Cache_NameCard(群号: data["群号"].ToString(), QQ: data["QQ"].ToString(), 名片: data["名片"].ToString());
                    return Task.CompletedTask;
                case "Api_DBan":
                    _mpqApi.Api_DBan(响应的QQ: data["响应的QQ"].ToString(), QQ: data["QQ"].ToString());
                    return Task.CompletedTask;
                case "Api_Ban":
                    _mpqApi.Api_Ban(响应的QQ: data["响应的QQ"].ToString(), QQ: data["QQ"].ToString());
                    return Task.CompletedTask;
                case "Api_Shutup":
                    var Api_ShutupResult =
                    _mpqApi.Api_Shutup(响应的QQ: data["响应的QQ"].ToString(), 群号: data["群号"].ToString(), QQ: data["QQ"].ToString(), 时长: Convert.ToInt32(data["时长"]));
                    return _mahuaCenter.HandleMahuaOutput(new Api_ShutupApiOut
                    { Result = Api_ShutupResult });
                case "Api_SetNotice":
                    _mpqApi.Api_SetNotice(响应的QQ: data["响应的QQ"].ToString(), 群号: data["群号"].ToString(), 标题: data["标题"].ToString(), 内容: data["内容"].ToString());
                    return Task.CompletedTask;
                case "Api_GetNotice":
                    var Api_GetNoticeResult =
                    _mpqApi.Api_GetNotice(响应的QQ: data["响应的QQ"].ToString(), 群号: data["群号"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetNoticeApiOut
                    { Result = Api_GetNoticeResult });
                case "Api_GetNameCard":
                    var Api_GetNameCardResult =
                    _mpqApi.Api_GetNameCard(响应的QQ: data["响应的QQ"].ToString(), 群号: data["群号"].ToString(), QQ: data["QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetNameCardApiOut
                    { Result = Api_GetNameCardResult });
                case "Api_SetNameCard":
                    _mpqApi.Api_SetNameCard(响应的QQ: data["响应的QQ"].ToString(), 群号: data["群号"].ToString(), QQ: data["QQ"].ToString(), 名片: data["名片"].ToString());
                    return Task.CompletedTask;
                case "Api_QuitDG":
                    _mpqApi.Api_QuitDG(响应的QQ: data["响应的QQ"].ToString(), 讨论组ID: data["讨论组ID"].ToString());
                    return Task.CompletedTask;
                case "Api_DelFriend":
                    var Api_DelFriendResult =
                    _mpqApi.Api_DelFriend(响应的QQ: data["响应的QQ"].ToString(), QQ: data["QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_DelFriendApiOut
                    { Result = Api_DelFriendResult });
                case "Api_Kick":
                    var Api_KickResult =
                    _mpqApi.Api_Kick(响应的QQ: data["响应的QQ"].ToString(), 群号: data["群号"].ToString(), 对象: data["对象"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_KickApiOut
                    { Result = Api_KickResult });
                case "Api_JoinGroup":
                    _mpqApi.Api_JoinGroup(响应的QQ: data["响应的QQ"].ToString(), 群号: data["群号"].ToString(), 附加理由: data["附加理由"].ToString());
                    return Task.CompletedTask;
                case "Api_QuitGroup":
                    _mpqApi.Api_QuitGroup(响应的QQ: data["响应的QQ"].ToString(), 群号: data["群号"].ToString());
                    return Task.CompletedTask;
                case "Api_UploadPic":
                    var Api_UploadPicResult =
                    _mpqApi.Api_UploadPic(响应的QQ: data["响应的QQ"].ToString(), 参_上传类型: Convert.ToInt32(data["参_上传类型"]), 参_参考对象: data["参_参考对象"].ToString(), 参_图片数据: Convert.FromBase64String(data["参_图片数据"].ToString()));
                    return _mahuaCenter.HandleMahuaOutput(new Api_UploadPicApiOut
                    { Result = Api_UploadPicResult });
                case "Api_GuidGetPicLink":
                    var Api_GuidGetPicLinkResult =
                    _mpqApi.Api_GuidGetPicLink(图片GUID: data["图片GUID"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GuidGetPicLinkApiOut
                    { Result = Api_GuidGetPicLinkResult });
                case "Api_Reply":
                    var Api_ReplyResult =
                    _mpqApi.Api_Reply(响应的QQ: data["响应的QQ"].ToString(), 信息类型: Convert.ToInt32(data["信息类型"]), 回复对象: data["回复对象"].ToString(), 内容: data["内容"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_ReplyApiOut
                    { Result = Api_ReplyResult });
                case "Api_SendMsg":
                    var Api_SendMsgResult =
                    _mpqApi.Api_SendMsg(响应的QQ: data["响应的QQ"].ToString(), 信息类型: Convert.ToInt32(data["信息类型"]), 参考子类型: Convert.ToInt32(data["参考子类型"]), 收信群_讨论组: data["收信群_讨论组"].ToString(), 收信对象: data["收信对象"].ToString(), 内容: data["内容"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_SendMsgApiOut
                    { Result = Api_SendMsgResult });
                case "Api_Send":
                    var Api_SendResult =
                    _mpqApi.Api_Send(封包内容: data["封包内容"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_SendApiOut
                    { Result = Api_SendResult });
                case "Api_OutPut":
                    var Api_OutPutResult =
                    _mpqApi.Api_OutPut(内容: data["内容"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_OutPutApiOut
                    { Result = Api_OutPutResult });
                case "Api_IsEnable":
                    var Api_IsEnableResult =
                    _mpqApi.Api_IsEnable();
                    return _mahuaCenter.HandleMahuaOutput(new Api_IsEnableApiOut
                    { Result = Api_IsEnableResult });
                case "Api_Login":
                    var Api_LoginResult =
                    _mpqApi.Api_Login(QQ: data["QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_LoginApiOut
                    { Result = Api_LoginResult });
                case "Api_Logout":
                    _mpqApi.Api_Logout(QQ: data["QQ"].ToString());
                    return Task.CompletedTask;
                case "Api_Tea加密":
                    var Api_Tea加密Result =
                    _mpqApi.Api_Tea加密(加密内容: data["加密内容"].ToString(), Key: data["Key"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_Tea加密ApiOut
                    { Result = Api_Tea加密Result });
                case "Api_Tea解密":
                    var Api_Tea解密Result =
                    _mpqApi.Api_Tea解密(解密内容: data["解密内容"].ToString(), Key: data["Key"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_Tea解密ApiOut
                    { Result = Api_Tea解密Result });
                case "Api_GetNick":
                    var Api_GetNickResult =
                    _mpqApi.Api_GetNick(QQ: data["QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetNickApiOut
                    { Result = Api_GetNickResult });
                case "Api_GetQQLevel":
                    var Api_GetQQLevelResult =
                    _mpqApi.Api_GetQQLevel(QQ: data["QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetQQLevelApiOut
                    { Result = Api_GetQQLevelResult });
                case "Api_GNGetGid":
                    var Api_GNGetGidResult =
                    _mpqApi.Api_GNGetGid(群号: data["群号"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GNGetGidApiOut
                    { Result = Api_GNGetGidResult });
                case "Api_GidGetGN":
                    var Api_GidGetGNResult =
                    _mpqApi.Api_GidGetGN(群ID: data["群ID"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GidGetGNApiOut
                    { Result = Api_GidGetGNResult });
                case "Api_GetVersion":
                    var Api_GetVersionResult =
                    _mpqApi.Api_GetVersion();
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetVersionApiOut
                    { Result = Api_GetVersionResult });
                case "Api_GetVersionName":
                    var Api_GetVersionNameResult =
                    _mpqApi.Api_GetVersionName();
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetVersionNameApiOut
                    { Result = Api_GetVersionNameResult });
                case "Api_GetTimeStamp":
                    var Api_GetTimeStampResult =
                    _mpqApi.Api_GetTimeStamp();
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetTimeStampApiOut
                    { Result = Api_GetTimeStampResult });
                case "Api_GetLog":
                    var Api_GetLogResult =
                    _mpqApi.Api_GetLog();
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetLogApiOut
                    { Result = Api_GetLogResult });
                case "Api_IfBlock":
                    var Api_IfBlockResult =
                    _mpqApi.Api_IfBlock(响应的QQ: data["响应的QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_IfBlockApiOut
                    { Result = Api_IfBlockResult });
                case "Api_GetAdminList":
                    var Api_GetAdminListResult =
                    _mpqApi.Api_GetAdminList(响应的QQ: data["响应的QQ"].ToString(), 群号: data["群号"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetAdminListApiOut
                    { Result = Api_GetAdminListResult });
                case "Api_AddTaotao":
                    var Api_AddTaotaoResult =
                    _mpqApi.Api_AddTaotao(响应的QQ: data["响应的QQ"].ToString(), 内容: data["内容"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_AddTaotaoApiOut
                    { Result = Api_AddTaotaoResult });
                case "Api_GetSign":
                    var Api_GetSignResult =
                    _mpqApi.Api_GetSign(响应的QQ: data["响应的QQ"].ToString(), 对象: data["对象"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetSignApiOut
                    { Result = Api_GetSignResult });
                case "Api_SetSign":
                    var Api_SetSignResult =
                    _mpqApi.Api_SetSign(响应的QQ: data["响应的QQ"].ToString(), 内容: data["内容"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_SetSignApiOut
                    { Result = Api_SetSignResult });
                case "Api_GetGroupListA":
                    var Api_GetGroupListAResult =
                    _mpqApi.Api_GetGroupListA(响应的QQ: data["响应的QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetGroupListAApiOut
                    { Result = Api_GetGroupListAResult });
                case "Api_GetGroupListB":
                    var Api_GetGroupListBResult =
                    _mpqApi.Api_GetGroupListB(响应的QQ: data["响应的QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetGroupListBApiOut
                    { Result = Api_GetGroupListBResult });
                case "Api_GetGroupMemberA":
                    var Api_GetGroupMemberAResult =
                    _mpqApi.Api_GetGroupMemberA(响应的QQ: data["响应的QQ"].ToString(), 群号: data["群号"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetGroupMemberAApiOut
                    { Result = Api_GetGroupMemberAResult });
                case "Api_GetGroupMemberB":
                    var Api_GetGroupMemberBResult =
                    _mpqApi.Api_GetGroupMemberB(响应的QQ: data["响应的QQ"].ToString(), 群号: data["群号"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetGroupMemberBApiOut
                    { Result = Api_GetGroupMemberBResult });
                case "Api_GetFriendList":
                    var Api_GetFriendListResult =
                    _mpqApi.Api_GetFriendList(响应的QQ: data["响应的QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetFriendListApiOut
                    { Result = Api_GetFriendListResult });
                case "Api_GetQQAge":
                    var Api_GetQQAgeResult =
                    _mpqApi.Api_GetQQAge(响应的QQ: data["响应的QQ"].ToString(), QQ: data["QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetQQAgeApiOut
                    { Result = Api_GetQQAgeResult });
                case "Api_GetAge":
                    var Api_GetAgeResult =
                    _mpqApi.Api_GetAge(响应的QQ: data["响应的QQ"].ToString(), QQ: data["QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetAgeApiOut
                    { Result = Api_GetAgeResult });
                case "Api_GetPersonalProfile":
                    var Api_GetPersonalProfileResult =
                    _mpqApi.Api_GetPersonalProfile(响应的QQ: data["响应的QQ"].ToString(), QQ: data["QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetPersonalProfileApiOut
                    { Result = Api_GetPersonalProfileResult });
                case "Api_GetEmail":
                    var Api_GetEmailResult =
                    _mpqApi.Api_GetEmail(响应的QQ: data["响应的QQ"].ToString(), QQ: data["QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetEmailApiOut
                    { Result = Api_GetEmailResult });
                case "Api_GetGender":
                    var Api_GetGenderResult =
                    _mpqApi.Api_GetGender(响应的QQ: data["响应的QQ"].ToString(), QQ: data["QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetGenderApiOut
                    { Result = Api_GetGenderResult });
                case "Api_SendTyping":
                    var Api_SendTypingResult =
                    _mpqApi.Api_SendTyping(响应的QQ: data["响应的QQ"].ToString(), QQ: data["QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_SendTypingApiOut
                    { Result = Api_SendTypingResult });
                case "Api_SendShake":
                    var Api_SendShakeResult =
                    _mpqApi.Api_SendShake(响应的QQ: data["响应的QQ"].ToString(), QQ: data["QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_SendShakeApiOut
                    { Result = Api_SendShakeResult });
                case "Api_GetRadomOnlineQQ":
                    var Api_GetRadomOnlineQQResult =
                    _mpqApi.Api_GetRadomOnlineQQ();
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetRadomOnlineQQApiOut
                    { Result = Api_GetRadomOnlineQQResult });
                case "Api_AddQQ":
                    var Api_AddQQResult =
                    _mpqApi.Api_AddQQ(QQ: data["QQ"].ToString(), 密码: data["密码"].ToString(), 自动登录: Convert.ToBoolean(data["自动登录"]));
                    return _mahuaCenter.HandleMahuaOutput(new Api_AddQQApiOut
                    { Result = Api_AddQQResult });
                case "Api_SetOLStatus":
                    var Api_SetOLStatusResult =
                    _mpqApi.Api_SetOLStatus(响应的QQ: data["响应的QQ"].ToString(), 在线状态: Convert.ToInt32(data["在线状态"]), 状态附加信息: data["状态附加信息"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_SetOLStatusApiOut
                    { Result = Api_SetOLStatusResult });
                case "Api_GetMC":
                    var Api_GetMCResult =
                    _mpqApi.Api_GetMC();
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetMCApiOut
                    { Result = Api_GetMCResult });
                case "Api_GroupInvitation":
                    var Api_GroupInvitationResult =
                    _mpqApi.Api_GroupInvitation(响应的QQ: data["响应的QQ"].ToString(), 好友QQ: data["好友QQ"].ToString(), 群号: data["群号"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GroupInvitationApiOut
                    { Result = Api_GroupInvitationResult });
                case "Api_CreateDG":
                    var Api_CreateDGResult =
                    _mpqApi.Api_CreateDG(响应的QQ: data["响应的QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_CreateDGApiOut
                    { Result = Api_CreateDGResult });
                case "Api_KickDG":
                    var Api_KickDGResult =
                    _mpqApi.Api_KickDG(响应的QQ: data["响应的QQ"].ToString(), 讨论组ID: data["讨论组ID"].ToString(), 成员: data["成员"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_KickDGApiOut
                    { Result = Api_KickDGResult });
                case "Api_DGInvitation":
                    var Api_DGInvitationResult =
                    _mpqApi.Api_DGInvitation(响应的QQ: data["响应的QQ"].ToString(), 讨论组ID: data["讨论组ID"].ToString(), 成员组: data["成员组"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_DGInvitationApiOut
                    { Result = Api_DGInvitationResult });
                case "Api_GetDGList":
                    var Api_GetDGListResult =
                    _mpqApi.Api_GetDGList(响应的QQ: data["响应的QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetDGListApiOut
                    { Result = Api_GetDGListResult });
                case "Api_SendMusic":
                    var Api_SendMusicResult =
                    _mpqApi.Api_SendMusic(响应的QQ: data["响应的QQ"].ToString(), 收信对象类型: Convert.ToInt32(data["收信对象类型"]), 收信对象所属群_讨论组: data["收信对象所属群_讨论组"].ToString(), 收信对象QQ: data["收信对象QQ"].ToString(), 音乐简介: data["音乐简介"].ToString(), 音乐播放页面连接: data["音乐播放页面连接"].ToString(), 音乐封面连接: data["音乐封面连接"].ToString(), 音乐文件直连连接: data["音乐文件直连连接"].ToString(), 曲名: data["曲名"].ToString(), 歌手名: data["歌手名"].ToString(), 音乐来源名: data["音乐来源名"].ToString(), 音乐来源图标连接: data["音乐来源图标连接"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_SendMusicApiOut
                    { Result = Api_SendMusicResult });
                case "Api_SendObjectMsg":
                    var Api_SendObjectMsgResult =
                    _mpqApi.Api_SendObjectMsg(响应的QQ: data["响应的QQ"].ToString(), 收信对象类型: Convert.ToInt32(data["收信对象类型"]), 收信对象所属群_讨论组: data["收信对象所属群_讨论组"].ToString(), 收信对象QQ: data["收信对象QQ"].ToString(), ObjectMsg: data["ObjectMsg"].ToString(), 结构子类型: Convert.ToInt32(data["结构子类型"]));
                    return _mahuaCenter.HandleMahuaOutput(new Api_SendObjectMsgApiOut
                    { Result = Api_SendObjectMsgResult });
                case "Api_IsFriend":
                    var Api_IsFriendResult =
                    _mpqApi.Api_IsFriend(响应的QQ: data["响应的QQ"].ToString(), 对象QQ: data["对象QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_IsFriendApiOut
                    { Result = Api_IsFriendResult });

                default:
                    throw new ArgumentOutOfRangeException(nameof(typeCode));
            }
        }
    }
    /// <summary>
    /// api out of method Api_GetGtk_Bkn
    /// </summary>
    public class Api_GetGtk_BknApiOut : MpqApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetGtk_BknApiOut);
    }
    /// <summary>
    /// api out of method Api_GetBkn32
    /// </summary>
    public class Api_GetBkn32ApiOut : MpqApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetBkn32ApiOut);
    }
    /// <summary>
    /// api out of method Api_GetLdw
    /// </summary>
    public class Api_GetLdwApiOut : MpqApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetLdwApiOut);
    }
    /// <summary>
    /// api out of method Api_GetRunPath
    /// </summary>
    public class Api_GetRunPathApiOut : MpqApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetRunPathApiOut);
    }
    /// <summary>
    /// api out of method Api_GetOnlineQQlist
    /// </summary>
    public class Api_GetOnlineQQlistApiOut : MpqApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetOnlineQQlistApiOut);
    }
    /// <summary>
    /// api out of method Api_GetQQlist
    /// </summary>
    public class Api_GetQQlistApiOut : MpqApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetQQlistApiOut);
    }
    /// <summary>
    /// api out of method Api_GetSessionkey
    /// </summary>
    public class Api_GetSessionkeyApiOut : MpqApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetSessionkeyApiOut);
    }
    /// <summary>
    /// api out of method Api_GetClientkey
    /// </summary>
    public class Api_GetClientkeyApiOut : MpqApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetClientkeyApiOut);
    }
    /// <summary>
    /// api out of method Api_GetLongClientkey
    /// </summary>
    public class Api_GetLongClientkeyApiOut : MpqApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetLongClientkeyApiOut);
    }
    /// <summary>
    /// api out of method Api_GetCookies
    /// </summary>
    public class Api_GetCookiesApiOut : MpqApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetCookiesApiOut);
    }
    /// <summary>
    /// api out of method Api_GetPrefix
    /// </summary>
    public class Api_GetPrefixApiOut : MpqApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetPrefixApiOut);
    }
    /// <summary>
    /// api out of method Api_Shutup
    /// </summary>
    public class Api_ShutupApiOut : MpqApiOutput
    {
        public bool Result { get; set; }
        public override string TypeCode => nameof(Api_ShutupApiOut);
    }
    /// <summary>
    /// api out of method Api_GetNotice
    /// </summary>
    public class Api_GetNoticeApiOut : MpqApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetNoticeApiOut);
    }
    /// <summary>
    /// api out of method Api_GetNameCard
    /// </summary>
    public class Api_GetNameCardApiOut : MpqApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetNameCardApiOut);
    }
    /// <summary>
    /// api out of method Api_DelFriend
    /// </summary>
    public class Api_DelFriendApiOut : MpqApiOutput
    {
        public bool Result { get; set; }
        public override string TypeCode => nameof(Api_DelFriendApiOut);
    }
    /// <summary>
    /// api out of method Api_Kick
    /// </summary>
    public class Api_KickApiOut : MpqApiOutput
    {
        public bool Result { get; set; }
        public override string TypeCode => nameof(Api_KickApiOut);
    }
    /// <summary>
    /// api out of method Api_UploadPic
    /// </summary>
    public class Api_UploadPicApiOut : MpqApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_UploadPicApiOut);
    }
    /// <summary>
    /// api out of method Api_GuidGetPicLink
    /// </summary>
    public class Api_GuidGetPicLinkApiOut : MpqApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GuidGetPicLinkApiOut);
    }
    /// <summary>
    /// api out of method Api_Reply
    /// </summary>
    public class Api_ReplyApiOut : MpqApiOutput
    {
        public int Result { get; set; }
        public override string TypeCode => nameof(Api_ReplyApiOut);
    }
    /// <summary>
    /// api out of method Api_SendMsg
    /// </summary>
    public class Api_SendMsgApiOut : MpqApiOutput
    {
        public int Result { get; set; }
        public override string TypeCode => nameof(Api_SendMsgApiOut);
    }
    /// <summary>
    /// api out of method Api_Send
    /// </summary>
    public class Api_SendApiOut : MpqApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_SendApiOut);
    }
    /// <summary>
    /// api out of method Api_OutPut
    /// </summary>
    public class Api_OutPutApiOut : MpqApiOutput
    {
        public int Result { get; set; }
        public override string TypeCode => nameof(Api_OutPutApiOut);
    }
    /// <summary>
    /// api out of method Api_IsEnable
    /// </summary>
    public class Api_IsEnableApiOut : MpqApiOutput
    {
        public bool Result { get; set; }
        public override string TypeCode => nameof(Api_IsEnableApiOut);
    }
    /// <summary>
    /// api out of method Api_Login
    /// </summary>
    public class Api_LoginApiOut : MpqApiOutput
    {
        public bool Result { get; set; }
        public override string TypeCode => nameof(Api_LoginApiOut);
    }
    /// <summary>
    /// api out of method Api_Tea加密
    /// </summary>
    public class Api_Tea加密ApiOut : MpqApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_Tea加密ApiOut);
    }
    /// <summary>
    /// api out of method Api_Tea解密
    /// </summary>
    public class Api_Tea解密ApiOut : MpqApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_Tea解密ApiOut);
    }
    /// <summary>
    /// api out of method Api_GetNick
    /// </summary>
    public class Api_GetNickApiOut : MpqApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetNickApiOut);
    }
    /// <summary>
    /// api out of method Api_GetQQLevel
    /// </summary>
    public class Api_GetQQLevelApiOut : MpqApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetQQLevelApiOut);
    }
    /// <summary>
    /// api out of method Api_GNGetGid
    /// </summary>
    public class Api_GNGetGidApiOut : MpqApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GNGetGidApiOut);
    }
    /// <summary>
    /// api out of method Api_GidGetGN
    /// </summary>
    public class Api_GidGetGNApiOut : MpqApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GidGetGNApiOut);
    }
    /// <summary>
    /// api out of method Api_GetVersion
    /// </summary>
    public class Api_GetVersionApiOut : MpqApiOutput
    {
        public int Result { get; set; }
        public override string TypeCode => nameof(Api_GetVersionApiOut);
    }
    /// <summary>
    /// api out of method Api_GetVersionName
    /// </summary>
    public class Api_GetVersionNameApiOut : MpqApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetVersionNameApiOut);
    }
    /// <summary>
    /// api out of method Api_GetTimeStamp
    /// </summary>
    public class Api_GetTimeStampApiOut : MpqApiOutput
    {
        public int Result { get; set; }
        public override string TypeCode => nameof(Api_GetTimeStampApiOut);
    }
    /// <summary>
    /// api out of method Api_GetLog
    /// </summary>
    public class Api_GetLogApiOut : MpqApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetLogApiOut);
    }
    /// <summary>
    /// api out of method Api_IfBlock
    /// </summary>
    public class Api_IfBlockApiOut : MpqApiOutput
    {
        public bool Result { get; set; }
        public override string TypeCode => nameof(Api_IfBlockApiOut);
    }
    /// <summary>
    /// api out of method Api_GetAdminList
    /// </summary>
    public class Api_GetAdminListApiOut : MpqApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetAdminListApiOut);
    }
    /// <summary>
    /// api out of method Api_AddTaotao
    /// </summary>
    public class Api_AddTaotaoApiOut : MpqApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_AddTaotaoApiOut);
    }
    /// <summary>
    /// api out of method Api_GetSign
    /// </summary>
    public class Api_GetSignApiOut : MpqApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetSignApiOut);
    }
    /// <summary>
    /// api out of method Api_SetSign
    /// </summary>
    public class Api_SetSignApiOut : MpqApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_SetSignApiOut);
    }
    /// <summary>
    /// api out of method Api_GetGroupListA
    /// </summary>
    public class Api_GetGroupListAApiOut : MpqApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetGroupListAApiOut);
    }
    /// <summary>
    /// api out of method Api_GetGroupListB
    /// </summary>
    public class Api_GetGroupListBApiOut : MpqApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetGroupListBApiOut);
    }
    /// <summary>
    /// api out of method Api_GetGroupMemberA
    /// </summary>
    public class Api_GetGroupMemberAApiOut : MpqApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetGroupMemberAApiOut);
    }
    /// <summary>
    /// api out of method Api_GetGroupMemberB
    /// </summary>
    public class Api_GetGroupMemberBApiOut : MpqApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetGroupMemberBApiOut);
    }
    /// <summary>
    /// api out of method Api_GetFriendList
    /// </summary>
    public class Api_GetFriendListApiOut : MpqApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetFriendListApiOut);
    }
    /// <summary>
    /// api out of method Api_GetQQAge
    /// </summary>
    public class Api_GetQQAgeApiOut : MpqApiOutput
    {
        public int Result { get; set; }
        public override string TypeCode => nameof(Api_GetQQAgeApiOut);
    }
    /// <summary>
    /// api out of method Api_GetAge
    /// </summary>
    public class Api_GetAgeApiOut : MpqApiOutput
    {
        public int Result { get; set; }
        public override string TypeCode => nameof(Api_GetAgeApiOut);
    }
    /// <summary>
    /// api out of method Api_GetPersonalProfile
    /// </summary>
    public class Api_GetPersonalProfileApiOut : MpqApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetPersonalProfileApiOut);
    }
    /// <summary>
    /// api out of method Api_GetEmail
    /// </summary>
    public class Api_GetEmailApiOut : MpqApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetEmailApiOut);
    }
    /// <summary>
    /// api out of method Api_GetGender
    /// </summary>
    public class Api_GetGenderApiOut : MpqApiOutput
    {
        public int Result { get; set; }
        public override string TypeCode => nameof(Api_GetGenderApiOut);
    }
    /// <summary>
    /// api out of method Api_SendTyping
    /// </summary>
    public class Api_SendTypingApiOut : MpqApiOutput
    {
        public int Result { get; set; }
        public override string TypeCode => nameof(Api_SendTypingApiOut);
    }
    /// <summary>
    /// api out of method Api_SendShake
    /// </summary>
    public class Api_SendShakeApiOut : MpqApiOutput
    {
        public int Result { get; set; }
        public override string TypeCode => nameof(Api_SendShakeApiOut);
    }
    /// <summary>
    /// api out of method Api_GetRadomOnlineQQ
    /// </summary>
    public class Api_GetRadomOnlineQQApiOut : MpqApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetRadomOnlineQQApiOut);
    }
    /// <summary>
    /// api out of method Api_AddQQ
    /// </summary>
    public class Api_AddQQApiOut : MpqApiOutput
    {
        public bool Result { get; set; }
        public override string TypeCode => nameof(Api_AddQQApiOut);
    }
    /// <summary>
    /// api out of method Api_SetOLStatus
    /// </summary>
    public class Api_SetOLStatusApiOut : MpqApiOutput
    {
        public bool Result { get; set; }
        public override string TypeCode => nameof(Api_SetOLStatusApiOut);
    }
    /// <summary>
    /// api out of method Api_GetMC
    /// </summary>
    public class Api_GetMCApiOut : MpqApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetMCApiOut);
    }
    /// <summary>
    /// api out of method Api_GroupInvitation
    /// </summary>
    public class Api_GroupInvitationApiOut : MpqApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GroupInvitationApiOut);
    }
    /// <summary>
    /// api out of method Api_CreateDG
    /// </summary>
    public class Api_CreateDGApiOut : MpqApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_CreateDGApiOut);
    }
    /// <summary>
    /// api out of method Api_KickDG
    /// </summary>
    public class Api_KickDGApiOut : MpqApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_KickDGApiOut);
    }
    /// <summary>
    /// api out of method Api_DGInvitation
    /// </summary>
    public class Api_DGInvitationApiOut : MpqApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_DGInvitationApiOut);
    }
    /// <summary>
    /// api out of method Api_GetDGList
    /// </summary>
    public class Api_GetDGListApiOut : MpqApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetDGListApiOut);
    }
    /// <summary>
    /// api out of method Api_SendMusic
    /// </summary>
    public class Api_SendMusicApiOut : MpqApiOutput
    {
        public bool Result { get; set; }
        public override string TypeCode => nameof(Api_SendMusicApiOut);
    }
    /// <summary>
    /// api out of method Api_SendObjectMsg
    /// </summary>
    public class Api_SendObjectMsgApiOut : MpqApiOutput
    {
        public bool Result { get; set; }
        public override string TypeCode => nameof(Api_SendObjectMsgApiOut);
    }
    /// <summary>
    /// api out of method Api_IsFriend
    /// </summary>
    public class Api_IsFriendApiOut : MpqApiOutput
    {
        public bool Result { get; set; }
        public override string TypeCode => nameof(Api_IsFriendApiOut);
    }
}
