using System.Runtime.InteropServices;

namespace Newbe.Mahua.Framework.CQP
{
    internal class CoolQApi : ICoolQApi
    {
        private int _cqauthcode;

        public void SetAuthCode(int authCode)
        {
            _cqauthcode = authCode;
        }

        #region Impl

        public int SendDiscussMsg(long discussId, string content)
        {
            return NativeMethods.CQ_sendDiscussMsg(_cqauthcode,
                discussId, content);
        }

        public int SendGroupMsg(long groupId, string content)
        {
            return NativeMethods.CQ_sendGroupMsg(_cqauthcode, groupId,
                content);
        }

        public int SendLike(long qqId)
        {
            return NativeMethods.CQ_sendLike(_cqauthcode, qqId);
        }

        public int SendLike2(long qqId, int times)
        {
            return NativeMethods.CQ_sendLike2(_cqauthcode, qqId, times);
        }

        public int SendPrivateMsg(long qqId, string content)
        {
            return NativeMethods.CQ_sendPrivateMsg(_cqauthcode, qqId,
                content);
        }

        public string GetAppDirectory()
        {
            return NativeMethods.CQ_getAppDirectory(_cqauthcode);
        }

        public string GetCookies()
        {
            return NativeMethods.CQ_getCookies(_cqauthcode);
        }

        public int GetCsrfToken()
        {
            return NativeMethods.CQ_getCsrfToken(_cqauthcode);
        }

        public string GetGroupMemberInfoV2AsString(long groupId, long qqId, bool cache)
        {
            return NativeMethods.CQ_getGroupMemberInfoV2(_cqauthcode, groupId, qqId, cache);
        }

        public string GetGroupMemberInfo(long groupId, long qqId)
        {
            return NativeMethods.CQ_getGroupMemberInfo(_cqauthcode, groupId, qqId);
        }


        public string GetGroupMemberListAsString(long groupId)
        {
            return NativeMethods.CQ_getGroupMemberList(_cqauthcode, groupId);
        }

        public string GetLoginNick()
        {
            return NativeMethods.CQ_getLoginNick(_cqauthcode);
        }

        // ReSharper disable once InconsistentNaming
        public long GetLoginQQ()
        {
            return NativeMethods.CQ_getLoginQQ(_cqauthcode);
        }

        public string GetRecord(string file, string outformat)
        {
            return NativeMethods.CQ_getRecord(_cqauthcode, file,
                outformat);
        }

        public string GetStrangerInfo(long qqId, bool ache)
        {
            return NativeMethods.CQ_getStrangerInfo(_cqauthcode, qqId, ache);
        }

        public int SetDiscussLeave(long discussId)
        {
            return NativeMethods.CQ_setDiscussLeave(_cqauthcode, discussId);
        }

        public int SetFatal(string errorText)
        {
            return NativeMethods.CQ_setFatal(_cqauthcode, errorText);
        }

        public int SetFriendAddRequest(string requestReturn, int returnType, string remark)
        {
            return NativeMethods
                .CQ_setFriendAddRequest(_cqauthcode, requestReturn, returnType, remark);
        }

        public int SetGroupAddRequest(string requestReturn, int requestType,
            int returnType)
        {
            return NativeMethods
                .CQ_setGroupAddRequest(_cqauthcode, requestReturn, (int) requestType, (int) returnType);
        }

        public int SetGroupAddRequest2(string requestReturn, int requestType,
            int returnType, string reason)
        {
            return NativeMethods.CQ_setGroupAddRequest2(_cqauthcode, requestReturn, (int) requestType, (int) returnType,
                reason);
        }

        public int SetGroupAdmin(long groupId, long qqId, bool manager)
        {
            return NativeMethods.CQ_setGroupAdmin(_cqauthcode,
                groupId, qqId, manager);
        }

        public int SetGroupAnonymous(long groupId, bool anonymous)
        {
            return NativeMethods.CQ_setGroupAnonymous(_cqauthcode,
                groupId, anonymous);
        }

        public int SetGroupAnonymousBan(long groupId, string fromAnonymous, long time)
        {
            return NativeMethods
                .CQ_setGroupAnonymousBan(_cqauthcode, groupId, fromAnonymous, time);
        }

        public int SetGroupBan(long groupId, long qqId, long time)
        {
            return NativeMethods.CQ_setGroupBan(_cqauthcode, groupId,
                qqId, time);
        }

        public int SetGroupCard(long groupId, long qqId, string newCard)
        {
            return NativeMethods.CQ_setGroupCard(_cqauthcode,
                groupId, qqId, newCard);
        }

        public int SetGroupKick(long groupId, long qqId, bool refused)
        {
            return NativeMethods.CQ_setGroupKick(_cqauthcode,
                groupId, qqId, refused);
        }

        public int SetGroupLeave(long groupId, bool disband)
        {
            return NativeMethods.CQ_setGroupLeave(_cqauthcode, groupId,
                disband);
        }

        public int SetGroupSpecialTitle(long groupId, long qqId, string specialTitle, long time)
        {
            return NativeMethods
                .CQ_setGroupSpecialTitle(_cqauthcode, groupId, qqId, specialTitle, time);
        }

        public int SetGroupWholeBan(long groupId, bool open)
        {
            return NativeMethods.CQ_setGroupWholeBan(_cqauthcode, groupId,
                open);
        }

        public int AddLog(int priority, string logType, string content)
        {
            return NativeMethods.CQ_addLog(_cqauthcode,
                priority, logType.ToString(), content);
        }

        #endregion

        private static class NativeMethods
        {
            /// <summary>
            ///     添加运行日志
            /// </summary>
            /// <param name="authCode"></param>
            /// <param name="priority">优先级#Log_开头常量</param>
            /// <param name="logType">日志类型</param>
            /// <param name="content">日志内容</param>
            /// <returns></returns>
            [DllImport("CQP.DLL")]
            public static extern int CQ_addLog(int authCode, int priority, string logType, string content);


            /// <summary>
            ///     发送讨论组消息
            /// </summary>
            /// <param name="authCode"></param>
            /// <param name="discussId">目标讨论组号</param>
            /// <param name="content">消息内容</param>
            /// <returns></returns>
            [DllImport("CQP.DLL")]
            public static extern int CQ_sendDiscussMsg(int authCode, long discussId, string content);

            /// <summary>
            ///     发送群消息
            /// </summary>
            /// <param name="authCode"></param>
            /// <param name="groupId">目标群号</param>
            /// <param name="content">消息内容</param>
            /// <returns></returns>
            [DllImport("CQP.DLL")]
            public static extern int CQ_sendGroupMsg(int authCode, long groupId, string content);

            /// <summary>
            ///     发送赞
            /// </summary>
            /// <param name="authCode"></param>
            /// <param name="qqId">目标QQ号</param>
            /// <returns></returns>
            [DllImport("CQP.DLL")]
            public static extern int CQ_sendLike(int authCode, long qqId);

            /// <summary>
            ///     发送赞
            /// </summary>
            /// <param name="authCode"></param>
            /// <param name="qqId">目标QQ</param>
            /// <param name="times">点赞次数</param>
            /// <returns></returns>
            [DllImport("CQP.DLL")]
            public static extern int CQ_sendLike2(int authCode, long qqId, int times);

            /// <summary>
            ///     发送好友消息
            /// </summary>
            /// <param name="authCode"></param>
            /// <param name="qqId">目标QQ号</param>
            /// <param name="content">消息内容</param>
            /// <returns></returns>
            [DllImport("CQP.DLL")]
            public static extern int CQ_sendPrivateMsg(int authCode, long qqId, string content);


            /// <summary>
            ///     取应用目录
            /// </summary>
            /// <param name="authCode"></param>
            /// <returns></returns>
            [DllImport("CQP.DLL")]
            public static extern string CQ_getAppDirectory(int authCode);

            /// <summary>
            ///     取Cookies(慎用,此接口需要严格授权)
            /// </summary>
            /// <param name="authCode"></param>
            /// <returns></returns>
            [DllImport("CQP.DLL")]
            public static extern string CQ_getCookies(int authCode);

            /// <summary>
            ///     取CsrfToken(慎用,此接口需要严格授权)
            /// </summary>
            /// <param name="authCode"></param>
            /// <returns></returns>
            [DllImport("CQP.DLL")]
            public static extern int CQ_getCsrfToken(int authCode);

            /// <summary>
            ///     取群成员信息(旧版,请用CQ_getGroupMemberInfoV2)
            /// </summary>
            /// <param name="authCode"></param>
            /// <param name="groupId">目标群</param>
            /// <param name="qqId">目标QQ</param>
            /// <returns></returns>
            [DllImport("CQP.DLL")]
            public static extern string CQ_getGroupMemberInfo(int authCode, long groupId, long qqId);

            /// <summary>
            ///     取群成员信息(支持缓存)
            /// </summary>
            /// <param name="authCode"></param>
            /// <param name="groupId">目标群</param>
            /// <param name="qqId">目标QQ</param>
            /// <param name="cache">是否缓存</param>
            /// <returns></returns>
            [DllImport("CQP.DLL")]
            public static extern string CQ_getGroupMemberInfoV2(int authCode, long groupId, long qqId, bool cache);

            /// <summary>
            ///     取群成员列表
            /// </summary>
            /// <param name="authCode"></param>
            /// <param name="groupId">目标群</param>
            /// <returns></returns>
            [DllImport("CQP.DLL")]
            public static extern string CQ_getGroupMemberList(int authCode, long groupId);

            /// <summary>
            ///     取登录昵称
            /// </summary>
            /// <param name="authCode"></param>
            /// <returns></returns>
            [DllImport("CQP.DLL")]
            public static extern string CQ_getLoginNick(int authCode);

            /// <summary>
            ///     取登录QQ
            /// </summary>
            /// <param name="authCode"></param>
            /// <returns></returns>
            [DllImport("CQP.DLL")]
            public static extern long CQ_getLoginQQ(int authCode);

            /// <summary>
            ///     接受语音消息
            /// </summary>
            /// <param name="authCode"></param>
            /// <param name="file">收到消息中的语音文件名(file)</param>
            /// <param name="outformat">应用所需的格式</param>
            /// <returns></returns>
            [DllImport("CQP.DLL")]
            public static extern string CQ_getRecord(int authCode, string file, string outformat);

            /// <summary>
            ///     取陌生人(支持缓存)
            /// </summary>
            /// <param name="authCode"></param>
            /// <param name="qqId">目标QQ</param>
            /// <param name="ache">是否缓存</param>
            /// <returns></returns>
            [DllImport("CQP.DLL")]
            public static extern string CQ_getStrangerInfo(int authCode, long qqId, bool ache);


            /// <summary>
            ///     退出讨论组
            /// </summary>
            /// <param name="authCode"></param>
            /// <param name="discussId">目标讨论组</param>
            /// <returns></returns>
            [DllImport("CQP.DLL")]
            public static extern int CQ_setDiscussLeave(int authCode, long discussId);

            /// <summary>
            ///     致命错误提示
            /// </summary>
            /// <param name="authCode"></param>
            /// <param name="errorText">错误信息</param>
            /// <returns></returns>
            [DllImport("CQP.DLL")]
            public static extern int CQ_setFatal(int authCode, string errorText);

            /// <summary>
            ///     好友添加请求
            /// </summary>
            /// <param name="authCode"></param>
            /// <param name="requestReturn">请求事件收到的“反馈标识”参数</param>
            /// <param name="returnType">#请求_通过 或 #请求_拒绝</param>
            /// <param name="remark">添加后的好友备注</param>
            /// <returns></returns>
            [DllImport("CQP.DLL")]
            public static extern int CQ_setFriendAddRequest(int authCode, string requestReturn, int returnType,
                string remark);

            /// <summary>
            ///     群添加请求
            /// </summary>
            /// <param name="authCode"></param>
            /// <param name="requestReturn">请求事件收到的“反馈标识”参数</param>
            /// <param name="requestType">根据请求事件的子类型区分 #请求_群添加 或 #请求_群邀请</param>
            /// <param name="returnType">#请求_通过 或 #请求_拒绝</param>
            /// <returns></returns>
            [DllImport("CQP.DLL")]
            public static extern int CQ_setGroupAddRequest(int authCode, string requestReturn, int requestType,
                int returnType);

            /// <summary>
            ///     群添加请求
            /// </summary>
            /// <param name="authCode"></param>
            /// <param name="requestReturn">请求事件收到的“反馈标识”参数</param>
            /// <param name="requestType">根据请求事件的子类型区分 #请求_群添加 或 #请求_群邀请</param>
            /// <param name="returnType">#请求_通过 或 #请求_拒绝</param>
            /// <param name="reason">操作理由，仅 #请求_群添加 且 #请求_拒绝 时可用</param>
            /// <returns></returns>
            [DllImport("CQP.DLL")]
            public static extern int CQ_setGroupAddRequest2(int authCode, string requestReturn, int requestType,
                int returnType, string reason);

            /// <summary>
            ///     设置群管理员
            /// </summary>
            /// <param name="authCode"></param>
            /// <param name="groupId">目标群</param>
            /// <param name="qqId">目标QQ</param>
            /// <param name="manager">true/设置管理员 false/取消管理员</param>
            /// <returns></returns>
            [DllImport("CQP.DLL")]
            public static extern int CQ_setGroupAdmin(int authCode, long groupId, long qqId, bool manager);

            /// <summary>
            ///     群匿名设置
            /// </summary>
            /// <param name="authCode"></param>
            /// <param name="groupId">目标群</param>
            /// <param name="anonymous">true开启.false关闭</param>
            /// <returns></returns>
            [DllImport("CQP.DLL")]
            public static extern int CQ_setGroupAnonymous(int authCode, long groupId, bool anonymous);

            /// <summary>
            ///     禁言匿名群员
            /// </summary>
            /// <param name="authCode"></param>
            /// <param name="groupId">目标群</param>
            /// <param name="fromAnonymous">群消息事件收到的“fromAnonymous”参数</param>
            /// <param name="time">禁言的时间，单位为秒。不支持解禁</param>
            /// <returns></returns>
            [DllImport("CQP.DLL")]
            public static extern int CQ_setGroupAnonymousBan(int authCode, long groupId, string fromAnonymous,
                long time);

            /// <summary>
            ///     禁言群员
            /// </summary>
            /// <param name="authCode"></param>
            /// <param name="groupId">目标群</param>
            /// <param name="qqId">目标QQ</param>
            /// <param name="time">禁言的时间，单位为秒。如果要解禁，这里填写0</param>
            /// <returns></returns>
            [DllImport("CQP.DLL")]
            public static extern int CQ_setGroupBan(int authCode, long groupId, long qqId, long time);

            /// <summary>
            ///     设置群成员名片
            /// </summary>
            /// <param name="authCode"></param>
            /// <param name="groupId">目标群</param>
            /// <param name="qqId">目标QQ</param>
            /// <param name="newCard">新名片</param>
            /// <returns></returns>
            [DllImport("CQP.DLL")]
            public static extern int CQ_setGroupCard(int authCode, long groupId, long qqId, string newCard);

            /// <summary>
            ///     踢出群员
            /// </summary>
            /// <param name="authCode"></param>
            /// <param name="groupId">目标群</param>
            /// <param name="qqId">目标QQ</param>
            /// <param name="refused">如果为真，则“不再接收此人加群申请”</param>
            /// <returns></returns>
            [DllImport("CQP.DLL")]
            public static extern int CQ_setGroupKick(int authCode, long groupId, long qqId, bool refused);

            /// <summary>
            ///     退出群
            /// </summary>
            /// <param name="authCode"></param>
            /// <param name="groupId">目标群</param>
            /// <param name="disband">true解散本群(群主),false退出本群(管理、群成员)</param>
            /// <returns></returns>
            [DllImport("CQP.DLL")]
            public static extern int CQ_setGroupLeave(int authCode, long groupId, bool disband);

            /// <summary>
            ///     设置群成员专属头衔
            /// </summary>
            /// <param name="authCode"></param>
            /// <param name="groupId">目标群</param>
            /// <param name="qqId">目标QQ</param>
            /// <param name="specialTitle">专属头衔,如果要删除，这里填空</param>
            /// <param name="time">专属头衔有效期，单位为秒。如果永久有效，这里填写-1</param>
            /// <returns></returns>
            [DllImport("CQP.DLL")]
            public static extern int CQ_setGroupSpecialTitle(int authCode, long groupId, long qqId, string specialTitle,
                long time);

            /// <summary>
            ///     全群禁言
            /// </summary>
            /// <param name="authCode"></param>
            /// <param name="groupId">目标群</param>
            /// <param name="open">true开启,false关闭</param>
            /// <returns></returns>
            [DllImport("CQP.DLL")]
            public static extern int CQ_setGroupWholeBan(int authCode, long groupId, bool open);
        }
    }
}