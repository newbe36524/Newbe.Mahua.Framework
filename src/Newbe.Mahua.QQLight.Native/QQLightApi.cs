using System.ComponentModel;
using System.Runtime.InteropServices;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Native
{
    public class QQLightApi : IQQLightApi
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="QQ号"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        void IQQLightApi.Api_SendPraise([Description("")] string QQ号, [Description("")] int AuthCode)
            => NativeMethods.Api_SendPraise(QQ号, AuthCode);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="QQ号"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        void IQQLightApi.Api_SendShake([Description("")] string QQ号, [Description("")] int AuthCode)
            => NativeMethods.Api_SendShake(QQ号, AuthCode);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        string IQQLightApi.Api_Getbkn([Description("")] int AuthCode)
            => NativeMethods.Api_Getbkn(AuthCode);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        void IQQLightApi.Api_QuitGroup([Description("")] string 群号, [Description("")] int AuthCode)
            => NativeMethods.Api_QuitGroup(群号, AuthCode);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="讨论组号"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        void IQQLightApi.Api_QuitDiscussGroup([Description("")] string 讨论组号, [Description("")] int AuthCode)
            => NativeMethods.Api_QuitDiscussGroup(讨论组号, AuthCode);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="个性签名"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        void IQQLightApi.Api_SetSignature([Description("")] string 个性签名, [Description("")] int AuthCode)
            => NativeMethods.Api_SetSignature(个性签名, AuthCode);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="讨论组号"></param>
        /// <param name="名称"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        void IQQLightApi.Api_SetDiscussName([Description("")] string 讨论组号, [Description("")] string 名称,
            [Description("")] int AuthCode)
            => NativeMethods.Api_SetDiscussName(讨论组号, 名称, AuthCode);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="是否全群禁言"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        void IQQLightApi.Api_BanGroup([Description("")] string 群号, [Description("")] bool 是否全群禁言,
            [Description("")] int AuthCode)
            => NativeMethods.Api_BanGroup(群号, 是否全群禁言, AuthCode);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        void IQQLightApi.Api_RemoveGroup([Description("")] string 群号, [Description("")] int AuthCode)
            => NativeMethods.Api_RemoveGroup(群号, AuthCode);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="QQ号"></param>
        /// <param name="是否设置为管理员">真,设置  假,取消</param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        void IQQLightApi.Api_SetManager([Description("")] string 群号, [Description("")] string QQ号,
            [Description("真,设置  假,取消")] bool 是否设置为管理员, [Description("")] int AuthCode)
            => NativeMethods.Api_SetManager(群号, QQ号, 是否设置为管理员, AuthCode);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="QQ"></param>
        /// <param name="禁言时长">单位:秒  0为解除禁言</param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        void IQQLightApi.Api_Ban([Description("")] string 群号, [Description("")] string QQ,
            [Description("单位:秒  0为解除禁言")] int 禁言时长, [Description("")] int AuthCode)
            => NativeMethods.Api_Ban(群号, QQ, 禁言时长, AuthCode);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="是否允许匿名聊天"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        void IQQLightApi.Api_SetAnony([Description("")] string 群号, [Description("")] bool 是否允许匿名聊天,
            [Description("")] int AuthCode)
            => NativeMethods.Api_SetAnony(群号, 是否允许匿名聊天, AuthCode);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="QQ号"></param>
        /// <param name="是否不再接收加群申请"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        void IQQLightApi.Api_RemoveMember([Description("")] string 群号, [Description("")] string QQ号,
            [Description("")] bool 是否不再接收加群申请, [Description("")] int AuthCode)
            => NativeMethods.Api_RemoveMember(群号, QQ号, 是否不再接收加群申请, AuthCode);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        string IQQLightApi.Api_GetCookies([Description("")] int AuthCode)
            => NativeMethods.Api_GetCookies(AuthCode);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        string IQQLightApi.Api_GetClientKey([Description("")] int AuthCode)
            => NativeMethods.Api_GetClientKey(AuthCode);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        string IQQLightApi.Api_GetLoginQQ([Description("")] int AuthCode)
            => NativeMethods.Api_GetLoginQQ(AuthCode);

        /// <summary>
        /// 是否开启/关闭
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        bool IQQLightApi.Api_GetPluginState([Description("")] int AuthCode)
            => NativeMethods.Api_GetPluginState(AuthCode);

        /// <summary>
        /// 框架为插件所创建的一个目录
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        string IQQLightApi.Api_GetPath([Description("")] int AuthCode)
            => NativeMethods.Api_GetPath(AuthCode);

        /// <summary>
        /// 机器人发送消息
        /// </summary>
        /// <param name="类型">1.好友消息 2.群消息 3.群临时消息 4.讨论组消息 5.讨论组临时消息 6.QQ临时消息</param>
        /// <param name="群组"></param>
        /// <param name="QQ号">类型为2，4时可留空</param>
        /// <param name="内容"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        void IQQLightApi.Api_SendMsg([Description("1.好友消息 2.群消息 3.群临时消息 4.讨论组消息 5.讨论组临时消息 6.QQ临时消息")]
            int 类型, [Description("")] string 群组, [Description("类型为2，4时可留空")] string QQ号, [Description("")] string 内容,
            [Description("")] int AuthCode)
            => NativeMethods.Api_SendMsg(类型, 群组, QQ号, 内容, AuthCode);

        /// <summary>
        /// 处理加群消息
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="QQ号"></param>
        /// <param name="Seq"></param>
        /// <param name="操作方式">1.同意 2.拒绝 3.忽略</param>
        /// <param name="拒绝理由">参数可为空，且为 拒绝 时有效</param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        void IQQLightApi.Api_SetGroupAdd([Description("")] string 群号, [Description("")] string QQ号,
            [Description("")] string Seq, [Description("1.同意 2.拒绝 3.忽略")] int 操作方式,
            [Description("参数可为空，且为 拒绝 时有效")] string 拒绝理由, [Description("")] int AuthCode)
            => NativeMethods.Api_SetGroupAdd(群号, QQ号, Seq, 操作方式, 拒绝理由, AuthCode);

        /// <summary>
        /// 处理加好友消息
        /// </summary>
        /// <param name="QQ号"></param>
        /// <param name="操作方式">1.同意 2.拒绝 3.忽略</param>
        /// <param name="拒绝理由">参数可为空，且为 拒绝 时有效</param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        void IQQLightApi.Api_SetFriendAdd([Description("")] string QQ号, [Description("1.同意 2.拒绝 3.忽略")] int 操作方式,
            [Description("参数可为空，且为 拒绝 时有效")] string 拒绝理由, [Description("")] int AuthCode)
            => NativeMethods.Api_SetFriendAdd(QQ号, 操作方式, 拒绝理由, AuthCode);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="类型"></param>
        /// <param name="内容"></param>
        /// <param name="字体颜色"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        void IQQLightApi.Api_SendLog([Description("")] string 类型, [Description("")] string 内容,
            [Description("")] int 字体颜色, [Description("")] int AuthCode)
            => NativeMethods.Api_SendLog(类型, 内容, 字体颜色, AuthCode);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="好友QQ"></param>
        /// <param name="备注名"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        void IQQLightApi.Api_SetFriendName([Description("")] string 好友QQ, [Description("")] string 备注名,
            [Description("")] int AuthCode)
            => NativeMethods.Api_SetFriendName(好友QQ, 备注名, AuthCode);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="好友QQ"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        void IQQLightApi.Api_DeleteFriend([Description("")] string 好友QQ, [Description("")] int AuthCode)
            => NativeMethods.Api_DeleteFriend(好友QQ, AuthCode);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="附加信息"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        void IQQLightApi.Api_AddGroup([Description("")] string 群号, [Description("")] string 附加信息,
            [Description("")] int AuthCode)
            => NativeMethods.Api_AddGroup(群号, 附加信息, AuthCode);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="目标QQ"></param>
        /// <param name="附加信息"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        void IQQLightApi.Api_AddFriend([Description("")] string 目标QQ, [Description("")] string 附加信息,
            [Description("")] int AuthCode)
            => NativeMethods.Api_AddFriend(目标QQ, 附加信息, AuthCode);

        /// <summary>
        /// 返回网易云点歌XML
        /// </summary>
        /// <param name="歌曲ID"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        string IQQLightApi.Api_163Music([Description("")] string 歌曲ID, [Description("")] int AuthCode)
            => NativeMethods.Api_163Music(歌曲ID, AuthCode);

        /// <summary>
        /// 返回QQ点歌XML
        /// </summary>
        /// <param name="歌曲ID"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        string IQQLightApi.Api_QQMusic([Description("")] string 歌曲ID, [Description("")] int AuthCode)
            => NativeMethods.Api_QQMusic(歌曲ID, AuthCode);

        /// <summary>
        /// 返回Json点歌XML
        /// </summary>
        /// <param name="歌曲ID"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        string IQQLightApi.Api_JsonMusic([Description("")] string 歌曲ID, [Description("")] int AuthCode)
            => NativeMethods.Api_JsonMusic(歌曲ID, AuthCode);

        /// <summary>
        /// 置插件错误管理
        /// </summary>
        /// <param name="Code"></param>
        /// <param name="Str"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        string IQQLightApi.Api_Error([Description("")] string Code, [Description("")] string Str,
            [Description("")] int AuthCode)
            => NativeMethods.Api_Error(Code, Str, AuthCode);

        /// <summary>
        /// 取得群内成员的名片
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="QQ号"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        string IQQLightApi.Api_GetGroupCard([Description("")] string 群号, [Description("")] string QQ号,
            [Description("")] int AuthCode)
            => NativeMethods.Api_GetGroupCard(群号, QQ号, AuthCode);

        /// <summary>
        /// 取得某个QQ的昵称
        /// </summary>
        /// <param name="QQ号"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        string IQQLightApi.Api_GetNick([Description("")] string QQ号, [Description("")] int AuthCode)
            => NativeMethods.Api_GetNick(QQ号, AuthCode);

        /// <summary>
        /// 修改群内成员的名片
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="QQ号"></param>
        /// <param name="新名片"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        void IQQLightApi.Api_SetGroupCard([Description("")] string 群号, [Description("")] string QQ号,
            [Description("")] string 新名片, [Description("")] int AuthCode)
            => NativeMethods.Api_SetGroupCard(群号, QQ号, 新名片, AuthCode);

        /// <summary>
        /// 取得某个QQ的名片赞数量
        /// </summary>
        /// <param name="QQ号"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        string IQQLightApi.Api_GetPraiseNum([Description("")] string QQ号, [Description("")] int AuthCode)
            => NativeMethods.Api_GetPraiseNum(QQ号, AuthCode);

        /// <summary>
        /// 以JSON形式取得好友列表
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        string IQQLightApi.Api_GetFriendList([Description("")] int AuthCode)
            => NativeMethods.Api_GetFriendList(AuthCode);

        /// <summary>
        /// 以JSON形式取得群列表
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        string IQQLightApi.Api_GetGroupList([Description("")] int AuthCode)
            => NativeMethods.Api_GetGroupList(AuthCode);

        /// <summary>
        /// 以JSON形式取得群成员列表
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        string IQQLightApi.Api_GetGroupMemberList([Description("")] string 群号, [Description("")] int AuthCode)
            => NativeMethods.Api_GetGroupMemberList(群号, AuthCode);

        /// <summary>
        /// 以JSON形式取得某QQ个人信息
        /// </summary>
        /// <param name="QQ号"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        string IQQLightApi.Api_GetQQInfo([Description("")] string QQ号, [Description("")] int AuthCode)
            => NativeMethods.Api_GetQQInfo(QQ号, AuthCode);

        /// <summary>
        /// 以JSON形式取得某群信息
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        string IQQLightApi.Api_GetGroupInfo([Description("")] string 群号, [Description("")] int AuthCode)
            => NativeMethods.Api_GetGroupInfo(群号, AuthCode);

        /// <summary>
        /// 让机器人快速重启
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        string IQQLightApi.Api_Restart([Description("")] int AuthCode)
            => NativeMethods.Api_Restart(AuthCode);

        /// <summary>
        /// 让机器人刷新插件
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        string IQQLightApi.Api_UpdatePlugin([Description("")] int AuthCode)
            => NativeMethods.Api_UpdatePlugin(AuthCode);

        /// <summary>
        /// 撤回群成员的消息 机器人必须为管理员
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="消息ID"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        string IQQLightApi.Api_DeleteMsg([Description("")] string 群号, [Description("")] string 消息ID,
            [Description("")] int AuthCode)
            => NativeMethods.Api_DeleteMsg(群号, 消息ID, AuthCode);

        /// <summary>
        /// 改变QQ在线状态
        /// </summary>
        /// <param name="类型">1.我在线上 2.Q我吧 3.离开 4.忙碌 5.请勿打扰 6.隐身</param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        string IQQLightApi.Api_SetQQState([Description("1.我在线上 2.Q我吧 3.离开 4.忙碌 5.请勿打扰 6.隐身")]
            int 类型, [Description("")] int AuthCode)
            => NativeMethods.Api_SetQQState(类型, AuthCode);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="好友QQ"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        void IQQLightApi.Api_InviteFriend([Description("")] string 群号, [Description("")] string 好友QQ,
            [Description("")] int AuthCode)
            => NativeMethods.Api_InviteFriend(群号, 好友QQ, AuthCode);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="QQ号"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        string IQQLightApi.Api_GetQQinfo_v2([Description("")] string QQ号, [Description("")] int AuthCode)
            => NativeMethods.Api_GetQQinfo_v2(QQ号, AuthCode);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="类型"></param>
        /// <param name="对象"></param>
        /// <param name="图片字节集">Hex形式</param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        string IQQLightApi.Api_UpLoadPic([Description("")] int 类型, [Description("")] string 对象,
            [Description("Hex形式")] string 图片字节集, [Description("")] int AuthCode)
            => NativeMethods.Api_UpLoadPic(类型, 对象, 图片字节集, AuthCode);

        private static class NativeMethods
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="QQ号"></param>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern void Api_SendPraise([Description("")] string QQ号, [Description("")] int AuthCode);

            /// <summary>
            /// 
            /// </summary>
            /// <param name="QQ号"></param>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern void Api_SendShake([Description("")] string QQ号, [Description("")] int AuthCode);

            /// <summary>
            /// 
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern string Api_Getbkn([Description("")] int AuthCode);

            /// <summary>
            /// 
            /// </summary>
            /// <param name="群号"></param>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern void Api_QuitGroup([Description("")] string 群号, [Description("")] int AuthCode);

            /// <summary>
            /// 
            /// </summary>
            /// <param name="讨论组号"></param>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern void Api_QuitDiscussGroup([Description("")] string 讨论组号,
                [Description("")] int AuthCode);

            /// <summary>
            /// 
            /// </summary>
            /// <param name="个性签名"></param>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern void Api_SetSignature([Description("")] string 个性签名,
                [Description("")] int AuthCode);

            /// <summary>
            /// 
            /// </summary>
            /// <param name="讨论组号"></param>
            /// <param name="名称"></param>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern void Api_SetDiscussName([Description("")] string 讨论组号, [Description("")] string 名称,
                [Description("")] int AuthCode);

            /// <summary>
            /// 
            /// </summary>
            /// <param name="群号"></param>
            /// <param name="是否全群禁言"></param>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern void Api_BanGroup([Description("")] string 群号, [Description("")] bool 是否全群禁言,
                [Description("")] int AuthCode);

            /// <summary>
            /// 
            /// </summary>
            /// <param name="群号"></param>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern void Api_RemoveGroup([Description("")] string 群号, [Description("")] int AuthCode);

            /// <summary>
            /// 
            /// </summary>
            /// <param name="群号"></param>
            /// <param name="QQ号"></param>
            /// <param name="是否设置为管理员">真,设置  假,取消</param>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern void Api_SetManager([Description("")] string 群号, [Description("")] string QQ号,
                [Description("真,设置  假,取消")] bool 是否设置为管理员, [Description("")] int AuthCode);

            /// <summary>
            /// 
            /// </summary>
            /// <param name="群号"></param>
            /// <param name="QQ"></param>
            /// <param name="禁言时长">单位:秒  0为解除禁言</param>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern void Api_Ban([Description("")] string 群号, [Description("")] string QQ,
                [Description("单位:秒  0为解除禁言")] int 禁言时长, [Description("")] int AuthCode);

            /// <summary>
            /// 
            /// </summary>
            /// <param name="群号"></param>
            /// <param name="是否允许匿名聊天"></param>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern void Api_SetAnony([Description("")] string 群号, [Description("")] bool 是否允许匿名聊天,
                [Description("")] int AuthCode);

            /// <summary>
            /// 
            /// </summary>
            /// <param name="群号"></param>
            /// <param name="QQ号"></param>
            /// <param name="是否不再接收加群申请"></param>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern void Api_RemoveMember([Description("")] string 群号, [Description("")] string QQ号,
                [Description("")] bool 是否不再接收加群申请, [Description("")] int AuthCode);

            /// <summary>
            /// 
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern string Api_GetCookies([Description("")] int AuthCode);

            /// <summary>
            /// 
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern string Api_GetClientKey([Description("")] int AuthCode);

            /// <summary>
            /// 
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern string Api_GetLoginQQ([Description("")] int AuthCode);

            /// <summary>
            /// 是否开启/关闭
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern bool Api_GetPluginState([Description("")] int AuthCode);

            /// <summary>
            /// 框架为插件所创建的一个目录
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern string Api_GetPath([Description("")] int AuthCode);

            /// <summary>
            /// 机器人发送消息
            /// </summary>
            /// <param name="类型">1.好友消息 2.群消息 3.群临时消息 4.讨论组消息 5.讨论组临时消息 6.QQ临时消息</param>
            /// <param name="群组"></param>
            /// <param name="QQ号">类型为2，4时可留空</param>
            /// <param name="内容"></param>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern void Api_SendMsg([Description("1.好友消息 2.群消息 3.群临时消息 4.讨论组消息 5.讨论组临时消息 6.QQ临时消息")]
                int 类型, [Description("")] string 群组, [Description("类型为2，4时可留空")] string QQ号,
                [Description("")] string 内容, [Description("")] int AuthCode);

            /// <summary>
            /// 处理加群消息
            /// </summary>
            /// <param name="群号"></param>
            /// <param name="QQ号"></param>
            /// <param name="Seq"></param>
            /// <param name="操作方式">1.同意 2.拒绝 3.忽略</param>
            /// <param name="拒绝理由">参数可为空，且为 拒绝 时有效</param>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern void Api_SetGroupAdd([Description("")] string 群号, [Description("")] string QQ号,
                [Description("")] string Seq, [Description("1.同意 2.拒绝 3.忽略")] int 操作方式,
                [Description("参数可为空，且为 拒绝 时有效")] string 拒绝理由, [Description("")] int AuthCode);

            /// <summary>
            /// 处理加好友消息
            /// </summary>
            /// <param name="QQ号"></param>
            /// <param name="操作方式">1.同意 2.拒绝 3.忽略</param>
            /// <param name="拒绝理由">参数可为空，且为 拒绝 时有效</param>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern void Api_SetFriendAdd([Description("")] string QQ号,
                [Description("1.同意 2.拒绝 3.忽略")] int 操作方式, [Description("参数可为空，且为 拒绝 时有效")] string 拒绝理由,
                [Description("")] int AuthCode);

            /// <summary>
            /// 
            /// </summary>
            /// <param name="类型"></param>
            /// <param name="内容"></param>
            /// <param name="字体颜色"></param>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern void Api_SendLog([Description("")] string 类型, [Description("")] string 内容,
                [Description("")] int 字体颜色, [Description("")] int AuthCode);

            /// <summary>
            /// 
            /// </summary>
            /// <param name="好友QQ"></param>
            /// <param name="备注名"></param>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern void Api_SetFriendName([Description("")] string 好友QQ, [Description("")] string 备注名,
                [Description("")] int AuthCode);

            /// <summary>
            /// 
            /// </summary>
            /// <param name="好友QQ"></param>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern void Api_DeleteFriend([Description("")] string 好友QQ,
                [Description("")] int AuthCode);

            /// <summary>
            /// 
            /// </summary>
            /// <param name="群号"></param>
            /// <param name="附加信息"></param>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern void Api_AddGroup([Description("")] string 群号, [Description("")] string 附加信息,
                [Description("")] int AuthCode);

            /// <summary>
            /// 
            /// </summary>
            /// <param name="目标QQ"></param>
            /// <param name="附加信息"></param>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern void Api_AddFriend([Description("")] string 目标QQ, [Description("")] string 附加信息,
                [Description("")] int AuthCode);

            /// <summary>
            /// 返回网易云点歌XML
            /// </summary>
            /// <param name="歌曲ID"></param>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern string Api_163Music([Description("")] string 歌曲ID, [Description("")] int AuthCode);

            /// <summary>
            /// 返回QQ点歌XML
            /// </summary>
            /// <param name="歌曲ID"></param>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern string Api_QQMusic([Description("")] string 歌曲ID, [Description("")] int AuthCode);

            /// <summary>
            /// 返回Json点歌XML
            /// </summary>
            /// <param name="歌曲ID"></param>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern string Api_JsonMusic([Description("")] string 歌曲ID, [Description("")] int AuthCode);

            /// <summary>
            /// 置插件错误管理
            /// </summary>
            /// <param name="Code"></param>
            /// <param name="Str"></param>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern string Api_Error([Description("")] string Code, [Description("")] string Str,
                [Description("")] int AuthCode);

            /// <summary>
            /// 取得群内成员的名片
            /// </summary>
            /// <param name="群号"></param>
            /// <param name="QQ号"></param>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern string Api_GetGroupCard([Description("")] string 群号, [Description("")] string QQ号,
                [Description("")] int AuthCode);

            /// <summary>
            /// 取得某个QQ的昵称
            /// </summary>
            /// <param name="QQ号"></param>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern string Api_GetNick([Description("")] string QQ号, [Description("")] int AuthCode);

            /// <summary>
            /// 修改群内成员的名片
            /// </summary>
            /// <param name="群号"></param>
            /// <param name="QQ号"></param>
            /// <param name="新名片"></param>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern void Api_SetGroupCard([Description("")] string 群号, [Description("")] string QQ号,
                [Description("")] string 新名片, [Description("")] int AuthCode);

            /// <summary>
            /// 取得某个QQ的名片赞数量
            /// </summary>
            /// <param name="QQ号"></param>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern string Api_GetPraiseNum([Description("")] string QQ号,
                [Description("")] int AuthCode);

            /// <summary>
            /// 以JSON形式取得好友列表
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern string Api_GetFriendList([Description("")] int AuthCode);

            /// <summary>
            /// 以JSON形式取得群列表
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern string Api_GetGroupList([Description("")] int AuthCode);

            /// <summary>
            /// 以JSON形式取得群成员列表
            /// </summary>
            /// <param name="群号"></param>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern string Api_GetGroupMemberList([Description("")] string 群号,
                [Description("")] int AuthCode);

            /// <summary>
            /// 以JSON形式取得某QQ个人信息
            /// </summary>
            /// <param name="QQ号"></param>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern string Api_GetQQInfo([Description("")] string QQ号, [Description("")] int AuthCode);

            /// <summary>
            /// 以JSON形式取得某群信息
            /// </summary>
            /// <param name="群号"></param>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern string
                Api_GetGroupInfo([Description("")] string 群号, [Description("")] int AuthCode);

            /// <summary>
            /// 让机器人快速重启
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern string Api_Restart([Description("")] int AuthCode);

            /// <summary>
            /// 让机器人刷新插件
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern string Api_UpdatePlugin([Description("")] int AuthCode);

            /// <summary>
            /// 撤回群成员的消息 机器人必须为管理员
            /// </summary>
            /// <param name="群号"></param>
            /// <param name="消息ID"></param>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern string Api_DeleteMsg([Description("")] string 群号, [Description("")] string 消息ID,
                [Description("")] int AuthCode);

            /// <summary>
            /// 改变QQ在线状态
            /// </summary>
            /// <param name="类型">1.我在线上 2.Q我吧 3.离开 4.忙碌 5.请勿打扰 6.隐身</param>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern string Api_SetQQState([Description("1.我在线上 2.Q我吧 3.离开 4.忙碌 5.请勿打扰 6.隐身")]
                int 类型, [Description("")] int AuthCode);

            /// <summary>
            /// 
            /// </summary>
            /// <param name="群号"></param>
            /// <param name="好友QQ"></param>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern void Api_InviteFriend([Description("")] string 群号, [Description("")] string 好友QQ,
                [Description("")] int AuthCode);

            /// <summary>
            /// 
            /// </summary>
            /// <param name="QQ号"></param>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern string Api_GetQQinfo_v2([Description("")] string QQ号,
                [Description("")] int AuthCode);

            /// <summary>
            /// 
            /// </summary>
            /// <param name="类型"></param>
            /// <param name="对象"></param>
            /// <param name="图片字节集">Hex形式</param>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("bin/message.dll")]
            public static extern string Api_UpLoadPic([Description("")] int 类型, [Description("")] string 对象,
                [Description("Hex形式")] string 图片字节集, [Description("")] int AuthCode);
        }
    }
}