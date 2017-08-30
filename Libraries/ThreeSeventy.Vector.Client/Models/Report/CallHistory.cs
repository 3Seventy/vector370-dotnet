using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSeventy.Vector.Client.Models
{
    /// <summary>
    /// Describes the Call history
    /// </summary>
    [DataContract]
    [Serializable]
    public  class CallHistory : LogBase
    {
        /// <summary>
        /// The account ID the source belonged to.
        /// </summary>
        [DataMember]
        public int AccountId { get; set; }


        /// <summary>
        /// 	The IRC command that was sent
        /// </summary>
        [DataMember]
        public string Command { get; set; }

        /// <summary>
        /// The message that the user sent
        /// </summary>
        [DataMember]
        public string MessageSent { get; set; }


        /// <summary>
        /// Who caused this event to occur.
        /// </summary>
        [DataMember]
        public string Source { get; set; }

        /// <summary>
        /// 	Who (or what) this event was bound to.
        /// </summary>
        [DataMember]
        public string Target { get; set; }
    }
}
