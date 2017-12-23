using Newbe.Mahua.MPQ.Commands;
using System.Runtime.InteropServices;

namespace Newbe.Mahua.MPQ.Native
{
    public class PluginApiExporter : IPluginApiExporter
    {
        public MahuaPlatform MahuaPlatform { get; } = MahuaPlatform.Mpq;

        [DllExport("info")]
        public static string GetInfo()
        {
            var getInfoCommandResult = PluginInstanceManager.GetInstance()
                .SendCommand<GetInfoCommand, GetInfoCommandResult>(new GetInfoCommand());
            return getInfoCommandResult.Info;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="receiverQq">多QQ登录情况下用于识别是哪个Q</param>
        /// <param name="eventType">信息唯一标识</param>
        /// <param name="eventAdditionType">对象申请、被邀请入群事件下该值为1时即对象为不良成员</param>
        /// <param name="fromNum">信息的源头  群号,好友QQ,讨论组ID,临时会话对象QQ等</param>
        /// <param name="eventOperator">主动触发这条信息的对象 T人时为T人的管理员QQ  </param>
        /// <param name="triggee">被动接受这条信息的对象 T人时为被T对象的QQ </param>
        /// <param name="message">视情况而定的信息内容  申请入群时为入群理由,添加好友为附加信息,T人之类的为空</param>
        /// <param name="rawMessage">经过解密后的封包字节数据或json结构信息</param>
        /// <returns></returns>
        [DllExport("EventFun")]
        public static int EventFun(
            string receiverQq,
            int eventType,
            int eventAdditionType,
            string fromNum,
            string eventOperator,
            string triggee,
            string message,
            string rawMessage)
        {
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
                });
            return endCommandResult.Result;
        }

        /// <summary>
        /// 点击设置按钮
        /// </summary>
        [DllExport("set")]
        public static void Set()
        {
            PluginInstanceManager.GetInstance().SendCommand(new ConfigurationManagerCommand());
        }

        /// <summary>
        /// 放版权和声明\教程
        /// </summary>
        [DllExport("about")]
        public static void About()
        {
            PluginInstanceManager.GetInstance().SendCommand(new AboutCommand());
        }

        /// <summary>
        /// 当插件被停用、卸载时将会调用
        /// </summary>
        /// <returns></returns>
        [DllExport("end")]
        public static int End()
        {
            var endCommandResult = PluginInstanceManager.GetInstance()
                .SendCommand<EndCommand, EndCommandResult>(new EndCommand());
            return endCommandResult.Result;
        }
    }
}
