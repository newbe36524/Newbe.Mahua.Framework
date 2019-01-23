namespace Newbe.Mahua.CQP.MahuaEventOutputs
{
    public class ProcessJoinGroupEventOutput : CqpEventOutput
    {
        public override string TypeCode { get; } = nameof(ProcessJoinGroupEventOutput);
        public int SubType { get; set; }
        public int SendTime { get; set; }
        public long FromQQ { get; set; }
        public long FromGroup { get; set; }
        public string Msg { get; set; }
        public string ResponseMark { get; set; }
    }
}