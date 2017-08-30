using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSeventy.Vector.Client.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    [Serializable]
    public class ContactAttributeDefinition : BaseAudited
    {

        /// <summary>
        /// The Account ID that owns this attribute.
        /// </summary>
        [DataMember]
        public int AccountId { get; set; }

        /// <summary>
        /// The ID of the data type for this attribute.
        /// </summary>
        [DataMember]
        public int DataTypeId { get; set; }

        /// <summary>
        /// The Id of category
        /// </summary>
        [DataMember]
        public int CategoryId { get; set; }

        /// <summary>
        /// Name of the attribute definition.
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// A full description of this attribute.
        /// </summary>
        [DataMember]
        public string Description { get; set; }

    }
}
