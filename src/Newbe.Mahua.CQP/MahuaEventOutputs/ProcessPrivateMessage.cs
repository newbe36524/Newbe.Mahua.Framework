namespace Newbe.Mahua.CQP.MahuaEventOutputs
{
    public class ProcessPrivateMessage : CqpEventOutput
    {
        public override string TypeCode { get; } = nameof(ProcessPrivateMessage);
        public int SubType { get; set; }
        public long FromQQ { get; set; }
        public string Msg { get; set; }
        public int MsgId { get; set; }
        public int Font { get; set; }
    }
}