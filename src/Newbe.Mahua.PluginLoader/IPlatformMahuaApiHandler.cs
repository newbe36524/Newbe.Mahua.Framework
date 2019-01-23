using System.Collections.Generic;
using System.Threading.Tasks;

namespace Newbe.Mahua
{
    public interface IPlatformMahuaApiHandler
    {
        Task Run(string typeCode, IReadOnlyDictionary<string, object> data);
    }
}