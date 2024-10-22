using Microsoft.EntityFrameworkCore;

namespace FXExchange.Data
{
    public class ExchangeDbContext : DbContext
    {
        public string DbPath { get; }

        public ExchangeDbContext()
        {
            var baseDirectory = AppContext.BaseDirectory;
            DbPath = Path.Combine(baseDirectory, "exchangeDb.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var currencyBuilder = modelBuilder.Entity<Currency>()
                .ToTable("Currency");
            currencyBuilder.HasKey(x => x.Id);
            currencyBuilder.HasMany<ExchangeRate>()
                           .WithOne()
                           .HasForeignKey(e => e.SourceCurrencyId)
                           .IsRequired();
            currencyBuilder.HasMany<ExchangeRate>()
                           .WithOne()
                           .HasForeignKey(e => e.DestinationCurrencyId)
                           .IsRequired();

            var exchangeRateBuilder = modelBuilder.Entity<ExchangeRate>()
                .ToTable("ExchangeRate");
            exchangeRateBuilder.HasKey(uv => new { uv.SourceCurrencyId, uv.DestinationCurrencyId });
        }
    }
}
