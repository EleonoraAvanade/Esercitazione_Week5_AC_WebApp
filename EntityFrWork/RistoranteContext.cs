using Core.Models;
using EntityFrWork.Configuration;
using Microsoft.EntityFrameworkCore;
using System;

namespace EntityFrWork
{
    public class RistoranteContext:DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Piatto> Piatti { get; set; }
        public RistoranteContext(DbContextOptions<RistoranteContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=RistoranteDb;Persist Security Info=False;Integrated Security=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Piatto>(new PiattoConfiguration());
            modelBuilder.ApplyConfiguration<Account>(new AccountConfiguration());
        }
    }
}
