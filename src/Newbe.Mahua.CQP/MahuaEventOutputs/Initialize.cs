namespace Newbe.Mahua.CQP.MahuaEventOutputs
{
    public class Initialize : CqpEventOutput
    {
        public override string TypeCode { get; } = nameof(Initialize);
        public int AuthCode { get; set; }
    }
}