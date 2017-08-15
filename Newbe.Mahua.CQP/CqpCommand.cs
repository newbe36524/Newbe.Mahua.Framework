using Newbe.Mahua.Commands;

namespace Newbe.Mahua.CQP
{
    internal abstract class CqpCommand : MahuaCommand
    {
    }

    internal abstract class CqpCommand<TResult> : MahuaCommand<TResult> where TResult : CqpCommandResult
    {
    }

    internal abstract class CqpCommandResult : MahuaCommandResult
    {
    }
}
