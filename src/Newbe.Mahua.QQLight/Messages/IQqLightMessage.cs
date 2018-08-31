using Newbe.Mahua.Messages;

namespace Newbe.Mahua.QQLight.Messages
{
    public interface IQqLightMessage : IMessage
    {
        bool Shake { get; set; }
    }
}
