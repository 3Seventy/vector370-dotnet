using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSeventy.Vector.Client.Models
{
    /// <summary>
    /// Provides details of a contact on a keyword
    /// </summary>
    [DataContract]
    [Serializable]
    public class KeywordContact
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int AccountId { set; get; }

        /// <summary>
        /// The keyword to which the contact opted in with.
        /// </summary>
        [DataMember]
        public int KeywordId { get; set; }

        /// <summary>
        /// Email Address
        /// </summary>
        [DataMember]
        public string Email { set; get; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int PhoneHardErrorCount { set; get; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public DateTime? PhoneHardErrorSince { set; get; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string PhoneLastHardError { set; get; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string PhoneLastSoftError { set; get; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string PhoneNumber { set; get; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int PhoneSoftErrorCount { set; get; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public DateTime? PhoneSoftErrorSince { set; get; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int PhoneStatusId { set; get; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int PhoneTotalHardErrorCount { set; get; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int PhoneTotalSoftErrorCount { set; get; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int? PreferredLanguageId { set; get; }
    }
}
