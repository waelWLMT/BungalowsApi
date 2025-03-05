using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    /// <summary>
    /// The appointement.
    /// </summary>
    public class Appointement : Entity
    {

        #region properties
        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Gets or sets the heure debut.
        /// </summary>
        public TimeSpan HeureDebut { get; set; }
        /// <summary>
        /// Gets or sets the heure fin.
        /// </summary>
        public TimeSpan HeureFin { get; set; }
        #endregion

        #region navigation properties
        /// <summary>
        /// Gets or sets the motif id.
        /// </summary>
        [ForeignKey(nameof(Motif))]
        public int MotifId { get; set; }
        /// <summary>
        /// Gets or sets the patient id.
        /// </summary>
        [ForeignKey(nameof(Patient))]
        public int PatientId { get; set; }
        /// <summary>
        /// Gets or sets the praticien id.
        /// </summary>
        [ForeignKey(nameof(Praticien))]
        public int PraticienId { get; set; }
        /// <summary>
        /// Gets or sets the motif.
        /// </summary>
        public virtual Motif Motif { get; set; }
        /// <summary>
        /// Gets or sets the patient.
        /// </summary>
        public virtual Patient Patient { get; set; }
        /// <summary>
        /// Gets or sets the praticien.
        /// </summary>
        public virtual Praticien Praticien { get; set; }
        #endregion

    }



}
