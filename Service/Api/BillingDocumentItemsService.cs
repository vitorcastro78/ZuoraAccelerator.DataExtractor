using EasyCaching.Core;
using RestSharp;
using Service.Interfaces;
using Service.Client;
using Service.Models;
using Service.Constants;

namespace Service
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BillingDocumentItemsService : IBillingDocumentItemsService
    {
        public readonly ApiClient _apiClient;
        private readonly List<string> expand;
        private List<string> filter;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactsService"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of _apiClient (optional)</param>
        /// <returns></returns>
        public BillingDocumentItemsService(ApiClient apiClient)
        {
            _apiClient = apiClient;
            expand = new Expands().BillingDocumentItemExpand;
            filter = new List<string>
                {
                    "enabled.EQ:true",
                    "subscriptions.state.EQ:active",
                };
        }

        /// <summary>
        /// List billing document items
        /// </summary>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        public BillingDocumentItemListResponse GetBillingDocumentItems(string zuoraTrackId, bool? async)
        {
            var path =$"v2/billing_document_items";
            

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;

            if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            //if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter


            // make the HTTP request
            _apiClient.FillPersistentTable<BillingDocumentItemListResponse>(path, queryParams, postBody);

        }
      
    }
}