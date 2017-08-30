using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSeventy.Vector.Client.Models
{
    /// <summary>
    /// Used to Attach and Dettach a Keyword to a Campaign
    /// </summary>
    [Serializable]
    [DataContract]
    public class ActionAttachKeyword : BaseAudited
    {
        /// <summary>
        /// Account Id
        /// </summary>
        [DataMember]
        public int AccountId { get; set; }

        /// <summary>
        /// Channel Id on which the keyword is 
        /// </summary>
        [DataMember]
        public int ChannelId { get; set; }

        /// <summary>
        /// Keyword Id 
        /// </summary>
        [DataMember]
        public int KeywordId { get; set; }

        /// <summary>
        /// Campaign Id to which the keyword is attached
        /// </summary>
        [DataMember]
        public int CampaignId { get; set; }
    }
}
