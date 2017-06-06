using System;
using Newbe.Mahua.MPQ.Commands;
using RGiesecke.DllExport;

namespace Newbe.Mahua.MPQ
{
    internal static class PluginInstanceManager
    {
        public static IPluginLoader GetInstance()
        {
            var pluginInfo = PluginInfoProvider.GetPluginInfo();
            return Mahua.PluginInstanceManager.GetInstance(pluginInfo);
        }
    }

    /// <summary>
    /// 暴露非托管代码的api集合
    /// </summary>
    public sealed class PluginApiExporter : IPluginApiExporter
    {
        public MahuaPlatform MahuaPlatform { get; } = MahuaPlatform.Mpq;

        [DllExport("info")]
        public static string GetInfo()
        {
            var infoCommandResult = PluginInstanceManager.GetInstance()
                .SendCommand<InfoCommandResult>(new InfoCommand());
            return infoCommandResult.Info;
        }

        [DllExport("EventFun")]
        public static int EventFun(string receiverQq, int eventType, int eventAdditionType, string fromNum,
            string eventOperator,
            string triggee,
            string message, string rawMessage)
        {
            var eventFunCommandResult = PluginInstanceManager.GetInstance().SendCommand<EventFunCommandResult>(
                new EventFunCommand
                {
                    ReceiverQq = long.Parse(receiverQq),
                    Message = message,
                    EventAdditionType = eventAdditionType,
                    EventOperator = eventOperator,
                    EventType = eventType,
                    FromNum = long.Parse(fromNum),
                    RawMessage = rawMessage,
                    Triggee = triggee,
                });
            return eventFunCommandResult.ResultCode;
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
            PluginInstanceManager.GetInstance().SendCommand(new EndCommand());
            return 0;
        }
    }
}