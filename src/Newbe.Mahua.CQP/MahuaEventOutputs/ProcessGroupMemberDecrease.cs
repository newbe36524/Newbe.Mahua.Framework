namespace Newbe.Mahua.CQP.MahuaEventOutputs
{
    public class ProcessGroupMemberDecrease : CqpEventOutput
    {
        public override string TypeCode { get; } = nameof(ProcessGroupMemberDecrease);
        public int SubType { get; set; }
        public int SendTime { get; set; }
        public long Target { get; set; }
        public long FromGroup { get; set; }
        public long FromQQ { get; set; }
    }
}