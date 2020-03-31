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
        public DbSet<System> Systems { get; set; }
        public DbSet<SystemToPart> SystemToParts { get; set; }
        
    }
}
