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
        /// <summary>
        /// Gets or sets the user accounts.
        /// </summary>
        public DbSet<User> UserAccounts { get; set; }
        /// <summary>
        /// Gets or sets the admins.
        /// </summary>
        public DbSet<Admin> Admins { get; set; }
        /// <summary>
        /// Gets or sets the motifs.
        /// </summary>
        public DbSet<Motif> Motifs { get; set; }
        /// <summary>
        /// Gets or sets the patients.
        /// </summary>
        public DbSet<Patient> Patients { get; set; }
        /// <summary>
        /// Gets or sets the praticiens.
        /// </summary>
        public DbSet<Praticien> Praticiens { get; set; }
        /// <summary>
        /// Gets or sets the specialites.
        /// </summary>
        public DbSet<Specialite> Specialites { get; set; }
        /// <summary>
        /// Gets or sets the appointements.
        /// </summary>
        public DbSet<Appointement> Appointements { get; set; }
        /// <summary>
        /// Gets or sets the plannings.
        /// </summary>
        public DbSet<Planning> Plannings { get; set; }
        /// <summary>
        /// Gets or sets the roles.
        /// </summary>
        public DbSet<Role> Roles { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MyDbContext"/> class.
        /// </summary>
        /// <param name="options">The options.</param>
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        { }
        /// <summary>
        /// On model creating.
        /// </summary>
        /// <param name="modelBuilder">The model builder.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            modelBuilder.ApplyConfiguration(new AppointementConfiguration());        
        }
                   

    }
}
