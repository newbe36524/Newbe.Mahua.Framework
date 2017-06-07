using System;
using Newbe.Mahua.Commands;

namespace Newbe.Mahua.Amanda.Commands
{
    internal class AdminChangeCommandHandler : CommandHandlerBase<AdminChangeCommand>
    {
        protected override void HandleCore(AdminChangeCommand command)
        {
            throw new NotImplementedException();
        }
    }

    [Serializable]
    internal class AdminChangeCommand : AmandaCommand
    {
        public string Type { get; set; }
        public string Fromgroup { get; set; }
        public string Fromqq { get; set; }
    }
}