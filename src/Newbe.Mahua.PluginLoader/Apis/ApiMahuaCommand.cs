using Newbe.Mahua.Commands;
using System.Runtime.Serialization;

namespace Newbe.Mahua.Apis
{
    [DataContract]
    public class ApiMahuaCommand : MahuaCommand
    {
    }

    [DataContract]
    public class ApiMahuaCommand<TResult> : MahuaCommand<TResult>
        where TResult : MahuaCommandResult
    {
    }
}
