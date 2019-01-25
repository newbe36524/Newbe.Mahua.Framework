namespace Newbe.Mahua.CQP.MahuaEventOutputs
{
    public class ProcessFriendsAdded : CqpEventOutput
    {
        public override string TypeCode { get; } = nameof(ProcessFriendsAdded);
        public int SubType { get; set; }
        public int SendTime { get; set; }
        public long FromQQ { get; set; }
    }
}