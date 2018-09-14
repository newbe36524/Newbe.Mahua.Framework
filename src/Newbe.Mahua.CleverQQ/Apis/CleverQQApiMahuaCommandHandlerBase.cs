using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public abstract class CleverQQApiMahuaCommandHandlerBase<T> : IApiCommandHandler<T>
        where T : ApiMahuaCommand
    {
        private readonly IRobotSessionContext _robotSessionContext;
        private readonly IIrEventOutput _eventFunOutput;

        public ICleverQqApi CleverQQApi { get; }

        public int ResultCode
        {
            get => _eventFunOutput.Result;
            set => _eventFunOutput.Result = value;
        }

        public string CurrentQq => _robotSessionContext.CurrentQq;

        protected CleverQQApiMahuaCommandHandlerBase(
            ICleverQqApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIrEventOutput eventFunOutput)
        {
            _robotSessionContext = robotSessionContext;
            _eventFunOutput = eventFunOutput;
            CleverQQApi = cleverqqApi;
        }

        public abstract void Handle(T message);
    }

    public abstract class CleverQQApiMahuaCommandHandlerBase<TCmd, TResult> : IApiCommandHandler<TCmd, TResult>
        where TCmd : ApiMahuaCommand<TResult>
        where TResult : ApiMahuaCommandResult
    {
        private readonly IRobotSessionContext _robotSessionContext;
        private readonly IIrEventOutput _eventFunOutput;

        public ICleverQqApi CleverQQApi { get; }

        public int ResultCode
        {
            get => _eventFunOutput.Result;
            set => _eventFunOutput.Result = value;
        }

        public string CurrentQq => _robotSessionContext.CurrentQq;

        protected CleverQQApiMahuaCommandHandlerBase(
            ICleverQqApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIrEventOutput eventFunOutput)
        {
            _robotSessionContext = robotSessionContext;
            _eventFunOutput = eventFunOutput;
            CleverQQApi = cleverqqApi;
        }

        public abstract TResult Handle(TCmd message);
    }
}
