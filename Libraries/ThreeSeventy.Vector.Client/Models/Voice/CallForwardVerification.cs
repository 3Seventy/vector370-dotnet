using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ThreeSeventy.Vector.Client.Models
{

    [DataContract]
    [Serializable]
    public class CallForwardVerification :LongCode
    {
        /// <summary>
        /// Request verification code
        /// </summary>
        [DataMember]
        [JsonProperty("VerificationCode")]
        public string RequestVerificationCode { get; set; }
    }
}
