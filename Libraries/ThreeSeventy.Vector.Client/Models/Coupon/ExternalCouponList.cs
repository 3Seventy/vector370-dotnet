using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSeventy.Vector.Client.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    [Serializable]
    public class ExternalCouponList : Base
    {

        /// <summary>
        /// 
        /// </summary>
        public ExternalCouponList()
        {
            CouponCodes = new List<string>();
        }

        /// <summary>
        /// The account ID that external coupon list belongs to
        /// </summary>
        [DataMember]
        public int AccountId { get; set; }

        /// <summary>
        /// Name of the external coupon list 
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Description for the external coupon list
        /// </summary>
        [DataMember]
        public string Description { get; set; }

        /// <summary>
        /// external coupon list can be shared with the child accounts or not
        /// </summary>
        [DataMember]
        public bool Inheritable { get; set; }

        /// <summary>
        /// Total number of codes available
        /// </summary>
        [DataMember]
        public int TotalCodesAvailable { get; set; }

        /// <summary>
        /// Blob URL pointing to the CSV file should have all coupon codes in one column with  "CouponCodes" as the column header (OPTIONAL)
        /// </summary>
        [DataMember]
        public string Url { get; set; }


        /// <summary>
        /// A list of coupon codes (OPTIONAL)
        /// </summary>
        [DataMember]
        public IList<string> CouponCodes { get; set; }
    }
}
