using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
    public class AppointementConfiguration : IEntityTypeConfiguration<Appointement>
    {
        public void Configure(EntityTypeBuilder<Appointement> builder)
        {

            builder.HasOne(x=> x.Patient)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Motif)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Praticien)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

        }

    }
}
