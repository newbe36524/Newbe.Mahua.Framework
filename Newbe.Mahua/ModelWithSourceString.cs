namespace Newbe.Mahua
{
    /// <summary>
    /// 包含序列化后的模型的原始字符串模型
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ModelWithSourceString<T> where T : class
    {
        /// <summary>
        /// 转换后的模型
        /// </summary>
        public T Model { get; set; }

        /// <summary>
        /// 原字符串
        /// </summary>
        public string SourceString { get; set; }
    }
}