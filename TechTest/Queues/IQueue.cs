using TechTest.Messages;

namespace TechTest.Queues
{
    public interface IQueue<T> where T : OfferMessage
    {
        void Register(ISubscriber<T> subscriber);

        void Publish(T message);
    }
}