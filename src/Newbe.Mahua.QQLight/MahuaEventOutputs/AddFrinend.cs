namespace Newbe.Mahua.QQLight.MahuaEventOutputs
{
    public class AddFrinend : QQLighEventOutput
    {
        public override string TypeCode { get; } = nameof(AddFrinend);
        public string Fromqq { get; set; }
        public string Reason { get; set; }
    }
}