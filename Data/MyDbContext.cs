using Core.Models;
using Data.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    /// <summary>
    /// The my db context.
    /// </summary>
    public class MyDbContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Locataire> Locataires { get; set; }
        public DbSet<Proprietaire> Proprietaires { get; set; }
        public DbSet<Commercial> Commercials { get; set; }
        public DbSet<Bungalow> Bungalows { get; set; }
        public DbSet<Adresse> Adresses { get; set; }
        public DbSet<Role> Roles { get; set; }



        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        { }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new ReservationConfiguration());
                    
        }
                   

    }
}
