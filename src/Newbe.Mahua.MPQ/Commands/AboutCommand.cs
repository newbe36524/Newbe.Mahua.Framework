using Newbe.Mahua.Commands;
using System.Runtime.Serialization;

namespace Newbe.Mahua.MPQ.Commands
{
    public class AboutCommandHandler : ICommandHandler<AboutCommand>
    {
        public void Handle(AboutCommand message)
        {
            throw new System.NotImplementedException();
        }
    }

    [DataContract]
    public class AboutCommand : MpqCommand
    {
    }
}
