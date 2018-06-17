using Newbe.Mahua.Samples.OkexRobot.Services;
using System;
using System.Collections.Generic;

namespace Newbe.Mahua.Samples.OkexRobot.Daos
{
    public interface IUserAssetDao
    {
        void Insert(UserAssetEntity entity);
        UserAssetEntity[] GetUserAssetEntities(DateTime startTime, DateTime endTime);
    }

    public class UserAssetEntity
    {
        public int Id { get; set; }
        public DateTime CreateTime { get; set; }
        public Dictionary<string, UserAsset> UserAssets { get; set; }
    }
}
