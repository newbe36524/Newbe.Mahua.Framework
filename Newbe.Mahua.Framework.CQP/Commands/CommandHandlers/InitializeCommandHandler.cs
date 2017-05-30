using Newbe.Mahua.Framework.Commands;

namespace Newbe.Mahua.Framework.CQP.Commands.CommandHandlers
{
    internal class InitializeCommandHandler : CommandHandlerBase<InitializeCommand>
    {
        private readonly ICoolQApi _coolQApi;

        public InitializeCommandHandler(ICoolQApi coolQApi)
        {
            _coolQApi = coolQApi;
        }

        protected override void HandleCore(InitializeCommand command)
        {
            _coolQApi.SetAuthCode(command.AuthCode);
        }
    }
}