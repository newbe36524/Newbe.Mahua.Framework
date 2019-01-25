namespace Newbe.Mahua.QQLight.MahuaEventOutputs
{
    public class GroupMemberDecrease : QQLighEventOutput
    {
        public override string TypeCode { get; } = nameof(GroupMemberDecrease);
        public int Type { get; set; }
        public string Fromqq { get; set; }
        public string Fromgroup { get; set; }
        public string OperatorQq { get; set; }
    }
}