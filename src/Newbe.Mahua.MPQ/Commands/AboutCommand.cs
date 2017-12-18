using Newbe.Mahua.Commands;
using System.Runtime.Serialization;

namespace Newbe.Mahua.MPQ.Commands
{
    /// <summary>
    /// 放版权和声明\教程，点击“关于”按钮时触发
    /// </summary>
    public class AboutCommandHandler : ICommandHandler<AboutCommand>
    {
        public void Handle(AboutCommand message)
        {
            // todo 弹出基本信息
        }
    }

    [DataContract]
    public class AboutCommand : MpqCommand
    {
    }
}
