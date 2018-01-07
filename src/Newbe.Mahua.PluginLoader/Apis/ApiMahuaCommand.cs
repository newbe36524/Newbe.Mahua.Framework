using Newbe.Mahua.Commands;
using System.Runtime.Serialization;

namespace Newbe.Mahua.Apis
{
    [DataContract]
    public class ApiMahuaCommand : MahuaCommand, IApiMahuaCommand
    {
    }

    [DataContract]
    public class ApiMahuaCommand<TResult> : MahuaCommand<TResult>, IApiMahuaCommand
        where TResult : MahuaCommandResult
    {
    }
}
