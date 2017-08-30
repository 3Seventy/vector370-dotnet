using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSeventy.Vector.Client.Models
{
    /// <summary>
    /// Used for updating a user's password.
    /// </summary>
    [DataContract]
    [Serializable]
    public class UserPassword
    {
        /// <summary>
        /// Account Id
        /// </summary>
        [DataMember]
        public int AccountId { get; set; }
        /// <summary>
        /// User name.
        /// </summary>
        [DataMember]
        public string UserName { get; set; }

        /// <summary>
        /// The new login password for the user.
        /// </summary>
        [DataMember]
        public string NewPassword { get; set; }

        /// <summary>
        /// Confirmation password.  Must match NewPassword.
        /// </summary>
        [DataMember]
        public string ConfirmPassword { get; set; }

    }
}
