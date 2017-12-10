using Newbe.Mahua.Commands;
using System.Runtime.Serialization;

namespace Newbe.Mahua.MPQ.Commands
{
    /// <summary>
    /// 当插件被停用、卸载时将会调用
    /// </summary>
    public class EndCommandHandler : ICommandHandler<EndCommand, EndCommandResult>
    {
        public EndCommandResult Handle(EndCommand message)
        {
            // 不处理卸载事件
            return new EndCommandResult
            {
                Result = 0
            };
        }
    }

    [DataContract]
    public class EndCommand : MpqCommand<EndCommandResult>
    {
    }

    [DataContract]
    public class EndCommandResult : MpqCommandResult
    {
        [DataMember]
        public int Result { get; set; }
    }
}
