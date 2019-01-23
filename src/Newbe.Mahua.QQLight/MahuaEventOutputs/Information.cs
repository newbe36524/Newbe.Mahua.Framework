namespace Newbe.Mahua.QQLight.MahuaEventOutputs
{
    public class Information : QQLighEventOutput
    {
        public override string TypeCode { get; } = nameof(Information);
        public string AuthCode { get; set; }
    }
}