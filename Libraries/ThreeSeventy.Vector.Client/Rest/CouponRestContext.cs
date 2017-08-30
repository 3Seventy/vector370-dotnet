using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using ThreeSeventy.Vector.Client.Models;
using ThreeSeventy.Vector.Client.Utils;

namespace ThreeSeventy.Vector.Client.Rest
{
    /// <summary>
    /// Used to interact with the Coupon related endpoints
    /// </summary>
    public class CouponRestContext : T70Context
    {
        private const string CAMPAIGN_COUPON_DEF = "/account/{accountId}/campaign/{campaignId}/coupon";

        private const string CAMPAIGN_COUPON_DEF_REDMP = "/account/{accountId}/campaign/{campaignId}/coupon/redemptions";

        private const string COUPON_OFFER = "/account/{accountId}/campaign/{campaignId}/couponOffer";

        private const string EXTERNAL_COUPON_CODES_LIST =
            "/account/{accountId}/external-couponlist/{externalCouponListId}/code";

        private const string EXTERNAL_COUPON_CODES_ITEM =
    "/account/{accountId}/external-couponlist/{externalCouponListId}/code/{couponCode}";


        private const string REDEEM_COUPON = "/account/{accountId}/event-redeemcoupon";

        /// <summary>
        /// Get Coupon Definition
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="campaignId"></param>
        /// <returns></returns>
        public HttpResponseMessage GetCouponDefinition(int accountId, int campaignId)
        {
            var request = new RestRequest(CAMPAIGN_COUPON_DEF, Method.GET)
            {
                RequestFormat = DataFormat.Json,
                JsonSerializer = new NewtonsoftSerializer()
            };


            request.AddUrlSegment("accountId", accountId.ToString());
            request.AddUrlSegment("campaignId", campaignId.ToString());

            var res = Execute<HttpResponseMessage>(request) ?? new HttpResponseMessage();

            // TODO: Map a flattened contact to an unflattened one.

            return res;
        }

        /// <summary>
        /// Get Redemption Rates
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="campaignId"></param>
        /// <returns></returns>
        public HttpResponseMessage GetCouponDefinitionRedemption(int accountId, int campaignId)
        {
            var request = new RestRequest(CAMPAIGN_COUPON_DEF_REDMP, Method.GET)
            {
                RequestFormat = DataFormat.Json,
                JsonSerializer = new NewtonsoftSerializer()
            };


            request.AddUrlSegment("accountId", accountId.ToString());
            request.AddUrlSegment("campaignId", campaignId.ToString());

            var res = Execute<HttpResponseMessage>(request) ?? new HttpResponseMessage();

            // TODO: Map a flattened contact to an unflattened one.

            return res;
        }


        /// <summary>
        /// Gets the Coupon Campaign offer details.
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="campaignId"></param>
        /// <returns></returns>
        public HttpResponseMessage GetCouponOfferDetails(int accountId, int campaignId)
        {
            var request = new RestRequest(COUPON_OFFER, Method.GET)
            {
                RequestFormat = DataFormat.Json,
                JsonSerializer = new NewtonsoftSerializer()
            };


            request.AddUrlSegment("accountId", accountId.ToString());
            request.AddUrlSegment("campaignId", campaignId.ToString());

            var res = Execute<HttpResponseMessage>(request) ?? new HttpResponseMessage();

            // TODO: Map a flattened contact to an unflattened one.

            return res;
        }


        /// <summary>
        /// Get all coupon codes associated with a perticular External coupon ListId
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="externalCouponListId"></param>
        /// <returns></returns>
        public List<CouponExternalCode> GetCouponExternalCodeList(int accountId, int externalCouponListId)
        {
            var request = new RestRequest(EXTERNAL_COUPON_CODES_LIST, Method.GET)
            {
                RequestFormat = DataFormat.Json,
                JsonSerializer = new NewtonsoftSerializer()
            };


            request.AddUrlSegment("accountId", accountId.ToString());
            request.AddUrlSegment("externalCouponListId", externalCouponListId.ToString());

            var res = Execute<List<CouponExternalCode>>(request) ?? new List<CouponExternalCode>();

            // TODO: Map a flattened contact to an unflattened one.

            return res;
        }



        /// <summary>
        /// Get details of a perticular Coupon Code
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="externalCouponListId"></param>
        /// <param name="couponCode"></param>
        /// <returns></returns>
        public HttpResponseMessage GetCouponExternalCode(int accountId, int externalCouponListId, string couponCode)
        {
            var request = new RestRequest(EXTERNAL_COUPON_CODES_ITEM, Method.GET)
            {
                RequestFormat = DataFormat.Json,
                JsonSerializer = new NewtonsoftSerializer()
            };


            request.AddUrlSegment("accountId", accountId.ToString());
            request.AddUrlSegment("externalCouponListId", externalCouponListId.ToString());
            request.AddUrlSegment("couponCode", couponCode);


            var res = Execute<HttpResponseMessage>(request) ?? new HttpResponseMessage();

            // TODO: Map a flattened contact to an unflattened one.

            return res;
        }


        /// <summary>
        /// Deletes a perticular coupon code associated with an External coupon List
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="externalCouponListId"></param>
        /// <param name="couponCode"></param>
        /// <returns></returns>
        public HttpResponseMessage DeleteCouponExternalCode(int accountId, int externalCouponListId, string couponCode)
        {
            var request = new RestRequest(EXTERNAL_COUPON_CODES_ITEM, Method.DELETE)
            {
                RequestFormat = DataFormat.Json,
                JsonSerializer = new NewtonsoftSerializer()
            };


            request.AddUrlSegment("accountId", accountId.ToString());
            request.AddUrlSegment("externalCouponListId", externalCouponListId.ToString());
            request.AddUrlSegment("couponCode", couponCode);


            var res = Execute<HttpResponseMessage>(request) ?? new HttpResponseMessage();

            // TODO: Map a flattened contact to an unflattened one.

            return res;
        }


        /// <summary>
        ///  Controller for redeeming a coupon.
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="couponCode"></param>
        /// <returns></returns>
        public HttpResponseMessage RedeemCoupon(int accountId, string couponCode)
        {
            var request = new RestRequest(REDEEM_COUPON, Method.POST)
            {
                RequestFormat = DataFormat.Json,
                JsonSerializer = new NewtonsoftSerializer()
            };

            request.AddBody(couponCode);
            request.AddUrlSegment("accountId", accountId.ToString());

            var res = Execute<HttpResponseMessage>(request) ?? new HttpResponseMessage();

            // TODO: Map a flattened contact to an unflattened one.

            return res;
        }
    }
}
