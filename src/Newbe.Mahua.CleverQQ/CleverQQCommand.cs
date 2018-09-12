using Newbe.Mahua.Commands;

namespace Newbe.Mahua.CleverQQ
{
    public class CleverQQCommand : MahuaCommand
    {
    }

    public class CleverQQCommand<TReslut> : MahuaCommand<TReslut> where TReslut : CleverQQCommandResult
    {
    }

    public class CleverQQCommandResult : MahuaCommandResult
    {
    }
}
