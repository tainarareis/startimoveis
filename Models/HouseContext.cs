using Microsoft.EntityFrameworkCore;

namespace startimoveis.Models
{
    public class HouseContext : DbContext
    {
        public HouseContext (DbContextOptions<HouseContext> options)
            : base(options)
        {
        }

        public DbSet<startimoveis.Models.House> House { get; set; }
    }
}