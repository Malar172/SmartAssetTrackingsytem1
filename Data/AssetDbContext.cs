using Microsoft.EntityFrameworkCore;
using SmartAssetTrackingSystem.Models;

namespace SmartAssetTrackingSystem.Data
{
    public class AssetDbContext : DbContext
    {
        public DbSet<Asset> Assets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=localhost\SQLEXPRESS;
                  Database=AssetTrackingDB;
                  Trusted_Connection=True;
                  TrustServerCertificate=True");
        }
    }
}