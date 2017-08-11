using Microsoft.EntityFrameworkCore;

namespace startimoveis.Models
{
    public class ApartmentContext : DbContext
    {
        public ApartmentContext (DbContextOptions<ApartmentContext> options)
            : base(options)
        {
        }

        public DbSet<startimoveis.Models.Property> Apartment { get; set; }
    }
}