using System;
using System.ComponentModel;

namespace Newbe.Mahua.MahuaEvents
{
    /// <inheritdoc />
    /// <summary>
    /// 运行出现异常事件
    /// </summary>
    [Description("运行出现异常事件")]
    public interface IExceptionOccuredMahuaEvent : IMahuaEvent
    {
        /// <summary>
        /// 处理事件
        /// </summary>
        /// <param name="context"></param>
        void HandleException(ExceptionOccuredContext context);
    }

    /// <summary>
    /// 事件上下文
    /// </summary>
    public class ExceptionOccuredContext
    {
        /// <summary>
        /// 是否忽略此异常，不抛出以避免进程终止。默认为：true
        /// </summary>
        public bool ContinueThrows { get; set; } = true;

        /// <summary>
        /// 异常的内容
        /// </summary>
        public Exception Exception { get; set; }

        /// <summary>
        /// 引发事件的命令对象
        /// </summary>
        public object SourceCommand { get; set; }
    }
}
