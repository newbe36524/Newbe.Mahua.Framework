namespace Newbe.Mahua.CleverQQ.MahuaEventOutputs
{
    public class Message : CleverQQEventOutput
    {
        public override string TypeCode { get; } = nameof(Message);
        public string RobotQQ { get; set; }
        public int MsgType { get; set; }
        public string Msg { get; set; }
        public string Cookies { get; set; }
        public string SessionKey { get; set; }
        public string ClientKey { get; set; }
    }
}