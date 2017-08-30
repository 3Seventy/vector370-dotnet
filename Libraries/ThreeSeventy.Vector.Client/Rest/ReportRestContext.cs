using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using ThreeSeventy.Vector.Client.Models;
using ThreeSeventy.Vector.Client.Utils;

namespace ThreeSeventy.Vector.Client
{
    /// <summary>
    /// Used to make Voice API calls
    /// </summary>
    public class ReportRestContext : T70Context
    {
        private const string ALL_REPORTS_URI = "/account/{accountId}/report";

        private const string REPORT_URI = "/account/{accountId}/report/{reportName}?getCount={getCount}";


        /// <summary>
        /// Gets a list of all available reports.
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns></returns>
        public IQueryable<Report> GetAllReports(int accountId)
        {
            var request = new RestRequest(ALL_REPORTS_URI, Method.GET)
            {
                RequestFormat = DataFormat.Json,
                JsonSerializer = new NewtonsoftSerializer()
            };


            request.AddUrlSegment("accountId", accountId.ToString());

            var res = Execute<List<Report>>(request) ?? new List<Report>();

            // TODO: Map a flattened contact to an unflattened one.

            return res.AsQueryable();
        }

        /// <summary>
        /// Get deatils of the report
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="reportName"></param>
        /// <param name="getCount"></param>
        /// <returns></returns>
        public HttpResponseMessage GetReport(int accountId, string reportName, bool getCount)
        {
            var request = new RestRequest(REPORT_URI, Method.GET)
            {
                RequestFormat = DataFormat.Json,
                JsonSerializer = new NewtonsoftSerializer()
            };


            request.AddUrlSegment("accountId", accountId.ToString());
            request.AddUrlSegment("reportName", reportName);
            request.AddUrlSegment("getCount", getCount.ToString());

            var res = Execute<HttpResponseMessage>(request) ?? new HttpResponseMessage();

            // TODO: Map a flattened contact to an unflattened one.

            return res;
        }


    }
}
