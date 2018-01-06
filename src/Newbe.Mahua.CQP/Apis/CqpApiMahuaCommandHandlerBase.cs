using Newbe.Mahua.Apis;
using Newbe.Mahua.CQP.NativeApi;

namespace Newbe.Mahua.CQP.Apis
{
    public abstract class CqpApiMahuaCommandHandlerBase<T> : IApiCommandHandler<T>
        where T : ApiMahuaCommand
    {
        public ICoolQApi CoolQApi { get; }

        public int AuthCode => _cqpAuthCodeContainer.AuthCode;

        private readonly ICqpAuthCodeContainer _cqpAuthCodeContainer;

        protected CqpApiMahuaCommandHandlerBase(
            ICoolQApi coolQApi,
            ICqpAuthCodeContainer cqpAuthCodeContainer)
        {
            CoolQApi = coolQApi;
            _cqpAuthCodeContainer = cqpAuthCodeContainer;
        }

        public abstract void Handle(T message);
    }

    public abstract class CqpApiMahuaCommandHandlerBase<TCmd, TResult> : IApiCommandHandler<TCmd, TResult>
        where TCmd : ApiMahuaCommand<TResult>
        where TResult : ApiMahuaCommandResult
    {
        public ICoolQApi CoolQApi { get; }

        public int AuthCode => _cqpAuthCodeContainer.AuthCode;

        private readonly ICqpAuthCodeContainer _cqpAuthCodeContainer;

        protected CqpApiMahuaCommandHandlerBase(
            ICoolQApi coolQApi,
            ICqpAuthCodeContainer cqpAuthCodeContainer)
        {
            CoolQApi = coolQApi;
            _cqpAuthCodeContainer = cqpAuthCodeContainer;
        }

        public abstract TResult Handle(TCmd message);
    }
}
