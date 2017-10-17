using System;
using Newbe.Mahua.Internals;

namespace Newbe.Mahua
{
    /// <summary>
    /// Mahua默认规则
    /// </summary>
    public static class MahuaConvertions
    {
        /// <summary>
        /// 调用标记为<see cref="NotSupportedMahuaApiAttribute"/>的Api将引发的规则
        /// </summary>
        public static class NotSupportedMahuaApiConvertions
        {
            /// <summary>
            /// 忽略此次调用继续进行下一步
            /// </summary>
            public static INotSupportedMahuaApiConvertion IgnoreNotSupportedMahuaApiConvertion =>
                new IgnoreNotSupportedMahuaApiConvertion();

            /// <summary>
            /// 抛出指定的异常
            /// </summary>
            /// <typeparam name="TException">希望抛出的异常类型</typeparam>
            /// <returns></returns>
            public static INotSupportedMahuaApiConvertion GetThrowsNotSupportedMahuaApiConvertion<TException>()
                where TException : Exception, new() => new ThrowsNotSupportedMahuaApiConvertion<TException>();
        }
    }
}