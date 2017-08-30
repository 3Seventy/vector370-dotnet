using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ThreeSeventy.Vector.Client.Models
{
    /// <summary>
    /// Used for sending a campaign to a list of contacts.
    /// </summary>
    /// <remarks>
    /// Note that the list of contacts can be specified in a variety of ways:
    /// * Targets: This is a list of phone numbers and/or email addresses.
    /// * Contacts: This is a list of contact ids.
    /// * ContactListId: This is the ID of a contact list which runs on the TrueDialog servers.
    /// 
    /// All three types can be specified and the lists will be merged with duplicate contacts removed.
    /// </remarks>
    [Serializable]
    [DataContract]
    public class ActionPushCampaign : BaseAudited
    {
        #region Private Members

        /// <summary>
        /// So we won't return a null value for the list object.
        /// </summary>
        private IList<string> m_channels = new List<string>();

        /// <summary>
        /// So we won't return a null value for the list object.
        /// </summary>
        private IList<string> m_targets = new List<string>();

        #endregion

        /// <summary>
        /// The AccountID which this event was run as.
        /// </summary>
        [DataMember]
        public int AccountId { get; set; }


        /// <summary>
        /// The channels the campaign will be (or was) sent to.
        /// </summary>
        [DataMember]
        public IList<string> Channels
        {
            get { return m_channels; }
            set { m_channels = value ?? new List<string>(); }
        }

        /// <summary>
        /// A list of targets this event will be (or was) sent to.
        /// </summary>
        /// <remarks>
        /// Targets can be a mixture of email addresses, phone numbers, and contact ids.
        /// 
        /// Note that in order for the system to differentiate a phone number from a contact ID, phone numbers must be
        /// prefixed with their country dialing code. E.g.: {@code (221) 555-0100} should be listed as {@code +12215550100}
        /// </remarks>
        [DataMember]
        public IList<string> Targets
        {
            get { return m_targets; }
            set { m_targets = value ?? new List<string>(); }
        }


        /// <summary>
        /// The contact lists to use for getting a list of contacts.
        /// </summary>
        /// <remarks>
        /// Generation of contact lists are not yet supported by this SDK, but they can be created via 
        /// raw API calls and using our Portal.  If you do create a contact list in this way, you can
        /// supply the generated ID here without any issues.
        /// </remarks>
         [DataMember]
        public IList<int> ContactListIds { get; set; }

        /// <summary>
        /// The campaign to send (or was sent)
        /// </summary>
        [DataMember]
        public int CampaignId { get; set; }
        
        /// <summary>
        /// The "from" line to use for sending to an email channel.
        /// </summary>
        /// <remarks>
        /// If it is not filled in, a default from field will be used.
        /// </remarks>
        /// <seealso cref="Campaign" />
        /// <seealso cref="Content" />
        /// <seealso cref="ContentTemplate" />
        /// <seealso cref="CampaignType" />
        /// <seealso cref="EncodingType" />
        [DataMember]
        public string From { get; set; }

        /// <summary>
        /// Ignore a campaign's SingleUse flag.
        /// </summary>
        /// <remarks>
        /// If a campaign is marked as single use, then it will only get sent to a particular 
        /// contact once and only once.  Setting this value will force the message to get
        /// sent regardless of the SingleUse flag setting on the campaign.
        /// 
        /// This can be handy if you have a particular contact who did not receive the message
        /// and you would like to resend it to them.
        /// </remarks>
        /// <seealso cref="Campaign.SingleUse" />
         [DataMember]
        public bool IgnoreSingleUse { get; set; }

        /// <summary>
        /// Forces the contacts to be opted into the subscription defined on the campaign.
        /// </summary>
         [DataMember]
        public bool ForceOptIn { get; set; }


        /// <summary>
        /// Set true if the action should be executed on creation
        /// </summary>
         [DataMember]
        public bool Execute { get; set; }


        #region Gateway Campaign Parameters

        // These fields are only needed for gateway campaigns.  For all other campaign types they will be ignored.

        /// <summary>
        /// The message text for use on gateway campaigns.
        /// </summary>
        /// <remarks>
        /// IMPORTANT: You cannot send Razor formatted text with this system.
        /// </remarks>
        [DataMember]
        public string Message { get; set; }

        /// <summary>
        /// The "Subject" line to use when sending to an email channel.
        /// </summary>
        /// <remarks>
        /// This field is ignored when being sent to all other types of channels.
        /// </remarks>
        [DataMember]
        public string Subject { get; set; }

        #endregion

    }
}
