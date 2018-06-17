using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Newbe.Mahua.Samples.OkexRobot.OkexApi
{
    public interface IUserInfoApi : IOkexApi
    {
        [Post("/v1/userinfo.do")]
        Task<UserInfoOutput> GetUserInfo([Body(BodySerializationMethod.UrlEncoded)] OkexInput input);
    }

    public class UserInfoOutput
    {
        public UserInfo Info { get; set; }
        public bool Result { get; set; }

        public class UserInfo
        {
            public Funds Funds { get; set; }
        }

        public class Funds
        {
            public Free Free { get; set; }
            public Freezed Freezed { get; set; }
        }

        public class Free : Dictionary<string, decimal>
        {
        }

        public class Freezed : Dictionary<string, decimal>
        {
        }
    }
}
