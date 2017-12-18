namespace Newbe.Mahua.Internals
{
    internal class IgnoreNotSupportedMahuaApiConvertion : INotSupportedMahuaApiConvertion
    {
        void INotSupportedMahuaApiConvertion.Handle()
        {
            // 无需任何处理直接忽略
        }

        public T Handle<T>(T defaultValue)
        {
            return RetrunDefault<T>();
        }

        public T Handle<T>()
        {
            return RetrunDefault<T>();
        }

        private static T RetrunDefault<T>()
        {
            // 无需任何处理直接忽略
            return default(T);
        }
    }
}
