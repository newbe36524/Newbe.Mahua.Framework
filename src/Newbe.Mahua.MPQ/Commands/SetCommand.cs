using Newbe.Mahua.Commands;
using System.Runtime.Serialization;

namespace Newbe.Mahua.MPQ.Commands
{
    /// <summary>
    /// 处理菜单
    /// </summary>
    public class SetCommandHandler : ICommandHandler<SetCommand>
    {
        public void Handle(SetCommand message)
        {
            // todo 处理菜单
        }
    }

    [DataContract]
    public class SetCommand : MpqCommand
    {
    }
}
