namespace Newbe.Mahua.MPQ.NativeApi
{
    internal interface IQqContainer
    {
        long ReceivedQq { get; set; }
    }

    class QqContainer : IQqContainer
    {
        public long ReceivedQq { get; set; }
    }
}