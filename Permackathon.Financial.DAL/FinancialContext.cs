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
                //optionsBuilder.UseSqlServer(@"Data Source=HACKATHON-SRV1\HACKATHON;Initial Catalog=Wapiti;User ID=WapitiUser;Password=WapitiUser;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                optionsBuilder.UseSqlite(@"Data Source=Financial.db;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<EffectiveEF> Effectives { get; set; }
        public DbSet<PredictionEF> Predictions { get; set; }

    }
}
