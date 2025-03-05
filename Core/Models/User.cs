using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    /// <summary>
    /// The user account.
    /// </summary>
    public class User : Entity
    {
        #region properties
        /// <summary>
        /// Gets or sets the user name.
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// Gets or sets the crypted password.
        /// </summary>
        public string CryptedPassword { get; set; }
        /// <summary>
        /// Gets or sets the login.
        /// </summary>
        public string  Login { get; set; }
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        public string Email { get; set; }
        #endregion

        #region navigation properties

        /// <summary>
        /// Gets or sets the role id.
        /// </summary>
        [ForeignKey(nameof(Role))]
        public int RoleId { get; set; }

        /// <summary>
        /// Gets or sets the role.
        /// </summary>
        public virtual Role Role { get; set; }

        #endregion

    }
}
