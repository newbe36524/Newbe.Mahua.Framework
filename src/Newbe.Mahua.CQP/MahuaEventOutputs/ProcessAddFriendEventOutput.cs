namespace Newbe.Mahua.CQP.MahuaEventOutputs
{
    public class ProcessAddFriendEventOutput : CqpEventOutput
    {
        public override string TypeCode { get; } = nameof(ProcessAddFriendEventOutput);
        public int SubType { get; set; }
        public int SendTime { get; set; }
        public long FromQQ { get; set; }
        public string Msg { get; set; }
        public string ResponseMark { get; set; }
    }
}