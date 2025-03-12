using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {

            builder.HasDiscriminator<int>("RoleId")
                .HasValue<Admin>(1)
                .HasValue<Commercial>(2)
                .HasValue<Locataire>(3)
                .HasValue<Proprietaire>(4)
                .HasValue<User>(5);

            builder.HasOne(x => x.Role)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
