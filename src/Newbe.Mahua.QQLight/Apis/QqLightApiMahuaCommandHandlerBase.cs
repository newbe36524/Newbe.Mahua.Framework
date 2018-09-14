using Newbe.Mahua.Apis;
using Newbe.Mahua.QQLight.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public abstract class QqLightApiMahuaCommandHandlerBase<T> : IApiCommandHandler<T>
        where T : ApiMahuaCommand
    {
        public IQqLightApi QqLightApi { get; }

        protected QqLightApiMahuaCommandHandlerBase(
            IQqLightApi qqLightApi)
        {
            QqLightApi = qqLightApi;
        }

        public abstract void Handle(T message);
    }

    public abstract class QqLightApiMahuaCommandHandlerBase<TCmd, TResult> : IApiCommandHandler<TCmd, TResult>
        where TCmd : ApiMahuaCommand<TResult>
        where TResult : ApiMahuaCommandResult
    {
        public IQqLightApi QqLightApi { get; }

        protected QqLightApiMahuaCommandHandlerBase(
            IQqLightApi qqLightApi)
        {
            QqLightApi = qqLightApi;
        }

        public abstract TResult Handle(TCmd message);
    }
}
