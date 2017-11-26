using Newbe.Mahua.Commands;
using System.Runtime.Serialization;

namespace Newbe.Mahua.Amanda.Commands
{
    internal class MenuCommandHandler : ICommandHandler<MenuCommand>
    {
        public void Handle(MenuCommand command)
        {
            //todo
        }
    }

    [DataContract]
    public class MenuCommand : AmandaCommand
    {
        [DataMember]
        public string MenuId { get; set; }
    }
}
