namespace Newbe.Mahua.QQLight.MahuaEventOutputs
{
    public class AddGroup : QQLighEventOutput
    {
        public override string TypeCode { get; } = nameof(AddGroup);
        public int Type { get; set; }
        public string Fromqq { get; set; }
        public string Fromgroup { get; set; }
        public string InvatorQq { get; set; }
        public string MoreMsg { get; set; }
        public string Seq { get; set; }
    }
}