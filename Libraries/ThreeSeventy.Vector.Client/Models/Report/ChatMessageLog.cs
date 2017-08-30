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
    /// Chat Message Log
    /// </summary>
    [DataContract]
    [Serializable]
    public class ChatMessageLog : LogBase
    {
        /// <summary>
        /// Account Id
        /// </summary>
        [DataMember]
        public int AccountId { get; set; }
        /// <summary>
        /// Conversation ID (see ChatConversationLog)
        /// </summary>
        [DataMember]
        public int ConversationId { set; get; }

        /// <summary>
        /// Incoming/Outgoing flag
        /// </summary>
        [DataMember]
        public bool Incoming { set; get; }

        /// <summary>
        /// When this message was sent.
        /// </summary>
        [DataMember]
        public string Message { set; get; }

        /// <summary>
        /// Who send this message
        /// </summary>
        [DataMember]
        public string Sender { set; get; }

        /// <summary>
        /// 	False if was not seen by the user, otherwise - true
        /// </summary>
        [DataMember]
        public bool Viewed { set; get; }
    }
}
