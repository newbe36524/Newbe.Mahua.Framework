namespace Newbe.Mahua.MPQ.MahuaEventOutputs
{
    public class EventFun : MpqEventOutput
    {
        public override string TypeCode { get; } = nameof(EventFun);
        public string ReceiverQq { get; set; }
        public int EventAdditionType { get; set; }
        public string EventOperator { get; set; }
        public int EventType { get; set; }
        public string FromNum { get; set; }
        public string Message { get; set; }
        public string RawMessage { get; set; }
        public string Triggee { get; set; }
    }
}