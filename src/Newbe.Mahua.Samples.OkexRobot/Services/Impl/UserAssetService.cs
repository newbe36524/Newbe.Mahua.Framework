using Newbe.Mahua.Samples.OkexRobot.OkexApi;
using System.Collections.Generic;
using System.Linq;

namespace Newbe.Mahua.Samples.OkexRobot.Services.Impl
{
    public class UserAssetService : IUserAssetService
    {
        private readonly IOkexApiFactory _okexApiFactory;
        private readonly ITickerProvider _tickerProvider;

        public UserAssetService(
            IOkexApiFactory okexApiFactory,
            ITickerProvider tickerProvider)
        {
            _okexApiFactory = okexApiFactory;
            _tickerProvider = tickerProvider;
        }

        public Dictionary<string, UserAsset> GetUserAssets()
        {
            var userInfoApi = _okexApiFactory.Create<IUserInfoApi>();
            var input = new OkexInput().WithSign();
            var output = userInfoApi.GetUserInfo(input).ConfigureAwait(false).GetAwaiter().GetResult();
            if (output.Result)
            {
                var userAssets = new Dictionary<string, UserAsset>();
                var funds = output.Info.Funds;
                foreach (var kv in funds.Free.Where(x => x.Value != 0))
                {
                    userAssets[kv.Key] = new UserAsset
                    {
                        Currency = kv.Key,
                        Balance = kv.Value,
                    };
                }

                foreach (var kv in funds.Freezed.Where(x => x.Value != 0))
                {
                    if (!userAssets.ContainsKey(kv.Key))
                    {
                        userAssets[kv.Key] = new UserAsset();
                    }
                    userAssets[kv.Key].Locked = kv.Value;
                }

                foreach (var kv in userAssets)
                {
                    var ticker = _tickerProvider.GetTikcer($"{kv.Key}_usdt");
                    var userAsset = kv.Value;
                    userAssets[kv.Key].AsUsdt = ticker.Last * (userAsset.Balance + userAsset.Locked);
                }

                return userAssets;
            }

            return new Dictionary<string, UserAsset>();
        }
    }
}
