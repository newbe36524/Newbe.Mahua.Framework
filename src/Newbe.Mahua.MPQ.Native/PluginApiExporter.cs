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

        [DllExport("EventFun")]
        public static int EventFun(string receiverQq, int eventType, int eventAdditionType, string fromNum,
            string eventOperator,
            string triggee,
            string message, string rawMessage)
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

        [DllExport("set")]
        public static void Set()
        {
            PluginInstanceManager.GetInstance().SendCommand(new SetCommand());
        }


        [DllExport("about")]
        public static void About()
        {
            PluginInstanceManager.GetInstance().SendCommand(new AboutCommand());
        }


        [DllExport("end")]
        public static int End()
        {
            var endCommandResult = PluginInstanceManager.GetInstance()
                .SendCommand<EndCommand, EndCommandResult>(new EndCommand());
            return endCommandResult.Result;
        }
    }
}
