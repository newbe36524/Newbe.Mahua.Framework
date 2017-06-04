using System;
using System.Runtime.InteropServices;
using Newbe.Mahua.CQP.Commands;
using Newbe.Mahua.MahuaEvents.Enums;
using RGiesecke.DllExport;

namespace Newbe.Mahua.CQP
{
    /// <summary>
    /// 暴露非托管代码的api集合
    /// </summary>
    public sealed class PluginApiExporter : IPluginApiExporter
    {
        public const string CoolApiVersion = "9";
        public MahuaPlatform MahuaPlatform { get; } = MahuaPlatform.Cqp;

        private static DateTime ConvertToDatetime(int time)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0).ToLocalTime().AddSeconds(time);
        }

        /// <summary>
        /// 此函数会在插件被开启时发生。
        /// </summary>
        /// <returns>返回处理过程是否成功的值。</returns>
        [DllExport("_eventEnable", CallingConvention.StdCall)]
        public static int Enabled()
        {
            PluginInstanceManager.GetInstance().SendCommand(new EnabledCommand());
            return 0;
        }

        /// <summary>
        /// 此函数会在插件被禁用时发生。
        /// </summary>
        /// <returns>返回处理过程是否成功的值。</returns>
        [DllExport("_eventDisable", CallingConvention.StdCall)]
        public static int Disabled()
        {
            PluginInstanceManager.GetInstance().SendCommand(new DisabledCommand());
            return 0;
        }

        /// <summary>
        /// 向酷Q提供插件信息。
        /// </summary>
        /// <returns>一个固定格式字符串。</returns>
        [DllExport("AppInfo", CallingConvention.StdCall)]
        public static string AppInfo()
        {
            var re = PluginInstanceManager.GetInstance().SendCommand<AppInfoCommandResult>(new AppInfoCommand());
            return $"{CoolApiVersion},{re.AppId}".ToLowerInvariant();
        }

        /// <summary>
        /// 获取此插件的AuthCode。
        /// </summary>
        /// <param name="authcode">由酷Q提供的AuthCode。</param>
        /// <returns></returns>
        [DllExport("Initialize", CallingConvention.StdCall)]
        public static int Initialize(int authcode)
        {
            PluginInstanceManager.GetInstance().SendCommand(new InitializeCommand
            {
                AuthCode = authcode
            });
            return 0;
        }

        /// <summary>
        /// 此函数会在酷Q退出时被调用。
        /// </summary>
        /// <returns></returns>
        [DllExport("_eventExit", CallingConvention.StdCall)]
        public static int CoolQExited()
        {
            PluginInstanceManager.GetInstance().SendCommand(new CoolQExitedCommand());
            return 0;
        }


        /// <summary>
        /// 处理私聊消息。
        /// </summary>
        /// <param name="subType">私聊消息类型。11代表消息来自好友；1代表消息来自在线状态；2代表消息来自群；3代表消息来自讨论组。</param>
        /// <param name="sendTime">消息发送时间的时间戳。</param>
        /// <param name="fromQQ">发送此消息的QQ号码。</param>
        /// <param name="msg">消息的内容。</param>
        /// <param name="font">消息所使用的字体。</param>
        /// <returns>是否拦截消息的值，0为忽略消息，1为拦截消息。</returns>
        [DllExport("_eventPrivateMsg", CallingConvention.StdCall)]
        public static int ProcessPrivateMessage(int subType, int sendTime, long fromQQ, string msg, int font)
        {
            PrivateMessageFromType privateMessageFromType;
            switch (subType)
            {
                case 11:
                    privateMessageFromType = PrivateMessageFromType.Friend;
                    break;
                case 1:
                    privateMessageFromType = PrivateMessageFromType.Online;
                    break;
                case 2:
                    privateMessageFromType = PrivateMessageFromType.Group;
                    break;
                case 3:
                    privateMessageFromType = PrivateMessageFromType.DiscussGroup;
                    break;
                default:
                    privateMessageFromType = PrivateMessageFromType.Unknown;
                    break;
            }
            PluginInstanceManager.GetInstance().SendCommand(new PrivateMessageCommand
            {
                PrivateMessageFromType = privateMessageFromType,
                FormNum = fromQQ,
                Message = msg,
                SendTime = ConvertToDatetime(sendTime),
            });
            return 0;
        }


        /// <summary>
        /// 处理群聊消息。
        /// </summary>
        /// <param name="subType">消息类型，目前固定为1。</param>
        /// <param name="sendTime">消息发送时间的时间戳。</param>
        /// <param name="fromGroup">消息来源群号。</param>
        /// <param name="fromQQ">发送此消息的QQ号码。</param>
        /// <param name="fromAnonymous">发送此消息的匿名用户。</param>
        /// <param name="msg">消息内容。</param>
        /// <param name="font">消息所使用字体。</param>
        /// <returns>是否拦截消息的值，0为忽略消息，1为拦截消息。</returns>
        [DllExport("_eventGroupMsg", CallingConvention.StdCall)]
        public static int ProcessGroupMessage(int subType, int sendTime, long fromGroup, long fromQQ,
            string fromAnonymous,
            string msg, int font)
        {
            PluginInstanceManager.GetInstance().SendCommand(new GroupMessageCommand
            {
                SendTime = ConvertToDatetime(sendTime),
                Message = msg,
                GroupNum = fromGroup,
                FromAnonymous = fromAnonymous,
                FromQq = fromQQ,
            });
            return 0;
        }

        /// <summary>
        /// 处理讨论组消息。
        /// </summary>
        /// <param name="subType">消息类型，目前固定为1。</param>
        /// <param name="sendTime">消息发送时间的时间戳。</param>
        /// <param name="fromDiscuss">消息来源讨论组号。</param>
        /// <param name="fromQQ">发送此消息的QQ号码。</param>
        /// <param name="msg">消息内容。</param>
        /// <param name="font">消息所使用字体。</param>
        /// <returns>是否拦截消息的值，0为忽略消息，1为拦截消息。</returns>
        [DllExport("_eventDiscussMsg", CallingConvention.StdCall)]
        public static int ProcessDiscussGroupMessage(int subType, int sendTime, long fromDiscuss, long fromQQ,
            string msg,
            int font)
        {
            PluginInstanceManager.GetInstance().SendCommand(new DiscussGroupMessageCommand()
            {
                SendTime = ConvertToDatetime(sendTime),
                Message = msg,
                DiscussGroupNum = fromDiscuss,
                FromQq = fromQQ,
            });
            return 0;
        }

        /// <summary>
        /// 处理群文件上传事件。
        /// </summary>
        /// <param name="subType">消息类型，目前固定为1。</param>
        /// <param name="sendTime">事件发生时间的时间戳。</param>
        /// <param name="fromGroup">事件来源群号。</param>
        /// <param name="fromQQ">上传此文件的QQ号码。</param>
        /// <param name="file">上传的文件的信息。</param>
        /// <returns>是否拦截消息的值，0为忽略消息，1为拦截消息。</returns>
        [DllExport("_eventGroupUpload", CallingConvention.StdCall)]
        public static int ProcessGroupUpload(int subType, int sendTime, long fromGroup, long fromQQ, string file)
        {
            PluginInstanceManager.GetInstance().SendCommand(new GroupUploadedCommand
            {
                SendTime = ConvertToDatetime(sendTime),
                GroupNum = fromGroup,
                FromQq = fromQQ,
                File = file
            });
            return 0;
        }

        /// <summary>
        /// 处理群管理员变动事件。
        /// </summary>
        /// <param name="subType">事件类型。1为被取消管理员，2为被设置管理员。</param>
        /// <param name="sendTime">事件发生时间的时间戳。</param>
        /// <param name="fromGroup">事件来源群号。</param>
        /// <param name="target">被操作的QQ。</param>
        /// <returns>是否拦截消息的值，0为忽略消息，1为拦截消息。</returns>
        [DllExport("_eventSystem_GroupAdmin", CallingConvention.StdCall)]
        public static int ProcessGroupAdminChange(int subType, int sendTime, long fromGroup, long target)
        {
            PluginInstanceManager.GetInstance().SendCommand(new GroupAdminChangeCommand
            {
                SendTime = ConvertToDatetime(sendTime),
                GroupAdminChangeType = subType == 1 ? GroupAdminChangeType.Disabled : GroupAdminChangeType.Enabled,
                ToQq = target,
                FromGroup = fromGroup
            });
            return 0;
        }

        /// <summary>
        /// 处理群成员数量减少事件。
        /// </summary>
        /// <param name="subType">事件类型。1为群员离开；2为群员被踢为；3为自己(即登录号)被踢。</param>
        /// <param name="sendTime">事件发生时间的时间戳。</param>
        /// <param name="fromGroup">事件来源群号。</param>
        /// <param name="fromQQ">事件来源QQ。</param>
        /// <param name="target">被操作的QQ。</param>
        /// <returns>是否拦截消息的值，0为忽略消息，1为拦截消息。</returns>
        [DllExport("_eventSystem_GroupMemberDecrease", CallingConvention.StdCall)]
        public static int ProcessGroupMemberDecrease(int subType, int sendTime, long fromGroup, long fromQQ,
            long target)
        {
            GroupMemberDecreasedReason reason;
            switch (subType)
            {
                case 1:
                    reason = GroupMemberDecreasedReason.Leavebyself;
                    break;
                case 2:
                    reason = GroupMemberDecreasedReason.Kicked;
                    break;
                case 3:
                    reason = GroupMemberDecreasedReason.Kicked;
                    break;
                default:
                    reason = GroupMemberDecreasedReason.Unknow;
                    break;
            }
            PluginInstanceManager.GetInstance().SendCommand(new GroupMemberDecreasedCommand
            {
                SendTime = ConvertToDatetime(sendTime),
                ToQq = target,
                FromGroup = fromGroup,
                FromQq = fromQQ,
                GroupMemberDecreasedReason = reason,
            });
            return 0;
        }

        /// <summary>
        /// 处理群成员添加事件。
        /// </summary>
        /// <param name="subType">事件类型。1为管理员已同意；2为管理员邀请。</param>
        /// <param name="sendTime">事件发生时间的时间戳。</param>
        /// <param name="fromGroup">事件来源群号。</param>
        /// <param name="fromQQ">事件来源QQ。</param>
        /// <param name="target">被操作的QQ。</param>
        /// <returns>是否拦截消息的值，0为忽略消息，1为拦截消息。</returns>
        [DllExport("_eventSystem_GroupMemberIncrease", CallingConvention.StdCall)]
        public static int ProcessGroupMemberIncrease(int subType, int sendTime, long fromGroup, long fromQQ,
            long target)
        {
            GroupMemberIncreasedReason reason;
            switch (subType)
            {
                case 1:
                    reason = GroupMemberIncreasedReason.AdminAllowed;
                    break;
                case 2:
                    reason = GroupMemberIncreasedReason.GroupMemberInvitated;
                    break;
                default:
                    reason = GroupMemberIncreasedReason.Unknow;
                    break;
            }
            PluginInstanceManager.GetInstance().SendCommand(new GroupMemberIncreasedCommand
            {
                SendTime = ConvertToDatetime(sendTime),
                ToQq = target,
                FromGroup = fromGroup,
                FromQq = fromQQ,
                GroupMemberIncreasedReason = reason,
            });
            return 0;
        }

        /// <summary>
        /// 处理好友已添加事件。
        /// </summary>
        /// <param name="subType">事件类型。固定为1。</param>
        /// <param name="sendTime">事件发生时间的时间戳。</param>
        /// <param name="fromQQ">事件来源QQ。</param>
        /// <returns>是否拦截消息的值，0为忽略消息，1为拦截消息。</returns>
        [DllExport("_eventFriend_Add", CallingConvention.StdCall)]
        public static int ProcessFriendsAdded(int subType, int sendTime, long fromQQ)
        {
            PluginInstanceManager.GetInstance().SendCommand(new FriendsAddedCommand
            {
                SendTime = ConvertToDatetime(sendTime),
                FromQq = fromQQ
            });
            return 0;
        }

        /// <summary>
        /// 处理好友添加请求。
        /// </summary>
        /// <param name="subType">事件类型。固定为1。</param>
        /// <param name="sendTime">事件发生时间的时间戳。</param>
        /// <param name="fromQQ">事件来源QQ。</param>
        /// <param name="msg">附言内容。</param>
        /// <param name="font">消息所使用字体。</param>
        /// <returns>是否拦截消息的值，0为忽略消息，1为拦截消息。</returns>
        [DllExport("_eventRequest_AddFriend", CallingConvention.StdCall)]
        public static int ProcessAddFriendRequest(int subType, int sendTime, long fromQQ, string msg, int font)
        {
            PluginInstanceManager.GetInstance().SendCommand(new AddFriendRequestCommand
            {
                SendTime = ConvertToDatetime(sendTime),
                FromQq = fromQQ,
                Message = msg
            });
            return 0;
        }

        /// <summary>
        /// 处理加群请求。
        /// </summary>
        /// <param name="subType">请求类型。1为他人申请入群；2为自己(即登录号)受邀入群。</param>
        /// <param name="sendTime">请求发送时间戳。</param>
        /// <param name="fromGroup">要加入的群的群号。</param>
        /// <param name="fromQQ">发送此请求的QQ号码。</param>
        /// <param name="msg">附言内容。</param>
        /// <param name="responseMark">用于处理请求的标识。</param>
        /// <returns>是否拦截消息的值，0为忽略消息，1为拦截消息。</returns>
        [DllExport("_eventRequest_AddGroup", CallingConvention.StdCall)]
        public static int ProcessJoinGroupRequest(int subType, int sendTime, long fromGroup, long fromQQ, string msg,
            string responseMark)
        {
            switch (subType)
            {
                case 1: //管理员收到入群申请
                    PluginInstanceManager.GetInstance().SendCommand(new GroupJoiningRequestCommand
                    {
                        SendTime = ConvertToDatetime(sendTime),
                        FromQq = fromQQ,
                        ToGroup = fromGroup,
                        Message = msg,
                        GroupJoiningRequestId = responseMark,
                    });
                    break;

                case 2: //收到加群邀请
                    PluginInstanceManager.GetInstance().SendCommand(new GroupJoiningInvitationCommand
                    {
                        SendTime = ConvertToDatetime(sendTime),
                        FromQq = fromQQ,
                        ToGroup = fromGroup,
                        Message = msg,
                        GroupJoiningInvitationId = responseMark,
                    });
                    break;
                default:
                    break;
            }
            return 0;
        }

        #region 菜单

        /// <summary>
        /// 菜单A
        /// </summary>
        /// <returns></returns>
        [DllExport("_menuA", CallingConvention.StdCall)]
        public static int ProcessMenuClickA() => throw new NotImplementedException();

        /// <summary>
        /// 菜单B
        /// </summary>
        /// <returns></returns>
        [DllExport("_menuB", CallingConvention.StdCall)]
        public static int ProcessMenuClickB() => throw new NotImplementedException();

        /// <summary>
        /// 菜单C
        /// </summary>
        /// <returns></returns>
        [DllExport("_menuC", CallingConvention.StdCall)]
        public static int ProcessMenuClickC() => throw new NotImplementedException();

        /// <summary>
        /// 菜单D
        /// </summary>
        /// <returns></returns>
        [DllExport("_menuD", CallingConvention.StdCall)]
        public static int ProcessMenuClickD() => throw new NotImplementedException();

        /// <summary>
        /// 菜单E
        /// </summary>
        /// <returns></returns>
        [DllExport("_menuE", CallingConvention.StdCall)]
        public static int ProcessMenuClickE() => throw new NotImplementedException();

        /// <summary>
        /// 菜单F
        /// </summary>
        /// <returns></returns>
        [DllExport("_menuF", CallingConvention.StdCall)]
        public static int ProcessMenuClickF() => throw new NotImplementedException();

        /// <summary>
        /// 菜单G
        /// </summary>
        /// <returns></returns>
        [DllExport("_menuG", CallingConvention.StdCall)]
        public static int ProcessMenuClickG() => throw new NotImplementedException();

        /// <summary>
        /// 菜单H
        /// </summary>
        /// <returns></returns>
        [DllExport("_menuH", CallingConvention.StdCall)]
        public static int ProcessMenuClickH() => throw new NotImplementedException();

        /// <summary>
        /// 菜单I
        /// </summary>
        /// <returns></returns>
        [DllExport("_menuI", CallingConvention.StdCall)]
        public static int ProcessMenuClickI() => throw new NotImplementedException();

        #endregion
    }
}