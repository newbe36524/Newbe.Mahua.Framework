namespace Newbe.Mahua.CQP.MahuaEventOutputs
{
    public class ProcessGroupMessage : CqpEventOutput
    {
        public override string TypeCode { get; } = nameof(ProcessGroupMessage);
        public string Message { get; set; }
        public long FromGroup { get; set; }
        public string FromAnonymous { get; set; }
        public long FromQQ { get; set; }
        public int MsgId { get; set; }
        public int SubType { get; set; }
        public int Font { get; set; }
    }
}