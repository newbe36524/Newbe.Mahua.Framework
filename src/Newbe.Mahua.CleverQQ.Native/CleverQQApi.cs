using System.ComponentModel;
using System.Runtime.InteropServices;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CleverQQ.Native
{
    public class CleverQQApi : ICleverQQApi
    {
        /// <summary>
        ///     发送普通文本消息
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="信息类型">0在线临时会话 1好友 2群 3讨论组 4群临时会话 5讨论组临时会话 7好友验证回复会话（0、7只支持Pro版）</param>
        /// <param name="收信对象群_讨论组">发送群信息、讨论组、群或讨论组临时会话信息时填写，如发送对象为好友或信息类型是0时可空</param>
        /// <param name="收信QQ">收信对象QQ</param>
        /// <param name="内容">信息内容</param>
        /// <param name="气泡ID">-1为随机气泡</param>
        /// <returns></returns>
        void ICleverQQApi.Api_SendMsg([Description("机器人QQ")] string 响应QQ,
            [Description("0在线临时会话 1好友 2群 3讨论组 4群临时会话 5讨论组临时会话 7好友验证回复会话（0、7只支持Pro版）")]
            int 信息类型, [Description("发送群信息、讨论组、群或讨论组临时会话信息时填写，如发送对象为好友或信息类型是0时可空")]
            string 收信对象群_讨论组, [Description("收信对象QQ")] string 收信QQ, [Description("信息内容")] string 内容,
            [Description("-1为随机气泡")] int 气泡ID)
        {
            NativeMethods.Api_SendMsg(响应QQ, 信息类型, 收信对象群_讨论组, 收信QQ, 内容, 气泡ID);
        }

        /// <summary>
        ///     发送XML消息
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="发送方式">1普通 2匿名（匿名需要群开启）</param>
        /// <param name="信息类型">0在线临时会话 1好友 2群 3讨论组 4群临时会话 5讨论组临时会话 7好友验证回复会话（0、7只支持Pro版）</param>
        /// <param name="收信对象所属群_讨论组">发送群信息、讨论组、群或讨论组临时会话信息时填写，如发送对象为好友或信息类型是0时可空</param>
        /// <param name="收信对象QQ">收信对象QQ</param>
        /// <param name="ObjectMsg">XML代码</param>
        /// <param name="结构子类型">0 基本 2 点歌</param>
        /// <returns></returns>
        void ICleverQQApi.Api_SendXML([Description("机器人QQ")] string 响应QQ, [Description("1普通 2匿名（匿名需要群开启）")] int 发送方式,
            [Description("0在线临时会话 1好友 2群 3讨论组 4群临时会话 5讨论组临时会话 7好友验证回复会话（0、7只支持Pro版）")]
            int 信息类型, [Description("发送群信息、讨论组、群或讨论组临时会话信息时填写，如发送对象为好友或信息类型是0时可空")]
            string 收信对象所属群_讨论组, [Description("收信对象QQ")] string 收信对象QQ, [Description("XML代码")] string ObjectMsg,
            [Description("0 基本 2 点歌")] int 结构子类型)
        {
            NativeMethods.Api_SendXML(响应QQ, 发送方式, 信息类型, 收信对象所属群_讨论组, 收信对象QQ, ObjectMsg, 结构子类型);
        }

        /// <summary>
        ///     发送JSON结构消息
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="发送方式">1普通 2匿名（匿名需要群开启）</param>
        /// <param name="信息类型">0在线临时会话 1好友 2群 3讨论组 4群临时会话 5讨论组临时会话 7好友验证回复会话（0、7只支持Pro版）</param>
        /// <param name="收信对象所属群_讨论组">发送群信息、讨论组、群或讨论组临时会话信息时填，如发送对象为好友或信息类型是0时可空</param>
        /// <param name="收信对象QQ">收信对象QQ</param>
        /// <param name="Json结构">Json结构内容</param>
        /// <returns></returns>
        void ICleverQQApi.Api_SendJSON([Description("机器人QQ")] string 响应QQ, [Description("1普通 2匿名（匿名需要群开启）")] int 发送方式,
            [Description("0在线临时会话 1好友 2群 3讨论组 4群临时会话 5讨论组临时会话 7好友验证回复会话（0、7只支持Pro版）")]
            int 信息类型, [Description("发送群信息、讨论组、群或讨论组临时会话信息时填，如发送对象为好友或信息类型是0时可空")]
            string 收信对象所属群_讨论组, [Description("收信对象QQ")] string 收信对象QQ, [Description("Json结构内容")] string Json结构)
        {
            NativeMethods.Api_SendJSON(响应QQ, 发送方式, 信息类型, 收信对象所属群_讨论组, 收信对象QQ, Json结构);
        }

        /// <summary>
        ///     调用一次点一下，成功返回空，失败返回理由如：每天最多给他点十个赞哦，调用此Api时应注意频率，每人每日可被赞10次，每日每Q最多可赞50人
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="被赞QQ">填写被赞人QQ</param>
        /// <returns></returns>
        string ICleverQQApi.Api_UpVote([Description("机器人QQ")] string 响应QQ, [Description("填写被赞人QQ")] string 被赞QQ)
        {
            return NativeMethods.Api_UpVote(响应QQ, 被赞QQ);
        }

        /// <summary>
        ///     取得机器人网页操作用的Cookies
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <returns></returns>
        string ICleverQQApi.Api_GetCookies([Description("机器人QQ")] string 响应QQ)
        {
            return NativeMethods.Api_GetCookies(响应QQ);
        }

        /// <summary>
        ///     取得腾讯微博页面操作用参数P_skey
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <returns></returns>
        string ICleverQQApi.Api_GetBlogPsKey([Description("机器人QQ")] string 响应QQ)
        {
            return NativeMethods.Api_GetBlogPsKey(响应QQ);
        }

        /// <summary>
        ///     取得QQ空间页面操作用参数P_skey
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <returns></returns>
        string ICleverQQApi.Api_GetZonePsKey([Description("机器人QQ")] string 响应QQ)
        {
            return NativeMethods.Api_GetZonePsKey(响应QQ);
        }

        /// <summary>
        ///     取得QQ群页面操作用参数P_skey
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <returns></returns>
        string ICleverQQApi.Api_GetGroupPsKey([Description("机器人QQ")] string 响应QQ)
        {
            return NativeMethods.Api_GetGroupPsKey(响应QQ);
        }

        /// <summary>
        ///     取得腾讯课堂页面操作用参数P_skey
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <returns></returns>
        string ICleverQQApi.Api_GetClassRoomPsKey([Description("机器人QQ")] string 响应QQ)
        {
            return NativeMethods.Api_GetClassRoomPsKey(响应QQ);
        }

        /// <summary>
        ///     取得机器人网页操作用参数Bkn或G_tk
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <returns></returns>
        string ICleverQQApi.Api_GetBkn([Description("机器人QQ")] string 响应QQ)
        {
            return NativeMethods.Api_GetBkn(响应QQ);
        }

        /// <summary>
        ///     取得机器人网页操作用参数长Bkn或长G_tk
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <returns></returns>
        string ICleverQQApi.Api_GetBkn32([Description("机器人QQ")] string 响应QQ)
        {
            return NativeMethods.Api_GetBkn32(响应QQ);
        }

        /// <summary>
        ///     取得机器人网页操作用参数长Ldw
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <returns></returns>
        string ICleverQQApi.Api_GetLongLdw([Description("机器人QQ")] string 响应QQ)
        {
            return NativeMethods.Api_GetLongLdw(响应QQ);
        }

        /// <summary>
        ///     取得机器人网页操作用的Clientkey
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <returns></returns>
        string ICleverQQApi.Api_GetClientkey([Description("机器人QQ")] string 响应QQ)
        {
            return NativeMethods.Api_GetClientkey(响应QQ);
        }

        /// <summary>
        ///     取得机器人网页操作用的长Clientkey
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <returns></returns>
        string ICleverQQApi.Api_GetLongClientkey([Description("机器人QQ")] string 响应QQ)
        {
            return NativeMethods.Api_GetLongClientkey(响应QQ);
        }

        /// <summary>
        ///     管理员邀请对象入群，频率过快会失败
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="对象QQ">被邀请人QQ号码（多个号码使用 #换行符 分割）</param>
        /// <param name="群号">被邀请加入的群号</param>
        /// <returns></returns>
        void ICleverQQApi.Api_AdminInviteGroup([Description("机器人QQ")] string 响应QQ,
            [Description("被邀请人QQ号码（多个号码使用 #换行符 分割）")]
            string 对象QQ, [Description("被邀请加入的群号")] string 群号)
        {
            NativeMethods.Api_AdminInviteGroup(响应QQ, 对象QQ, 群号);
        }

        /// <summary>
        ///     非管理员邀请对象入群，频率过快会失败
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="对象QQ">被邀请人QQ号码（多个号码使用 #换行符 分割）</param>
        /// <param name="群号">被邀请加入的群号</param>
        /// <returns></returns>
        void ICleverQQApi.Api_NoAdminInviteGroup([Description("机器人QQ")] string 响应QQ,
            [Description("被邀请人QQ号码（多个号码使用 #换行符 分割）")]
            string 对象QQ, [Description("被邀请加入的群号")] string 群号)
        {
            NativeMethods.Api_NoAdminInviteGroup(响应QQ, 对象QQ, 群号);
        }

        /// <summary>
        ///     取对象昵称
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="对象QQ">欲取得的QQ的号码</param>
        /// <returns></returns>
        string ICleverQQApi.Api_GetNick([Description("机器人QQ")] string 响应QQ, [Description("欲取得的QQ的号码")] string 对象QQ)
        {
            return NativeMethods.Api_GetNick(响应QQ, 对象QQ);
        }

        /// <summary>
        ///     取对象群名片
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="群号">群号</param>
        /// <param name="对象QQ">欲取得群名片的QQ号码</param>
        /// <returns></returns>
        string ICleverQQApi.Api_GetGroupCard([Description("机器人QQ")] string 响应QQ, [Description("群号")] string 群号,
            [Description("欲取得群名片的QQ号码")] string 对象QQ)
        {
            return NativeMethods.Api_GetGroupCard(响应QQ, 群号, 对象QQ);
        }

        /// <summary>
        ///     取对象QQ等级 成功返回等级  失败返回-1
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="对象QQ">欲取得的QQ的号码</param>
        /// <returns></returns>
        int ICleverQQApi.Api_GetObjLevel([Description("机器人QQ")] string 响应QQ, [Description("欲取得的QQ的号码")] string 对象QQ)
        {
            return NativeMethods.Api_GetObjLevel(响应QQ, 对象QQ);
        }

        /// <summary>
        ///     取得好友列表，返回获取到的原始JSON格式信息，需自行解析
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <returns></returns>
        string ICleverQQApi.Api_GetFriendList([Description("机器人QQ")] string 响应QQ)
        {
            return NativeMethods.Api_GetFriendList(响应QQ);
        }

        /// <summary>
        ///     取得好友列表，返回内容#换行符分割
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <returns></returns>
        string ICleverQQApi.Api_GetFriendList_B([Description("机器人QQ")] string 响应QQ)
        {
            return NativeMethods.Api_GetFriendList_B(响应QQ);
        }

        /// <summary>
        ///     取得企点QQ外部联系人好友列表  成功返回Json列表 失败或无返回空
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <returns></returns>
        string ICleverQQApi.Api_GetQidianQQFriendsList([Description("机器人QQ")] string 响应QQ)
        {
            return NativeMethods.Api_GetQidianQQFriendsList(响应QQ);
        }

        /// <summary>
        ///     取得群管理，返回获取到的原始JSON格式信息，需自行解析
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="群号">欲取管理员列表群号</param>
        /// <returns></returns>
        string ICleverQQApi.Api_GetGroupAdmin([Description("机器人QQ")] string 响应QQ, [Description("欲取管理员列表群号")] string 群号)
        {
            return NativeMethods.Api_GetGroupAdmin(响应QQ, 群号);
        }

        /// <summary>
        ///     取得群列表，#换行符分割 不受最高获取500群限制（如需获取群名称请对应调用 Api_GetGroupName 理论群名获取不会频繁）
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <returns></returns>
        string ICleverQQApi.Api_GetGroupList_A([Description("机器人QQ")] string 响应QQ)
        {
            return NativeMethods.Api_GetGroupList_A(响应QQ);
        }

        /// <summary>
        ///     取得群列表，返回获取到的原始JSON格式信息，需自行解析
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <returns></returns>
        string ICleverQQApi.Api_GetGroupList([Description("机器人QQ")] string 响应QQ)
        {
            return NativeMethods.Api_GetGroupList(响应QQ);
        }

        /// <summary>
        ///     取得群列表，返回获取到的原始JSON格式信息，需自行解析
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <returns></returns>
        string ICleverQQApi.Api_GetGroupList_B([Description("机器人QQ")] string 响应QQ)
        {
            return NativeMethods.Api_GetGroupList_B(响应QQ);
        }

        /// <summary>
        ///     取得群成员列表，返回获取到的原始JSON格式信息，需自行解析（有群员昵称）
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="群号">欲取群成员列表群号</param>
        /// <returns></returns>
        string ICleverQQApi.Api_GetGroupMemberList([Description("机器人QQ")] string 响应QQ,
            [Description("欲取群成员列表群号")] string 群号)
        {
            return NativeMethods.Api_GetGroupMemberList(响应QQ, 群号);
        }

        /// <summary>
        ///     取得群成员列表，返回QQ号和身份Json格式信息 失败返回空（无群员昵称）
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="群号">欲取群成员列表群号</param>
        /// <returns></returns>
        string ICleverQQApi.Api_GetGroupMemberList_B([Description("机器人QQ")] string 响应QQ,
            [Description("欲取群成员列表群号")] string 群号)
        {
            return NativeMethods.Api_GetGroupMemberList_B(响应QQ, 群号);
        }

        /// <summary>
        ///     取得群成员列表，返回获取到的原始JSON格式信息，需自行解析（有群员昵称）
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="群号">欲取群成员列表群号</param>
        /// <returns></returns>
        string ICleverQQApi.Api_GetGroupMemberList_C([Description("机器人QQ")] string 响应QQ,
            [Description("欲取群成员列表群号")] string 群号)
        {
            return NativeMethods.Api_GetGroupMemberList_C(响应QQ, 群号);
        }

        /// <summary>
        ///     查询对象或自己是否被禁言  禁言返回真 失败或未禁言返回假
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="群号">欲查询的群号</param>
        /// <param name="对象QQ">需要查询的对象QQ</param>
        /// <returns></returns>
        bool ICleverQQApi.Api_IsShutUp([Description("机器人QQ")] string 响应QQ, [Description("欲查询的群号")] string 群号,
            [Description("需要查询的对象QQ")] string 对象QQ)
        {
            return NativeMethods.Api_IsShutUp(响应QQ, 群号, 对象QQ);
        }

        /// <summary>
        ///     群内禁言某人
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="群号">欲操作的群号</param>
        /// <param name="对象QQ">欲禁言的对象，如留空且机器人QQ为管理员，将设置该群为全群禁言</param>
        /// <param name="时间">0为解除禁言 （禁言单位为秒），如为全群禁言，参数为非0，解除全群禁言为0</param>
        /// <returns></returns>
        void ICleverQQApi.Api_ShutUP([Description("机器人QQ")] string 响应QQ, [Description("欲操作的群号")] string 群号,
            [Description("欲禁言的对象，如留空且机器人QQ为管理员，将设置该群为全群禁言")]
            string 对象QQ, [Description("0为解除禁言 （禁言单位为秒），如为全群禁言，参数为非0，解除全群禁言为0")]
            int 时间)
        {
            NativeMethods.Api_ShutUP(响应QQ, 群号, 对象QQ, 时间);
        }

        /// <summary>
        ///     申请加群
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="群号">欲申请加入的群号</param>
        /// <param name="理由">附加理由，可留空（需回答正确问题时，请填写问题答案）</param>
        /// <returns></returns>
        void ICleverQQApi.Api_JoinGroup([Description("机器人QQ")] string 响应QQ, [Description("欲申请加入的群号")] string 群号,
            [Description("附加理由，可留空（需回答正确问题时，请填写问题答案）")]
            string 理由)
        {
            NativeMethods.Api_JoinGroup(响应QQ, 群号, 理由);
        }

        /// <summary>
        ///     退群
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="群号">欲退出的群号</param>
        /// <returns></returns>
        void ICleverQQApi.Api_QuitGroup([Description("机器人QQ")] string 响应QQ, [Description("欲退出的群号")] string 群号)
        {
            NativeMethods.Api_QuitGroup(响应QQ, 群号);
        }

        /// <summary>
        ///     上传图片（通过读入字节集方式），可使用网页链接或本地读入，成功返回该图片GUID，失败返回空
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="上传类型">1好友、临时会话  2群、讨论组 Ps：好友临时会话用类型 1，群讨论组用类型 2；当填写错误时，图片GUID发送不会成功</param>
        /// <param name="参考对象">上传该图片所属的群号或QQ</param>
        /// <param name="图片数据">图片字节集数据</param>
        /// <returns></returns>
        string ICleverQQApi.Api_UpLoadPic([Description("机器人QQ")] string 响应QQ,
            [Description("1好友、临时会话  2群、讨论组 Ps：好友临时会话用类型 1，群讨论组用类型 2；当填写错误时，图片GUID发送不会成功")]
            int 上传类型, [Description("上传该图片所属的群号或QQ")] string 参考对象, [Description("图片字节集数据")] byte[] 图片数据)
        {
            return NativeMethods.Api_UpLoadPic(响应QQ, 上传类型, 参考对象, 图片数据);
        }

        /// <summary>
        ///     根据图片GUID取得图片下载连接
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="图片类型">1 群 讨论组  2临时会话和好友</param>
        /// <param name="参考对象">图片所属对应的群号和好友QQ（可随意乱填写）</param>
        /// <param name="图片GUID">例如[IR:pic={xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx}.jpg]</param>
        /// <returns></returns>
        string ICleverQQApi.Api_GetPicLink([Description("机器人QQ")] string 响应QQ,
            [Description("1 群 讨论组  2临时会话和好友")] int 图片类型, [Description("图片所属对应的群号和好友QQ（可随意乱填写）")]
            string 参考对象, [Description("例如[IR:pic={xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx}.jpg]")]
            string 图片GUID)
        {
            return NativeMethods.Api_GetPicLink(响应QQ, 图片类型, 参考对象, 图片GUID);
        }

        /// <summary>
        ///     向CleverQQ日志窗口发送一条本插件的日志，可用于调试输出需要的内容，或定位插件错误与运行状态
        /// </summary>
        /// <param name="内容">任意想输出的文本格式信息</param>
        /// <returns></returns>
        void ICleverQQApi.Api_OutPutLog([Description("任意想输出的文本格式信息")] string 内容)
        {
            NativeMethods.Api_OutPutLog(内容);
        }

        /// <summary>
        ///     腾讯Tea加密
        /// </summary>
        /// <param name="需加密内容">需加密的内容</param>
        /// <param name="会话KEY">这里填Api_SessionKey</param>
        /// <returns></returns>
        string ICleverQQApi.Api_Tea加密([Description("需加密的内容")] string 需加密内容,
            [Description("这里填Api_SessionKey")] string 会话KEY)
        {
            return NativeMethods.Api_Tea加密(需加密内容, 会话KEY);
        }

        /// <summary>
        ///     腾讯Tea解密
        /// </summary>
        /// <param name="需解密内容">需解密的内容</param>
        /// <param name="会话KEY">这里填Api_SessionKey</param>
        /// <returns></returns>
        string ICleverQQApi.Api_Tea解密([Description("需解密的内容")] string 需解密内容,
            [Description("这里填Api_SessionKey")] string 会话KEY)
        {
            return NativeMethods.Api_Tea解密(需解密内容, 会话KEY);
        }

        /// <summary>
        ///     获取会话SessionKey密钥
        /// </summary>
        /// <param name="响应QQ">欲获取的QQ</param>
        /// <returns></returns>
        string ICleverQQApi.Api_SessionKey([Description("欲获取的QQ")] string 响应QQ)
        {
            return NativeMethods.Api_SessionKey(响应QQ);
        }

        /// <summary>
        ///     群号转群ID
        /// </summary>
        /// <param name="群号"></param>
        /// <returns></returns>
        string ICleverQQApi.Api_GNTransGID([Description("")] string 群号)
        {
            return NativeMethods.Api_GNTransGID(群号);
        }

        /// <summary>
        ///     群ID转群号
        /// </summary>
        /// <param name="群ID"></param>
        /// <returns></returns>
        string ICleverQQApi.Api_GIDTransGN([Description("")] string 群ID)
        {
            return NativeMethods.Api_GIDTransGN(群ID);
        }

        /// <summary>
        ///     发布群公告（成功返回真，失败返回假），调用此API应保证响应QQ为管理员
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="群号">欲发布公告的群号</param>
        /// <param name="标题">公告标题</param>
        /// <param name="内容">公告内容</param>
        /// <returns></returns>
        bool ICleverQQApi.Api_PBGroupNotic([Description("机器人QQ")] string 响应QQ, [Description("欲发布公告的群号")] string 群号,
            [Description("公告标题")] string 标题, [Description("公告内容")] string 内容)
        {
            return NativeMethods.Api_PBGroupNotic(响应QQ, 群号, 标题, 内容);
        }

        /// <summary>
        ///     取群公告，返回该群最新公告
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="群号">欲取得公告的群号</param>
        /// <returns></returns>
        string ICleverQQApi.Api_GetNotice([Description("机器人QQ")] string 响应QQ, [Description("欲取得公告的群号")] string 群号)
        {
            return NativeMethods.Api_GetNotice(响应QQ, 群号);
        }

        /// <summary>
        ///     向好友发起窗口抖动，调用此Api腾讯会限制频率
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="接收QQ">接收抖动消息的QQ</param>
        /// <returns></returns>
        bool ICleverQQApi.Api_ShakeWindow([Description("机器人QQ")] string 响应QQ, [Description("接收抖动消息的QQ")] string 接收QQ)
        {
            return NativeMethods.Api_ShakeWindow(响应QQ, 接收QQ);
        }

        /// <summary>
        ///     某人申请入群 添加好友 被邀请入群 请求处理
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="请求类型">213请求入群  214我被邀请加入某群  215某人被邀请加入群  101某人请求添加好友</param>
        /// <param name="对象QQ">申请入群 被邀请人 请求添加好友人的QQ （当请求类型为214时这里为邀请人QQ）</param>
        /// <param name="群号">收到请求群号（好友添加时这里请为空）</param>
        /// <param name="处理方式">10同意 20拒绝 30忽略</param>
        /// <param name="附加信息">拒绝入群，拒绝添加好友 附加信息</param>
        /// <returns></returns>
        void ICleverQQApi.Api_HandleEvent([Description("机器人QQ")] string 响应QQ,
            [Description("213请求入群  214我被邀请加入某群  215某人被邀请加入群  101某人请求添加好友")]
            int 请求类型, [Description("申请入群 被邀请人 请求添加好友人的QQ （当请求类型为214时这里为邀请人QQ）")]
            string 对象QQ, [Description("收到请求群号（好友添加时这里请为空）")] string 群号, [Description("10同意 20拒绝 30忽略")] int 处理方式,
            [Description("拒绝入群，拒绝添加好友 附加信息")] string 附加信息)
        {
            NativeMethods.Api_HandleEvent(响应QQ, 请求类型, 对象QQ, 群号, 处理方式, 附加信息);
        }

        /// <summary>
        ///     处理群验证事件 第二模式（新手建议使用Api_HandleEvent） Pro可用
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="请求类型">213请求入群  214我被邀请加入某群  215某人被邀请加入群  101某人请求添加好友</param>
        /// <param name="对象QQ">申请入群 被邀请人 请求添加好友人的QQ （当请求类型为214时这里为邀请人QQ）</param>
        /// <param name="群号">收到请求群号（好友添加时这里请为空）</param>
        /// <param name="seq">需要处理事件的seq （好友事件留空）</param>
        /// <param name="处理方式">10同意 20拒绝 30忽略</param>
        /// <param name="附加信息">拒绝入群，拒绝添加好友 附加信息</param>
        /// <returns></returns>
        void ICleverQQApi.Api_HandleGroupEvent([Description("机器人QQ")] string 响应QQ,
            [Description("213请求入群  214我被邀请加入某群  215某人被邀请加入群  101某人请求添加好友")]
            int 请求类型, [Description("申请入群 被邀请人 请求添加好友人的QQ （当请求类型为214时这里为邀请人QQ）")]
            string 对象QQ, [Description("收到请求群号（好友添加时这里请为空）")] string 群号, [Description("需要处理事件的seq （好友事件留空）")] string seq,
            [Description("10同意 20拒绝 30忽略")] int 处理方式, [Description("拒绝入群，拒绝添加好友 附加信息")] string 附加信息)
        {
            NativeMethods.Api_HandleGroupEvent(响应QQ, 请求类型, 对象QQ, 群号, seq, 处理方式, 附加信息);
        }

        /// <summary>
        ///     开关群匿名消息发送功能    成功返回真  失败返回假
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="群号">需开关群匿名功能群号</param>
        /// <param name="开关">真开    假关</param>
        /// <returns></returns>
        bool ICleverQQApi.Api_SetAnon([Description("机器人QQ")] string 响应QQ, [Description("需开关群匿名功能群号")] string 群号,
            [Description("真开    假关")] bool 开关)
        {
            return NativeMethods.Api_SetAnon(响应QQ, 群号, 开关);
        }

        /// <summary>
        ///     修改对象群名片 成功返回真 失败返回假
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="群号">对象所处群号</param>
        /// <param name="对象QQ">被修改名片人QQ</param>
        /// <param name="名片">需要修改的名片</param>
        /// <returns></returns>
        bool ICleverQQApi.Api_SetGroupCard([Description("机器人QQ")] string 响应QQ, [Description("对象所处群号")] string 群号,
            [Description("被修改名片人QQ")] string 对象QQ, [Description("需要修改的名片")] string 名片)
        {
            return NativeMethods.Api_SetGroupCard(响应QQ, 群号, 对象QQ, 名片);
        }

        /// <summary>
        ///     退出讨论组
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="讨论组ID">需退出的讨论组ID</param>
        /// <returns></returns>
        void ICleverQQApi.Api_QuitDisGroup([Description("机器人QQ")] string 响应QQ, [Description("需退出的讨论组ID")] string 讨论组ID)
        {
            NativeMethods.Api_QuitDisGroup(响应QQ, 讨论组ID);
        }

        /// <summary>
        ///     创建一个讨论组 成功返回讨论组ID 失败返回空
        /// </summary>
        /// <param name="响应QQ">机器人</param>
        /// <param name="讨论组名称">建立的讨论组名称</param>
        /// <returns></returns>
        string ICleverQQApi.Api_CreateDisGroup([Description("机器人")] string 响应QQ, [Description("建立的讨论组名称")] string 讨论组名称)
        {
            return NativeMethods.Api_CreateDisGroup(响应QQ, 讨论组名称);
        }

        /// <summary>
        ///     将对象移除讨论组 成功返回空 失败返回理由
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="讨论组ID">需执行的讨论组ID</param>
        /// <param name="对象QQ">被执行对象</param>
        /// <returns></returns>
        string ICleverQQApi.Api_KickDisGroupMBR([Description("机器人QQ")] string 响应QQ,
            [Description("需执行的讨论组ID")] string 讨论组ID, [Description("被执行对象")] string 对象QQ)
        {
            return NativeMethods.Api_KickDisGroupMBR(响应QQ, 讨论组ID, 对象QQ);
        }

        /// <summary>
        ///     邀请对象加入讨论组 成功返回空 失败返回理由
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="讨论组ID">需执行的讨论组ID</param>
        /// <param name="邀请对象QQ">被邀请对象QQ 多个用  #换行符 分割</param>
        /// <returns></returns>
        string ICleverQQApi.Api_InviteDisGroup([Description("机器人QQ")] string 响应QQ,
            [Description("需执行的讨论组ID")] string 讨论组ID, [Description("被邀请对象QQ 多个用  #换行符 分割")] string 邀请对象QQ)
        {
            return NativeMethods.Api_InviteDisGroup(响应QQ, 讨论组ID, 邀请对象QQ);
        }

        /// <summary>
        ///     取出讨论组列表 （返回格式为 换行符分割开的）
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <returns></returns>
        string ICleverQQApi.Api_GetDisGroupList([Description("机器人QQ")] string 响应QQ)
        {
            return NativeMethods.Api_GetDisGroupList(响应QQ);
        }

        /// <summary>
        ///     取出讨论组成员列表 （返回格式为 换行符分割开的）
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="讨论组ID">需获取的讨论组ID</param>
        /// <returns></returns>
        string ICleverQQApi.Api_GetDisGroupMemberList([Description("机器人QQ")] string 响应QQ,
            [Description("需获取的讨论组ID")] string 讨论组ID)
        {
            return NativeMethods.Api_GetDisGroupMemberList(响应QQ, 讨论组ID);
        }

        /// <summary>
        ///     修改讨论组名称
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="讨论组ID">需执行的讨论组ID</param>
        /// <param name="讨论组名称">需修改的名称</param>
        /// <returns></returns>
        void ICleverQQApi.Api_SetDisGroupName([Description("机器人QQ")] string 响应QQ,
            [Description("需执行的讨论组ID")] string 讨论组ID, [Description("需修改的名称")] string 讨论组名称)
        {
            NativeMethods.Api_SetDisGroupName(响应QQ, 讨论组ID, 讨论组名称);
        }

        /// <summary>
        ///     将对象移除群
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="群号">被执行群号</param>
        /// <param name="对象QQ">被执行对象</param>
        /// <param name="不再接收加群请求">真为不再接收，假为接收</param>
        /// <returns></returns>
        void ICleverQQApi.Api_KickGroupMBR([Description("机器人QQ")] string 响应QQ, [Description("被执行群号")] string 群号,
            [Description("被执行对象")] string 对象QQ, [Description("真为不再接收，假为接收")] bool 不再接收加群请求)
        {
            NativeMethods.Api_KickGroupMBR(响应QQ, 群号, 对象QQ, 不再接收加群请求);
        }

        /// <summary>
        ///     获取对象当前赞数量 失败返回-1   成功返回赞数 （获取频繁会出现失败现象，请自行写判断处理失败问题）
        /// </summary>
        /// <param name="响应QQ"></param>
        /// <param name="对象QQ"></param>
        /// <returns></returns>
        long ICleverQQApi.Api_GetObjVote([Description("")] string 响应QQ, [Description("")] string 对象QQ)
        {
            return NativeMethods.Api_GetObjVote(响应QQ, 对象QQ);
        }

        /// <summary>
        ///     上传QQ语音，成功返回语音GUID  失败返回空
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="上传类型">2、QQ群 讨论组</param>
        /// <param name="接收群号">需上传的群号</param>
        /// <param name="语音数据">语音字节集数据（AMR Silk编码）</param>
        /// <returns></returns>
        string ICleverQQApi.Api_UpLoadVoice([Description("机器人QQ")] string 响应QQ, [Description("2、QQ群 讨论组")] int 上传类型,
            [Description("需上传的群号")] string 接收群号, [Description("语音字节集数据（AMR Silk编码）")] byte[] 语音数据)
        {
            return NativeMethods.Api_UpLoadVoice(响应QQ, 上传类型, 接收群号, 语音数据);
        }

        /// <summary>
        ///     通过语音GUID获取下载连接 失败返回空
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="语音GUID">[IR:Voi={xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxx}.amr]</param>
        /// <returns></returns>
        string ICleverQQApi.Api_GetVoiLink([Description("机器人QQ")] string 响应QQ,
            [Description("[IR:Voi={xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxx}.amr]")]
            string 语音GUID)
        {
            return NativeMethods.Api_GetVoiLink(响应QQ, 语音GUID);
        }

        /// <summary>
        ///     获取当前框架内部时间戳
        /// </summary>
        /// <returns></returns>
        long ICleverQQApi.Api_GetTimeStamp()
        {
            return NativeMethods.Api_GetTimeStamp();
        }

        /// <summary>
        ///     向腾讯发送原始封包（成功返回腾讯返回的包 失败返回空）
        /// </summary>
        /// <param name="响应QQ"></param>
        /// <param name="封包">封包内容</param>
        /// <returns></returns>
        string ICleverQQApi.Api_SendPack([Description("")] string 响应QQ, [Description("封包内容")] string 封包)
        {
            return NativeMethods.Api_SendPack(响应QQ, 封包);
        }

        /// <summary>
        ///     获取对象资料 此方式为http，调用时应自行注意控制频率（成功返回JSON格式自行解析）
        /// </summary>
        /// <param name="响应QQ"></param>
        /// <param name="对象QQ"></param>
        /// <returns></returns>
        string ICleverQQApi.Api_GetObjInfo([Description("")] string 响应QQ, [Description("")] string 对象QQ)
        {
            return NativeMethods.Api_GetObjInfo(响应QQ, 对象QQ);
        }

        /// <summary>
        ///     取对象性别 1男 2女  未知或失败返回-1
        /// </summary>
        /// <param name="响应QQ"></param>
        /// <param name="对象QQ"></param>
        /// <returns></returns>
        int ICleverQQApi.Api_GetGender([Description("")] string 响应QQ, [Description("")] string 对象QQ)
        {
            return NativeMethods.Api_GetGender(响应QQ, 对象QQ);
        }

        /// <summary>
        ///     取Q龄 成功返回Q龄 失败返回-1
        /// </summary>
        /// <param name="响应QQ"></param>
        /// <param name="对象QQ"></param>
        /// <returns></returns>
        int ICleverQQApi.Api_GetQQAge([Description("")] string 响应QQ, [Description("")] string 对象QQ)
        {
            return NativeMethods.Api_GetQQAge(响应QQ, 对象QQ);
        }

        /// <summary>
        ///     取年龄 成功返回年龄 失败返回-1
        /// </summary>
        /// <param name="响应QQ"></param>
        /// <param name="对象QQ"></param>
        /// <returns></returns>
        int ICleverQQApi.Api_GetAge([Description("")] string 响应QQ, [Description("")] string 对象QQ)
        {
            return NativeMethods.Api_GetAge(响应QQ, 对象QQ);
        }

        /// <summary>
        ///     取个人说明
        /// </summary>
        /// <param name="响应QQ"></param>
        /// <param name="对象QQ"></param>
        /// <returns></returns>
        string ICleverQQApi.Api_GetPerExp([Description("")] string 响应QQ, [Description("")] string 对象QQ)
        {
            return NativeMethods.Api_GetPerExp(响应QQ, 对象QQ);
        }

        /// <summary>
        ///     取个人签名
        /// </summary>
        /// <param name="响应QQ"></param>
        /// <param name="对象QQ"></param>
        /// <returns></returns>
        string ICleverQQApi.Api_GetSign([Description("")] string 响应QQ, [Description("")] string 对象QQ)
        {
            return NativeMethods.Api_GetSign(响应QQ, 对象QQ);
        }

        /// <summary>
        ///     取邮箱，获取对象QQ资料内邮箱栏为邮箱时返回
        /// </summary>
        /// <param name="响应QQ"></param>
        /// <param name="对象QQ"></param>
        /// <returns></returns>
        string ICleverQQApi.Api_GetEmail([Description("")] string 响应QQ, [Description("")] string 对象QQ)
        {
            return NativeMethods.Api_GetEmail(响应QQ, 对象QQ);
        }

        /// <summary>
        ///     取QQ群名
        /// </summary>
        /// <param name="响应QQ"></param>
        /// <param name="群号"></param>
        /// <returns></returns>
        string ICleverQQApi.Api_GetGroupName([Description("")] string 响应QQ, [Description("")] string 群号)
        {
            return NativeMethods.Api_GetGroupName(响应QQ, 群号);
        }

        /// <summary>
        ///     取框架版本号
        /// </summary>
        /// <returns></returns>
        string ICleverQQApi.Api_GetVer()
        {
            return NativeMethods.Api_GetVer();
        }

        /// <summary>
        ///     取框架所有QQ号 换行符分割
        /// </summary>
        /// <returns></returns>
        string ICleverQQApi.Api_GetQQList()
        {
            return NativeMethods.Api_GetQQList();
        }

        /// <summary>
        ///     取框架在线QQ号 换行符分割
        /// </summary>
        /// <returns></returns>
        string ICleverQQApi.Api_GetOnLineList()
        {
            return NativeMethods.Api_GetOnLineList();
        }

        /// <summary>
        ///     取框架离线QQ号 （Pro版可用）换行符分割
        /// </summary>
        /// <returns></returns>
        string ICleverQQApi.Api_GetOffLineList()
        {
            return NativeMethods.Api_GetOffLineList();
        }

        /// <summary>
        ///     向框架帐号列表增加一个登录QQ 成功失败均返回理由（Pro版可用）
        /// </summary>
        /// <param name="帐号"></param>
        /// <param name="密码"></param>
        /// <param name="自动登录">真 为自动登录</param>
        /// <returns></returns>
        string ICleverQQApi.Api_AddQQ([Description("")] string 帐号, [Description("")] string 密码,
            [Description("真 为自动登录")] bool 自动登录)
        {
            return NativeMethods.Api_AddQQ(帐号, 密码, 自动登录);
        }

        /// <summary>
        ///     删除框架帐号列表内指定QQ，不可在执行登录过程中删除QQ否则有几率引起错误（Pro版可用）
        /// </summary>
        /// <param name="QQ号"></param>
        /// <returns></returns>
        string ICleverQQApi.Api_DelQQ([Description("")] string QQ号)
        {
            return NativeMethods.Api_DelQQ(QQ号);
        }

        /// <summary>
        ///     登录指定QQ，应确保QQ号码在列表中已存在
        /// </summary>
        /// <param name="登录QQ"></param>
        /// <returns></returns>
        void ICleverQQApi.Api_LoginQQ([Description("")] string 登录QQ)
        {
            NativeMethods.Api_LoginQQ(登录QQ);
        }

        /// <summary>
        ///     令指定QQ下线，应确保QQ号码已在列表中且在线
        /// </summary>
        /// <param name="响应QQ"></param>
        /// <returns></returns>
        void ICleverQQApi.Api_OffLineQQ([Description("")] string 响应QQ)
        {
            NativeMethods.Api_OffLineQQ(响应QQ);
        }

        /// <summary>
        ///     是否QQ好友 好友返回真 非好友或获取失败返回假
        /// </summary>
        /// <param name="响应QQ"></param>
        /// <param name="对象QQ"></param>
        /// <returns></returns>
        bool ICleverQQApi.Api_IfFriend([Description("")] string 响应QQ, [Description("")] string 对象QQ)
        {
            return NativeMethods.Api_IfFriend(响应QQ, 对象QQ);
        }

        /// <summary>
        ///     修改机器人在线状态 昵称 个性签名 性别
        /// </summary>
        /// <param name="响应QQ"></param>
        /// <param name="类型">1、我在线上 2、Q我吧 3、离开 4、忙碌 5、请勿打扰 6、隐身 7、修改昵称 8、修改个性签名 9、修改性别</param>
        /// <param name="修改内容">类型为7和8时填写修改内容  类型9时“1”为男 “2”为女      其他填“”</param>
        /// <returns></returns>
        void ICleverQQApi.Api_SetRInf([Description("")] string 响应QQ,
            [Description("1、我在线上 2、Q我吧 3、离开 4、忙碌 5、请勿打扰 6、隐身 7、修改昵称 8、修改个性签名 9、修改性别")]
            int 类型, [Description("类型为7和8时填写修改内容  类型9时“1”为男 “2”为女      其他填“”")]
            string 修改内容)
        {
            NativeMethods.Api_SetRInf(响应QQ, 类型, 修改内容);
        }

        /// <summary>
        ///     获取机器人状态信息，成功返回：昵称、帐号、在线状态、速度、收信、发信、在线时间，失败返回空
        /// </summary>
        /// <param name="响应QQ"></param>
        /// <returns></returns>
        string ICleverQQApi.Api_GetRInf([Description("")] string 响应QQ)
        {
            return NativeMethods.Api_GetRInf(响应QQ);
        }

        /// <summary>
        ///     删除好友 成功返回真 失败返回假
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="对象QQ">被删除对象</param>
        /// <returns></returns>
        bool ICleverQQApi.Api_DelFriend([Description("机器人QQ")] string 响应QQ, [Description("被删除对象")] string 对象QQ)
        {
            return NativeMethods.Api_DelFriend(响应QQ, 对象QQ);
        }

        /// <summary>
        ///     将好友拉入黑名单  成功返回真 失败返回假
        /// </summary>
        /// <param name="响应QQ"></param>
        /// <param name="对象QQ"></param>
        /// <returns></returns>
        bool ICleverQQApi.Api_AddBkList([Description("")] string 响应QQ, [Description("")] string 对象QQ)
        {
            return NativeMethods.Api_AddBkList(响应QQ, 对象QQ);
        }

        /// <summary>
        ///     解除好友黑名单
        /// </summary>
        /// <param name="响应QQ"></param>
        /// <param name="对象QQ"></param>
        /// <returns></returns>
        void ICleverQQApi.Api_DelBkList([Description("")] string 响应QQ, [Description("")] string 对象QQ)
        {
            NativeMethods.Api_DelBkList(响应QQ, 对象QQ);
        }

        /// <summary>
        ///     屏蔽或接收某群消息
        /// </summary>
        /// <param name="响应QQ"></param>
        /// <param name="群号"></param>
        /// <param name="类型">真 为屏蔽接收  假为接收并提醒</param>
        /// <returns></returns>
        void ICleverQQApi.Api_SetShieldedGroup([Description("")] string 响应QQ, [Description("")] string 群号,
            [Description("真 为屏蔽接收  假为接收并提醒")] bool 类型)
        {
            NativeMethods.Api_SetShieldedGroup(响应QQ, 群号, 类型);
        }

        /// <summary>
        ///     好友语音上传并发送 （成功返回真 失败返回假）
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="接收QQ">接收语音人QQ</param>
        /// <param name="语音数据">语音字节集数据（AMR Silk编码）</param>
        /// <returns></returns>
        bool ICleverQQApi.Api_SendVoice([Description("机器人QQ")] string 响应QQ, [Description("接收语音人QQ")] string 接收QQ,
            [Description("语音字节集数据（AMR Silk编码）")] byte[] 语音数据)
        {
            return NativeMethods.Api_SendVoice(响应QQ, 接收QQ, 语音数据);
        }

        /// <summary>
        ///     设置或取消群管理员   成功返回空  失败返回理由
        /// </summary>
        /// <param name="响应QQ"></param>
        /// <param name="群号"></param>
        /// <param name="对象QQ"></param>
        /// <param name="操作方式">真 为设置管理  假为取消管理</param>
        /// <returns></returns>
        string ICleverQQApi.Api_SetAdmin([Description("")] string 响应QQ, [Description("")] string 群号,
            [Description("")] string 对象QQ, [Description("真 为设置管理  假为取消管理")] bool 操作方式)
        {
            return NativeMethods.Api_SetAdmin(响应QQ, 群号, 对象QQ, 操作方式);
        }

        /// <summary>
        ///     QQ群作业发布
        /// </summary>
        /// <param name="响应QQ"></param>
        /// <param name="群号"></param>
        /// <param name="作业名"></param>
        /// <param name="标题"></param>
        /// <param name="内容"></param>
        /// <returns></returns>
        void ICleverQQApi.Api_PBHomeWork([Description("")] string 响应QQ, [Description("")] string 群号,
            [Description("")] string 作业名, [Description("")] string 标题, [Description("")] string 内容)
        {
            NativeMethods.Api_PBHomeWork(响应QQ, 群号, 作业名, 标题, 内容);
        }

        /// <summary>
        ///     取框架日志
        /// </summary>
        /// <returns></returns>
        string ICleverQQApi.Api_GetLog()
        {
            return NativeMethods.Api_GetLog();
        }

        /// <summary>
        ///     取得插件自身启用状态，启用真 禁用假
        /// </summary>
        /// <returns></returns>
        bool ICleverQQApi.Api_IsEnable()
        {
            return NativeMethods.Api_IsEnable();
        }

        /// <summary>
        ///     请求禁用插件自身
        /// </summary>
        /// <returns></returns>
        void ICleverQQApi.Api_DisabledPlugin()
        {
            NativeMethods.Api_DisabledPlugin();
        }

        /// <summary>
        ///     消息撤回（成功返回空，失败返回腾讯给出的理由）（Pro版可用）
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="群号">需撤回消息群号</param>
        /// <param name="消息序号">需撤回消息序号</param>
        /// <param name="消息ID">需撤回消息ID</param>
        /// <returns></returns>
        string ICleverQQApi.Api_WithdrawMsg([Description("机器人QQ")] string 响应QQ, [Description("需撤回消息群号")] string 群号,
            [Description("需撤回消息序号")] string 消息序号, [Description("需撤回消息ID")] string 消息ID)
        {
            return NativeMethods.Api_WithdrawMsg(响应QQ, 群号, 消息序号, 消息ID);
        }

        /// <summary>
        ///     置正在输入状态（发送消息后会打断状态）
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="对象QQ">置正在输入状态接收对象</param>
        /// <returns></returns>
        void ICleverQQApi.Api_BeInput([Description("机器人QQ")] string 响应QQ, [Description("置正在输入状态接收对象")] string 对象QQ)
        {
            NativeMethods.Api_BeInput(响应QQ, 对象QQ);
        }

        /// <summary>
        ///     取对象好友添加验证方式 （00 允许任何人  01 需要身份验证  03 需回答正确问题  04 需回答问题  99 已经是好友） （Pro版可用）
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="对象QQ">需获取对象QQ</param>
        /// <returns></returns>
        string ICleverQQApi.Api_GetQQAddMode([Description("机器人QQ")] string 响应QQ, [Description("需获取对象QQ")] string 对象QQ)
        {
            return NativeMethods.Api_GetQQAddMode(响应QQ, 对象QQ);
        }

        /// <summary>
        ///     查询对象是否在线
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="对象QQ">需获取对象QQ</param>
        /// <returns></returns>
        bool ICleverQQApi.Api_IsOnline([Description("机器人QQ")] string 响应QQ, [Description("需获取对象QQ")] string 对象QQ)
        {
            return NativeMethods.Api_IsOnline(响应QQ, 对象QQ);
        }

        /// <summary>
        ///     查询对象在线状态   返回 1、在线 2、Q我 3、离开 4、忙碌 5、勿扰 6、隐身或离线（Pro可用）
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="对象QQ">需获取对象QQ</param>
        /// <returns></returns>
        int ICleverQQApi.Api_GetOnlineState([Description("机器人QQ")] string 响应QQ, [Description("需获取对象QQ")] string 对象QQ)
        {
            return NativeMethods.Api_GetOnlineState(响应QQ, 对象QQ);
        }

        /// <summary>
        ///     查询对象群当前人数和上限人数
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="群号">需查询的群号</param>
        /// <returns></returns>
        string ICleverQQApi.Api_GetGroupMemberNum([Description("机器人QQ")] string 响应QQ, [Description("需查询的群号")] string 群号)
        {
            return NativeMethods.Api_GetGroupMemberNum(响应QQ, 群号);
        }

        /// <summary>
        ///     查询对方是否允许在线状态临时会话消息（非讨论组和群临时）（Pro版可用）
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="对象QQ">需查询的对象QQ</param>
        /// <returns></returns>
        bool ICleverQQApi.Api_GetWpa([Description("机器人QQ")] string 响应QQ, [Description("需查询的对象QQ")] string 对象QQ)
        {
            return NativeMethods.Api_GetWpa(响应QQ, 对象QQ);
        }

        /// <summary>
        ///     查询对象群验证方式 1允许任何人 2需要验证消息 3不允许任何人加群 4需要正确回答问题 5需要回答问题并由管理员审核 6付费群 -1群号不存在（获取失败返回空）Pro版可用
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="群号">需查询的群号</param>
        /// <returns></returns>
        string ICleverQQApi.Api_GetGroupAddMode([Description("机器人QQ")] string 响应QQ, [Description("需查询的群号")] string 群号)
        {
            return NativeMethods.Api_GetGroupAddMode(响应QQ, 群号);
        }

        /// <summary>
        ///     查询QQ群等级，成功返回等级（失败返回-1）Pro版可用
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="群号">需查询的群号</param>
        /// <returns></returns>
        int ICleverQQApi.Api_GetGroupLv([Description("机器人QQ")] string 响应QQ, [Description("需查询的群号")] string 群号)
        {
            return NativeMethods.Api_GetGroupLv(响应QQ, 群号);
        }

        /// <summary>
        ///     修改好友备注姓名
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="对象QQ">需获取对象好友QQ</param>
        /// <param name="备注">需要修改的备注姓名</param>
        /// <returns></returns>
        void ICleverQQApi.Api_SetFriendsRemark([Description("机器人QQ")] string 响应QQ,
            [Description("需获取对象好友QQ")] string 对象QQ, [Description("需要修改的备注姓名")] string 备注)
        {
            NativeMethods.Api_SetFriendsRemark(响应QQ, 对象QQ, 备注);
        }

        /// <summary>
        ///     取好友备注姓名（成功返回备注，失败或无备注返回空）Pro可用
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="对象QQ">需获取对象好友QQ</param>
        /// <returns></returns>
        string ICleverQQApi.Api_GetFriendsRemark([Description("机器人QQ")] string 响应QQ,
            [Description("需获取对象好友QQ")] string 对象QQ)
        {
            return NativeMethods.Api_GetFriendsRemark(响应QQ, 对象QQ);
        }

        /// <summary>
        ///     QQ群签到（成功返回真 失败返回假）
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="群号">QQ群号</param>
        /// <param name="地名">签到地名（Pro可自定义）</param>
        /// <param name="想说的话">想发表的内容</param>
        /// <returns></returns>
        bool ICleverQQApi.Api_SignIn([Description("机器人QQ")] string 响应QQ, [Description("QQ群号")] string 群号,
            [Description("签到地名（Pro可自定义）")] string 地名, [Description("想发表的内容")] string 想说的话)
        {
            return NativeMethods.Api_SignIn(响应QQ, 群号, 地名, 想说的话);
        }

        /// <summary>
        ///     抽取群礼物（返回结果Json，需群聊等级LV5后）Pro可用
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <returns></returns>
        string ICleverQQApi.Api_TakeGift([Description("机器人QQ")] string 响应QQ)
        {
            return NativeMethods.Api_TakeGift(响应QQ);
        }

        /// <summary>
        ///     查询我的群礼物（返回Json格式）Pro可用
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <returns></returns>
        string ICleverQQApi.Api_CheckGift([Description("机器人QQ")] string 响应QQ)
        {
            return NativeMethods.Api_CheckGift(响应QQ);
        }

        /// <summary>
        ///     送群礼物（成功返回1 失败返回-1）Pro可用
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="群号">需送礼物群号</param>
        /// <param name="对象QQ">赠予礼物对象</param>
        /// <param name="pid">礼物pid</param>
        /// <returns></returns>
        int ICleverQQApi.Api_GiveGift([Description("机器人QQ")] string 响应QQ, [Description("需送礼物群号")] string 群号,
            [Description("赠予礼物对象")] string 对象QQ, [Description("礼物pid")] string pid)
        {
            return NativeMethods.Api_GiveGift(响应QQ, 群号, 对象QQ, pid);
        }

        /// <summary>
        ///     查询对象或自身群聊等级（返回实际等级 失败返回-1）Pro可用
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="群号">查询群号</param>
        /// <param name="对象QQ">需查询对象或机器人QQ</param>
        /// <returns></returns>
        int ICleverQQApi.Api_GetGroupChatLv([Description("机器人QQ")] string 响应QQ, [Description("查询群号")] string 群号,
            [Description("需查询对象或机器人QQ")] string 对象QQ)
        {
            return NativeMethods.Api_GetGroupChatLv(响应QQ, 群号, 对象QQ);
        }

        /// <summary>
        ///     查询对象或自身QQ达人天数（返回实际天数 失败返回-1）Pro可用
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="对象QQ">需查询对象或机器人QQ</param>
        /// <returns></returns>
        int ICleverQQApi.Api_GetExpertDays([Description("机器人QQ")] string 响应QQ, [Description("需查询对象或机器人QQ")] string 对象QQ)
        {
            return NativeMethods.Api_GetExpertDays(响应QQ, 对象QQ);
        }

        /// <summary>
        ///     获取机器人QQ是否被屏蔽消息发送状态（真屏蔽 假未屏蔽）
        /// </summary>
        /// <param name="响应QQ">机器人QQ</param>
        /// <param name="消息类型">0在线临时会话 1好友 2群 3讨论组 4群临时会话 5讨论组临时会话 7好友验证回复会话</param>
        /// <returns></returns>
        bool ICleverQQApi.Api_GetShieldedState([Description("机器人QQ")] string 响应QQ,
            [Description("0在线临时会话 1好友 2群 3讨论组 4群临时会话 5讨论组临时会话 7好友验证回复会话")]
            int 消息类型)
        {
            return NativeMethods.Api_GetShieldedState(响应QQ, 消息类型);
        }

        private static class NativeMethods
        {
            /// <summary>
            ///     发送普通文本消息
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="信息类型">0在线临时会话 1好友 2群 3讨论组 4群临时会话 5讨论组临时会话 7好友验证回复会话（0、7只支持Pro版）</param>
            /// <param name="收信对象群_讨论组">发送群信息、讨论组、群或讨论组临时会话信息时填写，如发送对象为好友或信息类型是0时可空</param>
            /// <param name="收信QQ">收信对象QQ</param>
            /// <param name="内容">信息内容</param>
            /// <param name="气泡ID">-1为随机气泡</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern void Api_SendMsg([Description("机器人QQ")] string 响应QQ,
                [Description("0在线临时会话 1好友 2群 3讨论组 4群临时会话 5讨论组临时会话 7好友验证回复会话（0、7只支持Pro版）")]
                int 信息类型, [Description("发送群信息、讨论组、群或讨论组临时会话信息时填写，如发送对象为好友或信息类型是0时可空")]
                string 收信对象群_讨论组, [Description("收信对象QQ")] string 收信QQ, [Description("信息内容")] string 内容,
                [Description("-1为随机气泡")] int 气泡ID);

            /// <summary>
            ///     发送XML消息
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="发送方式">1普通 2匿名（匿名需要群开启）</param>
            /// <param name="信息类型">0在线临时会话 1好友 2群 3讨论组 4群临时会话 5讨论组临时会话 7好友验证回复会话（0、7只支持Pro版）</param>
            /// <param name="收信对象所属群_讨论组">发送群信息、讨论组、群或讨论组临时会话信息时填写，如发送对象为好友或信息类型是0时可空</param>
            /// <param name="收信对象QQ">收信对象QQ</param>
            /// <param name="ObjectMsg">XML代码</param>
            /// <param name="结构子类型">0 基本 2 点歌</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern void Api_SendXML([Description("机器人QQ")] string 响应QQ,
                [Description("1普通 2匿名（匿名需要群开启）")] int 发送方式,
                [Description("0在线临时会话 1好友 2群 3讨论组 4群临时会话 5讨论组临时会话 7好友验证回复会话（0、7只支持Pro版）")]
                int 信息类型, [Description("发送群信息、讨论组、群或讨论组临时会话信息时填写，如发送对象为好友或信息类型是0时可空")]
                string 收信对象所属群_讨论组, [Description("收信对象QQ")] string 收信对象QQ, [Description("XML代码")] string ObjectMsg,
                [Description("0 基本 2 点歌")] int 结构子类型);

            /// <summary>
            ///     发送JSON结构消息
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="发送方式">1普通 2匿名（匿名需要群开启）</param>
            /// <param name="信息类型">0在线临时会话 1好友 2群 3讨论组 4群临时会话 5讨论组临时会话 7好友验证回复会话（0、7只支持Pro版）</param>
            /// <param name="收信对象所属群_讨论组">发送群信息、讨论组、群或讨论组临时会话信息时填，如发送对象为好友或信息类型是0时可空</param>
            /// <param name="收信对象QQ">收信对象QQ</param>
            /// <param name="Json结构">Json结构内容</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern void Api_SendJSON([Description("机器人QQ")] string 响应QQ,
                [Description("1普通 2匿名（匿名需要群开启）")] int 发送方式,
                [Description("0在线临时会话 1好友 2群 3讨论组 4群临时会话 5讨论组临时会话 7好友验证回复会话（0、7只支持Pro版）")]
                int 信息类型, [Description("发送群信息、讨论组、群或讨论组临时会话信息时填，如发送对象为好友或信息类型是0时可空")]
                string 收信对象所属群_讨论组, [Description("收信对象QQ")] string 收信对象QQ, [Description("Json结构内容")] string Json结构);

            /// <summary>
            ///     调用一次点一下，成功返回空，失败返回理由如：每天最多给他点十个赞哦，调用此Api时应注意频率，每人每日可被赞10次，每日每Q最多可赞50人
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="被赞QQ">填写被赞人QQ</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_UpVote([Description("机器人QQ")] string 响应QQ,
                [Description("填写被赞人QQ")] string 被赞QQ);

            /// <summary>
            ///     取得机器人网页操作用的Cookies
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetCookies([Description("机器人QQ")] string 响应QQ);

            /// <summary>
            ///     取得腾讯微博页面操作用参数P_skey
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetBlogPsKey([Description("机器人QQ")] string 响应QQ);

            /// <summary>
            ///     取得QQ空间页面操作用参数P_skey
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetZonePsKey([Description("机器人QQ")] string 响应QQ);

            /// <summary>
            ///     取得QQ群页面操作用参数P_skey
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetGroupPsKey([Description("机器人QQ")] string 响应QQ);

            /// <summary>
            ///     取得腾讯课堂页面操作用参数P_skey
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetClassRoomPsKey([Description("机器人QQ")] string 响应QQ);

            /// <summary>
            ///     取得机器人网页操作用参数Bkn或G_tk
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetBkn([Description("机器人QQ")] string 响应QQ);

            /// <summary>
            ///     取得机器人网页操作用参数长Bkn或长G_tk
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetBkn32([Description("机器人QQ")] string 响应QQ);

            /// <summary>
            ///     取得机器人网页操作用参数长Ldw
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetLongLdw([Description("机器人QQ")] string 响应QQ);

            /// <summary>
            ///     取得机器人网页操作用的Clientkey
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetClientkey([Description("机器人QQ")] string 响应QQ);

            /// <summary>
            ///     取得机器人网页操作用的长Clientkey
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetLongClientkey([Description("机器人QQ")] string 响应QQ);

            /// <summary>
            ///     管理员邀请对象入群，频率过快会失败
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="对象QQ">被邀请人QQ号码（多个号码使用 #换行符 分割）</param>
            /// <param name="群号">被邀请加入的群号</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern void Api_AdminInviteGroup([Description("机器人QQ")] string 响应QQ,
                [Description("被邀请人QQ号码（多个号码使用 #换行符 分割）")]
                string 对象QQ, [Description("被邀请加入的群号")] string 群号);

            /// <summary>
            ///     非管理员邀请对象入群，频率过快会失败
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="对象QQ">被邀请人QQ号码（多个号码使用 #换行符 分割）</param>
            /// <param name="群号">被邀请加入的群号</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern void Api_NoAdminInviteGroup([Description("机器人QQ")] string 响应QQ,
                [Description("被邀请人QQ号码（多个号码使用 #换行符 分割）")]
                string 对象QQ, [Description("被邀请加入的群号")] string 群号);

            /// <summary>
            ///     取对象昵称
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="对象QQ">欲取得的QQ的号码</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetNick([Description("机器人QQ")] string 响应QQ,
                [Description("欲取得的QQ的号码")] string 对象QQ);

            /// <summary>
            ///     取对象群名片
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="群号">群号</param>
            /// <param name="对象QQ">欲取得群名片的QQ号码</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetGroupCard([Description("机器人QQ")] string 响应QQ,
                [Description("群号")] string 群号, [Description("欲取得群名片的QQ号码")] string 对象QQ);

            /// <summary>
            ///     取对象QQ等级 成功返回等级  失败返回-1
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="对象QQ">欲取得的QQ的号码</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern int Api_GetObjLevel([Description("机器人QQ")] string 响应QQ,
                [Description("欲取得的QQ的号码")] string 对象QQ);

            /// <summary>
            ///     取得好友列表，返回获取到的原始JSON格式信息，需自行解析
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetFriendList([Description("机器人QQ")] string 响应QQ);

            /// <summary>
            ///     取得好友列表，返回内容#换行符分割
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetFriendList_B([Description("机器人QQ")] string 响应QQ);

            /// <summary>
            ///     取得企点QQ外部联系人好友列表  成功返回Json列表 失败或无返回空
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetQidianQQFriendsList([Description("机器人QQ")] string 响应QQ);

            /// <summary>
            ///     取得群管理，返回获取到的原始JSON格式信息，需自行解析
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="群号">欲取管理员列表群号</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetGroupAdmin([Description("机器人QQ")] string 响应QQ,
                [Description("欲取管理员列表群号")] string 群号);

            /// <summary>
            ///     取得群列表，#换行符分割 不受最高获取500群限制（如需获取群名称请对应调用 Api_GetGroupName 理论群名获取不会频繁）
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetGroupList_A([Description("机器人QQ")] string 响应QQ);

            /// <summary>
            ///     取得群列表，返回获取到的原始JSON格式信息，需自行解析
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetGroupList([Description("机器人QQ")] string 响应QQ);

            /// <summary>
            ///     取得群列表，返回获取到的原始JSON格式信息，需自行解析
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetGroupList_B([Description("机器人QQ")] string 响应QQ);

            /// <summary>
            ///     取得群成员列表，返回获取到的原始JSON格式信息，需自行解析（有群员昵称）
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="群号">欲取群成员列表群号</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetGroupMemberList([Description("机器人QQ")] string 响应QQ,
                [Description("欲取群成员列表群号")] string 群号);

            /// <summary>
            ///     取得群成员列表，返回QQ号和身份Json格式信息 失败返回空（无群员昵称）
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="群号">欲取群成员列表群号</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetGroupMemberList_B([Description("机器人QQ")] string 响应QQ,
                [Description("欲取群成员列表群号")] string 群号);

            /// <summary>
            ///     取得群成员列表，返回获取到的原始JSON格式信息，需自行解析（有群员昵称）
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="群号">欲取群成员列表群号</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetGroupMemberList_C([Description("机器人QQ")] string 响应QQ,
                [Description("欲取群成员列表群号")] string 群号);

            /// <summary>
            ///     查询对象或自己是否被禁言  禁言返回真 失败或未禁言返回假
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="群号">欲查询的群号</param>
            /// <param name="对象QQ">需要查询的对象QQ</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern bool Api_IsShutUp([Description("机器人QQ")] string 响应QQ,
                [Description("欲查询的群号")] string 群号, [Description("需要查询的对象QQ")] string 对象QQ);

            /// <summary>
            ///     群内禁言某人
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="群号">欲操作的群号</param>
            /// <param name="对象QQ">欲禁言的对象，如留空且机器人QQ为管理员，将设置该群为全群禁言</param>
            /// <param name="时间">0为解除禁言 （禁言单位为秒），如为全群禁言，参数为非0，解除全群禁言为0</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern void Api_ShutUP([Description("机器人QQ")] string 响应QQ, [Description("欲操作的群号")] string 群号,
                [Description("欲禁言的对象，如留空且机器人QQ为管理员，将设置该群为全群禁言")]
                string 对象QQ, [Description("0为解除禁言 （禁言单位为秒），如为全群禁言，参数为非0，解除全群禁言为0")]
                int 时间);

            /// <summary>
            ///     申请加群
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="群号">欲申请加入的群号</param>
            /// <param name="理由">附加理由，可留空（需回答正确问题时，请填写问题答案）</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern void Api_JoinGroup([Description("机器人QQ")] string 响应QQ,
                [Description("欲申请加入的群号")] string 群号, [Description("附加理由，可留空（需回答正确问题时，请填写问题答案）")]
                string 理由);

            /// <summary>
            ///     退群
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="群号">欲退出的群号</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern void Api_QuitGroup([Description("机器人QQ")] string 响应QQ,
                [Description("欲退出的群号")] string 群号);

            /// <summary>
            ///     上传图片（通过读入字节集方式），可使用网页链接或本地读入，成功返回该图片GUID，失败返回空
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="上传类型">1好友、临时会话  2群、讨论组 Ps：好友临时会话用类型 1，群讨论组用类型 2；当填写错误时，图片GUID发送不会成功</param>
            /// <param name="参考对象">上传该图片所属的群号或QQ</param>
            /// <param name="图片数据">图片字节集数据</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_UpLoadPic([Description("机器人QQ")] string 响应QQ,
                [Description("1好友、临时会话  2群、讨论组 Ps：好友临时会话用类型 1，群讨论组用类型 2；当填写错误时，图片GUID发送不会成功")]
                int 上传类型, [Description("上传该图片所属的群号或QQ")] string 参考对象, [Description("图片字节集数据")] byte[] 图片数据);

            /// <summary>
            ///     根据图片GUID取得图片下载连接
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="图片类型">1 群 讨论组  2临时会话和好友</param>
            /// <param name="参考对象">图片所属对应的群号和好友QQ（可随意乱填写）</param>
            /// <param name="图片GUID">例如[IR:pic={xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx}.jpg]</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetPicLink([Description("机器人QQ")] string 响应QQ,
                [Description("1 群 讨论组  2临时会话和好友")] int 图片类型, [Description("图片所属对应的群号和好友QQ（可随意乱填写）")]
                string 参考对象, [Description("例如[IR:pic={xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx}.jpg]")]
                string 图片GUID);

            /// <summary>
            ///     向CleverQQ日志窗口发送一条本插件的日志，可用于调试输出需要的内容，或定位插件错误与运行状态
            /// </summary>
            /// <param name="内容">任意想输出的文本格式信息</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern void Api_OutPutLog([Description("任意想输出的文本格式信息")] string 内容);

            /// <summary>
            ///     腾讯Tea加密
            /// </summary>
            /// <param name="需加密内容">需加密的内容</param>
            /// <param name="会话KEY">这里填Api_SessionKey</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_Tea加密([Description("需加密的内容")] string 需加密内容,
                [Description("这里填Api_SessionKey")] string 会话KEY);

            /// <summary>
            ///     腾讯Tea解密
            /// </summary>
            /// <param name="需解密内容">需解密的内容</param>
            /// <param name="会话KEY">这里填Api_SessionKey</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_Tea解密([Description("需解密的内容")] string 需解密内容,
                [Description("这里填Api_SessionKey")] string 会话KEY);

            /// <summary>
            ///     获取会话SessionKey密钥
            /// </summary>
            /// <param name="响应QQ">欲获取的QQ</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_SessionKey([Description("欲获取的QQ")] string 响应QQ);

            /// <summary>
            ///     群号转群ID
            /// </summary>
            /// <param name="群号"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GNTransGID([Description("")] string 群号);

            /// <summary>
            ///     群ID转群号
            /// </summary>
            /// <param name="群ID"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GIDTransGN([Description("")] string 群ID);

            /// <summary>
            ///     发布群公告（成功返回真，失败返回假），调用此API应保证响应QQ为管理员
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="群号">欲发布公告的群号</param>
            /// <param name="标题">公告标题</param>
            /// <param name="内容">公告内容</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern bool Api_PBGroupNotic([Description("机器人QQ")] string 响应QQ,
                [Description("欲发布公告的群号")] string 群号, [Description("公告标题")] string 标题, [Description("公告内容")] string 内容);

            /// <summary>
            ///     取群公告，返回该群最新公告
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="群号">欲取得公告的群号</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetNotice([Description("机器人QQ")] string 响应QQ,
                [Description("欲取得公告的群号")] string 群号);

            /// <summary>
            ///     向好友发起窗口抖动，调用此Api腾讯会限制频率
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="接收QQ">接收抖动消息的QQ</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern bool Api_ShakeWindow([Description("机器人QQ")] string 响应QQ,
                [Description("接收抖动消息的QQ")] string 接收QQ);

            /// <summary>
            ///     某人申请入群 添加好友 被邀请入群 请求处理
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="请求类型">213请求入群  214我被邀请加入某群  215某人被邀请加入群  101某人请求添加好友</param>
            /// <param name="对象QQ">申请入群 被邀请人 请求添加好友人的QQ （当请求类型为214时这里为邀请人QQ）</param>
            /// <param name="群号">收到请求群号（好友添加时这里请为空）</param>
            /// <param name="处理方式">10同意 20拒绝 30忽略</param>
            /// <param name="附加信息">拒绝入群，拒绝添加好友 附加信息</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern void Api_HandleEvent([Description("机器人QQ")] string 响应QQ,
                [Description("213请求入群  214我被邀请加入某群  215某人被邀请加入群  101某人请求添加好友")]
                int 请求类型, [Description("申请入群 被邀请人 请求添加好友人的QQ （当请求类型为214时这里为邀请人QQ）")]
                string 对象QQ, [Description("收到请求群号（好友添加时这里请为空）")] string 群号, [Description("10同意 20拒绝 30忽略")] int 处理方式,
                [Description("拒绝入群，拒绝添加好友 附加信息")] string 附加信息);

            /// <summary>
            ///     处理群验证事件 第二模式（新手建议使用Api_HandleEvent） Pro可用
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="请求类型">213请求入群  214我被邀请加入某群  215某人被邀请加入群  101某人请求添加好友</param>
            /// <param name="对象QQ">申请入群 被邀请人 请求添加好友人的QQ （当请求类型为214时这里为邀请人QQ）</param>
            /// <param name="群号">收到请求群号（好友添加时这里请为空）</param>
            /// <param name="seq">需要处理事件的seq （好友事件留空）</param>
            /// <param name="处理方式">10同意 20拒绝 30忽略</param>
            /// <param name="附加信息">拒绝入群，拒绝添加好友 附加信息</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern void Api_HandleGroupEvent([Description("机器人QQ")] string 响应QQ,
                [Description("213请求入群  214我被邀请加入某群  215某人被邀请加入群  101某人请求添加好友")]
                int 请求类型, [Description("申请入群 被邀请人 请求添加好友人的QQ （当请求类型为214时这里为邀请人QQ）")]
                string 对象QQ, [Description("收到请求群号（好友添加时这里请为空）")] string 群号,
                [Description("需要处理事件的seq （好友事件留空）")] string seq, [Description("10同意 20拒绝 30忽略")] int 处理方式,
                [Description("拒绝入群，拒绝添加好友 附加信息")] string 附加信息);

            /// <summary>
            ///     开关群匿名消息发送功能    成功返回真  失败返回假
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="群号">需开关群匿名功能群号</param>
            /// <param name="开关">真开    假关</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern bool Api_SetAnon([Description("机器人QQ")] string 响应QQ,
                [Description("需开关群匿名功能群号")] string 群号, [Description("真开    假关")] bool 开关);

            /// <summary>
            ///     修改对象群名片 成功返回真 失败返回假
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="群号">对象所处群号</param>
            /// <param name="对象QQ">被修改名片人QQ</param>
            /// <param name="名片">需要修改的名片</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern bool Api_SetGroupCard([Description("机器人QQ")] string 响应QQ,
                [Description("对象所处群号")] string 群号, [Description("被修改名片人QQ")] string 对象QQ,
                [Description("需要修改的名片")] string 名片);

            /// <summary>
            ///     退出讨论组
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="讨论组ID">需退出的讨论组ID</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern void Api_QuitDisGroup([Description("机器人QQ")] string 响应QQ,
                [Description("需退出的讨论组ID")] string 讨论组ID);

            /// <summary>
            ///     创建一个讨论组 成功返回讨论组ID 失败返回空
            /// </summary>
            /// <param name="响应QQ">机器人</param>
            /// <param name="讨论组名称">建立的讨论组名称</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_CreateDisGroup([Description("机器人")] string 响应QQ,
                [Description("建立的讨论组名称")] string 讨论组名称);

            /// <summary>
            ///     将对象移除讨论组 成功返回空 失败返回理由
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="讨论组ID">需执行的讨论组ID</param>
            /// <param name="对象QQ">被执行对象</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_KickDisGroupMBR([Description("机器人QQ")] string 响应QQ,
                [Description("需执行的讨论组ID")] string 讨论组ID, [Description("被执行对象")] string 对象QQ);

            /// <summary>
            ///     邀请对象加入讨论组 成功返回空 失败返回理由
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="讨论组ID">需执行的讨论组ID</param>
            /// <param name="邀请对象QQ">被邀请对象QQ 多个用  #换行符 分割</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_InviteDisGroup([Description("机器人QQ")] string 响应QQ,
                [Description("需执行的讨论组ID")] string 讨论组ID, [Description("被邀请对象QQ 多个用  #换行符 分割")] string 邀请对象QQ);

            /// <summary>
            ///     取出讨论组列表 （返回格式为 换行符分割开的）
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetDisGroupList([Description("机器人QQ")] string 响应QQ);

            /// <summary>
            ///     取出讨论组成员列表 （返回格式为 换行符分割开的）
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="讨论组ID">需获取的讨论组ID</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetDisGroupMemberList([Description("机器人QQ")] string 响应QQ,
                [Description("需获取的讨论组ID")] string 讨论组ID);

            /// <summary>
            ///     修改讨论组名称
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="讨论组ID">需执行的讨论组ID</param>
            /// <param name="讨论组名称">需修改的名称</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern void Api_SetDisGroupName([Description("机器人QQ")] string 响应QQ,
                [Description("需执行的讨论组ID")] string 讨论组ID, [Description("需修改的名称")] string 讨论组名称);

            /// <summary>
            ///     将对象移除群
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="群号">被执行群号</param>
            /// <param name="对象QQ">被执行对象</param>
            /// <param name="不再接收加群请求">真为不再接收，假为接收</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern void Api_KickGroupMBR([Description("机器人QQ")] string 响应QQ,
                [Description("被执行群号")] string 群号, [Description("被执行对象")] string 对象QQ,
                [Description("真为不再接收，假为接收")] bool 不再接收加群请求);

            /// <summary>
            ///     获取对象当前赞数量 失败返回-1   成功返回赞数 （获取频繁会出现失败现象，请自行写判断处理失败问题）
            /// </summary>
            /// <param name="响应QQ"></param>
            /// <param name="对象QQ"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern long Api_GetObjVote([Description("")] string 响应QQ, [Description("")] string 对象QQ);

            /// <summary>
            ///     上传QQ语音，成功返回语音GUID  失败返回空
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="上传类型">2、QQ群 讨论组</param>
            /// <param name="接收群号">需上传的群号</param>
            /// <param name="语音数据">语音字节集数据（AMR Silk编码）</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_UpLoadVoice([Description("机器人QQ")] string 响应QQ,
                [Description("2、QQ群 讨论组")] int 上传类型, [Description("需上传的群号")] string 接收群号,
                [Description("语音字节集数据（AMR Silk编码）")] byte[] 语音数据);

            /// <summary>
            ///     通过语音GUID获取下载连接 失败返回空
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="语音GUID">[IR:Voi={xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxx}.amr]</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetVoiLink([Description("机器人QQ")] string 响应QQ,
                [Description("[IR:Voi={xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxx}.amr]")]
                string 语音GUID);

            /// <summary>
            ///     获取当前框架内部时间戳
            /// </summary>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern long Api_GetTimeStamp();

            /// <summary>
            ///     向腾讯发送原始封包（成功返回腾讯返回的包 失败返回空）
            /// </summary>
            /// <param name="响应QQ"></param>
            /// <param name="封包">封包内容</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_SendPack([Description("")] string 响应QQ, [Description("封包内容")] string 封包);

            /// <summary>
            ///     获取对象资料 此方式为http，调用时应自行注意控制频率（成功返回JSON格式自行解析）
            /// </summary>
            /// <param name="响应QQ"></param>
            /// <param name="对象QQ"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetObjInfo([Description("")] string 响应QQ, [Description("")] string 对象QQ);

            /// <summary>
            ///     取对象性别 1男 2女  未知或失败返回-1
            /// </summary>
            /// <param name="响应QQ"></param>
            /// <param name="对象QQ"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern int Api_GetGender([Description("")] string 响应QQ, [Description("")] string 对象QQ);

            /// <summary>
            ///     取Q龄 成功返回Q龄 失败返回-1
            /// </summary>
            /// <param name="响应QQ"></param>
            /// <param name="对象QQ"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern int Api_GetQQAge([Description("")] string 响应QQ, [Description("")] string 对象QQ);

            /// <summary>
            ///     取年龄 成功返回年龄 失败返回-1
            /// </summary>
            /// <param name="响应QQ"></param>
            /// <param name="对象QQ"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern int Api_GetAge([Description("")] string 响应QQ, [Description("")] string 对象QQ);

            /// <summary>
            ///     取个人说明
            /// </summary>
            /// <param name="响应QQ"></param>
            /// <param name="对象QQ"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetPerExp([Description("")] string 响应QQ, [Description("")] string 对象QQ);

            /// <summary>
            ///     取个人签名
            /// </summary>
            /// <param name="响应QQ"></param>
            /// <param name="对象QQ"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetSign([Description("")] string 响应QQ, [Description("")] string 对象QQ);

            /// <summary>
            ///     取邮箱，获取对象QQ资料内邮箱栏为邮箱时返回
            /// </summary>
            /// <param name="响应QQ"></param>
            /// <param name="对象QQ"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetEmail([Description("")] string 响应QQ, [Description("")] string 对象QQ);

            /// <summary>
            ///     取QQ群名
            /// </summary>
            /// <param name="响应QQ"></param>
            /// <param name="群号"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetGroupName([Description("")] string 响应QQ, [Description("")] string 群号);

            /// <summary>
            ///     取框架版本号
            /// </summary>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetVer();

            /// <summary>
            ///     取框架所有QQ号 换行符分割
            /// </summary>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetQQList();

            /// <summary>
            ///     取框架在线QQ号 换行符分割
            /// </summary>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetOnLineList();

            /// <summary>
            ///     取框架离线QQ号 （Pro版可用）换行符分割
            /// </summary>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetOffLineList();

            /// <summary>
            ///     向框架帐号列表增加一个登录QQ 成功失败均返回理由（Pro版可用）
            /// </summary>
            /// <param name="帐号"></param>
            /// <param name="密码"></param>
            /// <param name="自动登录">真 为自动登录</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_AddQQ([Description("")] string 帐号, [Description("")] string 密码,
                [Description("真 为自动登录")] bool 自动登录);

            /// <summary>
            ///     删除框架帐号列表内指定QQ，不可在执行登录过程中删除QQ否则有几率引起错误（Pro版可用）
            /// </summary>
            /// <param name="QQ号"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_DelQQ([Description("")] string QQ号);

            /// <summary>
            ///     登录指定QQ，应确保QQ号码在列表中已存在
            /// </summary>
            /// <param name="登录QQ"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern void Api_LoginQQ([Description("")] string 登录QQ);

            /// <summary>
            ///     令指定QQ下线，应确保QQ号码已在列表中且在线
            /// </summary>
            /// <param name="响应QQ"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern void Api_OffLineQQ([Description("")] string 响应QQ);

            /// <summary>
            ///     是否QQ好友 好友返回真 非好友或获取失败返回假
            /// </summary>
            /// <param name="响应QQ"></param>
            /// <param name="对象QQ"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern bool Api_IfFriend([Description("")] string 响应QQ, [Description("")] string 对象QQ);

            /// <summary>
            ///     修改机器人在线状态 昵称 个性签名 性别
            /// </summary>
            /// <param name="响应QQ"></param>
            /// <param name="类型">1、我在线上 2、Q我吧 3、离开 4、忙碌 5、请勿打扰 6、隐身 7、修改昵称 8、修改个性签名 9、修改性别</param>
            /// <param name="修改内容">类型为7和8时填写修改内容  类型9时“1”为男 “2”为女      其他填“”</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern void Api_SetRInf([Description("")] string 响应QQ,
                [Description("1、我在线上 2、Q我吧 3、离开 4、忙碌 5、请勿打扰 6、隐身 7、修改昵称 8、修改个性签名 9、修改性别")]
                int 类型, [Description("类型为7和8时填写修改内容  类型9时“1”为男 “2”为女      其他填“”")]
                string 修改内容);

            /// <summary>
            ///     获取机器人状态信息，成功返回：昵称、帐号、在线状态、速度、收信、发信、在线时间，失败返回空
            /// </summary>
            /// <param name="响应QQ"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetRInf([Description("")] string 响应QQ);

            /// <summary>
            ///     删除好友 成功返回真 失败返回假
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="对象QQ">被删除对象</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern bool Api_DelFriend([Description("机器人QQ")] string 响应QQ,
                [Description("被删除对象")] string 对象QQ);

            /// <summary>
            ///     将好友拉入黑名单  成功返回真 失败返回假
            /// </summary>
            /// <param name="响应QQ"></param>
            /// <param name="对象QQ"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern bool Api_AddBkList([Description("")] string 响应QQ, [Description("")] string 对象QQ);

            /// <summary>
            ///     解除好友黑名单
            /// </summary>
            /// <param name="响应QQ"></param>
            /// <param name="对象QQ"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern void Api_DelBkList([Description("")] string 响应QQ, [Description("")] string 对象QQ);

            /// <summary>
            ///     屏蔽或接收某群消息
            /// </summary>
            /// <param name="响应QQ"></param>
            /// <param name="群号"></param>
            /// <param name="类型">真 为屏蔽接收  假为接收并提醒</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern void Api_SetShieldedGroup([Description("")] string 响应QQ, [Description("")] string 群号,
                [Description("真 为屏蔽接收  假为接收并提醒")] bool 类型);

            /// <summary>
            ///     好友语音上传并发送 （成功返回真 失败返回假）
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="接收QQ">接收语音人QQ</param>
            /// <param name="语音数据">语音字节集数据（AMR Silk编码）</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern bool Api_SendVoice([Description("机器人QQ")] string 响应QQ,
                [Description("接收语音人QQ")] string 接收QQ, [Description("语音字节集数据（AMR Silk编码）")] byte[] 语音数据);

            /// <summary>
            ///     设置或取消群管理员   成功返回空  失败返回理由
            /// </summary>
            /// <param name="响应QQ"></param>
            /// <param name="群号"></param>
            /// <param name="对象QQ"></param>
            /// <param name="操作方式">真 为设置管理  假为取消管理</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_SetAdmin([Description("")] string 响应QQ, [Description("")] string 群号,
                [Description("")] string 对象QQ, [Description("真 为设置管理  假为取消管理")] bool 操作方式);

            /// <summary>
            ///     QQ群作业发布
            /// </summary>
            /// <param name="响应QQ"></param>
            /// <param name="群号"></param>
            /// <param name="作业名"></param>
            /// <param name="标题"></param>
            /// <param name="内容"></param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern void Api_PBHomeWork([Description("")] string 响应QQ, [Description("")] string 群号,
                [Description("")] string 作业名, [Description("")] string 标题, [Description("")] string 内容);

            /// <summary>
            ///     取框架日志
            /// </summary>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetLog();

            /// <summary>
            ///     取得插件自身启用状态，启用真 禁用假
            /// </summary>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern bool Api_IsEnable();

            /// <summary>
            ///     请求禁用插件自身
            /// </summary>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern void Api_DisabledPlugin();

            /// <summary>
            ///     消息撤回（成功返回空，失败返回腾讯给出的理由）（Pro版可用）
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="群号">需撤回消息群号</param>
            /// <param name="消息序号">需撤回消息序号</param>
            /// <param name="消息ID">需撤回消息ID</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_WithdrawMsg([Description("机器人QQ")] string 响应QQ,
                [Description("需撤回消息群号")] string 群号, [Description("需撤回消息序号")] string 消息序号,
                [Description("需撤回消息ID")] string 消息ID);

            /// <summary>
            ///     置正在输入状态（发送消息后会打断状态）
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="对象QQ">置正在输入状态接收对象</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern void Api_BeInput([Description("机器人QQ")] string 响应QQ,
                [Description("置正在输入状态接收对象")] string 对象QQ);

            /// <summary>
            ///     取对象好友添加验证方式 （00 允许任何人  01 需要身份验证  03 需回答正确问题  04 需回答问题  99 已经是好友） （Pro版可用）
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="对象QQ">需获取对象QQ</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetQQAddMode([Description("机器人QQ")] string 响应QQ,
                [Description("需获取对象QQ")] string 对象QQ);

            /// <summary>
            ///     查询对象是否在线
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="对象QQ">需获取对象QQ</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern bool Api_IsOnline([Description("机器人QQ")] string 响应QQ,
                [Description("需获取对象QQ")] string 对象QQ);

            /// <summary>
            ///     查询对象在线状态   返回 1、在线 2、Q我 3、离开 4、忙碌 5、勿扰 6、隐身或离线（Pro可用）
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="对象QQ">需获取对象QQ</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern int Api_GetOnlineState([Description("机器人QQ")] string 响应QQ,
                [Description("需获取对象QQ")] string 对象QQ);

            /// <summary>
            ///     查询对象群当前人数和上限人数
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="群号">需查询的群号</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetGroupMemberNum([Description("机器人QQ")] string 响应QQ,
                [Description("需查询的群号")] string 群号);

            /// <summary>
            ///     查询对方是否允许在线状态临时会话消息（非讨论组和群临时）（Pro版可用）
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="对象QQ">需查询的对象QQ</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern bool Api_GetWpa([Description("机器人QQ")] string 响应QQ,
                [Description("需查询的对象QQ")] string 对象QQ);

            /// <summary>
            ///     查询对象群验证方式 1允许任何人 2需要验证消息 3不允许任何人加群 4需要正确回答问题 5需要回答问题并由管理员审核 6付费群 -1群号不存在（获取失败返回空）Pro版可用
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="群号">需查询的群号</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetGroupAddMode([Description("机器人QQ")] string 响应QQ,
                [Description("需查询的群号")] string 群号);

            /// <summary>
            ///     查询QQ群等级，成功返回等级（失败返回-1）Pro版可用
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="群号">需查询的群号</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern int Api_GetGroupLv([Description("机器人QQ")] string 响应QQ,
                [Description("需查询的群号")] string 群号);

            /// <summary>
            ///     修改好友备注姓名
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="对象QQ">需获取对象好友QQ</param>
            /// <param name="备注">需要修改的备注姓名</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern void Api_SetFriendsRemark([Description("机器人QQ")] string 响应QQ,
                [Description("需获取对象好友QQ")] string 对象QQ, [Description("需要修改的备注姓名")] string 备注);

            /// <summary>
            ///     取好友备注姓名（成功返回备注，失败或无备注返回空）Pro可用
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="对象QQ">需获取对象好友QQ</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_GetFriendsRemark([Description("机器人QQ")] string 响应QQ,
                [Description("需获取对象好友QQ")] string 对象QQ);

            /// <summary>
            ///     QQ群签到（成功返回真 失败返回假）
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="群号">QQ群号</param>
            /// <param name="地名">签到地名（Pro可自定义）</param>
            /// <param name="想说的话">想发表的内容</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern bool Api_SignIn([Description("机器人QQ")] string 响应QQ, [Description("QQ群号")] string 群号,
                [Description("签到地名（Pro可自定义）")] string 地名, [Description("想发表的内容")] string 想说的话);

            /// <summary>
            ///     抽取群礼物（返回结果Json，需群聊等级LV5后）Pro可用
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_TakeGift([Description("机器人QQ")] string 响应QQ);

            /// <summary>
            ///     查询我的群礼物（返回Json格式）Pro可用
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern string Api_CheckGift([Description("机器人QQ")] string 响应QQ);

            /// <summary>
            ///     送群礼物（成功返回1 失败返回-1）Pro可用
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="群号">需送礼物群号</param>
            /// <param name="对象QQ">赠予礼物对象</param>
            /// <param name="pid">礼物pid</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern int Api_GiveGift([Description("机器人QQ")] string 响应QQ, [Description("需送礼物群号")] string 群号,
                [Description("赠予礼物对象")] string 对象QQ, [Description("礼物pid")] string pid);

            /// <summary>
            ///     查询对象或自身群聊等级（返回实际等级 失败返回-1）Pro可用
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="群号">查询群号</param>
            /// <param name="对象QQ">需查询对象或机器人QQ</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern int Api_GetGroupChatLv([Description("机器人QQ")] string 响应QQ,
                [Description("查询群号")] string 群号, [Description("需查询对象或机器人QQ")] string 对象QQ);

            /// <summary>
            ///     查询对象或自身QQ达人天数（返回实际天数 失败返回-1）Pro可用
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="对象QQ">需查询对象或机器人QQ</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern int Api_GetExpertDays([Description("机器人QQ")] string 响应QQ,
                [Description("需查询对象或机器人QQ")] string 对象QQ);

            /// <summary>
            ///     获取机器人QQ是否被屏蔽消息发送状态（真屏蔽 假未屏蔽）
            /// </summary>
            /// <param name="响应QQ">机器人QQ</param>
            /// <param name="消息类型">0在线临时会话 1好友 2群 3讨论组 4群临时会话 5讨论组临时会话 7好友验证回复会话</param>
            /// <returns></returns>
            [DllImport("IRapi.dll")]
            public static extern bool Api_GetShieldedState([Description("机器人QQ")] string 响应QQ,
                [Description("0在线临时会话 1好友 2群 3讨论组 4群临时会话 5讨论组临时会话 7好友验证回复会话")]
                int 消息类型);
        }
    }
}