using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ThreeSeventy.Vector.Client.Models
{
    /// <summary>
    /// Account Attrribute Definition Details
    /// </summary>
    [Serializable]
    [DataContract]
    public class AccountAttributeDefinition : Base
    {
        /// <summary>
        /// Account Id
        /// </summary>
        [DataMember]
        public int AccountId { get; set; }

        /// <summary>
        /// Account Attribute Category Id
        /// </summary>
        [DataMember]
        public int CategoryId { get; set; }

        /// <summary>
        /// Attribute DataTypeId
        /// </summary>
        [DataMember]
        public DataType DataType { get; set; }

        /// <summary>
        /// Name of the Account Attribute
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Account Attribute Description
        /// </summary>
        [DataMember]
        public string Description { get; set; }

        /// <summary>
        /// Account Attribute is inheritable to the child accounts or not
        /// </summary>
        [DataMember]
        public bool Inheritable { get; set; }
    }


}
