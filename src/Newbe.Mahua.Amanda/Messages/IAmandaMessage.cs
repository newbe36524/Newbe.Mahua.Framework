using Newbe.Mahua.Messages;

namespace Newbe.Mahua.Amanda.Messages
{
    public interface IAmandaMessage : IMessage
    {
        bool Shake { get; set; }
    }
}
