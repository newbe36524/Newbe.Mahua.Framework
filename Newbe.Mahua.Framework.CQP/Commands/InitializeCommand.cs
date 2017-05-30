using System;
using Newbe.Mahua.Framework.Commands;
using Newbe.Mahua.Framework.CQP.NativeApi;

namespace Newbe.Mahua.Framework.CQP.Commands
{
    internal class InitializeCommandHandler : CommandHandlerBase<InitializeCommand>
    {
        private readonly ICqpAuthCodeContainer _cqpAuthCodeContainer;

        public InitializeCommandHandler(ICqpAuthCodeContainer cqpAuthCodeContainer)
        {
            _cqpAuthCodeContainer = cqpAuthCodeContainer;
        }

        protected override void HandleCore(InitializeCommand command)
        {
            _cqpAuthCodeContainer.AuthCode = command.AuthCode;
        }
    }

    [Serializable]
    internal class InitializeCommand : CqpCommand
    {
        public int AuthCode { get; set; }
    }
}