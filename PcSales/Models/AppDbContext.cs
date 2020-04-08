using System;
using Microsoft.EntityFrameworkCore;

namespace PcSales.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<CaseSpec> CaseSpecs { get; set; }
        public DbSet<CpuSpec> CpuSpecs { get; set; }
        public DbSet<GpuSpec> GpuSpecs { get; set; }
        public DbSet<MoboSpec> MoboSpecs { get; set; }
        public DbSet<PsuSpec> PsuSpecs { get; set; }
        public DbSet<RamSpec> RamSpecs { get; set; }
        public DbSet<StorageSpec> StorageSpecs { get; set; }
        public DbSet<SystemForSale> SystemsForSale { get; set; }
        public DbSet<SystemToPart> SystemToParts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CaseSpec>(entity =>
            {
                entity.HasKey(e => e.PartNum).HasName("PartNum");
            });

            modelBuilder.Entity<CpuSpec>(entity =>
            { 
                entity.HasKey(e => e.PartNum).HasName("PartNum");
            });

            modelBuilder.Entity<GpuSpec>(entity =>
            {
                entity.HasKey(e => e.PartNum).HasName("PartNum");
            });

            modelBuilder.Entity<MoboSpec>(entity =>
            {
                entity.HasKey(e => e.PartNum).HasName("PartNum");
            });

            modelBuilder.Entity<PsuSpec>(entity =>
            {
                entity.HasKey(e => e.PartNum).HasName("PartNum");
            });

            modelBuilder.Entity<RamSpec>(entity =>
            {
                entity.HasKey(e => e.PartNum).HasName("PartNum");
            });

            modelBuilder.Entity<StorageSpec>(entity =>
            {
                entity.HasKey(e => e.PartNum).HasName("PartNum");
            });

            modelBuilder.Entity<SystemForSale>(entity =>
            {
                entity.HasKey(e => e.SystemId).HasName("SystemId");
            });

            modelBuilder.Entity<SystemToPart>(entity =>
            {
                entity.HasKey(e => e.PartId).HasName("PartId");
            });


        }
        
    }
}
