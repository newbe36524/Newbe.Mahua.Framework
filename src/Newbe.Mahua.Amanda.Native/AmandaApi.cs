using System.Runtime.InteropServices;

namespace Newbe.Mahua.Amanda.NativeApi
{
    public class AmandaApi : IAmandaApi
    {
        private readonly IAmandaAuthCodeContainer _amandaAuthCodeContainer;

        public AmandaApi(
            IAmandaAuthCodeContainer amandaAuthCodeContainer)
        {
            _amandaAuthCodeContainer = amandaAuthCodeContainer;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="QQ号"></param>
        /// <returns></returns>
        void IAmandaApi.Api_SendPraise(string QQ号)
            => NativeMethods.Api_SendPraise(QQ号, _amandaAuthCodeContainer.AuthCode);

        /// <summary>
        ///
        /// </summary>
        /// <param name="QQ号"></param>
        /// <returns></returns>
        void IAmandaApi.Api_SendShake(string QQ号)
            => NativeMethods.Api_SendShake(QQ号, _amandaAuthCodeContainer.AuthCode);

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        string IAmandaApi.Api_Getbkn()
            => NativeMethods.Api_Getbkn(_amandaAuthCodeContainer.AuthCode);

        /// <summary>
        ///
        /// </summary>
        /// <param name="群号"></param>
        /// <returns></returns>
        void IAmandaApi.Api_QuitGroup(string 群号)
            => NativeMethods.Api_QuitGroup(群号, _amandaAuthCodeContainer.AuthCode);

        /// <summary>
        ///
        /// </summary>
        /// <param name="讨论组号"></param>
        /// <returns></returns>
        void IAmandaApi.Api_QuitDiscussGroup(string 讨论组号)
            => NativeMethods.Api_QuitDiscussGroup(讨论组号, _amandaAuthCodeContainer.AuthCode);

        /// <summary>
        ///
        /// </summary>
        /// <param name="个性签名"></param>
        /// <returns></returns>
        void IAmandaApi.Api_SetSignature(string 个性签名)
            => NativeMethods.Api_SetSignature(个性签名, _amandaAuthCodeContainer.AuthCode);

        /// <summary>
        ///
        /// </summary>
        /// <param name="讨论组号"></param>
        /// <param name="名称"></param>
        /// <returns></returns>
        void IAmandaApi.Api_SetDiscussName(string 讨论组号, string 名称)
            => NativeMethods.Api_SetDiscussName(讨论组号, 名称, _amandaAuthCodeContainer.AuthCode);

        /// <summary>
        ///
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="是否全群禁言"></param>
        /// <returns></returns>
        void IAmandaApi.Api_BanGroup(string 群号, bool 是否全群禁言)
            => NativeMethods.Api_BanGroup(群号, 是否全群禁言, _amandaAuthCodeContainer.AuthCode);

        /// <summary>
        ///
        /// </summary>
        /// <param name="群号"></param>
        /// <returns></returns>
        void IAmandaApi.Api_RemoveGroup(string 群号)
            => NativeMethods.Api_RemoveGroup(群号, _amandaAuthCodeContainer.AuthCode);

        /// <summary>
        ///
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="QQ号"></param>
        /// <param name="是否设置为管理员">真,设置  假,取消</param>
        /// <returns></returns>
        void IAmandaApi.Api_SetManager(string 群号, string QQ号, bool 是否设置为管理员)
            => NativeMethods.Api_SetManager(群号, QQ号, 是否设置为管理员, _amandaAuthCodeContainer.AuthCode);

        /// <summary>
        ///
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="QQ"></param>
        /// <param name="禁言时长">单位:秒  0为解除禁言</param>
        /// <returns></returns>
        void IAmandaApi.Api_Ban(string 群号, string QQ, int 禁言时长)
            => NativeMethods.Api_Ban(群号, QQ, 禁言时长, _amandaAuthCodeContainer.AuthCode);

        /// <summary>
        ///
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="是否允许匿名聊天"></param>
        /// <returns></returns>
        void IAmandaApi.Api_SetAnony(string 群号, bool 是否允许匿名聊天)
            => NativeMethods.Api_SetAnony(群号, 是否允许匿名聊天, _amandaAuthCodeContainer.AuthCode);

        /// <summary>
        ///
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="QQ号"></param>
        /// <param name="是否不再接收加群申请"></param>
        /// <returns></returns>
        void IAmandaApi.Api_RemoveMember(string 群号, string QQ号, bool 是否不再接收加群申请)
            => NativeMethods.Api_RemoveMember(群号, QQ号, 是否不再接收加群申请, _amandaAuthCodeContainer.AuthCode);

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        string IAmandaApi.Api_GetCookies()
            => NativeMethods.Api_GetCookies(_amandaAuthCodeContainer.AuthCode);

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        string IAmandaApi.Api_GetLoginQQ()
            => NativeMethods.Api_GetLoginQQ(_amandaAuthCodeContainer.AuthCode);

        /// <summary>
        /// 是否开启/关闭
        /// </summary>
        /// <returns></returns>
        bool IAmandaApi.Api_GetPluginState()
            => NativeMethods.Api_GetPluginState(_amandaAuthCodeContainer.AuthCode);

        /// <summary>
        /// 框架为插件所创建的一个目录
        /// </summary>
        /// <returns></returns>
        string IAmandaApi.Api_GetPath()
            => NativeMethods.Api_GetPath(_amandaAuthCodeContainer.AuthCode);

        /// <summary>
        /// 机器人发送消息
        /// </summary>
        /// <param name="类型">1.好友消息 2.群消息 3.群临时消息 4.讨论组消息 5.讨论组临时消息</param>
        /// <param name="群组">类型不为1时为群号/讨论组号  类型为1时可留空</param>
        /// <param name="QQ号">类型为2，4时可留空</param>
        /// <param name="内容"></param>
        /// <returns></returns>
        void IAmandaApi.Api_SendMsg(int 类型, string 群组, string QQ号, string 内容)
            => NativeMethods.Api_SendMsg(类型, 群组, QQ号, 内容, _amandaAuthCodeContainer.AuthCode);

        /// <summary>
        /// 处理加群消息
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="QQ号"></param>
        /// <param name="Seq"></param>
        /// <param name="操作方式">1.同意 2.拒绝 3.忽略</param>
        /// <param name="拒绝理由">参数可为空，且为 拒绝 时有效</param>
        /// <returns></returns>
        void IAmandaApi.Api_SetGroupAdd(string 群号, string QQ号, string Seq, int 操作方式, string 拒绝理由)
            => NativeMethods.Api_SetGroupAdd(群号, QQ号, Seq, 操作方式, 拒绝理由, _amandaAuthCodeContainer.AuthCode);

        /// <summary>
        /// 处理加好友消息
        /// </summary>
        /// <param name="QQ号"></param>
        /// <param name="操作方式">1.同意 2.拒绝 3.忽略</param>
        /// <param name="拒绝理由">参数可为空，且为 拒绝 时有效</param>
        /// <returns></returns>
        void IAmandaApi.Api_SetFriendAdd(string QQ号, int 操作方式, string 拒绝理由)
            => NativeMethods.Api_SetFriendAdd(QQ号, 操作方式, 拒绝理由, _amandaAuthCodeContainer.AuthCode);

        /// <summary>
        ///
        /// </summary>
        /// <param name="类型"></param>
        /// <param name="内容"></param>
        /// <param name="字体颜色"></param>
        /// <returns></returns>
        void IAmandaApi.Api_SendLog(string 类型, string 内容, int 字体颜色)
            => NativeMethods.Api_SendLog(类型, 内容, 字体颜色, _amandaAuthCodeContainer.AuthCode);

        /// <summary>
        ///
        /// </summary>
        /// <param name="好友QQ"></param>
        /// <param name="备注名"></param>
        /// <returns></returns>
        void IAmandaApi.Api_SetFriendName(string 好友QQ, string 备注名)
            => NativeMethods.Api_SetFriendName(好友QQ, 备注名, _amandaAuthCodeContainer.AuthCode);

        /// <summary>
        ///
        /// </summary>
        /// <param name="好友QQ"></param>
        /// <returns></returns>
        void IAmandaApi.Api_DeleteFriend(string 好友QQ)
            => NativeMethods.Api_DeleteFriend(好友QQ, _amandaAuthCodeContainer.AuthCode);

        /// <summary>
        ///
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="附加信息"></param>
        /// <returns></returns>
        void IAmandaApi.Api_AddGroup(string 群号, string 附加信息)
            => NativeMethods.Api_AddGroup(群号, 附加信息, _amandaAuthCodeContainer.AuthCode);

        /// <summary>
        /// 返回网易云点歌XML
        /// </summary>
        /// <param name="歌曲ID"></param>
        /// <returns></returns>
        string IAmandaApi.Api_163Music(string 歌曲ID)
            => NativeMethods.Api_163Music(歌曲ID, _amandaAuthCodeContainer.AuthCode);

        /// <summary>
        /// 返回QQ点歌XML
        /// </summary>
        /// <param name="歌曲ID"></param>
        /// <returns></returns>
        string IAmandaApi.Api_QQMusic(string 歌曲ID)
            => NativeMethods.Api_QQMusic(歌曲ID, _amandaAuthCodeContainer.AuthCode);

        /// <summary>
        /// 返回Json点歌XML
        /// </summary>
        /// <param name="歌曲ID"></param>
        /// <returns></returns>
        string IAmandaApi.Api_JsonMusic(string 歌曲ID)
            => NativeMethods.Api_JsonMusic(歌曲ID, _amandaAuthCodeContainer.AuthCode);

        /// <summary>
        /// 置插件错误管理
        /// </summary>
        /// <param name="Code"></param>
        /// <param name="Str"></param>
        /// <returns></returns>
        string IAmandaApi.Api_Error(string Code, string Str)
            => NativeMethods.Api_Error(Code, Str, _amandaAuthCodeContainer.AuthCode);

        /// <summary>
        /// 取得群内成员的名片
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="QQ号"></param>
        /// <returns></returns>
        string IAmandaApi.Api_GetGroupCard(string 群号, string QQ号)
            => NativeMethods.Api_GetGroupCard(群号, QQ号, _amandaAuthCodeContainer.AuthCode);

        /// <summary>
        /// 取得某个QQ的昵称
        /// </summary>
        /// <param name="QQ号"></param>
        /// <returns></returns>
        string IAmandaApi.Api_GetNick(string QQ号)
            => NativeMethods.Api_GetNick(QQ号, _amandaAuthCodeContainer.AuthCode);

        /// <summary>
        /// 修改群内成员的名片
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="QQ号"></param>
        /// <param name="新名片"></param>
        /// <returns></returns>
        void IAmandaApi.Api_SetGroupCard(string 群号, string QQ号, string 新名片)
            => NativeMethods.Api_SetGroupCard(群号, QQ号, 新名片, _amandaAuthCodeContainer.AuthCode);

        /// <summary>
        /// 取得某个QQ的名片赞数量
        /// </summary>
        /// <param name="QQ号"></param>
        /// <returns></returns>
        string IAmandaApi.Api_GetPraiseNum(string QQ号)
            => NativeMethods.Api_GetPraiseNum(QQ号, _amandaAuthCodeContainer.AuthCode);

        /// <summary>
        /// 以JSON形式取得好友列表
        /// </summary>
        /// <returns></returns>
        string IAmandaApi.Api_GetFriendList()
            => NativeMethods.Api_GetFriendList(_amandaAuthCodeContainer.AuthCode);

        /// <summary>
        /// 以JSON形式取得群列表
        /// </summary>
        /// <returns></returns>
        string IAmandaApi.Api_GetGroupList()
            => NativeMethods.Api_GetGroupList(_amandaAuthCodeContainer.AuthCode);

        /// <summary>
        /// 以JSON形式取得群成员列表
        /// </summary>
        /// <param name="群号"></param>
        /// <returns></returns>
        string IAmandaApi.Api_GetGroupMemberList(string 群号)
            => NativeMethods.Api_GetGroupMemberList(群号, _amandaAuthCodeContainer.AuthCode);

        /// <summary>
        /// 改变QQ在线状态
        /// </summary>
        /// <param name="类型">1.我在线上 2.Q我吧 3.离开 4.忙碌 5.请勿打扰 6.隐身</param>
        /// <returns></returns>
        string IAmandaApi.Api_SetQQState(int 类型)
            => NativeMethods.Api_SetQQState(类型, _amandaAuthCodeContainer.AuthCode);

        private static class NativeMethods
        {
            public const string DllPath = @"bin\message.dll";
            [DllImport(DllPath)]
            public static extern int Api_SendPraise(string QQ号, string AuthCode);

            [DllImport(DllPath)]
            public static extern int Api_SendShake(string QQ号, string AuthCode);

            [DllImport(DllPath)]
            public static extern string Api_Getbkn(string AuthCode);

            [DllImport(DllPath)]
            public static extern int Api_QuitGroup(string 群号, string AuthCode);

            [DllImport(DllPath)]
            public static extern int Api_QuitDiscussGroup(string 讨论组号, string AuthCode);

            [DllImport(DllPath)]
            public static extern int Api_SetSignature(string 个性签名, string AuthCode);

            [DllImport(DllPath)]
            public static extern int Api_SetDiscussName(string 讨论组号, string 名称, string AuthCode);

            [DllImport(DllPath)]
            public static extern int Api_BanGroup(string 群号, bool 是否全群禁言, string AuthCode);

            [DllImport(DllPath)]
            public static extern int Api_RemoveGroup(string 群号, string AuthCode);

            [DllImport(DllPath)]
            public static extern int Api_SetManager(string 群号, string QQ号, bool 是否设置为管理员, string AuthCode);

            [DllImport(DllPath)]
            public static extern int Api_Ban(string 群号, string QQ, int 禁言时长, string AuthCode);

            [DllImport(DllPath)]
            public static extern int Api_SetAnony(string 群号, bool 是否允许匿名聊天, string AuthCode);

            [DllImport(DllPath)]
            public static extern int Api_RemoveMember(string 群号, string QQ号, bool 是否不再接收加群申请, string AuthCode);

            [DllImport(DllPath)]
            public static extern string Api_GetCookies(string AuthCode);

            [DllImport(DllPath)]
            public static extern string Api_GetClientKey(string AuthCode);

            [DllImport(DllPath)]
            public static extern string Api_GetLoginQQ(string AuthCode);

            [DllImport(DllPath)]
            public static extern bool Api_GetPluginState(string AuthCode);

            [DllImport(DllPath)]
            public static extern string Api_GetPath(string AuthCode);

            [DllImport(DllPath)]
            public static extern int Api_SendMsg(int 类型, string 群组, string QQ号, string 内容, string AuthCode);

            [DllImport(DllPath)]
            public static extern int Api_SetGroupAdd(string 群号, string QQ号, string Seq, int 操作方式, string 拒绝理由, string AuthCode);

            [DllImport(DllPath)]
            public static extern int Api_SetFriendAdd(string QQ号, int 操作方式, string 拒绝理由, string AuthCode);

            [DllImport(DllPath)]
            public static extern int Api_SendLog(string 类型, string 内容, int 字体颜色, string AuthCode);

            [DllImport(DllPath)]
            public static extern int Api_SetFriendName(string 好友QQ, string 备注名, string AuthCode);

            [DllImport(DllPath)]
            public static extern int Api_DeleteFriend(string 好友QQ, string AuthCode);

            [DllImport(DllPath)]
            public static extern int Api_AddGroup(string 群号, string 附加信息, string AuthCode);
            [DllImport(DllPath)]
            public static extern void Api_AddFriend(string 目标QQ, string 附加信息, string AuthCode);
            [DllImport(DllPath)]
            public static extern string Api_163Music(string 歌曲ID, string AuthCode);

            [DllImport(DllPath)]
            public static extern string Api_QQMusic(string 歌曲ID, string AuthCode);

            [DllImport(DllPath)]
            public static extern string Api_JsonMusic(string 歌曲ID, string AuthCode);

            [DllImport(DllPath)]
            public static extern string Api_Error(string Code, string Str, string AuthCode);

            [DllImport(DllPath)]
            public static extern string Api_GetGroupCard(string 群号, string QQ号, string AuthCode);

            [DllImport(DllPath)]
            public static extern string Api_GetNick(string QQ号, string AuthCode);

            [DllImport(DllPath)]
            public static extern int Api_SetGroupCard(string 群号, string QQ号, string 新名片, string AuthCode);

            [DllImport(DllPath)]
            public static extern string Api_GetPraiseNum(string QQ号, string AuthCode);

            [DllImport(DllPath)]
            public static extern string Api_GetFriendList(string AuthCode);

            [DllImport(DllPath)]
            public static extern string Api_GetGroupList(string AuthCode);

            [DllImport(DllPath)]
            public static extern string Api_GetGroupMemberList(string 群号, string AuthCode);

            [DllImport(DllPath)]
            public static extern string Api_GetQQInfo(string QQ号, string AuthCode);

            [DllImport(DllPath)]
            public static extern string Api_GetGroupInfo(string 群号, string AuthCode);

            [DllImport(DllPath)]
            public static extern string Api_Restart(string AuthCode);

            [DllImport(DllPath)]
            public static extern string Api_UpdatePlugin(string AuthCode);

            [DllImport(DllPath)]
            public static extern string Api_DeleteMsg(string 群号, string 消息ID, string AuthCode);

            [DllImport(DllPath)]
            public static extern string Api_SetQQState(int 类型, string AuthCode);

            [DllImport(DllPath)]
            public static extern string Api_InviteFriend(string 群号, string 好友QQ, string AuthCode);

            [DllImport(DllPath)]
            public static extern string Api_GetQQinfo_v2(string QQ号, string AuthCode);
        }
    }
}
