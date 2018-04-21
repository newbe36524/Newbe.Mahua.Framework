namespace Newbe.Mahua.Messages
{
    public interface IMessage
    {
        string Target { get; set; }
        void Append(string msg);
        string GetMessage();
    }
}
