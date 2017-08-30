using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ThreeSeventy.Vector.Client.Enums;

namespace ThreeSeventy.Vector.Client.Models
{
    /// <summary>
    /// Longcode details
    /// </summary>
    [DataContract]
    [Serializable]
    public class LongCode : SoftDeletable
    {
        /// <summary>
        /// Account Id
        /// </summary>
        [DataMember]
        public int AccountId { get; set; }


        /// <summary>
        /// Channel ID
        /// </summary>
        [DataMember]
        public int ChannelId { get; set; }

        /// <summary>
        /// Long Code
        /// </summary>
        [DataMember]
        public string Code { get; set; }

        /// <summary>
        /// Call Forward Number
        /// </summary>
        [DataMember]
        public string ForwardNumber { get; set; }

        /// <summary>
        /// Call Forward Status
        /// </summary>
        [DataMember]
        public int? ForwardStatus { get; set; }

        /// <summary>
        /// Call Forward Status 
        /// </summary>
        public CallForwardStatus? CallForwardStatus
        {
            get { return (CallForwardStatus?) ForwardStatus; }
            set { ForwardStatus = (int?) value; }
        }

        /// <summary>
        /// Verification Code
        /// </summary>
        [DataMember]
        public string ForwardVerificationCode { get; set; }

    }
}
