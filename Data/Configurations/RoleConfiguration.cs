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
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData(
                new Role() { Id = 1, Libelle = "Admin", Code= "Admin", Description = "Administrateur responsable sur la gestion des bungalows ainsi que les utilisateurs" },
                new Role() { Id = 2, Libelle = "Commercial", Code="Commercial", Description = "Le responsable de la location des bungalow" },
                new Role() { Id = 3, Libelle = "Locataire",Code="Locataire", Description = "Le Locataire des bungalows" },
                new Role() { Id = 4, Libelle = "Proprietaire",Code="Proprietaire", Description = "Le proprietaire des bungalows" },
                new Role() { Id = 5, Libelle = "User", Code = "User", Description = "Utilisateur de l'application" }
                );                    
        }

    }
}
