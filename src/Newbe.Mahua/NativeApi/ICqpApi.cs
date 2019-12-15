using System.ComponentModel;

namespace Newbe.Mahua.NativeApi
{
    // generate at 2019/12/15 12:07:28 +00:00
    public interface ICqpApi
    {
        /// <summary>
        /// 发送好友消息
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="Account">目标帐号</param>
        /// <param name="msg">消息内容</param>
        /// <returns></returns>
        [Description("发送好友消息")]
        int CQ_sendPrivateMsg([Description("")] int AuthCode, [Description("目标帐号")] long Account,
            [Description("消息内容")] string msg);

        /// <summary>
        /// 发送群消息
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="群号">目标群</param>
        /// <param name="msg">消息内容</param>
        /// <returns></returns>
        [Description("发送群消息")]
        int CQ_sendGroupMsg([Description("")] int AuthCode, [Description("目标群")] long 群号,
            [Description("消息内容")] string msg);

        /// <summary>
        /// 发送讨论组消息
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="讨论组号">目标讨论组</param>
        /// <param name="msg">消息内容</param>
        /// <returns></returns>
        [Description("发送讨论组消息")]
        int CQ_sendDiscussMsg([Description("")] int AuthCode, [Description("目标讨论组")] long 讨论组号,
            [Description("消息内容")] string msg);

        /// <summary>
        /// 撤回消息
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="MsgId">消息ID</param>
        /// <returns></returns>
        [Description("撤回消息")]
        int CQ_deleteMsg([Description("")] int AuthCode, [Description("消息ID")] long MsgId);

        /// <summary>
        /// 发送赞
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="Account">目标帐号</param>
        /// <param name="times">赞的次数，最多10次</param>
        /// <returns></returns>
        [Description("发送赞")]
        int CQ_sendLikeV2([Description("")] int AuthCode, [Description("目标帐号")] long Account,
            [Description("赞的次数，最多10次")] int times);

        /// <summary>
        /// 取Cookies(慎用
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="domain">目标域名，如 api.example.com</param>
        /// <returns></returns>
        [Description("取Cookies(慎用")]
        string CQ_getCookiesV2([Description("")] int AuthCode, [Description("目标域名，如 api.example.com")]
            string domain);

        /// <summary>
        /// 【已弃用】接收语音，并返回语音文件相对路径
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="file">收到消息中的语音文件名(file)</param>
        /// <param name="outformat">应用所需的格式</param>
        /// <returns></returns>
        [Description("【已弃用】接收语音，并返回语音文件相对路径")]
        string CQ_getRecord([Description("")] int AuthCode, [Description("收到消息中的语音文件名(file)")] string file,
            [Description("应用所需的格式")] string outformat);

        /// <summary>
        /// 接收语音，并返回语音文件绝对路径
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="file">收到消息中的语音文件名(file)</param>
        /// <param name="outformat">应用所需的格式</param>
        /// <returns></returns>
        [Description("接收语音，并返回语音文件绝对路径")]
        string CQ_getRecordV2([Description("")] int AuthCode, [Description("收到消息中的语音文件名(file)")] string file,
            [Description("应用所需的格式")] string outformat);

        /// <summary>
        /// 接收图片，并返回图片文件绝对路径
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="file">收到消息中的图片文件名(file)</param>
        /// <returns></returns>
        [Description("接收图片，并返回图片文件绝对路径")]
        string CQ_getImage([Description("")] int AuthCode, [Description("收到消息中的图片文件名(file)")] string file);

        /// <summary>
        /// 是否支持发送图片，返回大于 0 为支持，等于 0 为不支持
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        [Description("是否支持发送图片，返回大于 0 为支持，等于 0 为不支持")]
        int CQ_canSendImage([Description("")] int AuthCode);

        /// <summary>
        /// 是否支持发送语音，返回大于 0 为支持，等于 0 为不支持
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        [Description("是否支持发送语音，返回大于 0 为支持，等于 0 为不支持")]
        int CQ_canSendRecord([Description("")] int AuthCode);

        /// <summary>
        /// 取CsrfToken(慎用
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        [Description("取CsrfToken(慎用")]
        int CQ_getCsrfToken([Description("")] int AuthCode);

        /// <summary>
        /// 取应用目录
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        [Description("取应用目录")]
        string CQ_getAppDirectory([Description("")] int AuthCode);

        /// <summary>
        /// 取登录帐号
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        [Description("取登录帐号")]
        long CQ_getLoginQQ([Description("")] int AuthCode);

        /// <summary>
        /// 取登录昵称
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        [Description("取登录昵称")]
        string CQ_getLoginNick([Description("")] int AuthCode);

        /// <summary>
        /// 置群员移除
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="群号">目标群</param>
        /// <param name="Account">目标帐号</param>
        /// <param name="拒绝再加群">如果为真，则“不再接收此人加群申请”，请慎用</param>
        /// <returns></returns>
        [Description("置群员移除")]
        int CQ_setGroupKick([Description("")] int AuthCode, [Description("目标群")] long 群号,
            [Description("目标帐号")] long Account, [Description("如果为真，则“不再接收此人加群申请”，请慎用")]
            bool 拒绝再加群);

        /// <summary>
        /// 置群员禁言
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="群号">目标群</param>
        /// <param name="Account">目标帐号</param>
        /// <param name="禁言时间">禁言的时间，单位为秒。如果要解禁，这里填写0</param>
        /// <returns></returns>
        [Description("置群员禁言")]
        int CQ_setGroupBan([Description("")] int AuthCode, [Description("目标群")] long 群号,
            [Description("目标帐号")] long Account, [Description("禁言的时间，单位为秒。如果要解禁，这里填写0")]
            long 禁言时间);

        /// <summary>
        /// 置群管理员
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="群号">目标群</param>
        /// <param name="Account">被设置的帐号</param>
        /// <param name="成为管理员">真/设置管理员 假/取消管理员</param>
        /// <returns></returns>
        [Description("置群管理员")]
        int CQ_setGroupAdmin([Description("")] int AuthCode, [Description("目标群")] long 群号,
            [Description("被设置的帐号")] long Account, [Description("真/设置管理员 假/取消管理员")] bool 成为管理员);

        /// <summary>
        /// 置群成员专属头衔
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="群号">目标群</param>
        /// <param name="Account">目标帐号</param>
        /// <param name="头衔">如果要删除，这里填空</param>
        /// <param name="过期时间">专属头衔有效期，单位为秒。如果永久有效，这里填写-1</param>
        /// <returns></returns>
        [Description("置群成员专属头衔")]
        int CQ_setGroupSpecialTitle([Description("")] int AuthCode, [Description("目标群")] long 群号,
            [Description("目标帐号")] long Account, [Description("如果要删除，这里填空")] string 头衔,
            [Description("专属头衔有效期，单位为秒。如果永久有效，这里填写-1")]
            long 过期时间);

        /// <summary>
        /// 置全群禁言
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="群号">目标群</param>
        /// <param name="开启禁言">真/开启 假/关闭</param>
        /// <returns></returns>
        [Description("置全群禁言")]
        int CQ_setGroupWholeBan([Description("")] int AuthCode, [Description("目标群")] long 群号,
            [Description("真/开启 假/关闭")] bool 开启禁言);

        /// <summary>
        /// 置匿名群员禁言
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="群号">目标群</param>
        /// <param name="匿名">群消息事件收到的“匿名”参数</param>
        /// <param name="禁言时间">禁言的时间，单位为秒。不支持解禁</param>
        /// <returns></returns>
        [Description("置匿名群员禁言")]
        int CQ_setGroupAnonymousBan([Description("")] int AuthCode, [Description("目标群")] long 群号,
            [Description("群消息事件收到的“匿名”参数")] string 匿名, [Description("禁言的时间，单位为秒。不支持解禁")] long 禁言时间);

        /// <summary>
        /// 置群匿名设置
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="群号"></param>
        /// <param name="开启匿名"></param>
        /// <returns></returns>
        [Description("置群匿名设置")]
        int CQ_setGroupAnonymous([Description("")] int AuthCode, [Description("")] long 群号,
            [Description("")] bool 开启匿名);

        /// <summary>
        /// 置群成员名片
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="群号">目标群</param>
        /// <param name="Account">被设置的帐号</param>
        /// <param name="新名片_昵称"></param>
        /// <returns></returns>
        [Description("置群成员名片")]
        int CQ_setGroupCard([Description("")] int AuthCode, [Description("目标群")] long 群号,
            [Description("被设置的帐号")] long Account, [Description("")] string 新名片_昵称);

        /// <summary>
        /// 置群退出
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="群号">目标群</param>
        /// <param name="是否解散">真/解散本群(群主) 假/退出本群(管理、群成员)</param>
        /// <returns></returns>
        [Description("置群退出")]
        int CQ_setGroupLeave([Description("")] int AuthCode, [Description("目标群")] long 群号,
            [Description("真/解散本群(群主) 假/退出本群(管理、群成员)")]
            bool 是否解散);

        /// <summary>
        /// 置讨论组退出
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="讨论组号">目标讨论组</param>
        /// <returns></returns>
        [Description("置讨论组退出")]
        int CQ_setDiscussLeave([Description("")] int AuthCode, [Description("目标讨论组")] long 讨论组号);

        /// <summary>
        /// 置好友添加请求
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="请求反馈标识">请求事件收到的“反馈标识”参数</param>
        /// <param name="反馈类型">#请求_通过 或 #请求_拒绝</param>
        /// <param name="备注">添加后的好友备注</param>
        /// <returns></returns>
        [Description("置好友添加请求")]
        int CQ_setFriendAddRequest([Description("")] int AuthCode, [Description("请求事件收到的“反馈标识”参数")] string 请求反馈标识,
            [Description("#请求_通过 或 #请求_拒绝")] int 反馈类型, [Description("添加后的好友备注")] string 备注);

        /// <summary>
        /// 置群添加请求
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="请求反馈标识">请求事件收到的“反馈标识”参数</param>
        /// <param name="请求类型">根据请求事件的子类型区分 #请求_群添加 或 #请求_群邀请</param>
        /// <param name="反馈类型">#请求_通过 或 #请求_拒绝</param>
        /// <param name="理由">操作理由，仅 #请求_群添加 且 #请求_拒绝 时可用</param>
        /// <returns></returns>
        [Description("置群添加请求")]
        int CQ_setGroupAddRequestV2([Description("")] int AuthCode, [Description("请求事件收到的“反馈标识”参数")] string 请求反馈标识,
            [Description("根据请求事件的子类型区分 #请求_群添加 或 #请求_群邀请")]
            int 请求类型, [Description("#请求_通过 或 #请求_拒绝")] int 反馈类型, [Description("操作理由，仅 #请求_群添加 且 #请求_拒绝 时可用")]
            string 理由);

        /// <summary>
        /// 增加运行日志
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="优先级">#Log_ 开头常量</param>
        /// <param name="类型"></param>
        /// <param name="内容"></param>
        /// <returns></returns>
        [Description("增加运行日志")]
        int CQ_addLog([Description("")] int AuthCode, [Description("#Log_ 开头常量")] int 优先级, [Description("")] string 类型,
            [Description("")] string 内容);

        /// <summary>
        /// 置致命错误提示
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="错误信息"></param>
        /// <returns></returns>
        [Description("置致命错误提示")]
        int CQ_setFatal([Description("")] int AuthCode, [Description("")] string 错误信息);

        /// <summary>
        /// 取群成员信息(支持缓存)
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="群号">目标帐号所在群</param>
        /// <param name="Account">目标帐号</param>
        /// <param name="不使用缓存"></param>
        /// <returns></returns>
        [Description("取群成员信息(支持缓存)")]
        string CQ_getGroupMemberInfoV2([Description("")] int AuthCode, [Description("目标帐号所在群")] long 群号,
            [Description("目标帐号")] long Account, [Description("")] bool 不使用缓存);

        /// <summary>
        /// 取群成员列表
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="群号">目标帐号所在群</param>
        /// <returns></returns>
        [Description("取群成员列表")]
        string CQ_getGroupMemberList([Description("")] int AuthCode, [Description("目标帐号所在群")] long 群号);

        /// <summary>
        /// 取群列表
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        [Description("取群列表")]
        string CQ_getGroupList([Description("")] int AuthCode);

        /// <summary>
        /// 取好友列表
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="reserved">保留参数，请传入“假”</param>
        /// <returns></returns>
        [Description("取好友列表")]
        string CQ_getFriendList([Description("")] int AuthCode, [Description("保留参数，请传入“假”")] bool reserved);

        /// <summary>
        /// 取陌生人信息(支持缓存)
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="Account">目标帐号</param>
        /// <param name="不使用缓存"></param>
        /// <returns></returns>
        [Description("取陌生人信息(支持缓存)")]
        string CQ_getStrangerInfo([Description("")] int AuthCode, [Description("目标帐号")] long Account,
            [Description("")] bool 不使用缓存);

        /// <summary>
        /// 取群信息(支持缓存)
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="群号">目标群</param>
        /// <param name="不使用缓存"></param>
        /// <returns></returns>
        [Description("取群信息(支持缓存)")]
        string CQ_getGroupInfo([Description("")] int AuthCode, [Description("目标群")] long 群号,
            [Description("")] bool 不使用缓存);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pszString">址</param>
        /// <param name="cchString">址</param>
        /// <param name="dwFlags"></param>
        /// <param name="pbBinary"></param>
        /// <param name="pcbBinary">址</param>
        /// <param name="pdwSkip">0</param>
        /// <param name="pdwFlags">0</param>
        /// <returns></returns>
        [Description("")]
        bool CryptStringToBinaryA([Description("址")] string pszString, [Description("址")] int cchString,
            [Description("")] int dwFlags, [Description("")] int pbBinary, [Description("址")] int pcbBinary,
            [Description("0")] int pdwSkip, [Description("0")] int pdwFlags);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pszString">址</param>
        /// <param name="cchString">址</param>
        /// <param name="dwFlags"></param>
        /// <param name="pbBinary">址</param>
        /// <param name="pcbBinary">址</param>
        /// <param name="pdwSkip">0</param>
        /// <param name="pdwFlags">0</param>
        /// <returns></returns>
        [Description("")]
        bool CryptStringToBinaryA([Description("址")] string pszString, [Description("址")] int cchString,
            [Description("")] int dwFlags, [Description("址")] byte[] pbBinary, [Description("址")] int pcbBinary,
            [Description("0")] int pdwSkip, [Description("0")] int pdwFlags);
    }
}