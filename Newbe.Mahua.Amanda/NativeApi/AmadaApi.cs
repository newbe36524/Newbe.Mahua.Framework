using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Newbe.Mahua.Amanda.NativeApi
{
    public interface IAmadaApi
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="QQ号"></param>
        /// <returns></returns>
        void Api_点赞(string QQ号);

        /// <summary>
        ///
        /// </summary>
        /// <param name="QQ号"></param>
        /// <returns></returns>
        void Api_抖动好友窗口(string QQ号);

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        string Api_取bkn();

        /// <summary>
        ///
        /// </summary>
        /// <param name="群号"></param>
        /// <returns></returns>
        void Api_退出群(string 群号);

        /// <summary>
        ///
        /// </summary>
        /// <param name="讨论组号"></param>
        /// <returns></returns>
        void Api_退出讨论组(string 讨论组号);

        /// <summary>
        ///
        /// </summary>
        /// <param name="个性签名"></param>
        /// <returns></returns>
        void Api_修改个性签名(string 个性签名);

        /// <summary>
        ///
        /// </summary>
        /// <param name="讨论组号"></param>
        /// <param name="名称"></param>
        /// <returns></returns>
        void Api_修改讨论组名称(string 讨论组号, string 名称);

        /// <summary>
        ///
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="是否全群禁言"></param>
        /// <returns></returns>
        void Api_置全群禁言(string 群号, bool 是否全群禁言);

        /// <summary>
        ///
        /// </summary>
        /// <param name="群号"></param>
        /// <returns></returns>
        void Api_解散群(string 群号);

        /// <summary>
        ///
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="QQ号"></param>
        /// <param name="是否设置为管理员">真,设置  假,取消</param>
        /// <returns></returns>
        void Api_置群管理(string 群号, string QQ号, bool 是否设置为管理员);

        /// <summary>
        ///
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="QQ"></param>
        /// <param name="禁言时长">单位:秒  0为解除禁言</param>
        /// <returns></returns>
        void Api_禁言(string 群号, string QQ, int 禁言时长);

        /// <summary>
        ///
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="是否允许匿名聊天"></param>
        /// <returns></returns>
        void Api_置群匿名(string 群号, bool 是否允许匿名聊天);

        /// <summary>
        ///
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="QQ号"></param>
        /// <param name="是否不再接收加群申请"></param>
        /// <returns></returns>
        void Api_移除群成员(string 群号, string QQ号, bool 是否不再接收加群申请);

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        string Api_取Cookies();

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        string Api_取登录QQ();

        /// <summary>
        /// 是否开启/关闭
        /// </summary>
        /// <returns></returns>
        bool Api_取插件当前状态();

        /// <summary>
        /// 框架为插件所创建的一个目录
        /// </summary>
        /// <returns></returns>
        string Api_取插件目录();

        /// <summary>
        /// 机器人发送消息
        /// </summary>
        /// <param name="类型">1.好友消息 2.群消息 3.群临时消息 4.讨论组消息 5.讨论组临时消息</param>
        /// <param name="群组">类型不为1时为群号/讨论组号  类型为1时可留空</param>
        /// <param name="QQ号">类型为2，4时可留空</param>
        /// <param name="内容"></param>
        /// <returns></returns>
        void Api_发送消息(string 类型, string 群组, string QQ号, string 内容);

        /// <summary>
        /// 处理加群消息
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="QQ号"></param>
        /// <param name="Seq"></param>
        /// <param name="操作方式">1.同意 2.拒绝 3.忽略</param>
        /// <param name="拒绝理由">参数可为空，且为 拒绝 时有效</param>
        /// <returns></returns>
        void Api_置群添加请求(string 群号, string QQ号, string Seq, int 操作方式, string 拒绝理由);

        /// <summary>
        /// 处理加好友消息
        /// </summary>
        /// <param name="QQ号"></param>
        /// <param name="操作方式">1.同意 2.拒绝 3.忽略</param>
        /// <param name="拒绝理由">参数可为空，且为 拒绝 时有效</param>
        /// <returns></returns>
        void Api_置好友添加请求(string QQ号, int 操作方式, string 拒绝理由);

        /// <summary>
        /// 总共五种积分类型，取出对应序号的积分名称，返回空
        /// </summary>
        /// <param name="积分类型"></param>
        /// <returns></returns>
        string Api_取积分名称(int 积分类型);

        /// <summary>
        /// 取得当前某一类型积分是全局的还是分群的 0.全局 1.分群 -1.该积分未被启用
        /// </summary>
        /// <param name="积分类型"></param>
        /// <returns></returns>
        int Api_取积分状态(int 积分类型);

        /// <summary>
        /// 修改成功返回积分数值，失败返回-1
        /// </summary>
        /// <param name="积分类型"></param>
        /// <param name="群号">如果积分库是全局的 则不用填写此参数</param>
        /// <param name="QQ号"></param>
        /// <param name="积分数值"></param>
        /// <returns></returns>
        long Api_修改积分数值(int 积分类型, string 群号, string QQ号, long 积分数值);

        /// <summary>
        /// 修改成功返回积分数值，失败返回-1
        /// </summary>
        /// <param name="积分类型"></param>
        /// <param name="群号">如果积分库是全局的 则不用填写此参数</param>
        /// <param name="QQ号"></param>
        /// <param name="积分数值"></param>
        /// <returns></returns>
        long Api_增加积分(int 积分类型, string 群号, string QQ号, long 积分数值);

        /// <summary>
        /// 修改成功返回积分数值，失败返回-1
        /// </summary>
        /// <param name="积分类型"></param>
        /// <param name="群号">如果积分库是全局的 则不用填写此参数</param>
        /// <param name="QQ号"></param>
        /// <param name="积分数值"></param>
        /// <returns></returns>
        long Api_减少积分(int 积分类型, string 群号, string QQ号, long 积分数值);

        /// <summary>
        ///
        /// </summary>
        /// <param name="类型"></param>
        /// <param name="内容"></param>
        /// <param name="字体颜色"></param>
        /// <returns></returns>
        void Api_输出日志(string 类型, string 内容, int 字体颜色);

        /// <summary>
        ///
        /// </summary>
        /// <param name="好友QQ"></param>
        /// <param name="备注名"></param>
        /// <returns></returns>
        void Api_修改好友备注(string 好友QQ, string 备注名);

        /// <summary>
        ///
        /// </summary>
        /// <param name="好友QQ"></param>
        /// <returns></returns>
        void Api_删除好友(string 好友QQ);

        /// <summary>
        ///
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="附加信息"></param>
        /// <returns></returns>
        void Api_加群(string 群号, string 附加信息);

        /// <summary>
        /// 返回网易云点歌XML
        /// </summary>
        /// <param name="歌曲ID"></param>
        /// <returns></returns>
        string Api_网易云点歌(string 歌曲ID);

        /// <summary>
        /// 返回QQ点歌XML
        /// </summary>
        /// <param name="歌曲ID"></param>
        /// <returns></returns>
        string Api_QQ点歌(string 歌曲ID);

        /// <summary>
        /// 返回Json点歌XML
        /// </summary>
        /// <param name="歌曲ID"></param>
        /// <returns></returns>
        string Api_新点歌(string 歌曲ID);

        /// <summary>
        /// 置插件错误管理
        /// </summary>
        /// <param name="Code"></param>
        /// <param name="Str"></param>
        /// <returns></returns>
        string Api_置插件错误提示(string Code, string Str);

        /// <summary>
        /// 取得群内成员的名片
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="QQ号"></param>
        /// <returns></returns>
        string Api_取群名片(string 群号, string QQ号);

        /// <summary>
        /// 取得某个QQ的昵称
        /// </summary>
        /// <param name="QQ号"></param>
        /// <returns></returns>
        string Api_取昵称(string QQ号);

        /// <summary>
        /// 修改群内成员的名片
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="QQ号"></param>
        /// <param name="新名片"></param>
        /// <returns></returns>
        void Api_修改群名片(string 群号, string QQ号, string 新名片);

        /// <summary>
        /// 取得某个QQ的名片赞数量
        /// </summary>
        /// <param name="QQ号"></param>
        /// <returns></returns>
        string Api_取名片赞数量(string QQ号);

        /// <summary>
        /// 以JSON形式取得好友列表
        /// </summary>
        /// <returns></returns>
        string Api_取好友列表();

        /// <summary>
        /// 以JSON形式取得群列表
        /// </summary>
        /// <returns></returns>
        string Api_取群列表();

        /// <summary>
        /// 以JSON形式取得群成员列表
        /// </summary>
        /// <param name="群号"></param>
        /// <returns></returns>
        string Api_取群成员列表(string 群号);

        /// <summary>
        /// 改变QQ在线状态
        /// </summary>
        /// <param name="类型">1.我在线上 2.Q我吧 3.离开 4.忙碌 5.请勿打扰 6.隐身</param>
        /// <returns></returns>
        string Api_置在线状态(int 类型);
    }

    public class AmadaApi : IAmadaApi
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="QQ号"></param>
        /// <returns></returns>
        void IAmadaApi.Api_点赞(string QQ号)
            => NativeMethods.Api_点赞(QQ号);

        /// <summary>
        ///
        /// </summary>
        /// <param name="QQ号"></param>
        /// <returns></returns>
        void IAmadaApi.Api_抖动好友窗口(string QQ号)
            => NativeMethods.Api_抖动好友窗口(QQ号);

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        string IAmadaApi.Api_取bkn()
            => NativeMethods.Api_取bkn();

        /// <summary>
        ///
        /// </summary>
        /// <param name="群号"></param>
        /// <returns></returns>
        void IAmadaApi.Api_退出群(string 群号)
            => NativeMethods.Api_退出群(群号);

        /// <summary>
        ///
        /// </summary>
        /// <param name="讨论组号"></param>
        /// <returns></returns>
        void IAmadaApi.Api_退出讨论组(string 讨论组号)
            => NativeMethods.Api_退出讨论组(讨论组号);

        /// <summary>
        ///
        /// </summary>
        /// <param name="个性签名"></param>
        /// <returns></returns>
        void IAmadaApi.Api_修改个性签名(string 个性签名)
            => NativeMethods.Api_修改个性签名(个性签名);

        /// <summary>
        ///
        /// </summary>
        /// <param name="讨论组号"></param>
        /// <param name="名称"></param>
        /// <returns></returns>
        void IAmadaApi.Api_修改讨论组名称(string 讨论组号, string 名称)
            => NativeMethods.Api_修改讨论组名称(讨论组号, 名称);

        /// <summary>
        ///
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="是否全群禁言"></param>
        /// <returns></returns>
        void IAmadaApi.Api_置全群禁言(string 群号, bool 是否全群禁言)
            => NativeMethods.Api_置全群禁言(群号, 是否全群禁言);

        /// <summary>
        ///
        /// </summary>
        /// <param name="群号"></param>
        /// <returns></returns>
        void IAmadaApi.Api_解散群(string 群号)
            => NativeMethods.Api_解散群(群号);

        /// <summary>
        ///
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="QQ号"></param>
        /// <param name="是否设置为管理员">真,设置  假,取消</param>
        /// <returns></returns>
        void IAmadaApi.Api_置群管理(string 群号, string QQ号, bool 是否设置为管理员)
            => NativeMethods.Api_置群管理(群号, QQ号, 是否设置为管理员);

        /// <summary>
        ///
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="QQ"></param>
        /// <param name="禁言时长">单位:秒  0为解除禁言</param>
        /// <returns></returns>
        void IAmadaApi.Api_禁言(string 群号, string QQ, int 禁言时长)
            => NativeMethods.Api_禁言(群号, QQ, 禁言时长);

        /// <summary>
        ///
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="是否允许匿名聊天"></param>
        /// <returns></returns>
        void IAmadaApi.Api_置群匿名(string 群号, bool 是否允许匿名聊天)
            => NativeMethods.Api_置群匿名(群号, 是否允许匿名聊天);

        /// <summary>
        ///
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="QQ号"></param>
        /// <param name="是否不再接收加群申请"></param>
        /// <returns></returns>
        void IAmadaApi.Api_移除群成员(string 群号, string QQ号, bool 是否不再接收加群申请)
            => NativeMethods.Api_移除群成员(群号, QQ号, 是否不再接收加群申请);

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        string IAmadaApi.Api_取Cookies()
            => NativeMethods.Api_取Cookies();

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        string IAmadaApi.Api_取登录QQ()
            => NativeMethods.Api_取登录QQ();

        /// <summary>
        /// 是否开启/关闭
        /// </summary>
        /// <returns></returns>
        bool IAmadaApi.Api_取插件当前状态()
            => NativeMethods.Api_取插件当前状态();

        /// <summary>
        /// 框架为插件所创建的一个目录
        /// </summary>
        /// <returns></returns>
        string IAmadaApi.Api_取插件目录()
            => NativeMethods.Api_取插件目录();

        /// <summary>
        /// 机器人发送消息
        /// </summary>
        /// <param name="类型">1.好友消息 2.群消息 3.群临时消息 4.讨论组消息 5.讨论组临时消息</param>
        /// <param name="群组">类型不为1时为群号/讨论组号  类型为1时可留空</param>
        /// <param name="QQ号">类型为2，4时可留空</param>
        /// <param name="内容"></param>
        /// <returns></returns>
        void IAmadaApi.Api_发送消息(string 类型, string 群组, string QQ号, string 内容)
            => NativeMethods.Api_发送消息(类型, 群组, QQ号, 内容);

        /// <summary>
        /// 处理加群消息
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="QQ号"></param>
        /// <param name="Seq"></param>
        /// <param name="操作方式">1.同意 2.拒绝 3.忽略</param>
        /// <param name="拒绝理由">参数可为空，且为 拒绝 时有效</param>
        /// <returns></returns>
        void IAmadaApi.Api_置群添加请求(string 群号, string QQ号, string Seq, int 操作方式, string 拒绝理由)
            => NativeMethods.Api_置群添加请求(群号, QQ号, Seq, 操作方式, 拒绝理由);

        /// <summary>
        /// 处理加好友消息
        /// </summary>
        /// <param name="QQ号"></param>
        /// <param name="操作方式">1.同意 2.拒绝 3.忽略</param>
        /// <param name="拒绝理由">参数可为空，且为 拒绝 时有效</param>
        /// <returns></returns>
        void IAmadaApi.Api_置好友添加请求(string QQ号, int 操作方式, string 拒绝理由)
            => NativeMethods.Api_置好友添加请求(QQ号, 操作方式, 拒绝理由);

        /// <summary>
        /// 总共五种积分类型，取出对应序号的积分名称，返回空
        /// </summary>
        /// <param name="积分类型"></param>
        /// <returns></returns>
        string IAmadaApi.Api_取积分名称(int 积分类型)
            => NativeMethods.Api_取积分名称(积分类型);

        /// <summary>
        /// 取得当前某一类型积分是全局的还是分群的 0.全局 1.分群 -1.该积分未被启用
        /// </summary>
        /// <param name="积分类型"></param>
        /// <returns></returns>
        int IAmadaApi.Api_取积分状态(int 积分类型)
            => NativeMethods.Api_取积分状态(积分类型);

        /// <summary>
        /// 修改成功返回积分数值，失败返回-1
        /// </summary>
        /// <param name="积分类型"></param>
        /// <param name="群号">如果积分库是全局的 则不用填写此参数</param>
        /// <param name="QQ号"></param>
        /// <param name="积分数值"></param>
        /// <returns></returns>
        long IAmadaApi.Api_修改积分数值(int 积分类型, string 群号, string QQ号, long 积分数值)
            => NativeMethods.Api_修改积分数值(积分类型, 群号, QQ号, 积分数值);

        /// <summary>
        /// 修改成功返回积分数值，失败返回-1
        /// </summary>
        /// <param name="积分类型"></param>
        /// <param name="群号">如果积分库是全局的 则不用填写此参数</param>
        /// <param name="QQ号"></param>
        /// <param name="积分数值"></param>
        /// <returns></returns>
        long IAmadaApi.Api_增加积分(int 积分类型, string 群号, string QQ号, long 积分数值)
            => NativeMethods.Api_增加积分(积分类型, 群号, QQ号, 积分数值);

        /// <summary>
        /// 修改成功返回积分数值，失败返回-1
        /// </summary>
        /// <param name="积分类型"></param>
        /// <param name="群号">如果积分库是全局的 则不用填写此参数</param>
        /// <param name="QQ号"></param>
        /// <param name="积分数值"></param>
        /// <returns></returns>
        long IAmadaApi.Api_减少积分(int 积分类型, string 群号, string QQ号, long 积分数值)
            => NativeMethods.Api_减少积分(积分类型, 群号, QQ号, 积分数值);

        /// <summary>
        ///
        /// </summary>
        /// <param name="类型"></param>
        /// <param name="内容"></param>
        /// <param name="字体颜色"></param>
        /// <returns></returns>
        void IAmadaApi.Api_输出日志(string 类型, string 内容, int 字体颜色)
            => NativeMethods.Api_输出日志(类型, 内容, 字体颜色);

        /// <summary>
        ///
        /// </summary>
        /// <param name="好友QQ"></param>
        /// <param name="备注名"></param>
        /// <returns></returns>
        void IAmadaApi.Api_修改好友备注(string 好友QQ, string 备注名)
            => NativeMethods.Api_修改好友备注(好友QQ, 备注名);

        /// <summary>
        ///
        /// </summary>
        /// <param name="好友QQ"></param>
        /// <returns></returns>
        void IAmadaApi.Api_删除好友(string 好友QQ)
            => NativeMethods.Api_删除好友(好友QQ);

        /// <summary>
        ///
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="附加信息"></param>
        /// <returns></returns>
        void IAmadaApi.Api_加群(string 群号, string 附加信息)
            => NativeMethods.Api_加群(群号, 附加信息);

        /// <summary>
        /// 返回网易云点歌XML
        /// </summary>
        /// <param name="歌曲ID"></param>
        /// <returns></returns>
        string IAmadaApi.Api_网易云点歌(string 歌曲ID)
            => NativeMethods.Api_网易云点歌(歌曲ID);

        /// <summary>
        /// 返回QQ点歌XML
        /// </summary>
        /// <param name="歌曲ID"></param>
        /// <returns></returns>
        string IAmadaApi.Api_QQ点歌(string 歌曲ID)
            => NativeMethods.Api_QQ点歌(歌曲ID);

        /// <summary>
        /// 返回Json点歌XML
        /// </summary>
        /// <param name="歌曲ID"></param>
        /// <returns></returns>
        string IAmadaApi.Api_新点歌(string 歌曲ID)
            => NativeMethods.Api_新点歌(歌曲ID);

        /// <summary>
        /// 置插件错误管理
        /// </summary>
        /// <param name="Code"></param>
        /// <param name="Str"></param>
        /// <returns></returns>
        string IAmadaApi.Api_置插件错误提示(string Code, string Str)
            => NativeMethods.Api_置插件错误提示(Code, Str);

        /// <summary>
        /// 取得群内成员的名片
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="QQ号"></param>
        /// <returns></returns>
        string IAmadaApi.Api_取群名片(string 群号, string QQ号)
            => NativeMethods.Api_取群名片(群号, QQ号);

        /// <summary>
        /// 取得某个QQ的昵称
        /// </summary>
        /// <param name="QQ号"></param>
        /// <returns></returns>
        string IAmadaApi.Api_取昵称(string QQ号)
            => NativeMethods.Api_取昵称(QQ号);

        /// <summary>
        /// 修改群内成员的名片
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="QQ号"></param>
        /// <param name="新名片"></param>
        /// <returns></returns>
        void IAmadaApi.Api_修改群名片(string 群号, string QQ号, string 新名片)
            => NativeMethods.Api_修改群名片(群号, QQ号, 新名片);

        /// <summary>
        /// 取得某个QQ的名片赞数量
        /// </summary>
        /// <param name="QQ号"></param>
        /// <returns></returns>
        string IAmadaApi.Api_取名片赞数量(string QQ号)
            => NativeMethods.Api_取名片赞数量(QQ号);

        /// <summary>
        /// 以JSON形式取得好友列表
        /// </summary>
        /// <returns></returns>
        string IAmadaApi.Api_取好友列表()
            => NativeMethods.Api_取好友列表();

        /// <summary>
        /// 以JSON形式取得群列表
        /// </summary>
        /// <returns></returns>
        string IAmadaApi.Api_取群列表()
            => NativeMethods.Api_取群列表();

        /// <summary>
        /// 以JSON形式取得群成员列表
        /// </summary>
        /// <param name="群号"></param>
        /// <returns></returns>
        string IAmadaApi.Api_取群成员列表(string 群号)
            => NativeMethods.Api_取群成员列表(群号);

        /// <summary>
        /// 改变QQ在线状态
        /// </summary>
        /// <param name="类型">1.我在线上 2.Q我吧 3.离开 4.忙碌 5.请勿打扰 6.隐身</param>
        /// <returns></returns>
        string IAmadaApi.Api_置在线状态(int 类型)
            => NativeMethods.Api_置在线状态(类型);

        private static class NativeMethods
        {
            /// <summary>
            ///
            /// </summary>
            /// <param name="QQ号"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern void Api_点赞(string QQ号);

            /// <summary>
            ///
            /// </summary>
            /// <param name="QQ号"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern void Api_抖动好友窗口(string QQ号);

            /// <summary>
            ///
            /// </summary>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern string Api_取bkn();

            /// <summary>
            ///
            /// </summary>
            /// <param name="群号"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern void Api_退出群(string 群号);

            /// <summary>
            ///
            /// </summary>
            /// <param name="讨论组号"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern void Api_退出讨论组(string 讨论组号);

            /// <summary>
            ///
            /// </summary>
            /// <param name="个性签名"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern void Api_修改个性签名(string 个性签名);

            /// <summary>
            ///
            /// </summary>
            /// <param name="讨论组号"></param>
            /// <param name="名称"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern void Api_修改讨论组名称(string 讨论组号, string 名称);

            /// <summary>
            ///
            /// </summary>
            /// <param name="群号"></param>
            /// <param name="是否全群禁言"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern void Api_置全群禁言(string 群号, bool 是否全群禁言);

            /// <summary>
            ///
            /// </summary>
            /// <param name="群号"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern void Api_解散群(string 群号);

            /// <summary>
            ///
            /// </summary>
            /// <param name="群号"></param>
            /// <param name="QQ号"></param>
            /// <param name="是否设置为管理员">真,设置  假,取消</param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern void Api_置群管理(string 群号, string QQ号, bool 是否设置为管理员);

            /// <summary>
            ///
            /// </summary>
            /// <param name="群号"></param>
            /// <param name="QQ"></param>
            /// <param name="禁言时长">单位:秒  0为解除禁言</param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern void Api_禁言(string 群号, string QQ, int 禁言时长);

            /// <summary>
            ///
            /// </summary>
            /// <param name="群号"></param>
            /// <param name="是否允许匿名聊天"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern void Api_置群匿名(string 群号, bool 是否允许匿名聊天);

            /// <summary>
            ///
            /// </summary>
            /// <param name="群号"></param>
            /// <param name="QQ号"></param>
            /// <param name="是否不再接收加群申请"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern void Api_移除群成员(string 群号, string QQ号, bool 是否不再接收加群申请);

            /// <summary>
            ///
            /// </summary>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern string Api_取Cookies();

            /// <summary>
            ///
            /// </summary>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern string Api_取登录QQ();

            /// <summary>
            /// 是否开启/关闭
            /// </summary>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern bool Api_取插件当前状态();

            /// <summary>
            /// 框架为插件所创建的一个目录
            /// </summary>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern string Api_取插件目录();

            /// <summary>
            /// 机器人发送消息
            /// </summary>
            /// <param name="类型">1.好友消息 2.群消息 3.群临时消息 4.讨论组消息 5.讨论组临时消息</param>
            /// <param name="群组">类型不为1时为群号/讨论组号  类型为1时可留空</param>
            /// <param name="QQ号">类型为2，4时可留空</param>
            /// <param name="内容"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern void Api_发送消息(string 类型, string 群组, string QQ号, string 内容);

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
            public static extern void Api_置群添加请求(string 群号, string QQ号, string Seq, int 操作方式, string 拒绝理由);

            /// <summary>
            /// 处理加好友消息
            /// </summary>
            /// <param name="QQ号"></param>
            /// <param name="操作方式">1.同意 2.拒绝 3.忽略</param>
            /// <param name="拒绝理由">参数可为空，且为 拒绝 时有效</param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern void Api_置好友添加请求(string QQ号, int 操作方式, string 拒绝理由);

            /// <summary>
            /// 总共五种积分类型，取出对应序号的积分名称，返回空
            /// </summary>
            /// <param name="积分类型"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern string Api_取积分名称(int 积分类型);

            /// <summary>
            /// 取得当前某一类型积分是全局的还是分群的 0.全局 1.分群 -1.该积分未被启用
            /// </summary>
            /// <param name="积分类型"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern int Api_取积分状态(int 积分类型);

            /// <summary>
            /// 修改成功返回积分数值，失败返回-1
            /// </summary>
            /// <param name="积分类型"></param>
            /// <param name="群号">如果积分库是全局的 则不用填写此参数</param>
            /// <param name="QQ号"></param>
            /// <param name="积分数值"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern long Api_修改积分数值(int 积分类型, string 群号, string QQ号, long 积分数值);

            /// <summary>
            /// 修改成功返回积分数值，失败返回-1
            /// </summary>
            /// <param name="积分类型"></param>
            /// <param name="群号">如果积分库是全局的 则不用填写此参数</param>
            /// <param name="QQ号"></param>
            /// <param name="积分数值"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern long Api_增加积分(int 积分类型, string 群号, string QQ号, long 积分数值);

            /// <summary>
            /// 修改成功返回积分数值，失败返回-1
            /// </summary>
            /// <param name="积分类型"></param>
            /// <param name="群号">如果积分库是全局的 则不用填写此参数</param>
            /// <param name="QQ号"></param>
            /// <param name="积分数值"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern long Api_减少积分(int 积分类型, string 群号, string QQ号, long 积分数值);

            /// <summary>
            ///
            /// </summary>
            /// <param name="类型"></param>
            /// <param name="内容"></param>
            /// <param name="字体颜色"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern void Api_输出日志(string 类型, string 内容, int 字体颜色);

            /// <summary>
            ///
            /// </summary>
            /// <param name="好友QQ"></param>
            /// <param name="备注名"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern void Api_修改好友备注(string 好友QQ, string 备注名);

            /// <summary>
            ///
            /// </summary>
            /// <param name="好友QQ"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern void Api_删除好友(string 好友QQ);

            /// <summary>
            ///
            /// </summary>
            /// <param name="群号"></param>
            /// <param name="附加信息"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern void Api_加群(string 群号, string 附加信息);

            /// <summary>
            /// 返回网易云点歌XML
            /// </summary>
            /// <param name="歌曲ID"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern string Api_网易云点歌(string 歌曲ID);

            /// <summary>
            /// 返回QQ点歌XML
            /// </summary>
            /// <param name="歌曲ID"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern string Api_QQ点歌(string 歌曲ID);

            /// <summary>
            /// 返回Json点歌XML
            /// </summary>
            /// <param name="歌曲ID"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern string Api_新点歌(string 歌曲ID);

            /// <summary>
            /// 置插件错误管理
            /// </summary>
            /// <param name="Code"></param>
            /// <param name="Str"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern string Api_置插件错误提示(string Code, string Str);

            /// <summary>
            /// 取得群内成员的名片
            /// </summary>
            /// <param name="群号"></param>
            /// <param name="QQ号"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern string Api_取群名片(string 群号, string QQ号);

            /// <summary>
            /// 取得某个QQ的昵称
            /// </summary>
            /// <param name="QQ号"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern string Api_取昵称(string QQ号);

            /// <summary>
            /// 修改群内成员的名片
            /// </summary>
            /// <param name="群号"></param>
            /// <param name="QQ号"></param>
            /// <param name="新名片"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern void Api_修改群名片(string 群号, string QQ号, string 新名片);

            /// <summary>
            /// 取得某个QQ的名片赞数量
            /// </summary>
            /// <param name="QQ号"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern string Api_取名片赞数量(string QQ号);

            /// <summary>
            /// 以JSON形式取得好友列表
            /// </summary>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern string Api_取好友列表();

            /// <summary>
            /// 以JSON形式取得群列表
            /// </summary>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern string Api_取群列表();

            /// <summary>
            /// 以JSON形式取得群成员列表
            /// </summary>
            /// <param name="群号"></param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern string Api_取群成员列表(string 群号);

            /// <summary>
            /// 改变QQ在线状态
            /// </summary>
            /// <param name="类型">1.我在线上 2.Q我吧 3.离开 4.忙碌 5.请勿打扰 6.隐身</param>
            /// <returns></returns>
            [DllImport("message.dll")]
            public static extern string Api_置在线状态(int 类型);
        }
    }
}