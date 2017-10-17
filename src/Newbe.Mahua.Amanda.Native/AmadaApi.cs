using System.Runtime.InteropServices;

namespace Newbe.Mahua.Amanda.NativeApi
{


    public class AmadaApi : IAmadaApi
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="QQ号"></param>
        /// <returns></returns>
        void IAmadaApi.Api_SendPraise(string QQ号)
            => NativeMethods.Api_SendPraise(QQ号);

        /// <summary>
        ///
        /// </summary>
        /// <param name="QQ号"></param>
        /// <returns></returns>
        void IAmadaApi.Api_SendShake(string QQ号)
            => NativeMethods.Api_SendShake(QQ号);

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        string IAmadaApi.Api_Getbkn()
            => NativeMethods.Api_Getbkn();

        /// <summary>
        ///
        /// </summary>
        /// <param name="群号"></param>
        /// <returns></returns>
        void IAmadaApi.Api_QuitGroup(string 群号)
            => NativeMethods.Api_QuitGroup(群号);

        /// <summary>
        ///
        /// </summary>
        /// <param name="讨论组号"></param>
        /// <returns></returns>
        void IAmadaApi.Api_QuitDiscussGroup(string 讨论组号)
            => NativeMethods.Api_QuitDiscussGroup(讨论组号);

        /// <summary>
        ///
        /// </summary>
        /// <param name="个性签名"></param>
        /// <returns></returns>
        void IAmadaApi.Api_SetSignature(string 个性签名)
            => NativeMethods.Api_SetSignature(个性签名);

        /// <summary>
        ///
        /// </summary>
        /// <param name="讨论组号"></param>
        /// <param name="名称"></param>
        /// <returns></returns>
        void IAmadaApi.Api_SetDiscussName(string 讨论组号, string 名称)
            => NativeMethods.Api_SetDiscussName(讨论组号, 名称);

        /// <summary>
        ///
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="是否全群禁言"></param>
        /// <returns></returns>
        void IAmadaApi.Api_BanGroup(string 群号, bool 是否全群禁言)
            => NativeMethods.Api_BanGroup(群号, 是否全群禁言);

        /// <summary>
        ///
        /// </summary>
        /// <param name="群号"></param>
        /// <returns></returns>
        void IAmadaApi.Api_RemoveGroup(string 群号)
            => NativeMethods.Api_RemoveGroup(群号);

        /// <summary>
        ///
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="QQ号"></param>
        /// <param name="是否设置为管理员">真,设置  假,取消</param>
        /// <returns></returns>
        void IAmadaApi.Api_SetManager(string 群号, string QQ号, bool 是否设置为管理员)
            => NativeMethods.Api_SetManager(群号, QQ号, 是否设置为管理员);

        /// <summary>
        ///
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="QQ"></param>
        /// <param name="禁言时长">单位:秒  0为解除禁言</param>
        /// <returns></returns>
        void IAmadaApi.Api_Ban(string 群号, string QQ, int 禁言时长)
            => NativeMethods.Api_Ban(群号, QQ, 禁言时长);

        /// <summary>
        ///
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="是否允许匿名聊天"></param>
        /// <returns></returns>
        void IAmadaApi.Api_SetAnony(string 群号, bool 是否允许匿名聊天)
            => NativeMethods.Api_SetAnony(群号, 是否允许匿名聊天);

        /// <summary>
        ///
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="QQ号"></param>
        /// <param name="是否不再接收加群申请"></param>
        /// <returns></returns>
        void IAmadaApi.Api_RemoveMember(string 群号, string QQ号, bool 是否不再接收加群申请)
            => NativeMethods.Api_RemoveMember(群号, QQ号, 是否不再接收加群申请);

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        string IAmadaApi.Api_GetCookies()
            => NativeMethods.Api_GetCookies();

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        string IAmadaApi.Api_GetLoginQQ()
            => NativeMethods.Api_GetLoginQQ();

        /// <summary>
        /// 是否开启/关闭
        /// </summary>
        /// <returns></returns>
        bool IAmadaApi.Api_GetPluginState()
            => NativeMethods.Api_GetPluginState();

        /// <summary>
        /// 框架为插件所创建的一个目录
        /// </summary>
        /// <returns></returns>
        string IAmadaApi.Api_GetPath()
            => NativeMethods.Api_GetPath();

        /// <summary>
        /// 机器人发送消息
        /// </summary>
        /// <param name="类型">1.好友消息 2.群消息 3.群临时消息 4.讨论组消息 5.讨论组临时消息</param>
        /// <param name="群组">类型不为1时为群号/讨论组号  类型为1时可留空</param>
        /// <param name="QQ号">类型为2，4时可留空</param>
        /// <param name="内容"></param>
        /// <returns></returns>
        void IAmadaApi.Api_SendMsg(string 类型, string 群组, string QQ号, string 内容)
            => NativeMethods.Api_SendMsg(类型, 群组, QQ号, 内容);

        /// <summary>
        /// 处理加群消息
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="QQ号"></param>
        /// <param name="Seq"></param>
        /// <param name="操作方式">1.同意 2.拒绝 3.忽略</param>
        /// <param name="拒绝理由">参数可为空，且为 拒绝 时有效</param>
        /// <returns></returns>
        void IAmadaApi.Api_SetGroupAdd(string 群号, string QQ号, string Seq, int 操作方式, string 拒绝理由)
            => NativeMethods.Api_SetGroupAdd(群号, QQ号, Seq, 操作方式, 拒绝理由);

        /// <summary>
        /// 处理加好友消息
        /// </summary>
        /// <param name="QQ号"></param>
        /// <param name="操作方式">1.同意 2.拒绝 3.忽略</param>
        /// <param name="拒绝理由">参数可为空，且为 拒绝 时有效</param>
        /// <returns></returns>
        void IAmadaApi.Api_SetFriendAdd(string QQ号, int 操作方式, string 拒绝理由)
            => NativeMethods.Api_SetFriendAdd(QQ号, 操作方式, 拒绝理由);

        /// <summary>
        /// 总共五种积分类型，取出对应序号的积分名称，返回空
        /// </summary>
        /// <param name="积分类型"></param>
        /// <returns></returns>
        string IAmadaApi.Api_GetPointsName(int 积分类型)
            => NativeMethods.Api_GetPointsName(积分类型);

        /// <summary>
        /// 取得当前某一类型积分是全局的还是分群的 0.全局 1.分群 -1.该积分未被启用
        /// </summary>
        /// <param name="积分类型"></param>
        /// <returns></returns>
        int IAmadaApi.Api_GetPointsState(int 积分类型)
            => NativeMethods.Api_GetPointsState(积分类型);

        /// <summary>
        /// 修改成功返回积分数值，失败返回-1
        /// </summary>
        /// <param name="积分类型"></param>
        /// <param name="群号">如果积分库是全局的 则不用填写此参数</param>
        /// <param name="QQ号"></param>
        /// <param name="积分数值"></param>
        /// <returns></returns>
        long IAmadaApi.Api_SetPointsNum(int 积分类型, string 群号, string QQ号, long 积分数值)
            => NativeMethods.Api_SetPointsNum(积分类型, 群号, QQ号, 积分数值);

        /// <summary>
        /// 修改成功返回积分数值，失败返回-1
        /// </summary>
        /// <param name="积分类型"></param>
        /// <param name="群号">如果积分库是全局的 则不用填写此参数</param>
        /// <param name="QQ号"></param>
        /// <param name="积分数值"></param>
        /// <returns></returns>
        long IAmadaApi.Api_AddPoints(int 积分类型, string 群号, string QQ号, long 积分数值)
            => NativeMethods.Api_AddPoints(积分类型, 群号, QQ号, 积分数值);

        /// <summary>
        /// 修改成功返回积分数值，失败返回-1
        /// </summary>
        /// <param name="积分类型"></param>
        /// <param name="群号">如果积分库是全局的 则不用填写此参数</param>
        /// <param name="QQ号"></param>
        /// <param name="积分数值"></param>
        /// <returns></returns>
        long IAmadaApi.Api_ReducePoints(int 积分类型, string 群号, string QQ号, long 积分数值)
            => NativeMethods.Api_ReducePoints(积分类型, 群号, QQ号, 积分数值);

        /// <summary>
        ///
        /// </summary>
        /// <param name="类型"></param>
        /// <param name="内容"></param>
        /// <param name="字体颜色"></param>
        /// <returns></returns>
        void IAmadaApi.Api_SendLog(string 类型, string 内容, int 字体颜色)
            => NativeMethods.Api_SendLog(类型, 内容, 字体颜色);

        /// <summary>
        ///
        /// </summary>
        /// <param name="好友QQ"></param>
        /// <param name="备注名"></param>
        /// <returns></returns>
        void IAmadaApi.Api_SetFriendName(string 好友QQ, string 备注名)
            => NativeMethods.Api_SetFriendName(好友QQ, 备注名);

        /// <summary>
        ///
        /// </summary>
        /// <param name="好友QQ"></param>
        /// <returns></returns>
        void IAmadaApi.Api_DeleteFriend(string 好友QQ)
            => NativeMethods.Api_DeleteFriend(好友QQ);

        /// <summary>
        ///
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="附加信息"></param>
        /// <returns></returns>
        void IAmadaApi.Api_AddGroup(string 群号, string 附加信息)
            => NativeMethods.Api_AddGroup(群号, 附加信息);

        /// <summary>
        /// 返回网易云点歌XML
        /// </summary>
        /// <param name="歌曲ID"></param>
        /// <returns></returns>
        string IAmadaApi.Api_163Music(string 歌曲ID)
            => NativeMethods.Api_163Music(歌曲ID);

        /// <summary>
        /// 返回QQ点歌XML
        /// </summary>
        /// <param name="歌曲ID"></param>
        /// <returns></returns>
        string IAmadaApi.Api_QQMusic(string 歌曲ID)
            => NativeMethods.Api_QQMusic(歌曲ID);

        /// <summary>
        /// 返回Json点歌XML
        /// </summary>
        /// <param name="歌曲ID"></param>
        /// <returns></returns>
        string IAmadaApi.Api_JsonMusic(string 歌曲ID)
            => NativeMethods.Api_JsonMusic(歌曲ID);

        /// <summary>
        /// 置插件错误管理
        /// </summary>
        /// <param name="Code"></param>
        /// <param name="Str"></param>
        /// <returns></returns>
        string IAmadaApi.Api_Error(string Code, string Str)
            => NativeMethods.Api_Error(Code, Str);

        /// <summary>
        /// 取得群内成员的名片
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="QQ号"></param>
        /// <returns></returns>
        string IAmadaApi.Api_GetGroupCard(string 群号, string QQ号)
            => NativeMethods.Api_GetGroupCard(群号, QQ号);

        /// <summary>
        /// 取得某个QQ的昵称
        /// </summary>
        /// <param name="QQ号"></param>
        /// <returns></returns>
        string IAmadaApi.Api_GetNick(string QQ号)
            => NativeMethods.Api_GetNick(QQ号);

        /// <summary>
        /// 修改群内成员的名片
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="QQ号"></param>
        /// <param name="新名片"></param>
        /// <returns></returns>
        void IAmadaApi.Api_SetGroupCard(string 群号, string QQ号, string 新名片)
            => NativeMethods.Api_SetGroupCard(群号, QQ号, 新名片);

        /// <summary>
        /// 取得某个QQ的名片赞数量
        /// </summary>
        /// <param name="QQ号"></param>
        /// <returns></returns>
        string IAmadaApi.Api_GetPraiseNum(string QQ号)
            => NativeMethods.Api_GetPraiseNum(QQ号);

        /// <summary>
        /// 以JSON形式取得好友列表
        /// </summary>
        /// <returns></returns>
        string IAmadaApi.Api_GetFriendList()
            => NativeMethods.Api_GetFriendList();

        /// <summary>
        /// 以JSON形式取得群列表
        /// </summary>
        /// <returns></returns>
        string IAmadaApi.Api_GetGroupList()
            => NativeMethods.Api_GetGroupList();

        /// <summary>
        /// 以JSON形式取得群成员列表
        /// </summary>
        /// <param name="群号"></param>
        /// <returns></returns>
        string IAmadaApi.Api_GetGroupMemberList(string 群号)
            => NativeMethods.Api_GetGroupMemberList(群号);

        /// <summary>
        /// 改变QQ在线状态
        /// </summary>
        /// <param name="类型">1.我在线上 2.Q我吧 3.离开 4.忙碌 5.请勿打扰 6.隐身</param>
        /// <returns></returns>
        string IAmadaApi.Api_SetQQState(int 类型)
            => NativeMethods.Api_SetQQState(类型);

        private static class NativeMethods
        {
            /// <summary>
            ///
            /// </summary>
            /// <param name="QQ号"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern void Api_SendPraise(string QQ号);

            /// <summary>
            ///
            /// </summary>
            /// <param name="QQ号"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern void Api_SendShake(string QQ号);

            /// <summary>
            ///
            /// </summary>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern string Api_Getbkn();

            /// <summary>
            ///
            /// </summary>
            /// <param name="群号"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern void Api_QuitGroup(string 群号);

            /// <summary>
            ///
            /// </summary>
            /// <param name="讨论组号"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern void Api_QuitDiscussGroup(string 讨论组号);

            /// <summary>
            ///
            /// </summary>
            /// <param name="个性签名"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern void Api_SetSignature(string 个性签名);

            /// <summary>
            ///
            /// </summary>
            /// <param name="讨论组号"></param>
            /// <param name="名称"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern void Api_SetDiscussName(string 讨论组号, string 名称);

            /// <summary>
            ///
            /// </summary>
            /// <param name="群号"></param>
            /// <param name="是否全群禁言"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern void Api_BanGroup(string 群号, bool 是否全群禁言);

            /// <summary>
            ///
            /// </summary>
            /// <param name="群号"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern void Api_RemoveGroup(string 群号);

            /// <summary>
            ///
            /// </summary>
            /// <param name="群号"></param>
            /// <param name="QQ号"></param>
            /// <param name="是否设置为管理员">真,设置  假,取消</param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern void Api_SetManager(string 群号, string QQ号, bool 是否设置为管理员);

            /// <summary>
            ///
            /// </summary>
            /// <param name="群号"></param>
            /// <param name="QQ"></param>
            /// <param name="禁言时长">单位:秒  0为解除禁言</param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern void Api_Ban(string 群号, string QQ, int 禁言时长);

            /// <summary>
            ///
            /// </summary>
            /// <param name="群号"></param>
            /// <param name="是否允许匿名聊天"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern void Api_SetAnony(string 群号, bool 是否允许匿名聊天);

            /// <summary>
            ///
            /// </summary>
            /// <param name="群号"></param>
            /// <param name="QQ号"></param>
            /// <param name="是否不再接收加群申请"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern void Api_RemoveMember(string 群号, string QQ号, bool 是否不再接收加群申请);

            /// <summary>
            ///
            /// </summary>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern string Api_GetCookies();

            /// <summary>
            ///
            /// </summary>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern string Api_GetLoginQQ();

            /// <summary>
            /// 是否开启/关闭
            /// </summary>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern bool Api_GetPluginState();

            /// <summary>
            /// 框架为插件所创建的一个目录
            /// </summary>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern string Api_GetPath();

            /// <summary>
            /// 机器人发送消息
            /// </summary>
            /// <param name="类型">1.好友消息 2.群消息 3.群临时消息 4.讨论组消息 5.讨论组临时消息</param>
            /// <param name="群组">类型不为1时为群号/讨论组号  类型为1时可留空</param>
            /// <param name="QQ号">类型为2，4时可留空</param>
            /// <param name="内容"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern void Api_SendMsg(string 类型, string 群组, string QQ号, string 内容);

            /// <summary>
            /// 处理加群消息
            /// </summary>
            /// <param name="群号"></param>
            /// <param name="QQ号"></param>
            /// <param name="Seq"></param>
            /// <param name="操作方式">1.同意 2.拒绝 3.忽略</param>
            /// <param name="拒绝理由">参数可为空，且为 拒绝 时有效</param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern void Api_SetGroupAdd(string 群号, string QQ号, string Seq, int 操作方式, string 拒绝理由);

            /// <summary>
            /// 处理加好友消息
            /// </summary>
            /// <param name="QQ号"></param>
            /// <param name="操作方式">1.同意 2.拒绝 3.忽略</param>
            /// <param name="拒绝理由">参数可为空，且为 拒绝 时有效</param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern void Api_SetFriendAdd(string QQ号, int 操作方式, string 拒绝理由);

            /// <summary>
            /// 总共五种积分类型，取出对应序号的积分名称，返回空
            /// </summary>
            /// <param name="积分类型"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern string Api_GetPointsName(int 积分类型);

            /// <summary>
            /// 取得当前某一类型积分是全局的还是分群的 0.全局 1.分群 -1.该积分未被启用
            /// </summary>
            /// <param name="积分类型"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern int Api_GetPointsState(int 积分类型);

            /// <summary>
            /// 修改成功返回积分数值，失败返回-1
            /// </summary>
            /// <param name="积分类型"></param>
            /// <param name="群号">如果积分库是全局的 则不用填写此参数</param>
            /// <param name="QQ号"></param>
            /// <param name="积分数值"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern long Api_SetPointsNum(int 积分类型, string 群号, string QQ号, long 积分数值);

            /// <summary>
            /// 修改成功返回积分数值，失败返回-1
            /// </summary>
            /// <param name="积分类型"></param>
            /// <param name="群号">如果积分库是全局的 则不用填写此参数</param>
            /// <param name="QQ号"></param>
            /// <param name="积分数值"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern long Api_AddPoints(int 积分类型, string 群号, string QQ号, long 积分数值);

            /// <summary>
            /// 修改成功返回积分数值，失败返回-1
            /// </summary>
            /// <param name="积分类型"></param>
            /// <param name="群号">如果积分库是全局的 则不用填写此参数</param>
            /// <param name="QQ号"></param>
            /// <param name="积分数值"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern long Api_ReducePoints(int 积分类型, string 群号, string QQ号, long 积分数值);

            /// <summary>
            ///
            /// </summary>
            /// <param name="类型"></param>
            /// <param name="内容"></param>
            /// <param name="字体颜色"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern void Api_SendLog(string 类型, string 内容, int 字体颜色);

            /// <summary>
            ///
            /// </summary>
            /// <param name="好友QQ"></param>
            /// <param name="备注名"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern void Api_SetFriendName(string 好友QQ, string 备注名);

            /// <summary>
            ///
            /// </summary>
            /// <param name="好友QQ"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern void Api_DeleteFriend(string 好友QQ);

            /// <summary>
            ///
            /// </summary>
            /// <param name="群号"></param>
            /// <param name="附加信息"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern void Api_AddGroup(string 群号, string 附加信息);

            /// <summary>
            /// 返回网易云点歌XML
            /// </summary>
            /// <param name="歌曲ID"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern string Api_163Music(string 歌曲ID);

            /// <summary>
            /// 返回QQ点歌XML
            /// </summary>
            /// <param name="歌曲ID"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern string Api_QQMusic(string 歌曲ID);

            /// <summary>
            /// 返回Json点歌XML
            /// </summary>
            /// <param name="歌曲ID"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern string Api_JsonMusic(string 歌曲ID);

            /// <summary>
            /// 置插件错误管理
            /// </summary>
            /// <param name="Code"></param>
            /// <param name="Str"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern string Api_Error(string Code, string Str);

            /// <summary>
            /// 取得群内成员的名片
            /// </summary>
            /// <param name="群号"></param>
            /// <param name="QQ号"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern string Api_GetGroupCard(string 群号, string QQ号);

            /// <summary>
            /// 取得某个QQ的昵称
            /// </summary>
            /// <param name="QQ号"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern string Api_GetNick(string QQ号);

            /// <summary>
            /// 修改群内成员的名片
            /// </summary>
            /// <param name="群号"></param>
            /// <param name="QQ号"></param>
            /// <param name="新名片"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern void Api_SetGroupCard(string 群号, string QQ号, string 新名片);

            /// <summary>
            /// 取得某个QQ的名片赞数量
            /// </summary>
            /// <param name="QQ号"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern string Api_GetPraiseNum(string QQ号);

            /// <summary>
            /// 以JSON形式取得好友列表
            /// </summary>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern string Api_GetFriendList();

            /// <summary>
            /// 以JSON形式取得群列表
            /// </summary>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern string Api_GetGroupList();

            /// <summary>
            /// 以JSON形式取得群成员列表
            /// </summary>
            /// <param name="群号"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern string Api_GetGroupMemberList(string 群号);

            /// <summary>
            /// 改变QQ在线状态
            /// </summary>
            /// <param name="类型">1.我在线上 2.Q我吧 3.离开 4.忙碌 5.请勿打扰 6.隐身</param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern string Api_SetQQState(int 类型);
        }
    }
}
