using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


// this file is generate from tools, do not change this file
// generate time 2019/01/23 

namespace Newbe.Mahua.InputReceivers.HttpApi.Services.Controllers.Mpq
{
    [Route("api/v1/Mpq")]
    public class MpqController : Controller
    {

        private readonly IMahuaCenter _mahuaCenter;

        public MpqController(
            IMahuaCenter mahuaCenter)
        {
            _mahuaCenter = mahuaCenter;
        }
        /// <summary>
        /// 根据提交的QQ号计算得到页面操作用参数Bkn或G_tk`
        /// </summary>
        [HttpPost("Api_GetGtk_Bkn")]
        public Task Api_GetGtk_Bkn([FromBody] MpqApi_GetGtk_BknHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetGtk_Bkn),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 根据提交的QQ号计算得到页面操作用参数Bkn或G_tk`
        /// </summary>
        public class MpqApi_GetGtk_BknHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
        }
        /// <summary>
        /// 根据提交的QQ号计算得到页面操作用参数长Bkn或长G_tk`
        /// </summary>
        [HttpPost("Api_GetBkn32")]
        public Task Api_GetBkn32([FromBody] MpqApi_GetBkn32HttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetBkn32),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 根据提交的QQ号计算得到页面操作用参数长Bkn或长G_tk`
        /// </summary>
        public class MpqApi_GetBkn32HttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
        }
        /// <summary>
        /// 根据提交的QQ号计算得到页面操作用参数长Ldw`
        /// </summary>
        [HttpPost("Api_GetLdw")]
        public Task Api_GetLdw([FromBody] MpqApi_GetLdwHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetLdw),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 根据提交的QQ号计算得到页面操作用参数长Ldw`
        /// </summary>
        public class MpqApi_GetLdwHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
        }
        /// <summary>
        /// 取得框架所在目录.可能鸡肋了。`
        /// </summary>
        [HttpPost("Api_GetRunPath")]
        public Task Api_GetRunPath([FromBody] MpqApi_GetRunPathHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetRunPath),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
                {
                }
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取得框架所在目录.可能鸡肋了。`
        /// </summary>
        public class MpqApi_GetRunPathHttpInput
        {
        }
        /// <summary>
        /// 取得当前框架内在线可用的QQ列表`
        /// </summary>
        [HttpPost("Api_GetOnlineQQlist")]
        public Task Api_GetOnlineQQlist([FromBody] MpqApi_GetOnlineQQlistHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetOnlineQQlist),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
                {
                }
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取得当前框架内在线可用的QQ列表`
        /// </summary>
        public class MpqApi_GetOnlineQQlistHttpInput
        {
        }
        /// <summary>
        /// 取得框架内所有QQ列表。包括未登录以及登录失败的QQ`
        /// </summary>
        [HttpPost("Api_GetQQlist")]
        public Task Api_GetQQlist([FromBody] MpqApi_GetQQlistHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetQQlist),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
                {
                }
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取得框架内所有QQ列表。包括未登录以及登录失败的QQ`
        /// </summary>
        public class MpqApi_GetQQlistHttpInput
        {
        }
        /// <summary>
        /// 根据QQ取得对应的会话秘钥`
        /// </summary>
        [HttpPost("Api_GetSessionkey")]
        public Task Api_GetSessionkey([FromBody] MpqApi_GetSessionkeyHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetSessionkey),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 根据QQ取得对应的会话秘钥`
        /// </summary>
        public class MpqApi_GetSessionkeyHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
        }
        /// <summary>
        /// 取得页面登录用的Clientkey`
        /// </summary>
        [HttpPost("Api_GetClientkey")]
        public Task Api_GetClientkey([FromBody] MpqApi_GetClientkeyHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetClientkey),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取得页面登录用的Clientkey`
        /// </summary>
        public class MpqApi_GetClientkeyHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
        }
        /// <summary>
        /// 取得页面登录用的长Clientkey`
        /// </summary>
        [HttpPost("Api_GetLongClientkey")]
        public Task Api_GetLongClientkey([FromBody] MpqApi_GetLongClientkeyHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetLongClientkey),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取得页面登录用的长Clientkey`
        /// </summary>
        public class MpqApi_GetLongClientkeyHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
        }
        /// <summary>
        /// 取得页面操作用的Cookies`
        /// </summary>
        [HttpPost("Api_GetCookies")]
        public Task Api_GetCookies([FromBody] MpqApi_GetCookiesHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetCookies),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取得页面操作用的Cookies`
        /// </summary>
        public class MpqApi_GetCookiesHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
        }
        /// <summary>
        /// 取得框架内设置的信息发送前缀`
        /// </summary>
        [HttpPost("Api_GetPrefix")]
        public Task Api_GetPrefix([FromBody] MpqApi_GetPrefixHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetPrefix),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
                {
                }
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取得框架内设置的信息发送前缀`
        /// </summary>
        public class MpqApi_GetPrefixHttpInput
        {
        }
        /// <summary>
        /// 将群名片加入高速缓存当作.`
        /// </summary>
        [HttpPost("Api_Cache_NameCard")]
        public Task Api_Cache_NameCard([FromBody] MpqApi_Cache_NameCardHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_Cache_NameCard),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.群号), input.群号},
{nameof(input.QQ), input.QQ},
{nameof(input.名片), input.名片},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 将群名片加入高速缓存当作.`
        /// </summary>
        public class MpqApi_Cache_NameCardHttpInput
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
            /// 
            /// </summary>
            public string 名片 { get; set; }
        }
        /// <summary>
        /// 将指定QQ移出QQ黑名单`
        /// </summary>
        [HttpPost("Api_DBan")]
        public Task Api_DBan([FromBody] MpqApi_DBanHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_DBan),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
{nameof(input.QQ), input.QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 将指定QQ移出QQ黑名单`
        /// </summary>
        public class MpqApi_DBanHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string QQ { get; set; }
        }
        /// <summary>
        /// 将指定QQ列入QQ黑名单`
        /// </summary>
        [HttpPost("Api_Ban")]
        public Task Api_Ban([FromBody] MpqApi_BanHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_Ban),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
{nameof(input.QQ), input.QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 将指定QQ列入QQ黑名单`
        /// </summary>
        public class MpqApi_BanHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string QQ { get; set; }
        }
        /// <summary>
        /// 禁言群成员`
        /// </summary>
        [HttpPost("Api_Shutup")]
        public Task Api_Shutup([FromBody] MpqApi_ShutupHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_Shutup),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
{nameof(input.群号), input.群号},
{nameof(input.QQ), input.QQ},
{nameof(input.时长), input.时长},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 禁言群成员`
        /// </summary>
        public class MpqApi_ShutupHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
            /// <summary>
            /// 禁言对象所在群.
            /// </summary>
            public string 群号 { get; set; }
            /// <summary>
            /// 禁言对象.留空为全群禁言
            /// </summary>
            public string QQ { get; set; }
            /// <summary>
            /// 单位:秒 最大为1个月. 为零解除对象或全群禁言
            /// </summary>
            public int 时长 { get; set; }
        }
        /// <summary>
        /// 发群公告`
        /// </summary>
        [HttpPost("Api_SetNotice")]
        public Task Api_SetNotice([FromBody] MpqApi_SetNoticeHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_SetNotice),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
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
        /// 发群公告`
        /// </summary>
        public class MpqApi_SetNoticeHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 群号 { get; set; }
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
        /// 取群公告`
        /// </summary>
        [HttpPost("Api_GetNotice")]
        public Task Api_GetNotice([FromBody] MpqApi_GetNoticeHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetNotice),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
{nameof(input.群号), input.群号},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取群公告`
        /// </summary>
        public class MpqApi_GetNoticeHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 群号 { get; set; }
        }
        /// <summary>
        /// 取群名片`
        /// </summary>
        [HttpPost("Api_GetNameCard")]
        public Task Api_GetNameCard([FromBody] MpqApi_GetNameCardHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetNameCard),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
{nameof(input.群号), input.群号},
{nameof(input.QQ), input.QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取群名片`
        /// </summary>
        public class MpqApi_GetNameCardHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 群号 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string QQ { get; set; }
        }
        /// <summary>
        /// 设置群名片`
        /// </summary>
        [HttpPost("Api_SetNameCard")]
        public Task Api_SetNameCard([FromBody] MpqApi_SetNameCardHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_SetNameCard),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
{nameof(input.群号), input.群号},
{nameof(input.QQ), input.QQ},
{nameof(input.名片), input.名片},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 设置群名片`
        /// </summary>
        public class MpqApi_SetNameCardHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 群号 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 名片 { get; set; }
        }
        /// <summary>
        /// 退出讨论组`
        /// </summary>
        [HttpPost("Api_QuitDG")]
        public Task Api_QuitDG([FromBody] MpqApi_QuitDGHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_QuitDG),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
{nameof(input.讨论组ID), input.讨论组ID},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 退出讨论组`
        /// </summary>
        public class MpqApi_QuitDGHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 讨论组ID { get; set; }
        }
        /// <summary>
        /// 删除好友`
        /// </summary>
        [HttpPost("Api_DelFriend")]
        public Task Api_DelFriend([FromBody] MpqApi_DelFriendHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_DelFriend),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
{nameof(input.QQ), input.QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 删除好友`
        /// </summary>
        public class MpqApi_DelFriendHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string QQ { get; set; }
        }
        /// <summary>
        /// 将对象移除群`
        /// </summary>
        [HttpPost("Api_Kick")]
        public Task Api_Kick([FromBody] MpqApi_KickHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_Kick),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
{nameof(input.群号), input.群号},
{nameof(input.对象), input.对象},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 将对象移除群`
        /// </summary>
        public class MpqApi_KickHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 群号 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 对象 { get; set; }
        }
        /// <summary>
        /// 主动加群.为了避免广告、群发行为。出现验证码时将会直接失败不处理`
        /// </summary>
        [HttpPost("Api_JoinGroup")]
        public Task Api_JoinGroup([FromBody] MpqApi_JoinGroupHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_JoinGroup),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
{nameof(input.群号), input.群号},
{nameof(input.附加理由), input.附加理由},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 主动加群.为了避免广告、群发行为。出现验证码时将会直接失败不处理`
        /// </summary>
        public class MpqApi_JoinGroupHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 群号 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 附加理由 { get; set; }
        }
        /// <summary>
        /// 退出群`
        /// </summary>
        [HttpPost("Api_QuitGroup")]
        public Task Api_QuitGroup([FromBody] MpqApi_QuitGroupHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_QuitGroup),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
{nameof(input.群号), input.群号},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 退出群`
        /// </summary>
        public class MpqApi_QuitGroupHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 群号 { get; set; }
        }
        /// <summary>
        /// 返回值:成功返回图片GUID用于发送该图片.失败返回空.  图片尺寸应小于4MB`
        /// </summary>
        [HttpPost("Api_UploadPic")]
        public Task Api_UploadPic([FromBody] MpqApi_UploadPicHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_UploadPic),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
{nameof(input.参_上传类型), input.参_上传类型},
{nameof(input.参_参考对象), input.参_参考对象},
{nameof(input.参_图片数据), input.参_图片数据},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 返回值:成功返回图片GUID用于发送该图片.失败返回空.  图片尺寸应小于4MB`
        /// </summary>
        public class MpqApi_UploadPicHttpInput
        {
            /// <summary>
            /// 机器人QQ
            /// </summary>
            public string 响应的QQ { get; set; }
            /// <summary>
            /// 1好友2群 注:好友图和群图的GUID并不相同并不通用 需要非别上传。群、讨论组用类型2 临时会话、好友信息需要类型1
            /// </summary>
            public int 参_上传类型 { get; set; }
            /// <summary>
            /// 上传该图片所属的群号或QQ
            /// </summary>
            public string 参_参考对象 { get; set; }
            /// <summary>
            /// 址, 图片字节集数据或字节集数据指针()
            /// </summary>
            public string 参_图片数据 { get; set; }
        }
        /// <summary>
        /// 根据图片GUID取得图片下载连接 失败返回空`
        /// </summary>
        [HttpPost("Api_GuidGetPicLink")]
        public Task Api_GuidGetPicLink([FromBody] MpqApi_GuidGetPicLinkHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GuidGetPicLink),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.图片GUID), input.图片GUID},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 根据图片GUID取得图片下载连接 失败返回空`
        /// </summary>
        public class MpqApi_GuidGetPicLinkHttpInput
        {
            /// <summary>
            /// {xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx}.jpg这样的GUID
            /// </summary>
            public string 图片GUID { get; set; }
        }
        /// <summary>
        /// 回复信息 请尽量避免使用该API`
        /// </summary>
        [HttpPost("Api_Reply")]
        public Task Api_Reply([FromBody] MpqApi_ReplyHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_Reply),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
{nameof(input.信息类型), input.信息类型},
{nameof(input.回复对象), input.回复对象},
{nameof(input.内容), input.内容},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 回复信息 请尽量避免使用该API`
        /// </summary>
        public class MpqApi_ReplyHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
            /// <summary>
            /// 1好友 2群 3讨论组 4群临时会话 5讨论组临时会话
            /// </summary>
            public int 信息类型 { get; set; }
            /// <summary>
            /// 接收这条信息的对象
            /// </summary>
            public string 回复对象 { get; set; }
            /// <summary>
            /// 信息内容
            /// </summary>
            public string 内容 { get; set; }
        }
        /// <summary>
        /// 向对象、目标发送信息 支持好友 群 讨论组 群临时会话 讨论组临时会话`
        /// </summary>
        [HttpPost("Api_SendMsg")]
        public Task Api_SendMsg([FromBody] MpqApi_SendMsgHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_SendMsg),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
{nameof(input.信息类型), input.信息类型},
{nameof(input.参考子类型), input.参考子类型},
{nameof(input.收信群_讨论组), input.收信群_讨论组},
{nameof(input.收信对象), input.收信对象},
{nameof(input.内容), input.内容},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 向对象、目标发送信息 支持好友 群 讨论组 群临时会话 讨论组临时会话`
        /// </summary>
        public class MpqApi_SendMsgHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
            /// <summary>
            /// 1好友 2群 3讨论组 4群临时会话 5讨论组临时会话
            /// </summary>
            public int 信息类型 { get; set; }
            /// <summary>
            /// 无特殊说明情况下留空或填零
            /// </summary>
            public int 参考子类型 { get; set; }
            /// <summary>
            /// 发送群信息、讨论组信息、群临时会话信息、讨论组临时会话信息时填写
            /// </summary>
            public string 收信群_讨论组 { get; set; }
            /// <summary>
            /// 最终接收这条信息的对象QQ
            /// </summary>
            public string 收信对象 { get; set; }
            /// <summary>
            /// 信息内容
            /// </summary>
            public string 内容 { get; set; }
        }
        /// <summary>
        /// 发送封包`
        /// </summary>
        [HttpPost("Api_Send")]
        public Task Api_Send([FromBody] MpqApi_SendHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_Send),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.封包内容), input.封包内容},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 发送封包`
        /// </summary>
        public class MpqApi_SendHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 封包内容 { get; set; }
        }
        /// <summary>
        /// 在框架记录页输出一行信息`
        /// </summary>
        [HttpPost("Api_OutPut")]
        public Task Api_OutPut([FromBody] MpqApi_OutPutHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_OutPut),
                MahuaPlatform = MahuaPlatform.Mpq,
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
        /// 在框架记录页输出一行信息`
        /// </summary>
        public class MpqApi_OutPutHttpInput
        {
            /// <summary>
            /// 输出的内容
            /// </summary>
            public string 内容 { get; set; }
        }
        /// <summary>
        /// 取得本插件启用状态`
        /// </summary>
        [HttpPost("Api_IsEnable")]
        public Task Api_IsEnable([FromBody] MpqApi_IsEnableHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_IsEnable),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
                {
                }
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取得本插件启用状态`
        /// </summary>
        public class MpqApi_IsEnableHttpInput
        {
        }
        /// <summary>
        /// 登录一个现存的QQ`
        /// </summary>
        [HttpPost("Api_Login")]
        public Task Api_Login([FromBody] MpqApi_LoginHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_Login),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.QQ), input.QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 登录一个现存的QQ`
        /// </summary>
        public class MpqApi_LoginHttpInput
        {
            /// <summary>
            /// 欲登录的Q
            /// </summary>
            public string QQ { get; set; }
        }
        /// <summary>
        /// 让指定QQ下线`
        /// </summary>
        [HttpPost("Api_Logout")]
        public Task Api_Logout([FromBody] MpqApi_LogoutHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_Logout),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.QQ), input.QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 让指定QQ下线`
        /// </summary>
        public class MpqApi_LogoutHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string QQ { get; set; }
        }
        /// <summary>
        /// tean加密算法`
        /// </summary>
        [HttpPost("Api_Tea加密")]
        public Task Api_Tea加密([FromBody] MpqApi_Tea加密HttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_Tea加密),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.加密内容), input.加密内容},
{nameof(input.Key), input.Key},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// tean加密算法`
        /// </summary>
        public class MpqApi_Tea加密HttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 加密内容 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string Key { get; set; }
        }
        /// <summary>
        /// tean解密算法`
        /// </summary>
        [HttpPost("Api_Tea解密")]
        public Task Api_Tea解密([FromBody] MpqApi_Tea解密HttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_Tea解密),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.解密内容), input.解密内容},
{nameof(input.Key), input.Key},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// tean解密算法`
        /// </summary>
        public class MpqApi_Tea解密HttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 解密内容 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string Key { get; set; }
        }
        /// <summary>
        /// 取用户名`
        /// </summary>
        [HttpPost("Api_GetNick")]
        public Task Api_GetNick([FromBody] MpqApi_GetNickHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetNick),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.QQ), input.QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取用户名`
        /// </summary>
        public class MpqApi_GetNickHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string QQ { get; set; }
        }
        /// <summary>
        /// 取QQ等级+QQ会员等级 返回json格式信息`
        /// </summary>
        [HttpPost("Api_GetQQLevel")]
        public Task Api_GetQQLevel([FromBody] MpqApi_GetQQLevelHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetQQLevel),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.QQ), input.QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取QQ等级+QQ会员等级 返回json格式信息`
        /// </summary>
        public class MpqApi_GetQQLevelHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string QQ { get; set; }
        }
        /// <summary>
        /// 群号转群ID`
        /// </summary>
        [HttpPost("Api_GNGetGid")]
        public Task Api_GNGetGid([FromBody] MpqApi_GNGetGidHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GNGetGid),
                MahuaPlatform = MahuaPlatform.Mpq,
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
        /// 群号转群ID`
        /// </summary>
        public class MpqApi_GNGetGidHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 群号 { get; set; }
        }
        /// <summary>
        /// 群ID转群号`
        /// </summary>
        [HttpPost("Api_GidGetGN")]
        public Task Api_GidGetGN([FromBody] MpqApi_GidGetGNHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GidGetGN),
                MahuaPlatform = MahuaPlatform.Mpq,
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
        /// 群ID转群号`
        /// </summary>
        public class MpqApi_GidGetGNHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 群ID { get; set; }
        }
        /// <summary>
        /// 取框架版本号(发布时间戳`
        /// </summary>
        [HttpPost("Api_GetVersion")]
        public Task Api_GetVersion([FromBody] MpqApi_GetVersionHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetVersion),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
                {
                }
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取框架版本号(发布时间戳`
        /// </summary>
        public class MpqApi_GetVersionHttpInput
        {
        }
        /// <summary>
        /// 取框架版本名`
        /// </summary>
        [HttpPost("Api_GetVersionName")]
        public Task Api_GetVersionName([FromBody] MpqApi_GetVersionNameHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetVersionName),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
                {
                }
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取框架版本名`
        /// </summary>
        public class MpqApi_GetVersionNameHttpInput
        {
        }
        /// <summary>
        /// 取当前框架内部时间戳_周期性与服务器时间同步`
        /// </summary>
        [HttpPost("Api_GetTimeStamp")]
        public Task Api_GetTimeStamp([FromBody] MpqApi_GetTimeStampHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetTimeStamp),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
                {
                }
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取当前框架内部时间戳_周期性与服务器时间同步`
        /// </summary>
        public class MpqApi_GetTimeStampHttpInput
        {
        }
        /// <summary>
        /// 取得框架输出列表内所有信息`
        /// </summary>
        [HttpPost("Api_GetLog")]
        public Task Api_GetLog([FromBody] MpqApi_GetLogHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetLog),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
                {
                }
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取得框架输出列表内所有信息`
        /// </summary>
        public class MpqApi_GetLogHttpInput
        {
        }
        /// <summary>
        /// 判断是否处于被屏蔽群信息状态。`
        /// </summary>
        [HttpPost("Api_IfBlock")]
        public Task Api_IfBlock([FromBody] MpqApi_IfBlockHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_IfBlock),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 判断是否处于被屏蔽群信息状态。`
        /// </summary>
        public class MpqApi_IfBlockHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
        }
        /// <summary>
        /// 取包括群主在内的群管列表`
        /// </summary>
        [HttpPost("Api_GetAdminList")]
        public Task Api_GetAdminList([FromBody] MpqApi_GetAdminListHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetAdminList),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
{nameof(input.群号), input.群号},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取包括群主在内的群管列表`
        /// </summary>
        public class MpqApi_GetAdminListHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 群号 { get; set; }
        }
        /// <summary>
        /// 发说说`
        /// </summary>
        [HttpPost("Api_AddTaotao")]
        public Task Api_AddTaotao([FromBody] MpqApi_AddTaotaoHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_AddTaotao),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
{nameof(input.内容), input.内容},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 发说说`
        /// </summary>
        public class MpqApi_AddTaotaoHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 内容 { get; set; }
        }
        /// <summary>
        /// 取个签`
        /// </summary>
        [HttpPost("Api_GetSign")]
        public Task Api_GetSign([FromBody] MpqApi_GetSignHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetSign),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
{nameof(input.对象), input.对象},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取个签`
        /// </summary>
        public class MpqApi_GetSignHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 对象 { get; set; }
        }
        /// <summary>
        /// 设置个签`
        /// </summary>
        [HttpPost("Api_SetSign")]
        public Task Api_SetSign([FromBody] MpqApi_SetSignHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_SetSign),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
{nameof(input.内容), input.内容},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 设置个签`
        /// </summary>
        public class MpqApi_SetSignHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 内容 { get; set; }
        }
        /// <summary>
        /// 通过qun.qzone.qq.com接口取得取群列表.成功返回转码后的JSON格式文本信息`
        /// </summary>
        [HttpPost("Api_GetGroupListA")]
        public Task Api_GetGroupListA([FromBody] MpqApi_GetGroupListAHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetGroupListA),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 通过qun.qzone.qq.com接口取得取群列表.成功返回转码后的JSON格式文本信息`
        /// </summary>
        public class MpqApi_GetGroupListAHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
        }
        /// <summary>
        /// 通过qun.qq.com接口取得取群列表.成功返回转码后的JSON格式文本信息`
        /// </summary>
        [HttpPost("Api_GetGroupListB")]
        public Task Api_GetGroupListB([FromBody] MpqApi_GetGroupListBHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetGroupListB),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 通过qun.qq.com接口取得取群列表.成功返回转码后的JSON格式文本信息`
        /// </summary>
        public class MpqApi_GetGroupListBHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
        }
        /// <summary>
        /// 通过qun.qq.com接口取得群成员列表 成功返回转码后的JSON格式文本`
        /// </summary>
        [HttpPost("Api_GetGroupMemberA")]
        public Task Api_GetGroupMemberA([FromBody] MpqApi_GetGroupMemberAHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetGroupMemberA),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
{nameof(input.群号), input.群号},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 通过qun.qq.com接口取得群成员列表 成功返回转码后的JSON格式文本`
        /// </summary>
        public class MpqApi_GetGroupMemberAHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 群号 { get; set; }
        }
        /// <summary>
        /// 通过qun.qzone.qq.com接口取得群成员列表 成功返回转码后的JSON格式文本`
        /// </summary>
        [HttpPost("Api_GetGroupMemberB")]
        public Task Api_GetGroupMemberB([FromBody] MpqApi_GetGroupMemberBHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetGroupMemberB),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
{nameof(input.群号), input.群号},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 通过qun.qzone.qq.com接口取得群成员列表 成功返回转码后的JSON格式文本`
        /// </summary>
        public class MpqApi_GetGroupMemberBHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 群号 { get; set; }
        }
        /// <summary>
        /// 通过qun.qq.com接口取得好友列表。成功返回转码后的JSON文本`
        /// </summary>
        [HttpPost("Api_GetFriendList")]
        public Task Api_GetFriendList([FromBody] MpqApi_GetFriendListHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetFriendList),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 通过qun.qq.com接口取得好友列表。成功返回转码后的JSON文本`
        /// </summary>
        public class MpqApi_GetFriendListHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
        }
        /// <summary>
        /// 取Q龄 成功返回Q龄 失败返回-1`
        /// </summary>
        [HttpPost("Api_GetQQAge")]
        public Task Api_GetQQAge([FromBody] MpqApi_GetQQAgeHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetQQAge),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
{nameof(input.QQ), input.QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取Q龄 成功返回Q龄 失败返回-1`
        /// </summary>
        public class MpqApi_GetQQAgeHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string QQ { get; set; }
        }
        /// <summary>
        /// 取年龄 成功返回年龄 失败返回-1`
        /// </summary>
        [HttpPost("Api_GetAge")]
        public Task Api_GetAge([FromBody] MpqApi_GetAgeHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetAge),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
{nameof(input.QQ), input.QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取年龄 成功返回年龄 失败返回-1`
        /// </summary>
        public class MpqApi_GetAgeHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string QQ { get; set; }
        }
        /// <summary>
        /// 取个人说明`
        /// </summary>
        [HttpPost("Api_GetPersonalProfile")]
        public Task Api_GetPersonalProfile([FromBody] MpqApi_GetPersonalProfileHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetPersonalProfile),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
{nameof(input.QQ), input.QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取个人说明`
        /// </summary>
        public class MpqApi_GetPersonalProfileHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
            /// <summary>
            /// 对象QQ
            /// </summary>
            public string QQ { get; set; }
        }
        /// <summary>
        /// 取邮箱 成功返回邮箱 失败返回空`
        /// </summary>
        [HttpPost("Api_GetEmail")]
        public Task Api_GetEmail([FromBody] MpqApi_GetEmailHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetEmail),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
{nameof(input.QQ), input.QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取邮箱 成功返回邮箱 失败返回空`
        /// </summary>
        public class MpqApi_GetEmailHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string QQ { get; set; }
        }
        /// <summary>
        /// 取对象性别 1男 2女  未或失败返回-1`
        /// </summary>
        [HttpPost("Api_GetGender")]
        public Task Api_GetGender([FromBody] MpqApi_GetGenderHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetGender),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
{nameof(input.QQ), input.QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取对象性别 1男 2女  未或失败返回-1`
        /// </summary>
        public class MpqApi_GetGenderHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string QQ { get; set; }
        }
        /// <summary>
        /// 向好友发送‘正在输入’的状态信息.当好友收到信息之后 “正在输入”状态会立刻被打断`
        /// </summary>
        [HttpPost("Api_SendTyping")]
        public Task Api_SendTyping([FromBody] MpqApi_SendTypingHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_SendTyping),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
{nameof(input.QQ), input.QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 向好友发送‘正在输入’的状态信息.当好友收到信息之后 “正在输入”状态会立刻被打断`
        /// </summary>
        public class MpqApi_SendTypingHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string QQ { get; set; }
        }
        /// <summary>
        /// 向好友发送窗口抖动信息`
        /// </summary>
        [HttpPost("Api_SendShake")]
        public Task Api_SendShake([FromBody] MpqApi_SendShakeHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_SendShake),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
{nameof(input.QQ), input.QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 向好友发送窗口抖动信息`
        /// </summary>
        public class MpqApi_SendShakeHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string QQ { get; set; }
        }
        /// <summary>
        /// 取得框架内随机一个在线且可以使用的QQ`
        /// </summary>
        [HttpPost("Api_GetRadomOnlineQQ")]
        public Task Api_GetRadomOnlineQQ([FromBody] MpqApi_GetRadomOnlineQQHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetRadomOnlineQQ),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
                {
                }
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取得框架内随机一个在线且可以使用的QQ`
        /// </summary>
        public class MpqApi_GetRadomOnlineQQHttpInput
        {
        }
        /// <summary>
        /// 往帐号列表添加一个Q.当该Q已存在时则覆盖密码`
        /// </summary>
        [HttpPost("Api_AddQQ")]
        public Task Api_AddQQ([FromBody] MpqApi_AddQQHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_AddQQ),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.QQ), input.QQ},
{nameof(input.密码), input.密码},
{nameof(input.自动登录), input.自动登录},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 往帐号列表添加一个Q.当该Q已存在时则覆盖密码`
        /// </summary>
        public class MpqApi_AddQQHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 密码 { get; set; }
            /// <summary>
            /// 运行框架时是否自动登录该Q.若添加后需要登录该Q则需要通过Api_Login操作
            /// </summary>
            public bool 自动登录 { get; set; }
        }
        /// <summary>
        /// 设置在线状态+附加信息 `
        /// </summary>
        [HttpPost("Api_SetOLStatus")]
        public Task Api_SetOLStatus([FromBody] MpqApi_SetOLStatusHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_SetOLStatus),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
{nameof(input.在线状态), input.在线状态},
{nameof(input.状态附加信息), input.状态附加信息},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 设置在线状态+附加信息 `
        /// </summary>
        public class MpqApi_SetOLStatusHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
            /// <summary>
            /// 1~6 分别对应我在线上, Q我吧, 离开, 忙碌, 请勿打扰, 隐身
            /// </summary>
            public int 在线状态 { get; set; }
            /// <summary>
            /// 最大255字节
            /// </summary>
            public string 状态附加信息 { get; set; }
        }
        /// <summary>
        /// 取得机器码`
        /// </summary>
        [HttpPost("Api_GetMC")]
        public Task Api_GetMC([FromBody] MpqApi_GetMCHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetMC),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
                {
                }
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 取得机器码`
        /// </summary>
        public class MpqApi_GetMCHttpInput
        {
        }
        /// <summary>
        /// 邀请对象加入群 失败返回错误理由`
        /// </summary>
        [HttpPost("Api_GroupInvitation")]
        public Task Api_GroupInvitation([FromBody] MpqApi_GroupInvitationHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GroupInvitation),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
{nameof(input.好友QQ), input.好友QQ},
{nameof(input.群号), input.群号},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 邀请对象加入群 失败返回错误理由`
        /// </summary>
        public class MpqApi_GroupInvitationHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
            /// <summary>
            /// 多个好友用换行分割
            /// </summary>
            public string 好友QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 群号 { get; set; }
        }
        /// <summary>
        /// 创建一个讨论组 成功返回讨论组ID 失败返回空 注:每24小时只能创建100个讨论组 悠着点用`
        /// </summary>
        [HttpPost("Api_CreateDG")]
        public Task Api_CreateDG([FromBody] MpqApi_CreateDGHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_CreateDG),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 创建一个讨论组 成功返回讨论组ID 失败返回空 注:每24小时只能创建100个讨论组 悠着点用`
        /// </summary>
        public class MpqApi_CreateDGHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
        }
        /// <summary>
        /// 将对象移除讨论组.成功返回空 失败返回理由`
        /// </summary>
        [HttpPost("Api_KickDG")]
        public Task Api_KickDG([FromBody] MpqApi_KickDGHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_KickDG),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
{nameof(input.讨论组ID), input.讨论组ID},
{nameof(input.成员), input.成员},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 将对象移除讨论组.成功返回空 失败返回理由`
        /// </summary>
        public class MpqApi_KickDGHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 讨论组ID { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 成员 { get; set; }
        }
        /// <summary>
        /// 邀请对象加入讨论组 成功返回空 失败返回理由`
        /// </summary>
        [HttpPost("Api_DGInvitation")]
        public Task Api_DGInvitation([FromBody] MpqApi_DGInvitationHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_DGInvitation),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
{nameof(input.讨论组ID), input.讨论组ID},
{nameof(input.成员组), input.成员组},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 邀请对象加入讨论组 成功返回空 失败返回理由`
        /// </summary>
        public class MpqApi_DGInvitationHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 讨论组ID { get; set; }
            /// <summary>
            /// 多个成员用换行符分割
            /// </summary>
            public string 成员组 { get; set; }
        }
        /// <summary>
        /// 成功返回以换行符分割的讨论组号列表.最大为100个讨论组  失败返回空`
        /// </summary>
        [HttpPost("Api_GetDGList")]
        public Task Api_GetDGList([FromBody] MpqApi_GetDGListHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_GetDGList),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 成功返回以换行符分割的讨论组号列表.最大为100个讨论组  失败返回空`
        /// </summary>
        public class MpqApi_GetDGListHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
        }
        /// <summary>
        /// 向对象发送一条音乐信息（所谓的点歌）次数不限`
        /// </summary>
        [HttpPost("Api_SendMusic")]
        public Task Api_SendMusic([FromBody] MpqApi_SendMusicHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_SendMusic),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
{nameof(input.收信对象类型), input.收信对象类型},
{nameof(input.收信对象所属群_讨论组), input.收信对象所属群_讨论组},
{nameof(input.收信对象QQ), input.收信对象QQ},
{nameof(input.音乐简介), input.音乐简介},
{nameof(input.音乐播放页面连接), input.音乐播放页面连接},
{nameof(input.音乐封面连接), input.音乐封面连接},
{nameof(input.音乐文件直连连接), input.音乐文件直连连接},
{nameof(input.曲名), input.曲名},
{nameof(input.歌手名), input.歌手名},
{nameof(input.音乐来源名), input.音乐来源名},
{nameof(input.音乐来源图标连接), input.音乐来源图标连接},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 向对象发送一条音乐信息（所谓的点歌）次数不限`
        /// </summary>
        public class MpqApi_SendMusicHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
            /// <summary>
            /// 同Api_SendMsg  1好友 2群 3讨论组 4群临时会话 5讨论组临时会话
            /// </summary>
            public int 收信对象类型 { get; set; }
            /// <summary>
            /// 发群内、临时会话必填 好友可不填
            /// </summary>
            public string 收信对象所属群_讨论组 { get; set; }
            /// <summary>
            /// 临时会话、好友必填 发至群内可不填
            /// </summary>
            public string 收信对象QQ { get; set; }
            /// <summary>
            /// 留空默认‘QQ音乐 的分享’
            /// </summary>
            public string 音乐简介 { get; set; }
            /// <summary>
            /// 任意直连或短链接均可 留空为空 无法点开
            /// </summary>
            public string 音乐播放页面连接 { get; set; }
            /// <summary>
            /// 任意直连或短链接均可 可空 例:http://url.cn/cDiJT4
            /// </summary>
            public string 音乐封面连接 { get; set; }
            /// <summary>
            /// 任意直连或短链接均可 不可空 例:http://url.cn/djwXjr
            /// </summary>
            public string 音乐文件直连连接 { get; set; }
            /// <summary>
            /// 可空
            /// </summary>
            public string 曲名 { get; set; }
            /// <summary>
            /// 可空
            /// </summary>
            public string 歌手名 { get; set; }
            /// <summary>
            /// 可空 为空默认QQ音乐
            /// </summary>
            public string 音乐来源名 { get; set; }
            /// <summary>
            /// 可空 为空默认QQ音乐 http://qzonestyle.gtimg.cn/ac/qzone/applogo/64/308/100497308_64.gif
            /// </summary>
            public string 音乐来源图标连接 { get; set; }
        }
        /// <summary>
        /// `
        /// </summary>
        [HttpPost("Api_SendObjectMsg")]
        public Task Api_SendObjectMsg([FromBody] MpqApi_SendObjectMsgHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_SendObjectMsg),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
{nameof(input.收信对象类型), input.收信对象类型},
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
        /// `
        /// </summary>
        public class MpqApi_SendObjectMsgHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
            /// <summary>
            /// 同Api_SendMsg  1好友 2群 3讨论组 4群临时会话 5讨论组临时会话
            /// </summary>
            public int 收信对象类型 { get; set; }
            /// <summary>
            /// 发群内、临时会话必填 好友可不填
            /// </summary>
            public string 收信对象所属群_讨论组 { get; set; }
            /// <summary>
            /// 临时会话、好友必填 发至群内可不填
            /// </summary>
            public string 收信对象QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string ObjectMsg { get; set; }
            /// <summary>
            /// 00 基本 02 点歌 其他不明
            /// </summary>
            public int 结构子类型 { get; set; }
        }
        /// <summary>
        /// 判断对象是否为好友（双向）`
        /// </summary>
        [HttpPost("Api_IsFriend")]
        public Task Api_IsFriend([FromBody] MpqApi_IsFriendHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(Api_IsFriend),
                MahuaPlatform = MahuaPlatform.Mpq,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.响应的QQ), input.响应的QQ},
{nameof(input.对象QQ), input.对象QQ},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// 判断对象是否为好友（双向）`
        /// </summary>
        public class MpqApi_IsFriendHttpInput
        {
            /// <summary>
            /// 
            /// </summary>
            public string 响应的QQ { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string 对象QQ { get; set; }
        }
    }
}
