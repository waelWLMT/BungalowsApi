using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos
{
    public class UserCreateDto
    {

        #region properties

        public string Nom { get; set; }
        public string Prenom { get; set; }

        public string Password { get; set; }
       
        public string Login { get; set; }
       
        public string Email { get; set; }

        public int RoleId { get; set; }


        #endregion

    }
}
