using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


// this file is generate from tools, do not change this file
// generate time 2019/12/15 

namespace Newbe.Mahua.InputReceivers.HttpApi.Services.Controllers.Cqp
{
    [Route("api/v1/Cqp")]
    public class CqpController : Controller
    {

        private readonly IMahuaCenter _mahuaCenter;

        public CqpController(
            IMahuaCenter mahuaCenter)
        {
            _mahuaCenter = mahuaCenter;
        }
        /// <summary>
        /// 发送好友消息
        /// </summary>
        [HttpPost("CQ_sendPrivateMsg")]
        public Task CQ_sendPrivateMsg([FromBody] CqpCQ_sendPrivateMsgHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(CQ_sendPrivateMsg),
                MahuaPlatform = MahuaPlatform.Cqp,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.Account), input.Account},
{nameof(input.msg), input.msg},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 发送好友消息
        /// </summary>
        public class CqpCQ_sendPrivateMsgHttpInput
        {
            /// <summary>
            /// 目标帐号
            /// </summary>
            public long Account { get; set; }
            /// <summary>
            /// 消息内容
            /// </summary>
            public string msg { get; set; }
        }
        /// <summary>
        /// 发送群消息
        /// </summary>
        [HttpPost("CQ_sendGroupMsg")]
        public Task CQ_sendGroupMsg([FromBody] CqpCQ_sendGroupMsgHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(CQ_sendGroupMsg),
                MahuaPlatform = MahuaPlatform.Cqp,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.群号), input.群号},
{nameof(input.msg), input.msg},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 发送群消息
        /// </summary>
        public class CqpCQ_sendGroupMsgHttpInput
        {
            /// <summary>
            /// 目标群
            /// </summary>
            public long 群号 { get; set; }
            /// <summary>
            /// 消息内容
            /// </summary>
            public string msg { get; set; }
        }
        /// <summary>
        /// 发送讨论组消息
        /// </summary>
        [HttpPost("CQ_sendDiscussMsg")]
        public Task CQ_sendDiscussMsg([FromBody] CqpCQ_sendDiscussMsgHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(CQ_sendDiscussMsg),
                MahuaPlatform = MahuaPlatform.Cqp,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.讨论组号), input.讨论组号},
{nameof(input.msg), input.msg},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 发送讨论组消息
        /// </summary>
        public class CqpCQ_sendDiscussMsgHttpInput
        {
            /// <summary>
            /// 目标讨论组
            /// </summary>
            public long 讨论组号 { get; set; }
            /// <summary>
            /// 消息内容
            /// </summary>
            public string msg { get; set; }
        }
        /// <summary>
        /// 撤回消息
        /// </summary>
        [HttpPost("CQ_deleteMsg")]
        public Task CQ_deleteMsg([FromBody] CqpCQ_deleteMsgHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(CQ_deleteMsg),
                MahuaPlatform = MahuaPlatform.Cqp,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.MsgId), input.MsgId},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 撤回消息
        /// </summary>
        public class CqpCQ_deleteMsgHttpInput
        {
            /// <summary>
            /// 消息ID
            /// </summary>
            public long MsgId { get; set; }
        }
        /// <summary>
        /// 发送赞
        /// </summary>
        [HttpPost("CQ_sendLikeV2")]
        public Task CQ_sendLikeV2([FromBody] CqpCQ_sendLikeV2HttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(CQ_sendLikeV2),
                MahuaPlatform = MahuaPlatform.Cqp,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.Account), input.Account},
{nameof(input.times), input.times},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 发送赞
        /// </summary>
        public class CqpCQ_sendLikeV2HttpInput
        {
            /// <summary>
            /// 目标帐号
            /// </summary>
            public long Account { get; set; }
            /// <summary>
            /// 赞的次数，最多10次
            /// </summary>
            public int times { get; set; }
        }
        /// <summary>
        /// 取Cookies(慎用
        /// </summary>
        [HttpPost("CQ_getCookiesV2")]
        public Task CQ_getCookiesV2([FromBody] CqpCQ_getCookiesV2HttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(CQ_getCookiesV2),
                MahuaPlatform = MahuaPlatform.Cqp,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.domain), input.domain},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取Cookies(慎用
        /// </summary>
        public class CqpCQ_getCookiesV2HttpInput
        {
            /// <summary>
            /// 目标域名，如 api.example.com
            /// </summary>
            public string domain { get; set; }
        }
        /// <summary>
        /// 【已弃用】接收语音，并返回语音文件相对路径
        /// </summary>
        [HttpPost("CQ_getRecord")]
        public Task CQ_getRecord([FromBody] CqpCQ_getRecordHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(CQ_getRecord),
                MahuaPlatform = MahuaPlatform.Cqp,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.file), input.file},
{nameof(input.outformat), input.outformat},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 【已弃用】接收语音，并返回语音文件相对路径
        /// </summary>
        public class CqpCQ_getRecordHttpInput
        {
            /// <summary>
            /// 收到消息中的语音文件名(file)
            /// </summary>
            public string file { get; set; }
            /// <summary>
            /// 应用所需的格式
            /// </summary>
            public string outformat { get; set; }
        }
        /// <summary>
        /// 接收语音，并返回语音文件绝对路径
        /// </summary>
        [HttpPost("CQ_getRecordV2")]
        public Task CQ_getRecordV2([FromBody] CqpCQ_getRecordV2HttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(CQ_getRecordV2),
                MahuaPlatform = MahuaPlatform.Cqp,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.file), input.file},
{nameof(input.outformat), input.outformat},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 接收语音，并返回语音文件绝对路径
        /// </summary>
        public class CqpCQ_getRecordV2HttpInput
        {
            /// <summary>
            /// 收到消息中的语音文件名(file)
            /// </summary>
            public string file { get; set; }
            /// <summary>
            /// 应用所需的格式
            /// </summary>
            public string outformat { get; set; }
        }
        /// <summary>
        /// 接收图片，并返回图片文件绝对路径
        /// </summary>
        [HttpPost("CQ_getImage")]
        public Task CQ_getImage([FromBody] CqpCQ_getImageHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(CQ_getImage),
                MahuaPlatform = MahuaPlatform.Cqp,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.file), input.file},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 接收图片，并返回图片文件绝对路径
        /// </summary>
        public class CqpCQ_getImageHttpInput
        {
            /// <summary>
            /// 收到消息中的图片文件名(file)
            /// </summary>
            public string file { get; set; }
        }
        /// <summary>
        /// 是否支持发送图片，返回大于 0 为支持，等于 0 为不支持
        /// </summary>
        [HttpPost("CQ_canSendImage")]
        public Task CQ_canSendImage([FromBody] CqpCQ_canSendImageHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(CQ_canSendImage),
                MahuaPlatform = MahuaPlatform.Cqp,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
                {
                }
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 是否支持发送图片，返回大于 0 为支持，等于 0 为不支持
        /// </summary>
        public class CqpCQ_canSendImageHttpInput
        {
        }
        /// <summary>
        /// 是否支持发送语音，返回大于 0 为支持，等于 0 为不支持
        /// </summary>
        [HttpPost("CQ_canSendRecord")]
        public Task CQ_canSendRecord([FromBody] CqpCQ_canSendRecordHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(CQ_canSendRecord),
                MahuaPlatform = MahuaPlatform.Cqp,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
                {
                }
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 是否支持发送语音，返回大于 0 为支持，等于 0 为不支持
        /// </summary>
        public class CqpCQ_canSendRecordHttpInput
        {
        }
        /// <summary>
        /// 取CsrfToken(慎用
        /// </summary>
        [HttpPost("CQ_getCsrfToken")]
        public Task CQ_getCsrfToken([FromBody] CqpCQ_getCsrfTokenHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(CQ_getCsrfToken),
                MahuaPlatform = MahuaPlatform.Cqp,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
                {
                }
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取CsrfToken(慎用
        /// </summary>
        public class CqpCQ_getCsrfTokenHttpInput
        {
        }
        /// <summary>
        /// 取应用目录
        /// </summary>
        [HttpPost("CQ_getAppDirectory")]
        public Task CQ_getAppDirectory([FromBody] CqpCQ_getAppDirectoryHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(CQ_getAppDirectory),
                MahuaPlatform = MahuaPlatform.Cqp,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
                {
                }
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取应用目录
        /// </summary>
        public class CqpCQ_getAppDirectoryHttpInput
        {
        }
        /// <summary>
        /// 取登录帐号
        /// </summary>
        [HttpPost("CQ_getLoginQQ")]
        public Task CQ_getLoginQQ([FromBody] CqpCQ_getLoginQQHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(CQ_getLoginQQ),
                MahuaPlatform = MahuaPlatform.Cqp,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
                {
                }
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取登录帐号
        /// </summary>
        public class CqpCQ_getLoginQQHttpInput
        {
        }
        /// <summary>
        /// 取登录昵称
        /// </summary>
        [HttpPost("CQ_getLoginNick")]
        public Task CQ_getLoginNick([FromBody] CqpCQ_getLoginNickHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(CQ_getLoginNick),
                MahuaPlatform = MahuaPlatform.Cqp,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
                {
                }
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取登录昵称
        /// </summary>
        public class CqpCQ_getLoginNickHttpInput
        {
        }
        /// <summary>
        /// 置群员移除
        /// </summary>
        [HttpPost("CQ_setGroupKick")]
        public Task CQ_setGroupKick([FromBody] CqpCQ_setGroupKickHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(CQ_setGroupKick),
                MahuaPlatform = MahuaPlatform.Cqp,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.群号), input.群号},
{nameof(input.Account), input.Account},
{nameof(input.拒绝再加群), input.拒绝再加群},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 置群员移除
        /// </summary>
        public class CqpCQ_setGroupKickHttpInput
        {
            /// <summary>
            /// 目标群
            /// </summary>
            public long 群号 { get; set; }
            /// <summary>
            /// 目标帐号
            /// </summary>
            public long Account { get; set; }
            /// <summary>
            /// 如果为真，则“不再接收此人加群申请”，请慎用
            /// </summary>
            public bool 拒绝再加群 { get; set; }
        }
        /// <summary>
        /// 置群员禁言
        /// </summary>
        [HttpPost("CQ_setGroupBan")]
        public Task CQ_setGroupBan([FromBody] CqpCQ_setGroupBanHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(CQ_setGroupBan),
                MahuaPlatform = MahuaPlatform.Cqp,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.群号), input.群号},
{nameof(input.Account), input.Account},
{nameof(input.禁言时间), input.禁言时间},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 置群员禁言
        /// </summary>
        public class CqpCQ_setGroupBanHttpInput
        {
            /// <summary>
            /// 目标群
            /// </summary>
            public long 群号 { get; set; }
            /// <summary>
            /// 目标帐号
            /// </summary>
            public long Account { get; set; }
            /// <summary>
            /// 禁言的时间，单位为秒。如果要解禁，这里填写0
            /// </summary>
            public long 禁言时间 { get; set; }
        }
        /// <summary>
        /// 置群管理员
        /// </summary>
        [HttpPost("CQ_setGroupAdmin")]
        public Task CQ_setGroupAdmin([FromBody] CqpCQ_setGroupAdminHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(CQ_setGroupAdmin),
                MahuaPlatform = MahuaPlatform.Cqp,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.群号), input.群号},
{nameof(input.Account), input.Account},
{nameof(input.成为管理员), input.成为管理员},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 置群管理员
        /// </summary>
        public class CqpCQ_setGroupAdminHttpInput
        {
            /// <summary>
            /// 目标群
            /// </summary>
            public long 群号 { get; set; }
            /// <summary>
            /// 被设置的帐号
            /// </summary>
            public long Account { get; set; }
            /// <summary>
            /// 真/设置管理员 假/取消管理员
            /// </summary>
            public bool 成为管理员 { get; set; }
        }
        /// <summary>
        /// 置群成员专属头衔
        /// </summary>
        [HttpPost("CQ_setGroupSpecialTitle")]
        public Task CQ_setGroupSpecialTitle([FromBody] CqpCQ_setGroupSpecialTitleHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(CQ_setGroupSpecialTitle),
                MahuaPlatform = MahuaPlatform.Cqp,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.群号), input.群号},
{nameof(input.Account), input.Account},
{nameof(input.头衔), input.头衔},
{nameof(input.过期时间), input.过期时间},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 置群成员专属头衔
        /// </summary>
        public class CqpCQ_setGroupSpecialTitleHttpInput
        {
            /// <summary>
            /// 目标群
            /// </summary>
            public long 群号 { get; set; }
            /// <summary>
            /// 目标帐号
            /// </summary>
            public long Account { get; set; }
            /// <summary>
            /// 如果要删除，这里填空
            /// </summary>
            public string 头衔 { get; set; }
            /// <summary>
            /// 专属头衔有效期，单位为秒。如果永久有效，这里填写-1
            /// </summary>
            public long 过期时间 { get; set; }
        }
        /// <summary>
        /// 置全群禁言
        /// </summary>
        [HttpPost("CQ_setGroupWholeBan")]
        public Task CQ_setGroupWholeBan([FromBody] CqpCQ_setGroupWholeBanHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(CQ_setGroupWholeBan),
                MahuaPlatform = MahuaPlatform.Cqp,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.群号), input.群号},
{nameof(input.开启禁言), input.开启禁言},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 置全群禁言
        /// </summary>
        public class CqpCQ_setGroupWholeBanHttpInput
        {
            /// <summary>
            /// 目标群
            /// </summary>
            public long 群号 { get; set; }
            /// <summary>
            /// 真/开启 假/关闭
            /// </summary>
            public bool 开启禁言 { get; set; }
        }
        /// <summary>
        /// 置匿名群员禁言
        /// </summary>
        [HttpPost("CQ_setGroupAnonymousBan")]
        public Task CQ_setGroupAnonymousBan([FromBody] CqpCQ_setGroupAnonymousBanHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(CQ_setGroupAnonymousBan),
                MahuaPlatform = MahuaPlatform.Cqp,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.群号), input.群号},
{nameof(input.匿名), input.匿名},
{nameof(input.禁言时间), input.禁言时间},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 置匿名群员禁言
        /// </summary>
        public class CqpCQ_setGroupAnonymousBanHttpInput
        {
            /// <summary>
            /// 目标群
            /// </summary>
            public long 群号 { get; set; }
            /// <summary>
            /// 群消息事件收到的“匿名”参数
            /// </summary>
            public string 匿名 { get; set; }
            /// <summary>
            /// 禁言的时间，单位为秒。不支持解禁
            /// </summary>
            public long 禁言时间 { get; set; }
        }
        /// <summary>
        /// 置群匿名设置
        /// </summary>
        [HttpPost("CQ_setGroupAnonymous")]
        public Task CQ_setGroupAnonymous([FromBody] CqpCQ_setGroupAnonymousHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(CQ_setGroupAnonymous),
                MahuaPlatform = MahuaPlatform.Cqp,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.群号), input.群号},
{nameof(input.开启匿名), input.开启匿名},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 置群匿名设置
        /// </summary>
        public class CqpCQ_setGroupAnonymousHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public long 群号 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public bool 开启匿名 { get; set; }
        }
        /// <summary>
        /// 置群成员名片
        /// </summary>
        [HttpPost("CQ_setGroupCard")]
        public Task CQ_setGroupCard([FromBody] CqpCQ_setGroupCardHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(CQ_setGroupCard),
                MahuaPlatform = MahuaPlatform.Cqp,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.群号), input.群号},
{nameof(input.Account), input.Account},
{nameof(input.新名片_昵称), input.新名片_昵称},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 置群成员名片
        /// </summary>
        public class CqpCQ_setGroupCardHttpInput
        {
            /// <summary>
            /// 目标群
            /// </summary>
            public long 群号 { get; set; }
            /// <summary>
            /// 被设置的帐号
            /// </summary>
            public long Account { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 新名片_昵称 { get; set; }
        }
        /// <summary>
        /// 置群退出
        /// </summary>
        [HttpPost("CQ_setGroupLeave")]
        public Task CQ_setGroupLeave([FromBody] CqpCQ_setGroupLeaveHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(CQ_setGroupLeave),
                MahuaPlatform = MahuaPlatform.Cqp,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.群号), input.群号},
{nameof(input.是否解散), input.是否解散},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 置群退出
        /// </summary>
        public class CqpCQ_setGroupLeaveHttpInput
        {
            /// <summary>
            /// 目标群
            /// </summary>
            public long 群号 { get; set; }
            /// <summary>
            /// 真/解散本群(群主) 假/退出本群(管理、群成员)
            /// </summary>
            public bool 是否解散 { get; set; }
        }
        /// <summary>
        /// 置讨论组退出
        /// </summary>
        [HttpPost("CQ_setDiscussLeave")]
        public Task CQ_setDiscussLeave([FromBody] CqpCQ_setDiscussLeaveHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(CQ_setDiscussLeave),
                MahuaPlatform = MahuaPlatform.Cqp,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.讨论组号), input.讨论组号},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 置讨论组退出
        /// </summary>
        public class CqpCQ_setDiscussLeaveHttpInput
        {
            /// <summary>
            /// 目标讨论组
            /// </summary>
            public long 讨论组号 { get; set; }
        }
        /// <summary>
        /// 置好友添加请求
        /// </summary>
        [HttpPost("CQ_setFriendAddRequest")]
        public Task CQ_setFriendAddRequest([FromBody] CqpCQ_setFriendAddRequestHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(CQ_setFriendAddRequest),
                MahuaPlatform = MahuaPlatform.Cqp,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.请求反馈标识), input.请求反馈标识},
{nameof(input.反馈类型), input.反馈类型},
{nameof(input.备注), input.备注},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 置好友添加请求
        /// </summary>
        public class CqpCQ_setFriendAddRequestHttpInput
        {
            /// <summary>
            /// 请求事件收到的“反馈标识”参数
            /// </summary>
            public string 请求反馈标识 { get; set; }
            /// <summary>
            /// #请求_通过 或 #请求_拒绝
            /// </summary>
            public int 反馈类型 { get; set; }
            /// <summary>
            /// 添加后的好友备注
            /// </summary>
            public string 备注 { get; set; }
        }
        /// <summary>
        /// 置群添加请求
        /// </summary>
        [HttpPost("CQ_setGroupAddRequestV2")]
        public Task CQ_setGroupAddRequestV2([FromBody] CqpCQ_setGroupAddRequestV2HttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(CQ_setGroupAddRequestV2),
                MahuaPlatform = MahuaPlatform.Cqp,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.请求反馈标识), input.请求反馈标识},
{nameof(input.请求类型), input.请求类型},
{nameof(input.反馈类型), input.反馈类型},
{nameof(input.理由), input.理由},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 置群添加请求
        /// </summary>
        public class CqpCQ_setGroupAddRequestV2HttpInput
        {
            /// <summary>
            /// 请求事件收到的“反馈标识”参数
            /// </summary>
            public string 请求反馈标识 { get; set; }
            /// <summary>
            /// 根据请求事件的子类型区分 #请求_群添加 或 #请求_群邀请
            /// </summary>
            public int 请求类型 { get; set; }
            /// <summary>
            /// #请求_通过 或 #请求_拒绝
            /// </summary>
            public int 反馈类型 { get; set; }
            /// <summary>
            /// 操作理由，仅 #请求_群添加 且 #请求_拒绝 时可用
            /// </summary>
            public string 理由 { get; set; }
        }
        /// <summary>
        /// 增加运行日志
        /// </summary>
        [HttpPost("CQ_addLog")]
        public Task CQ_addLog([FromBody] CqpCQ_addLogHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(CQ_addLog),
                MahuaPlatform = MahuaPlatform.Cqp,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.优先级), input.优先级},
{nameof(input.类型), input.类型},
{nameof(input.内容), input.内容},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 增加运行日志
        /// </summary>
        public class CqpCQ_addLogHttpInput
        {
            /// <summary>
            /// #Log_ 开头常量
            /// </summary>
            public int 优先级 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 类型 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 内容 { get; set; }
        }
        /// <summary>
        /// 置致命错误提示
        /// </summary>
        [HttpPost("CQ_setFatal")]
        public Task CQ_setFatal([FromBody] CqpCQ_setFatalHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(CQ_setFatal),
                MahuaPlatform = MahuaPlatform.Cqp,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.错误信息), input.错误信息},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 置致命错误提示
        /// </summary>
        public class CqpCQ_setFatalHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 错误信息 { get; set; }
        }
        /// <summary>
        /// 取群成员信息(支持缓存)
        /// </summary>
        [HttpPost("CQ_getGroupMemberInfoV2")]
        public Task CQ_getGroupMemberInfoV2([FromBody] CqpCQ_getGroupMemberInfoV2HttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(CQ_getGroupMemberInfoV2),
                MahuaPlatform = MahuaPlatform.Cqp,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.群号), input.群号},
{nameof(input.Account), input.Account},
{nameof(input.不使用缓存), input.不使用缓存},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取群成员信息(支持缓存)
        /// </summary>
        public class CqpCQ_getGroupMemberInfoV2HttpInput
        {
            /// <summary>
            /// 目标帐号所在群
            /// </summary>
            public long 群号 { get; set; }
            /// <summary>
            /// 目标帐号
            /// </summary>
            public long Account { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public bool 不使用缓存 { get; set; }
        }
        /// <summary>
        /// 取群成员列表
        /// </summary>
        [HttpPost("CQ_getGroupMemberList")]
        public Task CQ_getGroupMemberList([FromBody] CqpCQ_getGroupMemberListHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(CQ_getGroupMemberList),
                MahuaPlatform = MahuaPlatform.Cqp,
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
        /// 取群成员列表
        /// </summary>
        public class CqpCQ_getGroupMemberListHttpInput
        {
            /// <summary>
            /// 目标帐号所在群
            /// </summary>
            public long 群号 { get; set; }
        }
        /// <summary>
        /// 取群列表
        /// </summary>
        [HttpPost("CQ_getGroupList")]
        public Task CQ_getGroupList([FromBody] CqpCQ_getGroupListHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(CQ_getGroupList),
                MahuaPlatform = MahuaPlatform.Cqp,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
                {
                }
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取群列表
        /// </summary>
        public class CqpCQ_getGroupListHttpInput
        {
        }
        /// <summary>
        /// 取好友列表
        /// </summary>
        [HttpPost("CQ_getFriendList")]
        public Task CQ_getFriendList([FromBody] CqpCQ_getFriendListHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(CQ_getFriendList),
                MahuaPlatform = MahuaPlatform.Cqp,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.reserved), input.reserved},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取好友列表
        /// </summary>
        public class CqpCQ_getFriendListHttpInput
        {
            /// <summary>
            /// 保留参数，请传入“假”
            /// </summary>
            public bool reserved { get; set; }
        }
        /// <summary>
        /// 取陌生人信息(支持缓存)
        /// </summary>
        [HttpPost("CQ_getStrangerInfo")]
        public Task CQ_getStrangerInfo([FromBody] CqpCQ_getStrangerInfoHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(CQ_getStrangerInfo),
                MahuaPlatform = MahuaPlatform.Cqp,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.Account), input.Account},
{nameof(input.不使用缓存), input.不使用缓存},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取陌生人信息(支持缓存)
        /// </summary>
        public class CqpCQ_getStrangerInfoHttpInput
        {
            /// <summary>
            /// 目标帐号
            /// </summary>
            public long Account { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public bool 不使用缓存 { get; set; }
        }
        /// <summary>
        /// 取群信息(支持缓存)
        /// </summary>
        [HttpPost("CQ_getGroupInfo")]
        public Task CQ_getGroupInfo([FromBody] CqpCQ_getGroupInfoHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(CQ_getGroupInfo),
                MahuaPlatform = MahuaPlatform.Cqp,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.群号), input.群号},
{nameof(input.不使用缓存), input.不使用缓存},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取群信息(支持缓存)
        /// </summary>
        public class CqpCQ_getGroupInfoHttpInput
        {
            /// <summary>
            /// 目标群
            /// </summary>
            public long 群号 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public bool 不使用缓存 { get; set; }
        }
    }
}
