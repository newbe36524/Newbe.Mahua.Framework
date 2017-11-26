using MediatR;
using System.Runtime.Serialization;

namespace Newbe.Mahua.Commands
{
    [DataContract]
    public class MahuaCommand<TResult> : IRequest<TResult> where TResult : MahuaCommandResult
    {
    }

    [DataContract]
    public class MahuaCommand : IRequest
    {
    }
}
