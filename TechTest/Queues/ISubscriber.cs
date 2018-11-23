using System.Threading.Tasks;
using TechTest.Messages;

namespace TechTest.Queues
{
    public interface ISubscriber<in T> where T : OfferMessage
    {
        Task Handle(T message);
    }
}