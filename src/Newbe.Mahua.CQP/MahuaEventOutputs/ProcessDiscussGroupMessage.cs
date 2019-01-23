namespace Newbe.Mahua.CQP.MahuaEventOutputs
{
    public class ProcessDiscussGroupMessage : CqpEventOutput
    {
        public override string TypeCode { get; } = nameof(ProcessDiscussGroupMessage);
        public int SubType { get; set; }
        public string Msg { get; set; }
        public long FromDiscuss { get; set; }
        public long FromQQ { get; set; }
        public int MsgId { get; set; }
        public int Font { get; set; }
    }
}