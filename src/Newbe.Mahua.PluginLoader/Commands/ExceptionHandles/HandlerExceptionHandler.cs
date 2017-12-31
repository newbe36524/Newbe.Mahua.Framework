using Newbe.Mahua.MahuaEvents;
using System.Collections.Generic;

namespace Newbe.Mahua.Commands.ExceptionHandles
{
    public class HandlerExceptionHandler
        : ICommandHandler<HandlerExceptionMahuaCommand, HandlerExceptionMahuaCommandResult>
    {
        private readonly IEnumerable<IExceptionOccuredMahuaEvent> _exceptionOccuredMahuaEvents;

        public HandlerExceptionHandler(
            IEnumerable<IExceptionOccuredMahuaEvent> exceptionOccuredMahuaEvents)
        {
            _exceptionOccuredMahuaEvents = exceptionOccuredMahuaEvents;
        }

        public HandlerExceptionMahuaCommandResult Handle(HandlerExceptionMahuaCommand message)
        {
            var continueThrows = true;
            foreach (var exceptionOccuredMahuaEvent in _exceptionOccuredMahuaEvents)
            {
                var exceptionOccuredContext = new ExceptionOccuredContext
                {
                    Exception = message.Exception,
                    ContinueThrows = true,
                    SourceCommand = message.SourceCommand,
                };
                exceptionOccuredMahuaEvent.HandleException(exceptionOccuredContext);

                // 一旦有一个处理，认为不应该抛出异常，则中断异常的抛出。
                if (!exceptionOccuredContext.ContinueThrows)
                {
                    continueThrows = false;
                }
            }
            return new HandlerExceptionMahuaCommandResult
            {
                Exception = message.Exception,
                ContinueThrows = continueThrows
            };
        }
    }
}
