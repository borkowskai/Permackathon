using Microsoft.EntityFrameworkCore;
using Permackathon.Financial.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permackathon.Financial.DAL
{
    public class FinancialContext : DbContext
    {
        public FinancialContext() { }
        public FinancialContext(DbContextOptions<FinancialContext> options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder is null)
                throw new ArgumentNullException(nameof(optionsBuilder));

            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder./*UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=FacilityDB;Trusted_Connection=True;")*/;
                optionsBuilder.EnableSensitiveDataLogging();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<EffectiveEF> Effectives { get; set; }
        public DbSet<PredictionEF> Predictions { get; set; }

    }
}
