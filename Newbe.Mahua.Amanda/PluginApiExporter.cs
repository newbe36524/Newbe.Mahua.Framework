using System;
using System.Runtime.InteropServices;
using RGiesecke.DllExport;

namespace Newbe.Mahua.Amanda
{
    public class PluginApiExporter : IPluginApiExporter
    {
        public MahuaPlatform MahuaPlatform { get; } = MahuaPlatform.Amanda;

        [DllExport("Information", CallingConvention.StdCall)]
        public static string Information() => throw new NotImplementedException();

        /// <summary>
        /// 初始化插件，插件加载时会调用此事件
        /// </summary>
        /// <returns></returns>
        [DllExport("Event_Initialization", CallingConvention.StdCall)]
        public static int Event_Initialization() => throw new NotImplementedException();


        /// <summary>
        /// 插件被启用事件
        /// </summary>
        /// <returns></returns>
        [DllExport("Event_pluginStart", CallingConvention.StdCall)]
        public static int Event_pluginStart() => throw new NotImplementedException();


        /// <summary>
        /// 插件被关闭事件
        /// </summary>
        /// <returns></returns>
        [DllExport("Event_pluginStop", CallingConvention.StdCall)]
        public static int Event_pluginStop() => throw new NotImplementedException();

        /// <summary>
        /// 获取最新信息(好友/群/群临时/讨论组/讨论组临时消息)事件
        /// </summary>
        /// <param name="type"> 1.好友消息 2.群消息 3.群临时消息 4.讨论组消息 5.讨论组临时消息</param>
        /// <param name="fromgroup">类型=1的时候，此参数为空，其余情况下为 群号或讨论组号</param>
        /// <param name="fromqq"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        [DllExport("Event_GetNewMsg", CallingConvention.StdCall)]
        public static string Event_GetNewMsg(string type, string fromgroup, string fromqq, string message) =>
            throw new NotImplementedException();

        /// <summary>
        /// QQ财付通转账事件
        /// </summary>
        /// <param name="type">1.好友转账 2.群临时转账 3.讨论组临时转账</param>
        /// <param name="fromgroup">类型1.此参数为空 2.群号 3.讨论组号</param>
        /// <param name="fromqq">转账的QQ</param>
        /// <param name="money">转账金额</param>
        /// <param name="friendRemark">QQ转账对方备注</param>
        /// <param name="orderNo">QQ转账获取的订单号</param>
        /// <returns></returns>
        [DllExport("Event_GetQQWalletData", CallingConvention.StdCall)]
        public static string Event_GetQQWalletData(string type, string fromgroup, string fromqq, string money,
            string friendRemark, string orderNo) =>
            throw new NotImplementedException();

        /// <summary>
        /// 管理员变动事件
        /// </summary>
        /// <param name="type">1.xx被添加管理 2.xx被解除管理</param>
        /// <param name="fromgroup"></param>
        /// <param name="fromqq"></param>
        /// <returns></returns>
        [DllExport("Event_AdminChange", CallingConvention.StdCall)]
        public static string Event_AdminChange(string type, string fromgroup, string fromqq) =>
            throw new NotImplementedException();


        /// <summary>
        /// 群成员增加事件
        /// </summary>
        /// <param name="type">1.主动入群  2.被xxx邀请入群</param>
        /// <param name="fromgroup">群号</param>
        /// <param name="fromqq">进群QQ</param>
        /// <param name="operatorQq"> 类型为1.管理员 2.邀请人</param>
        /// <returns></returns>
        [DllExport("Event_GroupMemberIncrease", CallingConvention.StdCall)]
        public static string Event_GroupMemberIncrease(string type, string fromgroup, string fromqq,
            string operatorQq) =>
            throw new NotImplementedException();


        /// <summary>
        /// 群成员减少事件
        /// </summary>
        /// <param name="type">1.主动退群  2.被xxx踢出群</param>
        /// <param name="fromgroup">群号</param>
        /// <param name="fromqq">退群QQ</param>
        /// <param name="operatorQq">类型为1时参数为空</param>
        /// <returns></returns>
        [DllExport("Event_GroupMemberDecrease", CallingConvention.StdCall)]
        public static string Event_GroupMemberDecrease(string type, string fromgroup, string fromqq,
            string operatorQq) =>
            throw new NotImplementedException();

        /// <summary>
        /// 群添加事件
        /// </summary>
        /// <param name="type">1.主动加群  2.被邀请进群 3.机器人被邀请入群</param>
        /// <param name="fromgroup"></param>
        /// <param name="fromqq"></param>
        /// <param name="invatorQq">邀请者QQ</param>
        /// <param name="moreMsg">加群者的附加信息，类型为2，3时参数为空</param>
        /// <param name="seq">群添加事件产生的Seq标识</param>
        /// <returns></returns>
        [DllExport("Event_AddGroup", CallingConvention.StdCall)]
        public static string Event_GrouEvent_AddGrouppMemberDecrease(string type, string fromgroup, string fromqq,
            string invatorQq, string moreMsg, string seq) =>
            throw new NotImplementedException();

        /// <summary>
        /// 好友添加事件
        /// </summary>
        /// <param name="fromqq"></param>
        /// <param name="reason">好友添加理由</param>
        /// <returns></returns>
        [DllExport("Event_AddFrinend", CallingConvention.StdCall)]
        public static string Event_AddFrinend(string fromqq, string reason) =>
            throw new NotImplementedException();

        /// <summary>
        /// 成为了好友事件
        /// </summary>
        /// <param name="fromqq"></param>
        /// <returns></returns>
        [DllExport("Event_BecomeFriends", CallingConvention.StdCall)]
        public static string Event_BecomeFriends(string fromqq) =>
            throw new NotImplementedException();

        /// <summary>
        /// Cookies更新时会触发此事件
        /// </summary>
        /// <returns></returns>
        [DllExport("Event_UpdataCookies", CallingConvention.StdCall)]
        public static string Event_UpdataCookies() =>
            throw new NotImplementedException();

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        [DllExport("_TestMenu1", CallingConvention.StdCall)]
        public static int _TestMenu1() => throw new NotImplementedException();

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        [DllExport("_TestMenu2", CallingConvention.StdCall)]
        public static int _TestMenu2() => throw new NotImplementedException();
    }
}