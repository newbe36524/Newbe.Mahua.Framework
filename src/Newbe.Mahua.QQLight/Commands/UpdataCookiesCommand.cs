using Newbe.Mahua.Commands;
using System.Runtime.Serialization;

namespace Newbe.Mahua.QQLight.Commands
{
    [DataContract]
    public class UpdataCookiesCommand : QqLightCommand
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
