using System;
using System.Threading.Tasks;
using TechTest.Messages;

namespace TechTest.Queues
{
    public class OffersSubscriber : ISubscriber<OfferMessage>
    {
        public async Task Handle(OfferMessage message)
        {
            throw new NotFiniteNumberException();
        }
    }
}