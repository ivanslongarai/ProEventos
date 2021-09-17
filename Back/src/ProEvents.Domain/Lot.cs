using System;

namespace ProEvents.Domain
{
    public class Lot
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public DateTime? InitialDate { get; set; }

        public DateTime? FinalDate { get; set; }

        public int Quantity { get; set; }

        public int EventId { get; set; }

        public Event Event { get; set; }
    }
}
