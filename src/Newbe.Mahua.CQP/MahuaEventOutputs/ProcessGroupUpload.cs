namespace Newbe.Mahua.CQP.MahuaEventOutputs
{
    public class ProcessGroupUpload : CqpEventOutput
    {
        public override string TypeCode { get; } = nameof(ProcessGroupUpload);
        public int SubType { get; set; }
        public int SendTime { get; set; }
        public long FromGroup { get; set; }
        public long FromQQ { get; set; }
        public string File { get; set; }
    }
}