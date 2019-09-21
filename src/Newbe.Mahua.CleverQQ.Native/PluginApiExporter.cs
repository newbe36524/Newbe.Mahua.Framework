using Newbe.Mahua.CleverQQ.Commands;
using System.Runtime.InteropServices;
using Newbe.Mahua.Logging;

namespace Newbe.Mahua.CleverQQ.Native
{
    public class PluginApiExporter : IPluginApiExporter
    {
        private static readonly ILog Logger = LogProvider.For<PluginApiExporter>();

        public MahuaPlatform MahuaPlatform { get; } = MahuaPlatform.CleverQQ;

        /// <summary>
        /// 程序入口
        /// </summary>
        /// <returns></returns>
        [DllExport(ExportName = nameof(IR_Create), CallingConvention = CallingConvention.StdCall)]
        public static string IR_Create()
        {
            TraceInvoke(nameof(IR_Create));
            var getInfoCommandResult = PluginInstanceManager.GetInstance()
                .SendCommand<IrCreateCommand, IrCreateCommandResult>(new IrCreateCommand());
            return getInfoCommandResult.Info;
        }

        /// <summary>
        /// 接收所有原始封包内容
        /// </summary>
        /// <param name="RobotQQ">响应的QQ</param>
        /// <param name="MsgType">UDP收到的原始信息</param>
        /// <param name="Msg">经过Tea加密的原文</param>
        /// <param name="Cookies">用于登录网页所需cookies</param>
        /// <param name="SessionKey">通信包所用的加密秘钥</param>
        /// <param name="ClientKey">登录网页服务用的秘钥</param>
        /// <returns>返回-1 已收到并拒绝处理，返回0 未收到并不处理，返回1 处理完且继续执行，返回2 处理完毕并不再让其他插件处理 （Pro版可用)</returns>
        [DllExport(ExportName = nameof(IR_Message), CallingConvention = CallingConvention.StdCall)]
        public static int IR_Message(string RobotQQ,
            int MsgType,
            string Msg,
            string Cookies,
            string SessionKey,
            string ClientKey)
        {
            TraceInvoke(nameof(IR_Message),
                $"{nameof(RobotQQ)}:", RobotQQ,
                $"{nameof(MsgType)}:", MsgType,
                $"{nameof(Msg)}:", Msg,
                $"{nameof(Cookies)}:", Cookies,
                $"{nameof(SessionKey)}:", SessionKey,
                $"{nameof(ClientKey)}:", ClientKey);
            return 1;
        }


        /// <summary>
        ///
        /// </summary>
        /// <param name="receiverQq">多QQ登录情况下用于识别是哪个Q</param>
        /// <param name="eventType">接收到消息类型，该类型可在常量表中查询具体定义，此处仅列举： -1 未定义事件 0,在线状态临时会话 1,好友信息 2,群信息 3,讨论组信息 4,群临时会话 5,讨论组临时会话 6,财付通转账 7,好友验证回复会话</param>
        /// <param name="eventAdditionType">此参数在不同消息类型下，有不同的定义，暂定：接收财付通转账时 1为好友 4为群临时会话 5为讨论组临时会话    有人请求入群时，不良成员这里为1</param>
        /// <param name="fromNum">此消息的来源，如：群号、讨论组ID、临时会话QQ、好友QQ等</param>
        /// <param name="eventOperator">主动发送这条消息的QQ，踢人时为踢人管理员QQ</param>
        /// <param name="triggee">被动触发的QQ，如某人被踢出群，则此参数为被踢出人QQ</param>
        /// <param name="message">此参数有多重含义，常见为：对方发送的消息内容，但当IRC_消息类型为 某人申请入群，则为入群申请理由</param>
        /// <param name="messageNum">此参数暂定用于消息回复，消息撤回</param>
        /// <param name="messageID">此参数暂定用于消息回复，消息撤回</param>
        /// <param name="rawMessage">经过解密后的封包字节数据或json结构信息，JSON格式转账解析</param>
        /// <param name="json">经过解密后的封包字节数据或json结构信息，JSON格式转账解析</param>
        /// <param name="pText">此参数用于插件加载拒绝理由  用法：写到内存（“拒绝理由”，IRC_信息回传文本指针_Out）</param>
        /// <returns></returns>
        [DllExport(ExportName = nameof(IR_Event), CallingConvention = CallingConvention.StdCall)]
        public static int IR_Event(
            string receiverQq,
            int eventType,
            int eventAdditionType,
            string fromNum,
            string eventOperator,
            string triggee,
            string message,
            string messageNum,
            string messageID,
            string rawMessage,
            string json,
            string pText)
        {
            TraceInvoke(nameof(IR_Event),
                $"{nameof(receiverQq)}:", receiverQq,
                $"{nameof(eventType)}:", eventType,
                $"{nameof(eventAdditionType)}:", eventAdditionType,
                $"{nameof(fromNum)}:", fromNum,
                $"{nameof(eventOperator)}:", eventOperator,
                $"{nameof(triggee)}:", triggee,
                $"{nameof(message)}:", message,
                $"{nameof(messageNum)}:", messageNum,
                $"{nameof(messageID)}:", messageID,
                $"{nameof(rawMessage)}:", rawMessage,
                $"{nameof(json)}:", json,
                $"{nameof(pText)}:", pText);
            var endCommandResult = PluginInstanceManager.GetInstance()
                .SendCommand<EventFunCommand, EventFunCommandResult>(new EventFunCommand
                {
                    ReceiverQq = receiverQq,
                    EventAdditionType = eventAdditionType,
                    EventOperator = eventOperator,
                    EventType = eventType,
                    FromNum = fromNum,
                    Message = message,
                    RawMessage = rawMessage,
                    Triggee = triggee,
                    MessageId = long.TryParse(messageID, out var id) ? id : 0,
                    MessageNum = long.TryParse(messageNum, out var num) ? num : 0,
                });
            return endCommandResult.Result;
        }

        /// <summary> 
        /// 点击设置按钮
        /// </summary>
        [DllExport(ExportName = nameof(IR_SetUp), CallingConvention = CallingConvention.StdCall)]
        public static void IR_SetUp()
        {
            TraceInvoke(nameof(IR_Create));
            PluginInstanceManager.GetInstance().SendCommand(new ConfigurationManagerCommand());
        }

        /// <summary>
        /// 当插件被停用、卸载时将会调用
        /// </summary>
        /// <returns></returns>
        [DllExport(ExportName = nameof(IR_DestroyPlugin), CallingConvention = CallingConvention.StdCall)]
        public static int IR_DestroyPlugin()
        {
            TraceInvoke(nameof(IR_DestroyPlugin));
            var endCommandResult = PluginInstanceManager.GetInstance()
                .SendCommand<IrDestroyPluginCommand, IrDestroyPluginCommandResult>(new IrDestroyPluginCommand());
            return endCommandResult.Result;
        }

        private static void TraceInvoke(string method, params object[] arguments)
        {
            Logger.Trace("called {method} {arguments}", method, arguments);
        }
    }
}