using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    /// <summary>
    /// The admin.
    /// </summary>
    public class Admin : Entity
    {
        #region properties
        /// <summary>
        /// Gets or sets the nom.
        /// </summary>
        public string Nom { get; set; }
        /// <summary>
        /// Gets or sets the prenom.
        /// </summary>
        public string Prenom { get; set; }
        #endregion

        #region mapping properties

        /// <summary>
        /// Gets or sets the user account id.
        /// </summary>
        [ForeignKey(nameof(UserAccount))]
        public int UserAccountId { get; set; }
        /// <summary>
        /// Gets or sets the user account.
        /// </summary>
        public virtual User UserAccount{ get; set; }

        #endregion
    }
}
