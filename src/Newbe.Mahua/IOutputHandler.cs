using System.Threading.Tasks;

namespace Newbe.Mahua
{
    public interface IOutputHandler
    {
        Task Handle(IOutput output);
    }
}