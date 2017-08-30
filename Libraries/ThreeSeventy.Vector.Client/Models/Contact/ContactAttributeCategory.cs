using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSeventy.Vector.Client.Models
{
    /// <summary>
    /// Account Attrribute Category Details
    /// </summary>
    [Serializable]
    [DataContract]
    public class ContactAttributeCategory : Base
    {
        /// <summary>
        /// Account Attribute Category Name
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Account Attribute Category Description
        /// </summary>
        [DataMember]
        public string Description { get; set; }
    }
}