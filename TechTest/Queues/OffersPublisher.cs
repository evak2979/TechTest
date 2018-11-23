using System;
using System.Threading;
using TechTest.Messages;

namespace TechTest.Queues
{
    public class OffersPublisher
    {
        private readonly IQueue<OfferMessage> _queue;

        private static readonly Random Random = new Random();

        private static readonly OfferMessage[] Offers = 
            {
                new OfferMessage
                    {
                        Id = 1,
                        Description = "Two for one on mains"
                    },
                new OfferMessage
                    {
                        Id = 2,
                        Description = "Three for one on mains"
                    },
                new OfferMessage
                    {
                        Id = 3,
                        Description = "Free dessert when ordering starter and main"
                    },
                new OfferMessage
                    {
                        Id = 4,
                        Description = "Free dessert and starter when ordering a main"
                    },
                new OfferMessage
                    {
                        Id = 5,
                        Description = "20% discount coupon for your next visit"
                    },
                new OfferMessage
                    {
                        Id = 6,
                        Description = "30% discount coupon for your next visit"
                    },
                new OfferMessage
                {
                    Id = 7,
                    Description = "30% discount coupon for your next visit"
                }
            };

        public OffersPublisher(IQueue<OfferMessage> queue)
        {
            _queue = queue;
        }

        public void Start()
        {
            while (true)
            {
                Thread.Sleep(2000);

                var restaurantOffer = Offers[Random.Next(0, Offers.Length)];

                restaurantOffer.Version = Random.Next(1, 100);
                restaurantOffer.From = DateTime.Now.AddDays(Random.Next(1, 5));
                restaurantOffer.To = DateTime.Now.AddDays(Random.Next(5, 10));

                _queue.Publish(restaurantOffer);
            }
        }
    }
}