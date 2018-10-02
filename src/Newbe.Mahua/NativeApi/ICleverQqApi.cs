namespace Newbe.Mahua.NativeApi
{
    public interface ICleverQqApi
    {
        /// <summary>
        /// 根据提交的QQ号计算得到页面操作用参数Bkn或G_tk`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        string Api_GetBkn(string 响应的QQ);
        /// <summary>
        /// 根据提交的QQ号计算得到页面操作用参数长Bkn或长G_tk`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        string Api_GetBkn32(string 响应的QQ);
        /// <summary>
        /// 根据提交的QQ号计算得到页面操作用参数长Ldw`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        string Api_GetLongLdw(string 响应的QQ);
        /// <summary>
        /// 取得当前框架内在线可用的QQ列表`
        /// </summary>
        /// <returns></returns>
        string Api_GetOnLineList();
        /// <summary>
        /// 取得框架内所有QQ列表。包括未登录以及登录失败的QQ`
        /// </summary>
        /// <returns></returns>
        string Api_GetQQList();
        /// <summary>
        /// 根据QQ取得对应的会话秘钥`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        string Api_SessionKey(string 响应的QQ);
        /// <summary>
        /// 取得页面登录用的Clientkey`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        string Api_GetClientkey(string 响应的QQ);
        /// <summary>
        /// 取得页面登录用的长Clientkey`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        string Api_GetLongClientkey(string 响应的QQ);
        /// <summary>
        /// 取得页面操作用的Cookies`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        string Api_GetCookies(string 响应的QQ);
        /// <summary>
        /// 将指定QQ列入QQ黑名单`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        void Api_AddBkList(string 响应的QQ, string QQ);
        /// <summary>
        /// 禁言群成员`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="群号">禁言对象所在群.</param>
        /// <param name="QQ">禁言对象.留空为全群禁言</param>
        /// <param name="时长">单位:秒 最大为1个月. 为零解除对象或全群禁言</param>
        /// <returns></returns>
        void Api_ShutUP(string 响应的QQ, string 群号, string QQ, int 时长);
        /// <summary>
        /// 发群公告`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="群号"></param>
        /// <param name="标题"></param>
        /// <param name="内容"></param>
        /// <returns></returns>
        void Api_PBGroupNotic(string 响应的QQ, string 群号, string 标题, string 内容);
        /// <summary>
        /// 取群名片`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="群号"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        string Api_GetGroupCard(string 响应的QQ, string 群号, string QQ);
        /// <summary>
        /// 设置群名片`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="群号"></param>
        /// <param name="QQ"></param>
        /// <param name="名片"></param>
        /// <returns></returns>
        void Api_SetGroupCard(string 响应的QQ, string 群号, string QQ, string 名片);
        /// <summary>
        /// 退出讨论组`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="讨论组ID"></param>
        /// <returns></returns>
        void Api_QuitDisGroup(string 响应的QQ, string 讨论组ID);
        /// <summary>
        /// 删除好友`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        bool Api_DelFriend(string 响应的QQ, string QQ);
        /// <summary>
        /// 将对象移除群`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="群号"></param>
        /// <param name="对象"></param>
        /// <param name="不再接收加群请求">真为不再接收，假为接收</param>
        /// <returns></returns>
        void Api_KickGroupMBR(string 响应的QQ, string 群号, string 对象, bool 不再接收加群请求);
        /// <summary>
        /// 主动加群.为了避免广告、群发行为。出现验证码时将会直接失败不处理`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="群号"></param>
        /// <param name="附加理由"></param>
        /// <returns></returns>
        void Api_JoinGroup(string 响应的QQ, string 群号, string 附加理由);
        /// <summary>
        /// 退出群`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="群号"></param>
        /// <returns></returns>
        void Api_QuitGroup(string 响应的QQ, string 群号);
        /// <summary>
        /// 返回值:成功返回图片GUID用于发送该图片.失败返回空.  图片尺寸应小于4MB`
        /// </summary>
        /// <param name="响应的QQ">机器人QQ</param>
        /// <param name="参_上传类型">1好友2群 注:好友图和群图的GUID并不相同并不通用 需要非别上传。群、讨论组用类型2 临时会话、好友信息需要类型1</param>
        /// <param name="参_参考对象">上传该图片所属的群号或QQ</param>
        /// <param name="参_图片数据">址, 图片字节集数据或字节集数据指针()</param>
        /// <returns></returns>
        string Api_UpLoadPic(string 响应的QQ, int 参_上传类型, string 参_参考对象, byte[] 参_图片数据);
        /// <summary>
        /// 根据图片GUID取得图片下载连接 失败返回空`
        /// </summary>
        ///<param name="响应的QQ">机器人QQ</param>
        ///<param name="图片类型">图片类型</param> 1 群 讨论组  2临时会话和好友
        ///<param name="参考对象">参考对象</param> 图片所属对应的群号（可随意乱填写，只有群图片需要填写）
        ///<param name="图片GUID">图片GUID</param>
        /// <returns></returns>
        string Api_GetPicLink(string 响应的QQ, int 图片类型, string 参考对象, string 图片GUID);
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
        long Api_SendMsg(string 响应的QQ, int 信息类型, string 收信群_讨论组, string 收信对象, string 内容, int 气泡ID);
        /// <summary>
        /// 在框架记录页输出一行信息`
        /// </summary>
        /// <param name="内容">输出的内容</param>
        /// <returns></returns>
        void Api_OutPutLog(string 内容);
        /// <summary>
        /// 取得本插件启用状态`
        /// </summary>
        /// <returns></returns>
        bool Api_IsEnable();
        /// <summary>
        /// 登录一个现存的QQ`
        /// </summary>
        /// <param name="QQ">欲登录的Q</param>
        /// <returns></returns>
        void Api_LoginQQ(string QQ);
        /// <summary>
        /// 让指定QQ下线`
        /// </summary>
        /// <param name="QQ"></param>
        /// <returns></returns>
        void Api_OffLineQQ(string QQ);
        /// <summary>
        /// tean加密算法`
        /// </summary>
        /// <param name="加密内容"></param>
        /// <param name="Key"></param>
        /// <returns></returns>
        string Api_Tea加密(string 加密内容, string Key);
        /// <summary>
        /// tean解密算法`
        /// </summary>
        /// <param name="解密内容"></param>
        /// <param name="Key"></param>
        /// <returns></returns>
        string Api_Tea解密(string 解密内容, string Key);
        /// <summary>
        /// 取用户名`
        /// </summary>
        /// <param name="QQ"></param>
        /// <returns></returns>
        string Api_GetRInf(string QQ);
        /// <summary>
        /// 群号转群ID`
        /// </summary>
        /// <param name="群号"></param>
        /// <returns></returns>
        string Api_GNTransGID(string 群号);
        /// <summary>
        /// 群ID转群号`
        /// </summary>
        /// <param name="群ID"></param>
        /// <returns></returns>
        string Api_GIDTransGN(string 群ID);
        /// <summary>
        /// 取框架版本名`
        /// </summary>
        /// <returns></returns>
        string Api_GetVer();
        /// <summary>
        /// 取当前框架内部时间戳_周期性与服务器时间同步`
        /// </summary>
        /// <returns></returns>
        long Api_GetTimeStamp();
        /// <summary>
        /// 取得框架输出列表内所有信息`
        /// </summary>
        /// <returns></returns>
        string Api_GetLog();
        /// <summary>
        /// 取包括群主在内的群管列表`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="群号"></param>
        /// <returns></returns>
        string Api_GetGroupAdmin(string 响应的QQ, string 群号);
        /// <summary>
        /// 发说说`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="内容"></param>
        /// <returns></returns>
        string Api_PBTaoTao(string 响应的QQ, string 内容);
        /// <summary>
        /// QQ群签到（成功返回真 失败返回假）
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="群号"></param>
        /// <param name="地名">签到地名（Pro可自定义）</param>
        /// <param name="想说的话">想发表的内容</param>
        /// <returns></returns>
        bool Api_SignIn(string 响应的QQ, string 群号, string 地名, string 想说的话);
        /// <summary>
        /// 通过qun.qzone.qq.com接口取得取群列表.成功返回转码后的JSON格式文本信息`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        string Api_GetGroupList(string 响应的QQ);
        /// <summary>
        /// 通过qun.qq.com接口取得群成员列表 成功返回转码后的JSON格式文本`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="群号"></param>
        /// <returns></returns>
        string Api_GetGroupMemberList(string 响应的QQ, string 群号);
        /// <summary>
        /// 通过qun.qq.com接口取得好友列表。成功返回转码后的JSON文本`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        string Api_GetFriendList(string 响应的QQ);
        /// <summary>
        /// 取Q龄 成功返回Q龄 失败返回-1`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        int Api_GetQQAge(string 响应的QQ, string QQ);
        /// <summary>
        /// 取年龄 成功返回年龄 失败返回-1`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        int Api_GetAge(string 响应的QQ, string QQ);
        /// <summary>
        /// 取个人说明`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="QQ">对象QQ</param>
        /// <returns></returns>
        string Api_GetPerExp(string 响应的QQ, string QQ);
        /// <summary>
        /// 取邮箱 成功返回邮箱 失败返回空`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        string Api_GetEmail(string 响应的QQ, string QQ);
        /// <summary>
        /// 取对象性别 1男 2女  未或失败返回-1`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        int Api_GetGender(string 响应的QQ, string QQ);
        /// <summary>
        /// 向好友发送窗口抖动信息`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        bool Api_ShakeWindow(string 响应的QQ, string QQ);
        /// <summary>
        /// 往帐号列表添加一个Q.当该Q已存在时则覆盖密码`
        /// </summary>
        /// <param name="QQ"></param>
        /// <param name="密码"></param>
        /// <param name="自动登录">运行框架时是否自动登录该Q.若添加后需要登录该Q则需要通过Api_Login操作</param>
        /// <returns></returns>
        string Api_AddQQ(string QQ, string 密码, bool 自动登录);
        /// <summary>
        /// 设置在线状态+附加信息 `
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="在线状态">1~6 分别对应我在线上, Q我吧, 离开, 忙碌, 请勿打扰, 隐身</param>
        /// <param name="状态附加信息">最大255字节</param>
        /// <returns></returns>
        void Api_SetRInf(string 响应的QQ, int 在线状态, string 状态附加信息);
        /// <summary>
        /// 邀请对象加入群 失败返回错误理由`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="好友QQ">多个好友用换行分割</param>
        /// <param name="群号"></param>
        /// <returns></returns>
        void Api_NoAdminInviteGroup(string 响应的QQ, string 好友QQ, string 群号);
        /// <summary>
        /// 创建一个讨论组 成功返回讨论组ID 失败返回空 注:每24小时只能创建100个讨论组 悠着点用`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="讨论组名称">讨论组名称</param>
        /// <returns></returns>
        string Api_CreateDisGroup(string 响应的QQ, string 讨论组名称);
        /// <summary>
        /// 将对象移除讨论组.成功返回空 失败返回理由`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="讨论组ID"></param>
        /// <param name="成员"></param>
        /// <returns></returns>
        string Api_KickDisGroupMBR(string 响应的QQ, string 讨论组ID, string 成员);
        /// <summary>
        /// 邀请对象加入讨论组 成功返回空 失败返回理由`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="讨论组ID"></param>
        /// <param name="成员组">多个成员用换行符分割</param>
        /// <returns></returns>
        string Api_InviteDisGroup(string 响应的QQ, string 讨论组ID, string 成员组);
        /// <summary>
        /// 成功返回以换行符分割的讨论组号列表.最大为100个讨论组  失败返回空`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <returns></returns>
        string Api_GetDisGroupList(string 响应的QQ);
        /// <summary>
        /// 判断对象是否为好友（双向）`
        /// </summary>
        /// <param name="响应的QQ"></param>
        /// <param name="对象QQ"></param>
        /// <returns></returns>
        bool Api_IfFriend(string 响应的QQ, string 对象QQ);
    }
}
