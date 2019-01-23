using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


// this file is generate from tools, do not change this file
// generate time 2019/01/23 

namespace Newbe.Mahua.InputReceivers.HttpApi.Services.Controllers.QQLight
{
    [Route("api/v1/QQLight")]
    public class QQLightController : Controller
    {

        private readonly IMahuaCenter _mahuaCenter;

        public QQLightController(
            IMahuaCenter mahuaCenter)
        {
            _mahuaCenter = mahuaCenter;
        }
        /// <summary>
        /// 
        /// </summary>
        [HttpPost("Api_SendPraise")]
        public Task Api_SendPraise([FromBody] QQLightApi_SendPraiseHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_SendPraise),
                MahuaPlatform = MahuaPlatform.QQLight,
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
        /// 
        /// </summary>
        public class QQLightApi_SendPraiseHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string QQ号 { get; set; }
        }
        /// <summary>
        /// 
        /// </summary>
        [HttpPost("Api_SendShake")]
        public Task Api_SendShake([FromBody] QQLightApi_SendShakeHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_SendShake),
                MahuaPlatform = MahuaPlatform.QQLight,
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
        /// 
        /// </summary>
        public class QQLightApi_SendShakeHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string QQ号 { get; set; }
        }
        /// <summary>
        /// 
        /// </summary>
        [HttpPost("Api_Getbkn")]
        public Task Api_Getbkn([FromBody] QQLightApi_GetbknHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_Getbkn),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
                {
                }
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 
        /// </summary>
        public class QQLightApi_GetbknHttpInput
        {
        }
        /// <summary>
        /// 
        /// </summary>
        [HttpPost("Api_QuitGroup")]
        public Task Api_QuitGroup([FromBody] QQLightApi_QuitGroupHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_QuitGroup),
                MahuaPlatform = MahuaPlatform.QQLight,
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
        /// 
        /// </summary>
        public class QQLightApi_QuitGroupHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 群号 { get; set; }
        }
        /// <summary>
        /// 
        /// </summary>
        [HttpPost("Api_QuitDiscussGroup")]
        public Task Api_QuitDiscussGroup([FromBody] QQLightApi_QuitDiscussGroupHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_QuitDiscussGroup),
                MahuaPlatform = MahuaPlatform.QQLight,
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
        /// 
        /// </summary>
        public class QQLightApi_QuitDiscussGroupHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 讨论组号 { get; set; }
        }
        /// <summary>
        /// 
        /// </summary>
        [HttpPost("Api_SetSignature")]
        public Task Api_SetSignature([FromBody] QQLightApi_SetSignatureHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_SetSignature),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.个性签名), input.个性签名},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 
        /// </summary>
        public class QQLightApi_SetSignatureHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 个性签名 { get; set; }
        }
        /// <summary>
        /// 
        /// </summary>
        [HttpPost("Api_SetDiscussName")]
        public Task Api_SetDiscussName([FromBody] QQLightApi_SetDiscussNameHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_SetDiscussName),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.讨论组号), input.讨论组号},
{nameof(input.名称), input.名称},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 
        /// </summary>
        public class QQLightApi_SetDiscussNameHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 讨论组号 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 名称 { get; set; }
        }
        /// <summary>
        /// 
        /// </summary>
        [HttpPost("Api_BanGroup")]
        public Task Api_BanGroup([FromBody] QQLightApi_BanGroupHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_BanGroup),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.群号), input.群号},
{nameof(input.是否全群禁言), input.是否全群禁言},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 
        /// </summary>
        public class QQLightApi_BanGroupHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 群号 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public bool 是否全群禁言 { get; set; }
        }
        /// <summary>
        /// 
        /// </summary>
        [HttpPost("Api_RemoveGroup")]
        public Task Api_RemoveGroup([FromBody] QQLightApi_RemoveGroupHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_RemoveGroup),
                MahuaPlatform = MahuaPlatform.QQLight,
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
        /// 
        /// </summary>
        public class QQLightApi_RemoveGroupHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 群号 { get; set; }
        }
        /// <summary>
        /// 
        /// </summary>
        [HttpPost("Api_SetManager")]
        public Task Api_SetManager([FromBody] QQLightApi_SetManagerHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_SetManager),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.群号), input.群号},
{nameof(input.QQ号), input.QQ号},
{nameof(input.是否设置为管理员), input.是否设置为管理员},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 
        /// </summary>
        public class QQLightApi_SetManagerHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 群号 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string QQ号 { get; set; }
            /// <summary>
            /// 真,设置  假,取消
            /// </summary>
            public bool 是否设置为管理员 { get; set; }
        }
        /// <summary>
        /// 
        /// </summary>
        [HttpPost("Api_Ban")]
        public Task Api_Ban([FromBody] QQLightApi_BanHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_Ban),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.群号), input.群号},
{nameof(input.QQ), input.QQ},
{nameof(input.禁言时长), input.禁言时长},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 
        /// </summary>
        public class QQLightApi_BanHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 群号 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string QQ { get; set; }
            /// <summary>
            /// 单位:秒  0为解除禁言
            /// </summary>
            public int 禁言时长 { get; set; }
        }
        /// <summary>
        /// 
        /// </summary>
        [HttpPost("Api_SetAnony")]
        public Task Api_SetAnony([FromBody] QQLightApi_SetAnonyHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_SetAnony),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.群号), input.群号},
{nameof(input.是否允许匿名聊天), input.是否允许匿名聊天},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 
        /// </summary>
        public class QQLightApi_SetAnonyHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 群号 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public bool 是否允许匿名聊天 { get; set; }
        }
        /// <summary>
        /// 
        /// </summary>
        [HttpPost("Api_RemoveMember")]
        public Task Api_RemoveMember([FromBody] QQLightApi_RemoveMemberHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_RemoveMember),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.群号), input.群号},
{nameof(input.QQ号), input.QQ号},
{nameof(input.是否不再接收加群申请), input.是否不再接收加群申请},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 
        /// </summary>
        public class QQLightApi_RemoveMemberHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 群号 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string QQ号 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public bool 是否不再接收加群申请 { get; set; }
        }
        /// <summary>
        /// 
        /// </summary>
        [HttpPost("Api_GetCookies")]
        public Task Api_GetCookies([FromBody] QQLightApi_GetCookiesHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetCookies),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
                {
                }
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 
        /// </summary>
        public class QQLightApi_GetCookiesHttpInput
        {
        }
        /// <summary>
        /// 
        /// </summary>
        [HttpPost("Api_GetClientKey")]
        public Task Api_GetClientKey([FromBody] QQLightApi_GetClientKeyHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetClientKey),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
                {
                }
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 
        /// </summary>
        public class QQLightApi_GetClientKeyHttpInput
        {
        }
        /// <summary>
        /// 
        /// </summary>
        [HttpPost("Api_GetLoginQQ")]
        public Task Api_GetLoginQQ([FromBody] QQLightApi_GetLoginQQHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetLoginQQ),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
                {
                }
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 
        /// </summary>
        public class QQLightApi_GetLoginQQHttpInput
        {
        }
        /// <summary>
        /// 是否开启/关闭
        /// </summary>
        [HttpPost("Api_GetPluginState")]
        public Task Api_GetPluginState([FromBody] QQLightApi_GetPluginStateHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetPluginState),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
                {
                }
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 是否开启/关闭
        /// </summary>
        public class QQLightApi_GetPluginStateHttpInput
        {
        }
        /// <summary>
        /// 框架为插件所创建的一个目录
        /// </summary>
        [HttpPost("Api_GetPath")]
        public Task Api_GetPath([FromBody] QQLightApi_GetPathHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetPath),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
                {
                }
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 框架为插件所创建的一个目录
        /// </summary>
        public class QQLightApi_GetPathHttpInput
        {
        }
        /// <summary>
        /// 机器人发送消息
        /// </summary>
        [HttpPost("Api_SendMsg")]
        public Task Api_SendMsg([FromBody] QQLightApi_SendMsgHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_SendMsg),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.类型), input.类型},
{nameof(input.群组), input.群组},
{nameof(input.QQ号), input.QQ号},
{nameof(input.内容), input.内容},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 机器人发送消息
        /// </summary>
        public class QQLightApi_SendMsgHttpInput
        {
            /// <summary>
            /// 1.好友消息 2.群消息 3.群临时消息 4.讨论组消息 5.讨论组临时消息 6.QQ临时消息
            /// </summary>
            public int 类型 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 群组 { get; set; }
            /// <summary>
            /// 类型为2，4时可留空
            /// </summary>
            public string QQ号 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 内容 { get; set; }
        }
        /// <summary>
        /// 处理加群消息
        /// </summary>
        [HttpPost("Api_SetGroupAdd")]
        public Task Api_SetGroupAdd([FromBody] QQLightApi_SetGroupAddHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_SetGroupAdd),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.群号), input.群号},
{nameof(input.QQ号), input.QQ号},
{nameof(input.Seq), input.Seq},
{nameof(input.操作方式), input.操作方式},
{nameof(input.拒绝理由), input.拒绝理由},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 处理加群消息
        /// </summary>
        public class QQLightApi_SetGroupAddHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 群号 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string QQ号 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string Seq { get; set; }
            /// <summary>
            /// 1.同意 2.拒绝 3.忽略
            /// </summary>
            public int 操作方式 { get; set; }
            /// <summary>
            /// 参数可为空，且为 拒绝 时有效
            /// </summary>
            public string 拒绝理由 { get; set; }
        }
        /// <summary>
        /// 处理加好友消息
        /// </summary>
        [HttpPost("Api_SetFriendAdd")]
        public Task Api_SetFriendAdd([FromBody] QQLightApi_SetFriendAddHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_SetFriendAdd),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.QQ号), input.QQ号},
{nameof(input.操作方式), input.操作方式},
{nameof(input.拒绝理由), input.拒绝理由},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 处理加好友消息
        /// </summary>
        public class QQLightApi_SetFriendAddHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string QQ号 { get; set; }
            /// <summary>
            /// 1.同意 2.拒绝 3.忽略
            /// </summary>
            public int 操作方式 { get; set; }
            /// <summary>
            /// 参数可为空，且为 拒绝 时有效
            /// </summary>
            public string 拒绝理由 { get; set; }
        }
        /// <summary>
        /// 
        /// </summary>
        [HttpPost("Api_SendLog")]
        public Task Api_SendLog([FromBody] QQLightApi_SendLogHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_SendLog),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.类型), input.类型},
{nameof(input.内容), input.内容},
{nameof(input.字体颜色), input.字体颜色},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 
        /// </summary>
        public class QQLightApi_SendLogHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 类型 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 内容 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int 字体颜色 { get; set; }
        }
        /// <summary>
        /// 
        /// </summary>
        [HttpPost("Api_SetFriendName")]
        public Task Api_SetFriendName([FromBody] QQLightApi_SetFriendNameHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_SetFriendName),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.好友QQ), input.好友QQ},
{nameof(input.备注名), input.备注名},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 
        /// </summary>
        public class QQLightApi_SetFriendNameHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 好友QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 备注名 { get; set; }
        }
        /// <summary>
        /// 
        /// </summary>
        [HttpPost("Api_DeleteFriend")]
        public Task Api_DeleteFriend([FromBody] QQLightApi_DeleteFriendHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_DeleteFriend),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.好友QQ), input.好友QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 
        /// </summary>
        public class QQLightApi_DeleteFriendHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 好友QQ { get; set; }
        }
        /// <summary>
        /// 
        /// </summary>
        [HttpPost("Api_AddGroup")]
        public Task Api_AddGroup([FromBody] QQLightApi_AddGroupHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_AddGroup),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.群号), input.群号},
{nameof(input.附加信息), input.附加信息},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 
        /// </summary>
        public class QQLightApi_AddGroupHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 群号 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 附加信息 { get; set; }
        }
        /// <summary>
        /// 
        /// </summary>
        [HttpPost("Api_AddFriend")]
        public Task Api_AddFriend([FromBody] QQLightApi_AddFriendHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_AddFriend),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.目标QQ), input.目标QQ},
{nameof(input.附加信息), input.附加信息},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 
        /// </summary>
        public class QQLightApi_AddFriendHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 目标QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 附加信息 { get; set; }
        }
        /// <summary>
        /// 返回网易云点歌XML
        /// </summary>
        [HttpPost("Api_163Music")]
        public Task Api_163Music([FromBody] QQLightApi_163MusicHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_163Music),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.歌曲ID), input.歌曲ID},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 返回网易云点歌XML
        /// </summary>
        public class QQLightApi_163MusicHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 歌曲ID { get; set; }
        }
        /// <summary>
        /// 返回QQ点歌XML
        /// </summary>
        [HttpPost("Api_QQMusic")]
        public Task Api_QQMusic([FromBody] QQLightApi_QQMusicHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_QQMusic),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.歌曲ID), input.歌曲ID},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 返回QQ点歌XML
        /// </summary>
        public class QQLightApi_QQMusicHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 歌曲ID { get; set; }
        }
        /// <summary>
        /// 返回Json点歌XML
        /// </summary>
        [HttpPost("Api_JsonMusic")]
        public Task Api_JsonMusic([FromBody] QQLightApi_JsonMusicHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_JsonMusic),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.歌曲ID), input.歌曲ID},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 返回Json点歌XML
        /// </summary>
        public class QQLightApi_JsonMusicHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 歌曲ID { get; set; }
        }
        /// <summary>
        /// 置插件错误管理
        /// </summary>
        [HttpPost("Api_Error")]
        public Task Api_Error([FromBody] QQLightApi_ErrorHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_Error),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.Code), input.Code},
{nameof(input.Str), input.Str},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 置插件错误管理
        /// </summary>
        public class QQLightApi_ErrorHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string Code { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string Str { get; set; }
        }
        /// <summary>
        /// 取得群内成员的名片
        /// </summary>
        [HttpPost("Api_GetGroupCard")]
        public Task Api_GetGroupCard([FromBody] QQLightApi_GetGroupCardHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetGroupCard),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.群号), input.群号},
{nameof(input.QQ号), input.QQ号},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取得群内成员的名片
        /// </summary>
        public class QQLightApi_GetGroupCardHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 群号 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string QQ号 { get; set; }
        }
        /// <summary>
        /// 取得某个QQ的昵称
        /// </summary>
        [HttpPost("Api_GetNick")]
        public Task Api_GetNick([FromBody] QQLightApi_GetNickHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetNick),
                MahuaPlatform = MahuaPlatform.QQLight,
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
        /// 取得某个QQ的昵称
        /// </summary>
        public class QQLightApi_GetNickHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string QQ号 { get; set; }
        }
        /// <summary>
        /// 修改群内成员的名片
        /// </summary>
        [HttpPost("Api_SetGroupCard")]
        public Task Api_SetGroupCard([FromBody] QQLightApi_SetGroupCardHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_SetGroupCard),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.群号), input.群号},
{nameof(input.QQ号), input.QQ号},
{nameof(input.新名片), input.新名片},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 修改群内成员的名片
        /// </summary>
        public class QQLightApi_SetGroupCardHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 群号 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string QQ号 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 新名片 { get; set; }
        }
        /// <summary>
        /// 取得某个QQ的名片赞数量
        /// </summary>
        [HttpPost("Api_GetPraiseNum")]
        public Task Api_GetPraiseNum([FromBody] QQLightApi_GetPraiseNumHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetPraiseNum),
                MahuaPlatform = MahuaPlatform.QQLight,
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
        /// 取得某个QQ的名片赞数量
        /// </summary>
        public class QQLightApi_GetPraiseNumHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string QQ号 { get; set; }
        }
        /// <summary>
        /// 以JSON形式取得好友列表
        /// </summary>
        [HttpPost("Api_GetFriendList")]
        public Task Api_GetFriendList([FromBody] QQLightApi_GetFriendListHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetFriendList),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
                {
                }
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 以JSON形式取得好友列表
        /// </summary>
        public class QQLightApi_GetFriendListHttpInput
        {
        }
        /// <summary>
        /// 以JSON形式取得群列表
        /// </summary>
        [HttpPost("Api_GetGroupList")]
        public Task Api_GetGroupList([FromBody] QQLightApi_GetGroupListHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetGroupList),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
                {
                }
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 以JSON形式取得群列表
        /// </summary>
        public class QQLightApi_GetGroupListHttpInput
        {
        }
        /// <summary>
        /// 以JSON形式取得群成员列表
        /// </summary>
        [HttpPost("Api_GetGroupMemberList")]
        public Task Api_GetGroupMemberList([FromBody] QQLightApi_GetGroupMemberListHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetGroupMemberList),
                MahuaPlatform = MahuaPlatform.QQLight,
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
        /// 以JSON形式取得群成员列表
        /// </summary>
        public class QQLightApi_GetGroupMemberListHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 群号 { get; set; }
        }
        /// <summary>
        /// 以JSON形式取得某QQ个人信息
        /// </summary>
        [HttpPost("Api_GetQQInfo")]
        public Task Api_GetQQInfo([FromBody] QQLightApi_GetQQInfoHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetQQInfo),
                MahuaPlatform = MahuaPlatform.QQLight,
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
        /// 以JSON形式取得某QQ个人信息
        /// </summary>
        public class QQLightApi_GetQQInfoHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string QQ号 { get; set; }
        }
        /// <summary>
        /// 以JSON形式取得某群信息
        /// </summary>
        [HttpPost("Api_GetGroupInfo")]
        public Task Api_GetGroupInfo([FromBody] QQLightApi_GetGroupInfoHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetGroupInfo),
                MahuaPlatform = MahuaPlatform.QQLight,
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
        /// 以JSON形式取得某群信息
        /// </summary>
        public class QQLightApi_GetGroupInfoHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 群号 { get; set; }
        }
        /// <summary>
        /// 让机器人快速重启
        /// </summary>
        [HttpPost("Api_Restart")]
        public Task Api_Restart([FromBody] QQLightApi_RestartHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_Restart),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
                {
                }
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 让机器人快速重启
        /// </summary>
        public class QQLightApi_RestartHttpInput
        {
        }
        /// <summary>
        /// 让机器人刷新插件
        /// </summary>
        [HttpPost("Api_UpdatePlugin")]
        public Task Api_UpdatePlugin([FromBody] QQLightApi_UpdatePluginHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_UpdatePlugin),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
                {
                }
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 让机器人刷新插件
        /// </summary>
        public class QQLightApi_UpdatePluginHttpInput
        {
        }
        /// <summary>
        /// 撤回群成员的消息 机器人必须为管理员
        /// </summary>
        [HttpPost("Api_DeleteMsg")]
        public Task Api_DeleteMsg([FromBody] QQLightApi_DeleteMsgHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_DeleteMsg),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.群号), input.群号},
{nameof(input.消息ID), input.消息ID},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 撤回群成员的消息 机器人必须为管理员
        /// </summary>
        public class QQLightApi_DeleteMsgHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 群号 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 消息ID { get; set; }
        }
        /// <summary>
        /// 改变QQ在线状态
        /// </summary>
        [HttpPost("Api_SetQQState")]
        public Task Api_SetQQState([FromBody] QQLightApi_SetQQStateHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_SetQQState),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.类型), input.类型},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 改变QQ在线状态
        /// </summary>
        public class QQLightApi_SetQQStateHttpInput
        {
            /// <summary>
            /// 1.我在线上 2.Q我吧 3.离开 4.忙碌 5.请勿打扰 6.隐身
            /// </summary>
            public int 类型 { get; set; }
        }
        /// <summary>
        /// 
        /// </summary>
        [HttpPost("Api_InviteFriend")]
        public Task Api_InviteFriend([FromBody] QQLightApi_InviteFriendHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_InviteFriend),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.群号), input.群号},
{nameof(input.好友QQ), input.好友QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 
        /// </summary>
        public class QQLightApi_InviteFriendHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 群号 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 好友QQ { get; set; }
        }
        /// <summary>
        /// 
        /// </summary>
        [HttpPost("Api_GetQQinfo_v2")]
        public Task Api_GetQQinfo_v2([FromBody] QQLightApi_GetQQinfo_v2HttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetQQinfo_v2),
                MahuaPlatform = MahuaPlatform.QQLight,
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
        /// 
        /// </summary>
        public class QQLightApi_GetQQinfo_v2HttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string QQ号 { get; set; }
        }
        /// <summary>
        /// 
        /// </summary>
        [HttpPost("Api_UpLoadPic")]
        public Task Api_UpLoadPic([FromBody] QQLightApi_UpLoadPicHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_UpLoadPic),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.类型), input.类型},
{nameof(input.对象), input.对象},
{nameof(input.图片字节集), input.图片字节集},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 
        /// </summary>
        public class QQLightApi_UpLoadPicHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public int 类型 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 对象 { get; set; }
            /// <summary>
            /// Hex形式
            /// </summary>
            public string 图片字节集 { get; set; }
        }
    }
}
