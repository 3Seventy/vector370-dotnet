using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSeventy.Vector.Client.Models
{
    /// <summary>
    /// Used to Schedule an Action
    /// </summary>
    [Serializable]
    [DataContract]
    public class ActionSchedule : BaseAudited
    {
        /// <summary>
        /// Account Id
        /// </summary>
        [DataMember]
        public int AccountId { get; set; }

        /// <summary>
        /// Action Id
        /// </summary>
        [DataMember]
        public int ActionId { get; set; }

  
        /// <summary>
        /// Schedule Type Id
        /// </summary>
        [DataMember]
        public int ScheduleTypeId { get; set; }

        /// <summary>
        /// Schedule Type Enum
        /// </summary>
        [IgnoreDataMember]
        public ScheduleType ScheduleType
        {
            get { return (ScheduleType) ScheduleTypeId; }
            set { ScheduleTypeId = (int) value; }
        }

        /// <summary>
        /// Time of day to start run at Ex: 12:20:00 or 17:04:40
        /// </summary>
        [DataMember]
        public string RunAt { get; set; }

        /// <summary>
        /// Date and time from which schedule will start.
        /// </summary>
        [DataMember]
        public DateTime StartFrom { get; set; }

        /// <summary>
        /// Day(s) of week to run action on.
        /// </summary>
        [DataMember]
        public string WeekDay { get; set; }


        /// <summary>
        /// Day(s) of month to run action on.
        /// </summary>
        [DataMember]
        public string MonthDay { get; set; }
    }
}
