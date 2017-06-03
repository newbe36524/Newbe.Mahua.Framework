using System;
using Newbe.Mahua.Framework.MahuaEvents;

namespace Newbe.Mahua.Framework
{
    public interface IMahuaApi
    {
        /// <summary>
        ///     发送好友消息
        /// </summary>
        /// <param name="toQq">目标QQ号</param>
        /// <param name="message">消息内容</param>
        void SendPrivateMessage(long toQq, string message);

        /// <summary>
        /// 发送群消息
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <param name="message">消息内容</param>
        void SendGroupMessage(long toGroup, string message);

        /// <summary>
        /// 发送讨论组消息
        /// </summary>
        /// <param name="toDiscuss">目标讨论组</param>
        /// <param name="message">消息内容</param>
        void SendDiscussMessage(long toDiscuss, string message);


        /// <summary>
        /// 发送赞
        /// </summary>
        /// <param name="toQq">目标QQ</param>
        /// <returns></returns>
        int SendLike(long toQq);

        /// <summary>
        /// 取Cookies
        /// </summary>
        /// <returns></returns>
        string GetCookies();

        /// <summary>
        /// 取CsrfToken，bkn
        /// </summary>
        /// <returns>bkn</returns>
        int GetCsrfToken();

        /// <summary>
        /// 取登录QQ
        /// </summary>
        /// <returns></returns>
        long GetLoginQq();

        /// <summary>
        /// 取登录昵称
        /// </summary>
        /// <returns></returns>
        string GetLoginNick();

        /// <summary>
        /// 接收语音
        /// </summary>
        /// <param name="file">收到消息中的语音文件名(file)</param>
        /// <param name="outformat">应用所需的格式</param>
        /// <returns></returns>
        string GetRecord(string file, string outformat);

        /// <summary>
        /// 置群员移除
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <param name="toQq">目标QQ</param>
        /// <param name="rejectForever">如果为真，则“不再接收此人加群申请”，请慎用</param>
        /// <returns></returns>
        void KickGroupMember(long toGroup, long toQq, bool rejectForever);

        /// <summary>
        /// 置群员禁言
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <param name="toQq">目标QQ</param>
        /// <param name="duration">禁言的时间</param>
        /// <returns></returns>
        void BanGroupMember(long toGroup, long toQq, TimeSpan duration);

        /// <summary>
        /// 取消群成员禁言
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <param name="toQq">目标QQ</param>
        /// <returns></returns>
        void RemoveBanGroupMember(long toGroup, long toQq);

        /// <summary>
        /// 设置群管理员
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <param name="toQq">被设置的QQ</param>
        /// <returns></returns>
        void EnableGroupAdmin(long toGroup, long toQq);

        /// <summary>
        /// 删除群管理员
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <param name="toQq">被设置的Q</param>
        /// <returns></returns>
        void DisableGroupAdmin(long toGroup, long toQq);

        /// <summary>
        /// 置群成员专属头衔
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <param name="toQq">目标QQ</param>
        /// <param name="specialTitle">如果要删除，这里填空</param>
        /// <param name="duration">专属头衔有效期。如果永久有效，则使用<see cref="TimeSpan.MaxValue"/></param>
        /// <returns></returns>
        void SetGroupMemberSpecialTitle(long toGroup, long toQq, string specialTitle, TimeSpan duration);

        /// <summary>
        /// 置全群禁言
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <param name="enabled">true为启用</param>
        /// <returns></returns>
        void SetBanAllGroupMembersOption(long toGroup, bool enabled);

        /// <summary>
        /// 置匿名群员禁言
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <param name="anonymous">匿名名称，<see cref="GroupMessageReceivedContext.FromAnonymous"/>参数</param>
        /// <param name="duration">禁言的时间。不支持解禁</param>
        /// <returns></returns>
        int SetGroupAnonymousBan(long toGroup, string anonymous, TimeSpan duration);

        /// <summary>
        /// 置群匿名设置
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <param name="enabled">true为启用</param>
        /// <returns></returns>
        int SetGroupAnonymousOption(long toGroup, bool enabled);

        /// <summary>
        /// 置群成员名片
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <param name="toQq">被设置的QQ</param>
        /// <param name="groupMemberCard">群名片</param>
        /// <returns></returns>
        void SetGroupMemberCard(long toGroup, long toQq, string groupMemberCard);

        /// <summary>
        /// 管理、群成员退出群
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <returns></returns>
        void LeaveGroup(long toGroup);

        /// <summary>
        /// 群主解散群
        /// </summary>
        /// <param name="toGroup">目标群</param>
        void DissolveGroup(long toGroup);

        /// <summary>
        /// 退出讨论组
        /// </summary>
        /// <param name="toDiscuss">目标讨论组</param>
        /// <returns></returns>
        int LeaveDiscuss(long toDiscuss);

        /// <summary>
        /// 同意添加好友请求
        /// </summary>
        /// <param name="addingFriendRequestId">好友请求Id，<see cref="FriendAddingRequestContext.SendTime"/></param>
        /// <param name="friendRemark">添加后的好友备注</param>
        void AcceptFriendAddingRequest(string addingFriendRequestId, string friendRemark);

        /// <summary>
        /// 拒绝添加好友请求
        /// </summary>
        /// <param name="addingFriendRequestId">好友请求Id，<see cref="FriendAddingRequestContext.SendTime"/></param>
        void RejectFriendAddingRequest(string addingFriendRequestId);

        /// <summary>
        /// 管理员同意入群申请
        /// </summary>
        /// <param name="groupJoiningRequestId">加入群请求Id，<see cref="GroupJoiningRequestReceivedContext.GroupJoiningRequestId"/></param>
        void AcceptGroupJoiningRequest(string groupJoiningRequestId);

        /// <summary>
        /// 管理员拒绝入群申请
        /// </summary>
        /// <param name="groupJoiningRequestId">加入群请求Id，<see cref="GroupJoiningRequestReceivedContext.GroupJoiningRequestId"/></param>
        /// <param name="reason">原因</param>
        void RejectGroupJoiningRequest(string groupJoiningRequestId, string reason);

        /// <summary>
        /// 接受入群邀请
        /// </summary>
        /// <param name="groupJoiningInvitationId">入群邀请Id，<see cref="GroupJoiningInvitationReceivedContext.GroupJoiningInvitationId"/></param>
        void AcceptGroupJoiningInvitation(string groupJoiningInvitationId);

        /// <summary>
        /// 拒绝入群邀请
        /// </summary>
        /// <param name="groupJoiningInvitationId">入群邀请Id，<see cref="GroupJoiningInvitationReceivedContext.GroupJoiningInvitationId"/></param>
        /// <param name="reason">原因</param>
        void RejectGroupJoiningInvitation(string groupJoiningInvitationId, string reason);
    }
}