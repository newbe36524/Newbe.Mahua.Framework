using System.ComponentModel;

namespace Newbe.Mahua.Apis
{
    /// <summary>
    /// 设置群匿名设置
    /// </summary>
    [Description("设置群匿名设置")]
    public class SetGroupAnonymousOptionApiMahuaCommand : ApiMahuaCommand
    {
        public string ToGroup { get; set; }

        public bool Enabled { get; set; }
    }
}
