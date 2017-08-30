using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSeventy.Vector.Client.Models
{
    /// <summary>
    /// Used to make a conference Call
    /// </summary>
    [DataContract]
    [Serializable]
    public class ConferenceCall
    {
        /// <summary>
        /// Phone Number to Join an existing conference else create a new conference
        /// </summary>
        [DataMember]
        public string ToPhoneNumber { get; set; }
    }
}
