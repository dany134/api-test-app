using Microsoft.EntityFrameworkCore;

namespace WebApplication1
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> op) : base (op)
        {

        }

        public DbSet<WeatherForecast> WeatherForecasts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<WeatherForecast>().HasNoKey();
        }
    }
}
