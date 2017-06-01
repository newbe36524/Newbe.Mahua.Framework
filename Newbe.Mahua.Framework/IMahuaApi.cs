namespace Newbe.Mahua.Framework
{
    public interface IMahuaApi
    {
        /// <summary>
        ///     发送好友消息
        /// </summary>
        /// <param name="qqId">目标QQ号</param>
        /// <param name="content">消息内容</param>
        void SendPrivateMsg(long qqId, string content);

        /// <summary>
        /// 发送群消息
        /// </summary>
        /// <param name="groupNum">目标群</param>
        /// <param name="msg">消息内容</param>
        void SendGroupMsg(long groupNum, string msg);

        /// <summary>
        /// 发送讨论组消息
        /// </summary>
        /// <param name="discussGroupNum">目标讨论组</param>
        /// <param name="msg">消息内容</param>
        void SendDiscussMsg(long discussGroupNum, string msg);


        /// <summary>
        /// 发送赞
        /// </summary>
        /// <param name="qqid">目标QQ</param>
        /// <returns></returns>
        int SendLike(long qqid);

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
        /// <param name="群号">目标群</param>
        /// <param name="qqid">目标QQ</param>
        /// <param name="拒绝再加群">如果为真，则“不再接收此人加群申请”，请慎用</param>
        /// <returns></returns>
        int SetGroupKick(long 群号, long qqid, bool 拒绝再加群);

        /// <summary>
        /// 置群员禁言
        /// </summary>
        /// <param name="群号">目标群</param>
        /// <param name="qqid">目标QQ</param>
        /// <param name="禁言时间">禁言的时间，单位为秒。如果要解禁，这里填写0</param>
        /// <returns></returns>
        int SetGroupBan(long 群号, long qqid, long 禁言时间);

        /// <summary>
        /// 置群管理员
        /// </summary>
        /// <param name="群号">目标群</param>
        /// <param name="QQID">被设置的QQ</param>
        /// <param name="成为管理员">真/设置管理员 假/取消管理员</param>
        /// <returns></returns>
        int SetGroupAdmin(long 群号, long QQID, bool 成为管理员);

        /// <summary>
        /// 置群成员专属头衔
        /// </summary>
        /// <param name="群号">目标群</param>
        /// <param name="QQID">目标QQ</param>
        /// <param name="头衔">如果要删除，这里填空</param>
        /// <param name="过期时间">专属头衔有效期，单位为秒。如果永久有效，这里填写-1</param>
        /// <returns></returns>
        int SetGroupSpecialTitle(long 群号, long QQID, string 头衔, long 过期时间);

        /// <summary>
        /// 置全群禁言
        /// </summary>
        /// <param name="群号">目标群</param>
        /// <param name="开启禁言">真/开启 假/关闭</param>
        /// <returns></returns>
        int SetGroupWholeBan(long 群号, bool 开启禁言);

        /// <summary>
        /// 置匿名群员禁言
        /// </summary>
        /// <param name="群号">目标群</param>
        /// <param name="匿名">群消息事件收到的“匿名”参数</param>
        /// <param name="禁言时间">禁言的时间，单位为秒。不支持解禁</param>
        /// <returns></returns>
        int SetGroupAnonymousBan(long 群号, string 匿名, long 禁言时间);

        /// <summary>
        /// 置群匿名设置
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="开启匿名"></param>
        /// <returns></returns>
        int SetGroupAnonymous(long 群号, bool 开启匿名);

        /// <summary>
        /// 置群成员名片
        /// </summary>
        /// <param name="群号">目标群</param>
        /// <param name="QQID">被设置的QQ</param>
        /// <param name="新名片_昵称"></param>
        /// <returns></returns>
        int SetGroupCard(long 群号, long QQID, string 新名片_昵称);

        /// <summary>
        /// 置群退出
        /// </summary>
        /// <param name="群号">目标群</param>
        /// <param name="是否解散">真/解散本群(群主) 假/退出本群(管理、群成员)</param>
        /// <returns></returns>
        int SetGroupLeave(long 群号, bool 是否解散);

        /// <summary>
        /// 置讨论组退出
        /// </summary>
        /// <param name="讨论组号">目标讨论组</param>
        /// <returns></returns>
        int SetDiscussLeave(long 讨论组号);

        /// <summary>
        /// 置好友添加请求
        /// </summary>
        /// <param name="请求反馈标识">请求事件收到的“反馈标识”参数</param>
        /// <param name="反馈类型">#请求_通过 或 #请求_拒绝</param>
        /// <param name="备注">添加后的好友备注</param>
        /// <returns></returns>
        int SetFriendAddRequest(string 请求反馈标识, int 反馈类型, string 备注);

        /// <summary>
        /// 置群添加请求
        /// </summary>
        /// <param name="请求反馈标识">请求事件收到的“反馈标识”参数</param>
        /// <param name="请求类型">根据请求事件的子类型区分 #请求_群添加 或 #请求_群邀请</param>
        /// <param name="反馈类型">#请求_通过 或 #请求_拒绝</param>
        /// <param name="理由">操作理由，仅 #请求_群添加 且 #请求_拒绝 时可用</param>
        /// <returns></returns>
        int SetGroupAddRequest(string 请求反馈标识, int 请求类型, int 反馈类型, string 理由);


        /// <summary>
        /// 取群成员信息(支持缓存)
        /// </summary>
        /// <param name="群号">目标QQ所在群</param>
        /// <param name="qqid">目标QQ</param>
        /// <returns></returns>
        string GetGroupMemberInfo(long 群号, long qqid);
    }
}