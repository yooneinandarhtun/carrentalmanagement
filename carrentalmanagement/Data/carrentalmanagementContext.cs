using carrentalmanagement.Configurations.Entities;
using carrentalmanagement.Data;
using CarRentalManagement.Configurations.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace carrentalmanagement.Data
{
    public class carrentalmanagementContext(DbContextOptions<carrentalmanagementContext> options) : IdentityDbContext<carrentalmanagementUser>(options)
    {

        public DbSet<carrentalmanagement.Domain.Make> Make { get; set; } = default!;
        public DbSet<carrentalmanagement.Domain.Model> Model { get; set; } = default!;
        public DbSet<carrentalmanagement.Domain.Color> Color { get; set; } = default!;
        public DbSet<carrentalmanagement.Domain.Customers> Customers { get; set; } = default!;
        public DbSet<carrentalmanagement.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<carrentalmanagement.Domain.Vehicle> Vehicle { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ColourSeed());
            builder.ApplyConfiguration(new MakeSeed());
            builder.ApplyConfiguration(new ModelSeed());
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
        }
    }
}
