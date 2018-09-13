using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System.Collections.Generic;

namespace Newbe.Mahua.CleverQQ.IrEvents
{
    /// <summary>
    /// 本插件载入(初始化) 返回20可拒绝加载 其他返回值均视为允许
    /// </summary>
    public class IrEvent12000 : IIrEvent
    {
        private readonly IEnumerable<IInitializationMahuaEvent> _initializationMahuaEvent;

        public IrEvent12000(
            IEnumerable<IInitializationMahuaEvent> initializationMahuaEvent)
        {
            _initializationMahuaEvent = initializationMahuaEvent;
        }

        public int IrEventCode { get; } = 12000;

        public void Handle(IrEventInput eventFunInput)
        {
            _initializationMahuaEvent
                .Handle(x => x.Initialized(new InitializedContext { }));

            // todo there is no mahua event
        }
    }
}
