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
    public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.HasKey(x => new { x.BungalowId, x.LocataireId, x.DateEntree, x.DateSortie });


            builder.HasOne<Bungalow>(x => x.Bungalow)
                .WithMany(y=> y.Reservations)
                .HasForeignKey(x => x.BungalowId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<Locataire>(x => x.Locataire)
                .WithMany(y=> y.Reservations)
                .HasForeignKey(x => x.LocataireId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<User>(x => x.User)
                .WithMany()                
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
