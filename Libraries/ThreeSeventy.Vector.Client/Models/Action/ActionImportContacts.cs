using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSeventy.Vector.Client.Models
{
    /// <summary>
    /// Lets you import conatcts 
    /// </summary>
    [DataContract]
    [Serializable]
    public class ActionImportContacts : BaseAudited
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ActionImportContacts()
        {
            Schedules = new List<ActionSchedule>();
            Subscriptions = new List<ContactSubscription>();
        }


        /// <summary>
        /// The account ID that the action reports under.
        /// </summary>
        [DataMember]
        public int AccountId { get; set; }


        /// <summary>
        /// The list of schedules associated with the action
        /// </summary>
        [DataMember]
        public List<ActionSchedule> Schedules { get; set; }



        /// <summary>
        /// Points to a BLOB url that contains the file to parse.
        /// </summary>
        [DataMember]
        public string Url { get; set; }

        /// <summary>
        /// A list of subscriptions that should be added or modified for each of the contacts in the supplied file.
        /// </summary>
        /// 
        [DataMember]
        public IList<ContactSubscription> Subscriptions { get; set; }


        /// <summary>
        /// This will override optout to optin 
        /// </summary>
        [DataMember]
        public bool OverrideSubscription { get; set; }
    }
}
