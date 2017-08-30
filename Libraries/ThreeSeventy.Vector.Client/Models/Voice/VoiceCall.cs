using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSeventy.Vector.Client.Models
{ /// <summary>
    /// 
    /// </summary>
    [DataContract]
    [Serializable]
    public class VoiceCall
    {
        /// <summary>
        /// Phone number to which the call will be made
        /// </summary>
        /// 
        [DataMember]
        public string ToNumber { get; set; }

        /// <summary>
        /// Sentance to speak  
        /// </summary>
        [DataMember]
        public string SpeakSentance { get; set; }
    }
}
