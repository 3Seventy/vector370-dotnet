using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSeventy.Vector.Client.Models
{
    /// <summary>
    /// Details of a valid answer for a campaign question.
    /// </summary>
    [DataContract]
    [Serializable]
    public class CampaignQuestionAnswerDefinition : BaseAudited
    {

        /// <summary>
        /// campaign Id
        /// </summary>
        public int CampaignId { get; set; }

        /// <summary>
        /// AnswerId
        /// </summary>
        public int AnswerId { get; set; }
        /// <summary>
        /// The account which owns the campaign.
        /// </summary>
        [DataMember]
        public int AccountId { get; set; }

        /// <summary>
        /// The question which this is a valid answer to.
        /// </summary>
         [DataMember]
        public int QuestionId { get; set; }

        /// <summary>
        /// Next campaignid for dialog 
        /// </summary>
        [DataMember]
        public int NextCampaignId { get; set; }

        /// <summary>
        /// Defines the content for multiple choise answers.
        /// </summary>
        /// <remarks>
        /// On answers for multiple choise questions, this is REQUIRED.  For other question types this is INVALID.
        /// </remarks>
         [DataMember]
        public int? ContentId { get; set; }

        /// <summary>
        /// Validator for open_reponse answers
        /// </summary>
         [DataMember]
        public string Validator { get; set; }

        /// <summary>
        /// A user definable ID to order the answers by on multiple choise questions.
        /// </summary>
         [DataMember]
        public int OrderingId { get; set; }

        /// <summary>
        /// The value that is actually saved when we receive this answer.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Label
        /// </summary>
         [DataMember]
        public string Label { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        public string Description { get; set; }
    }
}
