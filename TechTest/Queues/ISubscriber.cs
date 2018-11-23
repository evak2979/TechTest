using System.Threading.Tasks;
using TechTest.Messages;

namespace TechTest.Queues
{
    public interface ISubscriber<in T>
    {
        Task Handle(T message);
    }
}