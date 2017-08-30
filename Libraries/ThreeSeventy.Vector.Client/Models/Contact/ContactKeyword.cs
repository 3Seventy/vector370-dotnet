using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSeventy.Vector.Client.Models
{
    /// <summary>
    /// Gives you keyword details of a contact
    /// </summary>
    [DataContract]
    [Serializable]
    public class ContactKeyword : BaseAudited
    {

        /// <summary>
        /// AccountId
        /// </summary>
        public int AccountId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int CampaignAccountId { set; get; }

        /// <summary>
        /// 
        /// </summary>
         [DataMember]
        public int CampaignId { set; get; }

        /// <summary>
        /// 
        /// </summary>
         [DataMember]
        public int ContactAccountId { set; get; }

        /// <summary>
        /// 
        /// </summary>
         [DataMember]
        public int ContactId { set; get; }

        /// <summary>
        /// 
        /// </summary>
         [DataMember]
        public int KeywordAccountId { set; get; }

        /// <summary>
        /// 
        /// </summary>
         [DataMember]
        public int KeywordId { set; get; }

        /// <summary>
        /// 
        /// </summary>
         [DataMember]
        public int SubscriptionAccountId { set; get; }

        /// <summary>
        /// 
        /// </summary>
         [DataMember]
        public int SubscriptionId { set; get; }
    }
}
