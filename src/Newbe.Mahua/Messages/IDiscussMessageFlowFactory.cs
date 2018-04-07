namespace Newbe.Mahua.Messages
{
    public interface IDiscussMessageFlowFactory
    {
        IDiscussMessageStep Begin(string discuss);
    }
}
