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
    }
}