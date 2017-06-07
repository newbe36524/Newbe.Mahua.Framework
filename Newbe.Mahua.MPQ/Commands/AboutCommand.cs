using System;
using Newbe.Mahua.Commands;

namespace Newbe.Mahua.MPQ.Commands
{
    internal class AboutCommandHandler : CommandHandlerBase<AboutCommand>
    {
        protected override void HandleCore(AboutCommand command)
        {
            throw new System.NotImplementedException();
        }
    }

    [Serializable]
    internal class AboutCommand : MqpCommand
    {
    }
}