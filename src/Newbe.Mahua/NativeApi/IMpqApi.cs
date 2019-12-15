using System.ComponentModel;

namespace Newbe.Mahua.NativeApi
{
    // generate at 2019/12/15 9:16:11 +00:00
    public interface IMpqApi
    {
        /// <summary>
        /// 根据提交的QQ号计算得到页面操作用参数Bkn或G_tk`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        [Description("根据提交的QQ号计算得到页面操作用参数Bkn或G_tk`")]
        string Api_GetGtk_Bkn([Description("")] string 响应的QQ);

        /// <summary>
        /// 根据提交的QQ号计算得到页面操作用参数长Bkn或长G_tk`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        [Description("根据提交的QQ号计算得到页面操作用参数长Bkn或长G_tk`")]
        string Api_GetBkn32([Description("")] string 响应的QQ);

        /// <summary>
        /// 根据提交的QQ号计算得到页面操作用参数长Ldw`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        [Description("根据提交的QQ号计算得到页面操作用参数长Ldw`")]
        string Api_GetLdw([Description("")] string 响应的QQ);

        /// <summary>
        /// 取得框架所在目录.可能鸡肋了。`
        /// </summary>
        /// <returns></returns>
        [Description("取得框架所在目录.可能鸡肋了。`")]
        string Api_GetRunPath();

        /// <summary>
        /// 取得当前框架内在线可用的QQ列表`
        /// </summary>
        /// <returns></returns>
        [Description("取得当前框架内在线可用的QQ列表`")]
        string Api_GetOnlineQQlist();

        /// <summary>
        /// 取得框架内所有QQ列表。包括未登录以及登录失败的QQ`
        /// </summary>
        /// <returns></returns>
        [Description("取得框架内所有QQ列表。包括未登录以及登录失败的QQ`")]
        string Api_GetQQlist();

        /// <summary>
        /// 根据QQ取得对应的会话秘钥`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        [Description("根据QQ取得对应的会话秘钥`")]
        string Api_GetSessionkey([Description("")] string 响应的QQ);

        /// <summary>
        /// 取得页面登录用的Clientkey`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        [Description("取得页面登录用的Clientkey`")]
        string Api_GetClientkey([Description("")] string 响应的QQ);

        /// <summary>
        /// 取得页面登录用的长Clientkey`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        [Description("取得页面登录用的长Clientkey`")]
        string Api_GetLongClientkey([Description("")] string 响应的QQ);

        /// <summary>
        /// 取得页面操作用的Cookies`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        [Description("取得页面操作用的Cookies`")]
        string Api_GetCookies([Description("")] string 响应的QQ);

        /// <summary>
        /// 取得框架内设置的信息发送前缀`
        /// </summary>
        /// <returns></returns>
        [Description("取得框架内设置的信息发送前缀`")]
        string Api_GetPrefix();

        /// <summary>
        /// 将群名片加入高速缓存当作.`
        /// </summary>
        /// <param name="群号"></param>
        /// <param name="QQ"></param>
        /// <param name="名片"></param>
        /// <returns></returns>
        [Description("将群名片加入高速缓存当作.`")]
        void Api_Cache_NameCard([Description("")] string 群号, [Description("")] string QQ, [Description("")] string 名片);

        /// <summary>
        /// 将指定QQ移出QQ黑名单`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        [Description("将指定QQ移出QQ黑名单`")]
        void Api_DBan([Description("")] string 响应的QQ, [Description("")] string QQ);

        /// <summary>
        /// 将指定QQ列入QQ黑名单`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        [Description("将指定QQ列入QQ黑名单`")]
        void Api_Ban([Description("")] string 响应的QQ, [Description("")] string QQ);

        /// <summary>
        /// 禁言群成员`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="群号">禁言对象所在群.</param>
        /// <param name="QQ">禁言对象.留空为全群禁言</param>
        /// <param name="时长">单位:秒 最大为1个月. 为零解除对象或全群禁言</param>
        /// <returns></returns>
        [Description("禁言群成员`")]
        bool Api_Shutup([Description("")] string 响应的QQ, [Description("禁言对象所在群.")] string 群号,
            [Description("禁言对象.留空为全群禁言")] string QQ, [Description("单位:秒 最大为1个月. 为零解除对象或全群禁言")]
            int 时长);

        /// <summary>
        /// 根据群号+QQ判断指定群员是否被禁言  获取失败的情况下亦会返回假
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="群号">欲判断对象所在群.</param>
        /// <param name="QQ">欲判断对象</param>
        /// <returns></returns>
        [Description("根据群号+QQ判断指定群员是否被禁言  获取失败的情况下亦会返回假")]
        bool Api_IsShutup([Description("")] string 响应的QQ, [Description("欲判断对象所在群.")] string 群号,
            [Description("欲判断对象")] string QQ);

        /// <summary>
        /// 发群公告`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="群号"></param>
        /// <param name="标题"></param>
        /// <param name="内容"></param>
        /// <returns></returns>
        [Description("发群公告`")]
        void Api_SetNotice([Description("")] string 响应的QQ, [Description("")] string 群号, [Description("")] string 标题,
            [Description("")] string 内容);

        /// <summary>
        /// 取群公告`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="群号"></param>
        /// <returns></returns>
        [Description("取群公告`")]
        string Api_GetNotice([Description("")] string 响应的QQ, [Description("")] string 群号);

        /// <summary>
        /// 取群名片`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="群号"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        [Description("取群名片`")]
        string Api_GetNameCard([Description("")] string 响应的QQ, [Description("")] string 群号,
            [Description("")] string QQ);

        /// <summary>
        /// 设置群名片`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="群号"></param>
        /// <param name="QQ"></param>
        /// <param name="名片"></param>
        /// <returns></returns>
        [Description("设置群名片`")]
        void Api_SetNameCard([Description("")] string 响应的QQ, [Description("")] string 群号, [Description("")] string QQ,
            [Description("")] string 名片);

        /// <summary>
        /// 退出讨论组`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="讨论组ID"></param>
        /// <returns></returns>
        [Description("退出讨论组`")]
        void Api_QuitDG([Description("")] string 响应的QQ, [Description("")] string 讨论组ID);

        /// <summary>
        /// 删除好友`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        [Description("删除好友`")]
        bool Api_DelFriend([Description("")] string 响应的QQ, [Description("")] string QQ);

        /// <summary>
        /// 将对象移除群`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="群号"></param>
        /// <param name="对象"></param>
        /// <returns></returns>
        [Description("将对象移除群`")]
        bool Api_Kick([Description("")] string 响应的QQ, [Description("")] string 群号, [Description("")] string 对象);

        /// <summary>
        /// 主动加群.为了避免广告、群发行为。出现验证码时将会直接失败不处理`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="群号"></param>
        /// <param name="附加理由"></param>
        /// <returns></returns>
        [Description("主动加群.为了避免广告、群发行为。出现验证码时将会直接失败不处理`")]
        void Api_JoinGroup([Description("")] string 响应的QQ, [Description("")] string 群号, [Description("")] string 附加理由);

        /// <summary>
        /// 退出群`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="群号"></param>
        /// <returns></returns>
        [Description("退出群`")]
        void Api_QuitGroup([Description("")] string 响应的QQ, [Description("")] string 群号);

        /// <summary>
        /// 返回值:成功返回图片GUID用于发送该图片.失败返回空.  图片尺寸应小于4MB`
        /// </summary>
        /// <param name="响应的QQ">机器人QQ</param>
        /// <param name="参_上传类型">1好友2群 注:好友图和群图的GUID并不相同并不通用 需要非别上传。群、讨论组用类型2 临时会话、好友信息需要类型1</param>
        /// <param name="参_参考对象">上传该图片所属的群号或QQ</param>
        /// <param name="参_图片数据">址, 图片字节集数据或字节集数据指针()</param>
        /// <returns></returns>
        [Description("返回值:成功返回图片GUID用于发送该图片.失败返回空.  图片尺寸应小于4MB`")]
        string Api_UploadPic([Description("机器人QQ")] string 响应的QQ,
            [Description("1好友2群 注:好友图和群图的GUID并不相同并不通用 需要非别上传。群、讨论组用类型2 临时会话、好友信息需要类型1")]
            int 参_上传类型, [Description("上传该图片所属的群号或QQ")] string 参_参考对象,
            [Description("址, 图片字节集数据或字节集数据指针()")] byte[] 参_图片数据);

        /// <summary>
        /// 根据图片GUID取得图片下载连接 失败返回空`
        /// </summary>
        /// <param name="图片GUID">{xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx}.jpg这样的GUID</param>
        /// <returns></returns>
        [Description("根据图片GUID取得图片下载连接 失败返回空`")]
        string Api_GuidGetPicLink([Description("{xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx}.jpg这样的GUID")]
            string 图片GUID);

        /// <summary>
        /// 回复信息 请尽量避免使用该API`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="信息类型">1好友 2群 3讨论组 4群临时会话 5讨论组临时会话</param>
        /// <param name="回复对象">接收这条信息的对象</param>
        /// <param name="内容">信息内容</param>
        /// <returns></returns>
        [Description("回复信息 请尽量避免使用该API`")]
        int Api_Reply([Description("")] string 响应的QQ, [Description("1好友 2群 3讨论组 4群临时会话 5讨论组临时会话")]
            int 信息类型, [Description("接收这条信息的对象")] string 回复对象, [Description("信息内容")] string 内容);

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
        [Description("向对象、目标发送信息 支持好友 群 讨论组 群临时会话 讨论组临时会话`")]
        int Api_SendMsg([Description("")] string 响应的QQ, [Description("1好友 2群 3讨论组 4群临时会话 5讨论组临时会话")]
            int 信息类型, [Description("无特殊说明情况下留空或填零")] int 参考子类型, [Description("发送群信息、讨论组信息、群临时会话信息、讨论组临时会话信息时填写")]
            string 收信群_讨论组, [Description("最终接收这条信息的对象QQ")] string 收信对象, [Description("信息内容")] string 内容);

        /// <summary>
        /// 发送封包`
        /// </summary>
        /// <param name="封包内容"></param>
        /// <returns></returns>
        [Description("发送封包`")]
        string Api_Send([Description("")] string 封包内容);

        /// <summary>
        /// 在框架记录页输出一行信息`
        /// </summary>
        /// <param name="内容">输出的内容</param>
        /// <returns></returns>
        [Description("在框架记录页输出一行信息`")]
        int Api_OutPut([Description("输出的内容")] string 内容);

        /// <summary>
        /// 取得本插件启用状态`
        /// </summary>
        /// <returns></returns>
        [Description("取得本插件启用状态`")]
        bool Api_IsEnable();

        /// <summary>
        /// 登录一个现存的QQ`
        /// </summary>
        /// <param name="QQ">欲登录的Q</param>
        /// <returns></returns>
        [Description("登录一个现存的QQ`")]
        bool Api_Login([Description("欲登录的Q")] string QQ);

        /// <summary>
        /// 让指定QQ下线`
        /// </summary>
        /// <param name="QQ"></param>
        /// <returns></returns>
        [Description("让指定QQ下线`")]
        void Api_Logout([Description("")] string QQ);

        /// <summary>
        /// tean加密算法`
        /// </summary>
        /// <param name="加密内容"></param>
        /// <param name="Key"></param>
        /// <returns></returns>
        [Description("tean加密算法`")]
        string Api_Tea加密([Description("")] string 加密内容, [Description("")] string Key);

        /// <summary>
        /// tean解密算法`
        /// </summary>
        /// <param name="解密内容"></param>
        /// <param name="Key"></param>
        /// <returns></returns>
        [Description("tean解密算法`")]
        string Api_Tea解密([Description("")] string 解密内容, [Description("")] string Key);

        /// <summary>
        /// 取用户名`
        /// </summary>
        /// <param name="QQ"></param>
        /// <returns></returns>
        [Description("取用户名`")]
        string Api_GetNick([Description("")] string QQ);

        /// <summary>
        /// 取QQ等级+QQ会员等级 返回json格式信息`
        /// </summary>
        /// <param name="QQ"></param>
        /// <returns></returns>
        [Description("取QQ等级+QQ会员等级 返回json格式信息`")]
        string Api_GetQQLevel([Description("")] string QQ);

        /// <summary>
        /// 群号转群ID`
        /// </summary>
        /// <param name="群号"></param>
        /// <returns></returns>
        [Description("群号转群ID`")]
        string Api_GNGetGid([Description("")] string 群号);

        /// <summary>
        /// 群ID转群号`
        /// </summary>
        /// <param name="群ID"></param>
        /// <returns></returns>
        [Description("群ID转群号`")]
        string Api_GidGetGN([Description("")] string 群ID);

        /// <summary>
        /// 取框架版本号(发布时间戳`
        /// </summary>
        /// <returns></returns>
        [Description("取框架版本号(发布时间戳`")]
        int Api_GetVersion();

        /// <summary>
        /// 取框架版本名`
        /// </summary>
        /// <returns></returns>
        [Description("取框架版本名`")]
        string Api_GetVersionName();

        /// <summary>
        /// 取当前框架内部时间戳_周期性与服务器时间同步`
        /// </summary>
        /// <returns></returns>
        [Description("取当前框架内部时间戳_周期性与服务器时间同步`")]
        int Api_GetTimeStamp();

        /// <summary>
        /// 取得框架输出列表内所有信息`
        /// </summary>
        /// <returns></returns>
        [Description("取得框架输出列表内所有信息`")]
        string Api_GetLog();

        /// <summary>
        /// 判断是否处于被屏蔽群信息状态。`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        [Description("判断是否处于被屏蔽群信息状态。`")]
        bool Api_IfBlock([Description("")] string 响应的QQ);

        /// <summary>
        /// 取包括群主在内的群管列表`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="群号"></param>
        /// <returns></returns>
        [Description("取包括群主在内的群管列表`")]
        string Api_GetAdminList([Description("")] string 响应的QQ, [Description("")] string 群号);

        /// <summary>
        /// 发说说`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="内容"></param>
        /// <returns></returns>
        [Description("发说说`")]
        string Api_AddTaotao([Description("")] string 响应的QQ, [Description("")] string 内容);

        /// <summary>
        /// 取个签`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="对象"></param>
        /// <returns></returns>
        [Description("取个签`")]
        string Api_GetSign([Description("")] string 响应的QQ, [Description("")] string 对象);

        /// <summary>
        /// 设置个签`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="内容"></param>
        /// <returns></returns>
        [Description("设置个签`")]
        string Api_SetSign([Description("")] string 响应的QQ, [Description("")] string 内容);

        /// <summary>
        /// 通过qun.qzone.qq.com接口取得取群列表.成功返回转码后的JSON格式文本信息`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        [Description("通过qun.qzone.qq.com接口取得取群列表.成功返回转码后的JSON格式文本信息`")]
        string Api_GetGroupListA([Description("")] string 响应的QQ);

        /// <summary>
        /// 通过qun.qq.com接口取得取群列表.成功返回转码后的JSON格式文本信息`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        [Description("通过qun.qq.com接口取得取群列表.成功返回转码后的JSON格式文本信息`")]
        string Api_GetGroupListB([Description("")] string 响应的QQ);

        /// <summary>
        /// 通过qun.qq.com接口取得群成员列表 成功返回转码后的JSON格式文本`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="群号"></param>
        /// <returns></returns>
        [Description("通过qun.qq.com接口取得群成员列表 成功返回转码后的JSON格式文本`")]
        string Api_GetGroupMemberA([Description("")] string 响应的QQ, [Description("")] string 群号);

        /// <summary>
        /// 通过qun.qzone.qq.com接口取得群成员列表 成功返回转码后的JSON格式文本`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="群号"></param>
        /// <returns></returns>
        [Description("通过qun.qzone.qq.com接口取得群成员列表 成功返回转码后的JSON格式文本`")]
        string Api_GetGroupMemberB([Description("")] string 响应的QQ, [Description("")] string 群号);

        /// <summary>
        /// 通过qun.qq.com接口取得好友列表。成功返回转码后的JSON文本`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        [Description("通过qun.qq.com接口取得好友列表。成功返回转码后的JSON文本`")]
        string Api_GetFriendList([Description("")] string 响应的QQ);

        /// <summary>
        /// 取Q龄 成功返回Q龄 失败返回-1`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        [Description("取Q龄 成功返回Q龄 失败返回-1`")]
        int Api_GetQQAge([Description("")] string 响应的QQ, [Description("")] string QQ);

        /// <summary>
        /// 取年龄 成功返回年龄 失败返回-1`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        [Description("取年龄 成功返回年龄 失败返回-1`")]
        int Api_GetAge([Description("")] string 响应的QQ, [Description("")] string QQ);

        /// <summary>
        /// 取个人说明`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="QQ">对象QQ</param>
        /// <returns></returns>
        [Description("取个人说明`")]
        string Api_GetPersonalProfile([Description("")] string 响应的QQ, [Description("对象QQ")] string QQ);

        /// <summary>
        /// 取邮箱 成功返回邮箱 失败返回空`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        [Description("取邮箱 成功返回邮箱 失败返回空`")]
        string Api_GetEmail([Description("")] string 响应的QQ, [Description("")] string QQ);

        /// <summary>
        /// 取对象性别 1男 2女  未或失败返回-1`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        [Description("取对象性别 1男 2女  未或失败返回-1`")]
        int Api_GetGender([Description("")] string 响应的QQ, [Description("")] string QQ);

        /// <summary>
        /// 向好友发送‘正在输入’的状态信息.当好友收到信息之后 “正在输入”状态会立刻被打断`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        [Description("向好友发送‘正在输入’的状态信息.当好友收到信息之后 “正在输入”状态会立刻被打断`")]
        int Api_SendTyping([Description("")] string 响应的QQ, [Description("")] string QQ);

        /// <summary>
        /// 向好友发送窗口抖动信息`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        [Description("向好友发送窗口抖动信息`")]
        int Api_SendShake([Description("")] string 响应的QQ, [Description("")] string QQ);

        /// <summary>
        /// 取得框架内随机一个在线且可以使用的QQ`
        /// </summary>
        /// <returns></returns>
        [Description("取得框架内随机一个在线且可以使用的QQ`")]
        string Api_GetRadomOnlineQQ();

        /// <summary>
        /// 往帐号列表添加一个Q.当该Q已存在时则覆盖密码`
        /// </summary>
        /// <param name="QQ"></param>
        /// <param name="密码"></param>
        /// <param name="自动登录">运行框架时是否自动登录该Q.若添加后需要登录该Q则需要通过Api_Login操作</param>
        /// <returns></returns>
        [Description("往帐号列表添加一个Q.当该Q已存在时则覆盖密码`")]
        bool Api_AddQQ([Description("")] string QQ, [Description("")] string 密码,
            [Description("运行框架时是否自动登录该Q.若添加后需要登录该Q则需要通过Api_Login操作")]
            bool 自动登录);

        /// <summary>
        /// 设置在线状态+附加信息 `
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="在线状态">1~6 分别对应我在线上, Q我吧, 离开, 忙碌, 请勿打扰, 隐身</param>
        /// <param name="状态附加信息">最大255字节</param>
        /// <returns></returns>
        [Description("设置在线状态+附加信息 `")]
        bool Api_SetOLStatus([Description("")] string 响应的QQ, [Description("1~6 分别对应我在线上, Q我吧, 离开, 忙碌, 请勿打扰, 隐身")]
            int 在线状态, [Description("最大255字节")] string 状态附加信息);

        /// <summary>
        /// 取得机器码`
        /// </summary>
        /// <returns></returns>
        [Description("取得机器码`")]
        string Api_GetMC();

        /// <summary>
        /// 邀请对象加入群 失败返回错误理由`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="好友QQ">多个好友用换行分割</param>
        /// <param name="群号"></param>
        /// <returns></returns>
        [Description("邀请对象加入群 失败返回错误理由`")]
        string Api_GroupInvitation([Description("")] string 响应的QQ, [Description("多个好友用换行分割")] string 好友QQ,
            [Description("")] string 群号);

        /// <summary>
        /// 创建一个讨论组 成功返回讨论组ID 失败返回空 注:每24小时只能创建100个讨论组 悠着点用`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        [Description("创建一个讨论组 成功返回讨论组ID 失败返回空 注:每24小时只能创建100个讨论组 悠着点用`")]
        string Api_CreateDG([Description("")] string 响应的QQ);

        /// <summary>
        /// 将对象移除讨论组.成功返回空 失败返回理由`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="讨论组ID"></param>
        /// <param name="成员"></param>
        /// <returns></returns>
        [Description("将对象移除讨论组.成功返回空 失败返回理由`")]
        string Api_KickDG([Description("")] string 响应的QQ, [Description("")] string 讨论组ID, [Description("")] string 成员);

        /// <summary>
        /// 邀请对象加入讨论组 成功返回空 失败返回理由`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="讨论组ID"></param>
        /// <param name="成员组">多个成员用换行符分割</param>
        /// <returns></returns>
        [Description("邀请对象加入讨论组 成功返回空 失败返回理由`")]
        string Api_DGInvitation([Description("")] string 响应的QQ, [Description("")] string 讨论组ID,
            [Description("多个成员用换行符分割")] string 成员组);

        /// <summary>
        /// 成功返回以换行符分割的讨论组号列表.最大为100个讨论组  失败返回空`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        [Description("成功返回以换行符分割的讨论组号列表.最大为100个讨论组  失败返回空`")]
        string Api_GetDGList([Description("")] string 响应的QQ);

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
        [Description("向对象发送一条音乐信息（所谓的点歌）次数不限`")]
        bool Api_SendMusic([Description("")] string 响应的QQ, [Description("同Api_SendMsg  1好友 2群 3讨论组 4群临时会话 5讨论组临时会话")]
            int 收信对象类型, [Description("发群内、临时会话必填 好友可不填")] string 收信对象所属群_讨论组,
            [Description("临时会话、好友必填 发至群内可不填")] string 收信对象QQ, [Description("留空默认‘QQ音乐 的分享’")] string 音乐简介,
            [Description("任意直连或短链接均可 留空为空 无法点开")] string 音乐播放页面连接, [Description("任意直连或短链接均可 可空 例:http://url.cn/cDiJT4")]
            string 音乐封面连接, [Description("任意直连或短链接均可 不可空 例:http://url.cn/djwXjr")]
            string 音乐文件直连连接, [Description("可空")] string 曲名, [Description("可空")] string 歌手名,
            [Description("可空 为空默认QQ音乐")] string 音乐来源名,
            [Description("可空 为空默认QQ音乐 http://qzonestyle.gtimg.cn/ac/qzone/applogo/64/308/100497308_64.gif")]
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
        [Description("`")]
        bool Api_SendXml([Description("")] string 响应的QQ, [Description("同Api_SendMsg  1好友 2群 3讨论组 4群临时会话 5讨论组临时会话")]
            int 收信对象类型, [Description("发群内、临时会话必填 好友可不填")] string 收信对象所属群_讨论组,
            [Description("临时会话、好友必填 发至群内可不填")] string 收信对象QQ, [Description("")] string ObjectMsg,
            [Description("00 基本 02 点歌 其他不明")] int 结构子类型);

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
        [Description("`")]
        bool Api_SendObjectMsg([Description("")] string 响应的QQ,
            [Description("同Api_SendMsg  1好友 2群 3讨论组 4群临时会话 5讨论组临时会话")]
            int 收信对象类型, [Description("发群内、临时会话必填 好友可不填")] string 收信对象所属群_讨论组,
            [Description("临时会话、好友必填 发至群内可不填")] string 收信对象QQ, [Description("")] string ObjectMsg,
            [Description("00 基本 02 点歌 其他不明")] int 结构子类型);

        /// <summary>
        /// 判断对象是否为好友（双向）`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="对象QQ"></param>
        /// <returns></returns>
        [Description("判断对象是否为好友（双向）`")]
        bool Api_IsFriend([Description("")] string 响应的QQ, [Description("")] string 对象QQ);

        /// <summary>
        /// 主动加好友 成功返回真 失败返回假 当对象设置需要正确回答问题或不允许任何人添加时无条件失败
        /// </summary>
        /// <param name="响应的QQ">机器人QQ</param>
        /// <param name="对象QQ">加谁</param>
        /// <param name="附加理由">加好友提交的理由</param>
        /// <returns></returns>
        [Description("主动加好友 成功返回真 失败返回假 当对象设置需要正确回答问题或不允许任何人添加时无条件失败")]
        bool Api_AddFriend([Description("机器人QQ")] string 响应的QQ, [Description("加谁")] string 对象QQ,
            [Description("加好友提交的理由")] string 附加理由);

        /// <summary>
        /// 无参 用于插件自身请求禁用插件自身
        /// </summary>
        /// <returns></returns>
        [Description("无参 用于插件自身请求禁用插件自身")]
        void Api_SelfDisable();

        /// <summary>
        /// 取协议客户端类型常量 失败返回0
        /// </summary>
        /// <returns></returns>
        [Description("取协议客户端类型常量 失败返回0")]
        int Api_GetClientType();

        /// <summary>
        /// 取协议客户端版本号常量  失败返回0
        /// </summary>
        /// <returns></returns>
        [Description("取协议客户端版本号常量  失败返回0")]
        int Api_GetClientVer();

        /// <summary>
        /// 取协议客户端公开版本号常量  失败返回0
        /// </summary>
        /// <returns></returns>
        [Description("取协议客户端公开版本号常量  失败返回0")]
        int Api_GetPubNo();

        /// <summary>
        /// 取协议客户端主版本号常量  失败返回0
        /// </summary>
        /// <returns></returns>
        [Description("取协议客户端主版本号常量  失败返回0")]
        int Api_GetMainVer();

        /// <summary>
        /// 取协议客户端通信模块(TXSSO)版本号常量  失败返回0
        /// </summary>
        /// <returns></returns>
        [Description("取协议客户端通信模块(TXSSO)版本号常量  失败返回0")]
        int Api_GetTXSSOVer();

        /// <summary>
        /// 通过音频、语音guid取得下载连接
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="GUID">格式:{xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxx}.amr</param>
        /// <returns></returns>
        [Description("通过音频、语音guid取得下载连接")]
        string Api_GuidGetVoiceLink([Description("")] string 响应的QQ,
            [Description("格式:{xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxx}.amr")]
            string GUID);

        /// <summary>
        /// 上传音频文件 成功返回guid用于发送
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="amr音频数据">音频字节集数据</param>
        /// <returns></returns>
        [Description("上传音频文件 成功返回guid用于发送")]
        string Api_UploadVoice([Description("")] string 响应的QQ, [Description("音频字节集数据")] byte[] amr音频数据);

        /// <summary>
        /// 移除由Api_AddLogHandler添加、设置的日志处理函数
        /// </summary>
        /// <returns></returns>
        [Description("移除由Api_AddLogHandler添加、设置的日志处理函数")]
        void Api_RemoveLogHandler();

        /// <summary>
        /// 取群名
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="群号"></param>
        /// <returns></returns>
        [Description("取群名")]
        string Api_GetGroupName([Description("")] string 响应的QQ, [Description("")] string 群号);

        /// <summary>
        /// 移除\取消由Api_SetMsgFilter所添加\设置的处理函数
        /// </summary>
        /// <returns></returns>
        [Description("移除/取消由Api_SetMsgFilter所添加/设置的处理函数")]
        void Api_RemoveMsgFilter();

        /// <summary>
        /// QQ名片赞 10赞每Q每日 至多50人\日系列 成功返回空 失败返回理由(腾讯爸爸给出的) 一次一赞 速度请自行管控以免冻结
        /// </summary>
        /// <param name="参_响应的QQ"></param>
        /// <param name="参_被赞QQ"></param>
        /// <returns></returns>
        [Description("QQ名片赞 10赞每Q每日 至多50人/日系列 成功返回空 失败返回理由(腾讯爸爸给出的) 一次一赞 速度请自行管控以免冻结")]
        string Api_Like([Description("")] string 参_响应的QQ, [Description("")] string 参_被赞QQ);

        /// <summary>
        /// 上传群文件
        /// </summary>
        /// <param name="参_响应的QQ"></param>
        /// <param name="参_群号"></param>
        /// <param name="参_上传文件名">实际显示在群文件列表中的文件名</param>
        /// <param name="参_路径">本地文件路径 选填</param>
        /// <param name="参_图片数据">图片字节集数据 选填</param>
        /// <returns></returns>
        [Description("上传群文件")]
        bool Api_UploadGroupFile([Description("")] string 参_响应的QQ, [Description("")] string 参_群号,
            [Description("实际显示在群文件列表中的文件名")] string 参_上传文件名, [Description("本地文件路径 选填")] string 参_路径,
            [Description("图片字节集数据 选填")] byte[] 参_图片数据);

        /// <summary>
        /// 根据图片GUID取得图片下载连接 失败返回空
        /// </summary>
        /// <param name="参_图片GUID">{xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx}.jpg这样的GUID</param>
        /// <param name="参_图片类型">1好友\临时会话图片 2 群图</param>
        /// <param name="参_图片参考对象">好友QQ或群号 根据参数2填写</param>
        /// <returns></returns>
        [Description("根据图片GUID取得图片下载连接 失败返回空")]
        string Api_GuidGetPicLinkEx([Description("{xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx}.jpg这样的GUID")]
            string 参_图片GUID, [Description("1好友/临时会话图片 2 群图")] int 参_图片类型,
            [Description("好友QQ或群号 根据参数2填写")] string 参_图片参考对象);

        /// <summary>
        /// 撤回群信息 需为群管
        /// </summary>
        /// <param name="响应的QQ">机器人QQ</param>
        /// <param name="原始信息">Event函数中的'参_原始信息' 经过解密后的封包字节数据</param>
        /// <returns></returns>
        [Description("撤回群信息 需为群管")]
        bool Api_CancelGroupMsgA([Description("机器人QQ")] string 响应的QQ, [Description("Event函数中的'参_原始信息' 经过解密后的封包字节数据")]
            string 原始信息);

        /// <summary>
        /// 取得用于登陆腾讯子业务的Cookies 如xxx.qq.com
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="域名">如qun.qq.com</param>
        /// <returns></returns>
        [Description("取得用于登陆腾讯子业务的Cookies 如xxx.qq.com")]
        string Api_GetCookiesByDomain([Description("")] string 响应的QQ, [Description("如qun.qq.com")] string 域名);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        [Description("")]
        void Api_ChangeProtocol([Description("")] int i);

        /// <summary>
        /// 从框架中删除QQ
        /// </summary>
        /// <param name="被操作QQ"></param>
        /// <returns></returns>
        [Description("从框架中删除QQ")]
        void Api_DeleteQQ([Description("")] string 被操作QQ);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="收信对象类型">同Api_SendMsg  1好友 2群 3讨论组 4群临时会话 5讨论组临时会话</param>
        /// <param name="信对象所属群_讨论组">文本型, , 发群内、临时会话必填 好友可不填</param>
        /// <param name="收信对象QQ">临时会话、好友必填 发至群内可不填</param>
        /// <param name="AppMsg"></param>
        /// <returns></returns>
        [Description("")]
        bool Api_SendAppMsg([Description("")] string 响应的QQ, [Description("同Api_SendMsg  1好友 2群 3讨论组 4群临时会话 5讨论组临时会话")]
            int 收信对象类型, [Description("文本型, , 发群内、临时会话必填 好友可不填")]
            string 信对象所属群_讨论组, [Description("临时会话、好友必填 发至群内可不填")] string 收信对象QQ, [Description("")] string AppMsg);

        /// <summary>
        /// 取生日 失败返回空 未公开生日信息返回 "0年0月0日"
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        [Description("取生日 失败返回空 未公开生日信息返回 \"0 年0月0日\"")]
        string Api_GetBirthday([Description("")] string 响应的QQ, [Description("")] string QQ);

        /// <summary>
        /// 取用户个人信息页面字节数据 包含各种资料 返回内容为原始明文数据
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        [Description("取用户个人信息页面字节数据 包含各种资料 返回内容为原始明文数据")]
        string Api_GetUserInfo([Description("")] string 响应的QQ, [Description("")] string QQ);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        [Description("")]
        string Api_GetFriendListA([Description("")] string 响应的QQ);

        /// <summary>
        /// 仅商用版可用
        /// </summary>
        /// <returns></returns>
        [Description("仅商用版可用")]
        string Api_GetLoginQRCode();

        /// <summary>
        /// 仅商用版可用  上传头像 接受字节集参数 返回值:0 上传成功 -1参数有误  -2图片大于1MB -3获取上传令牌失败受限 -4其他理由上传失败
        /// </summary>
        /// <param name="参_响应的QQ">机器人QQ</param>
        /// <param name="参_图片数据">图片字节集数据,由于易语言DLL限制你可能在这里读到的是"整数型" 请自己改成字节集,图片不限PNG JPG 大小1MB以内</param>
        /// <returns></returns>
        [Description("仅商用版可用  上传头像 接受字节集参数 返回值:0 上传成功 -1参数有误  -2图片大于1MB -3获取上传令牌失败受限 -4其他理由上传失败")]
        int Api_UploadCface_Byte([Description("机器人QQ")] string 参_响应的QQ,
            [Description("图片字节集数据,由于易语言DLL限制你可能在这里读到的是\"整数型\" 请自己改成字节集,图片不限PNG JPG 大小1MB以内")]
            int 参_图片数据);

        /// <summary>
        /// 仅商用版可用 上传头像  接受路径参数 URL 或 本地路径  返回值:0 上传成功 -1参数有误  -2图片大于1MB -3获取上传令牌失败受限 -4其他理由上传失败
        /// </summary>
        /// <param name="参_响应的QQ">机器人QQ</param>
        /// <param name="参_图片路径">路径 可选URL 或 本地路径  http://www.baidu,com/图片.jpg   C:\1.jpg,</param>
        /// <returns></returns>
        [Description("仅商用版可用 上传头像  接受路径参数 URL 或 本地路径  返回值:0 上传成功 -1参数有误  -2图片大于1MB -3获取上传令牌失败受限 -4其他理由上传失败")]
        int Api_UploadCface_Path([Description("机器人QQ")] string 参_响应的QQ,
            [Description("路径 可选URL 或 本地路径  http://www.baidu,com/图片.jpg   C:/1.jpg,")]
            string 参_图片路径);

        /// <summary>
        /// 异步处理被加好友事件 在事件1001下返回值需>30 如50 以强制忽略且确保无其他插件处理
        /// </summary>
        /// <param name="参_原始信息">在事件1001下取得 参_原始信息 填入</param>
        /// <param name="参_处理方式">0忽略 10同意 20拒绝 30单向同意(成为单向好友)</param>
        /// <param name="参_附加信息">拒绝时的附加理由 可以留空</param>
        /// <returns></returns>
        [Description("异步处理被加好友事件 在事件1001下返回值需>30 如50 以强制忽略且确保无其他插件处理")]
        void Api_HandleFriendRequestAsync([Description("在事件1001下取得 参_原始信息 填入")] string 参_原始信息,
            [Description("0忽略 10同意 20拒绝 30单向同意(成为单向好友)")]
            int 参_处理方式, [Description("拒绝时的附加理由 可以留空")] string 参_附加信息);

        /// <summary>
        /// 异步处理被加群类事件 在事件200x下返回值需>30 如50 以强制忽略且确保无其他插件处理
        /// </summary>
        /// <param name="参_响应的QQ">机器人QQ</param>
        /// <param name="参_原始信息">在事件200x下取得 参_原始信息 填入</param>
        /// <param name="参_处理方式">0忽略 10同意 20拒绝 30拒绝并不再接受</param>
        /// <param name="参_附加信息">拒绝时的附加理由 可以留空</param>
        /// <returns></returns>
        [Description("异步处理被加群类事件 在事件200x下返回值需>30 如50 以强制忽略且确保无其他插件处理")]
        void Api_HandleGroupRequestAsync([Description("机器人QQ")] string 参_响应的QQ,
            [Description("在事件200x下取得 参_原始信息 填入")] string 参_原始信息, [Description("0忽略 10同意 20拒绝 30拒绝并不再接受")]
            int 参_处理方式, [Description("拒绝时的附加理由 可以留空")] string 参_附加信息);
    }
}