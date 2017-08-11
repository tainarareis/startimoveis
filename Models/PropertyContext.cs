using Microsoft.EntityFrameworkCore;

namespace startimoveis.Models
{
    public class PropertyContext : DbContext
    {
        public PropertyContext (DbContextOptions<PropertyContext> options)
            : base(options)
        {
        }

        public DbSet<startimoveis.Models.Property> Property { get; set; }
    }
}