using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ThreeSeventy.Vector.Client.Models
{
    /// <summary>
    /// USed to request a LongCode
    /// </summary>
    [DataContract]
    [Serializable]
    public  class RequestTn
    {
        /// <summary>
        /// Account Id
        /// </summary>
        public int AccountId { get; set; }
        /// <summary>
        /// The ID of the order.
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// The number of phone numbers requested.
        /// </summary>
        [DataMember]
        public int Quantity { get; set; }

        /// <summary>
        /// The search pattern used for provisioning this order.
        /// </summary>
        [DataMember]
        public string Pattern { get; set; }

        /// <summary>
        /// The type of order that is being provisioned.
        /// </summary>
        [DataMember]
        [JsonConverter(typeof(StringEnumConverter))]
        public OrderBy OrderBy { get; set; }

        /// <summary>
        /// The current status of the order
        /// </summary>
        [DataMember]
        [JsonConverter(typeof(StringEnumConverter))]
        public OrderStatus OrderStatus { get; set; }

        /// <summary>
        /// List of phone numbers that have been provisioned so far.
        /// </summary>
        [DataMember]
        public IEnumerable<string> PhoneNumbers { get; set; }
    }
}
