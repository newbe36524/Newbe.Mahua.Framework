using Autofac.Extras.Moq;
using FluentAssertions;
using Newbe.Mahua.MahuaEvents;
using System;
using Xunit;
using Xunit.Abstractions;

namespace Newbe.Mahua.Plugins.Parrot.Tests
{
    public class ParrotTestV2
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public ParrotTestV2(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact(DisplayName = "消息包含“收到回复”")]
        public void Test1()
        {
            using (var mocker = AutoMock.GetStrict())
            {
                mocker.VerifyAll = true;
                var mahuaApi = mocker.Mock<IMahuaApi>();
                var msgSend = false;
                mahuaApi
                    .Setup(x => x.SendPrivateMessage("472158246", "请马上捐款"))
                    .Callback<string, string>((qq, msg) =>
                    {
                        _testOutputHelper.WriteLine($"测试将消息发送给{qq},消息是{msg}");
                        msgSend = true;
                    });

                // 这里使用的是V2
                IPrivateMessageFromFriendReceivedMahuaEvent @event =
                    mocker.Create<PrivateMessageFromFriendReceivedMahuaEventV2>();
                @event.ProcessFriendMessage(new PrivateMessageFromFriendReceivedContext
                {
                    FromQq = "472158246",
                    Message = "请马上捐款收到回复",
                    SendTime = DateTime.Now
                });

                // 注意，这里是true
                msgSend.Should().BeTrue();
            }
        }

        [Fact(DisplayName = "消息不包含“收到回复”")]
        public void Test2()
        {
            using (var mocker = AutoMock.GetStrict())
            {
                mocker.VerifyAll = true;

                // 因为我们确定不会调用IMahuaApi，所以不需要Mock

                // 这里使用的是V2
                IPrivateMessageFromFriendReceivedMahuaEvent @event =
                    mocker.Create<PrivateMessageFromFriendReceivedMahuaEventV2>();
                @event.ProcessFriendMessage(new PrivateMessageFromFriendReceivedContext
                {
                    FromQq = "472158246",
                    Message = "呵呵哒",
                    SendTime = DateTime.Now
                });
            }
        }
    }
}
