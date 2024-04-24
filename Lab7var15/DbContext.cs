using CoinCollection.Models;
using Microsoft.EntityFrameworkCore;

namespace CoinCollection.Data
{
    public class CoinCollectionDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=postgres;Database=Lab7var15");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Coin>().ToTable("coins");
            modelBuilder.Entity<Coin>().HasKey(c => c.Id);
            modelBuilder.Entity<Coin>().Property(c => c.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Coin>().Property(c => c.Year).IsRequired();
            modelBuilder.Entity<Coin>().Property(c => c.Country).IsRequired();
            modelBuilder.Entity<Coin>().Property(c => c.Nominal).IsRequired();
            modelBuilder.Entity<Coin>().Property(c => c.Condition).IsRequired();
        }

        public DbSet<Coin> Coins { get; set; }
    }
}