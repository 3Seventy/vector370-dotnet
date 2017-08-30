using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSeventy.Vector.Client.Models
{
    /// <summary>
    /// Coupon Code assosiated with the External Coupon List
    /// </summary>
    [DataContract]
    [Serializable]
    public class CouponExternalCode : Base
    {
        /// <summary/>
        public CouponExternalCode()
        {
            Created = DateTime.UtcNow;
        }

        /// <summary>
        /// Account Id
        /// </summary>
        public int AccountId { get; set; }

        /// <summary>
        /// External Coupon list Id associated with this Coupon Code 
        ///</summary>
        [DataMember]
        public int ListId { get; set; }

        /// <summary>
        /// The Customer who received the external coupon code
        /// </summary>
         [DataMember]
        public int? ContactId { get; set; }

        /// <summary>
        /// The external coupon code
        /// </summary>
       [DataMember]
        public string CouponCode { get; set; }

        /// <summary>
        /// reservation token Identifier for this coupon code 
        /// </summary>
        [DataMember]
        public Guid? ReservationToken { get; set; }

        /// <summary>
        /// The date when the external coupon code is created
        /// </summary>
        [DataMember]
        public DateTime Created { get; set; }
    }
}
