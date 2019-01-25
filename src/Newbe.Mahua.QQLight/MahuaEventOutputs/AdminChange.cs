namespace Newbe.Mahua.QQLight.MahuaEventOutputs
{
    public class AdminChange : QQLighEventOutput
    {
        public override string TypeCode { get; } = nameof(AdminChange);
        public int Type { get; set; }
        public string Fromqq { get; set; }
        public string Fromgroup { get; set; }
    }
}