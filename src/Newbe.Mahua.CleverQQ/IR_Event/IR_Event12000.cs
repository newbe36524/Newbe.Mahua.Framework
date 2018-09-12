using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using System.Collections.Generic;

namespace Newbe.Mahua.CleverQQ.IR_Event
{
    /// <summary>
    /// 本插件载入(初始化) 返回20可拒绝加载 其他返回值均视为允许
    /// </summary>
    public class IR_Event12000 : IIR_Event
    {
        private readonly IEnumerable<IInitializationMahuaEvent> _initializationMahuaEvent;

        public IR_Event12000(
            IEnumerable<IInitializationMahuaEvent> initializationMahuaEvent)
        {
            _initializationMahuaEvent = initializationMahuaEvent;
        }

        public int IR_Event { get; } = 12000;

        public void Handle(IR_EventInput eventFunInput)
        {
            _initializationMahuaEvent
                .Handle(x => x.Initialized(new InitializedContext { }));

            // todo there is no mahua event
        }
    }
}
