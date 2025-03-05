using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    /// <summary>
    /// The motif.
    /// </summary>
    public class Motif : Entity
    {

        #region properties
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
        /// Gets or sets the specialite id.
        /// </summary>
        public int SpecialiteId { get; set; }
        /// <summary>
        /// Gets or sets the specialite.
        /// </summary>
        public Specialite Specialite { get; set; }

        /// <summary>
        /// Gets or sets the appointements.
        /// </summary>
        public virtual List<Appointement> Appointements { get; set; }
        #endregion

    }
}
