namespace Newbe.Mahua
{
    /// <summary>
    /// 调用标记为<see cref="NotSupportedMahuaApiAttribute"/>的Api的行为
    /// </summary>
    public interface INotSupportedMahuaApiConvertion
    {
        /// <summary>
        /// 处理
        /// </summary>
        void Handle();

        /// <summary>
        /// 处理后返回一个默认的值，通常是为了处理具有返回值的方法。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        T Handle<T>(T defaultValue);

        /// <summary>
        /// 处理后返回一个默认的值，通常是为了处理具有返回值的方法。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>default(T)</returns>
        T Handle<T>();
    }
}
