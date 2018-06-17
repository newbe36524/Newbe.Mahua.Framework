using LiteDB;
using System;
using System.IO;
using System.Linq;

namespace Newbe.Mahua.Samples.OkexRobot.Daos.Impl
{
    public class UserAssetDao : IUserAssetDao
    {
        private static readonly string UserAssetTracerDbPath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data", "userAssets.db");
        public void Insert(UserAssetEntity entity)
        {
            using (var db = new LiteDatabase(UserAssetTracerDbPath))
            {
                var collection = db.GetCollection<UserAssetEntity>();
                collection.EnsureIndex(x => x.CreateTime);
                collection.Insert(entity);
            }
        }

        public UserAssetEntity[] GetUserAssetEntities(DateTime startTime, DateTime endTime)
        {
            using (var db = new LiteDatabase(UserAssetTracerDbPath))
            {
                var collection = db.GetCollection<UserAssetEntity>();
                var re = collection
                    .Find(x => x.CreateTime > startTime && x.CreateTime <= endTime)
                    .ToArray();
                return re;
            }
        }
    }
}
