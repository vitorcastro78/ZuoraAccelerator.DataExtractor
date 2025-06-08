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
    public class SubscriptionsService : ISubscriptionsService
    {
        
        public readonly IApiClient _apiClient;
        private readonly List<string> expand;
        private List<string> filter;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactsService"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of _apiClient (optional)</param>
        /// <returns></returns>
        public SubscriptionsService(ApiClient apiClient)
        {

            _apiClient = apiClient;
            expand = new Expands().SubscriptionsExpand;

            filter = new List<string>
            {
                "latest_version.EQ:true",
                "state.EQ:active",
            };
        }



        /// <summary>
        /// Fill Subscriptions Table
        /// </summary>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        public void FillSubscriptionsTable(string zuoraTrackId, bool async)
        {
            var path = $"v2/subscriptions";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();


            string postBody = null;

            if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter


            _apiClient.FillPersistentTable<SubscriptionListResponse>(path, queryParams, postBody);
        }


    }
}