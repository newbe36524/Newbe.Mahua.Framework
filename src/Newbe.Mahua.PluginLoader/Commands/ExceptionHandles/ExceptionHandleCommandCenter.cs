using System;

namespace Newbe.Mahua.Commands.ExceptionHandles
{
    /// <summary>
    /// 带有异常处理功能的<see cref="ICommandCenter"/>
    /// </summary>
    internal class ExceptionHandleCommandCenter : ICommandCenter
    {
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
            catch (Exception e)
            {
                HandlerExceptionByMahuaCommad(e, command);
            }
        }

        TResult ICommandCenter.HandleWithResult<TCommand, TResult>(TCommand command)
        {
            try
            {
                return _commandCenter.HandleWithResult<TCommand, TResult>(command);
            }
            catch (Exception e)
            {
                // 本身就是运行出现异常事件 则不再进一步处理，直接抛出，避免出现死循环。
                if (command is HandlerExceptionMahuaCommand)
                {
                    throw;
                }
                HandlerExceptionByMahuaCommad(e, command);
            }

            return default(TResult);
        }

        private void HandlerExceptionByMahuaCommad(Exception e, object sourceCommand)
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
