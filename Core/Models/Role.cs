using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Role : Entity
    {
        #region Properties
        public string Libelle { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        #endregion 
    }
}
