using System.ComponentModel;
using System.Runtime.InteropServices;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CQP.Native
{
    public class CqpApi : ICqpApi
    {
	    /// <summary>
	    ///     发送好友消息
	    /// </summary>
	    /// <param name="AuthCode"></param>
	    /// <param name="QQID">目标QQ</param>
	    /// <param name="msg">消息内容</param>
	    /// <returns></returns>
	    int ICqpApi.CQ_sendPrivateMsg([Description("")] int AuthCode, [Description("目标QQ")] long QQID,
            [Description("消息内容")] string msg)
        {
            return NativeMethods.CQ_sendPrivateMsg(AuthCode, QQID, msg);
        }

	    /// <summary>
	    ///     发送群消息
	    /// </summary>
	    /// <param name="AuthCode"></param>
	    /// <param name="群号">目标群</param>
	    /// <param name="msg">消息内容</param>
	    /// <returns></returns>
	    int ICqpApi.CQ_sendGroupMsg([Description("")] int AuthCode, [Description("目标群")] long 群号,
            [Description("消息内容")] string msg)
        {
            return NativeMethods.CQ_sendGroupMsg(AuthCode, 群号, msg);
        }

	    /// <summary>
	    ///     发送讨论组消息
	    /// </summary>
	    /// <param name="AuthCode"></param>
	    /// <param name="讨论组号">目标讨论组</param>
	    /// <param name="msg">消息内容</param>
	    /// <returns></returns>
	    int ICqpApi.CQ_sendDiscussMsg([Description("")] int AuthCode, [Description("目标讨论组")] long 讨论组号,
            [Description("消息内容")] string msg)
        {
            return NativeMethods.CQ_sendDiscussMsg(AuthCode, 讨论组号, msg);
        }

	    /// <summary>
	    ///     撤回消息
	    /// </summary>
	    /// <param name="AuthCode"></param>
	    /// <param name="MsgId">消息ID</param>
	    /// <returns></returns>
	    int ICqpApi.CQ_deleteMsg([Description("")] int AuthCode, [Description("消息ID")] long MsgId)
        {
            return NativeMethods.CQ_deleteMsg(AuthCode, MsgId);
        }

	    /// <summary>
	    ///     发送赞
	    /// </summary>
	    /// <param name="AuthCode"></param>
	    /// <param name="QQID">目标QQ</param>
	    /// <param name="times">赞的次数，最多10次</param>
	    /// <returns></returns>
	    int ICqpApi.CQ_sendLikeV2([Description("")] int AuthCode, [Description("目标QQ")] long QQID,
            [Description("赞的次数，最多10次")] int times)
        {
            return NativeMethods.CQ_sendLikeV2(AuthCode, QQID, times);
        }

	    /// <summary>
	    ///     取Cookies(慎用
	    /// </summary>
	    /// <param name="AuthCode"></param>
	    /// <returns></returns>
	    string ICqpApi.CQ_getCookies([Description("")] int AuthCode)
        {
            return NativeMethods.CQ_getCookies(AuthCode);
        }

	    /// <summary>
	    ///     接收语音
	    /// </summary>
	    /// <param name="AuthCode"></param>
	    /// <param name="file">收到消息中的语音文件名(file)</param>
	    /// <param name="outformat">应用所需的格式</param>
	    /// <returns></returns>
	    string ICqpApi.CQ_getRecord([Description("")] int AuthCode, [Description("收到消息中的语音文件名(file)")] string file,
            [Description("应用所需的格式")] string outformat)
        {
            return NativeMethods.CQ_getRecord(AuthCode, file, outformat);
        }

	    /// <summary>
	    ///     取CsrfToken(慎用
	    /// </summary>
	    /// <param name="AuthCode"></param>
	    /// <returns></returns>
	    int ICqpApi.CQ_getCsrfToken([Description("")] int AuthCode)
        {
            return NativeMethods.CQ_getCsrfToken(AuthCode);
        }

	    /// <summary>
	    ///     取应用目录
	    /// </summary>
	    /// <param name="AuthCode"></param>
	    /// <returns></returns>
	    string ICqpApi.CQ_getAppDirectory([Description("")] int AuthCode)
        {
            return NativeMethods.CQ_getAppDirectory(AuthCode);
        }

	    /// <summary>
	    ///     取登录QQ
	    /// </summary>
	    /// <param name="AuthCode"></param>
	    /// <returns></returns>
	    long ICqpApi.CQ_getLoginQQ([Description("")] int AuthCode)
        {
            return NativeMethods.CQ_getLoginQQ(AuthCode);
        }

	    /// <summary>
	    ///     取登录昵称
	    /// </summary>
	    /// <param name="AuthCode"></param>
	    /// <returns></returns>
	    string ICqpApi.CQ_getLoginNick([Description("")] int AuthCode)
        {
            return NativeMethods.CQ_getLoginNick(AuthCode);
        }

	    /// <summary>
	    ///     置群员移除
	    /// </summary>
	    /// <param name="AuthCode"></param>
	    /// <param name="群号">目标群</param>
	    /// <param name="QQID">目标QQ</param>
	    /// <param name="拒绝再加群">如果为真，则“不再接收此人加群申请”，请慎用</param>
	    /// <returns></returns>
	    int ICqpApi.CQ_setGroupKick([Description("")] int AuthCode, [Description("目标群")] long 群号,
            [Description("目标QQ")] long QQID, [Description("如果为真，则“不再接收此人加群申请”，请慎用")]
            bool 拒绝再加群)
        {
            return NativeMethods.CQ_setGroupKick(AuthCode, 群号, QQID, 拒绝再加群);
        }

	    /// <summary>
	    ///     置群员禁言
	    /// </summary>
	    /// <param name="AuthCode"></param>
	    /// <param name="群号">目标群</param>
	    /// <param name="QQID">目标QQ</param>
	    /// <param name="禁言时间">禁言的时间，单位为秒。如果要解禁，这里填写0</param>
	    /// <returns></returns>
	    int ICqpApi.CQ_setGroupBan([Description("")] int AuthCode, [Description("目标群")] long 群号,
            [Description("目标QQ")] long QQID, [Description("禁言的时间，单位为秒。如果要解禁，这里填写0")]
            long 禁言时间)
        {
            return NativeMethods.CQ_setGroupBan(AuthCode, 群号, QQID, 禁言时间);
        }

	    /// <summary>
	    ///     置群管理员
	    /// </summary>
	    /// <param name="AuthCode"></param>
	    /// <param name="群号">目标群</param>
	    /// <param name="QQID">被设置的QQ</param>
	    /// <param name="成为管理员">真/设置管理员 假/取消管理员</param>
	    /// <returns></returns>
	    int ICqpApi.CQ_setGroupAdmin([Description("")] int AuthCode, [Description("目标群")] long 群号,
            [Description("被设置的QQ")] long QQID, [Description("真/设置管理员 假/取消管理员")] bool 成为管理员)
        {
            return NativeMethods.CQ_setGroupAdmin(AuthCode, 群号, QQID, 成为管理员);
        }

	    /// <summary>
	    ///     置群成员专属头衔
	    /// </summary>
	    /// <param name="AuthCode"></param>
	    /// <param name="群号">目标群</param>
	    /// <param name="QQID">目标QQ</param>
	    /// <param name="头衔">如果要删除，这里填空</param>
	    /// <param name="过期时间">专属头衔有效期，单位为秒。如果永久有效，这里填写-1</param>
	    /// <returns></returns>
	    int ICqpApi.CQ_setGroupSpecialTitle([Description("")] int AuthCode, [Description("目标群")] long 群号,
            [Description("目标QQ")] long QQID, [Description("如果要删除，这里填空")] string 头衔,
            [Description("专属头衔有效期，单位为秒。如果永久有效，这里填写-1")]
            long 过期时间)
        {
            return NativeMethods.CQ_setGroupSpecialTitle(AuthCode, 群号, QQID, 头衔, 过期时间);
        }

	    /// <summary>
	    ///     置全群禁言
	    /// </summary>
	    /// <param name="AuthCode"></param>
	    /// <param name="群号">目标群</param>
	    /// <param name="开启禁言">真/开启 假/关闭</param>
	    /// <returns></returns>
	    int ICqpApi.CQ_setGroupWholeBan([Description("")] int AuthCode, [Description("目标群")] long 群号,
            [Description("真/开启 假/关闭")] bool 开启禁言)
        {
            return NativeMethods.CQ_setGroupWholeBan(AuthCode, 群号, 开启禁言);
        }

	    /// <summary>
	    ///     置匿名群员禁言
	    /// </summary>
	    /// <param name="AuthCode"></param>
	    /// <param name="群号">目标群</param>
	    /// <param name="匿名">群消息事件收到的“匿名”参数</param>
	    /// <param name="禁言时间">禁言的时间，单位为秒。不支持解禁</param>
	    /// <returns></returns>
	    int ICqpApi.CQ_setGroupAnonymousBan([Description("")] int AuthCode, [Description("目标群")] long 群号,
            [Description("群消息事件收到的“匿名”参数")] string 匿名, [Description("禁言的时间，单位为秒。不支持解禁")] long 禁言时间)
        {
            return NativeMethods.CQ_setGroupAnonymousBan(AuthCode, 群号, 匿名, 禁言时间);
        }

	    /// <summary>
	    ///     置群匿名设置
	    /// </summary>
	    /// <param name="AuthCode"></param>
	    /// <param name="群号"></param>
	    /// <param name="开启匿名"></param>
	    /// <returns></returns>
	    int ICqpApi.CQ_setGroupAnonymous([Description("")] int AuthCode, [Description("")] long 群号,
            [Description("")] bool 开启匿名)
        {
            return NativeMethods.CQ_setGroupAnonymous(AuthCode, 群号, 开启匿名);
        }

	    /// <summary>
	    ///     置群成员名片
	    /// </summary>
	    /// <param name="AuthCode"></param>
	    /// <param name="群号">目标群</param>
	    /// <param name="QQID">被设置的QQ</param>
	    /// <param name="新名片_昵称"></param>
	    /// <returns></returns>
	    int ICqpApi.CQ_setGroupCard([Description("")] int AuthCode, [Description("目标群")] long 群号,
            [Description("被设置的QQ")] long QQID, [Description("")] string 新名片_昵称)
        {
            return NativeMethods.CQ_setGroupCard(AuthCode, 群号, QQID, 新名片_昵称);
        }

	    /// <summary>
	    ///     置群退出
	    /// </summary>
	    /// <param name="AuthCode"></param>
	    /// <param name="群号">目标群</param>
	    /// <param name="是否解散">真/解散本群(群主) 假/退出本群(管理、群成员)</param>
	    /// <returns></returns>
	    int ICqpApi.CQ_setGroupLeave([Description("")] int AuthCode, [Description("目标群")] long 群号,
            [Description("真/解散本群(群主) 假/退出本群(管理、群成员)")]
            bool 是否解散)
        {
            return NativeMethods.CQ_setGroupLeave(AuthCode, 群号, 是否解散);
        }

	    /// <summary>
	    ///     置讨论组退出
	    /// </summary>
	    /// <param name="AuthCode"></param>
	    /// <param name="讨论组号">目标讨论组</param>
	    /// <returns></returns>
	    int ICqpApi.CQ_setDiscussLeave([Description("")] int AuthCode, [Description("目标讨论组")] long 讨论组号)
        {
            return NativeMethods.CQ_setDiscussLeave(AuthCode, 讨论组号);
        }

	    /// <summary>
	    ///     置好友添加请求
	    /// </summary>
	    /// <param name="AuthCode"></param>
	    /// <param name="请求反馈标识">请求事件收到的“反馈标识”参数</param>
	    /// <param name="反馈类型">#请求_通过 或 #请求_拒绝</param>
	    /// <param name="备注">添加后的好友备注</param>
	    /// <returns></returns>
	    int ICqpApi.CQ_setFriendAddRequest([Description("")] int AuthCode,
            [Description("请求事件收到的“反馈标识”参数")] string 请求反馈标识, [Description("#请求_通过 或 #请求_拒绝")] int 反馈类型,
            [Description("添加后的好友备注")] string 备注)
        {
            return NativeMethods.CQ_setFriendAddRequest(AuthCode, 请求反馈标识, 反馈类型, 备注);
        }

	    /// <summary>
	    ///     置群添加请求
	    /// </summary>
	    /// <param name="AuthCode"></param>
	    /// <param name="请求反馈标识">请求事件收到的“反馈标识”参数</param>
	    /// <param name="请求类型">根据请求事件的子类型区分 #请求_群添加 或 #请求_群邀请</param>
	    /// <param name="反馈类型">#请求_通过 或 #请求_拒绝</param>
	    /// <param name="理由">操作理由，仅 #请求_群添加 且 #请求_拒绝 时可用</param>
	    /// <returns></returns>
	    int ICqpApi.CQ_setGroupAddRequestV2([Description("")] int AuthCode,
            [Description("请求事件收到的“反馈标识”参数")] string 请求反馈标识, [Description("根据请求事件的子类型区分 #请求_群添加 或 #请求_群邀请")]
            int 请求类型, [Description("#请求_通过 或 #请求_拒绝")] int 反馈类型, [Description("操作理由，仅 #请求_群添加 且 #请求_拒绝 时可用")]
            string 理由)
        {
            return NativeMethods.CQ_setGroupAddRequestV2(AuthCode, 请求反馈标识, 请求类型, 反馈类型, 理由);
        }

	    /// <summary>
	    ///     增加运行日志
	    /// </summary>
	    /// <param name="AuthCode"></param>
	    /// <param name="优先级">#Log_ 开头常量</param>
	    /// <param name="类型"></param>
	    /// <param name="内容"></param>
	    /// <returns></returns>
	    int ICqpApi.CQ_addLog([Description("")] int AuthCode, [Description("#Log_ 开头常量")] int 优先级,
            [Description("")] string 类型, [Description("")] string 内容)
        {
            return NativeMethods.CQ_addLog(AuthCode, 优先级, 类型, 内容);
        }

	    /// <summary>
	    ///     置致命错误提示
	    /// </summary>
	    /// <param name="AuthCode"></param>
	    /// <param name="错误信息"></param>
	    /// <returns></returns>
	    int ICqpApi.CQ_setFatal([Description("")] int AuthCode, [Description("")] string 错误信息)
        {
            return NativeMethods.CQ_setFatal(AuthCode, 错误信息);
        }

	    /// <summary>
	    ///     取群成员信息(支持缓存)
	    /// </summary>
	    /// <param name="AuthCode"></param>
	    /// <param name="群号">目标QQ所在群</param>
	    /// <param name="QQID">目标QQ</param>
	    /// <param name="不使用缓存"></param>
	    /// <returns></returns>
	    string ICqpApi.CQ_getGroupMemberInfoV2([Description("")] int AuthCode, [Description("目标QQ所在群")] long 群号,
            [Description("目标QQ")] long QQID, [Description("")] bool 不使用缓存)
        {
            return NativeMethods.CQ_getGroupMemberInfoV2(AuthCode, 群号, QQID, 不使用缓存);
        }

	    /// <summary>
	    ///     取群成员列表
	    /// </summary>
	    /// <param name="AuthCode"></param>
	    /// <param name="群号">目标QQ所在群</param>
	    /// <returns></returns>
	    string ICqpApi.CQ_getGroupMemberList([Description("")] int AuthCode, [Description("目标QQ所在群")] long 群号)
        {
            return NativeMethods.CQ_getGroupMemberList(AuthCode, 群号);
        }

	    /// <summary>
	    ///     取群列表
	    /// </summary>
	    /// <param name="AuthCode"></param>
	    /// <returns></returns>
	    string ICqpApi.CQ_getGroupList([Description("")] int AuthCode)
        {
            return NativeMethods.CQ_getGroupList(AuthCode);
        }

	    /// <summary>
	    ///     取陌生人信息(支持缓存)
	    /// </summary>
	    /// <param name="AuthCode"></param>
	    /// <param name="QQID">目标QQ</param>
	    /// <param name="不使用缓存"></param>
	    /// <returns></returns>
	    string ICqpApi.CQ_getStrangerInfo([Description("")] int AuthCode, [Description("目标QQ")] long QQID,
            [Description("")] bool 不使用缓存)
        {
            return NativeMethods.CQ_getStrangerInfo(AuthCode, QQID, 不使用缓存);
        }

        private static class NativeMethods
        {
	        /// <summary>
	        ///     发送好友消息
	        /// </summary>
	        /// <param name="AuthCode"></param>
	        /// <param name="QQID">目标QQ</param>
	        /// <param name="msg">消息内容</param>
	        /// <returns></returns>
	        [DllImport("CQP.dll")]
            public static extern int CQ_sendPrivateMsg([Description("")] int AuthCode, [Description("目标QQ")] long QQID,
                [Description("消息内容")] string msg);

	        /// <summary>
	        ///     发送群消息
	        /// </summary>
	        /// <param name="AuthCode"></param>
	        /// <param name="群号">目标群</param>
	        /// <param name="msg">消息内容</param>
	        /// <returns></returns>
	        [DllImport("CQP.dll")]
            public static extern int CQ_sendGroupMsg([Description("")] int AuthCode, [Description("目标群")] long 群号,
                [Description("消息内容")] string msg);

	        /// <summary>
	        ///     发送讨论组消息
	        /// </summary>
	        /// <param name="AuthCode"></param>
	        /// <param name="讨论组号">目标讨论组</param>
	        /// <param name="msg">消息内容</param>
	        /// <returns></returns>
	        [DllImport("CQP.dll")]
            public static extern int CQ_sendDiscussMsg([Description("")] int AuthCode, [Description("目标讨论组")] long 讨论组号,
                [Description("消息内容")] string msg);

	        /// <summary>
	        ///     撤回消息
	        /// </summary>
	        /// <param name="AuthCode"></param>
	        /// <param name="MsgId">消息ID</param>
	        /// <returns></returns>
	        [DllImport("CQP.dll")]
            public static extern int CQ_deleteMsg([Description("")] int AuthCode, [Description("消息ID")] long MsgId);

	        /// <summary>
	        ///     发送赞
	        /// </summary>
	        /// <param name="AuthCode"></param>
	        /// <param name="QQID">目标QQ</param>
	        /// <param name="times">赞的次数，最多10次</param>
	        /// <returns></returns>
	        [DllImport("CQP.dll")]
            public static extern int CQ_sendLikeV2([Description("")] int AuthCode, [Description("目标QQ")] long QQID,
                [Description("赞的次数，最多10次")] int times);

	        /// <summary>
	        ///     取Cookies(慎用
	        /// </summary>
	        /// <param name="AuthCode"></param>
	        /// <returns></returns>
	        [DllImport("CQP.dll")]
            public static extern string CQ_getCookies([Description("")] int AuthCode);

	        /// <summary>
	        ///     接收语音
	        /// </summary>
	        /// <param name="AuthCode"></param>
	        /// <param name="file">收到消息中的语音文件名(file)</param>
	        /// <param name="outformat">应用所需的格式</param>
	        /// <returns></returns>
	        [DllImport("CQP.dll")]
            public static extern string CQ_getRecord([Description("")] int AuthCode,
                [Description("收到消息中的语音文件名(file)")] string file, [Description("应用所需的格式")] string outformat);

	        /// <summary>
	        ///     取CsrfToken(慎用
	        /// </summary>
	        /// <param name="AuthCode"></param>
	        /// <returns></returns>
	        [DllImport("CQP.dll")]
            public static extern int CQ_getCsrfToken([Description("")] int AuthCode);

	        /// <summary>
	        ///     取应用目录
	        /// </summary>
	        /// <param name="AuthCode"></param>
	        /// <returns></returns>
	        [DllImport("CQP.dll")]
            public static extern string CQ_getAppDirectory([Description("")] int AuthCode);

	        /// <summary>
	        ///     取登录QQ
	        /// </summary>
	        /// <param name="AuthCode"></param>
	        /// <returns></returns>
	        [DllImport("CQP.dll")]
            public static extern long CQ_getLoginQQ([Description("")] int AuthCode);

	        /// <summary>
	        ///     取登录昵称
	        /// </summary>
	        /// <param name="AuthCode"></param>
	        /// <returns></returns>
	        [DllImport("CQP.dll")]
            public static extern string CQ_getLoginNick([Description("")] int AuthCode);

	        /// <summary>
	        ///     置群员移除
	        /// </summary>
	        /// <param name="AuthCode"></param>
	        /// <param name="群号">目标群</param>
	        /// <param name="QQID">目标QQ</param>
	        /// <param name="拒绝再加群">如果为真，则“不再接收此人加群申请”，请慎用</param>
	        /// <returns></returns>
	        [DllImport("CQP.dll")]
            public static extern int CQ_setGroupKick([Description("")] int AuthCode, [Description("目标群")] long 群号,
                [Description("目标QQ")] long QQID, [Description("如果为真，则“不再接收此人加群申请”，请慎用")]
                bool 拒绝再加群);

	        /// <summary>
	        ///     置群员禁言
	        /// </summary>
	        /// <param name="AuthCode"></param>
	        /// <param name="群号">目标群</param>
	        /// <param name="QQID">目标QQ</param>
	        /// <param name="禁言时间">禁言的时间，单位为秒。如果要解禁，这里填写0</param>
	        /// <returns></returns>
	        [DllImport("CQP.dll")]
            public static extern int CQ_setGroupBan([Description("")] int AuthCode, [Description("目标群")] long 群号,
                [Description("目标QQ")] long QQID, [Description("禁言的时间，单位为秒。如果要解禁，这里填写0")]
                long 禁言时间);

	        /// <summary>
	        ///     置群管理员
	        /// </summary>
	        /// <param name="AuthCode"></param>
	        /// <param name="群号">目标群</param>
	        /// <param name="QQID">被设置的QQ</param>
	        /// <param name="成为管理员">真/设置管理员 假/取消管理员</param>
	        /// <returns></returns>
	        [DllImport("CQP.dll")]
            public static extern int CQ_setGroupAdmin([Description("")] int AuthCode, [Description("目标群")] long 群号,
                [Description("被设置的QQ")] long QQID, [Description("真/设置管理员 假/取消管理员")] bool 成为管理员);

	        /// <summary>
	        ///     置群成员专属头衔
	        /// </summary>
	        /// <param name="AuthCode"></param>
	        /// <param name="群号">目标群</param>
	        /// <param name="QQID">目标QQ</param>
	        /// <param name="头衔">如果要删除，这里填空</param>
	        /// <param name="过期时间">专属头衔有效期，单位为秒。如果永久有效，这里填写-1</param>
	        /// <returns></returns>
	        [DllImport("CQP.dll")]
            public static extern int CQ_setGroupSpecialTitle([Description("")] int AuthCode,
                [Description("目标群")] long 群号, [Description("目标QQ")] long QQID, [Description("如果要删除，这里填空")] string 头衔,
                [Description("专属头衔有效期，单位为秒。如果永久有效，这里填写-1")]
                long 过期时间);

	        /// <summary>
	        ///     置全群禁言
	        /// </summary>
	        /// <param name="AuthCode"></param>
	        /// <param name="群号">目标群</param>
	        /// <param name="开启禁言">真/开启 假/关闭</param>
	        /// <returns></returns>
	        [DllImport("CQP.dll")]
            public static extern int CQ_setGroupWholeBan([Description("")] int AuthCode, [Description("目标群")] long 群号,
                [Description("真/开启 假/关闭")] bool 开启禁言);

	        /// <summary>
	        ///     置匿名群员禁言
	        /// </summary>
	        /// <param name="AuthCode"></param>
	        /// <param name="群号">目标群</param>
	        /// <param name="匿名">群消息事件收到的“匿名”参数</param>
	        /// <param name="禁言时间">禁言的时间，单位为秒。不支持解禁</param>
	        /// <returns></returns>
	        [DllImport("CQP.dll")]
            public static extern int CQ_setGroupAnonymousBan([Description("")] int AuthCode,
                [Description("目标群")] long 群号, [Description("群消息事件收到的“匿名”参数")] string 匿名,
                [Description("禁言的时间，单位为秒。不支持解禁")] long 禁言时间);

	        /// <summary>
	        ///     置群匿名设置
	        /// </summary>
	        /// <param name="AuthCode"></param>
	        /// <param name="群号"></param>
	        /// <param name="开启匿名"></param>
	        /// <returns></returns>
	        [DllImport("CQP.dll")]
            public static extern int CQ_setGroupAnonymous([Description("")] int AuthCode, [Description("")] long 群号,
                [Description("")] bool 开启匿名);

	        /// <summary>
	        ///     置群成员名片
	        /// </summary>
	        /// <param name="AuthCode"></param>
	        /// <param name="群号">目标群</param>
	        /// <param name="QQID">被设置的QQ</param>
	        /// <param name="新名片_昵称"></param>
	        /// <returns></returns>
	        [DllImport("CQP.dll")]
            public static extern int CQ_setGroupCard([Description("")] int AuthCode, [Description("目标群")] long 群号,
                [Description("被设置的QQ")] long QQID, [Description("")] string 新名片_昵称);

	        /// <summary>
	        ///     置群退出
	        /// </summary>
	        /// <param name="AuthCode"></param>
	        /// <param name="群号">目标群</param>
	        /// <param name="是否解散">真/解散本群(群主) 假/退出本群(管理、群成员)</param>
	        /// <returns></returns>
	        [DllImport("CQP.dll")]
            public static extern int CQ_setGroupLeave([Description("")] int AuthCode, [Description("目标群")] long 群号,
                [Description("真/解散本群(群主) 假/退出本群(管理、群成员)")]
                bool 是否解散);

	        /// <summary>
	        ///     置讨论组退出
	        /// </summary>
	        /// <param name="AuthCode"></param>
	        /// <param name="讨论组号">目标讨论组</param>
	        /// <returns></returns>
	        [DllImport("CQP.dll")]
            public static extern int CQ_setDiscussLeave([Description("")] int AuthCode,
                [Description("目标讨论组")] long 讨论组号);

	        /// <summary>
	        ///     置好友添加请求
	        /// </summary>
	        /// <param name="AuthCode"></param>
	        /// <param name="请求反馈标识">请求事件收到的“反馈标识”参数</param>
	        /// <param name="反馈类型">#请求_通过 或 #请求_拒绝</param>
	        /// <param name="备注">添加后的好友备注</param>
	        /// <returns></returns>
	        [DllImport("CQP.dll")]
            public static extern int CQ_setFriendAddRequest([Description("")] int AuthCode,
                [Description("请求事件收到的“反馈标识”参数")] string 请求反馈标识, [Description("#请求_通过 或 #请求_拒绝")] int 反馈类型,
                [Description("添加后的好友备注")] string 备注);

	        /// <summary>
	        ///     置群添加请求
	        /// </summary>
	        /// <param name="AuthCode"></param>
	        /// <param name="请求反馈标识">请求事件收到的“反馈标识”参数</param>
	        /// <param name="请求类型">根据请求事件的子类型区分 #请求_群添加 或 #请求_群邀请</param>
	        /// <param name="反馈类型">#请求_通过 或 #请求_拒绝</param>
	        /// <param name="理由">操作理由，仅 #请求_群添加 且 #请求_拒绝 时可用</param>
	        /// <returns></returns>
	        [DllImport("CQP.dll")]
            public static extern int CQ_setGroupAddRequestV2([Description("")] int AuthCode,
                [Description("请求事件收到的“反馈标识”参数")] string 请求反馈标识, [Description("根据请求事件的子类型区分 #请求_群添加 或 #请求_群邀请")]
                int 请求类型, [Description("#请求_通过 或 #请求_拒绝")] int 反馈类型, [Description("操作理由，仅 #请求_群添加 且 #请求_拒绝 时可用")]
                string 理由);

	        /// <summary>
	        ///     增加运行日志
	        /// </summary>
	        /// <param name="AuthCode"></param>
	        /// <param name="优先级">#Log_ 开头常量</param>
	        /// <param name="类型"></param>
	        /// <param name="内容"></param>
	        /// <returns></returns>
	        [DllImport("CQP.dll")]
            public static extern int CQ_addLog([Description("")] int AuthCode, [Description("#Log_ 开头常量")] int 优先级,
                [Description("")] string 类型, [Description("")] string 内容);

	        /// <summary>
	        ///     置致命错误提示
	        /// </summary>
	        /// <param name="AuthCode"></param>
	        /// <param name="错误信息"></param>
	        /// <returns></returns>
	        [DllImport("CQP.dll")]
            public static extern int CQ_setFatal([Description("")] int AuthCode, [Description("")] string 错误信息);

	        /// <summary>
	        ///     取群成员信息(支持缓存)
	        /// </summary>
	        /// <param name="AuthCode"></param>
	        /// <param name="群号">目标QQ所在群</param>
	        /// <param name="QQID">目标QQ</param>
	        /// <param name="不使用缓存"></param>
	        /// <returns></returns>
	        [DllImport("CQP.dll")]
            public static extern string CQ_getGroupMemberInfoV2([Description("")] int AuthCode,
                [Description("目标QQ所在群")] long 群号, [Description("目标QQ")] long QQID, [Description("")] bool 不使用缓存);

	        /// <summary>
	        ///     取群成员列表
	        /// </summary>
	        /// <param name="AuthCode"></param>
	        /// <param name="群号">目标QQ所在群</param>
	        /// <returns></returns>
	        [DllImport("CQP.dll")]
            public static extern string CQ_getGroupMemberList([Description("")] int AuthCode,
                [Description("目标QQ所在群")] long 群号);

	        /// <summary>
	        ///     取群列表
	        /// </summary>
	        /// <param name="AuthCode"></param>
	        /// <returns></returns>
	        [DllImport("CQP.dll")]
            public static extern string CQ_getGroupList([Description("")] int AuthCode);

	        /// <summary>
	        ///     取陌生人信息(支持缓存)
	        /// </summary>
	        /// <param name="AuthCode"></param>
	        /// <param name="QQID">目标QQ</param>
	        /// <param name="不使用缓存"></param>
	        /// <returns></returns>
	        [DllImport("CQP.dll")]
            public static extern string CQ_getStrangerInfo([Description("")] int AuthCode,
                [Description("目标QQ")] long QQID, [Description("")] bool 不使用缓存);

	        /// <summary>
	        /// </summary>
	        /// <param name="pszString">址</param>
	        /// <param name="cchString">址</param>
	        /// <param name="dwFlags"></param>
	        /// <param name="pbBinary"></param>
	        /// <param name="pcbBinary">址</param>
	        /// <param name="pdwSkip">0</param>
	        /// <param name="pdwFlags">0</param>
	        /// <returns></returns>
	        [DllImport("CQP.dll")]
            public static extern bool CryptStringToBinaryA([Description("址")] string pszString,
                [Description("址")] int cchString, [Description("")] int dwFlags, [Description("")] int pbBinary,
                [Description("址")] int pcbBinary, [Description("0")] int pdwSkip, [Description("0")] int pdwFlags);

	        /// <summary>
	        /// </summary>
	        /// <param name="pszString">址</param>
	        /// <param name="cchString">址</param>
	        /// <param name="dwFlags"></param>
	        /// <param name="pbBinary">址</param>
	        /// <param name="pcbBinary">址</param>
	        /// <param name="pdwSkip">0</param>
	        /// <param name="pdwFlags">0</param>
	        /// <returns></returns>
	        [DllImport("CQP.dll")]
            public static extern bool CryptStringToBinaryA([Description("址")] string pszString,
                [Description("址")] int cchString, [Description("")] int dwFlags, [Description("址")] byte[] pbBinary,
                [Description("址")] int pcbBinary, [Description("0")] int pdwSkip, [Description("0")] int pdwFlags);
        }
    }
}