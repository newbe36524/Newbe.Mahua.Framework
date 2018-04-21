namespace Newbe.Mahua.Messages
{
    public interface IGroupMessageFlowFactory
    {
        IGroupMessageStep Begin(string group);
    }
}
