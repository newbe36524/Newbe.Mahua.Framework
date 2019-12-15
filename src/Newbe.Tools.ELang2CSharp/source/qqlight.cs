// generate at 2019/12/15 8:54:12 +00:00
public interface IQQLightApi{
/// <summary>
/// //给QQ点名片赞，PCQQ点赞不稳定，容易失效
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//给QQ点名片赞，PCQQ点赞不稳定，容易失效")]void Api_SendPraise([Description("")] string QQID,[Description("")] int AuthCode);
/// <summary>
/// //抖动好友窗口
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//抖动好友窗口")]void Api_SendShake([Description("")] string QQID,[Description("")] int AuthCode);
/// <summary>
/// //取得网页操作时需要用到的bkn/Gtk
/// </summary>
/// <param name="Cookies"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//取得网页操作时需要用到的bkn/Gtk")]string Api_Getbkn([Description("")] string Cookies,[Description("")] int AuthCode);
/// <summary>
/// //取得网页操作时需要用到的bkn/Gtk
/// </summary>
/// <param name="Cookies"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//取得网页操作时需要用到的bkn/Gtk")]string Api_Getbkn_Long([Description("")] string Cookies,[Description("")] int AuthCode);
/// <summary>
/// //退出群
/// </summary>
/// <param name="GroupID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//退出群")]void Api_QuitGroup([Description("")] string GroupID,[Description("")] int AuthCode);
/// <summary>
/// //退出讨论组
/// </summary>
/// <param name="GroupID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//退出讨论组")]void Api_QuitDiscussGroup([Description("")] string GroupID,[Description("")] int AuthCode);
/// <summary>
/// //修改个性签名
/// </summary>
/// <param name="Signature"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//修改个性签名")]void Api_SetSignature([Description("")] string Signature,[Description("")] int AuthCode);
/// <summary>
/// //修改讨论组名称
/// </summary>
/// <param name="DiscussGroupID"></param>
/// <param name="Name"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//修改讨论组名称")]void Api_SetDiscussName([Description("")] string DiscussGroupID,[Description("")] string Name,[Description("")] int AuthCode);
/// <summary>
/// //修改群名称
/// </summary>
/// <param name="GroupID"></param>
/// <param name="Name"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//修改群名称")]void Api_SetGroupName([Description("")] string GroupID,[Description("")] string Name,[Description("")] int AuthCode);
/// <summary>
/// //设置全群禁言
/// </summary>
/// <param name="GroupID"></param>
/// <param name="IsBanGroup">真 开启全群禁言 假 关闭全群禁言</param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//设置全群禁言")]void Api_BanGroup([Description("")] string GroupID,[Description("真 开启全群禁言 假 关闭全群禁言")] bool IsBanGroup,[Description("")] int AuthCode);
/// <summary>
/// //设置管理员权限
/// </summary>
/// <param name="GroupID"></param>
/// <param name="QQID"></param>
/// <param name="IsManager">真,设置  假,取消</param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//设置管理员权限")]void Api_SetManager([Description("")] string GroupID,[Description("")] string QQID,[Description("真,设置  假,取消")] bool IsManager,[Description("")] int AuthCode);
/// <summary>
/// //禁言群成员
/// </summary>
/// <param name="GroupID"></param>
/// <param name="QQ"></param>
/// <param name="time">单位:秒  0为解除禁言</param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//禁言群成员")]void Api_Ban([Description("")] string GroupID,[Description("")] string QQ,[Description("单位:秒  0为解除禁言")] int time,[Description("")] int AuthCode);
/// <summary>
/// //修改匿名权限
/// </summary>
/// <param name="GroupID"></param>
/// <param name="IsSetAnony">真 允许匿名  假 禁止匿名</param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//修改匿名权限")]void Api_SetAnony([Description("")] string GroupID,[Description("真 允许匿名  假 禁止匿名")] bool IsSetAnony,[Description("")] int AuthCode);
/// <summary>
/// //踢出群成员
/// </summary>
/// <param name="GroupID"></param>
/// <param name="QQID"></param>
/// <param name="IsBan">不再接受此人加群</param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//踢出群成员")]void Api_RemoveMember([Description("")] string GroupID,[Description("")] string QQID,[Description("不再接受此人加群")] bool IsBan,[Description("")] int AuthCode);
/// <summary>
/// //解散群
/// </summary>
/// <param name="GroupID">群号</param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//解散群")]void Api_RemoveGroup([Description("群号")] string GroupID,[Description("")] int AuthCode);
/// <summary>
/// //取得操作网页所需要的Cookies
/// </summary>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//取得操作网页所需要的Cookies")]string Api_GetCookies([Description("")] int AuthCode);
/// <summary>
/// //取得QQ空间Token
/// </summary>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//取得QQ空间Token")]string Api_GetQzoneToken([Description("")] int AuthCode);
/// <summary>
/// //取得QQ空间Cookies
/// </summary>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//取得QQ空间Cookies")]string Api_GetQzoneCookies([Description("")] int AuthCode);
/// <summary>
/// //发表说说
/// </summary>
/// <param name="Str"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//发表说说")]string Api_SendTaotao([Description("")] string Str,[Description("")] int AuthCode);
/// <summary>
/// //取得所登录的QQ
/// </summary>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//取得所登录的QQ")]string Api_GetLoginQQ([Description("")] int AuthCode);
/// <summary>
/// //框架为插件所创建的插件目录
/// </summary>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//框架为插件所创建的插件目录")]string Api_GetPath([Description("")] int AuthCode);
/// <summary>
/// //置插件错误管理
/// </summary>
/// <param name="Code"></param>
/// <param name="Str"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//置插件错误管理")]string Api_Error([Description("")] string Code,[Description("")] string Str,[Description("")] int AuthCode);
/// <summary>
/// //机器人发送消息，返回值为该条消息的ID
/// </summary>
/// <param name="Type">1.好友消息 2.群消息 3.群临时消息 4.讨论组消息 5.讨论组临时消息 6.QQ临时消息</param>
/// <param name="GroupID"></param>
/// <param name="QQID">类型为2，4时可留空</param>
/// <param name="Msg"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//机器人发送消息，返回值为该条消息的ID")]string Api_SendMsg([Description("1.好友消息 2.群消息 3.群临时消息 4.讨论组消息 5.讨论组临时消息 6.QQ临时消息")] int Type,[Description("")] string GroupID,[Description("类型为2，4时可留空")] string QQID,[Description("")] string Msg,[Description("")] int AuthCode);
/// <summary>
/// //处理加群消息
/// </summary>
/// <param name="GroupID"></param>
/// <param name="QQID"></param>
/// <param name="Seq"></param>
/// <param name="Type">1.同意 2.拒绝 3.忽略</param>
/// <param name="Reason">参数可为空，且为 拒绝 时有效</param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//处理加群消息")]void Api_SetGroupAdd([Description("")] string GroupID,[Description("")] string QQID,[Description("")] string Seq,[Description("1.同意 2.拒绝 3.忽略")] int Type,[Description("参数可为空，且为 拒绝 时有效")] string Reason,[Description("")] int AuthCode);
/// <summary>
/// //处理加好友消息
/// </summary>
/// <param name="QQID"></param>
/// <param name="Type">1.同意 2.拒绝 3.忽略</param>
/// <param name="Reason">参数可为空，且为 拒绝 时有效</param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//处理加好友消息")]void Api_SetFriendAdd([Description("")] string QQID,[Description("1.同意 2.拒绝 3.忽略")] int Type,[Description("参数可为空，且为 拒绝 时有效")] string Reason,[Description("")] int AuthCode);
/// <summary>
/// //向框架推送一条日志
/// </summary>
/// <param name="Type">日志类型（自定义）</param>
/// <param name="Msg">日志内容</param>
/// <param name="FontColor">日志颜色</param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//向框架推送一条日志")]void Api_SendLog([Description("日志类型（自定义）")] string Type,[Description("日志内容")] string Msg,[Description("日志颜色")] int FontColor,[Description("")] int AuthCode);
/// <summary>
/// //修改好友备注
/// </summary>
/// <param name="QQID"></param>
/// <param name="Name"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//修改好友备注")]void Api_SetFriendName([Description("")] string QQID,[Description("")] string Name,[Description("")] int AuthCode);
/// <summary>
/// //删除好友
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//删除好友")]void Api_DeleteFriend([Description("")] string QQID,[Description("")] int AuthCode);
/// <summary>
/// //主动添加群
/// </summary>
/// <param name="GroupID"></param>
/// <param name="附加信息"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//主动添加群")]void Api_AddGroup([Description("")] string GroupID,[Description("")] string 附加信息,[Description("")] int AuthCode);
/// <summary>
/// //主动添加好友
/// </summary>
/// <param name="QQID"></param>
/// <param name="Info"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//主动添加好友")]void Api_AddFriend([Description("")] string QQID,[Description("")] string Info,[Description("")] int AuthCode);
/// <summary>
/// //返回卡片点歌JSON代码
/// </summary>
/// <param name="SongID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//返回卡片点歌JSON代码")]string Api_JsonMusic([Description("")] string SongID,[Description("")] int AuthCode);
/// <summary>
/// //取得群内成员的名片
/// </summary>
/// <param name="GroupID"></param>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//取得群内成员的名片")]string Api_GetGroupCard([Description("")] string GroupID,[Description("")] string QQID,[Description("")] int AuthCode);
/// <summary>
/// //取指定QQ的昵称
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//取指定QQ的昵称")]string Api_GetNick([Description("")] string QQID,[Description("")] int AuthCode);
/// <summary>
/// 
/// </summary>
/// <param name="GroupID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("")]string Api_GetGroupName([Description("")] string GroupID,[Description("")] int AuthCode);
/// <summary>
/// 
/// </summary>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("")]string Api_GetSoftVersion([Description("")] int AuthCode);
/// <summary>
/// 
/// </summary>
/// <param name="GroupID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("")]string Api_GetGroupIntroduce([Description("")] string GroupID,[Description("")] int AuthCode);
/// <summary>
/// 
/// </summary>
/// <param name="GroupID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("")]string Api_GetGroupOwner([Description("")] string GroupID,[Description("")] int AuthCode);
/// <summary>
/// //修改群成员的名片
/// </summary>
/// <param name="GroupID"></param>
/// <param name="QQID"></param>
/// <param name="NewCard"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//修改群成员的名片")]void Api_SetGroupCard([Description("")] string GroupID,[Description("")] string QQID,[Description("")] string NewCard,[Description("")] int AuthCode);
/// <summary>
/// //取得某个QQ的名片赞数量
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//取得某个QQ的名片赞数量")]string Api_GetPraiseNum([Description("")] string QQID,[Description("")] int AuthCode);
/// <summary>
/// //取得某个QQ的等级
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//取得某个QQ的等级")]int Api_GetQQLevel([Description("")] string QQID,[Description("")] int AuthCode);
/// <summary>
/// 
/// </summary>
/// <param name="NewNick"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("")]void Api_SetNick([Description("")] string NewNick,[Description("")] int AuthCode);
/// <summary>
/// 
/// </summary>
/// <param name="QQID"></param>
/// <param name="URL"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("")]string Api_Taotaodolike([Description("")] string QQID,[Description("")] string URL,[Description("")] int AuthCode);
/// <summary>
/// 
/// </summary>
/// <param name="QQID"></param>
/// <param name="URL"></param>
/// <param name="Content"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("")]string Api_Taotaofeeds([Description("")] string QQID,[Description("")] string URL,[Description("")] string Content,[Description("")] int AuthCode);
/// <summary>
/// 
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("")]int Api_GetQQAge([Description("")] string QQID,[Description("")] int AuthCode);
/// <summary>
/// 
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("")]int Api_GetQQSex([Description("")] string QQID,[Description("")] int AuthCode);
/// <summary>
/// //以JSON形式取得好友列表
/// </summary>
/// <param name="Cache"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//以JSON形式取得好友列表")]string Api_GetFriendList([Description("")] bool Cache,[Description("")] int AuthCode);
/// <summary>
/// //以JSON形式取得群列表
/// </summary>
/// <param name="Cache"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//以JSON形式取得群列表")]string Api_GetGroupList([Description("")] bool Cache,[Description("")] int AuthCode);
/// <summary>
/// //以JSON形式取得群成员列表
/// </summary>
/// <param name="GroupID"></param>
/// <param name="Cache"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//以JSON形式取得群成员列表")]string Api_GetGroupMemberList([Description("")] string GroupID,[Description("")] bool Cache,[Description("")] int AuthCode);
/// <summary>
/// //以JSON形式取得某QQ个人信息
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//以JSON形式取得某QQ个人信息")]string Api_GetQQInfo([Description("")] string QQID,[Description("")] int AuthCode);
/// <summary>
/// //以JSON形式取得某群信息
/// </summary>
/// <param name="GroupID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//以JSON形式取得某群信息")]string Api_GetGroupInfo([Description("")] string GroupID,[Description("")] int AuthCode);
/// <summary>
/// //撤回自身消息 发出消息不可以秒撤回，腾讯限制，1~2s后才可撤回
/// </summary>
/// <param name="Type">1.好友消息 2.群消息 3.群临时消息 4.讨论组消息 5.讨论组临时消息 6.QQ临时消息</param>
/// <param name="GroupID">撤回群消息、群临时消息、讨论组消息、讨论组临时消息必须填写，其余情况可留空</param>
/// <param name="QQID">撤回好友消息、群临时消息、讨论组临时消息、QQ临时消息必须填写，其余情况可留空</param>
/// <param name="MsgID">撤回的消息ID，机器人发送消息会返回自身的消息ID</param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//撤回自身消息 发出消息不可以秒撤回，腾讯限制，1~2s后才可撤回")]void Api_DeleteMsg([Description("1.好友消息 2.群消息 3.群临时消息 4.讨论组消息 5.讨论组临时消息 6.QQ临时消息")] int Type,[Description("撤回群消息、群临时消息、讨论组消息、讨论组临时消息必须填写，其余情况可留空")] string GroupID,[Description("撤回好友消息、群临时消息、讨论组临时消息、QQ临时消息必须填写，其余情况可留空")] string QQID,[Description("撤回的消息ID，机器人发送消息会返回自身的消息ID")] string MsgID,[Description("")] int AuthCode);
/// <summary>
/// //改变QQ在线状态
/// </summary>
/// <param name="Type">1.我在线上 2.Q我吧 3.离开 4.忙碌 5.请勿打扰 6.隐身</param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//改变QQ在线状态")]void Api_SetQQState([Description("1.我在线上 2.Q我吧 3.离开 4.忙碌 5.请勿打扰 6.隐身")] int Type,[Description("")] int AuthCode);
/// <summary>
/// //邀请好友入群
/// </summary>
/// <param name="GroupID"></param>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//邀请好友入群")]void Api_InviteFriend([Description("")] string GroupID,[Description("")] string QQID,[Description("")] int AuthCode);
/// <summary>
/// 
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("")]string Api_GetQQInfo_v2([Description("")] string QQID,[Description("")] int AuthCode);
/// <summary>
/// //取消COM库
/// </summary>
/// <returns></returns>
[Description("//取消COM库")]void CoUninitialize();
/// <summary>
/// //初始化COM库
/// </summary>
/// <param name="pvReserved"></param>
/// <returns></returns>
[Description("//初始化COM库")]void CoInitialize([Description("")] int pvReserved);
/// <summary>
/// //上传图片，获得图片GUID，
/// </summary>
/// <param name="Type">1.私聊图片  2.群聊图片</param>
/// <param name="对象">私聊图片填写QQID，群聊/讨论组图片填写群号讨论组号</param>
/// <param name="Bin">图片的Hex流</param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//上传图片，获得图片GUID，")]string Api_UpLoadPic([Description("1.私聊图片  2.群聊图片")] int Type,[Description("私聊图片填写QQID，群聊/讨论组图片填写群号讨论组号")] string 对象,[Description("图片的Hex流")] string Bin,[Description("")] int AuthCode);
/// <summary>
/// //设置插件状态，开启或关闭
/// </summary>
/// <param name="State">真:启用自身  假:关闭自身</param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("//设置插件状态，开启或关闭")]string Api_SetPluginState([Description("真:启用自身  假:关闭自身")] bool State,[Description("")] int AuthCode);
/// <summary>
/// 
/// </summary>
/// <param name="群号"></param>
/// <param name="文件GUID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("")]void Api_DeleteFile([Description("")] string 群号,[Description("")] string 文件GUID,[Description("")] int AuthCode);
/// <summary>
/// 
/// </summary>
/// <param name="来源对象"></param>
/// <param name="转发群号"></param>
/// <param name="文件GUID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("")]void Api_RepeatFile([Description("")] string 来源对象,[Description("")] string 转发群号,[Description("")] string 文件GUID,[Description("")] int AuthCode);
/// <summary>
/// 
/// </summary>
/// <param name="AuthCode"></param>
/// <returns></returns>
[Description("")]void Api_ClearOffLineFile([Description("")] int AuthCode);
/// <summary>
/// 
/// </summary>
/// <param name="CodePage"></param>
/// <param name="dwFlags"></param>
/// <param name="lpWideCharStr">址</param>
/// <param name="cchWideChar"></param>
/// <param name="lpMultiByteStr">址</param>
/// <param name="cchMultiByte"></param>
/// <param name="lpDefaultChar"></param>
/// <param name="lpUsedDefaultChar"></param>
/// <returns></returns>
[Description("")]int WideCharToMultiByte([Description("")] int CodePage,[Description("")] int dwFlags,[Description("址")] byte[] lpWideCharStr,[Description("")] int cchWideChar,[Description("址")] string lpMultiByteStr,[Description("")] int cchMultiByte,[Description("")] int lpDefaultChar,[Description("")] int lpUsedDefaultChar);
}
public class QQLightApi:IQQLightApi{

 		/// <summary>
/// //给QQ点名片赞，PCQQ点赞不稳定，容易失效
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQQLightApi.Api_SendPraise([Description("")] string QQID,[Description("")] int AuthCode)
		 =>NativeMethods.Api_SendPraise(QQID,AuthCode);
		 		/// <summary>
/// //抖动好友窗口
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQQLightApi.Api_SendShake([Description("")] string QQID,[Description("")] int AuthCode)
		 =>NativeMethods.Api_SendShake(QQID,AuthCode);
		 		/// <summary>
/// //取得网页操作时需要用到的bkn/Gtk
/// </summary>
/// <param name="Cookies"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQQLightApi.Api_Getbkn([Description("")] string Cookies,[Description("")] int AuthCode)
		 =>NativeMethods.Api_Getbkn(Cookies,AuthCode);
		 		/// <summary>
/// //取得网页操作时需要用到的bkn/Gtk
/// </summary>
/// <param name="Cookies"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQQLightApi.Api_Getbkn_Long([Description("")] string Cookies,[Description("")] int AuthCode)
		 =>NativeMethods.Api_Getbkn_Long(Cookies,AuthCode);
		 		/// <summary>
/// //退出群
/// </summary>
/// <param name="GroupID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQQLightApi.Api_QuitGroup([Description("")] string GroupID,[Description("")] int AuthCode)
		 =>NativeMethods.Api_QuitGroup(GroupID,AuthCode);
		 		/// <summary>
/// //退出讨论组
/// </summary>
/// <param name="GroupID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQQLightApi.Api_QuitDiscussGroup([Description("")] string GroupID,[Description("")] int AuthCode)
		 =>NativeMethods.Api_QuitDiscussGroup(GroupID,AuthCode);
		 		/// <summary>
/// //修改个性签名
/// </summary>
/// <param name="Signature"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQQLightApi.Api_SetSignature([Description("")] string Signature,[Description("")] int AuthCode)
		 =>NativeMethods.Api_SetSignature(Signature,AuthCode);
		 		/// <summary>
/// //修改讨论组名称
/// </summary>
/// <param name="DiscussGroupID"></param>
/// <param name="Name"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQQLightApi.Api_SetDiscussName([Description("")] string DiscussGroupID,[Description("")] string Name,[Description("")] int AuthCode)
		 =>NativeMethods.Api_SetDiscussName(DiscussGroupID,Name,AuthCode);
		 		/// <summary>
/// //修改群名称
/// </summary>
/// <param name="GroupID"></param>
/// <param name="Name"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQQLightApi.Api_SetGroupName([Description("")] string GroupID,[Description("")] string Name,[Description("")] int AuthCode)
		 =>NativeMethods.Api_SetGroupName(GroupID,Name,AuthCode);
		 		/// <summary>
/// //设置全群禁言
/// </summary>
/// <param name="GroupID"></param>
/// <param name="IsBanGroup">真 开启全群禁言 假 关闭全群禁言</param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQQLightApi.Api_BanGroup([Description("")] string GroupID,[Description("真 开启全群禁言 假 关闭全群禁言")] bool IsBanGroup,[Description("")] int AuthCode)
		 =>NativeMethods.Api_BanGroup(GroupID,IsBanGroup,AuthCode);
		 		/// <summary>
/// //设置管理员权限
/// </summary>
/// <param name="GroupID"></param>
/// <param name="QQID"></param>
/// <param name="IsManager">真,设置  假,取消</param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQQLightApi.Api_SetManager([Description("")] string GroupID,[Description("")] string QQID,[Description("真,设置  假,取消")] bool IsManager,[Description("")] int AuthCode)
		 =>NativeMethods.Api_SetManager(GroupID,QQID,IsManager,AuthCode);
		 		/// <summary>
/// //禁言群成员
/// </summary>
/// <param name="GroupID"></param>
/// <param name="QQ"></param>
/// <param name="time">单位:秒  0为解除禁言</param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQQLightApi.Api_Ban([Description("")] string GroupID,[Description("")] string QQ,[Description("单位:秒  0为解除禁言")] int time,[Description("")] int AuthCode)
		 =>NativeMethods.Api_Ban(GroupID,QQ,time,AuthCode);
		 		/// <summary>
/// //修改匿名权限
/// </summary>
/// <param name="GroupID"></param>
/// <param name="IsSetAnony">真 允许匿名  假 禁止匿名</param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQQLightApi.Api_SetAnony([Description("")] string GroupID,[Description("真 允许匿名  假 禁止匿名")] bool IsSetAnony,[Description("")] int AuthCode)
		 =>NativeMethods.Api_SetAnony(GroupID,IsSetAnony,AuthCode);
		 		/// <summary>
/// //踢出群成员
/// </summary>
/// <param name="GroupID"></param>
/// <param name="QQID"></param>
/// <param name="IsBan">不再接受此人加群</param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQQLightApi.Api_RemoveMember([Description("")] string GroupID,[Description("")] string QQID,[Description("不再接受此人加群")] bool IsBan,[Description("")] int AuthCode)
		 =>NativeMethods.Api_RemoveMember(GroupID,QQID,IsBan,AuthCode);
		 		/// <summary>
/// //解散群
/// </summary>
/// <param name="GroupID">群号</param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQQLightApi.Api_RemoveGroup([Description("群号")] string GroupID,[Description("")] int AuthCode)
		 =>NativeMethods.Api_RemoveGroup(GroupID,AuthCode);
		 		/// <summary>
/// //取得操作网页所需要的Cookies
/// </summary>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQQLightApi.Api_GetCookies([Description("")] int AuthCode)
		 =>NativeMethods.Api_GetCookies(AuthCode);
		 		/// <summary>
/// //取得QQ空间Token
/// </summary>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQQLightApi.Api_GetQzoneToken([Description("")] int AuthCode)
		 =>NativeMethods.Api_GetQzoneToken(AuthCode);
		 		/// <summary>
/// //取得QQ空间Cookies
/// </summary>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQQLightApi.Api_GetQzoneCookies([Description("")] int AuthCode)
		 =>NativeMethods.Api_GetQzoneCookies(AuthCode);
		 		/// <summary>
/// //发表说说
/// </summary>
/// <param name="Str"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQQLightApi.Api_SendTaotao([Description("")] string Str,[Description("")] int AuthCode)
		 =>NativeMethods.Api_SendTaotao(Str,AuthCode);
		 		/// <summary>
/// //取得所登录的QQ
/// </summary>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQQLightApi.Api_GetLoginQQ([Description("")] int AuthCode)
		 =>NativeMethods.Api_GetLoginQQ(AuthCode);
		 		/// <summary>
/// //框架为插件所创建的插件目录
/// </summary>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQQLightApi.Api_GetPath([Description("")] int AuthCode)
		 =>NativeMethods.Api_GetPath(AuthCode);
		 		/// <summary>
/// //置插件错误管理
/// </summary>
/// <param name="Code"></param>
/// <param name="Str"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQQLightApi.Api_Error([Description("")] string Code,[Description("")] string Str,[Description("")] int AuthCode)
		 =>NativeMethods.Api_Error(Code,Str,AuthCode);
		 		/// <summary>
/// //机器人发送消息，返回值为该条消息的ID
/// </summary>
/// <param name="Type">1.好友消息 2.群消息 3.群临时消息 4.讨论组消息 5.讨论组临时消息 6.QQ临时消息</param>
/// <param name="GroupID"></param>
/// <param name="QQID">类型为2，4时可留空</param>
/// <param name="Msg"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQQLightApi.Api_SendMsg([Description("1.好友消息 2.群消息 3.群临时消息 4.讨论组消息 5.讨论组临时消息 6.QQ临时消息")] int Type,[Description("")] string GroupID,[Description("类型为2，4时可留空")] string QQID,[Description("")] string Msg,[Description("")] int AuthCode)
		 =>NativeMethods.Api_SendMsg(Type,GroupID,QQID,Msg,AuthCode);
		 		/// <summary>
/// //处理加群消息
/// </summary>
/// <param name="GroupID"></param>
/// <param name="QQID"></param>
/// <param name="Seq"></param>
/// <param name="Type">1.同意 2.拒绝 3.忽略</param>
/// <param name="Reason">参数可为空，且为 拒绝 时有效</param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQQLightApi.Api_SetGroupAdd([Description("")] string GroupID,[Description("")] string QQID,[Description("")] string Seq,[Description("1.同意 2.拒绝 3.忽略")] int Type,[Description("参数可为空，且为 拒绝 时有效")] string Reason,[Description("")] int AuthCode)
		 =>NativeMethods.Api_SetGroupAdd(GroupID,QQID,Seq,Type,Reason,AuthCode);
		 		/// <summary>
/// //处理加好友消息
/// </summary>
/// <param name="QQID"></param>
/// <param name="Type">1.同意 2.拒绝 3.忽略</param>
/// <param name="Reason">参数可为空，且为 拒绝 时有效</param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQQLightApi.Api_SetFriendAdd([Description("")] string QQID,[Description("1.同意 2.拒绝 3.忽略")] int Type,[Description("参数可为空，且为 拒绝 时有效")] string Reason,[Description("")] int AuthCode)
		 =>NativeMethods.Api_SetFriendAdd(QQID,Type,Reason,AuthCode);
		 		/// <summary>
/// //向框架推送一条日志
/// </summary>
/// <param name="Type">日志类型（自定义）</param>
/// <param name="Msg">日志内容</param>
/// <param name="FontColor">日志颜色</param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQQLightApi.Api_SendLog([Description("日志类型（自定义）")] string Type,[Description("日志内容")] string Msg,[Description("日志颜色")] int FontColor,[Description("")] int AuthCode)
		 =>NativeMethods.Api_SendLog(Type,Msg,FontColor,AuthCode);
		 		/// <summary>
/// //修改好友备注
/// </summary>
/// <param name="QQID"></param>
/// <param name="Name"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQQLightApi.Api_SetFriendName([Description("")] string QQID,[Description("")] string Name,[Description("")] int AuthCode)
		 =>NativeMethods.Api_SetFriendName(QQID,Name,AuthCode);
		 		/// <summary>
/// //删除好友
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQQLightApi.Api_DeleteFriend([Description("")] string QQID,[Description("")] int AuthCode)
		 =>NativeMethods.Api_DeleteFriend(QQID,AuthCode);
		 		/// <summary>
/// //主动添加群
/// </summary>
/// <param name="GroupID"></param>
/// <param name="附加信息"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQQLightApi.Api_AddGroup([Description("")] string GroupID,[Description("")] string 附加信息,[Description("")] int AuthCode)
		 =>NativeMethods.Api_AddGroup(GroupID,附加信息,AuthCode);
		 		/// <summary>
/// //主动添加好友
/// </summary>
/// <param name="QQID"></param>
/// <param name="Info"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQQLightApi.Api_AddFriend([Description("")] string QQID,[Description("")] string Info,[Description("")] int AuthCode)
		 =>NativeMethods.Api_AddFriend(QQID,Info,AuthCode);
		 		/// <summary>
/// //返回卡片点歌JSON代码
/// </summary>
/// <param name="SongID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQQLightApi.Api_JsonMusic([Description("")] string SongID,[Description("")] int AuthCode)
		 =>NativeMethods.Api_JsonMusic(SongID,AuthCode);
		 		/// <summary>
/// //取得群内成员的名片
/// </summary>
/// <param name="GroupID"></param>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQQLightApi.Api_GetGroupCard([Description("")] string GroupID,[Description("")] string QQID,[Description("")] int AuthCode)
		 =>NativeMethods.Api_GetGroupCard(GroupID,QQID,AuthCode);
		 		/// <summary>
/// //取指定QQ的昵称
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQQLightApi.Api_GetNick([Description("")] string QQID,[Description("")] int AuthCode)
		 =>NativeMethods.Api_GetNick(QQID,AuthCode);
		 		/// <summary>
/// 
/// </summary>
/// <param name="GroupID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQQLightApi.Api_GetGroupName([Description("")] string GroupID,[Description("")] int AuthCode)
		 =>NativeMethods.Api_GetGroupName(GroupID,AuthCode);
		 		/// <summary>
/// 
/// </summary>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQQLightApi.Api_GetSoftVersion([Description("")] int AuthCode)
		 =>NativeMethods.Api_GetSoftVersion(AuthCode);
		 		/// <summary>
/// 
/// </summary>
/// <param name="GroupID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQQLightApi.Api_GetGroupIntroduce([Description("")] string GroupID,[Description("")] int AuthCode)
		 =>NativeMethods.Api_GetGroupIntroduce(GroupID,AuthCode);
		 		/// <summary>
/// 
/// </summary>
/// <param name="GroupID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQQLightApi.Api_GetGroupOwner([Description("")] string GroupID,[Description("")] int AuthCode)
		 =>NativeMethods.Api_GetGroupOwner(GroupID,AuthCode);
		 		/// <summary>
/// //修改群成员的名片
/// </summary>
/// <param name="GroupID"></param>
/// <param name="QQID"></param>
/// <param name="NewCard"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQQLightApi.Api_SetGroupCard([Description("")] string GroupID,[Description("")] string QQID,[Description("")] string NewCard,[Description("")] int AuthCode)
		 =>NativeMethods.Api_SetGroupCard(GroupID,QQID,NewCard,AuthCode);
		 		/// <summary>
/// //取得某个QQ的名片赞数量
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQQLightApi.Api_GetPraiseNum([Description("")] string QQID,[Description("")] int AuthCode)
		 =>NativeMethods.Api_GetPraiseNum(QQID,AuthCode);
		 		/// <summary>
/// //取得某个QQ的等级
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         int  IQQLightApi.Api_GetQQLevel([Description("")] string QQID,[Description("")] int AuthCode)
		 =>NativeMethods.Api_GetQQLevel(QQID,AuthCode);
		 		/// <summary>
/// 
/// </summary>
/// <param name="NewNick"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQQLightApi.Api_SetNick([Description("")] string NewNick,[Description("")] int AuthCode)
		 =>NativeMethods.Api_SetNick(NewNick,AuthCode);
		 		/// <summary>
/// 
/// </summary>
/// <param name="QQID"></param>
/// <param name="URL"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQQLightApi.Api_Taotaodolike([Description("")] string QQID,[Description("")] string URL,[Description("")] int AuthCode)
		 =>NativeMethods.Api_Taotaodolike(QQID,URL,AuthCode);
		 		/// <summary>
/// 
/// </summary>
/// <param name="QQID"></param>
/// <param name="URL"></param>
/// <param name="Content"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQQLightApi.Api_Taotaofeeds([Description("")] string QQID,[Description("")] string URL,[Description("")] string Content,[Description("")] int AuthCode)
		 =>NativeMethods.Api_Taotaofeeds(QQID,URL,Content,AuthCode);
		 		/// <summary>
/// 
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         int  IQQLightApi.Api_GetQQAge([Description("")] string QQID,[Description("")] int AuthCode)
		 =>NativeMethods.Api_GetQQAge(QQID,AuthCode);
		 		/// <summary>
/// 
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         int  IQQLightApi.Api_GetQQSex([Description("")] string QQID,[Description("")] int AuthCode)
		 =>NativeMethods.Api_GetQQSex(QQID,AuthCode);
		 		/// <summary>
/// //以JSON形式取得好友列表
/// </summary>
/// <param name="Cache"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQQLightApi.Api_GetFriendList([Description("")] bool Cache,[Description("")] int AuthCode)
		 =>NativeMethods.Api_GetFriendList(Cache,AuthCode);
		 		/// <summary>
/// //以JSON形式取得群列表
/// </summary>
/// <param name="Cache"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQQLightApi.Api_GetGroupList([Description("")] bool Cache,[Description("")] int AuthCode)
		 =>NativeMethods.Api_GetGroupList(Cache,AuthCode);
		 		/// <summary>
/// //以JSON形式取得群成员列表
/// </summary>
/// <param name="GroupID"></param>
/// <param name="Cache"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQQLightApi.Api_GetGroupMemberList([Description("")] string GroupID,[Description("")] bool Cache,[Description("")] int AuthCode)
		 =>NativeMethods.Api_GetGroupMemberList(GroupID,Cache,AuthCode);
		 		/// <summary>
/// //以JSON形式取得某QQ个人信息
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQQLightApi.Api_GetQQInfo([Description("")] string QQID,[Description("")] int AuthCode)
		 =>NativeMethods.Api_GetQQInfo(QQID,AuthCode);
		 		/// <summary>
/// //以JSON形式取得某群信息
/// </summary>
/// <param name="GroupID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQQLightApi.Api_GetGroupInfo([Description("")] string GroupID,[Description("")] int AuthCode)
		 =>NativeMethods.Api_GetGroupInfo(GroupID,AuthCode);
		 		/// <summary>
/// //撤回自身消息 发出消息不可以秒撤回，腾讯限制，1~2s后才可撤回
/// </summary>
/// <param name="Type">1.好友消息 2.群消息 3.群临时消息 4.讨论组消息 5.讨论组临时消息 6.QQ临时消息</param>
/// <param name="GroupID">撤回群消息、群临时消息、讨论组消息、讨论组临时消息必须填写，其余情况可留空</param>
/// <param name="QQID">撤回好友消息、群临时消息、讨论组临时消息、QQ临时消息必须填写，其余情况可留空</param>
/// <param name="MsgID">撤回的消息ID，机器人发送消息会返回自身的消息ID</param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQQLightApi.Api_DeleteMsg([Description("1.好友消息 2.群消息 3.群临时消息 4.讨论组消息 5.讨论组临时消息 6.QQ临时消息")] int Type,[Description("撤回群消息、群临时消息、讨论组消息、讨论组临时消息必须填写，其余情况可留空")] string GroupID,[Description("撤回好友消息、群临时消息、讨论组临时消息、QQ临时消息必须填写，其余情况可留空")] string QQID,[Description("撤回的消息ID，机器人发送消息会返回自身的消息ID")] string MsgID,[Description("")] int AuthCode)
		 =>NativeMethods.Api_DeleteMsg(Type,GroupID,QQID,MsgID,AuthCode);
		 		/// <summary>
/// //改变QQ在线状态
/// </summary>
/// <param name="Type">1.我在线上 2.Q我吧 3.离开 4.忙碌 5.请勿打扰 6.隐身</param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQQLightApi.Api_SetQQState([Description("1.我在线上 2.Q我吧 3.离开 4.忙碌 5.请勿打扰 6.隐身")] int Type,[Description("")] int AuthCode)
		 =>NativeMethods.Api_SetQQState(Type,AuthCode);
		 		/// <summary>
/// //邀请好友入群
/// </summary>
/// <param name="GroupID"></param>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQQLightApi.Api_InviteFriend([Description("")] string GroupID,[Description("")] string QQID,[Description("")] int AuthCode)
		 =>NativeMethods.Api_InviteFriend(GroupID,QQID,AuthCode);
		 		/// <summary>
/// 
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQQLightApi.Api_GetQQInfo_v2([Description("")] string QQID,[Description("")] int AuthCode)
		 =>NativeMethods.Api_GetQQInfo_v2(QQID,AuthCode);
		 		/// <summary>
/// //取消COM库
/// </summary>
/// <returns></returns>


         void  IQQLightApi.CoUninitialize()
		 =>NativeMethods.CoUninitialize();
		 		/// <summary>
/// //初始化COM库
/// </summary>
/// <param name="pvReserved"></param>
/// <returns></returns>


         void  IQQLightApi.CoInitialize([Description("")] int pvReserved)
		 =>NativeMethods.CoInitialize(pvReserved);
		 		/// <summary>
/// //上传图片，获得图片GUID，
/// </summary>
/// <param name="Type">1.私聊图片  2.群聊图片</param>
/// <param name="对象">私聊图片填写QQID，群聊/讨论组图片填写群号讨论组号</param>
/// <param name="Bin">图片的Hex流</param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQQLightApi.Api_UpLoadPic([Description("1.私聊图片  2.群聊图片")] int Type,[Description("私聊图片填写QQID，群聊/讨论组图片填写群号讨论组号")] string 对象,[Description("图片的Hex流")] string Bin,[Description("")] int AuthCode)
		 =>NativeMethods.Api_UpLoadPic(Type,对象,Bin,AuthCode);
		 		/// <summary>
/// //设置插件状态，开启或关闭
/// </summary>
/// <param name="State">真:启用自身  假:关闭自身</param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQQLightApi.Api_SetPluginState([Description("真:启用自身  假:关闭自身")] bool State,[Description("")] int AuthCode)
		 =>NativeMethods.Api_SetPluginState(State,AuthCode);
		 		/// <summary>
/// 
/// </summary>
/// <param name="群号"></param>
/// <param name="文件GUID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQQLightApi.Api_DeleteFile([Description("")] string 群号,[Description("")] string 文件GUID,[Description("")] int AuthCode)
		 =>NativeMethods.Api_DeleteFile(群号,文件GUID,AuthCode);
		 		/// <summary>
/// 
/// </summary>
/// <param name="来源对象"></param>
/// <param name="转发群号"></param>
/// <param name="文件GUID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQQLightApi.Api_RepeatFile([Description("")] string 来源对象,[Description("")] string 转发群号,[Description("")] string 文件GUID,[Description("")] int AuthCode)
		 =>NativeMethods.Api_RepeatFile(来源对象,转发群号,文件GUID,AuthCode);
		 		/// <summary>
/// 
/// </summary>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQQLightApi.Api_ClearOffLineFile([Description("")] int AuthCode)
		 =>NativeMethods.Api_ClearOffLineFile(AuthCode);
		 		/// <summary>
/// 
/// </summary>
/// <param name="CodePage"></param>
/// <param name="dwFlags"></param>
/// <param name="lpWideCharStr">址</param>
/// <param name="cchWideChar"></param>
/// <param name="lpMultiByteStr">址</param>
/// <param name="cchMultiByte"></param>
/// <param name="lpDefaultChar"></param>
/// <param name="lpUsedDefaultChar"></param>
/// <returns></returns>


         int  IQQLightApi.WideCharToMultiByte([Description("")] int CodePage,[Description("")] int dwFlags,[Description("址")] byte[] lpWideCharStr,[Description("")] int cchWideChar,[Description("址")] string lpMultiByteStr,[Description("")] int cchMultiByte,[Description("")] int lpDefaultChar,[Description("")] int lpUsedDefaultChar)
		 =>NativeMethods.WideCharToMultiByte(CodePage,dwFlags,lpWideCharStr,cchWideChar,lpMultiByteStr,cchMultiByte,lpDefaultChar,lpUsedDefaultChar);
		 private static class NativeMethods
        {
        			/// <summary>
/// //给QQ点名片赞，PCQQ点赞不稳定，容易失效
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern void Api_SendPraise([Description("")] string QQID,[Description("")] int AuthCode);
		 			/// <summary>
/// //抖动好友窗口
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern void Api_SendShake([Description("")] string QQID,[Description("")] int AuthCode);
		 			/// <summary>
/// //取得网页操作时需要用到的bkn/Gtk
/// </summary>
/// <param name="Cookies"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern string Api_Getbkn([Description("")] string Cookies,[Description("")] int AuthCode);
		 			/// <summary>
/// //取得网页操作时需要用到的bkn/Gtk
/// </summary>
/// <param name="Cookies"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern string Api_Getbkn_Long([Description("")] string Cookies,[Description("")] int AuthCode);
		 			/// <summary>
/// //退出群
/// </summary>
/// <param name="GroupID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern void Api_QuitGroup([Description("")] string GroupID,[Description("")] int AuthCode);
		 			/// <summary>
/// //退出讨论组
/// </summary>
/// <param name="GroupID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern void Api_QuitDiscussGroup([Description("")] string GroupID,[Description("")] int AuthCode);
		 			/// <summary>
/// //修改个性签名
/// </summary>
/// <param name="Signature"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern void Api_SetSignature([Description("")] string Signature,[Description("")] int AuthCode);
		 			/// <summary>
/// //修改讨论组名称
/// </summary>
/// <param name="DiscussGroupID"></param>
/// <param name="Name"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern void Api_SetDiscussName([Description("")] string DiscussGroupID,[Description("")] string Name,[Description("")] int AuthCode);
		 			/// <summary>
/// //修改群名称
/// </summary>
/// <param name="GroupID"></param>
/// <param name="Name"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern void Api_SetGroupName([Description("")] string GroupID,[Description("")] string Name,[Description("")] int AuthCode);
		 			/// <summary>
/// //设置全群禁言
/// </summary>
/// <param name="GroupID"></param>
/// <param name="IsBanGroup">真 开启全群禁言 假 关闭全群禁言</param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern void Api_BanGroup([Description("")] string GroupID,[Description("真 开启全群禁言 假 关闭全群禁言")] bool IsBanGroup,[Description("")] int AuthCode);
		 			/// <summary>
/// //设置管理员权限
/// </summary>
/// <param name="GroupID"></param>
/// <param name="QQID"></param>
/// <param name="IsManager">真,设置  假,取消</param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern void Api_SetManager([Description("")] string GroupID,[Description("")] string QQID,[Description("真,设置  假,取消")] bool IsManager,[Description("")] int AuthCode);
		 			/// <summary>
/// //禁言群成员
/// </summary>
/// <param name="GroupID"></param>
/// <param name="QQ"></param>
/// <param name="time">单位:秒  0为解除禁言</param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern void Api_Ban([Description("")] string GroupID,[Description("")] string QQ,[Description("单位:秒  0为解除禁言")] int time,[Description("")] int AuthCode);
		 			/// <summary>
/// //修改匿名权限
/// </summary>
/// <param name="GroupID"></param>
/// <param name="IsSetAnony">真 允许匿名  假 禁止匿名</param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern void Api_SetAnony([Description("")] string GroupID,[Description("真 允许匿名  假 禁止匿名")] bool IsSetAnony,[Description("")] int AuthCode);
		 			/// <summary>
/// //踢出群成员
/// </summary>
/// <param name="GroupID"></param>
/// <param name="QQID"></param>
/// <param name="IsBan">不再接受此人加群</param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern void Api_RemoveMember([Description("")] string GroupID,[Description("")] string QQID,[Description("不再接受此人加群")] bool IsBan,[Description("")] int AuthCode);
		 			/// <summary>
/// //解散群
/// </summary>
/// <param name="GroupID">群号</param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern void Api_RemoveGroup([Description("群号")] string GroupID,[Description("")] int AuthCode);
		 			/// <summary>
/// //取得操作网页所需要的Cookies
/// </summary>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern string Api_GetCookies([Description("")] int AuthCode);
		 			/// <summary>
/// //取得QQ空间Token
/// </summary>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern string Api_GetQzoneToken([Description("")] int AuthCode);
		 			/// <summary>
/// //取得QQ空间Cookies
/// </summary>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern string Api_GetQzoneCookies([Description("")] int AuthCode);
		 			/// <summary>
/// //发表说说
/// </summary>
/// <param name="Str"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern string Api_SendTaotao([Description("")] string Str,[Description("")] int AuthCode);
		 			/// <summary>
/// //取得所登录的QQ
/// </summary>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern string Api_GetLoginQQ([Description("")] int AuthCode);
		 			/// <summary>
/// //框架为插件所创建的插件目录
/// </summary>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern string Api_GetPath([Description("")] int AuthCode);
		 			/// <summary>
/// //置插件错误管理
/// </summary>
/// <param name="Code"></param>
/// <param name="Str"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern string Api_Error([Description("")] string Code,[Description("")] string Str,[Description("")] int AuthCode);
		 			/// <summary>
/// //机器人发送消息，返回值为该条消息的ID
/// </summary>
/// <param name="Type">1.好友消息 2.群消息 3.群临时消息 4.讨论组消息 5.讨论组临时消息 6.QQ临时消息</param>
/// <param name="GroupID"></param>
/// <param name="QQID">类型为2，4时可留空</param>
/// <param name="Msg"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern string Api_SendMsg([Description("1.好友消息 2.群消息 3.群临时消息 4.讨论组消息 5.讨论组临时消息 6.QQ临时消息")] int Type,[Description("")] string GroupID,[Description("类型为2，4时可留空")] string QQID,[Description("")] string Msg,[Description("")] int AuthCode);
		 			/// <summary>
/// //处理加群消息
/// </summary>
/// <param name="GroupID"></param>
/// <param name="QQID"></param>
/// <param name="Seq"></param>
/// <param name="Type">1.同意 2.拒绝 3.忽略</param>
/// <param name="Reason">参数可为空，且为 拒绝 时有效</param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern void Api_SetGroupAdd([Description("")] string GroupID,[Description("")] string QQID,[Description("")] string Seq,[Description("1.同意 2.拒绝 3.忽略")] int Type,[Description("参数可为空，且为 拒绝 时有效")] string Reason,[Description("")] int AuthCode);
		 			/// <summary>
/// //处理加好友消息
/// </summary>
/// <param name="QQID"></param>
/// <param name="Type">1.同意 2.拒绝 3.忽略</param>
/// <param name="Reason">参数可为空，且为 拒绝 时有效</param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern void Api_SetFriendAdd([Description("")] string QQID,[Description("1.同意 2.拒绝 3.忽略")] int Type,[Description("参数可为空，且为 拒绝 时有效")] string Reason,[Description("")] int AuthCode);
		 			/// <summary>
/// //向框架推送一条日志
/// </summary>
/// <param name="Type">日志类型（自定义）</param>
/// <param name="Msg">日志内容</param>
/// <param name="FontColor">日志颜色</param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern void Api_SendLog([Description("日志类型（自定义）")] string Type,[Description("日志内容")] string Msg,[Description("日志颜色")] int FontColor,[Description("")] int AuthCode);
		 			/// <summary>
/// //修改好友备注
/// </summary>
/// <param name="QQID"></param>
/// <param name="Name"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern void Api_SetFriendName([Description("")] string QQID,[Description("")] string Name,[Description("")] int AuthCode);
		 			/// <summary>
/// //删除好友
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern void Api_DeleteFriend([Description("")] string QQID,[Description("")] int AuthCode);
		 			/// <summary>
/// //主动添加群
/// </summary>
/// <param name="GroupID"></param>
/// <param name="附加信息"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern void Api_AddGroup([Description("")] string GroupID,[Description("")] string 附加信息,[Description("")] int AuthCode);
		 			/// <summary>
/// //主动添加好友
/// </summary>
/// <param name="QQID"></param>
/// <param name="Info"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern void Api_AddFriend([Description("")] string QQID,[Description("")] string Info,[Description("")] int AuthCode);
		 			/// <summary>
/// //返回卡片点歌JSON代码
/// </summary>
/// <param name="SongID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern string Api_JsonMusic([Description("")] string SongID,[Description("")] int AuthCode);
		 			/// <summary>
/// //取得群内成员的名片
/// </summary>
/// <param name="GroupID"></param>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern string Api_GetGroupCard([Description("")] string GroupID,[Description("")] string QQID,[Description("")] int AuthCode);
		 			/// <summary>
/// //取指定QQ的昵称
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern string Api_GetNick([Description("")] string QQID,[Description("")] int AuthCode);
		 			/// <summary>
/// 
/// </summary>
/// <param name="GroupID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern string Api_GetGroupName([Description("")] string GroupID,[Description("")] int AuthCode);
		 			/// <summary>
/// 
/// </summary>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern string Api_GetSoftVersion([Description("")] int AuthCode);
		 			/// <summary>
/// 
/// </summary>
/// <param name="GroupID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern string Api_GetGroupIntroduce([Description("")] string GroupID,[Description("")] int AuthCode);
		 			/// <summary>
/// 
/// </summary>
/// <param name="GroupID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern string Api_GetGroupOwner([Description("")] string GroupID,[Description("")] int AuthCode);
		 			/// <summary>
/// //修改群成员的名片
/// </summary>
/// <param name="GroupID"></param>
/// <param name="QQID"></param>
/// <param name="NewCard"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern void Api_SetGroupCard([Description("")] string GroupID,[Description("")] string QQID,[Description("")] string NewCard,[Description("")] int AuthCode);
		 			/// <summary>
/// //取得某个QQ的名片赞数量
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern string Api_GetPraiseNum([Description("")] string QQID,[Description("")] int AuthCode);
		 			/// <summary>
/// //取得某个QQ的等级
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern int Api_GetQQLevel([Description("")] string QQID,[Description("")] int AuthCode);
		 			/// <summary>
/// 
/// </summary>
/// <param name="NewNick"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern void Api_SetNick([Description("")] string NewNick,[Description("")] int AuthCode);
		 			/// <summary>
/// 
/// </summary>
/// <param name="QQID"></param>
/// <param name="URL"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern string Api_Taotaodolike([Description("")] string QQID,[Description("")] string URL,[Description("")] int AuthCode);
		 			/// <summary>
/// 
/// </summary>
/// <param name="QQID"></param>
/// <param name="URL"></param>
/// <param name="Content"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern string Api_Taotaofeeds([Description("")] string QQID,[Description("")] string URL,[Description("")] string Content,[Description("")] int AuthCode);
		 			/// <summary>
/// 
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern int Api_GetQQAge([Description("")] string QQID,[Description("")] int AuthCode);
		 			/// <summary>
/// 
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern int Api_GetQQSex([Description("")] string QQID,[Description("")] int AuthCode);
		 			/// <summary>
/// //以JSON形式取得好友列表
/// </summary>
/// <param name="Cache"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern string Api_GetFriendList([Description("")] bool Cache,[Description("")] int AuthCode);
		 			/// <summary>
/// //以JSON形式取得群列表
/// </summary>
/// <param name="Cache"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern string Api_GetGroupList([Description("")] bool Cache,[Description("")] int AuthCode);
		 			/// <summary>
/// //以JSON形式取得群成员列表
/// </summary>
/// <param name="GroupID"></param>
/// <param name="Cache"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern string Api_GetGroupMemberList([Description("")] string GroupID,[Description("")] bool Cache,[Description("")] int AuthCode);
		 			/// <summary>
/// //以JSON形式取得某QQ个人信息
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern string Api_GetQQInfo([Description("")] string QQID,[Description("")] int AuthCode);
		 			/// <summary>
/// //以JSON形式取得某群信息
/// </summary>
/// <param name="GroupID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern string Api_GetGroupInfo([Description("")] string GroupID,[Description("")] int AuthCode);
		 			/// <summary>
/// //撤回自身消息 发出消息不可以秒撤回，腾讯限制，1~2s后才可撤回
/// </summary>
/// <param name="Type">1.好友消息 2.群消息 3.群临时消息 4.讨论组消息 5.讨论组临时消息 6.QQ临时消息</param>
/// <param name="GroupID">撤回群消息、群临时消息、讨论组消息、讨论组临时消息必须填写，其余情况可留空</param>
/// <param name="QQID">撤回好友消息、群临时消息、讨论组临时消息、QQ临时消息必须填写，其余情况可留空</param>
/// <param name="MsgID">撤回的消息ID，机器人发送消息会返回自身的消息ID</param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern void Api_DeleteMsg([Description("1.好友消息 2.群消息 3.群临时消息 4.讨论组消息 5.讨论组临时消息 6.QQ临时消息")] int Type,[Description("撤回群消息、群临时消息、讨论组消息、讨论组临时消息必须填写，其余情况可留空")] string GroupID,[Description("撤回好友消息、群临时消息、讨论组临时消息、QQ临时消息必须填写，其余情况可留空")] string QQID,[Description("撤回的消息ID，机器人发送消息会返回自身的消息ID")] string MsgID,[Description("")] int AuthCode);
		 			/// <summary>
/// //改变QQ在线状态
/// </summary>
/// <param name="Type">1.我在线上 2.Q我吧 3.离开 4.忙碌 5.请勿打扰 6.隐身</param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern void Api_SetQQState([Description("1.我在线上 2.Q我吧 3.离开 4.忙碌 5.请勿打扰 6.隐身")] int Type,[Description("")] int AuthCode);
		 			/// <summary>
/// //邀请好友入群
/// </summary>
/// <param name="GroupID"></param>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern void Api_InviteFriend([Description("")] string GroupID,[Description("")] string QQID,[Description("")] int AuthCode);
		 			/// <summary>
/// 
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern string Api_GetQQInfo_v2([Description("")] string QQID,[Description("")] int AuthCode);
		 			/// <summary>
/// //取消COM库
/// </summary>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern void CoUninitialize();
		 			/// <summary>
/// //初始化COM库
/// </summary>
/// <param name="pvReserved"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern void CoInitialize([Description("")] int pvReserved);
		 			/// <summary>
/// //上传图片，获得图片GUID，
/// </summary>
/// <param name="Type">1.私聊图片  2.群聊图片</param>
/// <param name="对象">私聊图片填写QQID，群聊/讨论组图片填写群号讨论组号</param>
/// <param name="Bin">图片的Hex流</param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern string Api_UpLoadPic([Description("1.私聊图片  2.群聊图片")] int Type,[Description("私聊图片填写QQID，群聊/讨论组图片填写群号讨论组号")] string 对象,[Description("图片的Hex流")] string Bin,[Description("")] int AuthCode);
		 			/// <summary>
/// //设置插件状态，开启或关闭
/// </summary>
/// <param name="State">真:启用自身  假:关闭自身</param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern string Api_SetPluginState([Description("真:启用自身  假:关闭自身")] bool State,[Description("")] int AuthCode);
		 			/// <summary>
/// 
/// </summary>
/// <param name="群号"></param>
/// <param name="文件GUID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern void Api_DeleteFile([Description("")] string 群号,[Description("")] string 文件GUID,[Description("")] int AuthCode);
		 			/// <summary>
/// 
/// </summary>
/// <param name="来源对象"></param>
/// <param name="转发群号"></param>
/// <param name="文件GUID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern void Api_RepeatFile([Description("")] string 来源对象,[Description("")] string 转发群号,[Description("")] string 文件GUID,[Description("")] int AuthCode);
		 			/// <summary>
/// 
/// </summary>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern void Api_ClearOffLineFile([Description("")] int AuthCode);
		 			/// <summary>
/// 
/// </summary>
/// <param name="CodePage"></param>
/// <param name="dwFlags"></param>
/// <param name="lpWideCharStr">址</param>
/// <param name="cchWideChar"></param>
/// <param name="lpMultiByteStr">址</param>
/// <param name="cchMultiByte"></param>
/// <param name="lpDefaultChar"></param>
/// <param name="lpUsedDefaultChar"></param>
/// <returns></returns>

		  [DllImport("bin/message.dll")]
          public static extern int WideCharToMultiByte([Description("")] int CodePage,[Description("")] int dwFlags,[Description("址")] byte[] lpWideCharStr,[Description("")] int cchWideChar,[Description("址")] string lpMultiByteStr,[Description("")] int cchMultiByte,[Description("")] int lpDefaultChar,[Description("")] int lpUsedDefaultChar);
		         }
}
