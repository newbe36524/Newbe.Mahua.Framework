using System.Collections.Generic;

namespace Newbe.Mahua.Samples.OkexRobot.Services
{
    public interface IUserAssetService
    {
        Dictionary<string, UserAsset> GetUserAssets();
    }

    public class UserAsset
    {
        public string Currency { get; set; }
        public decimal Balance { get; set; }
        public decimal Locked { get; set; }
        public decimal AsUsdt { get; set; }
    }
}
