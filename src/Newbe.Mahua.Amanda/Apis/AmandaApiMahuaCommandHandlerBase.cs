using Newbe.Mahua.Amanda.NativeApi;
using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Amanda.Apis
{
    public abstract class AmandaApiMahuaCommandHandlerBase<T> : IApiCommandHandler<T>
        where T : ApiMahuaCommand
    {
        public IAmandaApi AmandaApi { get; }

        protected AmandaApiMahuaCommandHandlerBase(
            IAmandaApi amandaApi)
        {
            AmandaApi = amandaApi;
        }

        public abstract void Handle(T message);
    }

    public abstract class AmandaApiMahuaCommandHandlerBase<TCmd, TResult> : IApiCommandHandler<TCmd, TResult>
        where TCmd : ApiMahuaCommand<TResult>
        where TResult : ApiMahuaCommandResult
    {
        public IAmandaApi AmandaApi { get; }

        protected AmandaApiMahuaCommandHandlerBase(
            IAmandaApi amandaApi)
        {
            AmandaApi = amandaApi;
        }

        public abstract TResult Handle(TCmd message);
    }
}
