using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSeventy.Vector.Client.Models
{
    /// <summary>
    /// Coupon Offer Details
    /// </summary>
    [DataContract]
    [Serializable]
    public class CouponOffer : SoftDeletable
    {
        public CouponOffer()
        {
            UrlBase = "http://370.bz/";
        }

        /// <summary>
        /// The account this offer belongs to
        /// </summary>
        [DataMember]
        public int AccountId { get; set; }

        /// <summary>
        /// The campaign this offer is for
        /// </summary>
        [DataMember]
        public int CampaignId { get; set; }

        /// <summary>
        /// Regular offer (without coupon)
        /// </summary>
        /// <example>
        /// $10.00
        /// </example>
        [DataMember]
        public string RegularOffer { get; set; }

        /// <summary>
        /// Coupon offer (when coupon applied)
        /// </summary>
        /// <example>
        /// $0.00
        /// </example>
        [DataMember]
        public string NewOffer { get; set; }

        /// <summary>
        /// Offer image URL
        /// </summary>
        [DataMember]
        public string ImageURL { get; set; }

        /// <summary>
        /// Terms and conditions of this offer
        /// </summary>
        [DataMember]
        public string TermsAndConditions { get; set; }

        /// <summary>
        /// URL to use as base when sending to user
        /// </summary>
        /// <example>
        /// http://370.bz/
        /// </example>
        [DataMember]
        public string UrlBase { get; set; }
    }
}
