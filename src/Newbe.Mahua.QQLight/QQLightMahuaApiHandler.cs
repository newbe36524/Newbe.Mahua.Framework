using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newbe.Mahua.NativeApi;


// this file is generate from tools, do not change this file
// generate time 2019/12/15 

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
                    _qQLightApi.Api_SendPraise(QQID: data["QQID"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_SendShake":
                    _qQLightApi.Api_SendShake(QQID: data["QQID"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_Getbkn":
                    var Api_GetbknResult =
                    _qQLightApi.Api_Getbkn(Cookies: data["Cookies"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetbknApiOut
                    { Result = Api_GetbknResult });
                case "Api_Getbkn_Long":
                    var Api_Getbkn_LongResult =
                    _qQLightApi.Api_Getbkn_Long(Cookies: data["Cookies"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_Getbkn_LongApiOut
                    { Result = Api_Getbkn_LongResult });
                case "Api_QuitGroup":
                    _qQLightApi.Api_QuitGroup(GroupID: data["GroupID"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_QuitDiscussGroup":
                    _qQLightApi.Api_QuitDiscussGroup(GroupID: data["GroupID"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_SetSignature":
                    _qQLightApi.Api_SetSignature(Signature: data["Signature"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_SetDiscussName":
                    _qQLightApi.Api_SetDiscussName(DiscussGroupID: data["DiscussGroupID"].ToString(), Name: data["Name"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_SetGroupName":
                    _qQLightApi.Api_SetGroupName(GroupID: data["GroupID"].ToString(), Name: data["Name"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_BanGroup":
                    _qQLightApi.Api_BanGroup(GroupID: data["GroupID"].ToString(), IsBanGroup: Convert.ToBoolean(data["IsBanGroup"]), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_SetManager":
                    _qQLightApi.Api_SetManager(GroupID: data["GroupID"].ToString(), QQID: data["QQID"].ToString(), IsManager: Convert.ToBoolean(data["IsManager"]), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_Ban":
                    _qQLightApi.Api_Ban(GroupID: data["GroupID"].ToString(), QQ: data["QQ"].ToString(), time: Convert.ToInt32(data["time"]), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_SetAnony":
                    _qQLightApi.Api_SetAnony(GroupID: data["GroupID"].ToString(), IsSetAnony: Convert.ToBoolean(data["IsSetAnony"]), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_RemoveMember":
                    _qQLightApi.Api_RemoveMember(GroupID: data["GroupID"].ToString(), QQID: data["QQID"].ToString(), IsBan: Convert.ToBoolean(data["IsBan"]), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_RemoveGroup":
                    _qQLightApi.Api_RemoveGroup(GroupID: data["GroupID"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_GetCookies":
                    var Api_GetCookiesResult =
                    _qQLightApi.Api_GetCookies(AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetCookiesApiOut
                    { Result = Api_GetCookiesResult });
                case "Api_GetQzoneToken":
                    var Api_GetQzoneTokenResult =
                    _qQLightApi.Api_GetQzoneToken(AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetQzoneTokenApiOut
                    { Result = Api_GetQzoneTokenResult });
                case "Api_GetQzoneCookies":
                    var Api_GetQzoneCookiesResult =
                    _qQLightApi.Api_GetQzoneCookies(AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetQzoneCookiesApiOut
                    { Result = Api_GetQzoneCookiesResult });
                case "Api_SendTaotao":
                    var Api_SendTaotaoResult =
                    _qQLightApi.Api_SendTaotao(Str: data["Str"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_SendTaotaoApiOut
                    { Result = Api_SendTaotaoResult });
                case "Api_GetLoginQQ":
                    var Api_GetLoginQQResult =
                    _qQLightApi.Api_GetLoginQQ(AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetLoginQQApiOut
                    { Result = Api_GetLoginQQResult });
                case "Api_GetPath":
                    var Api_GetPathResult =
                    _qQLightApi.Api_GetPath(AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetPathApiOut
                    { Result = Api_GetPathResult });
                case "Api_Error":
                    var Api_ErrorResult =
                    _qQLightApi.Api_Error(Code: data["Code"].ToString(), Str: data["Str"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_ErrorApiOut
                    { Result = Api_ErrorResult });
                case "Api_SendMsg":
                    var Api_SendMsgResult =
                    _qQLightApi.Api_SendMsg(Type: Convert.ToInt32(data["Type"]), GroupID: data["GroupID"].ToString(), QQID: data["QQID"].ToString(), Msg: data["Msg"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_SendMsgApiOut
                    { Result = Api_SendMsgResult });
                case "Api_SetGroupAdd":
                    _qQLightApi.Api_SetGroupAdd(GroupID: data["GroupID"].ToString(), QQID: data["QQID"].ToString(), Seq: data["Seq"].ToString(), Type: Convert.ToInt32(data["Type"]), Reason: data["Reason"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_SetFriendAdd":
                    _qQLightApi.Api_SetFriendAdd(QQID: data["QQID"].ToString(), Type: Convert.ToInt32(data["Type"]), Reason: data["Reason"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_SendLog":
                    _qQLightApi.Api_SendLog(Type: data["Type"].ToString(), Msg: data["Msg"].ToString(), FontColor: Convert.ToInt32(data["FontColor"]), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_SetFriendName":
                    _qQLightApi.Api_SetFriendName(QQID: data["QQID"].ToString(), Name: data["Name"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_DeleteFriend":
                    _qQLightApi.Api_DeleteFriend(QQID: data["QQID"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_AddGroup":
                    _qQLightApi.Api_AddGroup(GroupID: data["GroupID"].ToString(), 附加信息: data["附加信息"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_AddFriend":
                    _qQLightApi.Api_AddFriend(QQID: data["QQID"].ToString(), Info: data["Info"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_JsonMusic":
                    var Api_JsonMusicResult =
                    _qQLightApi.Api_JsonMusic(SongID: data["SongID"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_JsonMusicApiOut
                    { Result = Api_JsonMusicResult });
                case "Api_GetGroupCard":
                    var Api_GetGroupCardResult =
                    _qQLightApi.Api_GetGroupCard(GroupID: data["GroupID"].ToString(), QQID: data["QQID"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetGroupCardApiOut
                    { Result = Api_GetGroupCardResult });
                case "Api_GetNick":
                    var Api_GetNickResult =
                    _qQLightApi.Api_GetNick(QQID: data["QQID"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetNickApiOut
                    { Result = Api_GetNickResult });
                case "Api_GetGroupName":
                    var Api_GetGroupNameResult =
                    _qQLightApi.Api_GetGroupName(GroupID: data["GroupID"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetGroupNameApiOut
                    { Result = Api_GetGroupNameResult });
                case "Api_GetSoftVersion":
                    var Api_GetSoftVersionResult =
                    _qQLightApi.Api_GetSoftVersion(AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetSoftVersionApiOut
                    { Result = Api_GetSoftVersionResult });
                case "Api_GetGroupIntroduce":
                    var Api_GetGroupIntroduceResult =
                    _qQLightApi.Api_GetGroupIntroduce(GroupID: data["GroupID"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetGroupIntroduceApiOut
                    { Result = Api_GetGroupIntroduceResult });
                case "Api_GetGroupOwner":
                    var Api_GetGroupOwnerResult =
                    _qQLightApi.Api_GetGroupOwner(GroupID: data["GroupID"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetGroupOwnerApiOut
                    { Result = Api_GetGroupOwnerResult });
                case "Api_SetGroupCard":
                    _qQLightApi.Api_SetGroupCard(GroupID: data["GroupID"].ToString(), QQID: data["QQID"].ToString(), NewCard: data["NewCard"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_GetPraiseNum":
                    var Api_GetPraiseNumResult =
                    _qQLightApi.Api_GetPraiseNum(QQID: data["QQID"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetPraiseNumApiOut
                    { Result = Api_GetPraiseNumResult });
                case "Api_GetQQLevel":
                    var Api_GetQQLevelResult =
                    _qQLightApi.Api_GetQQLevel(QQID: data["QQID"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetQQLevelApiOut
                    { Result = Api_GetQQLevelResult });
                case "Api_SetNick":
                    _qQLightApi.Api_SetNick(NewNick: data["NewNick"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_Taotaodolike":
                    var Api_TaotaodolikeResult =
                    _qQLightApi.Api_Taotaodolike(QQID: data["QQID"].ToString(), URL: data["URL"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_TaotaodolikeApiOut
                    { Result = Api_TaotaodolikeResult });
                case "Api_Taotaofeeds":
                    var Api_TaotaofeedsResult =
                    _qQLightApi.Api_Taotaofeeds(QQID: data["QQID"].ToString(), URL: data["URL"].ToString(), Content: data["Content"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_TaotaofeedsApiOut
                    { Result = Api_TaotaofeedsResult });
                case "Api_GetQQAge":
                    var Api_GetQQAgeResult =
                    _qQLightApi.Api_GetQQAge(QQID: data["QQID"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetQQAgeApiOut
                    { Result = Api_GetQQAgeResult });
                case "Api_GetQQSex":
                    var Api_GetQQSexResult =
                    _qQLightApi.Api_GetQQSex(QQID: data["QQID"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetQQSexApiOut
                    { Result = Api_GetQQSexResult });
                case "Api_GetFriendList":
                    var Api_GetFriendListResult =
                    _qQLightApi.Api_GetFriendList(Cache: Convert.ToBoolean(data["Cache"]), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetFriendListApiOut
                    { Result = Api_GetFriendListResult });
                case "Api_GetGroupList":
                    var Api_GetGroupListResult =
                    _qQLightApi.Api_GetGroupList(Cache: Convert.ToBoolean(data["Cache"]), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetGroupListApiOut
                    { Result = Api_GetGroupListResult });
                case "Api_GetGroupMemberList":
                    var Api_GetGroupMemberListResult =
                    _qQLightApi.Api_GetGroupMemberList(GroupID: data["GroupID"].ToString(), Cache: Convert.ToBoolean(data["Cache"]), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetGroupMemberListApiOut
                    { Result = Api_GetGroupMemberListResult });
                case "Api_GetQQInfo":
                    var Api_GetQQInfoResult =
                    _qQLightApi.Api_GetQQInfo(QQID: data["QQID"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetQQInfoApiOut
                    { Result = Api_GetQQInfoResult });
                case "Api_GetGroupInfo":
                    var Api_GetGroupInfoResult =
                    _qQLightApi.Api_GetGroupInfo(GroupID: data["GroupID"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetGroupInfoApiOut
                    { Result = Api_GetGroupInfoResult });
                case "Api_DeleteMsg":
                    _qQLightApi.Api_DeleteMsg(Type: Convert.ToInt32(data["Type"]), GroupID: data["GroupID"].ToString(), QQID: data["QQID"].ToString(), MsgID: data["MsgID"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_SetQQState":
                    _qQLightApi.Api_SetQQState(Type: Convert.ToInt32(data["Type"]), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_InviteFriend":
                    _qQLightApi.Api_InviteFriend(GroupID: data["GroupID"].ToString(), QQID: data["QQID"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_GetQQInfo_v2":
                    var Api_GetQQInfo_v2Result =
                    _qQLightApi.Api_GetQQInfo_v2(QQID: data["QQID"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetQQInfo_v2ApiOut
                    { Result = Api_GetQQInfo_v2Result });
                case "CoUninitialize":
                    _qQLightApi.CoUninitialize();
                    return Task.CompletedTask;
                case "CoInitialize":
                    _qQLightApi.CoInitialize(pvReserved: Convert.ToInt32(data["pvReserved"]));
                    return Task.CompletedTask;
                case "Api_UpLoadPic":
                    var Api_UpLoadPicResult =
                    _qQLightApi.Api_UpLoadPic(Type: Convert.ToInt32(data["Type"]), 对象: data["对象"].ToString(), Bin: data["Bin"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_UpLoadPicApiOut
                    { Result = Api_UpLoadPicResult });
                case "Api_SetPluginState":
                    var Api_SetPluginStateResult =
                    _qQLightApi.Api_SetPluginState(State: Convert.ToBoolean(data["State"]), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return _mahuaCenter.HandleMahuaOutput(new Api_SetPluginStateApiOut
                    { Result = Api_SetPluginStateResult });
                case "Api_DeleteFile":
                    _qQLightApi.Api_DeleteFile(群号: data["群号"].ToString(), 文件GUID: data["文件GUID"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_RepeatFile":
                    _qQLightApi.Api_RepeatFile(来源对象: data["来源对象"].ToString(), 转发群号: data["转发群号"].ToString(), 文件GUID: data["文件GUID"].ToString(), AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "Api_ClearOffLineFile":
                    _qQLightApi.Api_ClearOffLineFile(AuthCode: _qqLightAuthCodeContainer.AuthCode);
                    return Task.CompletedTask;
                case "WideCharToMultiByte":
                    var WideCharToMultiByteResult =
                    _qQLightApi.WideCharToMultiByte(CodePage: Convert.ToInt32(data["CodePage"]), dwFlags: Convert.ToInt32(data["dwFlags"]), lpWideCharStr: Convert.FromBase64String(data["lpWideCharStr"].ToString()), cchWideChar: Convert.ToInt32(data["cchWideChar"]), lpMultiByteStr: data["lpMultiByteStr"].ToString(), cchMultiByte: Convert.ToInt32(data["cchMultiByte"]), lpDefaultChar: Convert.ToInt32(data["lpDefaultChar"]), lpUsedDefaultChar: Convert.ToInt32(data["lpUsedDefaultChar"]));
                    return _mahuaCenter.HandleMahuaOutput(new WideCharToMultiByteApiOut
                    { Result = WideCharToMultiByteResult });

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
    /// api out of method Api_Getbkn_Long
    /// </summary>
    public class Api_Getbkn_LongApiOut : QQLightApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_Getbkn_LongApiOut);
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
    /// api out of method Api_GetQzoneToken
    /// </summary>
    public class Api_GetQzoneTokenApiOut : QQLightApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetQzoneTokenApiOut);
    }
    /// <summary>
    /// api out of method Api_GetQzoneCookies
    /// </summary>
    public class Api_GetQzoneCookiesApiOut : QQLightApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetQzoneCookiesApiOut);
    }
    /// <summary>
    /// api out of method Api_SendTaotao
    /// </summary>
    public class Api_SendTaotaoApiOut : QQLightApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_SendTaotaoApiOut);
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
    /// api out of method Api_GetPath
    /// </summary>
    public class Api_GetPathApiOut : QQLightApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetPathApiOut);
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
    /// api out of method Api_SendMsg
    /// </summary>
    public class Api_SendMsgApiOut : QQLightApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_SendMsgApiOut);
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
    /// api out of method Api_GetGroupName
    /// </summary>
    public class Api_GetGroupNameApiOut : QQLightApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetGroupNameApiOut);
    }
    /// <summary>
    /// api out of method Api_GetSoftVersion
    /// </summary>
    public class Api_GetSoftVersionApiOut : QQLightApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetSoftVersionApiOut);
    }
    /// <summary>
    /// api out of method Api_GetGroupIntroduce
    /// </summary>
    public class Api_GetGroupIntroduceApiOut : QQLightApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetGroupIntroduceApiOut);
    }
    /// <summary>
    /// api out of method Api_GetGroupOwner
    /// </summary>
    public class Api_GetGroupOwnerApiOut : QQLightApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetGroupOwnerApiOut);
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
    /// api out of method Api_GetQQLevel
    /// </summary>
    public class Api_GetQQLevelApiOut : QQLightApiOutput
    {
        public int Result { get; set; }
        public override string TypeCode => nameof(Api_GetQQLevelApiOut);
    }
    /// <summary>
    /// api out of method Api_Taotaodolike
    /// </summary>
    public class Api_TaotaodolikeApiOut : QQLightApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_TaotaodolikeApiOut);
    }
    /// <summary>
    /// api out of method Api_Taotaofeeds
    /// </summary>
    public class Api_TaotaofeedsApiOut : QQLightApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_TaotaofeedsApiOut);
    }
    /// <summary>
    /// api out of method Api_GetQQAge
    /// </summary>
    public class Api_GetQQAgeApiOut : QQLightApiOutput
    {
        public int Result { get; set; }
        public override string TypeCode => nameof(Api_GetQQAgeApiOut);
    }
    /// <summary>
    /// api out of method Api_GetQQSex
    /// </summary>
    public class Api_GetQQSexApiOut : QQLightApiOutput
    {
        public int Result { get; set; }
        public override string TypeCode => nameof(Api_GetQQSexApiOut);
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
    /// api out of method Api_GetQQInfo_v2
    /// </summary>
    public class Api_GetQQInfo_v2ApiOut : QQLightApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetQQInfo_v2ApiOut);
    }
    /// <summary>
    /// api out of method Api_UpLoadPic
    /// </summary>
    public class Api_UpLoadPicApiOut : QQLightApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_UpLoadPicApiOut);
    }
    /// <summary>
    /// api out of method Api_SetPluginState
    /// </summary>
    public class Api_SetPluginStateApiOut : QQLightApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_SetPluginStateApiOut);
    }
    /// <summary>
    /// api out of method WideCharToMultiByte
    /// </summary>
    public class WideCharToMultiByteApiOut : QQLightApiOutput
    {
        public int Result { get; set; }
        public override string TypeCode => nameof(WideCharToMultiByteApiOut);
    }
}
