using System.Collections.Generic;

namespace ProEvents.Domain
{
    public class Speaker
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string MiniResume { get; set; }

        public string ImageUrl { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public IEnumerable<SocialNetwork> SocialNetworks { get; set; }

        public IEnumerable<SpeakerEvent> SpeakerEvents { get; set; }
    }
}
