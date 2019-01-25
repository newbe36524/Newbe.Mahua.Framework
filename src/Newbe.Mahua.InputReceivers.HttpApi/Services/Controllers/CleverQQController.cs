using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


// this file is generate from tools, do not change this file
// generate time 2019/01/23 

namespace Newbe.Mahua.InputReceivers.HttpApi.Services.Controllers.CleverQQ
{
    [Route("api/v1/CleverQQ")]
    public class CleverQQController : Controller
    {

        private readonly IMahuaCenter _mahuaCenter;

        public CleverQQController(
            IMahuaCenter mahuaCenter)
        {
            _mahuaCenter = mahuaCenter;
        }
        /// <summary>
        /// 发送普通文本消息
        /// </summary>
        [HttpPost("Api_SendMsg")]
        public Task Api_SendMsg([FromBody] CleverQQApi_SendMsgHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_SendMsg),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.信息类型), input.信息类型},
{nameof(input.收信对象群_讨论组), input.收信对象群_讨论组},
{nameof(input.收信QQ), input.收信QQ},
{nameof(input.内容), input.内容},
{nameof(input.气泡ID), input.气泡ID},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 发送普通文本消息
        /// </summary>
        public class CleverQQApi_SendMsgHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 0在线临时会话 1好友 2群 3讨论组 4群临时会话 5讨论组临时会话 7好友验证回复会话（0、7只支持Pro版）
            /// </summary>
            public int 信息类型 { get; set; }
            /// <summary>
            /// 发送群信息、讨论组、群或讨论组临时会话信息时填写，如发送对象为好友或信息类型是0时可空
            /// </summary>
            public string 收信对象群_讨论组 { get; set; }
            /// <summary>
            /// 收信对象QQ
            /// </summary>
            public string 收信QQ { get; set; }
            /// <summary>
            /// 信息内容
            /// </summary>
            public string 内容 { get; set; }
            /// <summary>
            /// -1为随机气泡
            /// </summary>
            public int 气泡ID { get; set; }
        }
        /// <summary>
        /// 发送XML消息
        /// </summary>
        [HttpPost("Api_SendXML")]
        public Task Api_SendXML([FromBody] CleverQQApi_SendXMLHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_SendXML),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.发送方式), input.发送方式},
{nameof(input.信息类型), input.信息类型},
{nameof(input.收信对象所属群_讨论组), input.收信对象所属群_讨论组},
{nameof(input.收信对象QQ), input.收信对象QQ},
{nameof(input.ObjectMsg), input.ObjectMsg},
{nameof(input.结构子类型), input.结构子类型},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 发送XML消息
        /// </summary>
        public class CleverQQApi_SendXMLHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 1普通 2匿名（匿名需要群开启）
            /// </summary>
            public int 发送方式 { get; set; }
            /// <summary>
            /// 0在线临时会话 1好友 2群 3讨论组 4群临时会话 5讨论组临时会话 7好友验证回复会话（0、7只支持Pro版）
            /// </summary>
            public int 信息类型 { get; set; }
            /// <summary>
            /// 发送群信息、讨论组、群或讨论组临时会话信息时填写，如发送对象为好友或信息类型是0时可空
            /// </summary>
            public string 收信对象所属群_讨论组 { get; set; }
            /// <summary>
            /// 收信对象QQ
            /// </summary>
            public string 收信对象QQ { get; set; }
            /// <summary>
            /// XML代码
            /// </summary>
            public string ObjectMsg { get; set; }
            /// <summary>
            /// 0 基本 2 点歌
            /// </summary>
            public int 结构子类型 { get; set; }
        }
        /// <summary>
        /// 发送JSON结构消息
        /// </summary>
        [HttpPost("Api_SendJSON")]
        public Task Api_SendJSON([FromBody] CleverQQApi_SendJSONHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_SendJSON),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.发送方式), input.发送方式},
{nameof(input.信息类型), input.信息类型},
{nameof(input.收信对象所属群_讨论组), input.收信对象所属群_讨论组},
{nameof(input.收信对象QQ), input.收信对象QQ},
{nameof(input.Json结构), input.Json结构},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 发送JSON结构消息
        /// </summary>
        public class CleverQQApi_SendJSONHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 1普通 2匿名（匿名需要群开启）
            /// </summary>
            public int 发送方式 { get; set; }
            /// <summary>
            /// 0在线临时会话 1好友 2群 3讨论组 4群临时会话 5讨论组临时会话 7好友验证回复会话（0、7只支持Pro版）
            /// </summary>
            public int 信息类型 { get; set; }
            /// <summary>
            /// 发送群信息、讨论组、群或讨论组临时会话信息时填，如发送对象为好友或信息类型是0时可空
            /// </summary>
            public string 收信对象所属群_讨论组 { get; set; }
            /// <summary>
            /// 收信对象QQ
            /// </summary>
            public string 收信对象QQ { get; set; }
            /// <summary>
            /// Json结构内容
            /// </summary>
            public string Json结构 { get; set; }
        }
        /// <summary>
        /// 调用一次点一下，成功返回空，失败返回理由如：每天最多给他点十个赞哦，调用此Api时应注意频率，每人每日可被赞10次，每日每Q最多可赞50人
        /// </summary>
        [HttpPost("Api_UpVote")]
        public Task Api_UpVote([FromBody] CleverQQApi_UpVoteHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_UpVote),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.被赞QQ), input.被赞QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 调用一次点一下，成功返回空，失败返回理由如：每天最多给他点十个赞哦，调用此Api时应注意频率，每人每日可被赞10次，每日每Q最多可赞50人
        /// </summary>
        public class CleverQQApi_UpVoteHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 填写被赞人QQ
            /// </summary>
            public string 被赞QQ { get; set; }
        }
        /// <summary>
        /// 取得机器人网页操作用的Cookies
        /// </summary>
        [HttpPost("Api_GetCookies")]
        public Task Api_GetCookies([FromBody] CleverQQApi_GetCookiesHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetCookies),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取得机器人网页操作用的Cookies
        /// </summary>
        public class CleverQQApi_GetCookiesHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
        }
        /// <summary>
        /// 取得腾讯微博页面操作用参数P_skey
        /// </summary>
        [HttpPost("Api_GetBlogPsKey")]
        public Task Api_GetBlogPsKey([FromBody] CleverQQApi_GetBlogPsKeyHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetBlogPsKey),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取得腾讯微博页面操作用参数P_skey
        /// </summary>
        public class CleverQQApi_GetBlogPsKeyHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
        }
        /// <summary>
        /// 取得QQ空间页面操作用参数P_skey
        /// </summary>
        [HttpPost("Api_GetZonePsKey")]
        public Task Api_GetZonePsKey([FromBody] CleverQQApi_GetZonePsKeyHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetZonePsKey),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取得QQ空间页面操作用参数P_skey
        /// </summary>
        public class CleverQQApi_GetZonePsKeyHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
        }
        /// <summary>
        /// 取得QQ群页面操作用参数P_skey
        /// </summary>
        [HttpPost("Api_GetGroupPsKey")]
        public Task Api_GetGroupPsKey([FromBody] CleverQQApi_GetGroupPsKeyHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetGroupPsKey),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取得QQ群页面操作用参数P_skey
        /// </summary>
        public class CleverQQApi_GetGroupPsKeyHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
        }
        /// <summary>
        /// 取得腾讯课堂页面操作用参数P_skey
        /// </summary>
        [HttpPost("Api_GetClassRoomPsKey")]
        public Task Api_GetClassRoomPsKey([FromBody] CleverQQApi_GetClassRoomPsKeyHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetClassRoomPsKey),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取得腾讯课堂页面操作用参数P_skey
        /// </summary>
        public class CleverQQApi_GetClassRoomPsKeyHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
        }
        /// <summary>
        /// 取得机器人网页操作用参数Bkn或G_tk
        /// </summary>
        [HttpPost("Api_GetBkn")]
        public Task Api_GetBkn([FromBody] CleverQQApi_GetBknHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetBkn),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取得机器人网页操作用参数Bkn或G_tk
        /// </summary>
        public class CleverQQApi_GetBknHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
        }
        /// <summary>
        /// 取得机器人网页操作用参数长Bkn或长G_tk
        /// </summary>
        [HttpPost("Api_GetBkn32")]
        public Task Api_GetBkn32([FromBody] CleverQQApi_GetBkn32HttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetBkn32),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取得机器人网页操作用参数长Bkn或长G_tk
        /// </summary>
        public class CleverQQApi_GetBkn32HttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
        }
        /// <summary>
        /// 取得机器人网页操作用参数长Ldw
        /// </summary>
        [HttpPost("Api_GetLongLdw")]
        public Task Api_GetLongLdw([FromBody] CleverQQApi_GetLongLdwHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetLongLdw),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取得机器人网页操作用参数长Ldw
        /// </summary>
        public class CleverQQApi_GetLongLdwHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
        }
        /// <summary>
        /// 取得机器人网页操作用的Clientkey
        /// </summary>
        [HttpPost("Api_GetClientkey")]
        public Task Api_GetClientkey([FromBody] CleverQQApi_GetClientkeyHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetClientkey),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取得机器人网页操作用的Clientkey
        /// </summary>
        public class CleverQQApi_GetClientkeyHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
        }
        /// <summary>
        /// 取得机器人网页操作用的长Clientkey
        /// </summary>
        [HttpPost("Api_GetLongClientkey")]
        public Task Api_GetLongClientkey([FromBody] CleverQQApi_GetLongClientkeyHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetLongClientkey),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取得机器人网页操作用的长Clientkey
        /// </summary>
        public class CleverQQApi_GetLongClientkeyHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
        }
        /// <summary>
        /// 管理员邀请对象入群，频率过快会失败
        /// </summary>
        [HttpPost("Api_AdminInviteGroup")]
        public Task Api_AdminInviteGroup([FromBody] CleverQQApi_AdminInviteGroupHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_AdminInviteGroup),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.对象QQ), input.对象QQ},
{nameof(input.群号), input.群号},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 管理员邀请对象入群，频率过快会失败
        /// </summary>
        public class CleverQQApi_AdminInviteGroupHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 被邀请人QQ号码（多个号码使用 #换行符 分割）
            /// </summary>
            public string 对象QQ { get; set; }
            /// <summary>
            /// 被邀请加入的群号
            /// </summary>
            public string 群号 { get; set; }
        }
        /// <summary>
        /// 非管理员邀请对象入群，频率过快会失败
        /// </summary>
        [HttpPost("Api_NoAdminInviteGroup")]
        public Task Api_NoAdminInviteGroup([FromBody] CleverQQApi_NoAdminInviteGroupHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_NoAdminInviteGroup),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.对象QQ), input.对象QQ},
{nameof(input.群号), input.群号},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 非管理员邀请对象入群，频率过快会失败
        /// </summary>
        public class CleverQQApi_NoAdminInviteGroupHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 被邀请人QQ号码（多个号码使用 #换行符 分割）
            /// </summary>
            public string 对象QQ { get; set; }
            /// <summary>
            /// 被邀请加入的群号
            /// </summary>
            public string 群号 { get; set; }
        }
        /// <summary>
        /// 取对象昵称
        /// </summary>
        [HttpPost("Api_GetNick")]
        public Task Api_GetNick([FromBody] CleverQQApi_GetNickHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetNick),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.对象QQ), input.对象QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取对象昵称
        /// </summary>
        public class CleverQQApi_GetNickHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 欲取得的QQ的号码
            /// </summary>
            public string 对象QQ { get; set; }
        }
        /// <summary>
        /// 取对象群名片
        /// </summary>
        [HttpPost("Api_GetGroupCard")]
        public Task Api_GetGroupCard([FromBody] CleverQQApi_GetGroupCardHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetGroupCard),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.群号), input.群号},
{nameof(input.对象QQ), input.对象QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取对象群名片
        /// </summary>
        public class CleverQQApi_GetGroupCardHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 群号
            /// </summary>
            public string 群号 { get; set; }
            /// <summary>
            /// 欲取得群名片的QQ号码
            /// </summary>
            public string 对象QQ { get; set; }
        }
        /// <summary>
        /// 取对象QQ等级 成功返回等级  失败返回-1
        /// </summary>
        [HttpPost("Api_GetObjLevel")]
        public Task Api_GetObjLevel([FromBody] CleverQQApi_GetObjLevelHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetObjLevel),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.对象QQ), input.对象QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取对象QQ等级 成功返回等级  失败返回-1
        /// </summary>
        public class CleverQQApi_GetObjLevelHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 欲取得的QQ的号码
            /// </summary>
            public string 对象QQ { get; set; }
        }
        /// <summary>
        /// 取得好友列表，返回获取到的原始JSON格式信息，需自行解析
        /// </summary>
        [HttpPost("Api_GetFriendList")]
        public Task Api_GetFriendList([FromBody] CleverQQApi_GetFriendListHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetFriendList),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取得好友列表，返回获取到的原始JSON格式信息，需自行解析
        /// </summary>
        public class CleverQQApi_GetFriendListHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
        }
        /// <summary>
        /// 取得好友列表，返回内容#换行符分割
        /// </summary>
        [HttpPost("Api_GetFriendList_B")]
        public Task Api_GetFriendList_B([FromBody] CleverQQApi_GetFriendList_BHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetFriendList_B),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取得好友列表，返回内容#换行符分割
        /// </summary>
        public class CleverQQApi_GetFriendList_BHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
        }
        /// <summary>
        /// 取得企点QQ外部联系人好友列表  成功返回Json列表 失败或无返回空
        /// </summary>
        [HttpPost("Api_GetQidianQQFriendsList")]
        public Task Api_GetQidianQQFriendsList([FromBody] CleverQQApi_GetQidianQQFriendsListHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetQidianQQFriendsList),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取得企点QQ外部联系人好友列表  成功返回Json列表 失败或无返回空
        /// </summary>
        public class CleverQQApi_GetQidianQQFriendsListHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
        }
        /// <summary>
        /// 取得群管理，返回获取到的原始JSON格式信息，需自行解析
        /// </summary>
        [HttpPost("Api_GetGroupAdmin")]
        public Task Api_GetGroupAdmin([FromBody] CleverQQApi_GetGroupAdminHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetGroupAdmin),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.群号), input.群号},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取得群管理，返回获取到的原始JSON格式信息，需自行解析
        /// </summary>
        public class CleverQQApi_GetGroupAdminHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 欲取管理员列表群号
            /// </summary>
            public string 群号 { get; set; }
        }
        /// <summary>
        /// 取得群列表，#换行符分割 不受最高获取500群限制（如需获取群名称请对应调用 Api_GetGroupName 理论群名获取不会频繁）
        /// </summary>
        [HttpPost("Api_GetGroupList_A")]
        public Task Api_GetGroupList_A([FromBody] CleverQQApi_GetGroupList_AHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetGroupList_A),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取得群列表，#换行符分割 不受最高获取500群限制（如需获取群名称请对应调用 Api_GetGroupName 理论群名获取不会频繁）
        /// </summary>
        public class CleverQQApi_GetGroupList_AHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
        }
        /// <summary>
        /// 取得群列表，返回获取到的原始JSON格式信息，需自行解析
        /// </summary>
        [HttpPost("Api_GetGroupList")]
        public Task Api_GetGroupList([FromBody] CleverQQApi_GetGroupListHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetGroupList),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取得群列表，返回获取到的原始JSON格式信息，需自行解析
        /// </summary>
        public class CleverQQApi_GetGroupListHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
        }
        /// <summary>
        /// 取得群列表，返回获取到的原始JSON格式信息，需自行解析
        /// </summary>
        [HttpPost("Api_GetGroupList_B")]
        public Task Api_GetGroupList_B([FromBody] CleverQQApi_GetGroupList_BHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetGroupList_B),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取得群列表，返回获取到的原始JSON格式信息，需自行解析
        /// </summary>
        public class CleverQQApi_GetGroupList_BHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
        }
        /// <summary>
        /// 取得群成员列表，返回获取到的原始JSON格式信息，需自行解析（有群员昵称）
        /// </summary>
        [HttpPost("Api_GetGroupMemberList")]
        public Task Api_GetGroupMemberList([FromBody] CleverQQApi_GetGroupMemberListHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetGroupMemberList),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.群号), input.群号},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取得群成员列表，返回获取到的原始JSON格式信息，需自行解析（有群员昵称）
        /// </summary>
        public class CleverQQApi_GetGroupMemberListHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 欲取群成员列表群号
            /// </summary>
            public string 群号 { get; set; }
        }
        /// <summary>
        /// 取得群成员列表，返回QQ号和身份Json格式信息 失败返回空（无群员昵称）
        /// </summary>
        [HttpPost("Api_GetGroupMemberList_B")]
        public Task Api_GetGroupMemberList_B([FromBody] CleverQQApi_GetGroupMemberList_BHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetGroupMemberList_B),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.群号), input.群号},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取得群成员列表，返回QQ号和身份Json格式信息 失败返回空（无群员昵称）
        /// </summary>
        public class CleverQQApi_GetGroupMemberList_BHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 欲取群成员列表群号
            /// </summary>
            public string 群号 { get; set; }
        }
        /// <summary>
        /// 取得群成员列表，返回获取到的原始JSON格式信息，需自行解析（有群员昵称）
        /// </summary>
        [HttpPost("Api_GetGroupMemberList_C")]
        public Task Api_GetGroupMemberList_C([FromBody] CleverQQApi_GetGroupMemberList_CHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetGroupMemberList_C),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.群号), input.群号},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取得群成员列表，返回获取到的原始JSON格式信息，需自行解析（有群员昵称）
        /// </summary>
        public class CleverQQApi_GetGroupMemberList_CHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 欲取群成员列表群号
            /// </summary>
            public string 群号 { get; set; }
        }
        /// <summary>
        /// 查询对象或自己是否被禁言  禁言返回真 失败或未禁言返回假
        /// </summary>
        [HttpPost("Api_IsShutUp")]
        public Task Api_IsShutUp([FromBody] CleverQQApi_IsShutUpHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_IsShutUp),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.群号), input.群号},
{nameof(input.对象QQ), input.对象QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 查询对象或自己是否被禁言  禁言返回真 失败或未禁言返回假
        /// </summary>
        public class CleverQQApi_IsShutUpHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 欲查询的群号
            /// </summary>
            public string 群号 { get; set; }
            /// <summary>
            /// 需要查询的对象QQ
            /// </summary>
            public string 对象QQ { get; set; }
        }
        /// <summary>
        /// 群内禁言某人
        /// </summary>
        [HttpPost("Api_ShutUP")]
        public Task Api_ShutUP([FromBody] CleverQQApi_ShutUPHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_ShutUP),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.群号), input.群号},
{nameof(input.对象QQ), input.对象QQ},
{nameof(input.时间), input.时间},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 群内禁言某人
        /// </summary>
        public class CleverQQApi_ShutUPHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 欲操作的群号
            /// </summary>
            public string 群号 { get; set; }
            /// <summary>
            /// 欲禁言的对象，如留空且机器人QQ为管理员，将设置该群为全群禁言
            /// </summary>
            public string 对象QQ { get; set; }
            /// <summary>
            /// 0为解除禁言 （禁言单位为秒），如为全群禁言，参数为非0，解除全群禁言为0
            /// </summary>
            public int 时间 { get; set; }
        }
        /// <summary>
        /// 申请加群
        /// </summary>
        [HttpPost("Api_JoinGroup")]
        public Task Api_JoinGroup([FromBody] CleverQQApi_JoinGroupHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_JoinGroup),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.群号), input.群号},
{nameof(input.理由), input.理由},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 申请加群
        /// </summary>
        public class CleverQQApi_JoinGroupHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 欲申请加入的群号
            /// </summary>
            public string 群号 { get; set; }
            /// <summary>
            /// 附加理由，可留空（需回答正确问题时，请填写问题答案）
            /// </summary>
            public string 理由 { get; set; }
        }
        /// <summary>
        /// 退群
        /// </summary>
        [HttpPost("Api_QuitGroup")]
        public Task Api_QuitGroup([FromBody] CleverQQApi_QuitGroupHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_QuitGroup),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.群号), input.群号},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 退群
        /// </summary>
        public class CleverQQApi_QuitGroupHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 欲退出的群号
            /// </summary>
            public string 群号 { get; set; }
        }
        /// <summary>
        /// 上传图片（通过读入字节集方式），可使用网页链接或本地读入，成功返回该图片GUID，失败返回空
        /// </summary>
        [HttpPost("Api_UpLoadPic")]
        public Task Api_UpLoadPic([FromBody] CleverQQApi_UpLoadPicHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_UpLoadPic),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.上传类型), input.上传类型},
{nameof(input.参考对象), input.参考对象},
{nameof(input.图片数据), input.图片数据},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 上传图片（通过读入字节集方式），可使用网页链接或本地读入，成功返回该图片GUID，失败返回空
        /// </summary>
        public class CleverQQApi_UpLoadPicHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 1好友、临时会话  2群、讨论组 Ps：好友临时会话用类型 1，群讨论组用类型 2；当填写错误时，图片GUID发送不会成功
            /// </summary>
            public int 上传类型 { get; set; }
            /// <summary>
            /// 上传该图片所属的群号或QQ
            /// </summary>
            public string 参考对象 { get; set; }
            /// <summary>
            /// 图片字节集数据
            /// </summary>
            public string 图片数据 { get; set; }
        }
        /// <summary>
        /// 根据图片GUID取得图片下载连接
        /// </summary>
        [HttpPost("Api_GetPicLink")]
        public Task Api_GetPicLink([FromBody] CleverQQApi_GetPicLinkHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetPicLink),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.图片类型), input.图片类型},
{nameof(input.参考对象), input.参考对象},
{nameof(input.图片GUID), input.图片GUID},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 根据图片GUID取得图片下载连接
        /// </summary>
        public class CleverQQApi_GetPicLinkHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 1 群 讨论组  2临时会话和好友
            /// </summary>
            public int 图片类型 { get; set; }
            /// <summary>
            /// 图片所属对应的群号和好友QQ（可随意乱填写）
            /// </summary>
            public string 参考对象 { get; set; }
            /// <summary>
            /// 例如[IR:pic={xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx}.jpg]
            /// </summary>
            public string 图片GUID { get; set; }
        }
        /// <summary>
        /// 向CleverQQ日志窗口发送一条本插件的日志，可用于调试输出需要的内容，或定位插件错误与运行状态
        /// </summary>
        [HttpPost("Api_OutPutLog")]
        public Task Api_OutPutLog([FromBody] CleverQQApi_OutPutLogHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_OutPutLog),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.内容), input.内容},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 向CleverQQ日志窗口发送一条本插件的日志，可用于调试输出需要的内容，或定位插件错误与运行状态
        /// </summary>
        public class CleverQQApi_OutPutLogHttpInput
        {
            /// <summary>
            /// 任意想输出的文本格式信息
            /// </summary>
            public string 内容 { get; set; }
        }
        /// <summary>
        /// 腾讯Tea加密
        /// </summary>
        [HttpPost("Api_Tea加密")]
        public Task Api_Tea加密([FromBody] CleverQQApi_Tea加密HttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_Tea加密),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.需加密内容), input.需加密内容},
{nameof(input.会话KEY), input.会话KEY},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 腾讯Tea加密
        /// </summary>
        public class CleverQQApi_Tea加密HttpInput
        {
            /// <summary>
            /// 需加密的内容
            /// </summary>
            public string 需加密内容 { get; set; }
            /// <summary>
            /// 这里填Api_SessionKey
            /// </summary>
            public string 会话KEY { get; set; }
        }
        /// <summary>
        /// 腾讯Tea解密
        /// </summary>
        [HttpPost("Api_Tea解密")]
        public Task Api_Tea解密([FromBody] CleverQQApi_Tea解密HttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_Tea解密),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.需解密内容), input.需解密内容},
{nameof(input.会话KEY), input.会话KEY},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 腾讯Tea解密
        /// </summary>
        public class CleverQQApi_Tea解密HttpInput
        {
            /// <summary>
            /// 需解密的内容
            /// </summary>
            public string 需解密内容 { get; set; }
            /// <summary>
            /// 这里填Api_SessionKey
            /// </summary>
            public string 会话KEY { get; set; }
        }
        /// <summary>
        /// 获取会话SessionKey密钥
        /// </summary>
        [HttpPost("Api_SessionKey")]
        public Task Api_SessionKey([FromBody] CleverQQApi_SessionKeyHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_SessionKey),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 获取会话SessionKey密钥
        /// </summary>
        public class CleverQQApi_SessionKeyHttpInput
        {
            /// <summary>
            /// 欲获取的QQ
            /// </summary>
            public string 响应QQ { get; set; }
        }
        /// <summary>
        /// 群号转群ID
        /// </summary>
        [HttpPost("Api_GNTransGID")]
        public Task Api_GNTransGID([FromBody] CleverQQApi_GNTransGIDHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GNTransGID),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.群号), input.群号},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 群号转群ID
        /// </summary>
        public class CleverQQApi_GNTransGIDHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 群号 { get; set; }
        }
        /// <summary>
        /// 群ID转群号
        /// </summary>
        [HttpPost("Api_GIDTransGN")]
        public Task Api_GIDTransGN([FromBody] CleverQQApi_GIDTransGNHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GIDTransGN),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.群ID), input.群ID},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 群ID转群号
        /// </summary>
        public class CleverQQApi_GIDTransGNHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 群ID { get; set; }
        }
        /// <summary>
        /// 发布群公告（成功返回真，失败返回假），调用此API应保证响应QQ为管理员
        /// </summary>
        [HttpPost("Api_PBGroupNotic")]
        public Task Api_PBGroupNotic([FromBody] CleverQQApi_PBGroupNoticHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_PBGroupNotic),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.群号), input.群号},
{nameof(input.标题), input.标题},
{nameof(input.内容), input.内容},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 发布群公告（成功返回真，失败返回假），调用此API应保证响应QQ为管理员
        /// </summary>
        public class CleverQQApi_PBGroupNoticHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 欲发布公告的群号
            /// </summary>
            public string 群号 { get; set; }
            /// <summary>
            /// 公告标题
            /// </summary>
            public string 标题 { get; set; }
            /// <summary>
            /// 公告内容
            /// </summary>
            public string 内容 { get; set; }
        }
        /// <summary>
        /// 取群公告，返回该群最新公告
        /// </summary>
        [HttpPost("Api_GetNotice")]
        public Task Api_GetNotice([FromBody] CleverQQApi_GetNoticeHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetNotice),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.群号), input.群号},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取群公告，返回该群最新公告
        /// </summary>
        public class CleverQQApi_GetNoticeHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 欲取得公告的群号
            /// </summary>
            public string 群号 { get; set; }
        }
        /// <summary>
        /// 向好友发起窗口抖动，调用此Api腾讯会限制频率
        /// </summary>
        [HttpPost("Api_ShakeWindow")]
        public Task Api_ShakeWindow([FromBody] CleverQQApi_ShakeWindowHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_ShakeWindow),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.接收QQ), input.接收QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 向好友发起窗口抖动，调用此Api腾讯会限制频率
        /// </summary>
        public class CleverQQApi_ShakeWindowHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 接收抖动消息的QQ
            /// </summary>
            public string 接收QQ { get; set; }
        }
        /// <summary>
        /// 某人申请入群 添加好友 被邀请入群 请求处理
        /// </summary>
        [HttpPost("Api_HandleEvent")]
        public Task Api_HandleEvent([FromBody] CleverQQApi_HandleEventHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_HandleEvent),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.请求类型), input.请求类型},
{nameof(input.对象QQ), input.对象QQ},
{nameof(input.群号), input.群号},
{nameof(input.处理方式), input.处理方式},
{nameof(input.附加信息), input.附加信息},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 某人申请入群 添加好友 被邀请入群 请求处理
        /// </summary>
        public class CleverQQApi_HandleEventHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 213请求入群  214我被邀请加入某群  215某人被邀请加入群  101某人请求添加好友
            /// </summary>
            public int 请求类型 { get; set; }
            /// <summary>
            /// 申请入群 被邀请人 请求添加好友人的QQ （当请求类型为214时这里为邀请人QQ）
            /// </summary>
            public string 对象QQ { get; set; }
            /// <summary>
            /// 收到请求群号（好友添加时这里请为空）
            /// </summary>
            public string 群号 { get; set; }
            /// <summary>
            /// 10同意 20拒绝 30忽略
            /// </summary>
            public int 处理方式 { get; set; }
            /// <summary>
            /// 拒绝入群，拒绝添加好友 附加信息
            /// </summary>
            public string 附加信息 { get; set; }
        }
        /// <summary>
        /// 处理群验证事件 第二模式（新手建议使用Api_HandleEvent） Pro可用
        /// </summary>
        [HttpPost("Api_HandleGroupEvent")]
        public Task Api_HandleGroupEvent([FromBody] CleverQQApi_HandleGroupEventHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_HandleGroupEvent),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.请求类型), input.请求类型},
{nameof(input.对象QQ), input.对象QQ},
{nameof(input.群号), input.群号},
{nameof(input.seq), input.seq},
{nameof(input.处理方式), input.处理方式},
{nameof(input.附加信息), input.附加信息},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 处理群验证事件 第二模式（新手建议使用Api_HandleEvent） Pro可用
        /// </summary>
        public class CleverQQApi_HandleGroupEventHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 213请求入群  214我被邀请加入某群  215某人被邀请加入群  101某人请求添加好友
            /// </summary>
            public int 请求类型 { get; set; }
            /// <summary>
            /// 申请入群 被邀请人 请求添加好友人的QQ （当请求类型为214时这里为邀请人QQ）
            /// </summary>
            public string 对象QQ { get; set; }
            /// <summary>
            /// 收到请求群号（好友添加时这里请为空）
            /// </summary>
            public string 群号 { get; set; }
            /// <summary>
            /// 需要处理事件的seq （好友事件留空）
            /// </summary>
            public string seq { get; set; }
            /// <summary>
            /// 10同意 20拒绝 30忽略
            /// </summary>
            public int 处理方式 { get; set; }
            /// <summary>
            /// 拒绝入群，拒绝添加好友 附加信息
            /// </summary>
            public string 附加信息 { get; set; }
        }
        /// <summary>
        /// 开关群匿名消息发送功能    成功返回真  失败返回假
        /// </summary>
        [HttpPost("Api_SetAnon")]
        public Task Api_SetAnon([FromBody] CleverQQApi_SetAnonHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_SetAnon),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.群号), input.群号},
{nameof(input.开关), input.开关},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 开关群匿名消息发送功能    成功返回真  失败返回假
        /// </summary>
        public class CleverQQApi_SetAnonHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 需开关群匿名功能群号
            /// </summary>
            public string 群号 { get; set; }
            /// <summary>
            /// 真开    假关
            /// </summary>
            public bool 开关 { get; set; }
        }
        /// <summary>
        /// 修改对象群名片 成功返回真 失败返回假
        /// </summary>
        [HttpPost("Api_SetGroupCard")]
        public Task Api_SetGroupCard([FromBody] CleverQQApi_SetGroupCardHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_SetGroupCard),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.群号), input.群号},
{nameof(input.对象QQ), input.对象QQ},
{nameof(input.名片), input.名片},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 修改对象群名片 成功返回真 失败返回假
        /// </summary>
        public class CleverQQApi_SetGroupCardHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 对象所处群号
            /// </summary>
            public string 群号 { get; set; }
            /// <summary>
            /// 被修改名片人QQ
            /// </summary>
            public string 对象QQ { get; set; }
            /// <summary>
            /// 需要修改的名片
            /// </summary>
            public string 名片 { get; set; }
        }
        /// <summary>
        /// 退出讨论组
        /// </summary>
        [HttpPost("Api_QuitDisGroup")]
        public Task Api_QuitDisGroup([FromBody] CleverQQApi_QuitDisGroupHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_QuitDisGroup),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.讨论组ID), input.讨论组ID},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 退出讨论组
        /// </summary>
        public class CleverQQApi_QuitDisGroupHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 需退出的讨论组ID
            /// </summary>
            public string 讨论组ID { get; set; }
        }
        /// <summary>
        /// 创建一个讨论组 成功返回讨论组ID 失败返回空
        /// </summary>
        [HttpPost("Api_CreateDisGroup")]
        public Task Api_CreateDisGroup([FromBody] CleverQQApi_CreateDisGroupHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_CreateDisGroup),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.讨论组名称), input.讨论组名称},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 创建一个讨论组 成功返回讨论组ID 失败返回空
        /// </summary>
        public class CleverQQApi_CreateDisGroupHttpInput
        {
            /// <summary>
            /// 机器人
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 建立的讨论组名称
            /// </summary>
            public string 讨论组名称 { get; set; }
        }
        /// <summary>
        /// 将对象移除讨论组 成功返回空 失败返回理由
        /// </summary>
        [HttpPost("Api_KickDisGroupMBR")]
        public Task Api_KickDisGroupMBR([FromBody] CleverQQApi_KickDisGroupMBRHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_KickDisGroupMBR),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.讨论组ID), input.讨论组ID},
{nameof(input.对象QQ), input.对象QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 将对象移除讨论组 成功返回空 失败返回理由
        /// </summary>
        public class CleverQQApi_KickDisGroupMBRHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 需执行的讨论组ID
            /// </summary>
            public string 讨论组ID { get; set; }
            /// <summary>
            /// 被执行对象
            /// </summary>
            public string 对象QQ { get; set; }
        }
        /// <summary>
        /// 邀请对象加入讨论组 成功返回空 失败返回理由
        /// </summary>
        [HttpPost("Api_InviteDisGroup")]
        public Task Api_InviteDisGroup([FromBody] CleverQQApi_InviteDisGroupHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_InviteDisGroup),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.讨论组ID), input.讨论组ID},
{nameof(input.邀请对象QQ), input.邀请对象QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 邀请对象加入讨论组 成功返回空 失败返回理由
        /// </summary>
        public class CleverQQApi_InviteDisGroupHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 需执行的讨论组ID
            /// </summary>
            public string 讨论组ID { get; set; }
            /// <summary>
            /// 被邀请对象QQ 多个用  #换行符 分割
            /// </summary>
            public string 邀请对象QQ { get; set; }
        }
        /// <summary>
        /// 取出讨论组列表 （返回格式为 换行符分割开的）
        /// </summary>
        [HttpPost("Api_GetDisGroupList")]
        public Task Api_GetDisGroupList([FromBody] CleverQQApi_GetDisGroupListHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetDisGroupList),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取出讨论组列表 （返回格式为 换行符分割开的）
        /// </summary>
        public class CleverQQApi_GetDisGroupListHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
        }
        /// <summary>
        /// 取出讨论组成员列表 （返回格式为 换行符分割开的）
        /// </summary>
        [HttpPost("Api_GetDisGroupMemberList")]
        public Task Api_GetDisGroupMemberList([FromBody] CleverQQApi_GetDisGroupMemberListHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetDisGroupMemberList),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.讨论组ID), input.讨论组ID},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取出讨论组成员列表 （返回格式为 换行符分割开的）
        /// </summary>
        public class CleverQQApi_GetDisGroupMemberListHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 需获取的讨论组ID
            /// </summary>
            public string 讨论组ID { get; set; }
        }
        /// <summary>
        /// 修改讨论组名称
        /// </summary>
        [HttpPost("Api_SetDisGroupName")]
        public Task Api_SetDisGroupName([FromBody] CleverQQApi_SetDisGroupNameHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_SetDisGroupName),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.讨论组ID), input.讨论组ID},
{nameof(input.讨论组名称), input.讨论组名称},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 修改讨论组名称
        /// </summary>
        public class CleverQQApi_SetDisGroupNameHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 需执行的讨论组ID
            /// </summary>
            public string 讨论组ID { get; set; }
            /// <summary>
            /// 需修改的名称
            /// </summary>
            public string 讨论组名称 { get; set; }
        }
        /// <summary>
        /// 将对象移除群
        /// </summary>
        [HttpPost("Api_KickGroupMBR")]
        public Task Api_KickGroupMBR([FromBody] CleverQQApi_KickGroupMBRHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_KickGroupMBR),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.群号), input.群号},
{nameof(input.对象QQ), input.对象QQ},
{nameof(input.不再接收加群请求), input.不再接收加群请求},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 将对象移除群
        /// </summary>
        public class CleverQQApi_KickGroupMBRHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 被执行群号
            /// </summary>
            public string 群号 { get; set; }
            /// <summary>
            /// 被执行对象
            /// </summary>
            public string 对象QQ { get; set; }
            /// <summary>
            /// 真为不再接收，假为接收
            /// </summary>
            public bool 不再接收加群请求 { get; set; }
        }
        /// <summary>
        /// 获取对象当前赞数量 失败返回-1   成功返回赞数 （获取频繁会出现失败现象，请自行写判断处理失败问题）
        /// </summary>
        [HttpPost("Api_GetObjVote")]
        public Task Api_GetObjVote([FromBody] CleverQQApi_GetObjVoteHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetObjVote),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.对象QQ), input.对象QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 获取对象当前赞数量 失败返回-1   成功返回赞数 （获取频繁会出现失败现象，请自行写判断处理失败问题）
        /// </summary>
        public class CleverQQApi_GetObjVoteHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 对象QQ { get; set; }
        }
        /// <summary>
        /// 上传QQ语音，成功返回语音GUID  失败返回空
        /// </summary>
        [HttpPost("Api_UpLoadVoice")]
        public Task Api_UpLoadVoice([FromBody] CleverQQApi_UpLoadVoiceHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_UpLoadVoice),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.上传类型), input.上传类型},
{nameof(input.接收群号), input.接收群号},
{nameof(input.语音数据), input.语音数据},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 上传QQ语音，成功返回语音GUID  失败返回空
        /// </summary>
        public class CleverQQApi_UpLoadVoiceHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 2、QQ群 讨论组
            /// </summary>
            public int 上传类型 { get; set; }
            /// <summary>
            /// 需上传的群号
            /// </summary>
            public string 接收群号 { get; set; }
            /// <summary>
            /// 语音字节集数据（AMR Silk编码）
            /// </summary>
            public string 语音数据 { get; set; }
        }
        /// <summary>
        /// 通过语音GUID获取下载连接 失败返回空
        /// </summary>
        [HttpPost("Api_GetVoiLink")]
        public Task Api_GetVoiLink([FromBody] CleverQQApi_GetVoiLinkHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetVoiLink),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.语音GUID), input.语音GUID},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 通过语音GUID获取下载连接 失败返回空
        /// </summary>
        public class CleverQQApi_GetVoiLinkHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// [IR:Voi={xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxx}.amr]
            /// </summary>
            public string 语音GUID { get; set; }
        }
        /// <summary>
        /// 获取当前框架内部时间戳
        /// </summary>
        [HttpPost("Api_GetTimeStamp")]
        public Task Api_GetTimeStamp([FromBody] CleverQQApi_GetTimeStampHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetTimeStamp),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
                {
                }
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 获取当前框架内部时间戳
        /// </summary>
        public class CleverQQApi_GetTimeStampHttpInput
        {
        }
        /// <summary>
        /// 向腾讯发送原始封包（成功返回腾讯返回的包 失败返回空）
        /// </summary>
        [HttpPost("Api_SendPack")]
        public Task Api_SendPack([FromBody] CleverQQApi_SendPackHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_SendPack),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.封包), input.封包},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 向腾讯发送原始封包（成功返回腾讯返回的包 失败返回空）
        /// </summary>
        public class CleverQQApi_SendPackHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 封包内容
            /// </summary>
            public string 封包 { get; set; }
        }
        /// <summary>
        /// 获取对象资料 此方式为http，调用时应自行注意控制频率（成功返回JSON格式自行解析）
        /// </summary>
        [HttpPost("Api_GetObjInfo")]
        public Task Api_GetObjInfo([FromBody] CleverQQApi_GetObjInfoHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetObjInfo),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.对象QQ), input.对象QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 获取对象资料 此方式为http，调用时应自行注意控制频率（成功返回JSON格式自行解析）
        /// </summary>
        public class CleverQQApi_GetObjInfoHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 对象QQ { get; set; }
        }
        /// <summary>
        /// 取对象性别 1男 2女  未知或失败返回-1
        /// </summary>
        [HttpPost("Api_GetGender")]
        public Task Api_GetGender([FromBody] CleverQQApi_GetGenderHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetGender),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.对象QQ), input.对象QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取对象性别 1男 2女  未知或失败返回-1
        /// </summary>
        public class CleverQQApi_GetGenderHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 对象QQ { get; set; }
        }
        /// <summary>
        /// 取Q龄 成功返回Q龄 失败返回-1
        /// </summary>
        [HttpPost("Api_GetQQAge")]
        public Task Api_GetQQAge([FromBody] CleverQQApi_GetQQAgeHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetQQAge),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.对象QQ), input.对象QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取Q龄 成功返回Q龄 失败返回-1
        /// </summary>
        public class CleverQQApi_GetQQAgeHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 对象QQ { get; set; }
        }
        /// <summary>
        /// 取年龄 成功返回年龄 失败返回-1
        /// </summary>
        [HttpPost("Api_GetAge")]
        public Task Api_GetAge([FromBody] CleverQQApi_GetAgeHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetAge),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.对象QQ), input.对象QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取年龄 成功返回年龄 失败返回-1
        /// </summary>
        public class CleverQQApi_GetAgeHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 对象QQ { get; set; }
        }
        /// <summary>
        /// 取个人说明
        /// </summary>
        [HttpPost("Api_GetPerExp")]
        public Task Api_GetPerExp([FromBody] CleverQQApi_GetPerExpHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetPerExp),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.对象QQ), input.对象QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取个人说明
        /// </summary>
        public class CleverQQApi_GetPerExpHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 对象QQ { get; set; }
        }
        /// <summary>
        /// 取个人签名
        /// </summary>
        [HttpPost("Api_GetSign")]
        public Task Api_GetSign([FromBody] CleverQQApi_GetSignHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetSign),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.对象QQ), input.对象QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取个人签名
        /// </summary>
        public class CleverQQApi_GetSignHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 对象QQ { get; set; }
        }
        /// <summary>
        /// 取邮箱，获取对象QQ资料内邮箱栏为邮箱时返回
        /// </summary>
        [HttpPost("Api_GetEmail")]
        public Task Api_GetEmail([FromBody] CleverQQApi_GetEmailHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetEmail),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.对象QQ), input.对象QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取邮箱，获取对象QQ资料内邮箱栏为邮箱时返回
        /// </summary>
        public class CleverQQApi_GetEmailHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 对象QQ { get; set; }
        }
        /// <summary>
        /// 取QQ群名
        /// </summary>
        [HttpPost("Api_GetGroupName")]
        public Task Api_GetGroupName([FromBody] CleverQQApi_GetGroupNameHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetGroupName),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.群号), input.群号},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取QQ群名
        /// </summary>
        public class CleverQQApi_GetGroupNameHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 群号 { get; set; }
        }
        /// <summary>
        /// 取框架版本号
        /// </summary>
        [HttpPost("Api_GetVer")]
        public Task Api_GetVer([FromBody] CleverQQApi_GetVerHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetVer),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
                {
                }
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取框架版本号
        /// </summary>
        public class CleverQQApi_GetVerHttpInput
        {
        }
        /// <summary>
        /// 取框架所有QQ号 换行符分割
        /// </summary>
        [HttpPost("Api_GetQQList")]
        public Task Api_GetQQList([FromBody] CleverQQApi_GetQQListHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetQQList),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
                {
                }
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取框架所有QQ号 换行符分割
        /// </summary>
        public class CleverQQApi_GetQQListHttpInput
        {
        }
        /// <summary>
        /// 取框架在线QQ号 换行符分割
        /// </summary>
        [HttpPost("Api_GetOnLineList")]
        public Task Api_GetOnLineList([FromBody] CleverQQApi_GetOnLineListHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetOnLineList),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
                {
                }
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取框架在线QQ号 换行符分割
        /// </summary>
        public class CleverQQApi_GetOnLineListHttpInput
        {
        }
        /// <summary>
        /// 取框架离线QQ号 （Pro版可用）换行符分割
        /// </summary>
        [HttpPost("Api_GetOffLineList")]
        public Task Api_GetOffLineList([FromBody] CleverQQApi_GetOffLineListHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetOffLineList),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
                {
                }
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取框架离线QQ号 （Pro版可用）换行符分割
        /// </summary>
        public class CleverQQApi_GetOffLineListHttpInput
        {
        }
        /// <summary>
        /// 向框架帐号列表增加一个登录QQ 成功失败均返回理由（Pro版可用）
        /// </summary>
        [HttpPost("Api_AddQQ")]
        public Task Api_AddQQ([FromBody] CleverQQApi_AddQQHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_AddQQ),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.帐号), input.帐号},
{nameof(input.密码), input.密码},
{nameof(input.自动登录), input.自动登录},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 向框架帐号列表增加一个登录QQ 成功失败均返回理由（Pro版可用）
        /// </summary>
        public class CleverQQApi_AddQQHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 帐号 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 密码 { get; set; }
            /// <summary>
            /// 真 为自动登录
            /// </summary>
            public bool 自动登录 { get; set; }
        }
        /// <summary>
        /// 删除框架帐号列表内指定QQ，不可在执行登录过程中删除QQ否则有几率引起错误（Pro版可用）
        /// </summary>
        [HttpPost("Api_DelQQ")]
        public Task Api_DelQQ([FromBody] CleverQQApi_DelQQHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_DelQQ),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.QQ号), input.QQ号},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 删除框架帐号列表内指定QQ，不可在执行登录过程中删除QQ否则有几率引起错误（Pro版可用）
        /// </summary>
        public class CleverQQApi_DelQQHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string QQ号 { get; set; }
        }
        /// <summary>
        /// 登录指定QQ，应确保QQ号码在列表中已存在
        /// </summary>
        [HttpPost("Api_LoginQQ")]
        public Task Api_LoginQQ([FromBody] CleverQQApi_LoginQQHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_LoginQQ),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.登录QQ), input.登录QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 登录指定QQ，应确保QQ号码在列表中已存在
        /// </summary>
        public class CleverQQApi_LoginQQHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 登录QQ { get; set; }
        }
        /// <summary>
        /// 令指定QQ下线，应确保QQ号码已在列表中且在线
        /// </summary>
        [HttpPost("Api_OffLineQQ")]
        public Task Api_OffLineQQ([FromBody] CleverQQApi_OffLineQQHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_OffLineQQ),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 令指定QQ下线，应确保QQ号码已在列表中且在线
        /// </summary>
        public class CleverQQApi_OffLineQQHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应QQ { get; set; }
        }
        /// <summary>
        /// 是否QQ好友 好友返回真 非好友或获取失败返回假
        /// </summary>
        [HttpPost("Api_IfFriend")]
        public Task Api_IfFriend([FromBody] CleverQQApi_IfFriendHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_IfFriend),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.对象QQ), input.对象QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 是否QQ好友 好友返回真 非好友或获取失败返回假
        /// </summary>
        public class CleverQQApi_IfFriendHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 对象QQ { get; set; }
        }
        /// <summary>
        /// 修改机器人在线状态 昵称 个性签名 性别
        /// </summary>
        [HttpPost("Api_SetRInf")]
        public Task Api_SetRInf([FromBody] CleverQQApi_SetRInfHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_SetRInf),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.类型), input.类型},
{nameof(input.修改内容), input.修改内容},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 修改机器人在线状态 昵称 个性签名 性别
        /// </summary>
        public class CleverQQApi_SetRInfHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 1、我在线上 2、Q我吧 3、离开 4、忙碌 5、请勿打扰 6、隐身 7、修改昵称 8、修改个性签名 9、修改性别
            /// </summary>
            public int 类型 { get; set; }
            /// <summary>
            /// 类型为7和8时填写修改内容  类型9时“1”为男 “2”为女      其他填“”
            /// </summary>
            public string 修改内容 { get; set; }
        }
        /// <summary>
        /// 获取机器人状态信息，成功返回：昵称、帐号、在线状态、速度、收信、发信、在线时间，失败返回空
        /// </summary>
        [HttpPost("Api_GetRInf")]
        public Task Api_GetRInf([FromBody] CleverQQApi_GetRInfHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetRInf),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 获取机器人状态信息，成功返回：昵称、帐号、在线状态、速度、收信、发信、在线时间，失败返回空
        /// </summary>
        public class CleverQQApi_GetRInfHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应QQ { get; set; }
        }
        /// <summary>
        /// 删除好友 成功返回真 失败返回假
        /// </summary>
        [HttpPost("Api_DelFriend")]
        public Task Api_DelFriend([FromBody] CleverQQApi_DelFriendHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_DelFriend),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.对象QQ), input.对象QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 删除好友 成功返回真 失败返回假
        /// </summary>
        public class CleverQQApi_DelFriendHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 被删除对象
            /// </summary>
            public string 对象QQ { get; set; }
        }
        /// <summary>
        /// 将好友拉入黑名单  成功返回真 失败返回假
        /// </summary>
        [HttpPost("Api_AddBkList")]
        public Task Api_AddBkList([FromBody] CleverQQApi_AddBkListHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_AddBkList),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.对象QQ), input.对象QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 将好友拉入黑名单  成功返回真 失败返回假
        /// </summary>
        public class CleverQQApi_AddBkListHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 对象QQ { get; set; }
        }
        /// <summary>
        /// 解除好友黑名单
        /// </summary>
        [HttpPost("Api_DelBkList")]
        public Task Api_DelBkList([FromBody] CleverQQApi_DelBkListHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_DelBkList),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.对象QQ), input.对象QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 解除好友黑名单
        /// </summary>
        public class CleverQQApi_DelBkListHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 对象QQ { get; set; }
        }
        /// <summary>
        /// 屏蔽或接收某群消息
        /// </summary>
        [HttpPost("Api_SetShieldedGroup")]
        public Task Api_SetShieldedGroup([FromBody] CleverQQApi_SetShieldedGroupHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_SetShieldedGroup),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.群号), input.群号},
{nameof(input.类型), input.类型},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 屏蔽或接收某群消息
        /// </summary>
        public class CleverQQApi_SetShieldedGroupHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 群号 { get; set; }
            /// <summary>
            /// 真 为屏蔽接收  假为接收并提醒
            /// </summary>
            public bool 类型 { get; set; }
        }
        /// <summary>
        /// 好友语音上传并发送 （成功返回真 失败返回假）
        /// </summary>
        [HttpPost("Api_SendVoice")]
        public Task Api_SendVoice([FromBody] CleverQQApi_SendVoiceHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_SendVoice),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.接收QQ), input.接收QQ},
{nameof(input.语音数据), input.语音数据},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 好友语音上传并发送 （成功返回真 失败返回假）
        /// </summary>
        public class CleverQQApi_SendVoiceHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 接收语音人QQ
            /// </summary>
            public string 接收QQ { get; set; }
            /// <summary>
            /// 语音字节集数据（AMR Silk编码）
            /// </summary>
            public string 语音数据 { get; set; }
        }
        /// <summary>
        /// 设置或取消群管理员   成功返回空  失败返回理由
        /// </summary>
        [HttpPost("Api_SetAdmin")]
        public Task Api_SetAdmin([FromBody] CleverQQApi_SetAdminHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_SetAdmin),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.群号), input.群号},
{nameof(input.对象QQ), input.对象QQ},
{nameof(input.操作方式), input.操作方式},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 设置或取消群管理员   成功返回空  失败返回理由
        /// </summary>
        public class CleverQQApi_SetAdminHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 群号 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 对象QQ { get; set; }
            /// <summary>
            /// 真 为设置管理  假为取消管理
            /// </summary>
            public bool 操作方式 { get; set; }
        }
        /// <summary>
        /// QQ群作业发布
        /// </summary>
        [HttpPost("Api_PBHomeWork")]
        public Task Api_PBHomeWork([FromBody] CleverQQApi_PBHomeWorkHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_PBHomeWork),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.群号), input.群号},
{nameof(input.作业名), input.作业名},
{nameof(input.标题), input.标题},
{nameof(input.内容), input.内容},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// QQ群作业发布
        /// </summary>
        public class CleverQQApi_PBHomeWorkHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 群号 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 作业名 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 标题 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 内容 { get; set; }
        }
        /// <summary>
        /// 取框架日志
        /// </summary>
        [HttpPost("Api_GetLog")]
        public Task Api_GetLog([FromBody] CleverQQApi_GetLogHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetLog),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
                {
                }
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取框架日志
        /// </summary>
        public class CleverQQApi_GetLogHttpInput
        {
        }
        /// <summary>
        /// 取得插件自身启用状态，启用真 禁用假
        /// </summary>
        [HttpPost("Api_IsEnable")]
        public Task Api_IsEnable([FromBody] CleverQQApi_IsEnableHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_IsEnable),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
                {
                }
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取得插件自身启用状态，启用真 禁用假
        /// </summary>
        public class CleverQQApi_IsEnableHttpInput
        {
        }
        /// <summary>
        /// 请求禁用插件自身
        /// </summary>
        [HttpPost("Api_DisabledPlugin")]
        public Task Api_DisabledPlugin([FromBody] CleverQQApi_DisabledPluginHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_DisabledPlugin),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
                {
                }
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 请求禁用插件自身
        /// </summary>
        public class CleverQQApi_DisabledPluginHttpInput
        {
        }
        /// <summary>
        /// 消息撤回（成功返回空，失败返回腾讯给出的理由）（Pro版可用）
        /// </summary>
        [HttpPost("Api_WithdrawMsg")]
        public Task Api_WithdrawMsg([FromBody] CleverQQApi_WithdrawMsgHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_WithdrawMsg),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.群号), input.群号},
{nameof(input.消息序号), input.消息序号},
{nameof(input.消息ID), input.消息ID},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 消息撤回（成功返回空，失败返回腾讯给出的理由）（Pro版可用）
        /// </summary>
        public class CleverQQApi_WithdrawMsgHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 需撤回消息群号
            /// </summary>
            public string 群号 { get; set; }
            /// <summary>
            /// 需撤回消息序号
            /// </summary>
            public string 消息序号 { get; set; }
            /// <summary>
            /// 需撤回消息ID
            /// </summary>
            public string 消息ID { get; set; }
        }
        /// <summary>
        /// 置正在输入状态（发送消息后会打断状态）
        /// </summary>
        [HttpPost("Api_BeInput")]
        public Task Api_BeInput([FromBody] CleverQQApi_BeInputHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_BeInput),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.对象QQ), input.对象QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 置正在输入状态（发送消息后会打断状态）
        /// </summary>
        public class CleverQQApi_BeInputHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 置正在输入状态接收对象
            /// </summary>
            public string 对象QQ { get; set; }
        }
        /// <summary>
        /// 取对象好友添加验证方式 （00 允许任何人  01 需要身份验证  03 需回答正确问题  04 需回答问题  99 已经是好友） （Pro版可用）
        /// </summary>
        [HttpPost("Api_GetQQAddMode")]
        public Task Api_GetQQAddMode([FromBody] CleverQQApi_GetQQAddModeHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetQQAddMode),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.对象QQ), input.对象QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取对象好友添加验证方式 （00 允许任何人  01 需要身份验证  03 需回答正确问题  04 需回答问题  99 已经是好友） （Pro版可用）
        /// </summary>
        public class CleverQQApi_GetQQAddModeHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 需获取对象QQ
            /// </summary>
            public string 对象QQ { get; set; }
        }
        /// <summary>
        /// 查询对象是否在线
        /// </summary>
        [HttpPost("Api_IsOnline")]
        public Task Api_IsOnline([FromBody] CleverQQApi_IsOnlineHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_IsOnline),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.对象QQ), input.对象QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 查询对象是否在线
        /// </summary>
        public class CleverQQApi_IsOnlineHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 需获取对象QQ
            /// </summary>
            public string 对象QQ { get; set; }
        }
        /// <summary>
        /// 查询对象在线状态   返回 1、在线 2、Q我 3、离开 4、忙碌 5、勿扰 6、隐身或离线（Pro可用）
        /// </summary>
        [HttpPost("Api_GetOnlineState")]
        public Task Api_GetOnlineState([FromBody] CleverQQApi_GetOnlineStateHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetOnlineState),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.对象QQ), input.对象QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 查询对象在线状态   返回 1、在线 2、Q我 3、离开 4、忙碌 5、勿扰 6、隐身或离线（Pro可用）
        /// </summary>
        public class CleverQQApi_GetOnlineStateHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 需获取对象QQ
            /// </summary>
            public string 对象QQ { get; set; }
        }
        /// <summary>
        /// 查询对象群当前人数和上限人数
        /// </summary>
        [HttpPost("Api_GetGroupMemberNum")]
        public Task Api_GetGroupMemberNum([FromBody] CleverQQApi_GetGroupMemberNumHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetGroupMemberNum),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.群号), input.群号},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 查询对象群当前人数和上限人数
        /// </summary>
        public class CleverQQApi_GetGroupMemberNumHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 需查询的群号
            /// </summary>
            public string 群号 { get; set; }
        }
        /// <summary>
        /// 查询对方是否允许在线状态临时会话消息（非讨论组和群临时）（Pro版可用）
        /// </summary>
        [HttpPost("Api_GetWpa")]
        public Task Api_GetWpa([FromBody] CleverQQApi_GetWpaHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetWpa),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.对象QQ), input.对象QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 查询对方是否允许在线状态临时会话消息（非讨论组和群临时）（Pro版可用）
        /// </summary>
        public class CleverQQApi_GetWpaHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 需查询的对象QQ
            /// </summary>
            public string 对象QQ { get; set; }
        }
        /// <summary>
        /// 查询对象群验证方式 1允许任何人 2需要验证消息 3不允许任何人加群 4需要正确回答问题 5需要回答问题并由管理员审核 6付费群 -1群号不存在（获取失败返回空）Pro版可用
        /// </summary>
        [HttpPost("Api_GetGroupAddMode")]
        public Task Api_GetGroupAddMode([FromBody] CleverQQApi_GetGroupAddModeHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetGroupAddMode),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.群号), input.群号},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 查询对象群验证方式 1允许任何人 2需要验证消息 3不允许任何人加群 4需要正确回答问题 5需要回答问题并由管理员审核 6付费群 -1群号不存在（获取失败返回空）Pro版可用
        /// </summary>
        public class CleverQQApi_GetGroupAddModeHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 需查询的群号
            /// </summary>
            public string 群号 { get; set; }
        }
        /// <summary>
        /// 查询QQ群等级，成功返回等级（失败返回-1）Pro版可用
        /// </summary>
        [HttpPost("Api_GetGroupLv")]
        public Task Api_GetGroupLv([FromBody] CleverQQApi_GetGroupLvHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetGroupLv),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.群号), input.群号},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 查询QQ群等级，成功返回等级（失败返回-1）Pro版可用
        /// </summary>
        public class CleverQQApi_GetGroupLvHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 需查询的群号
            /// </summary>
            public string 群号 { get; set; }
        }
        /// <summary>
        /// 修改好友备注姓名
        /// </summary>
        [HttpPost("Api_SetFriendsRemark")]
        public Task Api_SetFriendsRemark([FromBody] CleverQQApi_SetFriendsRemarkHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_SetFriendsRemark),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.对象QQ), input.对象QQ},
{nameof(input.备注), input.备注},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 修改好友备注姓名
        /// </summary>
        public class CleverQQApi_SetFriendsRemarkHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 需获取对象好友QQ
            /// </summary>
            public string 对象QQ { get; set; }
            /// <summary>
            /// 需要修改的备注姓名
            /// </summary>
            public string 备注 { get; set; }
        }
        /// <summary>
        /// 取好友备注姓名（成功返回备注，失败或无备注返回空）Pro可用
        /// </summary>
        [HttpPost("Api_GetFriendsRemark")]
        public Task Api_GetFriendsRemark([FromBody] CleverQQApi_GetFriendsRemarkHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetFriendsRemark),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.对象QQ), input.对象QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取好友备注姓名（成功返回备注，失败或无备注返回空）Pro可用
        /// </summary>
        public class CleverQQApi_GetFriendsRemarkHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 需获取对象好友QQ
            /// </summary>
            public string 对象QQ { get; set; }
        }
        /// <summary>
        /// QQ群签到（成功返回真 失败返回假）
        /// </summary>
        [HttpPost("Api_SignIn")]
        public Task Api_SignIn([FromBody] CleverQQApi_SignInHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_SignIn),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.群号), input.群号},
{nameof(input.地名), input.地名},
{nameof(input.想说的话), input.想说的话},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// QQ群签到（成功返回真 失败返回假）
        /// </summary>
        public class CleverQQApi_SignInHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// QQ群号
            /// </summary>
            public string 群号 { get; set; }
            /// <summary>
            /// 签到地名（Pro可自定义）
            /// </summary>
            public string 地名 { get; set; }
            /// <summary>
            /// 想发表的内容
            /// </summary>
            public string 想说的话 { get; set; }
        }
        /// <summary>
        /// 抽取群礼物（返回结果Json，需群聊等级LV5后）Pro可用
        /// </summary>
        [HttpPost("Api_TakeGift")]
        public Task Api_TakeGift([FromBody] CleverQQApi_TakeGiftHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_TakeGift),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 抽取群礼物（返回结果Json，需群聊等级LV5后）Pro可用
        /// </summary>
        public class CleverQQApi_TakeGiftHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
        }
        /// <summary>
        /// 查询我的群礼物（返回Json格式）Pro可用
        /// </summary>
        [HttpPost("Api_CheckGift")]
        public Task Api_CheckGift([FromBody] CleverQQApi_CheckGiftHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_CheckGift),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 查询我的群礼物（返回Json格式）Pro可用
        /// </summary>
        public class CleverQQApi_CheckGiftHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
        }
        /// <summary>
        /// 送群礼物（成功返回1 失败返回-1）Pro可用
        /// </summary>
        [HttpPost("Api_GiveGift")]
        public Task Api_GiveGift([FromBody] CleverQQApi_GiveGiftHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GiveGift),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.群号), input.群号},
{nameof(input.对象QQ), input.对象QQ},
{nameof(input.pid), input.pid},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 送群礼物（成功返回1 失败返回-1）Pro可用
        /// </summary>
        public class CleverQQApi_GiveGiftHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 需送礼物群号
            /// </summary>
            public string 群号 { get; set; }
            /// <summary>
            /// 赠予礼物对象
            /// </summary>
            public string 对象QQ { get; set; }
            /// <summary>
            /// 礼物pid
            /// </summary>
            public string pid { get; set; }
        }
        /// <summary>
        /// 查询对象或自身群聊等级（返回实际等级 失败返回-1）Pro可用
        /// </summary>
        [HttpPost("Api_GetGroupChatLv")]
        public Task Api_GetGroupChatLv([FromBody] CleverQQApi_GetGroupChatLvHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetGroupChatLv),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.群号), input.群号},
{nameof(input.对象QQ), input.对象QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 查询对象或自身群聊等级（返回实际等级 失败返回-1）Pro可用
        /// </summary>
        public class CleverQQApi_GetGroupChatLvHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 查询群号
            /// </summary>
            public string 群号 { get; set; }
            /// <summary>
            /// 需查询对象或机器人QQ
            /// </summary>
            public string 对象QQ { get; set; }
        }
        /// <summary>
        /// 查询对象或自身QQ达人天数（返回实际天数 失败返回-1）Pro可用
        /// </summary>
        [HttpPost("Api_GetExpertDays")]
        public Task Api_GetExpertDays([FromBody] CleverQQApi_GetExpertDaysHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetExpertDays),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.对象QQ), input.对象QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 查询对象或自身QQ达人天数（返回实际天数 失败返回-1）Pro可用
        /// </summary>
        public class CleverQQApi_GetExpertDaysHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 需查询对象或机器人QQ
            /// </summary>
            public string 对象QQ { get; set; }
        }
        /// <summary>
        /// 获取机器人QQ是否被屏蔽消息发送状态（真屏蔽 假未屏蔽）
        /// </summary>
        [HttpPost("Api_GetShieldedState")]
        public Task Api_GetShieldedState([FromBody] CleverQQApi_GetShieldedStateHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetShieldedState),
                MahuaPlatform = MahuaPlatform.CleverQQ,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应QQ), input.响应QQ},
{nameof(input.消息类型), input.消息类型},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 获取机器人QQ是否被屏蔽消息发送状态（真屏蔽 假未屏蔽）
        /// </summary>
        public class CleverQQApi_GetShieldedStateHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应QQ { get; set; }
            /// <summary>
            /// 0在线临时会话 1好友 2群 3讨论组 4群临时会话 5讨论组临时会话 7好友验证回复会话
            /// </summary>
            public int 消息类型 { get; set; }
        }
    }
}
