using Newbe.Mahua.Commands;
using System.Runtime.Serialization;

namespace Newbe.Mahua.Amanda.Commands
{
    internal class UpdataCookiesCommandHandler : ICommandHandler<UpdataCookiesCommand>
    {
        public void Handle(UpdataCookiesCommand command)
        {
            //todo 需要做的什么
        }
    }

    [DataContract]
    public class UpdataCookiesCommand : AmandaCommand
    {
    }
}
