using Autofac;
using MediatR;
using Newbe.Mahua.Apis;
using Newbe.Mahua.Logging;
using System;
using System.Collections.Concurrent;

namespace Newbe.Mahua
{
    /// <summary>
    /// 用于在<see cref="IMahuaModule"/>中注册MahuaApi实现类的帮助类
    /// </summary>
    public static class MahuaApiRegistrations
    {
        /// <summary>
        /// 记录API实现者的作者名称，用于创建对应实现类时进行索引
        /// </summary>
        private static readonly ConcurrentDictionary<Type, string> ApiHandlerAuthorNames =
            new ConcurrentDictionary<Type, string>();

        private static readonly ILog Logger = LogProvider.GetLogger(typeof(MahuaApiRegistrations));

        /// <summary>
        /// 注册MahuaApi的实现类
        /// </summary>
        /// <typeparam name="THandler"></typeparam>
        /// <typeparam name="TCmd"></typeparam>
        /// <param name="builder"></param>
        /// <param name="authorName">实现此API的作者名称，若当前进程存在多个作者，则作者名称需要各不相同</param>
        public static void RegisterMahuaApi<THandler, TCmd>(this ContainerBuilder builder, string authorName)
            where THandler : IApiCommandHandler<TCmd>
            where TCmd : ApiMahuaCommand
        {
            ApiHandlerAuthorNames[typeof(TCmd)] = authorName;
            var handlerType = typeof(THandler);
            builder.RegisterType<THandler>().Keyed<IRequestHandler<TCmd>>(authorName);
            Logger.Info($"注册MahuaApi:[{handlerType.FullName} 作者名称：{authorName}]");
        }

        /// <summary>
        /// 注册MahuaApi的实现类
        /// </summary>
        /// <typeparam name="THandler"></typeparam>
        /// <typeparam name="TCmd"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="builder"></param>
        /// <param name="authorName">实现此API的作者名称，若当前进程存在多个作者，则作者名称需要各不相同</param>
        public static void RegisterMahuaApi<THandler, TCmd, TResult>(this ContainerBuilder builder, string authorName)
            where THandler : IApiCommandHandler<TCmd, TResult>
            where TCmd : ApiMahuaCommand<TResult>
            where TResult : ApiMahuaCommandResult
        {
            ApiHandlerAuthorNames[typeof(TCmd)] = authorName;
            var handlerType = typeof(THandler);
            builder.RegisterType<THandler>().Keyed<IRequestHandler<TCmd, TResult>>(authorName);
            Logger.Info($"注册MahuaApi:[{handlerType.FullName} 作者名称：{authorName}]");
        }

        internal static string GetHangdlerAuthorName(Type commandType)
        {
            if (ApiHandlerAuthorNames.TryGetValue(commandType, out var handlerName))
            {
                return handlerName;
            }

            MahuaGlobal.NotSupportedMahuaApiConvertion.Handle();
            return default(string);
        }
    }
}
