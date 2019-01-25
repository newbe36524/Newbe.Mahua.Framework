namespace Newbe.Mahua.CleverQQ.MahuaEventOutputs
{
    public class Event : CleverQQEventOutput
    {
        public override string TypeCode { get; } = nameof(Event);
        public string ReceiverQq { get; set; }
        public int EventAdditionType { get; set; }
        public string EventOperator { get; set; }
        public int EventType { get; set; }
        public string FromNum { get; set; }
        public string Message { get; set; }
        public string RawMessage { get; set; }
        public string Triggee { get; set; }
        public string MessageId { get; set; }
        public string MessageNum { get; set; }
        public string Json { get; set; }
    }
}