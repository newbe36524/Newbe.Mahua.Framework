using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


// this file is generate from tools, do not change this file
// generate time 2019/12/15 

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
        /// //给QQ点名片赞，PCQQ点赞不稳定，容易失效
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
{nameof(input.QQID), input.QQID},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// //给QQ点名片赞，PCQQ点赞不稳定，容易失效
        /// </summary>
        public class QQLightApi_SendPraiseHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string QQID { get; set; }
        }
        /// <summary>
        /// //抖动好友窗口
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
{nameof(input.QQID), input.QQID},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// //抖动好友窗口
        /// </summary>
        public class QQLightApi_SendShakeHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string QQID { get; set; }
        }
        /// <summary>
        /// //取得网页操作时需要用到的bkn/Gtk
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
{nameof(input.Cookies), input.Cookies},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// //取得网页操作时需要用到的bkn/Gtk
        /// </summary>
        public class QQLightApi_GetbknHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string Cookies { get; set; }
        }
        /// <summary>
        /// //取得网页操作时需要用到的bkn/Gtk
        /// </summary>
        [HttpPost("Api_Getbkn_Long")]
        public Task Api_Getbkn_Long([FromBody] QQLightApi_Getbkn_LongHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_Getbkn_Long),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.Cookies), input.Cookies},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// //取得网页操作时需要用到的bkn/Gtk
        /// </summary>
        public class QQLightApi_Getbkn_LongHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string Cookies { get; set; }
        }
        /// <summary>
        /// //退出群
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
{nameof(input.GroupID), input.GroupID},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// //退出群
        /// </summary>
        public class QQLightApi_QuitGroupHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string GroupID { get; set; }
        }
        /// <summary>
        /// //退出讨论组
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
{nameof(input.GroupID), input.GroupID},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// //退出讨论组
        /// </summary>
        public class QQLightApi_QuitDiscussGroupHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string GroupID { get; set; }
        }
        /// <summary>
        /// //修改个性签名
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
{nameof(input.Signature), input.Signature},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// //修改个性签名
        /// </summary>
        public class QQLightApi_SetSignatureHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string Signature { get; set; }
        }
        /// <summary>
        /// //修改讨论组名称
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
{nameof(input.DiscussGroupID), input.DiscussGroupID},
{nameof(input.Name), input.Name},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// //修改讨论组名称
        /// </summary>
        public class QQLightApi_SetDiscussNameHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string DiscussGroupID { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string Name { get; set; }
        }
        /// <summary>
        /// //修改群名称
        /// </summary>
        [HttpPost("Api_SetGroupName")]
        public Task Api_SetGroupName([FromBody] QQLightApi_SetGroupNameHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_SetGroupName),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.GroupID), input.GroupID},
{nameof(input.Name), input.Name},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// //修改群名称
        /// </summary>
        public class QQLightApi_SetGroupNameHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string GroupID { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string Name { get; set; }
        }
        /// <summary>
        /// //设置全群禁言
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
{nameof(input.GroupID), input.GroupID},
{nameof(input.IsBanGroup), input.IsBanGroup},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// //设置全群禁言
        /// </summary>
        public class QQLightApi_BanGroupHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string GroupID { get; set; }
            /// <summary>
            /// 真 开启全群禁言 假 关闭全群禁言
            /// </summary>
            public bool IsBanGroup { get; set; }
        }
        /// <summary>
        /// //设置管理员权限
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
{nameof(input.GroupID), input.GroupID},
{nameof(input.QQID), input.QQID},
{nameof(input.IsManager), input.IsManager},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// //设置管理员权限
        /// </summary>
        public class QQLightApi_SetManagerHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string GroupID { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string QQID { get; set; }
            /// <summary>
            /// 真,设置  假,取消
            /// </summary>
            public bool IsManager { get; set; }
        }
        /// <summary>
        /// //禁言群成员
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
{nameof(input.GroupID), input.GroupID},
{nameof(input.QQ), input.QQ},
{nameof(input.time), input.time},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// //禁言群成员
        /// </summary>
        public class QQLightApi_BanHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string GroupID { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string QQ { get; set; }
            /// <summary>
            /// 单位:秒  0为解除禁言
            /// </summary>
            public int time { get; set; }
        }
        /// <summary>
        /// //修改匿名权限
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
{nameof(input.GroupID), input.GroupID},
{nameof(input.IsSetAnony), input.IsSetAnony},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// //修改匿名权限
        /// </summary>
        public class QQLightApi_SetAnonyHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string GroupID { get; set; }
            /// <summary>
            /// 真 允许匿名  假 禁止匿名
            /// </summary>
            public bool IsSetAnony { get; set; }
        }
        /// <summary>
        /// //踢出群成员
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
{nameof(input.GroupID), input.GroupID},
{nameof(input.QQID), input.QQID},
{nameof(input.IsBan), input.IsBan},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// //踢出群成员
        /// </summary>
        public class QQLightApi_RemoveMemberHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string GroupID { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string QQID { get; set; }
            /// <summary>
            /// 不再接受此人加群
            /// </summary>
            public bool IsBan { get; set; }
        }
        /// <summary>
        /// //解散群
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
{nameof(input.GroupID), input.GroupID},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// //解散群
        /// </summary>
        public class QQLightApi_RemoveGroupHttpInput
        {
            /// <summary>
            /// 群号
            /// </summary>
            public string GroupID { get; set; }
        }
        /// <summary>
        /// //取得操作网页所需要的Cookies
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
        /// //取得操作网页所需要的Cookies
        /// </summary>
        public class QQLightApi_GetCookiesHttpInput
        {
        }
        /// <summary>
        /// //取得QQ空间Token
        /// </summary>
        [HttpPost("Api_GetQzoneToken")]
        public Task Api_GetQzoneToken([FromBody] QQLightApi_GetQzoneTokenHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetQzoneToken),
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
        /// //取得QQ空间Token
        /// </summary>
        public class QQLightApi_GetQzoneTokenHttpInput
        {
        }
        /// <summary>
        /// //取得QQ空间Cookies
        /// </summary>
        [HttpPost("Api_GetQzoneCookies")]
        public Task Api_GetQzoneCookies([FromBody] QQLightApi_GetQzoneCookiesHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetQzoneCookies),
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
        /// //取得QQ空间Cookies
        /// </summary>
        public class QQLightApi_GetQzoneCookiesHttpInput
        {
        }
        /// <summary>
        /// //发表说说
        /// </summary>
        [HttpPost("Api_SendTaotao")]
        public Task Api_SendTaotao([FromBody] QQLightApi_SendTaotaoHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_SendTaotao),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.Str), input.Str},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// //发表说说
        /// </summary>
        public class QQLightApi_SendTaotaoHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string Str { get; set; }
        }
        /// <summary>
        /// //取得所登录的QQ
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
        /// //取得所登录的QQ
        /// </summary>
        public class QQLightApi_GetLoginQQHttpInput
        {
        }
        /// <summary>
        /// //框架为插件所创建的插件目录
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
        /// //框架为插件所创建的插件目录
        /// </summary>
        public class QQLightApi_GetPathHttpInput
        {
        }
        /// <summary>
        /// //置插件错误管理
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
        /// //置插件错误管理
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
        /// //机器人发送消息，返回值为该条消息的ID
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
{nameof(input.Type), input.Type},
{nameof(input.GroupID), input.GroupID},
{nameof(input.QQID), input.QQID},
{nameof(input.Msg), input.Msg},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// //机器人发送消息，返回值为该条消息的ID
        /// </summary>
        public class QQLightApi_SendMsgHttpInput
        {
            /// <summary>
            /// 1.好友消息 2.群消息 3.群临时消息 4.讨论组消息 5.讨论组临时消息 6.QQ临时消息
            /// </summary>
            public int Type { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string GroupID { get; set; }
            /// <summary>
            /// 类型为2，4时可留空
            /// </summary>
            public string QQID { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string Msg { get; set; }
        }
        /// <summary>
        /// //处理加群消息
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
{nameof(input.GroupID), input.GroupID},
{nameof(input.QQID), input.QQID},
{nameof(input.Seq), input.Seq},
{nameof(input.Type), input.Type},
{nameof(input.Reason), input.Reason},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// //处理加群消息
        /// </summary>
        public class QQLightApi_SetGroupAddHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string GroupID { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string QQID { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string Seq { get; set; }
            /// <summary>
            /// 1.同意 2.拒绝 3.忽略
            /// </summary>
            public int Type { get; set; }
            /// <summary>
            /// 参数可为空，且为 拒绝 时有效
            /// </summary>
            public string Reason { get; set; }
        }
        /// <summary>
        /// //处理加好友消息
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
{nameof(input.QQID), input.QQID},
{nameof(input.Type), input.Type},
{nameof(input.Reason), input.Reason},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// //处理加好友消息
        /// </summary>
        public class QQLightApi_SetFriendAddHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string QQID { get; set; }
            /// <summary>
            /// 1.同意 2.拒绝 3.忽略
            /// </summary>
            public int Type { get; set; }
            /// <summary>
            /// 参数可为空，且为 拒绝 时有效
            /// </summary>
            public string Reason { get; set; }
        }
        /// <summary>
        /// //向框架推送一条日志
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
{nameof(input.Type), input.Type},
{nameof(input.Msg), input.Msg},
{nameof(input.FontColor), input.FontColor},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// //向框架推送一条日志
        /// </summary>
        public class QQLightApi_SendLogHttpInput
        {
            /// <summary>
            /// 日志类型（自定义）
            /// </summary>
            public string Type { get; set; }
            /// <summary>
            /// 日志内容
            /// </summary>
            public string Msg { get; set; }
            /// <summary>
            /// 日志颜色
            /// </summary>
            public int FontColor { get; set; }
        }
        /// <summary>
        /// //修改好友备注
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
{nameof(input.QQID), input.QQID},
{nameof(input.Name), input.Name},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// //修改好友备注
        /// </summary>
        public class QQLightApi_SetFriendNameHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string QQID { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string Name { get; set; }
        }
        /// <summary>
        /// //删除好友
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
{nameof(input.QQID), input.QQID},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// //删除好友
        /// </summary>
        public class QQLightApi_DeleteFriendHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string QQID { get; set; }
        }
        /// <summary>
        /// //主动添加群
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
{nameof(input.GroupID), input.GroupID},
{nameof(input.附加信息), input.附加信息},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// //主动添加群
        /// </summary>
        public class QQLightApi_AddGroupHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string GroupID { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 附加信息 { get; set; }
        }
        /// <summary>
        /// //主动添加好友
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
{nameof(input.QQID), input.QQID},
{nameof(input.Info), input.Info},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// //主动添加好友
        /// </summary>
        public class QQLightApi_AddFriendHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string QQID { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string Info { get; set; }
        }
        /// <summary>
        /// //返回卡片点歌JSON代码
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
{nameof(input.SongID), input.SongID},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// //返回卡片点歌JSON代码
        /// </summary>
        public class QQLightApi_JsonMusicHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string SongID { get; set; }
        }
        /// <summary>
        /// //取得群内成员的名片
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
{nameof(input.GroupID), input.GroupID},
{nameof(input.QQID), input.QQID},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// //取得群内成员的名片
        /// </summary>
        public class QQLightApi_GetGroupCardHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string GroupID { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string QQID { get; set; }
        }
        /// <summary>
        /// //取指定QQ的昵称
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
{nameof(input.QQID), input.QQID},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// //取指定QQ的昵称
        /// </summary>
        public class QQLightApi_GetNickHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string QQID { get; set; }
        }
        /// <summary>
        /// 
        /// </summary>
        [HttpPost("Api_GetGroupName")]
        public Task Api_GetGroupName([FromBody] QQLightApi_GetGroupNameHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetGroupName),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.GroupID), input.GroupID},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 
        /// </summary>
        public class QQLightApi_GetGroupNameHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string GroupID { get; set; }
        }
        /// <summary>
        /// 
        /// </summary>
        [HttpPost("Api_GetSoftVersion")]
        public Task Api_GetSoftVersion([FromBody] QQLightApi_GetSoftVersionHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetSoftVersion),
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
        public class QQLightApi_GetSoftVersionHttpInput
        {
        }
        /// <summary>
        /// 
        /// </summary>
        [HttpPost("Api_GetGroupIntroduce")]
        public Task Api_GetGroupIntroduce([FromBody] QQLightApi_GetGroupIntroduceHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetGroupIntroduce),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.GroupID), input.GroupID},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 
        /// </summary>
        public class QQLightApi_GetGroupIntroduceHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string GroupID { get; set; }
        }
        /// <summary>
        /// 
        /// </summary>
        [HttpPost("Api_GetGroupOwner")]
        public Task Api_GetGroupOwner([FromBody] QQLightApi_GetGroupOwnerHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetGroupOwner),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.GroupID), input.GroupID},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 
        /// </summary>
        public class QQLightApi_GetGroupOwnerHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string GroupID { get; set; }
        }
        /// <summary>
        /// //修改群成员的名片
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
{nameof(input.GroupID), input.GroupID},
{nameof(input.QQID), input.QQID},
{nameof(input.NewCard), input.NewCard},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// //修改群成员的名片
        /// </summary>
        public class QQLightApi_SetGroupCardHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string GroupID { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string QQID { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string NewCard { get; set; }
        }
        /// <summary>
        /// //取得某个QQ的名片赞数量
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
{nameof(input.QQID), input.QQID},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// //取得某个QQ的名片赞数量
        /// </summary>
        public class QQLightApi_GetPraiseNumHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string QQID { get; set; }
        }
        /// <summary>
        /// //取得某个QQ的等级
        /// </summary>
        [HttpPost("Api_GetQQLevel")]
        public Task Api_GetQQLevel([FromBody] QQLightApi_GetQQLevelHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetQQLevel),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.QQID), input.QQID},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// //取得某个QQ的等级
        /// </summary>
        public class QQLightApi_GetQQLevelHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string QQID { get; set; }
        }
        /// <summary>
        /// 
        /// </summary>
        [HttpPost("Api_SetNick")]
        public Task Api_SetNick([FromBody] QQLightApi_SetNickHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_SetNick),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.NewNick), input.NewNick},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 
        /// </summary>
        public class QQLightApi_SetNickHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string NewNick { get; set; }
        }
        /// <summary>
        /// 
        /// </summary>
        [HttpPost("Api_Taotaodolike")]
        public Task Api_Taotaodolike([FromBody] QQLightApi_TaotaodolikeHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_Taotaodolike),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.QQID), input.QQID},
{nameof(input.URL), input.URL},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 
        /// </summary>
        public class QQLightApi_TaotaodolikeHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string QQID { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string URL { get; set; }
        }
        /// <summary>
        /// 
        /// </summary>
        [HttpPost("Api_Taotaofeeds")]
        public Task Api_Taotaofeeds([FromBody] QQLightApi_TaotaofeedsHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_Taotaofeeds),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.QQID), input.QQID},
{nameof(input.URL), input.URL},
{nameof(input.Content), input.Content},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 
        /// </summary>
        public class QQLightApi_TaotaofeedsHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string QQID { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string URL { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string Content { get; set; }
        }
        /// <summary>
        /// 
        /// </summary>
        [HttpPost("Api_GetQQAge")]
        public Task Api_GetQQAge([FromBody] QQLightApi_GetQQAgeHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetQQAge),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.QQID), input.QQID},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 
        /// </summary>
        public class QQLightApi_GetQQAgeHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string QQID { get; set; }
        }
        /// <summary>
        /// 
        /// </summary>
        [HttpPost("Api_GetQQSex")]
        public Task Api_GetQQSex([FromBody] QQLightApi_GetQQSexHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetQQSex),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.QQID), input.QQID},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 
        /// </summary>
        public class QQLightApi_GetQQSexHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string QQID { get; set; }
        }
        /// <summary>
        /// //以JSON形式取得好友列表
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
{nameof(input.Cache), input.Cache},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// //以JSON形式取得好友列表
        /// </summary>
        public class QQLightApi_GetFriendListHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public bool Cache { get; set; }
        }
        /// <summary>
        /// //以JSON形式取得群列表
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
{nameof(input.Cache), input.Cache},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// //以JSON形式取得群列表
        /// </summary>
        public class QQLightApi_GetGroupListHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public bool Cache { get; set; }
        }
        /// <summary>
        /// //以JSON形式取得群成员列表
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
{nameof(input.GroupID), input.GroupID},
{nameof(input.Cache), input.Cache},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// //以JSON形式取得群成员列表
        /// </summary>
        public class QQLightApi_GetGroupMemberListHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string GroupID { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public bool Cache { get; set; }
        }
        /// <summary>
        /// //以JSON形式取得某QQ个人信息
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
{nameof(input.QQID), input.QQID},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// //以JSON形式取得某QQ个人信息
        /// </summary>
        public class QQLightApi_GetQQInfoHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string QQID { get; set; }
        }
        /// <summary>
        /// //以JSON形式取得某群信息
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
{nameof(input.GroupID), input.GroupID},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// //以JSON形式取得某群信息
        /// </summary>
        public class QQLightApi_GetGroupInfoHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string GroupID { get; set; }
        }
        /// <summary>
        /// //撤回自身消息 发出消息不可以秒撤回，腾讯限制，1~2s后才可撤回
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
{nameof(input.Type), input.Type},
{nameof(input.GroupID), input.GroupID},
{nameof(input.QQID), input.QQID},
{nameof(input.MsgID), input.MsgID},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// //撤回自身消息 发出消息不可以秒撤回，腾讯限制，1~2s后才可撤回
        /// </summary>
        public class QQLightApi_DeleteMsgHttpInput
        {
            /// <summary>
            /// 1.好友消息 2.群消息 3.群临时消息 4.讨论组消息 5.讨论组临时消息 6.QQ临时消息
            /// </summary>
            public int Type { get; set; }
            /// <summary>
            /// 撤回群消息、群临时消息、讨论组消息、讨论组临时消息必须填写，其余情况可留空
            /// </summary>
            public string GroupID { get; set; }
            /// <summary>
            /// 撤回好友消息、群临时消息、讨论组临时消息、QQ临时消息必须填写，其余情况可留空
            /// </summary>
            public string QQID { get; set; }
            /// <summary>
            /// 撤回的消息ID，机器人发送消息会返回自身的消息ID
            /// </summary>
            public string MsgID { get; set; }
        }
        /// <summary>
        /// //改变QQ在线状态
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
{nameof(input.Type), input.Type},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// //改变QQ在线状态
        /// </summary>
        public class QQLightApi_SetQQStateHttpInput
        {
            /// <summary>
            /// 1.我在线上 2.Q我吧 3.离开 4.忙碌 5.请勿打扰 6.隐身
            /// </summary>
            public int Type { get; set; }
        }
        /// <summary>
        /// //邀请好友入群
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
{nameof(input.GroupID), input.GroupID},
{nameof(input.QQID), input.QQID},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// //邀请好友入群
        /// </summary>
        public class QQLightApi_InviteFriendHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string GroupID { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string QQID { get; set; }
        }
        /// <summary>
        /// 
        /// </summary>
        [HttpPost("Api_GetQQInfo_v2")]
        public Task Api_GetQQInfo_v2([FromBody] QQLightApi_GetQQInfo_v2HttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetQQInfo_v2),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.QQID), input.QQID},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 
        /// </summary>
        public class QQLightApi_GetQQInfo_v2HttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string QQID { get; set; }
        }
        /// <summary>
        /// //取消COM库
        /// </summary>
        [HttpPost("CoUninitialize")]
        public Task CoUninitialize([FromBody] QQLightCoUninitializeHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(CoUninitialize),
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
        /// //取消COM库
        /// </summary>
        public class QQLightCoUninitializeHttpInput
        {
        }
        /// <summary>
        /// //初始化COM库
        /// </summary>
        [HttpPost("CoInitialize")]
        public Task CoInitialize([FromBody] QQLightCoInitializeHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(CoInitialize),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.pvReserved), input.pvReserved},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// //初始化COM库
        /// </summary>
        public class QQLightCoInitializeHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public int pvReserved { get; set; }
        }
        /// <summary>
        /// //上传图片，获得图片GUID，
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
{nameof(input.Type), input.Type},
{nameof(input.对象), input.对象},
{nameof(input.Bin), input.Bin},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// //上传图片，获得图片GUID，
        /// </summary>
        public class QQLightApi_UpLoadPicHttpInput
        {
            /// <summary>
            /// 1.私聊图片  2.群聊图片
            /// </summary>
            public int Type { get; set; }
            /// <summary>
            /// 私聊图片填写QQID，群聊/讨论组图片填写群号讨论组号
            /// </summary>
            public string 对象 { get; set; }
            /// <summary>
            /// 图片的Hex流
            /// </summary>
            public string Bin { get; set; }
        }
        /// <summary>
        /// //设置插件状态，开启或关闭
        /// </summary>
        [HttpPost("Api_SetPluginState")]
        public Task Api_SetPluginState([FromBody] QQLightApi_SetPluginStateHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_SetPluginState),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.State), input.State},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// //设置插件状态，开启或关闭
        /// </summary>
        public class QQLightApi_SetPluginStateHttpInput
        {
            /// <summary>
            /// 真:启用自身  假:关闭自身
            /// </summary>
            public bool State { get; set; }
        }
        /// <summary>
        /// 
        /// </summary>
        [HttpPost("Api_DeleteFile")]
        public Task Api_DeleteFile([FromBody] QQLightApi_DeleteFileHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_DeleteFile),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.群号), input.群号},
{nameof(input.文件GUID), input.文件GUID},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 
        /// </summary>
        public class QQLightApi_DeleteFileHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 群号 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 文件GUID { get; set; }
        }
        /// <summary>
        /// 
        /// </summary>
        [HttpPost("Api_RepeatFile")]
        public Task Api_RepeatFile([FromBody] QQLightApi_RepeatFileHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_RepeatFile),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.来源对象), input.来源对象},
{nameof(input.转发群号), input.转发群号},
{nameof(input.文件GUID), input.文件GUID},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 
        /// </summary>
        public class QQLightApi_RepeatFileHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 来源对象 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 转发群号 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 文件GUID { get; set; }
        }
        /// <summary>
        /// 
        /// </summary>
        [HttpPost("Api_ClearOffLineFile")]
        public Task Api_ClearOffLineFile([FromBody] QQLightApi_ClearOffLineFileHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_ClearOffLineFile),
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
        public class QQLightApi_ClearOffLineFileHttpInput
        {
        }
        /// <summary>
        /// 
        /// </summary>
        [HttpPost("WideCharToMultiByte")]
        public Task WideCharToMultiByte([FromBody] QQLightWideCharToMultiByteHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(WideCharToMultiByte),
                MahuaPlatform = MahuaPlatform.QQLight,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.CodePage), input.CodePage},
{nameof(input.dwFlags), input.dwFlags},
{nameof(input.lpWideCharStr), input.lpWideCharStr},
{nameof(input.cchWideChar), input.cchWideChar},
{nameof(input.lpMultiByteStr), input.lpMultiByteStr},
{nameof(input.cchMultiByte), input.cchMultiByte},
{nameof(input.lpDefaultChar), input.lpDefaultChar},
{nameof(input.lpUsedDefaultChar), input.lpUsedDefaultChar},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 
        /// </summary>
        public class QQLightWideCharToMultiByteHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public int CodePage { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int dwFlags { get; set; }
            /// <summary>
            /// 址
            /// </summary>
            public string lpWideCharStr { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int cchWideChar { get; set; }
            /// <summary>
            /// 址
            /// </summary>
            public string lpMultiByteStr { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int cchMultiByte { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int lpDefaultChar { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int lpUsedDefaultChar { get; set; }
        }
    }
}
