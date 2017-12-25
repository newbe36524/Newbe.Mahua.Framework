using Autofac.Extras.Moq;
using FluentAssertions;
using Newbe.Mahua.MahuaEvents;
using Newbe.Mahua.Plugins.Parrot.MahuaEvents;
using System;
using Xunit;
using Xunit.Abstractions;

namespace Newbe.Mahua.Plugins.Parrot.Tests
{
    public class ParrotTest
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public ParrotTest(ITestOutputHelper testOutputHelper)
        {
            // 这是xunit特有的信息输出方法，其他框架可以使用Console.Writeline
            _testOutputHelper = testOutputHelper;
        }

        [Fact(DisplayName = "将消息回发给消息发送者")]
        public void Test()
        {
            // 一般的单元测试都分为三个部分 Arrange(准备) Action(执行) 和 Assert(断言)
            // Arrange 对单元测试中需要测试的准备参数进行初始化
            // Action 执行需要测试的逻辑
            // Assert 对测试结果是否正确进行判断
            using (var mocker = AutoMock.GetStrict())
            {
                // Moq的参数，确定在整个单元测试结束之后，所有被模拟的方法都已经被执行。
                mocker.VerifyAll = true;

                #region Arrange

                // 生成一个IMahuaApi的实现，这个实现的所有方法都是没有实现的，需要进一步填充
                var mahuaApi = mocker.Mock<IMahuaApi>();

                // 用来记录消息是否已经发送的变量，为了在断言中使用
                var msgSend = false;

                // 对MahuaApi中的SendPrivateMessage方法进行模拟
                // 当调用参数是“472158246”和“呵呵哒”时，调用xunit帮助类在控制台输出消息
                // 并设置变量msgSend为true  表示，消息确实已经回发了
                mahuaApi
                    .Setup(x => x.SendPrivateMessage("472158246", "呵呵哒"))
                    .Callback<string, string>((qq, msg) =>
                    {
                        _testOutputHelper.WriteLine($"测试将消息发送给{qq},消息是{msg}");
                        msgSend = true;
                    });

                #endregion

                #region Action

                //创建需要测试的类，由于使用了Autofac.Extras.Moq，构造函数注入的过程会自动执行
                IPrivateMessageFromFriendReceivedMahuaEvent @event =
                    mocker.Create<PrivateMessageFromFriendReceivedMahuaEvent>();

                // 模拟某人向机器人发送了消息
                @event.ProcessFriendMessage(new PrivateMessageFromFriendReceivedContext
                {
                    FromQq = "472158246",
                    Message = "呵呵哒",
                    SendTime = DateTime.Now
                });

                #endregion

                #region Assert

                // 根据这个变量判断 机器人是否成功回发了消息
                msgSend.Should().BeTrue();

                #endregion
            }
        }
    }
}
