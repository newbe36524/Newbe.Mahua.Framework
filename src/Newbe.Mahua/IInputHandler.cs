using System.Threading.Tasks;

namespace Newbe.Mahua
{
    public interface IInputHandler
    {
        Task Handle(IInput input);
    }
}