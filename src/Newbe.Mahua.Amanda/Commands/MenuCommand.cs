using Newbe.Mahua.Commands;

namespace Newbe.Mahua.Amanda.Commands
{
    internal class MenuCommandHandler : ICommandHandler<MenuCommand>
    {
        public void Handle(MenuCommand command)
        {
            //todo
        }
    }

    internal class MenuCommand : AmandaCommand
    {
        public string MenuId { get; set; }
    }
}
