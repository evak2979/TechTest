using System;
using System.Threading.Tasks;
using LiteDB;
using TechTest.Dto;
using TechTest.Messages;
using TechTest.Repositories;

namespace TechTest.Queues
{
    public class OffersSubscriber : ISubscriber<OfferMessage>
    {
        public async Task Handle(OfferMessage message)
        {
            try
            {
                var x = new OffersRepository<OfferDtoBase>();

                var y = x.GetById(message.Id).Result;

                if (y == null)
                {
                    var insertDto = new OfferDtoBase()
                    {
                        Id = message.Id
                    };

                    await x.Insert(insertDto);
                }
            }
            catch (LiteException ex)
            {
                Console.WriteLine($"\t\n ***Database error*** \t\n ");
            }
        }
    }
}