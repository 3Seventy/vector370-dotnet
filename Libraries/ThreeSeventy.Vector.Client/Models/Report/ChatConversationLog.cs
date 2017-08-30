using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSeventy.Vector.Client.Models
{
    /// <summary>
    /// Chat Conversation Log Details
    /// </summary>
    [DataContract]
    [Serializable]
    public class ChatConversationLog  : LogBase
    {
        /// <summary>
        /// Account Id
        /// </summary>
        [DataMember]
        public int AccountId { get; set; }

        /// <summary>
        /// conversation Id
        /// </summary>
        [DataMember]
        public int ConversationId { get; set; }

        /// <summary>
        /// True if target already got auto-response message
        /// </summary>
        [DataMember]
        public bool AutoResponded { get; set; }

        /// <summary>
        /// A contact you are talking to
        /// </summary>
        [DataMember]
        public int? ContactId { get; set; }

        /// <summary>
        /// 	A name to display
        /// </summary>
        [DataMember]
        public string DisplayName { get; set; }

        /// <summary>
        /// Last incoming message timestamp
        /// </summary>
        [DataMember]
        public DateTime LastMessage { get; set; }

        /// <summary>
        /// 	Real target -- holding phone number for SMS users
        /// </summary>
        [DataMember]
        public string RealTarget { get; set; }

        /// <summary>
        /// Collocutor(s) -- nick or channel name
        /// </summary>
        [DataMember]
        public string Target { get; set; }

        /// <summary>
        /// Total messages unread.
        /// </summary>
        [DataMember]
        public int UnreadCount { get; set; }
    }
}
