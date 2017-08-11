using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace startimoveis.Models
{
    public static class DBinitialize
    {
        public static void EnsureCreated(IServiceProvider serviceProvider)
        {
            var context = new HouseContext(
                serviceProvider.GetRequiredService<DbContextOptions<HouseContext>>());
            context.Database.EnsureCreated();
        }
    }
}