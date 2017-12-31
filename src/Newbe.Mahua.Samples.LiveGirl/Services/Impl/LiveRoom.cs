using RestSharp;

namespace Newbe.Mahua.Samples.LiveGirl.Services.Impl
{
    public class LiveRoom : ILiveRoom
    {
        public bool IsOnLive()
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

        // 可以使用VS中的 编辑->选择性粘贴->将JSON粘贴为类
        // 莫非不知道么ლ(′◉❥◉｀ლ)
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
}
