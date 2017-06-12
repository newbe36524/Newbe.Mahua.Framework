using System;
using Newbe.Mahua.Commands;

namespace Newbe.Mahua.Amanda.Commands
{
    internal class MenuCommandHandler : CommandHandlerBase<MenuCommand>
    {
        protected override void HandleCore(MenuCommand command)
        {
            //todo
        }
    }

    [Serializable]
    internal class MenuCommand : AmandaCommand
    {
        public string MenuId { get; set; }
    }
}