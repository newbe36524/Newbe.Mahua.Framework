using System;
using System.Reflection;
using Newbe.Mahua.Logging;

namespace Newbe.Mahua.Commands.ExceptionHandles
{
    /// <summary>
    /// 带有异常处理功能的<see cref="ICommandCenter"/>
    /// </summary>
    internal class ExceptionHandleCommandCenter : ICommandCenter
    {
        private static readonly ILog Logger = LogProvider.GetLogger(typeof(ExceptionHandleCommandCenter));

        private readonly ICommandCenter _commandCenter;

        public ExceptionHandleCommandCenter(
            ICommandCenter commandCenter)
        {
            _commandCenter = commandCenter;
        }

        void ICommandCenter.Handle<TCommand>(TCommand command)
        {
            try
            {
                _commandCenter.Handle(command);
            }
            catch (TargetInvocationException ex)
            {
                Logger.ErrorException("出现异常，捕获并忽略该异常，参考信息：https://github.com/newbe36524/Newbe.Mahua.Framework/issues/52", ex);
            }
            catch (Exception e)
            {
                HandlerExceptionByMahuaCommand(e, command);
            }
        }

        TResult ICommandCenter.HandleWithResult<TCommand, TResult>(TCommand command)
        {
            try
            {
                return _commandCenter.HandleWithResult<TCommand, TResult>(command);
            }
            catch (TargetInvocationException ex)
            {
                Logger.ErrorException("出现异常，捕获并忽略该异常，参考信息：https://github.com/newbe36524/Newbe.Mahua.Framework/issues/52", ex);
            }
            catch (Exception e)
            {
                // 本身就是运行出现异常事件 则不再进一步处理，直接抛出，避免出现死循环。
                if (command is HandlerExceptionMahuaCommand)
                {
                    throw;
                }

                HandlerExceptionByMahuaCommand(e, command);
            }

            return new TResult();
        }

        private void HandlerExceptionByMahuaCommand(Exception e, object sourceCommand)
        {
            var r = _commandCenter.HandleWithResult<HandlerExceptionMahuaCommand, HandlerExceptionMahuaCommandResult>(
                new HandlerExceptionMahuaCommand
                {
                    Exception = e,
                    SourceCommand = sourceCommand
                });
            if (r.ContinueThrows)
            {
                throw r.Exception;
            }
        }
    }
}