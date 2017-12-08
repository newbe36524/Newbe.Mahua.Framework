namespace Newbe.Mahua.Internals
{
    internal class IgnoreNotSupportedMahuaApiConvertion : INotSupportedMahuaApiConvertion
    {
        void INotSupportedMahuaApiConvertion.Handle()
        {
            // 无需任何处理直接忽略
        }
    }
}
