using Newbe.Mahua.Commands;
using System.Runtime.Serialization;

namespace Newbe.Mahua.CQP
{
    [DataContract]
    public abstract class CqpCommand : MahuaCommand
    {
    }

    [DataContract]
    public abstract class CqpCommand<TResult> : MahuaCommand<TResult> where TResult : CqpCommandResult
    {
    }

    [DataContract]
    public abstract class CqpCommandResult : MahuaCommandResult
    {
    }
}
