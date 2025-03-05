using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    /// <summary>
    /// The praticien.
    /// </summary>
    public class Praticien : Entity
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

        /// <summary>
        /// Gets or sets the user account id.
        /// </summary>
        [ForeignKey(nameof(UserAccount))]
        public int UserAccountId { get; set; }

        /// <summary>
        /// Gets or sets the specialite id.
        /// </summary>
        [ForeignKey(nameof(Specialite))]
        public int SpecialiteId { get; set; }

        #endregion

        #region mapping properties
        /// <summary>
        /// Gets or sets the user account.
        /// </summary>
        public virtual User UserAccount { get; set; }
        /// <summary>
        /// Gets or sets the specialite.
        /// </summary>
        public virtual Specialite Specialite { get; set; }
        /// <summary>
        /// Gets or sets the plannings.
        /// </summary>
        public virtual List<Planning> Plannings { get; set; }

        /// <summary>
        /// Gets or sets the appointements.
        /// </summary>
        public virtual List<Appointement> Appointements { get; set; }

        #endregion
    }
}
