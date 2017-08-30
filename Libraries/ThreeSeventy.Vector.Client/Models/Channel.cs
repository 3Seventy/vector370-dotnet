using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSeventy.Vector.Client.Models
{
    /// <summary>
    /// Channel deatils
    /// </summary>
    [DataContract]
    [Serializable]
    public class Channel : Base
    {

        /// <summary>
        /// Account Id
        /// </summary>
        public int AccountId { get; set; }
        /// <summary />
        [DataMember]
        public int Type { get; set; }

        /// <summary />
        [DataMember]
        public string Name { get; set; }

        /// <summary />
        [DataMember]
        public string Label { get; set; }

        /// <summary />
        [DataMember]
        public string Description { get; set; }

        /// <summary>
        /// The default language type for a channel.
        /// </summary>
        [DataMember]
        public int DefaultLanguageId { get; set; }

        /// <summary>
        /// Set if the channel is currently active and running.
        /// </summary>
        [DataMember]
        public bool IsActive { get; set; }

        /// <summary>
        /// Set if the channel supports MMS.
        /// </summary>
        [DataMember]
        public bool IsMediaEnabled { get; set; }

        /// <summary>
        /// Gets or sets the language override group for the channel
        /// </summary>
        [DataMember]
        public int OverrideGroup { get; set; }

        /// <summary>
        /// Thread sleep timeout in milliseconds
        /// </summary>
        [DataMember]
        public int ThreadSleep { get; set; }

        /// <summary>
        /// Set if we can send handset verifications on.
        /// </summary>
        [DataMember]
        public bool AllowVerify { get; set; }

        /// <summary>
        /// Set if this channel uses long codes or not.
        /// </summary>
        /// <remarks>
        /// Used to find out if we should pull a list of long codes when we push to the channel ID or name instead of
        /// a specific long code.
        /// </remarks>
        [DataMember]
        public bool UseLongCodes { get; set; }

        /// <summary>
        /// The default language type for a channel.
        /// </summary>
        [IgnoreDataMember]
        public LanguageType DefaultLanguage
        {
            get { return (LanguageType) DefaultLanguageId; }
            set { DefaultLanguageId = (int) value; }
        }

        /// <summary>
        /// Enumeration mapping for ChannelTypeId
        /// </summary>

        [IgnoreDataMember]
        public ChannelType ChannelType
        {
            get { return (ChannelType) Type; }
            set { Type = (int) value; }
        }
    }
}
