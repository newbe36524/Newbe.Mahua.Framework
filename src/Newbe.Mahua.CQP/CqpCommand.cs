using Newbe.Mahua.Commands;

namespace Newbe.Mahua.CQP
{
    public abstract class CqpCommand : MahuaCommand
    {
    }

    public abstract class CqpCommand<TResult> : MahuaCommand<TResult> where TResult : CqpCommandResult
    {
    }

    public abstract class CqpCommandResult : MahuaCommandResult
    {
    }
}
