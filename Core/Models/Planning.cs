using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    /// <summary>
    /// The planning.
    /// </summary>
    public class Planning : Entity
    {

        #region properties
        /// <summary>
        /// Gets or sets the date debut planning.
        /// </summary>
        public DateTime DateDebutPlanning { get; set; }
        /// <summary>
        /// Gets or sets the date fin planning.
        /// </summary>
        public DateTime DateFinPlanning { get; set; }
        /// <summary>
        /// Gets or sets the heure debut.
        /// </summary>
        public TimeSpan HeureDebut { get; set; }
        /// <summary>
        /// Gets or sets the heure fin.
        /// </summary>
        public TimeSpan HeureFin { get; set; }
        /// <summary>
        /// Gets or sets the heure repos.
        /// </summary>
        public TimeSpan HeureRepos { get; set; }
        /// <summary>
        /// Gets or sets the duree repos.
        /// </summary>
        public TimeSpan DureeRepos { get; set; }
        /// <summary>
        /// Gets or sets the est actif.
        /// </summary>
        public Boolean EstActif { get; set; }
        #endregion

        #region navigation properties
        /// <summary>
        /// Gets or sets the praticien id.
        /// </summary>
        public int PraticienId { get; set; }
        /// <summary>
        /// Gets or sets the praticien.
        /// </summary>
        public virtual Praticien Praticien { get; set; }
        #endregion

    }
}
