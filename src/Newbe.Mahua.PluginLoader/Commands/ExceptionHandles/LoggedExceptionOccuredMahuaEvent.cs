using MessagePack;
using Newbe.Mahua.Internals;
using Newbe.Mahua.Logging;
using Newbe.Mahua.MahuaEvents;

namespace Newbe.Mahua.Commands.ExceptionHandles
{
    /// <summary>
    /// 异常事件发生时，将异常信息写入到日志文件中
    /// </summary>
    public class LoggedExceptionOccuredMahuaEvent : IExceptionOccuredMahuaEvent
    {
        private static readonly ILog Logger = LogProvider.For<LoggedExceptionOccuredMahuaEvent>();

        public void HandleException(ExceptionOccuredContext context)
        {
            var cmd = context.SourceCommand;
            var cmdType = cmd.GetType();
            Logger.ErrorException($"由{cmdType.Name}命令引发了异常", context.Exception);
            var cmdBytes = GlobalCache.CrossDoaminSerializer.Serialize(cmd, cmdType);
            var json = MessagePackSerializer.ToJson(cmdBytes);
            Logger.Debug($"命令的内容为:{json}");
        }
    }
}
