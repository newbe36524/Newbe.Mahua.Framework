using Newbe.Mahua.Samples.OkexRobot.Common;
using Newbe.Mahua.Samples.OkexRobot.Daos;
using System;
using System.Linq;

namespace Newbe.Mahua.Samples.OkexRobot.Services.Impl
{
    public class UserAssetTracer : IUserAssetTracer
    {
        private readonly IUserAssetService _userAssetService;
        private readonly IUserAssetDao _userAssetDao;

        public UserAssetTracer(
            IUserAssetService userAssetService,
            IUserAssetDao userAssetDao)
        {
            _userAssetService = userAssetService;
            _userAssetDao = userAssetDao;
        }

        public void Recode()
        {
            var userAssets = _userAssetService.GetUserAssets();
            _userAssetDao.Insert(new UserAssetEntity
            {
                UserAssets = userAssets,
                CreateTime = DateTime.Now,
            });
        }

        public void Report()
        {
            var now = DateTime.Now;
            var nowTime = now.Date.AddHours(now.Hour);
            var beforeTime = now.Date.AddHours(now.Hour).AddHours(-6);
            using (var session = MahuaRobotManager.Instance.CreateSession())
            {
                var beforeDatas = _userAssetDao.GetUserAssetEntities(beforeTime.AddMinutes(-30), beforeTime.AddMinutes(30));
                var nowDatas = _userAssetDao.GetUserAssetEntities(nowTime.AddMinutes(-30), nowTime.AddMinutes(30));
                var beforeData = beforeDatas.OrderByDescending(x => x.CreateTime).FirstOrDefault();
                var nowData = nowDatas.OrderByDescending(x => x.CreateTime).FirstOrDefault();
                var api = session.MahuaApi;
                var qq = SystemOptions.Instance.MasterQq;
                if (nowData == null)
                {
                    api.SendPrivateMessage(qq, "No UserAsset Record");
                    return;
                }

                var nowUsdt = nowData.UserAssets.Values.Sum(x => x.AsUsdt);

                if (beforeData == null)
                {
                    api.SendPrivateMessage(qq, $"{nowData.CreateTime:s}: $ {nowUsdt:0000000.00}");
                    return;
                }

                var beforeUsdt = beforeData.UserAssets.Values.Sum(x => x.AsUsdt);

                var change = nowUsdt - beforeUsdt;
                var changePercent = change / beforeUsdt * 100;
                var changeStr = changePercent > 0
                    ? $"↑↑↑{changePercent:000.00} ${change:000000.00}"
                    : $"↓↓↓{Math.Abs(changePercent):000.00} ${Math.Abs(change):000000.00}";
                api.SendPrivateMessage(qq)
                    .Text($"{beforeData.CreateTime:s}: $ {beforeUsdt:0000000.00}")
                    .Newline()
                    .Text($"{nowData.CreateTime:s}: $ {nowUsdt:0000000.00}")
                    .Newline()
                    .Text(changeStr)
                    .Done();

            }
        }
    }
}
