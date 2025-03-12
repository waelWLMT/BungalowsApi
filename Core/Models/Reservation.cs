using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Reservation
    {
        public DateTime DateEntree { get; set; }
        public DateTime DateSortie { get; set; }
        public TimeSpan HeureEntree { get; set; }
        public TimeSpan HeureSortie { get; set; }

        
        public int UserId { get; set; }
        public User User { get; set; }        
        public int BungalowId { get; set; }        
        public int LocataireId { get; set; }
        public Bungalow Bungalow { get; set; }
        public Locataire Locataire { get; set; }

    }
}
