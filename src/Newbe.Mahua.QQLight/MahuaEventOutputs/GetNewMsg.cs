namespace Newbe.Mahua.QQLight.MahuaEventOutputs
{
    public class GetNewMsg : QQLighEventOutput
    {
        public override string TypeCode { get; } = nameof(GetNewMsg);
        public string Message { get; set; }
        public int Type { get; set; }
        public string Fromgroup { get; set; }
        public string Fromqq { get; set; }
        public string MessageId { get; set; }
    }
}