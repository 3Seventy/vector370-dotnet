using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSeventy.Vector.Client.Models
{
    /// <summary>
    /// Details of dialog specific campaign type.
    /// </summary>
    [DataContract]
    [Serializable]
    public class CampaignDialog : BaseAudited
    {
        /// <summary>
        /// The account ID which owns this dialog
        /// </summary>
        [DataMember]
        public int AccountId { get; set; }


        /// <summary>
        /// Campaign Id
        /// </summary>
        public int CampaignId { get; set; }

        /// <summary>
        /// Pointer to the campaign which defines the first question of the dialog.
        /// </summary>
        [DataMember]
        public int FirstQuestionId { get; set; }
    }
}
