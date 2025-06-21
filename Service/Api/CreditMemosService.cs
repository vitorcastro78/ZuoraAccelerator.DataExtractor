using EasyCaching.Core;
using RestSharp;
using Service.Client;
using Service.Constants;
using Service.Interfaces;
using Service.Models;

namespace Service
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CreditMemosService : ICreditMemosService
    {
        public readonly IApiClient _apiClient;

        private readonly List<string> expand;

        private List<string> filter;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditMemosService"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of _apiClient (optional)</param>
        /// <returns></returns>
        public CreditMemosService(ApiClient apiClient)
        {
            _apiClient = apiClient;
            expand = new Expands().CreditMemoExpand;
            filter = new List<string>
                {
                    "enabled.EQ:true",
                    "subscriptions.state.EQ:active",
                };
        }


        /// <summary>
        /// List credit memo items
        /// </summary>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        public CreditMemoItemListResponse GetCreditMemoItems(string zuoraTrackId, bool? async)
        {
            var path = $"v2/credit_memo_items";
            

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();


            string postBody = null;

            //if (cursor != null) queryParams.Add("cursor", _apiClient.ParameterToString(cursor)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter

            // make the HTTP request
            _apiClient.FillPersistentTable<CreditMemoItemListResponse>(path, queryParams, postBody);
            return new CreditMemoItemListResponse();

        }

        /// <summary>
        /// List credit memos
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        public CreditMemoListResponse GetCreditMemos(string zuoraTrackId, bool? async)
        {
            var path = $"v2/credit_memos";
            

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();


            string postBody = null;

            if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter));
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            // make the HTTP request
            _apiClient.FillPersistentTable<CreditMemoListResponse>(path, queryParams, postBody);
            return new CreditMemoListResponse();
        }


    }
}