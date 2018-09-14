using Newbe.Mahua.Commands;

namespace Newbe.Mahua.QQLight
{
    public class QqLightCommand : MahuaCommand
    {
    }

    public class QqLightCommand<TReslut> : MahuaCommand<TReslut> where TReslut : QqLightCommandResult
    {
    }

    public class QqLightCommandResult : MahuaCommandResult
    {
    }
}
