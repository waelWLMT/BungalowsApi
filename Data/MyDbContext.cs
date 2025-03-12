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
            //modelBuilder.ApplyConfiguration(new AppointementConfiguration());        
        }
                   

    }
}
