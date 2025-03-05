using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    /// <summary>
    /// The patient.
    /// </summary>
    public class Patient : Entity
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
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        public string Email { get; set; }
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
        public virtual User UserAccount { get; set; }

        /// <summary>
        /// Gets or sets the appointements.
        /// </summary>
        public virtual List<Appointement> Appointements { get; set; }
        #endregion
    }
}
