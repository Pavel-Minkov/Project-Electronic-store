using ElectronicStore.Data.Models;
using ElectronicStore.Data.Models.Products;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ElectronicStore.Data
{
    public class ElectronicStoreContext : IdentityDbContext<ElectronicStoreUser>
    {
        public ElectronicStoreContext(DbContextOptions<ElectronicStoreContext> options)
            : base(options)
        {
        }

        public DbSet<AirConditioner> AirConditioners { get; set; }
        public DbSet<Fridge> Fridges { get; set; }
        public DbSet<PhotoCamera> PhotoCameras { get; set; }
        public DbSet<Smartphone> Smartphones { get; set; }
        public DbSet<TV> TVs { get; set; }
        public DbSet<WashingMachine> WashingMachines { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
