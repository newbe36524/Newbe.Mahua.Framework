using Newbe.Mahua.Commands;

namespace Newbe.Mahua.MPQ
{
    public class MpqCommand : MahuaCommand
    {
    }

    public class MpqCommand<TReslut> : MahuaCommand<TReslut> where TReslut : MpqCommandResult
    {
    }

    public class MpqCommandResult : MahuaCommandResult
    {
    }
}
