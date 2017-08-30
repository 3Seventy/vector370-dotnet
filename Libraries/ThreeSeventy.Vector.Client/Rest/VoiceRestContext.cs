using System;
using System.Collections.Generic;
using System.Linq;
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
    public class VoiceRestContext : T70Context
    {
        private const string VOICE_CALL_URI = "/account/{accountId}/long-code/{longCode}/voicecall";

        private const string AUDIO_CALL_URI = "/account/{accountId}/long-code/{longCode}/audiocall";

        private const string BRIDGE_CALL_URI = "/account/{accountId}/long-code/{longCode}/bridgecalls";

        private const string CONFERENCE_CALL_URI = "/account/{accountId}/long-code/{longCode}/conferencecal";
        

        /// <summary>
        /// Allows you to make a voice call from your LongCode to a valid phone number and will speak the provided sentance 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="longCode">Long code (From phone number) in the following format Ex.1xxxxxxxxxx</param>
        /// <returns></returns>
        public string VoiceCall(int accountId, string longCode, VoiceCall model)
        {
            var request = new RestRequest(VOICE_CALL_URI, Method.POST)
            {
                RequestFormat = DataFormat.Json,
                JsonSerializer = new NewtonsoftSerializer()
            };


            request.AddUrlSegment("accountId", accountId.ToString());
            request.AddUrlSegment("longCode", longCode);

            request.AddBody(model);

            var res = Execute<object>(request) ?? "";

            // TODO: Map a flattened contact to an unflattened one.

            return res.ToString();
        }


        /// <summary>
        /// Allows you to make a call from your LongCode and play an audio file (mp3 or wav formats only) to a valid phone number
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="longCode">Long code (From phone number) in the following format Ex.1xxxxxxxxxx</param>
        /// <param name="model"></param>
        /// <returns></returns>
        public string AudioCall(int accountId, string longCode, AudioCall model)
        {
            var request = new RestRequest(AUDIO_CALL_URI, Method.POST)
            {
                RequestFormat = DataFormat.Json,
                JsonSerializer = new NewtonsoftSerializer()
            };


            request.AddUrlSegment("accountId", accountId.ToString());
            request.AddUrlSegment("longCode", longCode);

            request.AddBody(model);

            var res = Execute<object>(request) ?? "";

            // TODO: Map a flattened contact to an unflattened one.

            return res.ToString();
        }

        /// <summary>
        /// Allows you to Bridge calls between two phone numbers using your Longcode
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="longCode">Long code (From phone number) in the following format Ex.1xxxxxxxxxx</param>
        /// <param name="model"></param>
        /// <returns></returns>
        public string BridgeCall(int accountId, string longCode, BridgeCall model)
        {
            var request = new RestRequest(BRIDGE_CALL_URI, Method.POST)
            {
                RequestFormat = DataFormat.Json,
                JsonSerializer = new NewtonsoftSerializer()
            };


            request.AddUrlSegment("accountId", accountId.ToString());
            request.AddUrlSegment("longCode", longCode);

            request.AddBody(model);

            var res = Execute<object>(request) ?? "";

            // TODO: Map a flattened contact to an unflattened one.

            return res.ToString();
        }


        /// <summary>
        /// Allows you to join an existing conference call or create a new one 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="longCode">Long code (From phone number) in the following format Ex.1xxxxxxxxxx</param>
        /// <param name="model"></param>
        /// <returns></returns>
        public string ConferenceCall(int accountId, string longCode, ConferenceCall model)
        {
            var request = new RestRequest(CONFERENCE_CALL_URI, Method.POST)
            {
                RequestFormat = DataFormat.Json,
                JsonSerializer = new NewtonsoftSerializer()
            };


            request.AddUrlSegment("accountId", accountId.ToString());
            request.AddUrlSegment("longCode", longCode);

            request.AddBody(model);

            var res = Execute<object>(request) ?? "";

            // TODO: Map a flattened contact to an unflattened one.

            return res.ToString();
        }
    }
}
