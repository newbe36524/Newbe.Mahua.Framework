using Newbe.Mahua.MahuaEvents;
using Newbe.Mahua.Samples.OkexRobot.Services;
using System.Linq;

namespace Newbe.Mahua.Samples.OkexRobot.MahuaEvents
{
    /// <summary>
    /// 获取用户资产
    /// </summary>
    public class GetAssetEvent
        : MasterPrivateMessageEventBase
    {
        private readonly IUserAssetService _userAssetService;

        public GetAssetEvent(
            IMahuaApi mahuaApi,
            IUserAssetService userAssetService)
            : base(mahuaApi)
        {
            _userAssetService = userAssetService;
        }

        public override void HandleCore(PrivateMessageReceivedContext context)
        {
            MahuaApi.SendPrivateMessage(context.FromQq)
                .Text("Begin Get User Asset")
                .Done();

            var userAssets = _userAssetService.GetUserAssets();
            if (userAssets.Any())
            {
                var assets = userAssets.Where(x => x.Value.AsUsdt > 1).OrderByDescending(x => x.Value.AsUsdt).ToArray();
                foreach (var kv in assets)
                {
                    MahuaApi.SendPrivateMessage(context.FromQq)
                        .Text(kv.Key.ToUpperInvariant())
                        .Newline()
                        .Text((kv.Value.Balance + kv.Value.Locked).ToString("e2"))
                        .Newline()
                        .Text(kv.Value.AsUsdt.ToString("'$' 0000000.000"))
                        .Done();
                }

                var totalusd = assets.Sum(x => x.Value.AsUsdt);
                var totalyuan = totalusd * 6.5M;
                MahuaApi.SendPrivateMessage(context.FromQq)
                    .Text("Total:")
                    .Text(totalusd.ToString("'$' 0000000.00"))
                    .Text(totalyuan.ToString("'￥' 0000000.00"))
                    .Done();
            }
            else
            {
                MahuaApi.SendPrivateMessage(context.FromQq, "获取失败或没有任何资产");
            }
        }

        public override string MenuCode => "1";
    }


}
