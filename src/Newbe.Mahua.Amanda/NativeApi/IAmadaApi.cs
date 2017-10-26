namespace Newbe.Mahua.Amanda.NativeApi
{
    public interface IAmadaApi
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="QQ号"></param>
        /// <returns></returns>
        void Api_SendPraise(string QQ号);

        /// <summary>
        ///
        /// </summary>
        /// <param name="QQ号"></param>
        /// <returns></returns>
        void Api_SendShake(string QQ号);

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        string Api_Getbkn();

        /// <summary>
        ///
        /// </summary>
        /// <param name="群号"></param>
        /// <returns></returns>
        void Api_QuitGroup(string 群号);

        /// <summary>
        ///
        /// </summary>
        /// <param name="讨论组号"></param>
        /// <returns></returns>
        void Api_QuitDiscussGroup(string 讨论组号);

        /// <summary>
        ///
        /// </summary>
        /// <param name="个性签名"></param>
        /// <returns></returns>
        void Api_SetSignature(string 个性签名);

        /// <summary>
        ///
        /// </summary>
        /// <param name="讨论组号"></param>
        /// <param name="名称"></param>
        /// <returns></returns>
        void Api_SetDiscussName(string 讨论组号, string 名称);

        /// <summary>
        ///
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="是否全群禁言"></param>
        /// <returns></returns>
        void Api_BanGroup(string 群号, bool 是否全群禁言);

        /// <summary>
        ///
        /// </summary>
        /// <param name="群号"></param>
        /// <returns></returns>
        void Api_RemoveGroup(string 群号);

        /// <summary>
        ///
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="QQ号"></param>
        /// <param name="是否设置为管理员">真,设置  假,取消</param>
        /// <returns></returns>
        void Api_SetManager(string 群号, string QQ号, bool 是否设置为管理员);

        /// <summary>
        ///
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="QQ"></param>
        /// <param name="禁言时长">单位:秒  0为解除禁言</param>
        /// <returns></returns>
        void Api_Ban(string 群号, string QQ, int 禁言时长);

        /// <summary>
        ///
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="是否允许匿名聊天"></param>
        /// <returns></returns>
        void Api_SetAnony(string 群号, bool 是否允许匿名聊天);

        /// <summary>
        ///
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="QQ号"></param>
        /// <param name="是否不再接收加群申请"></param>
        /// <returns></returns>
        void Api_RemoveMember(string 群号, string QQ号, bool 是否不再接收加群申请);

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        string Api_GetCookies();

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        string Api_GetLoginQQ();

        /// <summary>
        /// 是否开启/关闭
        /// </summary>
        /// <returns></returns>
        bool Api_GetPluginState();

        /// <summary>
        /// 框架为插件所创建的一个目录
        /// </summary>
        /// <returns></returns>
        string Api_GetPath();

        /// <summary>
        /// 机器人发送消息
        /// </summary>
        /// <param name="类型">1.好友消息 2.群消息 3.群临时消息 4.讨论组消息 5.讨论组临时消息</param>
        /// <param name="群组">类型不为1时为群号/讨论组号  类型为1时可留空</param>
        /// <param name="QQ号">类型为2，4时可留空</param>
        /// <param name="内容"></param>
        /// <returns></returns>
        void Api_SendMsg(string 类型, string 群组, string QQ号, string 内容);

        /// <summary>
        /// 处理加群消息
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="QQ号"></param>
        /// <param name="Seq"></param>
        /// <param name="操作方式">1.同意 2.拒绝 3.忽略</param>
        /// <param name="拒绝理由">参数可为空，且为 拒绝 时有效</param>
        /// <returns></returns>
        void Api_SetGroupAdd(string 群号, string QQ号, string Seq, int 操作方式, string 拒绝理由);

        /// <summary>
        /// 处理加好友消息
        /// </summary>
        /// <param name="QQ号"></param>
        /// <param name="操作方式">1.同意 2.拒绝 3.忽略</param>
        /// <param name="拒绝理由">参数可为空，且为 拒绝 时有效</param>
        /// <returns></returns>
        void Api_SetFriendAdd(string QQ号, int 操作方式, string 拒绝理由);

        /// <summary>
        /// 总共五种积分类型，取出对应序号的积分名称，返回空
        /// </summary>
        /// <param name="积分类型"></param>
        /// <returns></returns>
        string Api_GetPointsName(int 积分类型);

        /// <summary>
        /// 取得当前某一类型积分是全局的还是分群的 0.全局 1.分群 -1.该积分未被启用
        /// </summary>
        /// <param name="积分类型"></param>
        /// <returns></returns>
        int Api_GetPointsState(int 积分类型);

        /// <summary>
        /// 修改成功返回积分数值，失败返回-1
        /// </summary>
        /// <param name="积分类型"></param>
        /// <param name="群号">如果积分库是全局的 则不用填写此参数</param>
        /// <param name="QQ号"></param>
        /// <param name="积分数值"></param>
        /// <returns></returns>
        long Api_SetPointsNum(int 积分类型, string 群号, string QQ号, long 积分数值);

        /// <summary>
        /// 修改成功返回积分数值，失败返回-1
        /// </summary>
        /// <param name="积分类型"></param>
        /// <param name="群号">如果积分库是全局的 则不用填写此参数</param>
        /// <param name="QQ号"></param>
        /// <param name="积分数值"></param>
        /// <returns></returns>
        long Api_AddPoints(int 积分类型, string 群号, string QQ号, long 积分数值);

        /// <summary>
        /// 修改成功返回积分数值，失败返回-1
        /// </summary>
        /// <param name="积分类型"></param>
        /// <param name="群号">如果积分库是全局的 则不用填写此参数</param>
        /// <param name="QQ号"></param>
        /// <param name="积分数值"></param>
        /// <returns></returns>
        long Api_ReducePoints(int 积分类型, string 群号, string QQ号, long 积分数值);

        /// <summary>
        ///
        /// </summary>
        /// <param name="类型"></param>
        /// <param name="内容"></param>
        /// <param name="字体颜色"></param>
        /// <returns></returns>
        void Api_SendLog(string 类型, string 内容, int 字体颜色);

        /// <summary>
        ///
        /// </summary>
        /// <param name="好友QQ"></param>
        /// <param name="备注名"></param>
        /// <returns></returns>
        void Api_SetFriendName(string 好友QQ, string 备注名);

        /// <summary>
        ///
        /// </summary>
        /// <param name="好友QQ"></param>
        /// <returns></returns>
        void Api_DeleteFriend(string 好友QQ);

        /// <summary>
        ///
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="附加信息"></param>
        /// <returns></returns>
        void Api_AddGroup(string 群号, string 附加信息);

        /// <summary>
        /// 返回网易云点歌XML
        /// </summary>
        /// <param name="歌曲ID"></param>
        /// <returns></returns>
        string Api_163Music(string 歌曲ID);

        /// <summary>
        /// 返回QQ点歌XML
        /// </summary>
        /// <param name="歌曲ID"></param>
        /// <returns></returns>
        string Api_QQMusic(string 歌曲ID);

        /// <summary>
        /// 返回Json点歌XML
        /// </summary>
        /// <param name="歌曲ID"></param>
        /// <returns></returns>
        string Api_JsonMusic(string 歌曲ID);

        /// <summary>
        /// 置插件错误管理
        /// </summary>
        /// <param name="Code"></param>
        /// <param name="Str"></param>
        /// <returns></returns>
        string Api_Error(string Code, string Str);

        /// <summary>
        /// 取得群内成员的名片
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="QQ号"></param>
        /// <returns></returns>
        string Api_GetGroupCard(string 群号, string QQ号);

        /// <summary>
        /// 取得某个QQ的昵称
        /// </summary>
        /// <param name="QQ号"></param>
        /// <returns></returns>
        string Api_GetNick(string QQ号);

        /// <summary>
        /// 修改群内成员的名片
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="QQ号"></param>
        /// <param name="新名片"></param>
        /// <returns></returns>
        void Api_SetGroupCard(string 群号, string QQ号, string 新名片);

        /// <summary>
        /// 取得某个QQ的名片赞数量
        /// </summary>
        /// <param name="QQ号"></param>
        /// <returns></returns>
        string Api_GetPraiseNum(string QQ号);

        /// <summary>
        /// 以JSON形式取得好友列表
        /// </summary>
        /// <returns></returns>
        string Api_GetFriendList();

        /// <summary>
        /// 以JSON形式取得群列表
        /// </summary>
        /// <returns></returns>
        string Api_GetGroupList();

        /// <summary>
        /// 以JSON形式取得群成员列表
        /// </summary>
        /// <param name="群号"></param>
        /// <returns></returns>
        string Api_GetGroupMemberList(string 群号);

        /// <summary>
        /// 改变QQ在线状态
        /// </summary>
        /// <param name="类型">1.我在线上 2.Q我吧 3.离开 4.忙碌 5.请勿打扰 6.隐身</param>
        /// <returns></returns>
        string Api_SetQQState(int 类型);
    }
}
