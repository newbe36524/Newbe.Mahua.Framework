using System;
using Newbe.Mahua.Commands;

namespace Newbe.Mahua.Amanda.Commands
{
    internal class GetNewMsgCommandHandler : CommandHandlerBase<GetNewMsgCommand>
    {
        protected override void HandleCore(GetNewMsgCommand command)
        {
            throw new NotImplementedException();
        }
    }

    [Serializable]
    internal class GetNewMsgCommand : AmandaCommand
    {
        public string Type { get; set; }
        public string Fromgroup { get; set; }
        public string Fromqq { get; set; }
        public string Message { get; set; }
    }
}