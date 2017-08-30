using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSeventy.Vector.Client.Models
{
    /// <summary>
    /// Used to Bridge two calls
    /// </summary>
    [DataContract]
    [Serializable]
    public class BridgeCall
    {
        /// <summary>
        /// First phone number in the bridge
        /// </summary>
        [DataMember]
        public string PhoneNumber1 { get; set; }

        /// <summary>
        /// Second phone number in the bridge
        /// </summary>
        [DataMember]
        public string PhoneNumber2 { get; set; }
    }
}
