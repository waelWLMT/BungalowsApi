using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Adresse : Entity
    {
        public string Rue { get; set; }
        public string Boulevard { get; set; }
        public string Ville { get; set; }
        public string CodePosatl { get; set; }
        public string Altitude  { get; set; }
        public string Longitude { get; set; }
    }
}
