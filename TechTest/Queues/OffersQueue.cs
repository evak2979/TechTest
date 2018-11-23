using System.Collections.Generic;
using System.Threading.Tasks;
using TechTest.Messages;

namespace TechTest.Queues
{
    public class OffersQueue : IQueue<OfferMessage>
    {
        private readonly List<ISubscriber<OfferMessage>> _subscribers = new List<ISubscriber<OfferMessage>>();

        public void Register(ISubscriber<OfferMessage> subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void Publish(OfferMessage message)
        {
            _subscribers.ForEach(x => Task.Run(() => x.Handle(message)));
        }
    }
}