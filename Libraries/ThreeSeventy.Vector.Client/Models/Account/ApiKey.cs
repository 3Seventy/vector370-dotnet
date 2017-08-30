using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using ThreeSeventy.Vector.Client.Enums;

namespace ThreeSeventy.Vector.Client.Models
{
    /// <summary>
    /// A new Api Key
    /// </summary>
    [DataContract]
    [Serializable]
    public class ApiKey : Base
    {
        /// <summary>
        /// User defined identificator
        /// </summary>
        [DataMember]
        public string Label { get; set; }

        /// <summary>
        /// Api Key type: 1 for a Common key, 2 for a Temporary key
        /// </summary>
        [DataMember]
        public ApiKeyType Type { get; set; }

        /// <summary>
        /// A date and time this key will be valid to.
        /// Applicable for Temporary keys only.
        /// </summary>
        [DataMember]
        public DateTime? ValidTo { get; set; }


        /// <summary>
        /// Api Key (used as username for login)
        /// </summary>
        [DataMember]
        public string Key { get; set; }

        /// <summary>
        /// Type of a key
        /// </summary>
        [DataMember]
        public int TypeId { get; set; }

        /// <summary>
        /// A date and time this key was last used.
        /// </summary>
        [DataMember]
        public DateTime LastActivity { get; set; }

        /// <summary>
        /// An account id this key has direct access to.
        /// </summary>
        [DataMember]
        public int AccountId { get; set; }

        /// <summary>
        /// Username this key belongs to.
        /// Applicable to Master keys only.
        /// </summary>
        [DataMember]
        public string UserName { get; set; }
    }
}
