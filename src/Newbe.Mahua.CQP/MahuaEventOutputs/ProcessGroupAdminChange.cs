namespace Newbe.Mahua.CQP.MahuaEventOutputs
{
    public class ProcessGroupAdminChange : CqpEventOutput
    {
        public override string TypeCode { get; } = nameof(ProcessGroupAdminChange);
        public int SubType { get; set; }
        public int SendTime { get; set; }
        public long Target { get; set; }
        public long FromGroup { get; set; }
    }
}