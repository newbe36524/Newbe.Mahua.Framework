using System;

namespace Newbe.Mahua.Commands.ExceptionHandles
{
    public class HandlerExceptionMahuaCommand : MahuaCommand<HandlerExceptionMahuaCommandResult>
    {
        public Exception Exception { get; set; }

        public object SourceCommand { get; set; }
    }
}
