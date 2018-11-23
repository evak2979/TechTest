using TechTest.Messages;

namespace TechTest.Queues
{
    public interface IQueue<T>
    {
        void Register(ISubscriber<T> subscriber);

        void Publish(T message);
    }
}