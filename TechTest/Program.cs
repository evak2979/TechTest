using System;
using System.Threading.Tasks;
using TechTest.Data;
using TechTest.Queues;

namespace TechTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Database.Reset();

            var queue = new OffersQueue();
            queue.Register(new OffersSubscriber());

            var publisher = new OffersPublisher(queue);
            Task.Run(() => publisher.Start());
            
            Console.ReadLine();
        }
    }
}
