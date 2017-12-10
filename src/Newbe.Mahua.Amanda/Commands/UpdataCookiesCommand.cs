using Newbe.Mahua.Commands;
using System.Runtime.Serialization;

namespace Newbe.Mahua.Amanda.Commands
{
    [DataContract]
    public class UpdataCookiesCommand : AmandaCommand
    {
    }

    internal class UpdataCookiesCommandHandler : ICommandHandler<UpdataCookiesCommand>
    {
        public void Handle(UpdataCookiesCommand message)
        {
            // todo 需要做的什么
        }
    }
}
