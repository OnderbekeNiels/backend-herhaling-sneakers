using System;
using System.Threading;
using System.Threading.Tasks;
using backend_herhaling_sneakers.Configuration;
using backend_herhaling_sneakers.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace backend_herhaling_sneakers.Data
{
    public interface ISneakerContext
    {
        DbSet<Sneaker> Sneakers { get; set; }
        DbSet<Brand> Brands { get; set; }
        DbSet<Occasion> Occasions { get; set; }
        DbSet<Image> Images { get; set; }
        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }

    public class SneakerContext : DbContext, ISneakerContext
    {
        public DbSet<Sneaker> Sneakers { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Occasion> Occasions { get; set; }
        public DbSet<Image> Images { get; set; }

        private ConnectionStrings _connectionStrings;

        public SneakerContext(DbContextOptions<SneakerContext> options, IOptions<ConnectionStrings> connectionStrings)
        {
            _connectionStrings = connectionStrings.Value;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(_connectionStrings.SQL);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>().HasData(new Brand() { BrandId = Guid.NewGuid(), Name = "ASICS" });
            modelBuilder.Entity<Brand>().HasData(new Brand() { BrandId = Guid.NewGuid(), Name = "CONVERSE" });
            modelBuilder.Entity<Brand>().HasData(new Brand() { BrandId = Guid.NewGuid(), Name = "VANS" });
            modelBuilder.Entity<Brand>().HasData(new Brand() { BrandId = Guid.NewGuid(), Name = "NIKE" });

            modelBuilder.Entity<Occasion>().HasData(new Occasion() { OccasionId = Guid.NewGuid(), Name = "Sports" });
            modelBuilder.Entity<Occasion>().HasData(new Occasion() { OccasionId = Guid.NewGuid(), Name = "Casual" });
            modelBuilder.Entity<Occasion>().HasData(new Occasion() { OccasionId = Guid.NewGuid(), Name = "Skate" });
            modelBuilder.Entity<Occasion>().HasData(new Occasion() { OccasionId = Guid.NewGuid(), Name = "Diner" });
        }

    }
}
