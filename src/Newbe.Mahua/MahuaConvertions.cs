using Newbe.Mahua.Internals;
using System;

namespace Newbe.Mahua
{
    /// <summary>
    /// Mahua默认规则
    /// </summary>
    public static class MahuaConvertions
    {
        /// <summary>
        /// 调用不受支持的Api将引发的规则
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
                where TException : Exception, new()
            {
                return new ThrowsNotSupportedMahuaApiConvertion<TException>();
            }
        }

        public static class NotSupportedMessageBuilderConvertions
        {
            /// <summary>
            /// 忽略此次调用继续进行下一步
            /// </summary>
            public static INotSupportedMessageBuilderConvertion IgnoreNotSupportedMessageBuilderConvertion =>
                new IgnoreNotSupportedMessageBuilderConvertion();

            /// <summary>
            /// 抛出指定的异常
            /// </summary>
            /// <typeparam name="TException">希望抛出的异常类型</typeparam>
            public static INotSupportedMessageBuilderConvertion GetThrowsNotSupportedMahuaApiConvertion<TException>()
                where TException : Exception, new()
            {
                return new ThrowsNotSupportedMessageBuilderConvertion<TException>();
            }
        }
    }
}
