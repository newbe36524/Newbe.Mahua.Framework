using Newbe.Mahua.Commands;

namespace Newbe.Mahua.MPQ
{
    internal class MpqCommand : MahuaCommand
    {
    }

    internal class MpqCommand<TResult> : MahuaCommand<TResult> where TResult : MpqCommandResult
    {
    }

    internal class MpqCommandResult : MahuaCommandResult
    {
    }
}
