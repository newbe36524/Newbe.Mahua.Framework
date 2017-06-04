using System;
using System.Runtime.InteropServices;
using RGiesecke.DllExport;

namespace Newbe.Mahua.MPQ
{
    /// <summary>
    /// 暴露非托管代码的api集合
    /// </summary>
    public sealed class PluginApiExporter : IPluginApiExporter
    {
        public MahuaPlatform MahuaPlatform { get; } = MahuaPlatform.Mpq;

        [DllExport("info")]
        public static string GetInfo() => throw new NotImplementedException();

        [DllExport("EventFun")]
        public static int EventFun(string receiverQq, int eventType, int eventAdditionType, string fromNum,
            string eventOperator,
            string triggee,
            string message, string rawMessage) => throw new NotImplementedException();

        [DllExport("set")]
        public static void Set() => throw new NotImplementedException();

        [DllExport("about")]
        public static void About() => throw new NotImplementedException();


        [DllExport("end")]
        public static int End() => throw new NotImplementedException();
    }
}