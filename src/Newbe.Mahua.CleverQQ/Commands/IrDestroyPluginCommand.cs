using Newbe.Mahua.Commands;
using System.Runtime.Serialization;

namespace Newbe.Mahua.CleverQQ.Commands
{
    /// <summary>
    /// 当插件被停用、卸载时将会调用
    /// </summary>
    public class IrDestroyPluginCommandHandler : ICommandHandler<IrDestroyPluginCommand, IrDestroyPluginCommandResult>
    {
        public IrDestroyPluginCommandResult Handle(IrDestroyPluginCommand message)
        {
            // 不处理卸载事件
            return new IrDestroyPluginCommandResult
            {
                Result = 0
            };
        }
    }

    [DataContract]
    public class IrDestroyPluginCommand : CleverQQCommand<IrDestroyPluginCommandResult>
    {
    }

    [DataContract]
    public class IrDestroyPluginCommandResult : CleverQQCommandResult
    {
        [DataMember]
        public int Result { get; set; }
    }
}
