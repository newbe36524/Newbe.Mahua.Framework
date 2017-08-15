using MediatR;
using System;

namespace Newbe.Mahua.Commands
{
    [Serializable]
    public abstract class MahuaCommand<TResult> : IRequest<TResult> where TResult : MahuaCommandResult
    {
    }

    [Serializable]
    public abstract class MahuaCommand : IRequest
    {
    }
}
