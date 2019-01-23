namespace Newbe.Mahua.QQLight.MahuaEventOutputs
{
    public class BecomeFriends : QQLighEventOutput
    {
        public override string TypeCode { get; } = nameof(BecomeFriends);
        public string Fromqq { get; set; }
    }
}