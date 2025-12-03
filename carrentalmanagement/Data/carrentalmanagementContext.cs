using carrentalmanagement.Configurations.Entities;
using carrentalmanagement.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace carrentalmanagement.Data
{
    public class carrentalmanagementContext : DbContext
    {
        public carrentalmanagementContext (DbContextOptions<carrentalmanagementContext> options)
            : base(options)
        {
        }

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
        }
    }
}
