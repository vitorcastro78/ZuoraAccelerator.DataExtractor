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
    public class SubscriptionPlansService : ISubscriptionPlansService
    {
        public readonly IApiClient _apiClient;

        private readonly List<string> expand;

        private List<string> filter;

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPlansService"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of _apiClient (optional)</param>
        /// <returns></returns>
        public SubscriptionPlansService(ApiClient apiClient)
        {
            _apiClient = apiClient;
            expand = new Expands().SubscriptionPlanExpand;
            filter = new List<string>
                {
                    "subscriptions.state.EQ:active",
                };
        }

        /// <summary>
        /// Fills the cache with subscription plans
        /// </summary>
        /// <returns></returns>
        public void FillSubscriptionPlansTable()
        {
            var path = $"v2/subscription_plans";
            

            var queryParams = new Dictionary<string, string>();
            string postBody = null;
            filter = new List<string>();

            if (expand.Any()) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (filter.Any()) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter

            // make the HTTP request
            _apiClient.FillPersistentTable<SubscriptionPlanListResponse>(path, queryParams, postBody);
        }



    }
}