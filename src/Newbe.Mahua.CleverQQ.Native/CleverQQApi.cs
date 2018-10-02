using System.Runtime.InteropServices;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CleverQQ.Native
{
    public class CleverQQApi : ICleverQqApi
    {
        /// <summary>
        /// 根据提交的QQ号计算得到页面操作用参数Bkn或G_tk`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        string ICleverQqApi.Api_GetBkn(string 响应的QQ)
            => NativeMethods.Api_GetBkn(响应的QQ);

        /// <summary>
        /// 根据提交的QQ号计算得到页面操作用参数长Bkn或长G_tk`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        string ICleverQqApi.Api_GetBkn32(string 响应的QQ)
            => NativeMethods.Api_GetBkn32(响应的QQ);

        /// <summary>
        /// 根据提交的QQ号计算得到页面操作用参数长Ldw`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        string ICleverQqApi.Api_GetLongLdw(string 响应的QQ)
            => NativeMethods.Api_GetLongLdw(响应的QQ);

        /// <summary>
        /// 取得当前框架内在线可用的QQ列表`
        /// </summary>
        /// <returns></returns>
        string ICleverQqApi.Api_GetOnLineList()
            => NativeMethods.Api_GetOnLineList();

        /// <summary>
        /// 取得框架内所有QQ列表。包括未登录以及登录失败的QQ`
        /// </summary>
        /// <returns></returns>
        string ICleverQqApi.Api_GetQQList()
            => NativeMethods.Api_GetQQList();

        /// <summary>
        /// 根据QQ取得对应的会话秘钥`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        string ICleverQqApi.Api_SessionKey(string 响应的QQ)
            => NativeMethods.Api_SessionKey(响应的QQ);

        /// <summary>
        /// 取得页面登录用的Clientkey`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        string ICleverQqApi.Api_GetClientkey(string 响应的QQ)
            => NativeMethods.Api_GetClientkey(响应的QQ);

        /// <summary>
        /// 取得页面登录用的长Clientkey`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        string ICleverQqApi.Api_GetLongClientkey(string 响应的QQ)
            => NativeMethods.Api_GetLongClientkey(响应的QQ);

        /// <summary>
        /// 取得页面操作用的Cookies`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        string ICleverQqApi.Api_GetCookies(string 响应的QQ)
            => NativeMethods.Api_GetCookies(响应的QQ);

        /// <summary>
        /// 将指定QQ列入QQ黑名单`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        void ICleverQqApi.Api_AddBkList(string 响应的QQ, string QQ)
            => NativeMethods.Api_AddBkList(响应的QQ, QQ);

        /// <summary>
        /// 禁言群成员`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="群号">禁言对象所在群.</param>
        /// <param name="QQ">禁言对象.留空为全群禁言</param>
        /// <param name="时长">单位:秒 最大为1个月. 为零解除对象或全群禁言</param>
        /// <returns></returns>
        void ICleverQqApi.Api_ShutUP(string 响应的QQ, string 群号, string QQ, int 时长)
            => NativeMethods.Api_ShutUP(响应的QQ, 群号, QQ, 时长);

        /// <summary>
        /// 发群公告`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="群号"></param>
        /// <param name="标题"></param>
        /// <param name="内容"></param>
        /// <returns></returns>
        void ICleverQqApi.Api_PBGroupNotic(string 响应的QQ, string 群号, string 标题, string 内容)
            => NativeMethods.Api_PBGroupNotic(响应的QQ, 群号, 标题, 内容);

        /// <summary>
        /// 取群名片`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="群号"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        string ICleverQqApi.Api_GetGroupCard(string 响应的QQ, string 群号, string QQ)
            => NativeMethods.Api_GetGroupCard(响应的QQ, 群号, QQ);

        /// <summary>
        /// 设置群名片`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="群号"></param>
        /// <param name="QQ"></param>
        /// <param name="名片"></param>
        /// <returns></returns>
        void ICleverQqApi.Api_SetGroupCard(string 响应的QQ, string 群号, string QQ, string 名片)
            => NativeMethods.Api_SetGroupCard(响应的QQ, 群号, QQ, 名片);

        /// <summary>
        /// 退出讨论组`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="讨论组ID"></param>
        /// <returns></returns>
        void ICleverQqApi.Api_QuitDisGroup(string 响应的QQ, string 讨论组ID)
            => NativeMethods.Api_QuitDisGroup(响应的QQ, 讨论组ID);

        /// <summary>
        /// 删除好友`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        bool ICleverQqApi.Api_DelFriend(string 响应的QQ, string QQ)
            => NativeMethods.Api_DelFriend(响应的QQ, QQ);

        /// <summary>
        /// 将对象移除群`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="群号"></param>
        /// <param name="对象"></param>
        /// <param name="不再接收加群请求">真为不再接收，假为接收</param>
        /// <returns></returns>
        void ICleverQqApi.Api_KickGroupMBR(string 响应的QQ, string 群号, string 对象, bool 不再接收加群请求)
            => NativeMethods.Api_KickGroupMBR(响应的QQ, 群号, 对象, 不再接收加群请求);

        /// <summary>
        /// 主动加群.为了避免广告、群发行为。出现验证码时将会直接失败不处理`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="群号"></param>
        /// <param name="附加理由"></param>
        /// <returns></returns>
        void ICleverQqApi.Api_JoinGroup(string 响应的QQ, string 群号, string 附加理由)
            => NativeMethods.Api_JoinGroup(响应的QQ, 群号, 附加理由);

        /// <summary>
        /// 退出群`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="群号"></param>
        /// <returns></returns>
        void ICleverQqApi.Api_QuitGroup(string 响应的QQ, string 群号)
            => NativeMethods.Api_QuitGroup(响应的QQ, 群号);

        /// <summary>
        /// 返回值:成功返回图片GUID用于发送该图片.失败返回空.  图片尺寸应小于4MB`
        /// </summary>
        /// <param name="响应的QQ">机器人QQ</param>
        /// <param name="参_上传类型">1好友2群 注:好友图和群图的GUID并不相同并不通用 需要非别上传。群、讨论组用类型2 临时会话、好友信息需要类型1</param>
        /// <param name="参_参考对象">上传该图片所属的群号或QQ</param>
        /// <param name="参_图片数据">址, 图片字节集数据或字节集数据指针()</param>
        /// <returns></returns>
        string ICleverQqApi.Api_UpLoadPic(string 响应的QQ, int 参_上传类型, string 参_参考对象, byte[] 参_图片数据)
            => NativeMethods.Api_UpLoadPic(响应的QQ, 参_上传类型, 参_参考对象, 参_图片数据);

        /// <summary>
        /// 根据图片GUID取得图片下载连接 失败返回空`
        /// </summary>
        ///<param name="响应的QQ">机器人QQ</param>
        ///<param name="图片类型">图片类型</param> 1 群 讨论组  2临时会话和好友
        ///<param name="参考对象">参考对象</param> 图片所属对应的群号（可随意乱填写，只有群图片需要填写）
        ///<param name="图片GUID">图片GUID</param>
        /// <returns></returns>
        string ICleverQqApi.Api_GetPicLink(string 响应的QQ, int 图片类型, string 参考对象, string 图片GUID)
            => NativeMethods.Api_GetPicLink(响应的QQ, 图片类型, 参考对象, 图片GUID);

        /// <summary>
        /// 向对象、目标发送信息 支持好友 群 讨论组 群临时会话 讨论组临时会话`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="信息类型">1好友 2群 3讨论组 4群临时会话 5讨论组临时会话</param>
        /// <param name="收信群_讨论组">发送群信息、讨论组信息、群临时会话信息、讨论组临时会话信息时填写</param>
        /// <param name="收信对象">最终接收这条信息的对象QQ</param>
        /// <param name="内容">信息内容</param>
        /// <param name="气泡ID">气泡ID</param>
        /// <returns></returns>
        long ICleverQqApi.Api_SendMsg(string 响应的QQ, int 信息类型, string 收信群_讨论组, string 收信对象, string 内容, int 气泡ID)
            => NativeMethods.Api_SendMsg(响应的QQ, 信息类型, 收信群_讨论组, 收信对象, 内容, 气泡ID);

        /// <summary>
        /// 在框架记录页输出一行信息`
        /// </summary>
        /// <param name="内容">输出的内容</param>
        /// <returns></returns>
        void ICleverQqApi.Api_OutPutLog(string 内容)
            => NativeMethods.Api_OutPutLog(内容);

        /// <summary>
        /// 取得本插件启用状态`
        /// </summary>
        /// <returns></returns>
        bool ICleverQqApi.Api_IsEnable()
            => NativeMethods.Api_IsEnable();

        /// <summary>
        /// 登录一个现存的QQ`
        /// </summary>
        /// <param name="QQ">欲登录的Q</param>
        /// <returns></returns>
        void ICleverQqApi.Api_LoginQQ(string QQ)
            => NativeMethods.Api_LoginQQ(QQ);

        /// <summary>
        /// 让指定QQ下线`
        /// </summary>
        /// <param name="QQ"></param>
        /// <returns></returns>
        void ICleverQqApi.Api_OffLineQQ(string QQ)
            => NativeMethods.Api_OffLineQQ(QQ);

        /// <summary>
        /// tean加密算法`
        /// </summary>
        /// <param name="加密内容"></param>
        /// <param name="Key"></param>
        /// <returns></returns>
        string ICleverQqApi.Api_Tea加密(string 加密内容, string Key)
            => NativeMethods.Api_Tea加密(加密内容, Key);

        /// <summary>
        /// tean解密算法`
        /// </summary>
        /// <param name="解密内容"></param>
        /// <param name="Key"></param>
        /// <returns></returns>
        string ICleverQqApi.Api_Tea解密(string 解密内容, string Key)
            => NativeMethods.Api_Tea解密(解密内容, Key);

        /// <summary>
        /// 取用户名`
        /// </summary>
        /// <param name="QQ"></param>
        /// <returns></returns>
        string ICleverQqApi.Api_GetRInf(string QQ)
            => NativeMethods.Api_GetRInf(QQ);

        /// <summary>
        /// 群号转群ID`
        /// </summary>
        /// <param name="群号"></param>
        /// <returns></returns>
        string ICleverQqApi.Api_GNTransGID(string 群号)
            => NativeMethods.Api_GNTransGID(群号);

        /// <summary>
        /// 群ID转群号`
        /// </summary>
        /// <param name="群ID"></param>
        /// <returns></returns>
        string ICleverQqApi.Api_GIDTransGN(string 群ID)
            => NativeMethods.Api_GIDTransGN(群ID);

        /// <summary>
        /// 取框架版本名`
        /// </summary>
        /// <returns></returns>
        string ICleverQqApi.Api_GetVer()
            => NativeMethods.Api_GetVer();

        /// <summary>
        /// 取当前框架内部时间戳_周期性与服务器时间同步`
        /// </summary>
        /// <returns></returns>
        long ICleverQqApi.Api_GetTimeStamp()
            => NativeMethods.Api_GetTimeStamp();

        /// <summary>
        /// 取得框架输出列表内所有信息`
        /// </summary>
        /// <returns></returns>
        string ICleverQqApi.Api_GetLog()
            => NativeMethods.Api_GetLog();

        /// <summary>
        /// 取包括群主在内的群管列表`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="群号"></param>
        /// <returns></returns>
        string ICleverQqApi.Api_GetGroupAdmin(string 响应的QQ, string 群号)
            => NativeMethods.Api_GetGroupAdmin(响应的QQ, 群号);

        /// <summary>
        /// 发说说`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="内容"></param>
        /// <returns></returns>
        string ICleverQqApi.Api_PBTaoTao(string 响应的QQ, string 内容)
            => NativeMethods.Api_PBTaoTao(响应的QQ, 内容);

        /// <summary>
        /// QQ群签到（成功返回真 失败返回假）
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="群号"></param>
        /// <param name="地名">签到地名（Pro可自定义）</param>
        /// <param name="想说的话">想发表的内容</param>
        /// <returns></returns>
        bool ICleverQqApi.Api_SignIn(string 响应的QQ, string 群号, string 地名, string 想说的话)
            => NativeMethods.Api_SignIn(响应的QQ, 群号, 地名, 想说的话);

        /// <summary>
        /// 通过qun.qzone.qq.com接口取得取群列表.成功返回转码后的JSON格式文本信息`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        string ICleverQqApi.Api_GetGroupList(string 响应的QQ)
            => NativeMethods.Api_GetGroupList(响应的QQ);

        /// <summary>
        /// 通过qun.qq.com接口取得群成员列表 成功返回转码后的JSON格式文本`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="群号"></param>
        /// <returns></returns>
        string ICleverQqApi.Api_GetGroupMemberList(string 响应的QQ, string 群号)
            => NativeMethods.Api_GetGroupMemberList(响应的QQ, 群号);

        /// <summary>
        /// 通过qun.qq.com接口取得好友列表。成功返回转码后的JSON文本`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        string ICleverQqApi.Api_GetFriendList(string 响应的QQ)
            => NativeMethods.Api_GetFriendList(响应的QQ);

        /// <summary>
        /// 取Q龄 成功返回Q龄 失败返回-1`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        int ICleverQqApi.Api_GetQQAge(string 响应的QQ, string QQ)
            => NativeMethods.Api_GetQQAge(响应的QQ, QQ);

        /// <summary>
        /// 取年龄 成功返回年龄 失败返回-1`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        int ICleverQqApi.Api_GetAge(string 响应的QQ, string QQ)
            => NativeMethods.Api_GetAge(响应的QQ, QQ);

        /// <summary>
        /// 取个人说明`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="QQ">对象QQ</param>
        /// <returns></returns>
        string ICleverQqApi.Api_GetPerExp(string 响应的QQ, string QQ)
            => NativeMethods.Api_GetPerExp(响应的QQ, QQ);

        /// <summary>
        /// 取邮箱 成功返回邮箱 失败返回空`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        string ICleverQqApi.Api_GetEmail(string 响应的QQ, string QQ)
            => NativeMethods.Api_GetEmail(响应的QQ, QQ);

        /// <summary>
        /// 取对象性别 1男 2女  未或失败返回-1`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        int ICleverQqApi.Api_GetGender(string 响应的QQ, string QQ)
            => NativeMethods.Api_GetGender(响应的QQ, QQ);

        /// <summary>
        /// 向好友发送窗口抖动信息`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        bool ICleverQqApi.Api_ShakeWindow(string 响应的QQ, string QQ)
            => NativeMethods.Api_ShakeWindow(响应的QQ, QQ);

        /// <summary>
        /// 往帐号列表添加一个Q.当该Q已存在时则覆盖密码`
        /// </summary>
        /// <param name="QQ"></param>
        /// <param name="密码"></param>
        /// <param name="自动登录">运行框架时是否自动登录该Q.若添加后需要登录该Q则需要通过Api_Login操作</param>
        /// <returns></returns>
        string ICleverQqApi.Api_AddQQ(string QQ, string 密码, bool 自动登录)
            => NativeMethods.Api_AddQQ(QQ, 密码, 自动登录);

        /// <summary>
        /// 设置在线状态+附加信息 `
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="在线状态">1~6 分别对应我在线上, Q我吧, 离开, 忙碌, 请勿打扰, 隐身</param>
        /// <param name="状态附加信息">最大255字节</param>
        /// <returns></returns>
        void ICleverQqApi.Api_SetRInf(string 响应的QQ, int 在线状态, string 状态附加信息)
            => NativeMethods.Api_SetRInf(响应的QQ, 在线状态, 状态附加信息);

        /// <summary>
        /// 邀请对象加入群 失败返回错误理由`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="好友QQ">多个好友用换行分割</param>
        /// <param name="群号"></param>
        /// <returns></returns>
        void ICleverQqApi.Api_NoAdminInviteGroup(string 响应的QQ, string 好友QQ, string 群号)
            => NativeMethods.Api_NoAdminInviteGroup(响应的QQ, 好友QQ, 群号);

        /// <summary>
        /// 创建一个讨论组 成功返回讨论组ID 失败返回空 注:每24小时只能创建100个讨论组 悠着点用`
        /// </summary>
        /// <param name="响应的QQ"></param>
        ///<param name="讨论组名称">讨论组名称</param>
        /// <returns></returns>
        string ICleverQqApi.Api_CreateDisGroup(string 响应的QQ, string 讨论组名称)
            => NativeMethods.Api_CreateDisGroup(响应的QQ, 讨论组名称);

        /// <summary>
        /// 将对象移除讨论组.成功返回空 失败返回理由`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="讨论组ID"></param>
        /// <param name="成员"></param>
        /// <returns></returns>
        string ICleverQqApi.Api_KickDisGroupMBR(string 响应的QQ, string 讨论组ID, string 成员)
            => NativeMethods.Api_KickDisGroupMBR(响应的QQ, 讨论组ID, 成员);

        /// <summary>
        /// 邀请对象加入讨论组 成功返回空 失败返回理由`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="讨论组ID"></param>
        /// <param name="成员组">多个成员用换行符分割</param>
        /// <returns></returns>
        string ICleverQqApi.Api_InviteDisGroup(string 响应的QQ, string 讨论组ID, string 成员组)
            => NativeMethods.Api_InviteDisGroup(响应的QQ, 讨论组ID, 成员组);

        /// <summary>
        /// 成功返回以换行符分割的讨论组号列表.最大为100个讨论组  失败返回空`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        string ICleverQqApi.Api_GetDisGroupList(string 响应的QQ)
            => NativeMethods.Api_GetDisGroupList(响应的QQ);

        /// <summary>
        /// 判断对象是否为好友（双向）`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="对象QQ"></param>
        /// <returns></returns>
        bool ICleverQqApi.Api_IfFriend(string 响应的QQ, string 对象QQ)
            => NativeMethods.Api_IfFriend(响应的QQ, 对象QQ);

        private static class NativeMethods
        {
            /// <summary>
            /// 取得机器人网页操作用参数Bkn或G_tk
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetBkn(string 响应的QQ);

            /// <summary>
            /// 根据提交的QQ号计算得到页面操作用参数长Bkn或长G_tk`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetBkn32(string 响应的QQ);

            /// <summary>
            /// 根据提交的QQ号计算得到页面操作用参数长Ldw`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetLongLdw(string 响应的QQ);

            /// <summary>
            /// 取得当前框架内在线可用的QQ列表` 换行符分割
            /// </summary>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetOnLineList();

            /// <summary>
            /// 取得框架内所有QQ列表。包括未登录以及登录失败的QQ` 换行符分割
            /// </summary>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetQQList();

            /// <summary>
            /// 根据QQ取得对应的会话秘钥`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_SessionKey(string 响应的QQ);

            /// <summary>
            /// 取得页面登录用的Clientkey`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetClientkey(string 响应的QQ);

            /// <summary>
            /// 取得页面登录用的长Clientkey`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetLongClientkey(string 响应的QQ);

            /// <summary>
            /// 取得页面操作用的Cookies`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetCookies(string 响应的QQ);

            /// <summary>
            /// 将指定QQ列入QQ黑名单`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="QQ"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern bool Api_AddBkList(string 响应的QQ, string QQ);

            /// <summary>
            /// 禁言群成员`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="群号">禁言对象所在群.</param>
            /// <param name="QQ">禁言对象.留空为全群禁言</param>
            /// <param name="时长">单位:秒 最大为1个月. 为零解除对象或全群禁言</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern void Api_ShutUP(string 响应的QQ, string 群号,
               string QQ, int 时长);

            /// <summary>
            /// 发群公告`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="群号"></param>
            /// <param name="标题"></param>
            /// <param name="内容"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern bool Api_PBGroupNotic(string 响应的QQ, string 群号, string 标题, string 内容);

            /// <summary>
            /// 取群公告`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="群号"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetNotice(string 响应的QQ, string 群号);

            /// <summary>
            /// 取群名片`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="群号"></param>
            /// <param name="QQ"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetGroupCard(string 响应的QQ, string 群号, string QQ);

            /// <summary>
            /// 设置群名片`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="群号"></param>
            /// <param name="QQ"></param>
            /// <param name="名片"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern bool Api_SetGroupCard(string 响应的QQ, string 群号,
               string QQ, string 名片);

            /// <summary>
            /// 退出讨论组`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="讨论组ID"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern void Api_QuitDisGroup(string 响应的QQ, string 讨论组ID);

            /// <summary>
            /// 删除好友`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="QQ"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern bool Api_DelFriend(string 响应的QQ, string QQ);


            /// <summary>
            /// 将对象移除群`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="群号"></param>
            /// <param name="对象"></param>
            /// <param name="不再接收加群请求">真为不再接收，假为接收</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern void Api_KickGroupMBR(string 响应的QQ, string 群号, string 对象, bool 不再接收加群请求);

            /// <summary>
            /// 主动加群.为了避免广告、群发行为。出现验证码时将会直接失败不处理`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="群号"></param>
            /// <param name="附加理由">可留空（需回答正确问题时，请填写问题答案）</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern void Api_JoinGroup(string 响应的QQ, string 群号, string 附加理由);

            /// <summary>
            /// 退出群`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="群号"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern void Api_QuitGroup(string 响应的QQ, string 群号);

            /// <summary>
            /// 返回值:成功返回图片GUID用于发送该图片.失败返回空.  图片尺寸应小于4MB`
            /// </summary>
            /// <param name="响应的QQ">机器人QQ</param>
            /// <param name="参_上传类型">1好友2群 注:好友图和群图的GUID并不相同并不通用 需要非别上传。群、讨论组用类型2 临时会话、好友信息需要类型1</param>
            /// <param name="参_参考对象">上传该图片所属的群号或QQ</param>
            /// <param name="参_图片数据">址, 图片字节集数据或字节集数据指针()</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_UpLoadPic(string 响应的QQ, int 参_上传类型,
           string 参_参考对象, byte[] 参_图片数据);

            /// <summary>
            /// 根据图片GUID取得图片下载连接 失败返回空`
            /// </summary>
            ///<param name="响应的QQ">机器人QQ</param>
            ///<param name="图片类型">图片类型</param> 1 群 讨论组  2临时会话和好友
            ///<param name="参考对象">参考对象</param> 图片所属对应的群号（可随意乱填写，只有群图片需要填写）
            ///<param name="图片GUID">图片GUID</param> [IR:pic={xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx}.jpg]
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetPicLink(string 响应的QQ, int 图片类型, string 参考对象, string 图片GUID);

            /// <summary>
            /// 向对象、目标发送信息 支持好友 群 讨论组 群临时会话 讨论组临时会话`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="信息类型">1好友 2群 3讨论组 4群临时会话 5讨论组临时会话</param>
            /// <param name="收信群_讨论组">发送群信息、讨论组信息、群临时会话信息、讨论组临时会话信息时填写</param>
            /// <param name="收信对象">最终接收这条信息的对象QQ</param>
            /// <param name="内容">信息内容</param>
            /// <param name="气泡ID">气泡ID</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern long Api_SendMsg(string 响应的QQ, int 信息类型, string 收信群_讨论组,
               string 收信对象, string 内容, int 气泡ID);

            /// <summary>
            /// 在框架记录页输出一行信息`
            /// </summary>
            /// <param name="内容">输出的内容</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern void Api_OutPutLog(string 内容);

            /// <summary>
            /// 取得本插件启用状态`
            /// </summary>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern bool Api_IsEnable();

            /// <summary>
            /// 登录一个现存的QQ`
            /// </summary>
            /// <param name="QQ">欲登录的Q</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern void Api_LoginQQ(string QQ);

            /// <summary>
            /// 让指定QQ下线`
            /// </summary>
            /// <param name="QQ"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern void Api_OffLineQQ(string QQ);

            /// <summary>
            /// tean加密算法`
            /// </summary>
            /// <param name="加密内容"></param>
            /// <param name="Key"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_Tea加密(string 加密内容, string Key);

            /// <summary>
            /// tean解密算法`
            /// </summary>
            /// <param name="解密内容"></param>
            /// <param name="Key"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_Tea解密(string 解密内容, string Key);

            /// <summary>
            /// 获取机器人状态信息，成功返回：昵称、帐号、在线状态、速度、收信、发信、在线时间，失败返回空`
            /// </summary>
            /// <param name="QQ"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetRInf(string QQ);

            /// <summary>
            /// 群号转群ID`
            /// </summary>
            /// <param name="群号"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GNTransGID(string 群号);

            /// <summary>
            /// 群ID转群号`
            /// </summary>
            /// <param name="群ID"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GIDTransGN(string 群ID);

            /// <summary>
            /// 取框架版本名`
            /// </summary>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetVer();

            /// <summary>
            /// 取当前框架内部时间戳_周期性与服务器时间同步`
            /// </summary>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern long Api_GetTimeStamp();

            /// <summary>
            /// 取得框架输出列表内所有信息`
            /// </summary>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetLog();

            /// <summary>
            /// 取包括群主在内的群管列表`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="群号"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetGroupAdmin(string 响应的QQ, string 群号);

            /// <summary>
            /// 发说说`(需确认)
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="内容"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_PBTaoTao(string 响应的QQ, string 内容);

            /// <summary>
            /// QQ群签到（成功返回真 失败返回假）
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="群号"></param>
            /// <param name="地名">签到地名（Pro可自定义）</param>
            /// <param name="想说的话">想发表的内容</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern bool Api_SignIn(string 响应的QQ, string 群号, string 地名, string 想说的话);

            /// <summary>
            /// 通过qun.qzone.qq.com接口取得取群列表.成功返回转码后的JSON格式文本信息`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetGroupList(string 响应的QQ);

            /// <summary>
            /// 通过qun.qq.com接口取得群成员列表 成功返回转码后的JSON格式文本`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="群号"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetGroupMemberList(string 响应的QQ, string 群号);

            /// <summary>
            /// 通过qun.qq.com接口取得好友列表。成功返回转码后的JSON文本`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetFriendList(string 响应的QQ);

            /// <summary>
            /// 取Q龄 成功返回Q龄 失败返回-1`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="QQ"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern int Api_GetQQAge(string 响应的QQ, string QQ);

            /// <summary>
            /// 取年龄 成功返回年龄 失败返回-1`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="QQ"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern int Api_GetAge(string 响应的QQ, string QQ);

            /// <summary>
            /// 取个人说明`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="QQ">对象QQ</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetPerExp(string 响应的QQ, string QQ);

            /// <summary>
            /// 取邮箱 成功返回邮箱 失败返回空`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="QQ"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetEmail(string 响应的QQ, string QQ);

            /// <summary>
            /// 取对象性别 1男 2女  未或失败返回-1`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="QQ"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern int Api_GetGender(string 响应的QQ, string QQ);

            /// <summary>
            /// 向好友发送窗口抖动信息`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="QQ"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern bool Api_ShakeWindow(string 响应的QQ, string QQ);

            /// <summary>
            /// 往帐号列表添加一个Q.当该Q已存在时则覆盖密码`
            /// </summary>
            /// <param name="QQ"></param>
            /// <param name="密码"></param>
            /// <param name="自动登录">运行框架时是否自动登录该Q.若添加后需要登录该Q则需要通过Api_Login操作</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_AddQQ(string QQ, string 密码, bool 自动登录);

            /// <summary>
            /// 设置在线状态+附加信息 `
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="在线状态">1、我在线上 2、Q我吧 3、离开 4、忙碌 5、请勿打扰 6、隐身 7、修改昵称 8、修改个性签名 9、修改性别</param>
            /// <param name="状态附加信息">类型为7和8时填写修改内容  类型9时“1”为男 “2”为女      其他填“”</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern void Api_SetRInf(string 响应的QQ, int 在线状态, string 状态附加信息);

            /// <summary>
            /// 非管理员邀请对象入群，频率过快会失败
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="好友QQ">多个好友用换行分割</param>
            /// <param name="群号"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern void Api_NoAdminInviteGroup(string 响应的QQ, string 好友QQ, string 群号);

            /// <summary>
            /// 创建一个讨论组 成功返回讨论组ID 失败返回空 注:每24小时只能创建100个讨论组 悠着点用`
            /// </summary>
            /// <param name="响应的QQ"></param>
            ///<param name="讨论组名称">讨论组名称</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_CreateDisGroup(string 响应的QQ, string 讨论组名称);

            /// <summary>
            /// 将对象移除讨论组.成功返回空 失败返回理由`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="讨论组ID"></param>
            /// <param name="成员"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_KickDisGroupMBR(string 响应的QQ, string 讨论组ID, string 成员);

            /// <summary>
            /// 邀请对象加入讨论组 成功返回空 失败返回理由`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="讨论组ID"></param>
            /// <param name="成员组">被邀请对象QQ 多个用  #换行符 分割</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_InviteDisGroup(string 响应的QQ, string 讨论组ID, string 成员组);

            /// <summary>
            /// 成功返回以换行符分割的讨论组号列表.最大为100个讨论组  失败返回空`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetDisGroupList(string 响应的QQ);

            /// <summary>
            /// 判断对象是否为好友（双向）`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="对象QQ"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern bool Api_IfFriend(string 响应的QQ, string 对象QQ);

            ////// 新增 //////////////////////////////  


            /// <summary>
            /// 发送XML消息
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="发送方式">1普通 2匿名（匿名需要群开启）</param>
            /// <param name="信息类型">0在线临时会话 1好友 2群 3讨论组 4群临时会话 5讨论组临时会话 7好友验证回复会话（0、7只支持Pro版）</param>
            /// <param name="群号">发送群信息、讨论组、群或讨论组临时会话信息时填写，如发送对象为好友或信息类型是0时可空</param>
            /// <param name="对象QQ"></param>
            /// <param name="ObjectMsg">XML代码</param>
            /// <param name="结构子类型"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern bool Api_SendXML(string 响应的QQ, int 发送方式, int 信息类型, string 群号, string 对象QQ,
                string ObjectMsg, int 结构子类型);


            /// <summary>
            /// 发送JSON结构消息
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="发送方式">1普通 2匿名（匿名需要群开启）</param>
            /// <param name="信息类型">0在线临时会话 1好友 2群 3讨论组 4群临时会话 5讨论组临时会话 7好友验证回复会话（0、7只支持Pro版）</param>
            /// <param name="群号">发送群信息、讨论组、群或讨论组临时会话信息时填写，如发送对象为好友或信息类型是0时可空</param>
            /// <param name="对象QQ"></param>
            /// <param name="Json结构">Json结构内容</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern bool Api_SendJSON(string 响应的QQ, int 发送方式, int 信息类型, string 群号, string 对象QQ,
                string Json结构);

            /// <summary>
            /// 调用一次点一下，成功返回空，失败返回理由如：每天最多给他点十个赞哦，调用此Api时应注意频率，每人每日可被赞10次
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="对象QQ">被赞人QQ</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern bool Api_UpVote(string 响应的QQ, string 对象QQ);

        }
    }
}
