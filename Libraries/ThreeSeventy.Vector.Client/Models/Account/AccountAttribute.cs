using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSeventy.Vector.Client.Models
{
    /// <summary>
    /// USsed to work with the Account Attributes
    /// </summary>
    [Serializable]
    [DataContract]
    public class AccountAttribute : Base
    {
        /// <summary>
        /// Account Id
        /// </summary>
        [DataMember]
        public int AccountId { get; set; }

        /// <summary>
        /// Account Attribute Name
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// AccountAttribute Value
        /// </summary>
        [DataMember]
        public string Value { get; set; }
    }

}
