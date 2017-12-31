using Autofac.Extras.Moq;
using FluentAssertions;
using Moq;
using Newbe.Mahua.MahuaEvents;
using Newbe.Mahua.Samples.Sqlite.MahuaEvents;
using Newbe.Mahua.Samples.Sqlite.Services;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Newbe.Mahua.Samples.Sqlite.Tests
{
    public class PrivateMessageFromFriendReceivedMahuaEventTests
    {
        [Fact]
        public void Test()
        {
            using (var mocker = AutoMock.GetStrict())
            {
                mocker.VerifyAll = true;

                var now = DateTime.Now;
                var msg = string.Empty;

                mocker.Mock<IMahuaApi>()
                    .Setup(x => x.SendPrivateMessage("472158246", It.IsAny<string>()))
                    .Callback<string, string>((qq, inputmsg) => msg = inputmsg);

                mocker.Mock<IFriendMessageStore>()
                    .Setup(x => x.InsertAsync(It.IsAny<InsertFriendMessageInput>()))
                    .Returns(Task.FromResult(0));

                mocker.Mock<IFriendMessageStore>()
                    .Setup(x => x.GetCountAsync())
                    .Returns(Task.FromResult(200));

                var service = mocker.Create<PrivateMessageFromFriendReceivedMahuaEvent>();
                service.ProcessFriendMessage(new PrivateMessageFromFriendReceivedContext
                {
                    FromQq = "472158246",
                    Message = "MSG",
                    SendTime = now
                });

                msg.Should().Be("存储中已经存在200条好友信息。");
            }
        }
    }
}
