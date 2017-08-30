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
    /// Returned details of a report's metadata.
    /// </summary>
    [DataContract]
    [Serializable]
    public class Report : BaseAudited

    {
        private IQueryable<ReportColumn> m_columns = new List<ReportColumn>().AsQueryable();

        /// <summary>
        /// The account to which this report belongs.
        /// </summary>
        [DataMember]
        public int AccountId { get; set; }

        /// <summary>
        /// The type of report this is.
        /// </summary>
        [DataMember]
        public int CategoryId { get; set; }

        /// <summary>
        /// The name of the report.
        /// </summary>
        /// <remarks>
        /// This is the name sent when asking to execute the report.
        /// </remarks>
        [DataMember]
        public string ReportName { get; set; }

        /// <summary>
        /// The display name of the report in the UI.
        /// </summary>
        [DataMember]
        public string DisplayName { get; set; }

        /// <summary>
        /// List of columns that are defined on this report.
        /// </summary>
        [DataMember]
        public IQueryable<ReportColumn> Columns
        {
            get { return m_columns; }
            set { m_columns = value == null ? new List<ReportColumn>().AsQueryable() : value; }
        }
    }

    /// <summary>
    /// Details of a report's columns
    /// </summary>
    [DataContract]
    [Serializable]
    public class ReportColumn
    {
        /// <summary>
        /// The name of the report's column
        /// </summary>
        [DataMember]
        public string ColumnName { get; set; }

        /// <summary>
        /// The type of data this column returns.
        /// </summary>
        [DataMember]
        public int DataTypeId { get; set; }

        /// <summary>
        /// Set if this column can return a NULL
        /// </summary>
        [DataMember]
        public bool IsNullable { get; set; }
    }
}
