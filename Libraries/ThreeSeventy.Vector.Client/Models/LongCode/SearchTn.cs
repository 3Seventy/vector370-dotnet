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
    /// Details of a TN search
    /// </summary>
    /// 
    [DataContract]
    [Serializable]
    public class SearchTn : Base
    {
        private IList<string> m_phoneNumbers = new List<string>();

        /// <summary>
        /// Account Id
        /// </summary>
        public int AccountId { get; set; }

        /// <summary>
        /// The number of phone numbers requested.
        /// </summary>
        /// <remarks>
        /// Renamed from "Quantity" to avoid confusion with the actually found number of phone numbers.
        /// </remarks>
        [DataMember]
        public int RequestedQuantity { get; set; }

        /// <summary>
        /// The search pattern that was used.
        /// </summary>
        [DataMember]
        public string Pattern { get; set; }

        /// <summary>
        /// The type of search that was performed.
        /// </summary>
        [DataMember]
        [JsonConverter(typeof (StringEnumConverter))]
        public SearchBy SearchBy { get; set; }

        /// <summary>
        /// When the search was preformed.
        /// </summary>
        [DataMember]
        public DateTime Created { get; set; }

        /// <summary>
        /// When we will no longer allow using this search item for orders.
        /// </summary>
        [DataMember]
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// List of phone numbers that were found.
        /// </summary>
        [DataMember]
        public IList<string> PhoneNumbers
        {
            get { return m_phoneNumbers; }
            set { m_phoneNumbers = value ?? new List<string>(); }
        }
    }
}
