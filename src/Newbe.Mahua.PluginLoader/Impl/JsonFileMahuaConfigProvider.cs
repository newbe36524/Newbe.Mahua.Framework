using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Newbe.Mahua.Impl
{
    internal class JsonFileMahuaConfigProvider : IMahuaConfigProvider
    {
        public IEnumerable<MahuaOutputConfig> GetOutputsConfig()
        {
            var mahuaJsonModel = GetJsonConfig();
            return mahuaJsonModel.Output;
        }

        public IEnumerable<MahuaInputConfig> GetInputsConfig()
        {
            var mahuaJsonModel = GetJsonConfig();
            return mahuaJsonModel.Input;
        }

        private static MahuaJsonModel GetJsonConfig() => JsonConvert.DeserializeObject<MahuaJsonModel>(
            File.ReadAllText(
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "mahua.json")));

        private class MahuaJsonModel
        {
            public MahuaInputConfig[] Input { get; set; }
            public MahuaOutputConfig[] Output { get; set; }
        }
    }
}