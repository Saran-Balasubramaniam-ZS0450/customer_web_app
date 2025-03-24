using Microsoft.EntityFrameworkCore;

namespace customer_web_api.Entities
{
    public class CustomerWebContext:DbContext
    {
        public CustomerWebContext(DbContextOptions<CustomerWebContext> options):
            base(options)
        {
        }

        public DbSet<FeaturesPromos> FeaturesPromos { get; set; } = default!;
        public DbSet<CardDetails> CardDetails { get; set; }
    }
}
