namespace ProEvents.API.Models
{
    public class Event
    {
        public int Id { get; set; }

        public string Local { get; set; }

        public string EventDate { get; set; }

        public string Subject { get; set; }

        public int Quantity { get; set; }

        public string Lot { get; set; }

        public string ImageURL { get; set; }
    }
}
