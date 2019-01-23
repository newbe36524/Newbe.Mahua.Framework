using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newbe.Mahua.NativeApi;


// this file is generate from tools, do not change this file
// generate time 2019/01/23 

namespace Newbe.Mahua.CleverQQ
{
    public class CleverQQMahuaApiHandler : IPlatformMahuaApiHandler
    {

        private readonly IMahuaCenter _mahuaCenter;
        private readonly ICleverQQApi _cleverQQApi;

        public CleverQQMahuaApiHandler(
            IMahuaCenter mahuaCenter,
            ICleverQQApi cleverQQApi)
        {
            _mahuaCenter = mahuaCenter;
            _cleverQQApi = cleverQQApi;
        }
        public Task Run(string typeCode, IReadOnlyDictionary<string, object> data)
        {
            switch (typeCode)
            {
                case "Api_SendMsg":
                    _cleverQQApi.Api_SendMsg(响应QQ: data["响应QQ"].ToString(), 信息类型: Convert.ToInt32(data["信息类型"]), 收信对象群_讨论组: data["收信对象群_讨论组"].ToString(), 收信QQ: data["收信QQ"].ToString(), 内容: data["内容"].ToString(), 气泡ID: Convert.ToInt32(data["气泡ID"]));
                    return Task.CompletedTask;
                case "Api_SendXML":
                    _cleverQQApi.Api_SendXML(响应QQ: data["响应QQ"].ToString(), 发送方式: Convert.ToInt32(data["发送方式"]), 信息类型: Convert.ToInt32(data["信息类型"]), 收信对象所属群_讨论组: data["收信对象所属群_讨论组"].ToString(), 收信对象QQ: data["收信对象QQ"].ToString(), ObjectMsg: data["ObjectMsg"].ToString(), 结构子类型: Convert.ToInt32(data["结构子类型"]));
                    return Task.CompletedTask;
                case "Api_SendJSON":
                    _cleverQQApi.Api_SendJSON(响应QQ: data["响应QQ"].ToString(), 发送方式: Convert.ToInt32(data["发送方式"]), 信息类型: Convert.ToInt32(data["信息类型"]), 收信对象所属群_讨论组: data["收信对象所属群_讨论组"].ToString(), 收信对象QQ: data["收信对象QQ"].ToString(), Json结构: data["Json结构"].ToString());
                    return Task.CompletedTask;
                case "Api_UpVote":
                    var Api_UpVoteResult =
                    _cleverQQApi.Api_UpVote(响应QQ: data["响应QQ"].ToString(), 被赞QQ: data["被赞QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_UpVoteApiOut
                    { Result = Api_UpVoteResult });
                case "Api_GetCookies":
                    var Api_GetCookiesResult =
                    _cleverQQApi.Api_GetCookies(响应QQ: data["响应QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetCookiesApiOut
                    { Result = Api_GetCookiesResult });
                case "Api_GetBlogPsKey":
                    var Api_GetBlogPsKeyResult =
                    _cleverQQApi.Api_GetBlogPsKey(响应QQ: data["响应QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetBlogPsKeyApiOut
                    { Result = Api_GetBlogPsKeyResult });
                case "Api_GetZonePsKey":
                    var Api_GetZonePsKeyResult =
                    _cleverQQApi.Api_GetZonePsKey(响应QQ: data["响应QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetZonePsKeyApiOut
                    { Result = Api_GetZonePsKeyResult });
                case "Api_GetGroupPsKey":
                    var Api_GetGroupPsKeyResult =
                    _cleverQQApi.Api_GetGroupPsKey(响应QQ: data["响应QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetGroupPsKeyApiOut
                    { Result = Api_GetGroupPsKeyResult });
                case "Api_GetClassRoomPsKey":
                    var Api_GetClassRoomPsKeyResult =
                    _cleverQQApi.Api_GetClassRoomPsKey(响应QQ: data["响应QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetClassRoomPsKeyApiOut
                    { Result = Api_GetClassRoomPsKeyResult });
                case "Api_GetBkn":
                    var Api_GetBknResult =
                    _cleverQQApi.Api_GetBkn(响应QQ: data["响应QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetBknApiOut
                    { Result = Api_GetBknResult });
                case "Api_GetBkn32":
                    var Api_GetBkn32Result =
                    _cleverQQApi.Api_GetBkn32(响应QQ: data["响应QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetBkn32ApiOut
                    { Result = Api_GetBkn32Result });
                case "Api_GetLongLdw":
                    var Api_GetLongLdwResult =
                    _cleverQQApi.Api_GetLongLdw(响应QQ: data["响应QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetLongLdwApiOut
                    { Result = Api_GetLongLdwResult });
                case "Api_GetClientkey":
                    var Api_GetClientkeyResult =
                    _cleverQQApi.Api_GetClientkey(响应QQ: data["响应QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetClientkeyApiOut
                    { Result = Api_GetClientkeyResult });
                case "Api_GetLongClientkey":
                    var Api_GetLongClientkeyResult =
                    _cleverQQApi.Api_GetLongClientkey(响应QQ: data["响应QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetLongClientkeyApiOut
                    { Result = Api_GetLongClientkeyResult });
                case "Api_AdminInviteGroup":
                    _cleverQQApi.Api_AdminInviteGroup(响应QQ: data["响应QQ"].ToString(), 对象QQ: data["对象QQ"].ToString(), 群号: data["群号"].ToString());
                    return Task.CompletedTask;
                case "Api_NoAdminInviteGroup":
                    _cleverQQApi.Api_NoAdminInviteGroup(响应QQ: data["响应QQ"].ToString(), 对象QQ: data["对象QQ"].ToString(), 群号: data["群号"].ToString());
                    return Task.CompletedTask;
                case "Api_GetNick":
                    var Api_GetNickResult =
                    _cleverQQApi.Api_GetNick(响应QQ: data["响应QQ"].ToString(), 对象QQ: data["对象QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetNickApiOut
                    { Result = Api_GetNickResult });
                case "Api_GetGroupCard":
                    var Api_GetGroupCardResult =
                    _cleverQQApi.Api_GetGroupCard(响应QQ: data["响应QQ"].ToString(), 群号: data["群号"].ToString(), 对象QQ: data["对象QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetGroupCardApiOut
                    { Result = Api_GetGroupCardResult });
                case "Api_GetObjLevel":
                    var Api_GetObjLevelResult =
                    _cleverQQApi.Api_GetObjLevel(响应QQ: data["响应QQ"].ToString(), 对象QQ: data["对象QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetObjLevelApiOut
                    { Result = Api_GetObjLevelResult });
                case "Api_GetFriendList":
                    var Api_GetFriendListResult =
                    _cleverQQApi.Api_GetFriendList(响应QQ: data["响应QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetFriendListApiOut
                    { Result = Api_GetFriendListResult });
                case "Api_GetFriendList_B":
                    var Api_GetFriendList_BResult =
                    _cleverQQApi.Api_GetFriendList_B(响应QQ: data["响应QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetFriendList_BApiOut
                    { Result = Api_GetFriendList_BResult });
                case "Api_GetQidianQQFriendsList":
                    var Api_GetQidianQQFriendsListResult =
                    _cleverQQApi.Api_GetQidianQQFriendsList(响应QQ: data["响应QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetQidianQQFriendsListApiOut
                    { Result = Api_GetQidianQQFriendsListResult });
                case "Api_GetGroupAdmin":
                    var Api_GetGroupAdminResult =
                    _cleverQQApi.Api_GetGroupAdmin(响应QQ: data["响应QQ"].ToString(), 群号: data["群号"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetGroupAdminApiOut
                    { Result = Api_GetGroupAdminResult });
                case "Api_GetGroupList_A":
                    var Api_GetGroupList_AResult =
                    _cleverQQApi.Api_GetGroupList_A(响应QQ: data["响应QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetGroupList_AApiOut
                    { Result = Api_GetGroupList_AResult });
                case "Api_GetGroupList":
                    var Api_GetGroupListResult =
                    _cleverQQApi.Api_GetGroupList(响应QQ: data["响应QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetGroupListApiOut
                    { Result = Api_GetGroupListResult });
                case "Api_GetGroupList_B":
                    var Api_GetGroupList_BResult =
                    _cleverQQApi.Api_GetGroupList_B(响应QQ: data["响应QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetGroupList_BApiOut
                    { Result = Api_GetGroupList_BResult });
                case "Api_GetGroupMemberList":
                    var Api_GetGroupMemberListResult =
                    _cleverQQApi.Api_GetGroupMemberList(响应QQ: data["响应QQ"].ToString(), 群号: data["群号"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetGroupMemberListApiOut
                    { Result = Api_GetGroupMemberListResult });
                case "Api_GetGroupMemberList_B":
                    var Api_GetGroupMemberList_BResult =
                    _cleverQQApi.Api_GetGroupMemberList_B(响应QQ: data["响应QQ"].ToString(), 群号: data["群号"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetGroupMemberList_BApiOut
                    { Result = Api_GetGroupMemberList_BResult });
                case "Api_GetGroupMemberList_C":
                    var Api_GetGroupMemberList_CResult =
                    _cleverQQApi.Api_GetGroupMemberList_C(响应QQ: data["响应QQ"].ToString(), 群号: data["群号"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetGroupMemberList_CApiOut
                    { Result = Api_GetGroupMemberList_CResult });
                case "Api_IsShutUp":
                    var Api_IsShutUpResult =
                    _cleverQQApi.Api_IsShutUp(响应QQ: data["响应QQ"].ToString(), 群号: data["群号"].ToString(), 对象QQ: data["对象QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_IsShutUpApiOut
                    { Result = Api_IsShutUpResult });
                case "Api_ShutUP":
                    _cleverQQApi.Api_ShutUP(响应QQ: data["响应QQ"].ToString(), 群号: data["群号"].ToString(), 对象QQ: data["对象QQ"].ToString(), 时间: Convert.ToInt32(data["时间"]));
                    return Task.CompletedTask;
                case "Api_JoinGroup":
                    _cleverQQApi.Api_JoinGroup(响应QQ: data["响应QQ"].ToString(), 群号: data["群号"].ToString(), 理由: data["理由"].ToString());
                    return Task.CompletedTask;
                case "Api_QuitGroup":
                    _cleverQQApi.Api_QuitGroup(响应QQ: data["响应QQ"].ToString(), 群号: data["群号"].ToString());
                    return Task.CompletedTask;
                case "Api_UpLoadPic":
                    var Api_UpLoadPicResult =
                    _cleverQQApi.Api_UpLoadPic(响应QQ: data["响应QQ"].ToString(), 上传类型: Convert.ToInt32(data["上传类型"]), 参考对象: data["参考对象"].ToString(), 图片数据: Convert.FromBase64String(data["图片数据"].ToString()));
                    return _mahuaCenter.HandleMahuaOutput(new Api_UpLoadPicApiOut
                    { Result = Api_UpLoadPicResult });
                case "Api_GetPicLink":
                    var Api_GetPicLinkResult =
                    _cleverQQApi.Api_GetPicLink(响应QQ: data["响应QQ"].ToString(), 图片类型: Convert.ToInt32(data["图片类型"]), 参考对象: data["参考对象"].ToString(), 图片GUID: data["图片GUID"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetPicLinkApiOut
                    { Result = Api_GetPicLinkResult });
                case "Api_OutPutLog":
                    _cleverQQApi.Api_OutPutLog(内容: data["内容"].ToString());
                    return Task.CompletedTask;
                case "Api_Tea加密":
                    var Api_Tea加密Result =
                    _cleverQQApi.Api_Tea加密(需加密内容: data["需加密内容"].ToString(), 会话KEY: data["会话KEY"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_Tea加密ApiOut
                    { Result = Api_Tea加密Result });
                case "Api_Tea解密":
                    var Api_Tea解密Result =
                    _cleverQQApi.Api_Tea解密(需解密内容: data["需解密内容"].ToString(), 会话KEY: data["会话KEY"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_Tea解密ApiOut
                    { Result = Api_Tea解密Result });
                case "Api_SessionKey":
                    var Api_SessionKeyResult =
                    _cleverQQApi.Api_SessionKey(响应QQ: data["响应QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_SessionKeyApiOut
                    { Result = Api_SessionKeyResult });
                case "Api_GNTransGID":
                    var Api_GNTransGIDResult =
                    _cleverQQApi.Api_GNTransGID(群号: data["群号"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GNTransGIDApiOut
                    { Result = Api_GNTransGIDResult });
                case "Api_GIDTransGN":
                    var Api_GIDTransGNResult =
                    _cleverQQApi.Api_GIDTransGN(群ID: data["群ID"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GIDTransGNApiOut
                    { Result = Api_GIDTransGNResult });
                case "Api_PBGroupNotic":
                    var Api_PBGroupNoticResult =
                    _cleverQQApi.Api_PBGroupNotic(响应QQ: data["响应QQ"].ToString(), 群号: data["群号"].ToString(), 标题: data["标题"].ToString(), 内容: data["内容"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_PBGroupNoticApiOut
                    { Result = Api_PBGroupNoticResult });
                case "Api_GetNotice":
                    var Api_GetNoticeResult =
                    _cleverQQApi.Api_GetNotice(响应QQ: data["响应QQ"].ToString(), 群号: data["群号"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetNoticeApiOut
                    { Result = Api_GetNoticeResult });
                case "Api_ShakeWindow":
                    var Api_ShakeWindowResult =
                    _cleverQQApi.Api_ShakeWindow(响应QQ: data["响应QQ"].ToString(), 接收QQ: data["接收QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_ShakeWindowApiOut
                    { Result = Api_ShakeWindowResult });
                case "Api_HandleEvent":
                    _cleverQQApi.Api_HandleEvent(响应QQ: data["响应QQ"].ToString(), 请求类型: Convert.ToInt32(data["请求类型"]), 对象QQ: data["对象QQ"].ToString(), 群号: data["群号"].ToString(), 处理方式: Convert.ToInt32(data["处理方式"]), 附加信息: data["附加信息"].ToString());
                    return Task.CompletedTask;
                case "Api_HandleGroupEvent":
                    _cleverQQApi.Api_HandleGroupEvent(响应QQ: data["响应QQ"].ToString(), 请求类型: Convert.ToInt32(data["请求类型"]), 对象QQ: data["对象QQ"].ToString(), 群号: data["群号"].ToString(), seq: data["seq"].ToString(), 处理方式: Convert.ToInt32(data["处理方式"]), 附加信息: data["附加信息"].ToString());
                    return Task.CompletedTask;
                case "Api_SetAnon":
                    var Api_SetAnonResult =
                    _cleverQQApi.Api_SetAnon(响应QQ: data["响应QQ"].ToString(), 群号: data["群号"].ToString(), 开关: Convert.ToBoolean(data["开关"]));
                    return _mahuaCenter.HandleMahuaOutput(new Api_SetAnonApiOut
                    { Result = Api_SetAnonResult });
                case "Api_SetGroupCard":
                    var Api_SetGroupCardResult =
                    _cleverQQApi.Api_SetGroupCard(响应QQ: data["响应QQ"].ToString(), 群号: data["群号"].ToString(), 对象QQ: data["对象QQ"].ToString(), 名片: data["名片"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_SetGroupCardApiOut
                    { Result = Api_SetGroupCardResult });
                case "Api_QuitDisGroup":
                    _cleverQQApi.Api_QuitDisGroup(响应QQ: data["响应QQ"].ToString(), 讨论组ID: data["讨论组ID"].ToString());
                    return Task.CompletedTask;
                case "Api_CreateDisGroup":
                    var Api_CreateDisGroupResult =
                    _cleverQQApi.Api_CreateDisGroup(响应QQ: data["响应QQ"].ToString(), 讨论组名称: data["讨论组名称"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_CreateDisGroupApiOut
                    { Result = Api_CreateDisGroupResult });
                case "Api_KickDisGroupMBR":
                    var Api_KickDisGroupMBRResult =
                    _cleverQQApi.Api_KickDisGroupMBR(响应QQ: data["响应QQ"].ToString(), 讨论组ID: data["讨论组ID"].ToString(), 对象QQ: data["对象QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_KickDisGroupMBRApiOut
                    { Result = Api_KickDisGroupMBRResult });
                case "Api_InviteDisGroup":
                    var Api_InviteDisGroupResult =
                    _cleverQQApi.Api_InviteDisGroup(响应QQ: data["响应QQ"].ToString(), 讨论组ID: data["讨论组ID"].ToString(), 邀请对象QQ: data["邀请对象QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_InviteDisGroupApiOut
                    { Result = Api_InviteDisGroupResult });
                case "Api_GetDisGroupList":
                    var Api_GetDisGroupListResult =
                    _cleverQQApi.Api_GetDisGroupList(响应QQ: data["响应QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetDisGroupListApiOut
                    { Result = Api_GetDisGroupListResult });
                case "Api_GetDisGroupMemberList":
                    var Api_GetDisGroupMemberListResult =
                    _cleverQQApi.Api_GetDisGroupMemberList(响应QQ: data["响应QQ"].ToString(), 讨论组ID: data["讨论组ID"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetDisGroupMemberListApiOut
                    { Result = Api_GetDisGroupMemberListResult });
                case "Api_SetDisGroupName":
                    _cleverQQApi.Api_SetDisGroupName(响应QQ: data["响应QQ"].ToString(), 讨论组ID: data["讨论组ID"].ToString(), 讨论组名称: data["讨论组名称"].ToString());
                    return Task.CompletedTask;
                case "Api_KickGroupMBR":
                    _cleverQQApi.Api_KickGroupMBR(响应QQ: data["响应QQ"].ToString(), 群号: data["群号"].ToString(), 对象QQ: data["对象QQ"].ToString(), 不再接收加群请求: Convert.ToBoolean(data["不再接收加群请求"]));
                    return Task.CompletedTask;
                case "Api_GetObjVote":
                    var Api_GetObjVoteResult =
                    _cleverQQApi.Api_GetObjVote(响应QQ: data["响应QQ"].ToString(), 对象QQ: data["对象QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetObjVoteApiOut
                    { Result = Api_GetObjVoteResult });
                case "Api_UpLoadVoice":
                    var Api_UpLoadVoiceResult =
                    _cleverQQApi.Api_UpLoadVoice(响应QQ: data["响应QQ"].ToString(), 上传类型: Convert.ToInt32(data["上传类型"]), 接收群号: data["接收群号"].ToString(), 语音数据: Convert.FromBase64String(data["语音数据"].ToString()));
                    return _mahuaCenter.HandleMahuaOutput(new Api_UpLoadVoiceApiOut
                    { Result = Api_UpLoadVoiceResult });
                case "Api_GetVoiLink":
                    var Api_GetVoiLinkResult =
                    _cleverQQApi.Api_GetVoiLink(响应QQ: data["响应QQ"].ToString(), 语音GUID: data["语音GUID"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetVoiLinkApiOut
                    { Result = Api_GetVoiLinkResult });
                case "Api_GetTimeStamp":
                    var Api_GetTimeStampResult =
                    _cleverQQApi.Api_GetTimeStamp();
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetTimeStampApiOut
                    { Result = Api_GetTimeStampResult });
                case "Api_SendPack":
                    var Api_SendPackResult =
                    _cleverQQApi.Api_SendPack(响应QQ: data["响应QQ"].ToString(), 封包: data["封包"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_SendPackApiOut
                    { Result = Api_SendPackResult });
                case "Api_GetObjInfo":
                    var Api_GetObjInfoResult =
                    _cleverQQApi.Api_GetObjInfo(响应QQ: data["响应QQ"].ToString(), 对象QQ: data["对象QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetObjInfoApiOut
                    { Result = Api_GetObjInfoResult });
                case "Api_GetGender":
                    var Api_GetGenderResult =
                    _cleverQQApi.Api_GetGender(响应QQ: data["响应QQ"].ToString(), 对象QQ: data["对象QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetGenderApiOut
                    { Result = Api_GetGenderResult });
                case "Api_GetQQAge":
                    var Api_GetQQAgeResult =
                    _cleverQQApi.Api_GetQQAge(响应QQ: data["响应QQ"].ToString(), 对象QQ: data["对象QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetQQAgeApiOut
                    { Result = Api_GetQQAgeResult });
                case "Api_GetAge":
                    var Api_GetAgeResult =
                    _cleverQQApi.Api_GetAge(响应QQ: data["响应QQ"].ToString(), 对象QQ: data["对象QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetAgeApiOut
                    { Result = Api_GetAgeResult });
                case "Api_GetPerExp":
                    var Api_GetPerExpResult =
                    _cleverQQApi.Api_GetPerExp(响应QQ: data["响应QQ"].ToString(), 对象QQ: data["对象QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetPerExpApiOut
                    { Result = Api_GetPerExpResult });
                case "Api_GetSign":
                    var Api_GetSignResult =
                    _cleverQQApi.Api_GetSign(响应QQ: data["响应QQ"].ToString(), 对象QQ: data["对象QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetSignApiOut
                    { Result = Api_GetSignResult });
                case "Api_GetEmail":
                    var Api_GetEmailResult =
                    _cleverQQApi.Api_GetEmail(响应QQ: data["响应QQ"].ToString(), 对象QQ: data["对象QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetEmailApiOut
                    { Result = Api_GetEmailResult });
                case "Api_GetGroupName":
                    var Api_GetGroupNameResult =
                    _cleverQQApi.Api_GetGroupName(响应QQ: data["响应QQ"].ToString(), 群号: data["群号"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetGroupNameApiOut
                    { Result = Api_GetGroupNameResult });
                case "Api_GetVer":
                    var Api_GetVerResult =
                    _cleverQQApi.Api_GetVer();
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetVerApiOut
                    { Result = Api_GetVerResult });
                case "Api_GetQQList":
                    var Api_GetQQListResult =
                    _cleverQQApi.Api_GetQQList();
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetQQListApiOut
                    { Result = Api_GetQQListResult });
                case "Api_GetOnLineList":
                    var Api_GetOnLineListResult =
                    _cleverQQApi.Api_GetOnLineList();
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetOnLineListApiOut
                    { Result = Api_GetOnLineListResult });
                case "Api_GetOffLineList":
                    var Api_GetOffLineListResult =
                    _cleverQQApi.Api_GetOffLineList();
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetOffLineListApiOut
                    { Result = Api_GetOffLineListResult });
                case "Api_AddQQ":
                    var Api_AddQQResult =
                    _cleverQQApi.Api_AddQQ(帐号: data["帐号"].ToString(), 密码: data["密码"].ToString(), 自动登录: Convert.ToBoolean(data["自动登录"]));
                    return _mahuaCenter.HandleMahuaOutput(new Api_AddQQApiOut
                    { Result = Api_AddQQResult });
                case "Api_DelQQ":
                    var Api_DelQQResult =
                    _cleverQQApi.Api_DelQQ(QQ号: data["QQ号"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_DelQQApiOut
                    { Result = Api_DelQQResult });
                case "Api_LoginQQ":
                    _cleverQQApi.Api_LoginQQ(登录QQ: data["登录QQ"].ToString());
                    return Task.CompletedTask;
                case "Api_OffLineQQ":
                    _cleverQQApi.Api_OffLineQQ(响应QQ: data["响应QQ"].ToString());
                    return Task.CompletedTask;
                case "Api_IfFriend":
                    var Api_IfFriendResult =
                    _cleverQQApi.Api_IfFriend(响应QQ: data["响应QQ"].ToString(), 对象QQ: data["对象QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_IfFriendApiOut
                    { Result = Api_IfFriendResult });
                case "Api_SetRInf":
                    _cleverQQApi.Api_SetRInf(响应QQ: data["响应QQ"].ToString(), 类型: Convert.ToInt32(data["类型"]), 修改内容: data["修改内容"].ToString());
                    return Task.CompletedTask;
                case "Api_GetRInf":
                    var Api_GetRInfResult =
                    _cleverQQApi.Api_GetRInf(响应QQ: data["响应QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetRInfApiOut
                    { Result = Api_GetRInfResult });
                case "Api_DelFriend":
                    var Api_DelFriendResult =
                    _cleverQQApi.Api_DelFriend(响应QQ: data["响应QQ"].ToString(), 对象QQ: data["对象QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_DelFriendApiOut
                    { Result = Api_DelFriendResult });
                case "Api_AddBkList":
                    var Api_AddBkListResult =
                    _cleverQQApi.Api_AddBkList(响应QQ: data["响应QQ"].ToString(), 对象QQ: data["对象QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_AddBkListApiOut
                    { Result = Api_AddBkListResult });
                case "Api_DelBkList":
                    _cleverQQApi.Api_DelBkList(响应QQ: data["响应QQ"].ToString(), 对象QQ: data["对象QQ"].ToString());
                    return Task.CompletedTask;
                case "Api_SetShieldedGroup":
                    _cleverQQApi.Api_SetShieldedGroup(响应QQ: data["响应QQ"].ToString(), 群号: data["群号"].ToString(), 类型: Convert.ToBoolean(data["类型"]));
                    return Task.CompletedTask;
                case "Api_SendVoice":
                    var Api_SendVoiceResult =
                    _cleverQQApi.Api_SendVoice(响应QQ: data["响应QQ"].ToString(), 接收QQ: data["接收QQ"].ToString(), 语音数据: Convert.FromBase64String(data["语音数据"].ToString()));
                    return _mahuaCenter.HandleMahuaOutput(new Api_SendVoiceApiOut
                    { Result = Api_SendVoiceResult });
                case "Api_SetAdmin":
                    var Api_SetAdminResult =
                    _cleverQQApi.Api_SetAdmin(响应QQ: data["响应QQ"].ToString(), 群号: data["群号"].ToString(), 对象QQ: data["对象QQ"].ToString(), 操作方式: Convert.ToBoolean(data["操作方式"]));
                    return _mahuaCenter.HandleMahuaOutput(new Api_SetAdminApiOut
                    { Result = Api_SetAdminResult });
                case "Api_PBHomeWork":
                    _cleverQQApi.Api_PBHomeWork(响应QQ: data["响应QQ"].ToString(), 群号: data["群号"].ToString(), 作业名: data["作业名"].ToString(), 标题: data["标题"].ToString(), 内容: data["内容"].ToString());
                    return Task.CompletedTask;
                case "Api_GetLog":
                    var Api_GetLogResult =
                    _cleverQQApi.Api_GetLog();
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetLogApiOut
                    { Result = Api_GetLogResult });
                case "Api_IsEnable":
                    var Api_IsEnableResult =
                    _cleverQQApi.Api_IsEnable();
                    return _mahuaCenter.HandleMahuaOutput(new Api_IsEnableApiOut
                    { Result = Api_IsEnableResult });
                case "Api_DisabledPlugin":
                    _cleverQQApi.Api_DisabledPlugin();
                    return Task.CompletedTask;
                case "Api_WithdrawMsg":
                    var Api_WithdrawMsgResult =
                    _cleverQQApi.Api_WithdrawMsg(响应QQ: data["响应QQ"].ToString(), 群号: data["群号"].ToString(), 消息序号: data["消息序号"].ToString(), 消息ID: data["消息ID"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_WithdrawMsgApiOut
                    { Result = Api_WithdrawMsgResult });
                case "Api_BeInput":
                    _cleverQQApi.Api_BeInput(响应QQ: data["响应QQ"].ToString(), 对象QQ: data["对象QQ"].ToString());
                    return Task.CompletedTask;
                case "Api_GetQQAddMode":
                    var Api_GetQQAddModeResult =
                    _cleverQQApi.Api_GetQQAddMode(响应QQ: data["响应QQ"].ToString(), 对象QQ: data["对象QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetQQAddModeApiOut
                    { Result = Api_GetQQAddModeResult });
                case "Api_IsOnline":
                    var Api_IsOnlineResult =
                    _cleverQQApi.Api_IsOnline(响应QQ: data["响应QQ"].ToString(), 对象QQ: data["对象QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_IsOnlineApiOut
                    { Result = Api_IsOnlineResult });
                case "Api_GetOnlineState":
                    var Api_GetOnlineStateResult =
                    _cleverQQApi.Api_GetOnlineState(响应QQ: data["响应QQ"].ToString(), 对象QQ: data["对象QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetOnlineStateApiOut
                    { Result = Api_GetOnlineStateResult });
                case "Api_GetGroupMemberNum":
                    var Api_GetGroupMemberNumResult =
                    _cleverQQApi.Api_GetGroupMemberNum(响应QQ: data["响应QQ"].ToString(), 群号: data["群号"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetGroupMemberNumApiOut
                    { Result = Api_GetGroupMemberNumResult });
                case "Api_GetWpa":
                    var Api_GetWpaResult =
                    _cleverQQApi.Api_GetWpa(响应QQ: data["响应QQ"].ToString(), 对象QQ: data["对象QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetWpaApiOut
                    { Result = Api_GetWpaResult });
                case "Api_GetGroupAddMode":
                    var Api_GetGroupAddModeResult =
                    _cleverQQApi.Api_GetGroupAddMode(响应QQ: data["响应QQ"].ToString(), 群号: data["群号"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetGroupAddModeApiOut
                    { Result = Api_GetGroupAddModeResult });
                case "Api_GetGroupLv":
                    var Api_GetGroupLvResult =
                    _cleverQQApi.Api_GetGroupLv(响应QQ: data["响应QQ"].ToString(), 群号: data["群号"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetGroupLvApiOut
                    { Result = Api_GetGroupLvResult });
                case "Api_SetFriendsRemark":
                    _cleverQQApi.Api_SetFriendsRemark(响应QQ: data["响应QQ"].ToString(), 对象QQ: data["对象QQ"].ToString(), 备注: data["备注"].ToString());
                    return Task.CompletedTask;
                case "Api_GetFriendsRemark":
                    var Api_GetFriendsRemarkResult =
                    _cleverQQApi.Api_GetFriendsRemark(响应QQ: data["响应QQ"].ToString(), 对象QQ: data["对象QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetFriendsRemarkApiOut
                    { Result = Api_GetFriendsRemarkResult });
                case "Api_SignIn":
                    var Api_SignInResult =
                    _cleverQQApi.Api_SignIn(响应QQ: data["响应QQ"].ToString(), 群号: data["群号"].ToString(), 地名: data["地名"].ToString(), 想说的话: data["想说的话"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_SignInApiOut
                    { Result = Api_SignInResult });
                case "Api_TakeGift":
                    var Api_TakeGiftResult =
                    _cleverQQApi.Api_TakeGift(响应QQ: data["响应QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_TakeGiftApiOut
                    { Result = Api_TakeGiftResult });
                case "Api_CheckGift":
                    var Api_CheckGiftResult =
                    _cleverQQApi.Api_CheckGift(响应QQ: data["响应QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_CheckGiftApiOut
                    { Result = Api_CheckGiftResult });
                case "Api_GiveGift":
                    var Api_GiveGiftResult =
                    _cleverQQApi.Api_GiveGift(响应QQ: data["响应QQ"].ToString(), 群号: data["群号"].ToString(), 对象QQ: data["对象QQ"].ToString(), pid: data["pid"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GiveGiftApiOut
                    { Result = Api_GiveGiftResult });
                case "Api_GetGroupChatLv":
                    var Api_GetGroupChatLvResult =
                    _cleverQQApi.Api_GetGroupChatLv(响应QQ: data["响应QQ"].ToString(), 群号: data["群号"].ToString(), 对象QQ: data["对象QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetGroupChatLvApiOut
                    { Result = Api_GetGroupChatLvResult });
                case "Api_GetExpertDays":
                    var Api_GetExpertDaysResult =
                    _cleverQQApi.Api_GetExpertDays(响应QQ: data["响应QQ"].ToString(), 对象QQ: data["对象QQ"].ToString());
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetExpertDaysApiOut
                    { Result = Api_GetExpertDaysResult });
                case "Api_GetShieldedState":
                    var Api_GetShieldedStateResult =
                    _cleverQQApi.Api_GetShieldedState(响应QQ: data["响应QQ"].ToString(), 消息类型: Convert.ToInt32(data["消息类型"]));
                    return _mahuaCenter.HandleMahuaOutput(new Api_GetShieldedStateApiOut
                    { Result = Api_GetShieldedStateResult });

                default:
                    throw new ArgumentOutOfRangeException(nameof(typeCode));
            }
        }
    }
    /// <summary>
    /// api out of method Api_UpVote
    /// </summary>
    public class Api_UpVoteApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_UpVoteApiOut);
    }
    /// <summary>
    /// api out of method Api_GetCookies
    /// </summary>
    public class Api_GetCookiesApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetCookiesApiOut);
    }
    /// <summary>
    /// api out of method Api_GetBlogPsKey
    /// </summary>
    public class Api_GetBlogPsKeyApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetBlogPsKeyApiOut);
    }
    /// <summary>
    /// api out of method Api_GetZonePsKey
    /// </summary>
    public class Api_GetZonePsKeyApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetZonePsKeyApiOut);
    }
    /// <summary>
    /// api out of method Api_GetGroupPsKey
    /// </summary>
    public class Api_GetGroupPsKeyApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetGroupPsKeyApiOut);
    }
    /// <summary>
    /// api out of method Api_GetClassRoomPsKey
    /// </summary>
    public class Api_GetClassRoomPsKeyApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetClassRoomPsKeyApiOut);
    }
    /// <summary>
    /// api out of method Api_GetBkn
    /// </summary>
    public class Api_GetBknApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetBknApiOut);
    }
    /// <summary>
    /// api out of method Api_GetBkn32
    /// </summary>
    public class Api_GetBkn32ApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetBkn32ApiOut);
    }
    /// <summary>
    /// api out of method Api_GetLongLdw
    /// </summary>
    public class Api_GetLongLdwApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetLongLdwApiOut);
    }
    /// <summary>
    /// api out of method Api_GetClientkey
    /// </summary>
    public class Api_GetClientkeyApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetClientkeyApiOut);
    }
    /// <summary>
    /// api out of method Api_GetLongClientkey
    /// </summary>
    public class Api_GetLongClientkeyApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetLongClientkeyApiOut);
    }
    /// <summary>
    /// api out of method Api_GetNick
    /// </summary>
    public class Api_GetNickApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetNickApiOut);
    }
    /// <summary>
    /// api out of method Api_GetGroupCard
    /// </summary>
    public class Api_GetGroupCardApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetGroupCardApiOut);
    }
    /// <summary>
    /// api out of method Api_GetObjLevel
    /// </summary>
    public class Api_GetObjLevelApiOut : CleverQQApiOutput
    {
        public int Result { get; set; }
        public override string TypeCode => nameof(Api_GetObjLevelApiOut);
    }
    /// <summary>
    /// api out of method Api_GetFriendList
    /// </summary>
    public class Api_GetFriendListApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetFriendListApiOut);
    }
    /// <summary>
    /// api out of method Api_GetFriendList_B
    /// </summary>
    public class Api_GetFriendList_BApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetFriendList_BApiOut);
    }
    /// <summary>
    /// api out of method Api_GetQidianQQFriendsList
    /// </summary>
    public class Api_GetQidianQQFriendsListApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetQidianQQFriendsListApiOut);
    }
    /// <summary>
    /// api out of method Api_GetGroupAdmin
    /// </summary>
    public class Api_GetGroupAdminApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetGroupAdminApiOut);
    }
    /// <summary>
    /// api out of method Api_GetGroupList_A
    /// </summary>
    public class Api_GetGroupList_AApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetGroupList_AApiOut);
    }
    /// <summary>
    /// api out of method Api_GetGroupList
    /// </summary>
    public class Api_GetGroupListApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetGroupListApiOut);
    }
    /// <summary>
    /// api out of method Api_GetGroupList_B
    /// </summary>
    public class Api_GetGroupList_BApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetGroupList_BApiOut);
    }
    /// <summary>
    /// api out of method Api_GetGroupMemberList
    /// </summary>
    public class Api_GetGroupMemberListApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetGroupMemberListApiOut);
    }
    /// <summary>
    /// api out of method Api_GetGroupMemberList_B
    /// </summary>
    public class Api_GetGroupMemberList_BApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetGroupMemberList_BApiOut);
    }
    /// <summary>
    /// api out of method Api_GetGroupMemberList_C
    /// </summary>
    public class Api_GetGroupMemberList_CApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetGroupMemberList_CApiOut);
    }
    /// <summary>
    /// api out of method Api_IsShutUp
    /// </summary>
    public class Api_IsShutUpApiOut : CleverQQApiOutput
    {
        public bool Result { get; set; }
        public override string TypeCode => nameof(Api_IsShutUpApiOut);
    }
    /// <summary>
    /// api out of method Api_UpLoadPic
    /// </summary>
    public class Api_UpLoadPicApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_UpLoadPicApiOut);
    }
    /// <summary>
    /// api out of method Api_GetPicLink
    /// </summary>
    public class Api_GetPicLinkApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetPicLinkApiOut);
    }
    /// <summary>
    /// api out of method Api_Tea加密
    /// </summary>
    public class Api_Tea加密ApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_Tea加密ApiOut);
    }
    /// <summary>
    /// api out of method Api_Tea解密
    /// </summary>
    public class Api_Tea解密ApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_Tea解密ApiOut);
    }
    /// <summary>
    /// api out of method Api_SessionKey
    /// </summary>
    public class Api_SessionKeyApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_SessionKeyApiOut);
    }
    /// <summary>
    /// api out of method Api_GNTransGID
    /// </summary>
    public class Api_GNTransGIDApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GNTransGIDApiOut);
    }
    /// <summary>
    /// api out of method Api_GIDTransGN
    /// </summary>
    public class Api_GIDTransGNApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GIDTransGNApiOut);
    }
    /// <summary>
    /// api out of method Api_PBGroupNotic
    /// </summary>
    public class Api_PBGroupNoticApiOut : CleverQQApiOutput
    {
        public bool Result { get; set; }
        public override string TypeCode => nameof(Api_PBGroupNoticApiOut);
    }
    /// <summary>
    /// api out of method Api_GetNotice
    /// </summary>
    public class Api_GetNoticeApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetNoticeApiOut);
    }
    /// <summary>
    /// api out of method Api_ShakeWindow
    /// </summary>
    public class Api_ShakeWindowApiOut : CleverQQApiOutput
    {
        public bool Result { get; set; }
        public override string TypeCode => nameof(Api_ShakeWindowApiOut);
    }
    /// <summary>
    /// api out of method Api_SetAnon
    /// </summary>
    public class Api_SetAnonApiOut : CleverQQApiOutput
    {
        public bool Result { get; set; }
        public override string TypeCode => nameof(Api_SetAnonApiOut);
    }
    /// <summary>
    /// api out of method Api_SetGroupCard
    /// </summary>
    public class Api_SetGroupCardApiOut : CleverQQApiOutput
    {
        public bool Result { get; set; }
        public override string TypeCode => nameof(Api_SetGroupCardApiOut);
    }
    /// <summary>
    /// api out of method Api_CreateDisGroup
    /// </summary>
    public class Api_CreateDisGroupApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_CreateDisGroupApiOut);
    }
    /// <summary>
    /// api out of method Api_KickDisGroupMBR
    /// </summary>
    public class Api_KickDisGroupMBRApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_KickDisGroupMBRApiOut);
    }
    /// <summary>
    /// api out of method Api_InviteDisGroup
    /// </summary>
    public class Api_InviteDisGroupApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_InviteDisGroupApiOut);
    }
    /// <summary>
    /// api out of method Api_GetDisGroupList
    /// </summary>
    public class Api_GetDisGroupListApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetDisGroupListApiOut);
    }
    /// <summary>
    /// api out of method Api_GetDisGroupMemberList
    /// </summary>
    public class Api_GetDisGroupMemberListApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetDisGroupMemberListApiOut);
    }
    /// <summary>
    /// api out of method Api_GetObjVote
    /// </summary>
    public class Api_GetObjVoteApiOut : CleverQQApiOutput
    {
        public long Result { get; set; }
        public override string TypeCode => nameof(Api_GetObjVoteApiOut);
    }
    /// <summary>
    /// api out of method Api_UpLoadVoice
    /// </summary>
    public class Api_UpLoadVoiceApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_UpLoadVoiceApiOut);
    }
    /// <summary>
    /// api out of method Api_GetVoiLink
    /// </summary>
    public class Api_GetVoiLinkApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetVoiLinkApiOut);
    }
    /// <summary>
    /// api out of method Api_GetTimeStamp
    /// </summary>
    public class Api_GetTimeStampApiOut : CleverQQApiOutput
    {
        public long Result { get; set; }
        public override string TypeCode => nameof(Api_GetTimeStampApiOut);
    }
    /// <summary>
    /// api out of method Api_SendPack
    /// </summary>
    public class Api_SendPackApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_SendPackApiOut);
    }
    /// <summary>
    /// api out of method Api_GetObjInfo
    /// </summary>
    public class Api_GetObjInfoApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetObjInfoApiOut);
    }
    /// <summary>
    /// api out of method Api_GetGender
    /// </summary>
    public class Api_GetGenderApiOut : CleverQQApiOutput
    {
        public int Result { get; set; }
        public override string TypeCode => nameof(Api_GetGenderApiOut);
    }
    /// <summary>
    /// api out of method Api_GetQQAge
    /// </summary>
    public class Api_GetQQAgeApiOut : CleverQQApiOutput
    {
        public int Result { get; set; }
        public override string TypeCode => nameof(Api_GetQQAgeApiOut);
    }
    /// <summary>
    /// api out of method Api_GetAge
    /// </summary>
    public class Api_GetAgeApiOut : CleverQQApiOutput
    {
        public int Result { get; set; }
        public override string TypeCode => nameof(Api_GetAgeApiOut);
    }
    /// <summary>
    /// api out of method Api_GetPerExp
    /// </summary>
    public class Api_GetPerExpApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetPerExpApiOut);
    }
    /// <summary>
    /// api out of method Api_GetSign
    /// </summary>
    public class Api_GetSignApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetSignApiOut);
    }
    /// <summary>
    /// api out of method Api_GetEmail
    /// </summary>
    public class Api_GetEmailApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetEmailApiOut);
    }
    /// <summary>
    /// api out of method Api_GetGroupName
    /// </summary>
    public class Api_GetGroupNameApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetGroupNameApiOut);
    }
    /// <summary>
    /// api out of method Api_GetVer
    /// </summary>
    public class Api_GetVerApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetVerApiOut);
    }
    /// <summary>
    /// api out of method Api_GetQQList
    /// </summary>
    public class Api_GetQQListApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetQQListApiOut);
    }
    /// <summary>
    /// api out of method Api_GetOnLineList
    /// </summary>
    public class Api_GetOnLineListApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetOnLineListApiOut);
    }
    /// <summary>
    /// api out of method Api_GetOffLineList
    /// </summary>
    public class Api_GetOffLineListApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetOffLineListApiOut);
    }
    /// <summary>
    /// api out of method Api_AddQQ
    /// </summary>
    public class Api_AddQQApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_AddQQApiOut);
    }
    /// <summary>
    /// api out of method Api_DelQQ
    /// </summary>
    public class Api_DelQQApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_DelQQApiOut);
    }
    /// <summary>
    /// api out of method Api_IfFriend
    /// </summary>
    public class Api_IfFriendApiOut : CleverQQApiOutput
    {
        public bool Result { get; set; }
        public override string TypeCode => nameof(Api_IfFriendApiOut);
    }
    /// <summary>
    /// api out of method Api_GetRInf
    /// </summary>
    public class Api_GetRInfApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetRInfApiOut);
    }
    /// <summary>
    /// api out of method Api_DelFriend
    /// </summary>
    public class Api_DelFriendApiOut : CleverQQApiOutput
    {
        public bool Result { get; set; }
        public override string TypeCode => nameof(Api_DelFriendApiOut);
    }
    /// <summary>
    /// api out of method Api_AddBkList
    /// </summary>
    public class Api_AddBkListApiOut : CleverQQApiOutput
    {
        public bool Result { get; set; }
        public override string TypeCode => nameof(Api_AddBkListApiOut);
    }
    /// <summary>
    /// api out of method Api_SendVoice
    /// </summary>
    public class Api_SendVoiceApiOut : CleverQQApiOutput
    {
        public bool Result { get; set; }
        public override string TypeCode => nameof(Api_SendVoiceApiOut);
    }
    /// <summary>
    /// api out of method Api_SetAdmin
    /// </summary>
    public class Api_SetAdminApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_SetAdminApiOut);
    }
    /// <summary>
    /// api out of method Api_GetLog
    /// </summary>
    public class Api_GetLogApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetLogApiOut);
    }
    /// <summary>
    /// api out of method Api_IsEnable
    /// </summary>
    public class Api_IsEnableApiOut : CleverQQApiOutput
    {
        public bool Result { get; set; }
        public override string TypeCode => nameof(Api_IsEnableApiOut);
    }
    /// <summary>
    /// api out of method Api_WithdrawMsg
    /// </summary>
    public class Api_WithdrawMsgApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_WithdrawMsgApiOut);
    }
    /// <summary>
    /// api out of method Api_GetQQAddMode
    /// </summary>
    public class Api_GetQQAddModeApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetQQAddModeApiOut);
    }
    /// <summary>
    /// api out of method Api_IsOnline
    /// </summary>
    public class Api_IsOnlineApiOut : CleverQQApiOutput
    {
        public bool Result { get; set; }
        public override string TypeCode => nameof(Api_IsOnlineApiOut);
    }
    /// <summary>
    /// api out of method Api_GetOnlineState
    /// </summary>
    public class Api_GetOnlineStateApiOut : CleverQQApiOutput
    {
        public int Result { get; set; }
        public override string TypeCode => nameof(Api_GetOnlineStateApiOut);
    }
    /// <summary>
    /// api out of method Api_GetGroupMemberNum
    /// </summary>
    public class Api_GetGroupMemberNumApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetGroupMemberNumApiOut);
    }
    /// <summary>
    /// api out of method Api_GetWpa
    /// </summary>
    public class Api_GetWpaApiOut : CleverQQApiOutput
    {
        public bool Result { get; set; }
        public override string TypeCode => nameof(Api_GetWpaApiOut);
    }
    /// <summary>
    /// api out of method Api_GetGroupAddMode
    /// </summary>
    public class Api_GetGroupAddModeApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetGroupAddModeApiOut);
    }
    /// <summary>
    /// api out of method Api_GetGroupLv
    /// </summary>
    public class Api_GetGroupLvApiOut : CleverQQApiOutput
    {
        public int Result { get; set; }
        public override string TypeCode => nameof(Api_GetGroupLvApiOut);
    }
    /// <summary>
    /// api out of method Api_GetFriendsRemark
    /// </summary>
    public class Api_GetFriendsRemarkApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_GetFriendsRemarkApiOut);
    }
    /// <summary>
    /// api out of method Api_SignIn
    /// </summary>
    public class Api_SignInApiOut : CleverQQApiOutput
    {
        public bool Result { get; set; }
        public override string TypeCode => nameof(Api_SignInApiOut);
    }
    /// <summary>
    /// api out of method Api_TakeGift
    /// </summary>
    public class Api_TakeGiftApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_TakeGiftApiOut);
    }
    /// <summary>
    /// api out of method Api_CheckGift
    /// </summary>
    public class Api_CheckGiftApiOut : CleverQQApiOutput
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(Api_CheckGiftApiOut);
    }
    /// <summary>
    /// api out of method Api_GiveGift
    /// </summary>
    public class Api_GiveGiftApiOut : CleverQQApiOutput
    {
        public int Result { get; set; }
        public override string TypeCode => nameof(Api_GiveGiftApiOut);
    }
    /// <summary>
    /// api out of method Api_GetGroupChatLv
    /// </summary>
    public class Api_GetGroupChatLvApiOut : CleverQQApiOutput
    {
        public int Result { get; set; }
        public override string TypeCode => nameof(Api_GetGroupChatLvApiOut);
    }
    /// <summary>
    /// api out of method Api_GetExpertDays
    /// </summary>
    public class Api_GetExpertDaysApiOut : CleverQQApiOutput
    {
        public int Result { get; set; }
        public override string TypeCode => nameof(Api_GetExpertDaysApiOut);
    }
    /// <summary>
    /// api out of method Api_GetShieldedState
    /// </summary>
    public class Api_GetShieldedStateApiOut : CleverQQApiOutput
    {
        public bool Result { get; set; }
        public override string TypeCode => nameof(Api_GetShieldedStateApiOut);
    }
}
