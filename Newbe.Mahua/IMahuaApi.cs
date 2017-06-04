using System;
using System.ComponentModel;
using Newbe.Mahua.MahuaEvents;

namespace Newbe.Mahua
{
    public interface IMahuaApi
    {
        /// <summary>
        /// 发送私聊消息
        /// </summary>
        /// <param name="toQq">目标QQ号</param>
        /// <param name="message">消息内容</param>
        [Description("发送私聊消息")]
        void SendPrivateMessage(long toQq, string message);

        /// <summary>
        /// 发送群消息
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <param name="message">消息内容</param>
        [Description("发送群消息")]
        void SendGroupMessage(long toGroup, string message);

        /// <summary>
        /// 发送讨论组消息
        /// </summary>
        /// <param name="toDiscuss">目标讨论组</param>
        /// <param name="message">消息内容</param>
        [Description("发送讨论组消息")]
        void SendDiscussMessage(long toDiscuss, string message);


        /// <summary>
        /// 发送名片赞
        /// </summary>
        /// <param name="toQq">目标QQ</param>
        /// <returns></returns>
        [Description("发送名片赞")]
        int SendLike(long toQq);

        /// <summary>
        /// 取Cookies
        /// </summary>
        /// <returns></returns>
        [Description("取Cookies")]
        string GetCookies();

        /// <summary>
        /// 取CsrfToken，bkn
        /// </summary>
        /// <returns>bkn</returns>
        [Description("取CsrfToken，bkn")]
        int GetCsrfToken();

        /// <summary>
        /// 取当前登录QQ
        /// </summary>
        /// <returns></returns>
        [Description("取当前登录QQ")]
        long GetLoginQq();

        /// <summary>
        /// 取当前登录QQ昵称
        /// </summary>
        /// <returns></returns>
        [Description("取当前登录QQ昵称")]
        string GetLoginNick();

        /// <summary>
        /// 接收语音
        /// </summary>
        /// <param name="file">收到消息中的语音文件名(file)</param>
        /// <param name="outformat">应用所需的格式</param>
        /// <returns></returns>
        [Description("接收语音")]
        string GetRecord(string file, string outformat);

        /// <summary>
        /// 移出群成员
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <param name="toQq">目标QQ</param>
        /// <param name="rejectForever">如果为真，则“不再接收此人加群申请”，请慎用</param>
        /// <returns></returns>
        [Description("移出群成员")]
        void KickGroupMember(long toGroup, long toQq, bool rejectForever);

        /// <summary>
        /// 禁言某群成员
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <param name="toQq">目标QQ</param>
        /// <param name="duration">禁言的时间</param>
        /// <returns></returns>
        [Description("禁言某群成员")]
        void BanGroupMember(long toGroup, long toQq, TimeSpan duration);

        /// <summary>
        /// 取消禁言某群成员
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <param name="toQq">目标QQ</param>
        /// <returns></returns>
        [Description("取消禁言某群成员")]
        void RemoveBanGroupMember(long toGroup, long toQq);

        /// <summary>
        /// 设置群管理员
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <param name="toQq">被设置的QQ</param>
        /// <returns></returns>
        [Description("设置群管理员")]
        void EnableGroupAdmin(long toGroup, long toQq);

        /// <summary>
        /// 删除群管理员
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <param name="toQq">被设置的Q</param>
        /// <returns></returns>
        [Description("删除群管理员")]
        void DisableGroupAdmin(long toGroup, long toQq);

        /// <summary>
        /// 设置群成员专属头衔
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <param name="toQq">目标QQ</param>
        /// <param name="specialTitle">如果要删除，这里填空</param>
        /// <param name="duration">专属头衔有效期。如果永久有效，则使用<see cref="TimeSpan.MaxValue"/></param>
        /// <returns></returns>
        [Description("设置群成员专属头衔")]
        void SetGroupMemberSpecialTitle(long toGroup, long toQq, string specialTitle, TimeSpan duration);

        /// <summary>
        /// 设置全群禁言
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <param name="enabled">true为启用</param>
        /// <returns></returns>
        [Description("设置全群禁言")]
        void SetBanAllGroupMembersOption(long toGroup, bool enabled);

        /// <summary>
        /// 设置禁言某匿名群员
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <param name="anonymous">匿名名称，<see cref="GroupMessageReceivedContext.FromAnonymous"/>参数</param>
        /// <param name="duration">禁言的时间。不支持解禁</param>
        /// <returns></returns>
        [Description("设置禁言某匿名群员")]
        int SetGroupAnonymousBan(long toGroup, string anonymous, TimeSpan duration);

        /// <summary>
        /// 设置群匿名设置
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <param name="enabled">true为启用</param>
        /// <returns></returns>
        [Description("设置群匿名设置")]
        int SetGroupAnonymousOption(long toGroup, bool enabled);

        /// <summary>
        /// 设置群成员名片
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <param name="toQq">被设置的QQ</param>
        /// <param name="groupMemberCard">群名片</param>
        /// <returns></returns>
        [Description("设置群成员名片")]
        void SetGroupMemberCard(long toGroup, long toQq, string groupMemberCard);

        /// <summary>
        /// 退出群
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <returns></returns>
        [Description("退出群")]
        void LeaveGroup(long toGroup);

        /// <summary>
        /// 解散群
        /// </summary>
        /// <param name="toGroup">目标群</param>
        [Description("解散群")]
        void DissolveGroup(long toGroup);

        /// <summary>
        /// 退出讨论组
        /// </summary>
        /// <param name="toDiscuss">目标讨论组</param>
        /// <returns></returns>
        [Description("退出讨论组")]
        int LeaveDiscuss(long toDiscuss);

        /// <summary>
        /// 同意添加好友请求
        /// </summary>
        /// <param name="addingFriendRequestId">好友请求Id，<see cref="FriendAddingRequestContext.SendTime"/></param>
        /// <param name="friendRemark">添加后的好友备注</param>
        [Description("同意添加好友请求")]
        void AcceptFriendAddingRequest(string addingFriendRequestId, string friendRemark);

        /// <summary>
        /// 拒绝添加好友请求
        /// </summary>
        /// <param name="addingFriendRequestId">好友请求Id，<see cref="FriendAddingRequestContext.SendTime"/></param>
        [Description("拒绝添加好友请求")]
        void RejectFriendAddingRequest(string addingFriendRequestId);

        /// <summary>
        /// 管理员同意入群申请
        /// </summary>
        /// <param name="groupJoiningRequestId">加入群请求Id，<see cref="GroupJoiningRequestReceivedContext.GroupJoiningRequestId"/></param>
        [Description("管理员同意入群申请")]
        void AcceptGroupJoiningRequest(string groupJoiningRequestId);

        /// <summary>
        /// 管理员拒绝入群申请
        /// </summary>
        /// <param name="groupJoiningRequestId">加入群请求Id，<see cref="GroupJoiningRequestReceivedContext.GroupJoiningRequestId"/></param>
        /// <param name="reason">原因</param>
        [Description("管理员拒绝入群申请")]
        void RejectGroupJoiningRequest(string groupJoiningRequestId, string reason);

        /// <summary>
        /// 接受入群邀请
        /// </summary>
        /// <param name="groupJoiningInvitationId">入群邀请Id，<see cref="GroupJoiningInvitationReceivedContext.GroupJoiningInvitationId"/></param>
        [Description("接受入群邀请")]
        void AcceptGroupJoiningInvitation(string groupJoiningInvitationId);

        /// <summary>
        /// 拒绝入群邀请
        /// </summary>
        /// <param name="groupJoiningInvitationId">入群邀请Id，<see cref="GroupJoiningInvitationReceivedContext.GroupJoiningInvitationId"/></param>
        /// <param name="reason">原因</param>
        [Description("拒绝入群邀请")]
        void RejectGroupJoiningInvitation(string groupJoiningInvitationId, string reason);
    }
}