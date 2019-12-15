namespace Newbe.Mahua.QQLight.MahuaEventOutputs
{
    public class FriendChange : QQLighEventOutput
    {
        public override string TypeCode { get; } = nameof(GetNewMsg);
        public string Fromqq { get; set; }
        public int Type { get; set; }
    }
}