using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
   
    public class User : Entity
    {
        #region Properties

        public string Nom { get; set; }
        public string Prenom { get; set; }        
        public string CryptedPassword { get; set; }       
        public string  Login { get; set; }       
        public string Email { get; set; }
        public bool Active { get; set; }

        [ForeignKey(nameof(Role))]
        public int RoleId { get; set; }
        #endregion

        #region Navigation properties        
        public Role Role { get; set; }

        #endregion

    }
}
