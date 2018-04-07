namespace Newbe.Mahua.Messages
{
    public interface IMessageBuilder
    {
        string Target { get; set; }
        void Append(string msg);
        string GetMessage();
    }
}
