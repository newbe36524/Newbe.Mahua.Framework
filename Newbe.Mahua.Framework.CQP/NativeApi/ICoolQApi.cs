using System;
using System.ComponentModel;

namespace Newbe.Mahua.Framework.CQP.NativeApi
{
    /// <summary>
    /// 向酷Q.NET插件提供酷Q Api（与易语言170501对应）
    /// </summary>
    public interface ICoolQApi
    {
        /// <summary>
        ///     添加运行日志
        /// </summary>
        /// <param name="priority">优先级#Log_开头常量</param>
        /// <param name="logType">日志类型</param>
        /// <param name="content">日志内容</param>
        /// <returns></returns>
        int AddLog(int priority, string logType, string content);

        /// <summary>
        ///     取应用目录
        /// </summary>
        /// <returns></returns>
        string GetAppDirectory();

        /// <summary>
        ///     取Cookies(慎用,此接口需要严格授权)
        /// </summary>
        /// <returns></returns>
        string GetCookies();

        /// <summary>
        ///     取CsrfToken(慎用,此接口需要严格授权)
        /// </summary>
        /// <returns></returns>
        int GetCsrfToken();

        /// <summary>
        ///     取群成员信息(旧版,请用CQ_getGroupMemberInfoV2)
        /// </summary>
        /// <param name="groupId">目标群</param>
        /// <param name="qqId">目标QQ</param>
        /// <returns></returns>
        [Obsolete("旧版,请用CQ_getGroupMemberInfoV2")]
        string GetGroupMemberInfo(long groupId, long qqId);

        /// <summary>
        /// 取群成员信息(支持缓存)
        /// </summary>
        /// <param name="groupId">目标群</param>
        /// <param name="qqId">目标QQ</param>
        /// <param name="cache">是否缓存</param>
        /// <returns></returns>
        string GetGroupMemberInfoV2AsString(long groupId, long qqId, bool cache);

        /// <summary>
        /// 取群成员列表
        /// </summary>
        /// <param name="groupId">目标群</param>
        /// <returns></returns>
        string GetGroupMemberListAsString(long groupId);

        /// <summary>
        ///     取登录昵称
        /// </summary>
        /// <returns></returns>
        string GetLoginNick();

        /// <summary>
        ///     取登录QQ
        /// </summary>
        /// <returns></returns>
        // ReSharper disable once InconsistentNaming
        long GetLoginQQ();

        /// <summary>
        ///     接受语音消息
        /// </summary>
        /// <param name="file">收到消息中的语音文件名(file)</param>
        /// <param name="outformat">应用所需的格式</param>
        /// <returns></returns>
        string GetRecord(string file, string outformat);

        /// <summary>
        ///     取陌生人(支持缓存)
        /// </summary>
        /// <param name="qqId">目标QQ</param>
        /// <param name="ache">是否缓存</param>
        /// <returns></returns>
        string GetStrangerInfo(long qqId, bool ache);

        /// <summary>
        ///     发送讨论组消息
        /// </summary>
        /// <param name="discussId">目标讨论组号</param>
        /// <param name="content">消息内容</param>
        /// <returns></returns>
        int SendDiscussMsg(long discussId, string content);

        /// <summary>
        ///     发送群消息
        /// </summary>
        /// <param name="groupId">目标群号</param>
        /// <param name="content">消息内容</param>
        /// <returns></returns>
        int SendGroupMsg(long groupId, string content);

        /// <summary>
        ///     发送赞
        /// </summary>
        /// <param name="qqId">目标QQ号</param>
        /// <returns></returns>
        int SendLike(long qqId);

        /// <summary>
        ///     发送赞
        /// </summary>
        /// <param name="qqId">目标QQ</param>
        /// <param name="times">点赞次数</param>
        /// <returns></returns>
        int SendLike2(long qqId, int times);

        /// <summary>
        ///     发送好友消息
        /// </summary>
        /// <param name="qqId">目标QQ号</param>
        /// <param name="content">消息内容</param>
        /// <returns></returns>
        int SendPrivateMsg(long qqId, string content);

        /// <summary>
        /// 设置酷Q授权码
        /// </summary>
        /// <param name="authCode"></param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        void SetAuthCode(int authCode);

        /// <summary>
        ///     退出讨论组
        /// </summary>
        /// <param name="discussId">目标讨论组</param>
        /// <returns></returns>
        int SetDiscussLeave(long discussId);

        /// <summary>
        ///     致命错误提示
        /// </summary>
        /// <param name="errorText">错误信息</param>
        /// <returns></returns>
        int SetFatal(string errorText);

        /// <summary>
        ///     好友添加请求
        /// </summary>
        /// <param name="requestReturn">请求事件收到的“反馈标识”参数</param>
        /// <param name="returnType">#请求_通过 或 #请求_拒绝</param>
        /// <param name="remark">添加后的好友备注</param>
        /// <returns></returns>
        int SetFriendAddRequest(string requestReturn, int returnType, string remark);

        /// <summary>
        ///     群添加请求
        /// </summary>
        /// <param name="requestReturn">请求事件收到的“反馈标识”参数</param>
        /// <param name="requestType">根据请求事件的子类型区分 #请求_群添加 或 #请求_群邀请</param>
        /// <param name="returnType">#请求_通过 或 #请求_拒绝</param>
        /// <returns></returns>
        int SetGroupAddRequest(string requestReturn, int requestType,
            int returnType);

        /// <summary>
        ///     群添加请求
        /// </summary>
        /// <param name="requestReturn">请求事件收到的“反馈标识”参数</param>
        /// <param name="requestType">根据请求事件的子类型区分 #请求_群添加 或 #请求_群邀请</param>
        /// <param name="returnType">#请求_通过 或 #请求_拒绝</param>
        /// <param name="reason">操作理由，仅 #请求_群添加 且 #请求_拒绝 时可用</param>
        /// <returns></returns>
        int SetGroupAddRequest2(string requestReturn, int requestType,
            int returnType, string reason);

        /// <summary>
        ///     设置群管理员
        /// </summary>
        /// <param name="groupId">目标群</param>
        /// <param name="qqId">目标QQ</param>
        /// <param name="manager">true/设置管理员 false/取消管理员</param>
        /// <returns></returns>
        int SetGroupAdmin(long groupId, long qqId, bool manager);

        /// <summary>
        ///     群匿名设置
        /// </summary>
        /// <param name="groupId">目标群</param>
        /// <param name="anonymous">true开启.false关闭</param>
        /// <returns></returns>
        int SetGroupAnonymous(long groupId, bool anonymous);

        /// <summary>
        ///     禁言匿名群员
        /// </summary>
        /// <param name="groupId">目标群</param>
        /// <param name="fromAnonymous">群消息事件收到的“fromAnonymous”参数</param>
        /// <param name="time">禁言的时间，单位为秒。不支持解禁</param>
        /// <returns></returns>
        int SetGroupAnonymousBan(long groupId, string fromAnonymous, long time);

        /// <summary>
        ///     禁言群员
        /// </summary>
        /// <param name="groupId">目标群</param>
        /// <param name="qqId">目标QQ</param>
        /// <param name="time">禁言的时间，单位为秒。如果要解禁，这里填写0</param>
        /// <returns></returns>
        int SetGroupBan(long groupId, long qqId, long time);

        /// <summary>
        ///     设置群成员名片
        /// </summary>
        /// <param name="groupId">目标群</param>
        /// <param name="qqId">目标QQ</param>
        /// <param name="newCard">新名片</param>
        /// <returns></returns>
        int SetGroupCard(long groupId, long qqId, string newCard);

        /// <summary>
        ///     踢出群员
        /// </summary>
        /// <param name="groupId">目标群</param>
        /// <param name="qqId">目标QQ</param>
        /// <param name="refused">如果为真，则“不再接收此人加群申请”</param>
        /// <returns></returns>
        int SetGroupKick(long groupId, long qqId, bool refused);

        /// <summary>
        ///     退出群
        /// </summary>
        /// <param name="groupId">目标群</param>
        /// <param name="disband">true解散本群(群主),false退出本群(管理、群成员)</param>
        /// <returns></returns>
        int SetGroupLeave(long groupId, bool disband);

        /// <summary>
        ///     设置群成员专属头衔
        /// </summary>
        /// <param name="groupId">目标群</param>
        /// <param name="qqId">目标QQ</param>
        /// <param name="specialTitle">专属头衔,如果要删除，这里填空</param>
        /// <param name="time">专属头衔有效期，单位为秒。如果永久有效，这里填写-1</param>
        /// <returns></returns>
        int SetGroupSpecialTitle(long groupId, long qqId, string specialTitle, long time);

        /// <summary>
        ///     全群禁言
        /// </summary>
        /// <param name="groupId">目标群</param>
        /// <param name="open">true开启,false关闭</param>
        /// <returns></returns>
        int SetGroupWholeBan(long groupId, bool open);
    }
}