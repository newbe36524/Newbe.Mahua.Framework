using Newbe.Mahua.Amanda.Commands;
using System.Runtime.InteropServices;

namespace Newbe.Mahua.Amanda
{
    public class PluginApiExporter : IPluginApiExporter
    {
        public static string Continue { get; } = "0";

        public static string Stopped { get; } = "1";

        public MahuaPlatform MahuaPlatform { get; } = MahuaPlatform.Amanda;

        [DllExport("Information", CallingConvention.StdCall)]
        public static string Information(string authCode)
        {
            var informationCommandResult = Native.PluginInstanceManager.GetInstance()
                .SendCommand<InformationCommand, InformationCommandResult>(new InformationCommand
                {
                    AuthCode = authCode,
                });
            return informationCommandResult.Info;
        }

        /// <summary>
        /// 初始化插件，插件加载时会调用此事件
        /// </summary>
        /// <returns></returns>
        [DllExport("Event_Initialization", CallingConvention.StdCall)]
        public static int Event_Initialization()
        {
            Native.PluginInstanceManager.GetInstance().SendCommand(new InitializationCommand());
            return 0;
        }

        /// <summary>
        /// 插件被启用事件
        /// </summary>
        /// <returns></returns>
        [DllExport("Event_pluginStart", CallingConvention.StdCall)]
        public static int Event_pluginStart()
        {
            Native.PluginInstanceManager.GetInstance().SendCommand(new PluginStartCommand());
            return 0;
        }

        /// <summary>
        /// 插件被关闭事件
        /// </summary>
        /// <returns></returns>
        [DllExport("Event_pluginStop", CallingConvention.StdCall)]
        public static int Event_pluginStop()
        {
            Native.PluginInstanceManager.GetInstance().SendCommand(new PluginStopCommand());
            return 0;
        }

        /// <summary>
        /// 获取最新信息(好友/群/群临时/讨论组/讨论组临时消息)事件
        /// </summary>
        /// <param name="type"> 1.好友消息 2.群消息 3.群临时消息 4.讨论组消息 5.讨论组临时消息</param>
        /// <param name="fromgroup">类型=1的时候，此参数为空，其余情况下为 群号或讨论组号</param>
        /// <param name="fromqq"></param>
        /// <param name="message"></param>
        /// <param name="messageId"></param>
        /// <returns></returns>
        [DllExport("Event_GetNewMsg", CallingConvention.StdCall)]
        public static string Event_GetNewMsg(int type, string fromgroup, string fromqq, string message, string messageId)
        {
            FromMessageType t;
            switch (type)
            {
                case 1:
                    t = FromMessageType.好友消息;
                    break;
                case 2:
                    t = FromMessageType.群消息;
                    break;
                case 3:
                    t = FromMessageType.群临时消息;
                    break;
                case 4:
                    t = FromMessageType.讨论组消息;
                    break;
                case 5:
                    t = FromMessageType.讨论组临时消息;
                    break;
                default:
                    t = FromMessageType.Unknown;
                    break;
            }
            Native.PluginInstanceManager.GetInstance().SendCommand(new GetNewMsgCommand
            {
                Message = message,
                Type = t,
                Fromgroup = fromgroup,
                Fromqq = fromqq,
            });
            return Continue;
        }

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
        public static string Event_GetQQWalletData(
            int type,
            string fromgroup,
            string fromqq,
            string money,
            string friendRemark,
            string orderNo)
        {
            Native.PluginInstanceManager.GetInstance().SendCommand(new GetQqWalletDataCommand
            {
                Type = type,
                Fromqq = fromqq,
                Fromgroup = fromgroup,
                FriendRemark = friendRemark,
                Money = money,
                OrderNo = orderNo
            });
            return Continue;
        }

        /// <summary>
        /// 管理员变动事件
        /// </summary>
        /// <param name="type">1.xx被添加管理 2.xx被解除管理</param>
        /// <param name="fromgroup"></param>
        /// <param name="fromqq"></param>
        /// <returns></returns>
        [DllExport("Event_AdminChange", CallingConvention.StdCall)]
        public static string Event_AdminChange(int type, string fromgroup, string fromqq)
        {
            Native.PluginInstanceManager.GetInstance().SendCommand(new AdminChangeCommand
            {
                Type = type,
                Fromqq = fromqq,
                Fromgroup = fromgroup
            });
            return Continue;
        }

        /// <summary>
        /// 群成员增加事件
        /// </summary>
        /// <param name="type">1.主动入群  2.被xxx邀请入群</param>
        /// <param name="fromgroup">群号</param>
        /// <param name="fromqq">进群QQ</param>
        /// <param name="operatorQq"> 类型为1.管理员 2.邀请人</param>
        /// <returns></returns>
        [DllExport("Event_GroupMemberIncrease", CallingConvention.StdCall)]
        public static string Event_GroupMemberIncrease(
            int type,
            string fromgroup,
            string fromqq,
            string operatorQq)
        {
            Native.PluginInstanceManager.GetInstance().SendCommand(new GroupMemberIncreaseCommand
            {
                Type = type,
                Fromqq = fromqq,
                Fromgroup = fromgroup,
                OperatorQq = operatorQq,
            });
            return Continue;
        }

        /// <summary>
        /// 群成员减少事件
        /// </summary>
        /// <param name="type">1.主动退群  2.被xxx踢出群</param>
        /// <param name="fromgroup">群号</param>
        /// <param name="fromqq">退群QQ</param>
        /// <param name="operatorQq">类型为1时参数为空</param>
        /// <returns></returns>
        [DllExport("Event_GroupMemberDecrease", CallingConvention.StdCall)]
        public static string Event_GroupMemberDecrease(
            int type,
            string fromgroup,
            string fromqq,
            string operatorQq)
        {
            Native.PluginInstanceManager.GetInstance().SendCommand(new GroupMemberDecreaseCommand
            {
                Type = type,
                Fromqq = fromqq,
                Fromgroup = fromgroup,
                OperatorQq = operatorQq
            });
            return Continue;
        }

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
        public static string Event_AddGroup(
            int type,
            string fromgroup,
            string fromqq,
            string invatorQq,
            string moreMsg,
            string seq)
        {
            Native.PluginInstanceManager.GetInstance().SendCommand(new AddGroupCommand
            {
                Type = type,
                Fromqq = fromqq,
                Fromgroup = fromgroup,
                InvatorQq = invatorQq,
                MoreMsg = moreMsg,
                Seq = seq
            });
            return Continue;
        }

        /// <summary>
        /// 好友添加事件
        /// </summary>
        /// <param name="fromqq"></param>
        /// <param name="reason">好友添加理由</param>
        /// <returns></returns>
        /// 这个拼写就是这样，没毛病
        [DllExport("Event_AddFrinend", CallingConvention.StdCall)]
        public static string Event_AddFrinend(string fromqq, string reason)
        {
            Native.PluginInstanceManager.GetInstance().SendCommand(new AddFrinendCommand
            {
                Fromqq = fromqq,
                Reason = reason
            });
            return Continue;
        }

        /// <summary>
        /// 成为了好友事件
        /// </summary>
        /// <param name="fromqq"></param>
        /// <returns></returns>
        [DllExport("Event_BecomeFriends", CallingConvention.StdCall)]
        public static string Event_BecomeFriends(string fromqq)
        {
            Native.PluginInstanceManager.GetInstance().SendCommand(new BecomeFriendsCommand
            {
                Fromqq = fromqq
            });
            return Continue;
        }

        /// <summary>
        /// Cookies更新时会触发此事件
        /// </summary>
        /// <returns></returns>
        [DllExport("Event_UpdataCookies", CallingConvention.StdCall)]
        public static string Event_UpdataCookies()
        {
            Native.PluginInstanceManager.GetInstance().SendCommand(new UpdataCookiesCommand());
            return Continue;
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        [DllExport("_TestMenu1", CallingConvention.StdCall)]
        public static int _TestMenu1()
        {
            Native.PluginInstanceManager.GetInstance().SendCommand(new ConfigurationManagerCommand());
            return 0;
        }
    }
}
