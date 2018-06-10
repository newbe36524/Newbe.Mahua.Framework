using Newbe.Mahua.Apis;
using Newbe.Mahua.MPQ.NativeApi;

namespace Newbe.Mahua.MPQ.Apis
{
    public abstract class MpqApiMahuaCommandHandlerBase<T> : IApiCommandHandler<T>
        where T : ApiMahuaCommand
    {
        private readonly IRobotSessionContext _robotSessionContext;
        private readonly IEventFunOutput _eventFunOutput;

        public IMpqApi MpqApi { get; }

        public int ResultCode
        {
            get => _eventFunOutput.Result;
            set => _eventFunOutput.Result = value;
        }

        public string CurrentQq => _robotSessionContext.CurrentQq;

        protected MpqApiMahuaCommandHandlerBase(
            IMpqApi mpqApi,
            IRobotSessionContext robotSessionContext,
            IEventFunOutput eventFunOutput)
        {
            _robotSessionContext = robotSessionContext;
            _eventFunOutput = eventFunOutput;
            MpqApi = mpqApi;
        }

        public abstract void Handle(T message);
    }

    public abstract class MpqApiMahuaCommandHandlerBase<TCmd, TResult> : IApiCommandHandler<TCmd, TResult>
        where TCmd : ApiMahuaCommand<TResult>
        where TResult : ApiMahuaCommandResult
    {
        private readonly IRobotSessionContext _robotSessionContext;
        private readonly IEventFunOutput _eventFunOutput;

        public IMpqApi MpqApi { get; }

        public int ResultCode
        {
            get => _eventFunOutput.Result;
            set => _eventFunOutput.Result = value;
        }

        public string CurrentQq => _robotSessionContext.CurrentQq;

        protected MpqApiMahuaCommandHandlerBase(
            IMpqApi mpqApi,
            IRobotSessionContext robotSessionContext,
            IEventFunOutput eventFunOutput)
        {
            _robotSessionContext = robotSessionContext;
            _eventFunOutput = eventFunOutput;
            MpqApi = mpqApi;
        }

        public abstract TResult Handle(TCmd message);
    }
}
