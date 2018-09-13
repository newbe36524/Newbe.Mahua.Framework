using Newbe.Mahua.Commands;
using System.Runtime.Serialization;

namespace Newbe.Mahua.CleverQQ.Commands
{
    /// <summary>
    /// 当插件被停用、卸载时将会调用
    /// </summary>
    public class IR_DestroyPluginCommandHandler : ICommandHandler<IR_DestroyPluginCommand, IR_DestroyPluginCommandResult>
    {
        public IR_DestroyPluginCommandResult Handle(IR_DestroyPluginCommand message)
        {
            // 不处理卸载事件
            return new IR_DestroyPluginCommandResult
            {
                Result = 0
            };
        }
    }

    [DataContract]
    public class IR_DestroyPluginCommand : CleverQQCommand<IR_DestroyPluginCommandResult>
    {
    }

    [DataContract]
    public class IR_DestroyPluginCommandResult : CleverQQCommandResult
    {
        [DataMember]
        public int Result { get; set; }
    }
}
