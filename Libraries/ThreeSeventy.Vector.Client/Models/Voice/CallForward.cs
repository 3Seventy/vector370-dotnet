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
    /// Lets you add callforwarding number on a long code
    /// </summary>
    [DataContract]
    [Serializable]
    public class CallForward : LongCode
    {
        /// <summary>
        /// Request to change the call forward number
        /// </summary>
        [DataMember]
        [JsonProperty("ForwardingNumber")]
        public string RequestCallForwardNumber { get; set; }
    }
}
