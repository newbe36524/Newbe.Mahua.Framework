using System.Collections.Generic;

namespace Newbe.Mahua
{
    public interface IMahuaConfigProvider
    {
        IEnumerable<MahuaOutputConfig> GetOutputsConfig();
        IEnumerable<MahuaInputConfig> GetInputsConfig();
    }
}