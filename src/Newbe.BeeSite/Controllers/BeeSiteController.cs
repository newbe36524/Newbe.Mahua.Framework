using RestSharp;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Newbe.BeeSite.Controllers
{
    public class BeeSiteController : ApiController
    {
        [EnableCors("*", "*", "*")]
        [HttpGet]
        [Route("api/beesite/status")]
        public bool Status()
        {
            var client = new RestClient("https://api.live.bilibili.com");
            var req = new RestRequest("room/v1/Room/get_info?room_id=7834872&from=room");
            var resp = client.Get<Rootobject>(req);
            if (resp.IsSuccessful)
            {
                return resp.Data.data.live_status == 1;
            }
            return false;
        }
    }

    public class Rootobject
    {
        public int code { get; set; }
        public string msg { get; set; }
        public string message { get; set; }
        public Data data { get; set; }
    }

    public class Data
    {
        public int uid { get; set; }
        public string description { get; set; }
        public int live_status { get; set; }
        public int area_id { get; set; }
        public int parent_area_id { get; set; }
        public string parent_area_name { get; set; }
        public int old_area_id { get; set; }
        public string background { get; set; }
        public string title { get; set; }
        public string user_cover { get; set; }
        public string live_time { get; set; }
        public string tags { get; set; }
        public int is_anchor { get; set; }
        public string room_silent_type { get; set; }
        public int room_silent_level { get; set; }
        public int room_silent_second { get; set; }
        public string area_name { get; set; }
        public string pendants { get; set; }
        public string area_pendants { get; set; }
        public string verify { get; set; }
    }


}
