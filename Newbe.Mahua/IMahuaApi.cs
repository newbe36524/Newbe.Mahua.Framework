using System;
using System.ComponentModel;
using Newbe.Mahua.MahuaEvents;

namespace Newbe.Mahua
{
    /// <summary>
    /// MahuaApi
    /// </summary>
    public interface IMahuaApi
    {
        /// <summary>
        /// 发送私聊消息
        /// </summary>
        /// <param name="toQq">目标QQ号</param>
        /// <param name="message">消息内容</param>
        [Description("发送私聊消息")]
        void SendPrivateMessage(string toQq, string message);

        /// <summary>
        /// 发送群消息
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <param name="message">消息内容</param>
        [Description("发送群消息")]
        void SendGroupMessage(string toGroup, string message);

        /// <summary>
        /// 发送讨论组消息
        /// </summary>
        /// <param name="toDiscuss">目标讨论组</param>
        /// <param name="message">消息内容</param>
        [Description("发送讨论组消息")]
        void SendDiscussMessage(string toDiscuss, string message);


        /// <summary>
        /// 发送名片赞
        /// </summary>
        /// <param name="toQq">目标QQ</param>
        /// <returns></returns>
        /// <remarks>:QQ名片赞 10赞每Q每日 至多50人</remarks>
        [Description("发送名片赞")]
        void SendLike(string toQq);

        /// <summary>
        /// 取Cookies
        /// </summary>
        /// <returns></returns>
        [Description("取Cookies")]
        string GetCookies();

        /// <summary>
        /// 取bkn
        /// </summary>
        /// <returns>bkn</returns>
        [Description("取bkn")]
        string GetBkn();

        /// <summary>
        /// 取当前登录QQ
        /// </summary>
        /// <returns></returns>
        [Description("取当前登录QQ")]
        string GetLoginQq();

        /// <summary>
        /// 取当前登录QQ昵称
        /// </summary>
        /// <returns></returns>
        [Description("取当前登录QQ昵称")]
        string GetLoginNick();

        /// <summary>
        /// 移出群成员
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <param name="toQq">目标QQ</param>
        /// <param name="rejectForever">如果为真，则“不再接收此人加群申请”，请慎用</param>
        /// <returns></returns>
        [Description("移出群成员")]
        void KickGroupMember(string toGroup, string toQq, bool rejectForever);

        /// <summary>
        /// 禁言某群成员
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <param name="toQq">目标QQ</param>
        /// <param name="duration">禁言的时间</param>
        /// <returns></returns>
        [Description("禁言某群成员")]
        void BanGroupMember(string toGroup, string toQq, TimeSpan duration);

        /// <summary>
        /// 取消禁言某群成员
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <param name="toQq">目标QQ</param>
        /// <returns></returns>
        [Description("取消禁言某群成员")]
        void RemoveBanGroupMember(string toGroup, string toQq);

        /// <summary>
        /// 设置群管理员
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <param name="toQq">被设置的QQ</param>
        /// <returns></returns>
        [Description("设置群管理员")]
        void EnableGroupAdmin(string toGroup, string toQq);

        /// <summary>
        /// 删除群管理员
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <param name="toQq">被设置的Q</param>
        /// <returns></returns>
        [Description("删除群管理员")]
        void DisableGroupAdmin(string toGroup, string toQq);

        /// <summary>
        /// 设置群成员专属头衔
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <param name="toQq">目标QQ</param>
        /// <param name="specialTitle">如果要删除，这里填空</param>
        /// <param name="duration">专属头衔有效期。如果永久有效，则使用<see cref="TimeSpan.MaxValue"/></param>
        /// <returns></returns>
        [Description("设置群成员专属头衔")]
        void SetGroupMemberSpecialTitle(string toGroup, string toQq, string specialTitle, TimeSpan duration);

        /// <summary>
        /// 设置全群禁言
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <param name="enabled">true为启用</param>
        /// <returns></returns>
        [Description("设置全群禁言")]
        void SetBanAllGroupMembersOption(string toGroup, bool enabled);

        /// <summary>
        /// 设置禁言某匿名群员
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <param name="anonymous">匿名名称，<see cref="GroupMessageReceivedContext.FromAnonymous"/>参数</param>
        /// <param name="duration">禁言的时间。不支持解禁</param>
        /// <returns></returns>
        [Description("设置禁言某匿名群员")]
        void BanGroupAnonymousMember(string toGroup, string anonymous, TimeSpan duration);

        /// <summary>
        /// 设置群匿名设置
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <param name="enabled">true为启用</param>
        /// <returns></returns>
        [Description("设置群匿名设置")]
        void SetGroupAnonymousOption(string toGroup, bool enabled);

        /// <summary>
        /// 设置群成员名片
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <param name="toQq">被设置的QQ</param>
        /// <param name="groupMemberCard">群名片</param>
        /// <returns></returns>
        [Description("设置群成员名片")]
        void SetGroupMemberCard(string toGroup, string toQq, string groupMemberCard);

        /// <summary>
        /// 退出群
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <returns></returns>
        [Description("退出群")]
        void LeaveGroup(string toGroup);

        /// <summary>
        /// 解散群
        /// </summary>
        /// <param name="toGroup">目标群</param>
        [Description("解散群")]
        void DissolveGroup(string toGroup);

        /// <summary>
        /// 退出讨论组
        /// </summary>
        /// <param name="toDiscuss">目标讨论组</param>
        /// <returns></returns>
        [Description("退出讨论组")]
        void LeaveDiscuss(string toDiscuss);

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


        /// <summary>
        /// 将QQ移入黑名单
        /// </summary>
        /// <param name="toQq"></param>
        [Description("将QQ移入黑名单")]
        void BanFriend(string toQq);

        /// <summary>
        /// 将QQ移出黑名单
        /// </summary>
        /// <param name="toQq"></param>
        [Description("将QQ移出黑名单")]
        void RemoveBanFriend(string toQq);

        /// <summary>
        /// 发布群公告
        /// </summary>
        /// <param name="toGroup"></param>
        /// <param name="title"></param>
        /// <param name="content"></param>
        [Description("发布群公告")]
        void SetNotice(string toGroup, string title, string content);


        /// <summary>
        /// 删除好友
        /// </summary>
        /// <param name="toQq"></param>
        [Description("删除好友")]
        void RemoveFriend(string toQq);


        /// <summary>
        /// 主动加群
        /// </summary>
        /// <param name="toGroup"></param>
        /// <param name="reason"></param>
        [Description("主动加群")]
        void JoinGroup(string toGroup, string reason);

        /// <summary>
        /// 获取群成员列表
        /// </summary>
        /// <param name="toGroup"></param>
        /// <returns></returns>
        [Description("获取群成员列表")]
        string GetGroupMemebers(string toGroup);


        /// <summary>
        /// 获取群列表
        /// </summary>
        /// <returns></returns>
        [Description("获取群列表")]
        string GetGroups();

        /// <summary>
        /// 获取好友列表
        /// </summary>
        /// <returns></returns>
        [Description("获取好友列表")]
        string GetFriends();

        /// <summary>
        /// 发送入群邀请
        /// </summary>
        /// <param name="toQq"></param>
        /// <param name="toGroup"></param>
        [Description("发送入群邀请")]
        void SendGroupJoiningInvitation(string toQq, string toGroup);

        /// <summary>
        /// 创建讨论组
        /// </summary>
        /// <returns>讨论组Id，为空则说明创建失败</returns>
        /// <remarks>每24小时只能创建100个讨论组</remarks>
        [Description("创建讨论组")]
        string CreateDiscuss();


        /// <summary>
        /// 踢出讨论组
        /// </summary>
        /// <param name="toDiscuss"></param>
        /// <param name="toQq"></param>
        [Description("踢出讨论组")]
        void KickDiscussMember(string toDiscuss, string toQq);

        /// <summary>
        /// 发送讨论组邀请
        /// </summary>
        /// <param name="toQq"></param>
        /// <param name="toDiscuss"></param>
        [Description("发送讨论组邀请")]
        void SendDiscussJoiningInvitation(string toQq, string toDiscuss);

        /// <summary>
        /// 获取讨论组列表
        /// </summary>
        /// <returns></returns>
        [Description("获取讨论组列表")]
        string GetDiscusses();
    }
}