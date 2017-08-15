using Newbe.Mahua.Commands;

namespace Newbe.Mahua.Amanda
{
    public class AmandaCommand : MahuaCommand
    {
    }

    public class AmandaCommand<TReslut> : MahuaCommand<TReslut> where TReslut : AmandaCommandResult
    {
    }

    public class AmandaCommandResult : MahuaCommandResult
    {
    }
}
