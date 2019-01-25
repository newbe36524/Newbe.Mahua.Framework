using System;
using System.Runtime.InteropServices;
using Newbe.Mahua.CQP.MahuaEventOutputs;

namespace Newbe.Mahua.CQP.Native
{
    /// <summary>
    /// 暴露非托管代码的api集合
    /// </summary>
    public sealed class PluginApiExporter : IPluginApiExporter
    {
        private const string CoolApiVersion = "9";

        /// <summary>
        /// 此函数会在插件被开启时发生。
        /// </summary>
        /// <returns>返回处理过程是否成功的值。</returns>
        [DllExport("_eventEnable", CallingConvention.StdCall)]
        public static int Enabled()
        {
            PluginInstanceManager.GetInstance().HandleMahuaOutput(new Enabled());
            return 0;
        }

        /// <summary>
        /// 此函数会在插件被禁用时发生。
        /// </summary>
        /// <returns>返回处理过程是否成功的值。</returns>
        [DllExport("_eventDisable", CallingConvention.StdCall)]
        public static int Disabled()
        {
            PluginInstanceManager.GetInstance().HandleMahuaOutput(new Disabled());
            return 0;
        }

        /// <summary>
        /// 向酷Q提供插件信息。
        /// </summary>
        /// <returns>一个固定格式字符串。</returns>
        [DllExport("AppInfo", CallingConvention.StdCall)]
        public static string AppInfo()
        {
            return $"{CoolApiVersion},{AgentInfo.Instance.Id}".ToLowerInvariant();
        }

        /// <summary>
        /// 获取此插件的AuthCode。
        /// </summary>
        /// <param name="authcode">由酷Q提供的AuthCode。</param>
        /// <returns></returns>
        [DllExport("Initialize", CallingConvention.StdCall)]
        public static int Initialize(int authcode)
        {
            CqpAuthCodeContainer.StaticAuthCode = authcode;
            PluginInstanceManager.GetInstance().HandleMahuaOutput(new Initialize
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
            PluginInstanceManager.GetInstance().HandleMahuaOutput(new CoolQExited());
            return 0;
        }

        /// <summary>
        /// 处理私聊消息。
        /// </summary>
        /// <param name="subType">私聊消息类型。11代表消息来自好友；1代表消息来自在线状态；2代表消息来自群；3代表消息来自讨论组。</param>
        /// <param name="msgId">消息Id。</param>
        /// <param name="fromQQ">发送此消息的QQ号码。</param>
        /// <param name="msg">消息的内容。</param>
        /// <param name="font">消息所使用的字体。</param>
        /// <returns>是否拦截消息的值，0为忽略消息，1为拦截消息。</returns>
        [DllExport("_eventPrivateMsg", CallingConvention.StdCall)]
        public static int ProcessPrivateMessage(int subType, int msgId, long fromQQ, string msg, int font)
        {
            PluginInstanceManager.GetInstance().HandleMahuaOutput(new ProcessPrivateMessage
            {
                SubType = subType,
                FromQQ = fromQQ,
                Msg = msg,
                MsgId = msgId,
                Font = font,
            });
            return 0;
        }

        /// <summary>
        /// 处理群聊消息。
        /// </summary>
        /// <param name="subType">消息类型，目前固定为1。</param>
        /// <param name="msgId">消息Id</param>
        /// <param name="fromGroup">消息来源群号。</param>
        /// <param name="fromQQ">发送此消息的QQ号码。</param>
        /// <param name="fromAnonymous">发送此消息的匿名用户。</param>
        /// <param name="msg">消息内容。</param>
        /// <param name="font">消息所使用字体。</param>
        /// <returns>是否拦截消息的值，0为忽略消息，1为拦截消息。</returns>
        [DllExport("_eventGroupMsg", CallingConvention.StdCall)]
        public static int ProcessGroupMessage(
            int subType,
            int msgId,
            long fromGroup,
            long fromQQ,
            string fromAnonymous,
            string msg,
            int font)
        {
            PluginInstanceManager.GetInstance().HandleMahuaOutput(new ProcessGroupMessage
            {
                SubType = subType,
                Message = msg,
                FromGroup = fromGroup,
                FromAnonymous = fromAnonymous,
                FromQQ = fromQQ,
                MsgId = msgId,
                Font = font,
            });
            return 0;
        }

        /// <summary>
        /// 处理讨论组消息。
        /// </summary>
        /// <param name="subType">消息类型，目前固定为1。</param>
        /// <param name="msgId">消息Id</param>
        /// <param name="fromDiscuss">消息来源讨论组号。</param>
        /// <param name="fromQQ">发送此消息的QQ号码。</param>
        /// <param name="msg">消息内容。</param>
        /// <param name="font">消息所使用字体。</param>
        /// <returns>是否拦截消息的值，0为忽略消息，1为拦截消息。</returns>
        [DllExport("_eventDiscussMsg", CallingConvention.StdCall)]
        public static int ProcessDiscussGroupMessage(
            int subType,
            int msgId,
            long fromDiscuss,
            long fromQQ,
            string msg,
            int font)
        {
            PluginInstanceManager.GetInstance().HandleMahuaOutput(new ProcessDiscussGroupMessage
            {
                SubType = subType,
                Msg = msg,
                FromDiscuss = fromDiscuss,
                FromQQ = fromQQ,
                MsgId = msgId,
                Font = font,
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
            PluginInstanceManager.GetInstance().HandleMahuaOutput(new ProcessGroupUpload
            {
                SubType = subType,
                SendTime = sendTime,
                FromGroup = fromGroup,
                FromQQ = fromQQ,
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
            PluginInstanceManager.GetInstance().HandleMahuaOutput(new ProcessGroupAdminChange
            {
                SubType = subType,
                SendTime = sendTime,
                Target = target,
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
        public static int ProcessGroupMemberDecrease(
            int subType,
            int sendTime,
            long fromGroup,
            long fromQQ,
            long target)
        {
            PluginInstanceManager.GetInstance().HandleMahuaOutput(new ProcessGroupMemberDecrease
            {
                SubType = subType,
                SendTime = sendTime,
                Target = target,
                FromGroup = fromGroup,
                FromQQ = fromQQ,
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
        public static int ProcessGroupMemberIncrease(
            int subType,
            int sendTime,
            long fromGroup,
            long fromQQ,
            long target)
        {
            PluginInstanceManager.GetInstance().HandleMahuaOutput(new ProcessGroupMemberIncrease
            {
                SubType = subType,
                SendTime = sendTime,
                Target = target,
                FromGroup = fromGroup,
                FromQQ = fromQQ,
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
            PluginInstanceManager.GetInstance().HandleMahuaOutput(new ProcessFriendsAdded
            {
                SubType = subType,
                SendTime = sendTime,
                FromQQ = fromQQ
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
            PluginInstanceManager.GetInstance().HandleMahuaOutput(new ProcessAddFriendEventOutput
            {
                SubType = subType,
                SendTime = sendTime,
                FromQQ = fromQQ,
                Msg = msg,
                Font = font,
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
        public static int ProcessJoinGroupRequest(
            int subType,
            int sendTime,
            long fromGroup,
            long fromQQ,
            string msg,
            string responseMark)
        {
            PluginInstanceManager.GetInstance().HandleMahuaOutput(new ProcessJoinGroupEventOutput
            {
                SubType = subType,
                SendTime = sendTime,
                FromQQ = fromQQ,
                FromGroup = fromGroup,
                Msg = msg,
                ResponseMark = responseMark,
            });
            return 0;
        }

        /// <summary>
        /// 设置中心菜单
        /// </summary>
        /// <returns></returns>
        [DllExport("_menuA", CallingConvention.StdCall)]
        public static int ProcessMenuClickA()
        {
            // TODO 点击设置中心，暂时没有任何作用
            Console.WriteLine("nothing");
            return 0;
        }
    }
}