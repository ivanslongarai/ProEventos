using Microsoft.EntityFrameworkCore;
using ProEvents.Domain;

namespace ProEvents.Persistence
{
    public class ProEventsContext : DbContext
    {
        public ProEventsContext(DbContextOptions<ProEventsContext> options) :
            base(options)
        {
        }

        public DbSet<Event> Events { get; set; }

        public DbSet<Lot> Lots { get; set; }

        public DbSet<Speaker> Speakers { get; set; }

        public DbSet<SpeakerEvent> SpeakersEvents { get; set; }

        public DbSet<SocialNetwork> SocialNetworks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<SpeakerEvent>()
                .HasKey(pe => new { pe.EventId, pe.SpeakerId });
        }
    }
}
