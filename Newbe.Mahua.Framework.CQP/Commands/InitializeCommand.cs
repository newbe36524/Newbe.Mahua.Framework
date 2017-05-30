using System;
using Newbe.Mahua.Framework.Commands;
using Newbe.Mahua.Framework.CQP.NativeApi;

namespace Newbe.Mahua.Framework.CQP.Commands
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

    [Serializable]
    internal class InitializeCommand : CqpCommand
    {
        public int AuthCode { get; set; }
    }
}