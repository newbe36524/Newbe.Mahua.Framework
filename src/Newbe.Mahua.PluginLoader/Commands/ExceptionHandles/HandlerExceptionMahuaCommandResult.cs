using System;

namespace Newbe.Mahua.Commands.ExceptionHandles
{
    public class HandlerExceptionMahuaCommandResult : MahuaCommandResult
    {
        public bool ContinueThrows { get; set; } = true;

        public Exception Exception { get; set; }
    }
}
