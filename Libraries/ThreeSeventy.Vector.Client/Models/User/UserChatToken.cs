using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSeventy.Vector.Client.Models
{
    /// <summary>
    /// Return value for a user chat token request.
    /// </summary>
    [DataContract]
    [Serializable]
    public class UserChatToken
    {
        /// <summary>
        /// Account Id
        /// </summary>
        public int AccountId { get; set; }
        // PRIVATE NOTE: The Token is returned as a Base64 encoded GUID

        /// <summary>
        /// The login token.
        /// </summary>
        [DataMember]
        public string Token { get; set; }

        /// <summary>
        /// The user name this token is for (for reference)
        /// </summary>
        [DataMember]
        public string UserName { get; set; }

        /// <summary>
        /// When this token will no longer be valid.  Time is in UTC.
        /// </summary>
        [DataMember]
        public DateTime ExpirationDate { get; set; }
    }
}
