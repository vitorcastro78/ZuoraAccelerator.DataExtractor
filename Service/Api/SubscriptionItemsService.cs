using RestSharp;
using Service.Interfaces;
using Service.Client;
using Service.Models;
using EasyCaching.Core;
using Service.Constants;

namespace Service
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SubscriptionItemsService : ISubscriptionItemsService
    {
        public readonly IApiClient _apiClient;

        private readonly List<string> expand;

        private List<string> filter;

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionItemsService"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of _apiClient (optional)</param>
        /// <returns></returns>
        public SubscriptionItemsService(ApiClient apiClient)
        {
            _apiClient = apiClient;
            expand = new Expands().SubscriptionItemsExpand;
            filter = new List<string>
                {
                    "enabled.EQ:true",
                    "subscriptions.state.EQ:active",
                };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        public void FillSubscriptionItemsTable(string zuoraTrackId, bool async)
        {
            var path = $"v2/subscription_items";
            var headerParams = new Dictionary<string, string>();
            var queryParams = new Dictionary<string, string>();
            string postBody = null;
            filter = new List<string>();
            if (expand.Any()) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            //if (filter.Any()) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter
            // make the HTTP request
            _apiClient.FillPersistentTable<SubscriptionItemListResponse>(path, queryParams, postBody);
        }

    }
}