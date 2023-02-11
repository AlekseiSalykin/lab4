using Microsoft.EntityFrameworkCore;

namespace WebApplication5
{
    public partial class CityContext : DbContext
    {
        public virtual DbSet<City> Cities => Set<City>();
        public CityContext(DbContextOptions<CityContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
