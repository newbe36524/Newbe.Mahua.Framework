using System.Threading.Tasks;

namespace Newbe.Mahua.Samples.LiveGirl.Services
{
    public interface ILivegirl
    {
        Task StartAsync();

        Task StopAsnyc();
    }


}
