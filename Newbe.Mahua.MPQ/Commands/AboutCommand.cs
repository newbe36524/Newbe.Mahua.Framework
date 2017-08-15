using Newbe.Mahua.Commands;

namespace Newbe.Mahua.MPQ.Commands
{
    internal class AboutCommandHandler : ICommandHandler<AboutCommand>
    {
        public void Handle(AboutCommand command)
        {
            throw new System.NotImplementedException();
        }
    }

    internal class AboutCommand : MpqCommand
    {
    }
}
