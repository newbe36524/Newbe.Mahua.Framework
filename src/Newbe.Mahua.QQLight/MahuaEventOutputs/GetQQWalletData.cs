namespace Newbe.Mahua.QQLight.MahuaEventOutputs
{
    public class GetQQWalletData : QQLighEventOutput
    {
        public override string TypeCode { get; } = nameof(GetQQWalletData);
        public int Type { get; set; }
        public string Fromqq { get; set; }
        public string Fromgroup { get; set; }
        public string FriendRemark { get; set; }
        public string Money { get; set; }
        public string OrderNo { get; set; }
    }
}