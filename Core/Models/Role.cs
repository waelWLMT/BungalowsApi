using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    /// <summary>
    /// The role.
    /// </summary>
    public class Role : Entity
    {
        #region properties
        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// Gets or sets the libelle.
        /// </summary>
        public string Libelle { get; set; }
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }
        #endregion


        #region navigation properties
        /// <summary>
        /// Gets or sets the user accounts.
        /// </summary>
        public virtual List<User> UserAccounts { get; set; }
        #endregion

    }
}
