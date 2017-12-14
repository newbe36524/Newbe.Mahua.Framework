using Newbe.Mahua.MahuaEvents;
using System;

namespace Newbe.Mahua.Plugins.Parrot
{
    /// <summary>
    /// 监听来自好友的私聊消息事件
    /// </summary>
    public class PrivateMessageFromFriendReceivedMahuaEvent : IPrivateMessageFromFriendReceivedMahuaEvent
    {
        private readonly IMahuaApi _mahuaApi;

        /// <summary>
        /// 采用构造函数注入<see cref="IMahuaApi"/>，以便后续调用
        /// </summary>
        /// <param name="mahuaApi"></param>
        public PrivateMessageFromFriendReceivedMahuaEvent(IMahuaApi mahuaApi)
        {
            _mahuaApi = mahuaApi;
        }

        /// <summary>
        /// 处理事件
        /// </summary>
        /// <param name="context"></param>
        public void ProcessFriendMessage(PrivateMessageFromFriendReceivedContext context)
        {
            //调用_mahuaApi实现将消息回发给好友的功能
            _mahuaApi.SendPrivateMessage(context.FromQq, context.Message);
            foreach (var groupInfo in _mahuaApi.GetGroupsWithModel().Model)
            {
                foreach (var groupMemberInfo in _mahuaApi.GetGroupMemebersWithModel(groupInfo.Group).Model)
                {
                    Console.WriteLine(groupMemberInfo);
                }
            }
        }
    }
}
