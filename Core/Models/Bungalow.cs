using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Bungalow : Entity
    {
        public double Prix { get; set; }

        [ForeignKey(nameof(Adresse))]
        public int AdresseId { get; set; }
        public Adresse Adresse { get; set; }
        public Proprietaire Proprietaire { get; set; }
        public List<Reservation> Reservations { get; set; }
    }
}
