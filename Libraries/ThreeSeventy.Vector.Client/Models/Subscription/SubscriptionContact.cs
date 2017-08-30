using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSeventy.Vector.Client.Models
{
    /// <summary>
    /// Contact Subscription Details
    /// </summary>
    [DataContract]
    [Serializable]
    public class SubscriptionContact : Base
    {
 
        /// <summary>
        /// Account Id
        /// </summary>
        public int AccountId { get; set; }
        /// <summary>
        /// Contact Information.
        /// </summary>
        [DataMember]
        public Contact Contact { get; set; }

        /// <summary>
        /// Contact Id
        /// </summary>
        [DataMember]
        public int ContactId { set; get; }

        /// <summary>
        /// Email Enabled Details
        /// </summary>
        [DataMember]
        public bool EmailEnabled { set; get; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public bool MmsEnabled { set; get; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public bool SmsEnabled { set; get; }

        /// <summary>
        /// 	Subscription Details
        /// </summary>
        [DataMember]
        public Subscription Subscription { set; get; }

        /// <summary>
        /// Subscription Id
        /// </summary>
        [DataMember]
        public int SubscriptionId { set; get; }

        /// <summary>
        /// Voice Enabled Details
        /// </summary>
        [DataMember]
        public bool VoiceEnabled { set; get; }
    }
}
