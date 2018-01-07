using Refit;
using System.Threading.Tasks;

namespace Newbe.Mahua.CQP.ApiExtensions
{
    public interface IQqGroupApi
    {
        [Post("/cgi-bin/announce/add_qun_notice")]
        Task<string> SetNotice([Body(BodySerializationMethod.UrlEncoded)]SetNoticeInput input);
    }

    public class SetNoticeInput
    {
        [AliasAs("bkn")]
        public string Bkn { get; set; }

        [AliasAs("qid")]
        public string Qid { get; set; }

        [AliasAs("title")]
        public string Title { get; set; }

        [AliasAs("text")]
        public string Text { get; set; }
    }
}
