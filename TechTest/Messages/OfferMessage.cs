using System;

namespace TechTest.Messages
{
    public class OfferMessage
    {
        public int Id { get; set; }

        public int Version { get; set; }

        public string Description { get; set; }

        public DateTime From { get; set; }

        public DateTime To { get; set; }
    }
}