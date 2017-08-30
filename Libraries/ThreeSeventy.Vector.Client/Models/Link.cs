using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSeventy.Vector.Client.Models
{
    /// <summary>
    /// Describes a link that can be sent in a razor template.
    /// </summary>
    [DataContract]
    [Serializable]
    public class Link : BaseAudited
    {
        /// <summary>
        /// The account ID which owns the link
        /// </summary>
        [DataMember]
        public int AccountId { get; set; }

        /// <summary>
        /// The campaign this link is part of.
        /// </summary>
        [DataMember]
        public int? CampaignId { get; set; }

        /// <summary>
        /// The type of link this is.  Either Static or Dynamic
        /// </summary>
        [DataMember]
        public int LinkTypeId { get; set; }

        /// <summary>
        /// Set if we should request the user's location before redirecting.
        /// </summary>
        [DataMember]
        public bool RequestLocation { get; set; }

        /// <summary>
        /// The name of the link.
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// The short URL to use.
        /// </summary>
        [DataMember]
        public string ShortBaseURL { get; set; }

        /// <summary>
        /// The URL we should redirect to.
        /// </summary>
        [DataMember]
        public string RedirectURL { get; set; }

        /// <summary>
        /// The contact attribute ID to append to the URL if desired.
        /// </summary>
        [DataMember]
        public int? ContactAttributeDefinitionId { get; set; }


        /// <summary>
        /// The contact attribute ID to be updated.
        /// </summary>
        [DataMember]
        public int? UpdateContactAttributeDefinitionId { get; set; }

        /// <summary>
        /// The value to update the contact attribute to.
        /// </summary>
        [DataMember]
        public string UpdateContactAttributeValue { get; set; }

        /// <summary>
        /// Enumeration mapping to LinkTypeId
        /// </summary>
        [IgnoreDataMember]
        public LinkType LinkType
        {
            get { return (LinkType) LinkTypeId; }
            set { LinkTypeId = (int) value; }
        }
    }
}
