namespace Newbe.Mahua.QQLight.MahuaEventOutputs
{
    public class Information : QQLighEventOutput
    {
        public override string TypeCode { get; } = nameof(Information);
        public int AuthCode { get; set; }
    }
}