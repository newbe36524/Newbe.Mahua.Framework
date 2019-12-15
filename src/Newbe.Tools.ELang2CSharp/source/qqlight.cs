
public interface IQqLightApi{
/// <summary>
/// //给QQ点名片赞，PCQQ点赞不稳定，容易失效
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
void Api_SendPraise(string QQID,int AuthCode);
/// <summary>
/// //抖动好友窗口
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
void Api_SendShake(string QQID,int AuthCode);
/// <summary>
/// //取得网页操作时需要用到的bkn/Gtk
/// </summary>
/// <param name="Cookies"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
string Api_Getbkn(string Cookies,int AuthCode);
/// <summary>
/// //取得网页操作时需要用到的bkn/Gtk
/// </summary>
/// <param name="Cookies"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
string Api_Getbkn_Long(string Cookies,int AuthCode);
/// <summary>
/// //退出群
/// </summary>
/// <param name="GroupID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
void Api_QuitGroup(string GroupID,int AuthCode);
/// <summary>
/// //退出讨论组
/// </summary>
/// <param name="GroupID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
void Api_QuitDiscussGroup(string GroupID,int AuthCode);
/// <summary>
/// //修改个性签名
/// </summary>
/// <param name="Signature"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
void Api_SetSignature(string Signature,int AuthCode);
/// <summary>
/// //修改讨论组名称
/// </summary>
/// <param name="DiscussGroupID"></param>
/// <param name="Name"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
void Api_SetDiscussName(string DiscussGroupID,string Name,int AuthCode);
/// <summary>
/// //修改群名称
/// </summary>
/// <param name="GroupID"></param>
/// <param name="Name"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
void Api_SetGroupName(string GroupID,string Name,int AuthCode);
/// <summary>
/// //设置全群禁言
/// </summary>
/// <param name="GroupID"></param>
/// <param name="IsBanGroup">真 开启全群禁言 假 关闭全群禁言</param>
/// <param name="AuthCode"></param>
/// <returns></returns>
void Api_BanGroup(string GroupID,bool IsBanGroup,int AuthCode);
/// <summary>
/// //设置管理员权限
/// </summary>
/// <param name="GroupID"></param>
/// <param name="QQID"></param>
/// <param name="IsManager">真,设置  假,取消</param>
/// <param name="AuthCode"></param>
/// <returns></returns>
void Api_SetManager(string GroupID,string QQID,bool IsManager,int AuthCode);
/// <summary>
/// //禁言群成员
/// </summary>
/// <param name="GroupID"></param>
/// <param name="QQ"></param>
/// <param name="time">单位:秒  0为解除禁言</param>
/// <param name="AuthCode"></param>
/// <returns></returns>
void Api_Ban(string GroupID,string QQ,int time,int AuthCode);
/// <summary>
/// //修改匿名权限
/// </summary>
/// <param name="GroupID"></param>
/// <param name="IsSetAnony">真 允许匿名  假 禁止匿名</param>
/// <param name="AuthCode"></param>
/// <returns></returns>
void Api_SetAnony(string GroupID,bool IsSetAnony,int AuthCode);
/// <summary>
/// //踢出群成员
/// </summary>
/// <param name="GroupID"></param>
/// <param name="QQID"></param>
/// <param name="IsBan">不再接受此人加群</param>
/// <param name="AuthCode"></param>
/// <returns></returns>
void Api_RemoveMember(string GroupID,string QQID,bool IsBan,int AuthCode);
/// <summary>
/// //解散群
/// </summary>
/// <param name="GroupID">群号</param>
/// <param name="AuthCode"></param>
/// <returns></returns>
void Api_RemoveGroup(string GroupID,int AuthCode);
/// <summary>
/// //取得操作网页所需要的Cookies
/// </summary>
/// <param name="AuthCode"></param>
/// <returns></returns>
string Api_GetCookies(int AuthCode);
/// <summary>
/// //取得QQ空间Token
/// </summary>
/// <param name="AuthCode"></param>
/// <returns></returns>
string Api_GetQzoneToken(int AuthCode);
/// <summary>
/// //取得QQ空间Cookies
/// </summary>
/// <param name="AuthCode"></param>
/// <returns></returns>
string Api_GetQzoneCookies(int AuthCode);
/// <summary>
/// //发表说说
/// </summary>
/// <param name="Str"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
string Api_SendTaotao(string Str,int AuthCode);
/// <summary>
/// //取得所登录的QQ
/// </summary>
/// <param name="AuthCode"></param>
/// <returns></returns>
string Api_GetLoginQQ(int AuthCode);
/// <summary>
/// //框架为插件所创建的插件目录
/// </summary>
/// <param name="AuthCode"></param>
/// <returns></returns>
string Api_GetPath(int AuthCode);
/// <summary>
/// //置插件错误管理
/// </summary>
/// <param name="Code"></param>
/// <param name="Str"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
string Api_Error(string Code,string Str,int AuthCode);
/// <summary>
/// //机器人发送消息，返回值为该条消息的ID
/// </summary>
/// <param name="Type">1.好友消息 2.群消息 3.群临时消息 4.讨论组消息 5.讨论组临时消息 6.QQ临时消息</param>
/// <param name="GroupID"></param>
/// <param name="QQID">类型为2，4时可留空</param>
/// <param name="Msg"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
string Api_SendMsg(int Type,string GroupID,string QQID,string Msg,int AuthCode);
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
void Api_SetGroupAdd(string GroupID,string QQID,string Seq,int Type,string Reason,int AuthCode);
/// <summary>
/// //处理加好友消息
/// </summary>
/// <param name="QQID"></param>
/// <param name="Type">1.同意 2.拒绝 3.忽略</param>
/// <param name="Reason">参数可为空，且为 拒绝 时有效</param>
/// <param name="AuthCode"></param>
/// <returns></returns>
void Api_SetFriendAdd(string QQID,int Type,string Reason,int AuthCode);
/// <summary>
/// //向框架推送一条日志
/// </summary>
/// <param name="Type">日志类型（自定义）</param>
/// <param name="Msg">日志内容</param>
/// <param name="FontColor">日志颜色</param>
/// <param name="AuthCode"></param>
/// <returns></returns>
void Api_SendLog(string Type,string Msg,int FontColor,int AuthCode);
/// <summary>
/// //修改好友备注
/// </summary>
/// <param name="QQID"></param>
/// <param name="Name"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
void Api_SetFriendName(string QQID,string Name,int AuthCode);
/// <summary>
/// //删除好友
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
void Api_DeleteFriend(string QQID,int AuthCode);
/// <summary>
/// //主动添加群
/// </summary>
/// <param name="GroupID"></param>
/// <param name="附加信息"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
void Api_AddGroup(string GroupID,string 附加信息,int AuthCode);
/// <summary>
/// //主动添加好友
/// </summary>
/// <param name="QQID"></param>
/// <param name="Info"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
void Api_AddFriend(string QQID,string Info,int AuthCode);
/// <summary>
/// //返回卡片点歌JSON代码
/// </summary>
/// <param name="SongID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
string Api_JsonMusic(string SongID,int AuthCode);
/// <summary>
/// //取得群内成员的名片
/// </summary>
/// <param name="GroupID"></param>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
string Api_GetGroupCard(string GroupID,string QQID,int AuthCode);
/// <summary>
/// //取指定QQ的昵称
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
string Api_GetNick(string QQID,int AuthCode);
/// <summary>
/// 
/// </summary>
/// <param name="GroupID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
string Api_GetGroupName(string GroupID,int AuthCode);
/// <summary>
/// 
/// </summary>
/// <param name="AuthCode"></param>
/// <returns></returns>
string Api_GetSoftVersion(int AuthCode);
/// <summary>
/// 
/// </summary>
/// <param name="GroupID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
string Api_GetGroupIntroduce(string GroupID,int AuthCode);
/// <summary>
/// 
/// </summary>
/// <param name="GroupID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
string Api_GetGroupOwner(string GroupID,int AuthCode);
/// <summary>
/// //修改群成员的名片
/// </summary>
/// <param name="GroupID"></param>
/// <param name="QQID"></param>
/// <param name="NewCard"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
void Api_SetGroupCard(string GroupID,string QQID,string NewCard,int AuthCode);
/// <summary>
/// //取得某个QQ的名片赞数量
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
string Api_GetPraiseNum(string QQID,int AuthCode);
/// <summary>
/// //取得某个QQ的等级
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
int Api_GetQQLevel(string QQID,int AuthCode);
/// <summary>
/// 
/// </summary>
/// <param name="NewNick"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
void Api_SetNick(string NewNick,int AuthCode);
/// <summary>
/// 
/// </summary>
/// <param name="QQID"></param>
/// <param name="URL"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
string Api_Taotaodolike(string QQID,string URL,int AuthCode);
/// <summary>
/// 
/// </summary>
/// <param name="QQID"></param>
/// <param name="URL"></param>
/// <param name="Content"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
string Api_Taotaofeeds(string QQID,string URL,string Content,int AuthCode);
/// <summary>
/// 
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
int Api_GetQQAge(string QQID,int AuthCode);
/// <summary>
/// 
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
int Api_GetQQSex(string QQID,int AuthCode);
/// <summary>
/// //以JSON形式取得好友列表
/// </summary>
/// <param name="Cache"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
string Api_GetFriendList(bool Cache,int AuthCode);
/// <summary>
/// //以JSON形式取得群列表
/// </summary>
/// <param name="Cache"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
string Api_GetGroupList(bool Cache,int AuthCode);
/// <summary>
/// //以JSON形式取得群成员列表
/// </summary>
/// <param name="GroupID"></param>
/// <param name="Cache"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
string Api_GetGroupMemberList(string GroupID,bool Cache,int AuthCode);
/// <summary>
/// //以JSON形式取得某QQ个人信息
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
string Api_GetQQInfo(string QQID,int AuthCode);
/// <summary>
/// //以JSON形式取得某群信息
/// </summary>
/// <param name="GroupID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
string Api_GetGroupInfo(string GroupID,int AuthCode);
/// <summary>
/// //撤回自身消息 发出消息不可以秒撤回，腾讯限制，1~2s后才可撤回
/// </summary>
/// <param name="Type">1.好友消息 2.群消息 3.群临时消息 4.讨论组消息 5.讨论组临时消息 6.QQ临时消息</param>
/// <param name="GroupID">撤回群消息、群临时消息、讨论组消息、讨论组临时消息必须填写，其余情况可留空</param>
/// <param name="QQID">撤回好友消息、群临时消息、讨论组临时消息、QQ临时消息必须填写，其余情况可留空</param>
/// <param name="MsgID">撤回的消息ID，机器人发送消息会返回自身的消息ID</param>
/// <param name="AuthCode"></param>
/// <returns></returns>
void Api_DeleteMsg(int Type,string GroupID,string QQID,string MsgID,int AuthCode);
/// <summary>
/// //改变QQ在线状态
/// </summary>
/// <param name="Type">1.我在线上 2.Q我吧 3.离开 4.忙碌 5.请勿打扰 6.隐身</param>
/// <param name="AuthCode"></param>
/// <returns></returns>
void Api_SetQQState(int Type,int AuthCode);
/// <summary>
/// //邀请好友入群
/// </summary>
/// <param name="GroupID"></param>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
void Api_InviteFriend(string GroupID,string QQID,int AuthCode);
/// <summary>
/// 
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
string Api_GetQQInfo_v2(string QQID,int AuthCode);
/// <summary>
/// //取消COM库
/// </summary>
/// <returns></returns>
void CoUninitialize();
/// <summary>
/// //初始化COM库
/// </summary>
/// <param name="pvReserved"></param>
/// <returns></returns>
void CoInitialize(int pvReserved);
/// <summary>
/// //上传图片，获得图片GUID，
/// </summary>
/// <param name="Type">1.私聊图片  2.群聊图片</param>
/// <param name="对象">私聊图片填写QQID，群聊/讨论组图片填写群号讨论组号</param>
/// <param name="Bin">图片的Hex流</param>
/// <param name="AuthCode"></param>
/// <returns></returns>
string Api_UpLoadPic(int Type,string 对象,string Bin,int AuthCode);
/// <summary>
/// //设置插件状态，开启或关闭
/// </summary>
/// <param name="State">真:启用自身  假:关闭自身</param>
/// <param name="AuthCode"></param>
/// <returns></returns>
string Api_SetPluginState(bool State,int AuthCode);
/// <summary>
/// 
/// </summary>
/// <param name="群号"></param>
/// <param name="文件GUID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
void Api_DeleteFile(string 群号,string 文件GUID,int AuthCode);
/// <summary>
/// 
/// </summary>
/// <param name="来源对象"></param>
/// <param name="转发群号"></param>
/// <param name="文件GUID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>
void Api_RepeatFile(string 来源对象,string 转发群号,string 文件GUID,int AuthCode);
/// <summary>
/// 
/// </summary>
/// <param name="AuthCode"></param>
/// <returns></returns>
void Api_ClearOffLineFile(int AuthCode);
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
int WideCharToMultiByte(int CodePage,int dwFlags,byte[] lpWideCharStr,int cchWideChar,string lpMultiByteStr,int cchMultiByte,int lpDefaultChar,int lpUsedDefaultChar);
}
public class QqLightApi:IQqLightApi{

 		/// <summary>
/// //给QQ点名片赞，PCQQ点赞不稳定，容易失效
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQqLightApi.Api_SendPraise(string QQID,int AuthCode)
		 =>NativeMethods.Api_SendPraise(QQID,AuthCode);
		 		/// <summary>
/// //抖动好友窗口
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQqLightApi.Api_SendShake(string QQID,int AuthCode)
		 =>NativeMethods.Api_SendShake(QQID,AuthCode);
		 		/// <summary>
/// //取得网页操作时需要用到的bkn/Gtk
/// </summary>
/// <param name="Cookies"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQqLightApi.Api_Getbkn(string Cookies,int AuthCode)
		 =>NativeMethods.Api_Getbkn(Cookies,AuthCode);
		 		/// <summary>
/// //取得网页操作时需要用到的bkn/Gtk
/// </summary>
/// <param name="Cookies"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQqLightApi.Api_Getbkn_Long(string Cookies,int AuthCode)
		 =>NativeMethods.Api_Getbkn_Long(Cookies,AuthCode);
		 		/// <summary>
/// //退出群
/// </summary>
/// <param name="GroupID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQqLightApi.Api_QuitGroup(string GroupID,int AuthCode)
		 =>NativeMethods.Api_QuitGroup(GroupID,AuthCode);
		 		/// <summary>
/// //退出讨论组
/// </summary>
/// <param name="GroupID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQqLightApi.Api_QuitDiscussGroup(string GroupID,int AuthCode)
		 =>NativeMethods.Api_QuitDiscussGroup(GroupID,AuthCode);
		 		/// <summary>
/// //修改个性签名
/// </summary>
/// <param name="Signature"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQqLightApi.Api_SetSignature(string Signature,int AuthCode)
		 =>NativeMethods.Api_SetSignature(Signature,AuthCode);
		 		/// <summary>
/// //修改讨论组名称
/// </summary>
/// <param name="DiscussGroupID"></param>
/// <param name="Name"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQqLightApi.Api_SetDiscussName(string DiscussGroupID,string Name,int AuthCode)
		 =>NativeMethods.Api_SetDiscussName(DiscussGroupID,Name,AuthCode);
		 		/// <summary>
/// //修改群名称
/// </summary>
/// <param name="GroupID"></param>
/// <param name="Name"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQqLightApi.Api_SetGroupName(string GroupID,string Name,int AuthCode)
		 =>NativeMethods.Api_SetGroupName(GroupID,Name,AuthCode);
		 		/// <summary>
/// //设置全群禁言
/// </summary>
/// <param name="GroupID"></param>
/// <param name="IsBanGroup">真 开启全群禁言 假 关闭全群禁言</param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQqLightApi.Api_BanGroup(string GroupID,bool IsBanGroup,int AuthCode)
		 =>NativeMethods.Api_BanGroup(GroupID,IsBanGroup,AuthCode);
		 		/// <summary>
/// //设置管理员权限
/// </summary>
/// <param name="GroupID"></param>
/// <param name="QQID"></param>
/// <param name="IsManager">真,设置  假,取消</param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQqLightApi.Api_SetManager(string GroupID,string QQID,bool IsManager,int AuthCode)
		 =>NativeMethods.Api_SetManager(GroupID,QQID,IsManager,AuthCode);
		 		/// <summary>
/// //禁言群成员
/// </summary>
/// <param name="GroupID"></param>
/// <param name="QQ"></param>
/// <param name="time">单位:秒  0为解除禁言</param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQqLightApi.Api_Ban(string GroupID,string QQ,int time,int AuthCode)
		 =>NativeMethods.Api_Ban(GroupID,QQ,time,AuthCode);
		 		/// <summary>
/// //修改匿名权限
/// </summary>
/// <param name="GroupID"></param>
/// <param name="IsSetAnony">真 允许匿名  假 禁止匿名</param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQqLightApi.Api_SetAnony(string GroupID,bool IsSetAnony,int AuthCode)
		 =>NativeMethods.Api_SetAnony(GroupID,IsSetAnony,AuthCode);
		 		/// <summary>
/// //踢出群成员
/// </summary>
/// <param name="GroupID"></param>
/// <param name="QQID"></param>
/// <param name="IsBan">不再接受此人加群</param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQqLightApi.Api_RemoveMember(string GroupID,string QQID,bool IsBan,int AuthCode)
		 =>NativeMethods.Api_RemoveMember(GroupID,QQID,IsBan,AuthCode);
		 		/// <summary>
/// //解散群
/// </summary>
/// <param name="GroupID">群号</param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQqLightApi.Api_RemoveGroup(string GroupID,int AuthCode)
		 =>NativeMethods.Api_RemoveGroup(GroupID,AuthCode);
		 		/// <summary>
/// //取得操作网页所需要的Cookies
/// </summary>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQqLightApi.Api_GetCookies(int AuthCode)
		 =>NativeMethods.Api_GetCookies(AuthCode);
		 		/// <summary>
/// //取得QQ空间Token
/// </summary>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQqLightApi.Api_GetQzoneToken(int AuthCode)
		 =>NativeMethods.Api_GetQzoneToken(AuthCode);
		 		/// <summary>
/// //取得QQ空间Cookies
/// </summary>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQqLightApi.Api_GetQzoneCookies(int AuthCode)
		 =>NativeMethods.Api_GetQzoneCookies(AuthCode);
		 		/// <summary>
/// //发表说说
/// </summary>
/// <param name="Str"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQqLightApi.Api_SendTaotao(string Str,int AuthCode)
		 =>NativeMethods.Api_SendTaotao(Str,AuthCode);
		 		/// <summary>
/// //取得所登录的QQ
/// </summary>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQqLightApi.Api_GetLoginQQ(int AuthCode)
		 =>NativeMethods.Api_GetLoginQQ(AuthCode);
		 		/// <summary>
/// //框架为插件所创建的插件目录
/// </summary>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQqLightApi.Api_GetPath(int AuthCode)
		 =>NativeMethods.Api_GetPath(AuthCode);
		 		/// <summary>
/// //置插件错误管理
/// </summary>
/// <param name="Code"></param>
/// <param name="Str"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQqLightApi.Api_Error(string Code,string Str,int AuthCode)
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


         string  IQqLightApi.Api_SendMsg(int Type,string GroupID,string QQID,string Msg,int AuthCode)
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


         void  IQqLightApi.Api_SetGroupAdd(string GroupID,string QQID,string Seq,int Type,string Reason,int AuthCode)
		 =>NativeMethods.Api_SetGroupAdd(GroupID,QQID,Seq,Type,Reason,AuthCode);
		 		/// <summary>
/// //处理加好友消息
/// </summary>
/// <param name="QQID"></param>
/// <param name="Type">1.同意 2.拒绝 3.忽略</param>
/// <param name="Reason">参数可为空，且为 拒绝 时有效</param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQqLightApi.Api_SetFriendAdd(string QQID,int Type,string Reason,int AuthCode)
		 =>NativeMethods.Api_SetFriendAdd(QQID,Type,Reason,AuthCode);
		 		/// <summary>
/// //向框架推送一条日志
/// </summary>
/// <param name="Type">日志类型（自定义）</param>
/// <param name="Msg">日志内容</param>
/// <param name="FontColor">日志颜色</param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQqLightApi.Api_SendLog(string Type,string Msg,int FontColor,int AuthCode)
		 =>NativeMethods.Api_SendLog(Type,Msg,FontColor,AuthCode);
		 		/// <summary>
/// //修改好友备注
/// </summary>
/// <param name="QQID"></param>
/// <param name="Name"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQqLightApi.Api_SetFriendName(string QQID,string Name,int AuthCode)
		 =>NativeMethods.Api_SetFriendName(QQID,Name,AuthCode);
		 		/// <summary>
/// //删除好友
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQqLightApi.Api_DeleteFriend(string QQID,int AuthCode)
		 =>NativeMethods.Api_DeleteFriend(QQID,AuthCode);
		 		/// <summary>
/// //主动添加群
/// </summary>
/// <param name="GroupID"></param>
/// <param name="附加信息"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQqLightApi.Api_AddGroup(string GroupID,string 附加信息,int AuthCode)
		 =>NativeMethods.Api_AddGroup(GroupID,附加信息,AuthCode);
		 		/// <summary>
/// //主动添加好友
/// </summary>
/// <param name="QQID"></param>
/// <param name="Info"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQqLightApi.Api_AddFriend(string QQID,string Info,int AuthCode)
		 =>NativeMethods.Api_AddFriend(QQID,Info,AuthCode);
		 		/// <summary>
/// //返回卡片点歌JSON代码
/// </summary>
/// <param name="SongID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQqLightApi.Api_JsonMusic(string SongID,int AuthCode)
		 =>NativeMethods.Api_JsonMusic(SongID,AuthCode);
		 		/// <summary>
/// //取得群内成员的名片
/// </summary>
/// <param name="GroupID"></param>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQqLightApi.Api_GetGroupCard(string GroupID,string QQID,int AuthCode)
		 =>NativeMethods.Api_GetGroupCard(GroupID,QQID,AuthCode);
		 		/// <summary>
/// //取指定QQ的昵称
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQqLightApi.Api_GetNick(string QQID,int AuthCode)
		 =>NativeMethods.Api_GetNick(QQID,AuthCode);
		 		/// <summary>
/// 
/// </summary>
/// <param name="GroupID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQqLightApi.Api_GetGroupName(string GroupID,int AuthCode)
		 =>NativeMethods.Api_GetGroupName(GroupID,AuthCode);
		 		/// <summary>
/// 
/// </summary>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQqLightApi.Api_GetSoftVersion(int AuthCode)
		 =>NativeMethods.Api_GetSoftVersion(AuthCode);
		 		/// <summary>
/// 
/// </summary>
/// <param name="GroupID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQqLightApi.Api_GetGroupIntroduce(string GroupID,int AuthCode)
		 =>NativeMethods.Api_GetGroupIntroduce(GroupID,AuthCode);
		 		/// <summary>
/// 
/// </summary>
/// <param name="GroupID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQqLightApi.Api_GetGroupOwner(string GroupID,int AuthCode)
		 =>NativeMethods.Api_GetGroupOwner(GroupID,AuthCode);
		 		/// <summary>
/// //修改群成员的名片
/// </summary>
/// <param name="GroupID"></param>
/// <param name="QQID"></param>
/// <param name="NewCard"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQqLightApi.Api_SetGroupCard(string GroupID,string QQID,string NewCard,int AuthCode)
		 =>NativeMethods.Api_SetGroupCard(GroupID,QQID,NewCard,AuthCode);
		 		/// <summary>
/// //取得某个QQ的名片赞数量
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQqLightApi.Api_GetPraiseNum(string QQID,int AuthCode)
		 =>NativeMethods.Api_GetPraiseNum(QQID,AuthCode);
		 		/// <summary>
/// //取得某个QQ的等级
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         int  IQqLightApi.Api_GetQQLevel(string QQID,int AuthCode)
		 =>NativeMethods.Api_GetQQLevel(QQID,AuthCode);
		 		/// <summary>
/// 
/// </summary>
/// <param name="NewNick"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQqLightApi.Api_SetNick(string NewNick,int AuthCode)
		 =>NativeMethods.Api_SetNick(NewNick,AuthCode);
		 		/// <summary>
/// 
/// </summary>
/// <param name="QQID"></param>
/// <param name="URL"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQqLightApi.Api_Taotaodolike(string QQID,string URL,int AuthCode)
		 =>NativeMethods.Api_Taotaodolike(QQID,URL,AuthCode);
		 		/// <summary>
/// 
/// </summary>
/// <param name="QQID"></param>
/// <param name="URL"></param>
/// <param name="Content"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQqLightApi.Api_Taotaofeeds(string QQID,string URL,string Content,int AuthCode)
		 =>NativeMethods.Api_Taotaofeeds(QQID,URL,Content,AuthCode);
		 		/// <summary>
/// 
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         int  IQqLightApi.Api_GetQQAge(string QQID,int AuthCode)
		 =>NativeMethods.Api_GetQQAge(QQID,AuthCode);
		 		/// <summary>
/// 
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         int  IQqLightApi.Api_GetQQSex(string QQID,int AuthCode)
		 =>NativeMethods.Api_GetQQSex(QQID,AuthCode);
		 		/// <summary>
/// //以JSON形式取得好友列表
/// </summary>
/// <param name="Cache"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQqLightApi.Api_GetFriendList(bool Cache,int AuthCode)
		 =>NativeMethods.Api_GetFriendList(Cache,AuthCode);
		 		/// <summary>
/// //以JSON形式取得群列表
/// </summary>
/// <param name="Cache"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQqLightApi.Api_GetGroupList(bool Cache,int AuthCode)
		 =>NativeMethods.Api_GetGroupList(Cache,AuthCode);
		 		/// <summary>
/// //以JSON形式取得群成员列表
/// </summary>
/// <param name="GroupID"></param>
/// <param name="Cache"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQqLightApi.Api_GetGroupMemberList(string GroupID,bool Cache,int AuthCode)
		 =>NativeMethods.Api_GetGroupMemberList(GroupID,Cache,AuthCode);
		 		/// <summary>
/// //以JSON形式取得某QQ个人信息
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQqLightApi.Api_GetQQInfo(string QQID,int AuthCode)
		 =>NativeMethods.Api_GetQQInfo(QQID,AuthCode);
		 		/// <summary>
/// //以JSON形式取得某群信息
/// </summary>
/// <param name="GroupID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQqLightApi.Api_GetGroupInfo(string GroupID,int AuthCode)
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


         void  IQqLightApi.Api_DeleteMsg(int Type,string GroupID,string QQID,string MsgID,int AuthCode)
		 =>NativeMethods.Api_DeleteMsg(Type,GroupID,QQID,MsgID,AuthCode);
		 		/// <summary>
/// //改变QQ在线状态
/// </summary>
/// <param name="Type">1.我在线上 2.Q我吧 3.离开 4.忙碌 5.请勿打扰 6.隐身</param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQqLightApi.Api_SetQQState(int Type,int AuthCode)
		 =>NativeMethods.Api_SetQQState(Type,AuthCode);
		 		/// <summary>
/// //邀请好友入群
/// </summary>
/// <param name="GroupID"></param>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQqLightApi.Api_InviteFriend(string GroupID,string QQID,int AuthCode)
		 =>NativeMethods.Api_InviteFriend(GroupID,QQID,AuthCode);
		 		/// <summary>
/// 
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQqLightApi.Api_GetQQInfo_v2(string QQID,int AuthCode)
		 =>NativeMethods.Api_GetQQInfo_v2(QQID,AuthCode);
		 		/// <summary>
/// //取消COM库
/// </summary>
/// <returns></returns>


         void  IQqLightApi.CoUninitialize()
		 =>NativeMethods.CoUninitialize();
		 		/// <summary>
/// //初始化COM库
/// </summary>
/// <param name="pvReserved"></param>
/// <returns></returns>


         void  IQqLightApi.CoInitialize(int pvReserved)
		 =>NativeMethods.CoInitialize(pvReserved);
		 		/// <summary>
/// //上传图片，获得图片GUID，
/// </summary>
/// <param name="Type">1.私聊图片  2.群聊图片</param>
/// <param name="对象">私聊图片填写QQID，群聊/讨论组图片填写群号讨论组号</param>
/// <param name="Bin">图片的Hex流</param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQqLightApi.Api_UpLoadPic(int Type,string 对象,string Bin,int AuthCode)
		 =>NativeMethods.Api_UpLoadPic(Type,对象,Bin,AuthCode);
		 		/// <summary>
/// //设置插件状态，开启或关闭
/// </summary>
/// <param name="State">真:启用自身  假:关闭自身</param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         string  IQqLightApi.Api_SetPluginState(bool State,int AuthCode)
		 =>NativeMethods.Api_SetPluginState(State,AuthCode);
		 		/// <summary>
/// 
/// </summary>
/// <param name="群号"></param>
/// <param name="文件GUID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQqLightApi.Api_DeleteFile(string 群号,string 文件GUID,int AuthCode)
		 =>NativeMethods.Api_DeleteFile(群号,文件GUID,AuthCode);
		 		/// <summary>
/// 
/// </summary>
/// <param name="来源对象"></param>
/// <param name="转发群号"></param>
/// <param name="文件GUID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQqLightApi.Api_RepeatFile(string 来源对象,string 转发群号,string 文件GUID,int AuthCode)
		 =>NativeMethods.Api_RepeatFile(来源对象,转发群号,文件GUID,AuthCode);
		 		/// <summary>
/// 
/// </summary>
/// <param name="AuthCode"></param>
/// <returns></returns>


         void  IQqLightApi.Api_ClearOffLineFile(int AuthCode)
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


         int  IQqLightApi.WideCharToMultiByte(int CodePage,int dwFlags,byte[] lpWideCharStr,int cchWideChar,string lpMultiByteStr,int cchMultiByte,int lpDefaultChar,int lpUsedDefaultChar)
		 =>NativeMethods.WideCharToMultiByte(CodePage,dwFlags,lpWideCharStr,cchWideChar,lpMultiByteStr,cchMultiByte,lpDefaultChar,lpUsedDefaultChar);
		 private static class NativeMethods
        {
        			/// <summary>
/// //给QQ点名片赞，PCQQ点赞不稳定，容易失效
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern void Api_SendPraise(string QQID,int AuthCode);
		 			/// <summary>
/// //抖动好友窗口
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern void Api_SendShake(string QQID,int AuthCode);
		 			/// <summary>
/// //取得网页操作时需要用到的bkn/Gtk
/// </summary>
/// <param name="Cookies"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern string Api_Getbkn(string Cookies,int AuthCode);
		 			/// <summary>
/// //取得网页操作时需要用到的bkn/Gtk
/// </summary>
/// <param name="Cookies"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern string Api_Getbkn_Long(string Cookies,int AuthCode);
		 			/// <summary>
/// //退出群
/// </summary>
/// <param name="GroupID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern void Api_QuitGroup(string GroupID,int AuthCode);
		 			/// <summary>
/// //退出讨论组
/// </summary>
/// <param name="GroupID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern void Api_QuitDiscussGroup(string GroupID,int AuthCode);
		 			/// <summary>
/// //修改个性签名
/// </summary>
/// <param name="Signature"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern void Api_SetSignature(string Signature,int AuthCode);
		 			/// <summary>
/// //修改讨论组名称
/// </summary>
/// <param name="DiscussGroupID"></param>
/// <param name="Name"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern void Api_SetDiscussName(string DiscussGroupID,string Name,int AuthCode);
		 			/// <summary>
/// //修改群名称
/// </summary>
/// <param name="GroupID"></param>
/// <param name="Name"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern void Api_SetGroupName(string GroupID,string Name,int AuthCode);
		 			/// <summary>
/// //设置全群禁言
/// </summary>
/// <param name="GroupID"></param>
/// <param name="IsBanGroup">真 开启全群禁言 假 关闭全群禁言</param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern void Api_BanGroup(string GroupID,bool IsBanGroup,int AuthCode);
		 			/// <summary>
/// //设置管理员权限
/// </summary>
/// <param name="GroupID"></param>
/// <param name="QQID"></param>
/// <param name="IsManager">真,设置  假,取消</param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern void Api_SetManager(string GroupID,string QQID,bool IsManager,int AuthCode);
		 			/// <summary>
/// //禁言群成员
/// </summary>
/// <param name="GroupID"></param>
/// <param name="QQ"></param>
/// <param name="time">单位:秒  0为解除禁言</param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern void Api_Ban(string GroupID,string QQ,int time,int AuthCode);
		 			/// <summary>
/// //修改匿名权限
/// </summary>
/// <param name="GroupID"></param>
/// <param name="IsSetAnony">真 允许匿名  假 禁止匿名</param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern void Api_SetAnony(string GroupID,bool IsSetAnony,int AuthCode);
		 			/// <summary>
/// //踢出群成员
/// </summary>
/// <param name="GroupID"></param>
/// <param name="QQID"></param>
/// <param name="IsBan">不再接受此人加群</param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern void Api_RemoveMember(string GroupID,string QQID,bool IsBan,int AuthCode);
		 			/// <summary>
/// //解散群
/// </summary>
/// <param name="GroupID">群号</param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern void Api_RemoveGroup(string GroupID,int AuthCode);
		 			/// <summary>
/// //取得操作网页所需要的Cookies
/// </summary>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern string Api_GetCookies(int AuthCode);
		 			/// <summary>
/// //取得QQ空间Token
/// </summary>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern string Api_GetQzoneToken(int AuthCode);
		 			/// <summary>
/// //取得QQ空间Cookies
/// </summary>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern string Api_GetQzoneCookies(int AuthCode);
		 			/// <summary>
/// //发表说说
/// </summary>
/// <param name="Str"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern string Api_SendTaotao(string Str,int AuthCode);
		 			/// <summary>
/// //取得所登录的QQ
/// </summary>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern string Api_GetLoginQQ(int AuthCode);
		 			/// <summary>
/// //框架为插件所创建的插件目录
/// </summary>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern string Api_GetPath(int AuthCode);
		 			/// <summary>
/// //置插件错误管理
/// </summary>
/// <param name="Code"></param>
/// <param name="Str"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern string Api_Error(string Code,string Str,int AuthCode);
		 			/// <summary>
/// //机器人发送消息，返回值为该条消息的ID
/// </summary>
/// <param name="Type">1.好友消息 2.群消息 3.群临时消息 4.讨论组消息 5.讨论组临时消息 6.QQ临时消息</param>
/// <param name="GroupID"></param>
/// <param name="QQID">类型为2，4时可留空</param>
/// <param name="Msg"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern string Api_SendMsg(int Type,string GroupID,string QQID,string Msg,int AuthCode);
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

		  [DllImport("message.dll")]
          public static extern void Api_SetGroupAdd(string GroupID,string QQID,string Seq,int Type,string Reason,int AuthCode);
		 			/// <summary>
/// //处理加好友消息
/// </summary>
/// <param name="QQID"></param>
/// <param name="Type">1.同意 2.拒绝 3.忽略</param>
/// <param name="Reason">参数可为空，且为 拒绝 时有效</param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern void Api_SetFriendAdd(string QQID,int Type,string Reason,int AuthCode);
		 			/// <summary>
/// //向框架推送一条日志
/// </summary>
/// <param name="Type">日志类型（自定义）</param>
/// <param name="Msg">日志内容</param>
/// <param name="FontColor">日志颜色</param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern void Api_SendLog(string Type,string Msg,int FontColor,int AuthCode);
		 			/// <summary>
/// //修改好友备注
/// </summary>
/// <param name="QQID"></param>
/// <param name="Name"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern void Api_SetFriendName(string QQID,string Name,int AuthCode);
		 			/// <summary>
/// //删除好友
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern void Api_DeleteFriend(string QQID,int AuthCode);
		 			/// <summary>
/// //主动添加群
/// </summary>
/// <param name="GroupID"></param>
/// <param name="附加信息"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern void Api_AddGroup(string GroupID,string 附加信息,int AuthCode);
		 			/// <summary>
/// //主动添加好友
/// </summary>
/// <param name="QQID"></param>
/// <param name="Info"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern void Api_AddFriend(string QQID,string Info,int AuthCode);
		 			/// <summary>
/// //返回卡片点歌JSON代码
/// </summary>
/// <param name="SongID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern string Api_JsonMusic(string SongID,int AuthCode);
		 			/// <summary>
/// //取得群内成员的名片
/// </summary>
/// <param name="GroupID"></param>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern string Api_GetGroupCard(string GroupID,string QQID,int AuthCode);
		 			/// <summary>
/// //取指定QQ的昵称
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern string Api_GetNick(string QQID,int AuthCode);
		 			/// <summary>
/// 
/// </summary>
/// <param name="GroupID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern string Api_GetGroupName(string GroupID,int AuthCode);
		 			/// <summary>
/// 
/// </summary>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern string Api_GetSoftVersion(int AuthCode);
		 			/// <summary>
/// 
/// </summary>
/// <param name="GroupID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern string Api_GetGroupIntroduce(string GroupID,int AuthCode);
		 			/// <summary>
/// 
/// </summary>
/// <param name="GroupID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern string Api_GetGroupOwner(string GroupID,int AuthCode);
		 			/// <summary>
/// //修改群成员的名片
/// </summary>
/// <param name="GroupID"></param>
/// <param name="QQID"></param>
/// <param name="NewCard"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern void Api_SetGroupCard(string GroupID,string QQID,string NewCard,int AuthCode);
		 			/// <summary>
/// //取得某个QQ的名片赞数量
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern string Api_GetPraiseNum(string QQID,int AuthCode);
		 			/// <summary>
/// //取得某个QQ的等级
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern int Api_GetQQLevel(string QQID,int AuthCode);
		 			/// <summary>
/// 
/// </summary>
/// <param name="NewNick"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern void Api_SetNick(string NewNick,int AuthCode);
		 			/// <summary>
/// 
/// </summary>
/// <param name="QQID"></param>
/// <param name="URL"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern string Api_Taotaodolike(string QQID,string URL,int AuthCode);
		 			/// <summary>
/// 
/// </summary>
/// <param name="QQID"></param>
/// <param name="URL"></param>
/// <param name="Content"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern string Api_Taotaofeeds(string QQID,string URL,string Content,int AuthCode);
		 			/// <summary>
/// 
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern int Api_GetQQAge(string QQID,int AuthCode);
		 			/// <summary>
/// 
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern int Api_GetQQSex(string QQID,int AuthCode);
		 			/// <summary>
/// //以JSON形式取得好友列表
/// </summary>
/// <param name="Cache"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern string Api_GetFriendList(bool Cache,int AuthCode);
		 			/// <summary>
/// //以JSON形式取得群列表
/// </summary>
/// <param name="Cache"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern string Api_GetGroupList(bool Cache,int AuthCode);
		 			/// <summary>
/// //以JSON形式取得群成员列表
/// </summary>
/// <param name="GroupID"></param>
/// <param name="Cache"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern string Api_GetGroupMemberList(string GroupID,bool Cache,int AuthCode);
		 			/// <summary>
/// //以JSON形式取得某QQ个人信息
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern string Api_GetQQInfo(string QQID,int AuthCode);
		 			/// <summary>
/// //以JSON形式取得某群信息
/// </summary>
/// <param name="GroupID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern string Api_GetGroupInfo(string GroupID,int AuthCode);
		 			/// <summary>
/// //撤回自身消息 发出消息不可以秒撤回，腾讯限制，1~2s后才可撤回
/// </summary>
/// <param name="Type">1.好友消息 2.群消息 3.群临时消息 4.讨论组消息 5.讨论组临时消息 6.QQ临时消息</param>
/// <param name="GroupID">撤回群消息、群临时消息、讨论组消息、讨论组临时消息必须填写，其余情况可留空</param>
/// <param name="QQID">撤回好友消息、群临时消息、讨论组临时消息、QQ临时消息必须填写，其余情况可留空</param>
/// <param name="MsgID">撤回的消息ID，机器人发送消息会返回自身的消息ID</param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern void Api_DeleteMsg(int Type,string GroupID,string QQID,string MsgID,int AuthCode);
		 			/// <summary>
/// //改变QQ在线状态
/// </summary>
/// <param name="Type">1.我在线上 2.Q我吧 3.离开 4.忙碌 5.请勿打扰 6.隐身</param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern void Api_SetQQState(int Type,int AuthCode);
		 			/// <summary>
/// //邀请好友入群
/// </summary>
/// <param name="GroupID"></param>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern void Api_InviteFriend(string GroupID,string QQID,int AuthCode);
		 			/// <summary>
/// 
/// </summary>
/// <param name="QQID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern string Api_GetQQInfo_v2(string QQID,int AuthCode);
		 			/// <summary>
/// //取消COM库
/// </summary>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern void CoUninitialize();
		 			/// <summary>
/// //初始化COM库
/// </summary>
/// <param name="pvReserved"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern void CoInitialize(int pvReserved);
		 			/// <summary>
/// //上传图片，获得图片GUID，
/// </summary>
/// <param name="Type">1.私聊图片  2.群聊图片</param>
/// <param name="对象">私聊图片填写QQID，群聊/讨论组图片填写群号讨论组号</param>
/// <param name="Bin">图片的Hex流</param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern string Api_UpLoadPic(int Type,string 对象,string Bin,int AuthCode);
		 			/// <summary>
/// //设置插件状态，开启或关闭
/// </summary>
/// <param name="State">真:启用自身  假:关闭自身</param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern string Api_SetPluginState(bool State,int AuthCode);
		 			/// <summary>
/// 
/// </summary>
/// <param name="群号"></param>
/// <param name="文件GUID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern void Api_DeleteFile(string 群号,string 文件GUID,int AuthCode);
		 			/// <summary>
/// 
/// </summary>
/// <param name="来源对象"></param>
/// <param name="转发群号"></param>
/// <param name="文件GUID"></param>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern void Api_RepeatFile(string 来源对象,string 转发群号,string 文件GUID,int AuthCode);
		 			/// <summary>
/// 
/// </summary>
/// <param name="AuthCode"></param>
/// <returns></returns>

		  [DllImport("message.dll")]
          public static extern void Api_ClearOffLineFile(int AuthCode);
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

		  [DllImport("message.dll")]
          public static extern int WideCharToMultiByte(int CodePage,int dwFlags,byte[] lpWideCharStr,int cchWideChar,string lpMultiByteStr,int cchMultiByte,int lpDefaultChar,int lpUsedDefaultChar);
		         }
}
