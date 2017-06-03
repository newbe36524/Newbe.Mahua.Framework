using System.Runtime.InteropServices;

namespace Newbe.Mahua.MPQ.NativeApi
{
    public class MyPcqqApi : IMyPcqqApi
    {
        /// <summary>
        /// 根据提交的QQ号计算得到页面操作用参数Bkn或G_tk`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetGtk_Bkn(string 响应的QQ)
            => NativeMethods.Api_GetGtk_Bkn(响应的QQ);

        /// <summary>
        /// 根据提交的QQ号计算得到页面操作用参数长Bkn或长G_tk`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetBkn32(string 响应的QQ)
            => NativeMethods.Api_GetBkn32(响应的QQ);

        /// <summary>
        /// 根据提交的QQ号计算得到页面操作用参数长Ldw`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetLdw(string 响应的QQ)
            => NativeMethods.Api_GetLdw(响应的QQ);

        /// <summary>
        /// 取得框架所在目录.可能鸡肋了。`
        /// </summary>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetRunPath()
            => NativeMethods.Api_GetRunPath();

        /// <summary>
        /// 取得当前框架内在线可用的QQ列表`
        /// </summary>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetOnlineQQlist()
            => NativeMethods.Api_GetOnlineQQlist();

        /// <summary>
        /// 取得框架内所有QQ列表。包括未登录以及登录失败的QQ`
        /// </summary>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetQQlist()
            => NativeMethods.Api_GetQQlist();

        /// <summary>
        /// 根据QQ取得对应的会话秘钥`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetSessionkey(string 响应的QQ)
            => NativeMethods.Api_GetSessionkey(响应的QQ);

        /// <summary>
        /// 取得页面登录用的Clientkey`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetClientkey(string 响应的QQ)
            => NativeMethods.Api_GetClientkey(响应的QQ);

        /// <summary>
        /// 取得页面登录用的长Clientkey`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetLongClientkey(string 响应的QQ)
            => NativeMethods.Api_GetLongClientkey(响应的QQ);

        /// <summary>
        /// 取得页面操作用的Cookies`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetCookies(string 响应的QQ)
            => NativeMethods.Api_GetCookies(响应的QQ);

        /// <summary>
        /// 取得框架内设置的信息发送前缀`
        /// </summary>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetPrefix()
            => NativeMethods.Api_GetPrefix();

        /// <summary>
        /// 将群名片加入高速缓存当作.`
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="QQ"></param>
        /// <param name="名片"></param>
        /// <returns></returns>
        void IMyPcqqApi.Api_Cache_NameCard(string 群号, string QQ, string 名片)
            => NativeMethods.Api_Cache_NameCard(群号, QQ, 名片);

        /// <summary>
        /// 将指定QQ移出QQ黑名单`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        void IMyPcqqApi.Api_DBan(string 响应的QQ, string QQ)
            => NativeMethods.Api_DBan(响应的QQ, QQ);

        /// <summary>
        /// 将指定QQ列入QQ黑名单`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        void IMyPcqqApi.Api_Ban(string 响应的QQ, string QQ)
            => NativeMethods.Api_Ban(响应的QQ, QQ);

        /// <summary>
        /// 禁言群成员`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="群号">禁言对象所在群.</param>
        /// <param name="QQ">禁言对象.留空为全群禁言</param>
        /// <param name="时长">单位:秒 最大为1个月. 为零解除对象或全群禁言</param>
        /// <returns></returns>
        bool IMyPcqqApi.Api_Shutup(string 响应的QQ, string 群号, string QQ, int 时长)
            => NativeMethods.Api_Shutup(响应的QQ, 群号, QQ, 时长);

        /// <summary>
        /// 发群公告`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="群号"></param>
        /// <param name="标题"></param>
        /// <param name="内容"></param>
        /// <returns></returns>
        void IMyPcqqApi.Api_SetNotice(string 响应的QQ, string 群号, string 标题, string 内容)
            => NativeMethods.Api_SetNotice(响应的QQ, 群号, 标题, 内容);

        /// <summary>
        /// 取群公告`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="群号"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetNotice(string 响应的QQ, string 群号)
            => NativeMethods.Api_GetNotice(响应的QQ, 群号);

        /// <summary>
        /// 取群名片`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="群号"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetNameCard(string 响应的QQ, string 群号, string QQ)
            => NativeMethods.Api_GetNameCard(响应的QQ, 群号, QQ);

        /// <summary>
        /// 设置群名片`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="群号"></param>
        /// <param name="QQ"></param>
        /// <param name="名片"></param>
        /// <returns></returns>
        void IMyPcqqApi.Api_SetNameCard(string 响应的QQ, string 群号, string QQ, string 名片)
            => NativeMethods.Api_SetNameCard(响应的QQ, 群号, QQ, 名片);

        /// <summary>
        /// 退出讨论组`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="讨论组ID"></param>
        /// <returns></returns>
        void IMyPcqqApi.Api_QuitDG(string 响应的QQ, string 讨论组ID)
            => NativeMethods.Api_QuitDG(响应的QQ, 讨论组ID);

        /// <summary>
        /// 删除好友`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        bool IMyPcqqApi.Api_DelFriend(string 响应的QQ, string QQ)
            => NativeMethods.Api_DelFriend(响应的QQ, QQ);

        /// <summary>
        /// 将对象移除群`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="群号"></param>
        /// <param name="对象"></param>
        /// <returns></returns>
        bool IMyPcqqApi.Api_Kick(string 响应的QQ, string 群号, string 对象)
            => NativeMethods.Api_Kick(响应的QQ, 群号, 对象);

        /// <summary>
        /// 主动加群.为了避免广告、群发行为。出现验证码时将会直接失败不处理`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="群号"></param>
        /// <param name="附加理由"></param>
        /// <returns></returns>
        void IMyPcqqApi.Api_JoinGroup(string 响应的QQ, string 群号, string 附加理由)
            => NativeMethods.Api_JoinGroup(响应的QQ, 群号, 附加理由);

        /// <summary>
        /// 退出群`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="群号"></param>
        /// <returns></returns>
        void IMyPcqqApi.Api_QuitGroup(string 响应的QQ, string 群号)
            => NativeMethods.Api_QuitGroup(响应的QQ, 群号);

        /// <summary>
        /// 返回值:成功返回图片GUID用于发送该图片.失败返回空.  图片尺寸应小于4MB`
        /// </summary>
        /// <param name="响应的QQ">机器人QQ</param>
        /// <param name="参_上传类型">1好友2群 注:好友图和群图的GUID并不相同并不通用 需要非别上传。群、讨论组用类型2 临时会话、好友信息需要类型1</param>
        /// <param name="参_参考对象">上传该图片所属的群号或QQ</param>
        /// <param name="参_图片数据">址, 图片字节集数据或字节集数据指针()</param>
        /// <returns></returns>
        string IMyPcqqApi.Api_UploadPic(string 响应的QQ, int 参_上传类型, string 参_参考对象, byte[] 参_图片数据)
            => NativeMethods.Api_UploadPic(响应的QQ, 参_上传类型, 参_参考对象, 参_图片数据);

        /// <summary>
        /// 根据图片GUID取得图片下载连接 失败返回空`
        /// </summary>
        /// <param name="图片GUID">{xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx}.jpg这样的GUID</param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GuidGetPicLink(string 图片GUID)
            => NativeMethods.Api_GuidGetPicLink(图片GUID);

        /// <summary>
        /// 回复信息 请尽量避免使用该API`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="信息类型">1好友 2群 3讨论组 4群临时会话 5讨论组临时会话</param>
        /// <param name="回复对象">接收这条信息的对象</param>
        /// <param name="内容">信息内容</param>
        /// <returns></returns>
        int IMyPcqqApi.Api_Reply(string 响应的QQ, int 信息类型, string 回复对象, string 内容)
            => NativeMethods.Api_Reply(响应的QQ, 信息类型, 回复对象, 内容);

        /// <summary>
        /// 向对象、目标发送信息 支持好友 群 讨论组 群临时会话 讨论组临时会话`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="信息类型">1好友 2群 3讨论组 4群临时会话 5讨论组临时会话</param>
        /// <param name="参考子类型">无特殊说明情况下留空或填零</param>
        /// <param name="收信群_讨论组">发送群信息、讨论组信息、群临时会话信息、讨论组临时会话信息时填写</param>
        /// <param name="收信对象">最终接收这条信息的对象QQ</param>
        /// <param name="内容">信息内容</param>
        /// <returns></returns>
        int IMyPcqqApi.Api_SendMsg(string 响应的QQ, int 信息类型, int 参考子类型, string 收信群_讨论组, string 收信对象, string 内容)
            => NativeMethods.Api_SendMsg(响应的QQ, 信息类型, 参考子类型, 收信群_讨论组, 收信对象, 内容);

        /// <summary>
        /// 发送封包`
        /// </summary>
        /// <param name="封包内容"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_Send(string 封包内容)
            => NativeMethods.Api_Send(封包内容);

        /// <summary>
        /// 在框架记录页输出一行信息`
        /// </summary>
        /// <param name="内容">输出的内容</param>
        /// <returns></returns>
        int IMyPcqqApi.Api_OutPut(string 内容)
            => NativeMethods.Api_OutPut(内容);

        /// <summary>
        /// 取得本插件启用状态`
        /// </summary>
        /// <returns></returns>
        bool IMyPcqqApi.Api_IsEnable()
            => NativeMethods.Api_IsEnable();

        /// <summary>
        /// 登录一个现存的QQ`
        /// </summary>
        /// <param name="QQ">欲登录的Q</param>
        /// <returns></returns>
        bool IMyPcqqApi.Api_Login(string QQ)
            => NativeMethods.Api_Login(QQ);

        /// <summary>
        /// 让指定QQ下线`
        /// </summary>
        /// <param name="QQ"></param>
        /// <returns></returns>
        void IMyPcqqApi.Api_Logout(string QQ)
            => NativeMethods.Api_Logout(QQ);

        /// <summary>
        /// tean加密算法`
        /// </summary>
        /// <param name="加密内容"></param>
        /// <param name="Key"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_Tea加密(string 加密内容, string Key)
            => NativeMethods.Api_Tea加密(加密内容, Key);

        /// <summary>
        /// tean解密算法`
        /// </summary>
        /// <param name="解密内容"></param>
        /// <param name="Key"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_Tea解密(string 解密内容, string Key)
            => NativeMethods.Api_Tea解密(解密内容, Key);

        /// <summary>
        /// 取用户名`
        /// </summary>
        /// <param name="QQ"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetNick(string QQ)
            => NativeMethods.Api_GetNick(QQ);

        /// <summary>
        /// 取QQ等级+QQ会员等级 返回json格式信息`
        /// </summary>
        /// <param name="QQ"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetQQLevel(string QQ)
            => NativeMethods.Api_GetQQLevel(QQ);

        /// <summary>
        /// 群号转群ID`
        /// </summary>
        /// <param name="群号"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GNGetGid(string 群号)
            => NativeMethods.Api_GNGetGid(群号);

        /// <summary>
        /// 群ID转群号`
        /// </summary>
        /// <param name="群ID"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GidGetGN(string 群ID)
            => NativeMethods.Api_GidGetGN(群ID);

        /// <summary>
        /// 取框架版本号(发布时间戳`
        /// </summary>
        /// <returns></returns>
        int IMyPcqqApi.Api_GetVersion()
            => NativeMethods.Api_GetVersion();

        /// <summary>
        /// 取框架版本名`
        /// </summary>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetVersionName()
            => NativeMethods.Api_GetVersionName();

        /// <summary>
        /// 取当前框架内部时间戳_周期性与服务器时间同步`
        /// </summary>
        /// <returns></returns>
        int IMyPcqqApi.Api_GetTimeStamp()
            => NativeMethods.Api_GetTimeStamp();

        /// <summary>
        /// 取得框架输出列表内所有信息`
        /// </summary>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetLog()
            => NativeMethods.Api_GetLog();

        /// <summary>
        /// 判断是否处于被屏蔽群信息状态。`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        bool IMyPcqqApi.Api_IfBlock(string 响应的QQ)
            => NativeMethods.Api_IfBlock(响应的QQ);

        /// <summary>
        /// 取包括群主在内的群管列表`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="群号"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetAdminList(string 响应的QQ, string 群号)
            => NativeMethods.Api_GetAdminList(响应的QQ, 群号);

        /// <summary>
        /// 发说说`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="内容"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_AddTaotao(string 响应的QQ, string 内容)
            => NativeMethods.Api_AddTaotao(响应的QQ, 内容);

        /// <summary>
        /// 取个签`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="对象"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetSign(string 响应的QQ, string 对象)
            => NativeMethods.Api_GetSign(响应的QQ, 对象);

        /// <summary>
        /// 设置个签`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="内容"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_SetSign(string 响应的QQ, string 内容)
            => NativeMethods.Api_SetSign(响应的QQ, 内容);

        /// <summary>
        /// 通过qun.qzone.qq.com接口取得取群列表.成功返回转码后的JSON格式文本信息`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetGroupListA(string 响应的QQ)
            => NativeMethods.Api_GetGroupListA(响应的QQ);

        /// <summary>
        /// 通过qun.qq.com接口取得取群列表.成功返回转码后的JSON格式文本信息`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetGroupListB(string 响应的QQ)
            => NativeMethods.Api_GetGroupListB(响应的QQ);

        /// <summary>
        /// 通过qun.qq.com接口取得群成员列表 成功返回转码后的JSON格式文本`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="群号"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetGroupMemberA(string 响应的QQ, string 群号)
            => NativeMethods.Api_GetGroupMemberA(响应的QQ, 群号);

        /// <summary>
        /// 通过qun.qzone.qq.com接口取得群成员列表 成功返回转码后的JSON格式文本`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="群号"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetGroupMemberB(string 响应的QQ, string 群号)
            => NativeMethods.Api_GetGroupMemberB(响应的QQ, 群号);

        /// <summary>
        /// 通过qun.qq.com接口取得好友列表。成功返回转码后的JSON文本`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetFriendList(string 响应的QQ)
            => NativeMethods.Api_GetFriendList(响应的QQ);

        /// <summary>
        /// 取Q龄 成功返回Q龄 失败返回-1`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        int IMyPcqqApi.Api_GetQQAge(string 响应的QQ, string QQ)
            => NativeMethods.Api_GetQQAge(响应的QQ, QQ);

        /// <summary>
        /// 取年龄 成功返回年龄 失败返回-1`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        int IMyPcqqApi.Api_GetAge(string 响应的QQ, string QQ)
            => NativeMethods.Api_GetAge(响应的QQ, QQ);

        /// <summary>
        /// 取个人说明`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="QQ">对象QQ</param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetPersonalProfile(string 响应的QQ, string QQ)
            => NativeMethods.Api_GetPersonalProfile(响应的QQ, QQ);

        /// <summary>
        /// 取邮箱 成功返回邮箱 失败返回空`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetEmail(string 响应的QQ, string QQ)
            => NativeMethods.Api_GetEmail(响应的QQ, QQ);

        /// <summary>
        /// 取对象性别 1男 2女  未或失败返回-1`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        int IMyPcqqApi.Api_GetGender(string 响应的QQ, string QQ)
            => NativeMethods.Api_GetGender(响应的QQ, QQ);

        /// <summary>
        /// 向好友发送‘正在输入’的状态信息.当好友收到信息之后 “正在输入”状态会立刻被打断`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        int IMyPcqqApi.Api_SendTyping(string 响应的QQ, string QQ)
            => NativeMethods.Api_SendTyping(响应的QQ, QQ);

        /// <summary>
        /// 向好友发送窗口抖动信息`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        int IMyPcqqApi.Api_SendShake(string 响应的QQ, string QQ)
            => NativeMethods.Api_SendShake(响应的QQ, QQ);

        /// <summary>
        /// 取得框架内随机一个在线且可以使用的QQ`
        /// </summary>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetRadomOnlineQQ()
            => NativeMethods.Api_GetRadomOnlineQQ();

        /// <summary>
        /// 往帐号列表添加一个Q.当该Q已存在时则覆盖密码`
        /// </summary>
        /// <param name="QQ"></param>
        /// <param name="密码"></param>
        /// <param name="自动登录">运行框架时是否自动登录该Q.若添加后需要登录该Q则需要通过Api_Login操作</param>
        /// <returns></returns>
        bool IMyPcqqApi.Api_AddQQ(string QQ, string 密码, bool 自动登录)
            => NativeMethods.Api_AddQQ(QQ, 密码, 自动登录);

        /// <summary>
        /// 设置在线状态+附加信息 `
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="在线状态">1~6 分别对应我在线上, Q我吧, 离开, 忙碌, 请勿打扰, 隐身</param>
        /// <param name="状态附加信息">最大255字节</param>
        /// <returns></returns>
        bool IMyPcqqApi.Api_SetOLStatus(string 响应的QQ, int 在线状态, string 状态附加信息)
            => NativeMethods.Api_SetOLStatus(响应的QQ, 在线状态, 状态附加信息);

        /// <summary>
        /// 取得机器码`
        /// </summary>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetMC()
            => NativeMethods.Api_GetMC();

        /// <summary>
        /// 邀请对象加入群 失败返回错误理由`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="好友QQ">多个好友用换行分割</param>
        /// <param name="群号"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GroupInvitation(string 响应的QQ, string 好友QQ, string 群号)
            => NativeMethods.Api_GroupInvitation(响应的QQ, 好友QQ, 群号);

        /// <summary>
        /// 创建一个讨论组 成功返回讨论组ID 失败返回空 注:每24小时只能创建100个讨论组 悠着点用`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_CreateDG(string 响应的QQ)
            => NativeMethods.Api_CreateDG(响应的QQ);

        /// <summary>
        /// 将对象移除讨论组.成功返回空 失败返回理由`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="讨论组ID"></param>
        /// <param name="成员"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_KickDG(string 响应的QQ, string 讨论组ID, string 成员)
            => NativeMethods.Api_KickDG(响应的QQ, 讨论组ID, 成员);

        /// <summary>
        /// 邀请对象加入讨论组 成功返回空 失败返回理由`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="讨论组ID"></param>
        /// <param name="成员组">多个成员用换行符分割</param>
        /// <returns></returns>
        string IMyPcqqApi.Api_DGInvitation(string 响应的QQ, string 讨论组ID, string 成员组)
            => NativeMethods.Api_DGInvitation(响应的QQ, 讨论组ID, 成员组);

        /// <summary>
        /// 成功返回以换行符分割的讨论组号列表.最大为100个讨论组  失败返回空`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetDGList(string 响应的QQ)
            => NativeMethods.Api_GetDGList(响应的QQ);

        /// <summary>
        /// 向对象发送一条音乐信息（所谓的点歌）次数不限`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="收信对象类型">同Api_SendMsg  1好友 2群 3讨论组 4群临时会话 5讨论组临时会话</param>
        /// <param name="收信对象所属群_讨论组">发群内、临时会话必填 好友可不填</param>
        /// <param name="收信对象QQ">临时会话、好友必填 发至群内可不填</param>
        /// <param name="音乐简介">留空默认‘QQ音乐 的分享’</param>
        /// <param name="音乐播放页面连接">任意直连或短链接均可 留空为空 无法点开</param>
        /// <param name="音乐封面连接">任意直连或短链接均可 可空 例:http://url.cn/cDiJT4</param>
        /// <param name="音乐文件直连连接">任意直连或短链接均可 不可空 例:http://url.cn/djwXjr</param>
        /// <param name="曲名">可空</param>
        /// <param name="歌手名">可空</param>
        /// <param name="音乐来源名">可空 为空默认QQ音乐</param>
        /// <param name="音乐来源图标连接">可空 为空默认QQ音乐 http://qzonestyle.gtimg.cn/ac/qzone/applogo/64/308/100497308_64.gif</param>
        /// <returns></returns>
        bool IMyPcqqApi.Api_SendMusic(string 响应的QQ, int 收信对象类型, string 收信对象所属群_讨论组, string 收信对象QQ, string 音乐简介,
            string 音乐播放页面连接, string 音乐封面连接, string 音乐文件直连连接, string 曲名, string 歌手名, string 音乐来源名, string 音乐来源图标连接)
            => NativeMethods.Api_SendMusic(响应的QQ, 收信对象类型, 收信对象所属群_讨论组, 收信对象QQ, 音乐简介, 音乐播放页面连接, 音乐封面连接, 音乐文件直连连接, 曲名,
                歌手名, 音乐来源名, 音乐来源图标连接);

        /// <summary>
        /// `
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="收信对象类型">同Api_SendMsg  1好友 2群 3讨论组 4群临时会话 5讨论组临时会话</param>
        /// <param name="收信对象所属群_讨论组">发群内、临时会话必填 好友可不填</param>
        /// <param name="收信对象QQ">临时会话、好友必填 发至群内可不填</param>
        /// <param name="ObjectMsg"></param>
        /// <param name="结构子类型">00 基本 02 点歌 其他不明</param>
        /// <returns></returns>
        bool IMyPcqqApi.Api_SendObjectMsg(string 响应的QQ, int 收信对象类型, string 收信对象所属群_讨论组, string 收信对象QQ, string ObjectMsg,
            int 结构子类型)
            => NativeMethods.Api_SendObjectMsg(响应的QQ, 收信对象类型, 收信对象所属群_讨论组, 收信对象QQ, ObjectMsg, 结构子类型);

        /// <summary>
        /// 判断对象是否为好友（双向）`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="对象QQ"></param>
        /// <returns></returns>
        bool IMyPcqqApi.Api_IsFriend(string 响应的QQ, string 对象QQ)
            => NativeMethods.Api_IsFriend(响应的QQ, 对象QQ);

        private static class NativeMethods
        {
            /// <summary>
            /// 根据提交的QQ号计算得到页面操作用参数Bkn或G_tk`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetGtk_Bkn(string 响应的QQ);

            /// <summary>
            /// 根据提交的QQ号计算得到页面操作用参数长Bkn或长G_tk`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetBkn32(string 响应的QQ);

            /// <summary>
            /// 根据提交的QQ号计算得到页面操作用参数长Ldw`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetLdw(string 响应的QQ);

            /// <summary>
            /// 取得框架所在目录.可能鸡肋了。`
            /// </summary>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetRunPath();

            /// <summary>
            /// 取得当前框架内在线可用的QQ列表`
            /// </summary>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetOnlineQQlist();

            /// <summary>
            /// 取得框架内所有QQ列表。包括未登录以及登录失败的QQ`
            /// </summary>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetQQlist();

            /// <summary>
            /// 根据QQ取得对应的会话秘钥`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetSessionkey(string 响应的QQ);

            /// <summary>
            /// 取得页面登录用的Clientkey`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetClientkey(string 响应的QQ);

            /// <summary>
            /// 取得页面登录用的长Clientkey`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetLongClientkey(string 响应的QQ);

            /// <summary>
            /// 取得页面操作用的Cookies`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetCookies(string 响应的QQ);

            /// <summary>
            /// 取得框架内设置的信息发送前缀`
            /// </summary>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetPrefix();

            /// <summary>
            /// 将群名片加入高速缓存当作.`
            /// </summary>
            /// <param name="群号"></param>
            /// <param name="QQ"></param>
            /// <param name="名片"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern void Api_Cache_NameCard(string 群号, string QQ, string 名片);

            /// <summary>
            /// 将指定QQ移出QQ黑名单`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern void Api_DBan(string 响应的QQ, string QQ);

            /// <summary>
            /// 将指定QQ列入QQ黑名单`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern void Api_Ban(string 响应的QQ, string QQ);

            /// <summary>
            /// 禁言群成员`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="群号">禁言对象所在群.</param>
            /// <param name="QQ">禁言对象.留空为全群禁言</param>
            /// <param name="时长">单位:秒 最大为1个月. 为零解除对象或全群禁言</param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern bool Api_Shutup(string 响应的QQ, string 群号, string QQ, int 时长);

            /// <summary>
            /// 发群公告`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="群号"></param>
            /// <param name="标题"></param>
            /// <param name="内容"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern void Api_SetNotice(string 响应的QQ, string 群号, string 标题, string 内容);

            /// <summary>
            /// 取群公告`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="群号"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetNotice(string 响应的QQ, string 群号);

            /// <summary>
            /// 取群名片`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="群号"></param>
            /// <param name="QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetNameCard(string 响应的QQ, string 群号, string QQ);

            /// <summary>
            /// 设置群名片`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="群号"></param>
            /// <param name="QQ"></param>
            /// <param name="名片"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern void Api_SetNameCard(string 响应的QQ, string 群号, string QQ, string 名片);

            /// <summary>
            /// 退出讨论组`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="讨论组ID"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern void Api_QuitDG(string 响应的QQ, string 讨论组ID);

            /// <summary>
            /// 删除好友`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern bool Api_DelFriend(string 响应的QQ, string QQ);

            /// <summary>
            /// 将对象移除群`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="群号"></param>
            /// <param name="对象"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern bool Api_Kick(string 响应的QQ, string 群号, string 对象);

            /// <summary>
            /// 主动加群.为了避免广告、群发行为。出现验证码时将会直接失败不处理`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="群号"></param>
            /// <param name="附加理由"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern void Api_JoinGroup(string 响应的QQ, string 群号, string 附加理由);

            /// <summary>
            /// 退出群`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="群号"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern void Api_QuitGroup(string 响应的QQ, string 群号);

            /// <summary>
            /// 返回值:成功返回图片GUID用于发送该图片.失败返回空.  图片尺寸应小于4MB`
            /// </summary>
            /// <param name="响应的QQ">机器人QQ</param>
            /// <param name="参_上传类型">1好友2群 注:好友图和群图的GUID并不相同并不通用 需要非别上传。群、讨论组用类型2 临时会话、好友信息需要类型1</param>
            /// <param name="参_参考对象">上传该图片所属的群号或QQ</param>
            /// <param name="参_图片数据">址, 图片字节集数据或字节集数据指针()</param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_UploadPic(string 响应的QQ, int 参_上传类型, string 参_参考对象, byte[] 参_图片数据);

            /// <summary>
            /// 根据图片GUID取得图片下载连接 失败返回空`
            /// </summary>
            /// <param name="图片GUID">{xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx}.jpg这样的GUID</param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GuidGetPicLink(string 图片GUID);

            /// <summary>
            /// 回复信息 请尽量避免使用该API`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="信息类型">1好友 2群 3讨论组 4群临时会话 5讨论组临时会话</param>
            /// <param name="回复对象">接收这条信息的对象</param>
            /// <param name="内容">信息内容</param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern int Api_Reply(string 响应的QQ, int 信息类型, string 回复对象, string 内容);

            /// <summary>
            /// 向对象、目标发送信息 支持好友 群 讨论组 群临时会话 讨论组临时会话`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="信息类型">1好友 2群 3讨论组 4群临时会话 5讨论组临时会话</param>
            /// <param name="参考子类型">无特殊说明情况下留空或填零</param>
            /// <param name="收信群_讨论组">发送群信息、讨论组信息、群临时会话信息、讨论组临时会话信息时填写</param>
            /// <param name="收信对象">最终接收这条信息的对象QQ</param>
            /// <param name="内容">信息内容</param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern int Api_SendMsg(string 响应的QQ, int 信息类型, int 参考子类型, string 收信群_讨论组, string 收信对象,
                string 内容);

            /// <summary>
            /// 发送封包`
            /// </summary>
            /// <param name="封包内容"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_Send(string 封包内容);

            /// <summary>
            /// 在框架记录页输出一行信息`
            /// </summary>
            /// <param name="内容">输出的内容</param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern int Api_OutPut(string 内容);

            /// <summary>
            /// 取得本插件启用状态`
            /// </summary>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern bool Api_IsEnable();

            /// <summary>
            /// 登录一个现存的QQ`
            /// </summary>
            /// <param name="QQ">欲登录的Q</param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern bool Api_Login(string QQ);

            /// <summary>
            /// 让指定QQ下线`
            /// </summary>
            /// <param name="QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern void Api_Logout(string QQ);

            /// <summary>
            /// tean加密算法`
            /// </summary>
            /// <param name="加密内容"></param>
            /// <param name="Key"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_Tea加密(string 加密内容, string Key);

            /// <summary>
            /// tean解密算法`
            /// </summary>
            /// <param name="解密内容"></param>
            /// <param name="Key"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_Tea解密(string 解密内容, string Key);

            /// <summary>
            /// 取用户名`
            /// </summary>
            /// <param name="QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetNick(string QQ);

            /// <summary>
            /// 取QQ等级+QQ会员等级 返回json格式信息`
            /// </summary>
            /// <param name="QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetQQLevel(string QQ);

            /// <summary>
            /// 群号转群ID`
            /// </summary>
            /// <param name="群号"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GNGetGid(string 群号);

            /// <summary>
            /// 群ID转群号`
            /// </summary>
            /// <param name="群ID"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GidGetGN(string 群ID);

            /// <summary>
            /// 取框架版本号(发布时间戳`
            /// </summary>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern int Api_GetVersion();

            /// <summary>
            /// 取框架版本名`
            /// </summary>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetVersionName();

            /// <summary>
            /// 取当前框架内部时间戳_周期性与服务器时间同步`
            /// </summary>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern int Api_GetTimeStamp();

            /// <summary>
            /// 取得框架输出列表内所有信息`
            /// </summary>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetLog();

            /// <summary>
            /// 判断是否处于被屏蔽群信息状态。`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern bool Api_IfBlock(string 响应的QQ);

            /// <summary>
            /// 取包括群主在内的群管列表`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="群号"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetAdminList(string 响应的QQ, string 群号);

            /// <summary>
            /// 发说说`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="内容"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_AddTaotao(string 响应的QQ, string 内容);

            /// <summary>
            /// 取个签`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="对象"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetSign(string 响应的QQ, string 对象);

            /// <summary>
            /// 设置个签`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="内容"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_SetSign(string 响应的QQ, string 内容);

            /// <summary>
            /// 通过qun.qzone.qq.com接口取得取群列表.成功返回转码后的JSON格式文本信息`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetGroupListA(string 响应的QQ);

            /// <summary>
            /// 通过qun.qq.com接口取得取群列表.成功返回转码后的JSON格式文本信息`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetGroupListB(string 响应的QQ);

            /// <summary>
            /// 通过qun.qq.com接口取得群成员列表 成功返回转码后的JSON格式文本`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="群号"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetGroupMemberA(string 响应的QQ, string 群号);

            /// <summary>
            /// 通过qun.qzone.qq.com接口取得群成员列表 成功返回转码后的JSON格式文本`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="群号"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetGroupMemberB(string 响应的QQ, string 群号);

            /// <summary>
            /// 通过qun.qq.com接口取得好友列表。成功返回转码后的JSON文本`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetFriendList(string 响应的QQ);

            /// <summary>
            /// 取Q龄 成功返回Q龄 失败返回-1`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern int Api_GetQQAge(string 响应的QQ, string QQ);

            /// <summary>
            /// 取年龄 成功返回年龄 失败返回-1`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern int Api_GetAge(string 响应的QQ, string QQ);

            /// <summary>
            /// 取个人说明`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="QQ">对象QQ</param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetPersonalProfile(string 响应的QQ, string QQ);

            /// <summary>
            /// 取邮箱 成功返回邮箱 失败返回空`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetEmail(string 响应的QQ, string QQ);

            /// <summary>
            /// 取对象性别 1男 2女  未或失败返回-1`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern int Api_GetGender(string 响应的QQ, string QQ);

            /// <summary>
            /// 向好友发送‘正在输入’的状态信息.当好友收到信息之后 “正在输入”状态会立刻被打断`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern int Api_SendTyping(string 响应的QQ, string QQ);

            /// <summary>
            /// 向好友发送窗口抖动信息`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern int Api_SendShake(string 响应的QQ, string QQ);

            /// <summary>
            /// 取得框架内随机一个在线且可以使用的QQ`
            /// </summary>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetRadomOnlineQQ();

            /// <summary>
            /// 往帐号列表添加一个Q.当该Q已存在时则覆盖密码`
            /// </summary>
            /// <param name="QQ"></param>
            /// <param name="密码"></param>
            /// <param name="自动登录">运行框架时是否自动登录该Q.若添加后需要登录该Q则需要通过Api_Login操作</param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern bool Api_AddQQ(string QQ, string 密码, bool 自动登录);

            /// <summary>
            /// 设置在线状态+附加信息 `
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="在线状态">1~6 分别对应我在线上, Q我吧, 离开, 忙碌, 请勿打扰, 隐身</param>
            /// <param name="状态附加信息">最大255字节</param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern bool Api_SetOLStatus(string 响应的QQ, int 在线状态, string 状态附加信息);

            /// <summary>
            /// 取得机器码`
            /// </summary>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetMC();

            /// <summary>
            /// 邀请对象加入群 失败返回错误理由`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="好友QQ">多个好友用换行分割</param>
            /// <param name="群号"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GroupInvitation(string 响应的QQ, string 好友QQ, string 群号);

            /// <summary>
            /// 创建一个讨论组 成功返回讨论组ID 失败返回空 注:每24小时只能创建100个讨论组 悠着点用`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_CreateDG(string 响应的QQ);

            /// <summary>
            /// 将对象移除讨论组.成功返回空 失败返回理由`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="讨论组ID"></param>
            /// <param name="成员"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_KickDG(string 响应的QQ, string 讨论组ID, string 成员);

            /// <summary>
            /// 邀请对象加入讨论组 成功返回空 失败返回理由`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="讨论组ID"></param>
            /// <param name="成员组">多个成员用换行符分割</param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_DGInvitation(string 响应的QQ, string 讨论组ID, string 成员组);

            /// <summary>
            /// 成功返回以换行符分割的讨论组号列表.最大为100个讨论组  失败返回空`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetDGList(string 响应的QQ);

            /// <summary>
            /// 向对象发送一条音乐信息（所谓的点歌）次数不限`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="收信对象类型">同Api_SendMsg  1好友 2群 3讨论组 4群临时会话 5讨论组临时会话</param>
            /// <param name="收信对象所属群_讨论组">发群内、临时会话必填 好友可不填</param>
            /// <param name="收信对象QQ">临时会话、好友必填 发至群内可不填</param>
            /// <param name="音乐简介">留空默认‘QQ音乐 的分享’</param>
            /// <param name="音乐播放页面连接">任意直连或短链接均可 留空为空 无法点开</param>
            /// <param name="音乐封面连接">任意直连或短链接均可 可空 例:http://url.cn/cDiJT4</param>
            /// <param name="音乐文件直连连接">任意直连或短链接均可 不可空 例:http://url.cn/djwXjr</param>
            /// <param name="曲名">可空</param>
            /// <param name="歌手名">可空</param>
            /// <param name="音乐来源名">可空 为空默认QQ音乐</param>
            /// <param name="音乐来源图标连接">可空 为空默认QQ音乐 http://qzonestyle.gtimg.cn/ac/qzone/applogo/64/308/100497308_64.gif</param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern bool Api_SendMusic(string 响应的QQ, int 收信对象类型, string 收信对象所属群_讨论组, string 收信对象QQ,
                string 音乐简介, string 音乐播放页面连接, string 音乐封面连接, string 音乐文件直连连接, string 曲名, string 歌手名, string 音乐来源名,
                string 音乐来源图标连接);

            /// <summary>
            /// `
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="收信对象类型">同Api_SendMsg  1好友 2群 3讨论组 4群临时会话 5讨论组临时会话</param>
            /// <param name="收信对象所属群_讨论组">发群内、临时会话必填 好友可不填</param>
            /// <param name="收信对象QQ">临时会话、好友必填 发至群内可不填</param>
            /// <param name="ObjectMsg"></param>
            /// <param name="结构子类型">00 基本 02 点歌 其他不明</param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern bool Api_SendObjectMsg(string 响应的QQ, int 收信对象类型, string 收信对象所属群_讨论组, string 收信对象QQ,
                string ObjectMsg, int 结构子类型);

            /// <summary>
            /// 判断对象是否为好友（双向）`
            /// </summary>
            /// <param name="响应的QQ"></param>
            /// <param name="对象QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern bool Api_IsFriend(string 响应的QQ, string 对象QQ);
        }
    }
}