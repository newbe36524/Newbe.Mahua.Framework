using Autofac;
using Newbe.Mahua.Messages;

namespace Newbe.Mahua
{
    public static class MessageBuilderExtensions
    {
        /// <summary>
        /// 发送私聊消息
        /// </summary>
        /// <param name="api"></param>
        /// <param name="toQq"></param>
        /// <returns></returns>
        public static IPrivateMessageStep SendPrivateMessage(this IMahuaApi api, string toQq)
        {
            var privateMessageBuilder = api
                .GetLifetimeScope()
                .BeginLifetimeScope()
                .Resolve<IPrivateMessageFlowFactory>();
            var re = privateMessageBuilder.Begin(toQq);
            return re;
        }

        /// <summary>
        /// 发送群消息
        /// </summary>
        /// <param name="api"></param>
        /// <param name="toGroup"></param>
        /// <returns></returns>
        public static IGroupMessageStep SendGroupMessage(this IMahuaApi api, string toGroup)
        {
            var groupMessageFactory = api
                .GetLifetimeScope()
                .BeginLifetimeScope()
                .Resolve<IGroupMessageFlowFactory>();
            var re = groupMessageFactory.Begin(toGroup);
            return re;
        }

        /// <summary>
        /// 发送讨论组消息
        /// </summary>
        /// <param name="api"></param>
        /// <param name="toDiscuss"></param>
        /// <returns></returns>
        public static IDiscussMessageStep SendDiscussMessage(this IMahuaApi api, string toDiscuss)
        {
            var discussMessage = api
                .GetLifetimeScope()
                .BeginLifetimeScope()
                .Resolve<IDiscussMessageFlowFactory>();
            var re = discussMessage.Begin(toDiscuss);
            return re;
        }
    }
}
