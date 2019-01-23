using System.Threading.Tasks;

namespace Newbe.Mahua
{
    public interface IOutputSender
    {
        Task Handle(IOutput output);
    }
}