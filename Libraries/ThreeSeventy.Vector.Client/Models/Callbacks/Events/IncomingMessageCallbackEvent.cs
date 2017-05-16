using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSeventy.Vector.Client.Models
{
    /// <summary>
    /// Details for when a contact sends a message to the Platfrom.
    /// </summary>
    [Serializable]
    [DataContract]
    public class IncomingMessageCallbackEvent:BaseCallbackEvent
    {
        /// <summary>
        /// The account name that sent the message.
        /// </summary>
        [DataMember]
        public string AccountName { get; set; }

        /// <summary>
        /// The Message that the contact has sent to the platfrom
        /// </summary>
        [DataMember]
        public string Message { get; set; }

        /// <summary>
        /// The channel ID we receved the message on.
        /// </summary>
        [DataMember]
        public int ChannelId { get; set; }

        /// <summary>
        /// The contact ID which texted in.
        /// </summary>
        [DataMember]
        public int ContactId { get; set; }

        /// <summary>
        /// The phone number of the contact
        /// </summary>
        [DataMember]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The actual channle code Ex: +19103755141
        /// </summary>
        [DataMember]
        public int ChannelCode { get; set; }

  
    }
}


