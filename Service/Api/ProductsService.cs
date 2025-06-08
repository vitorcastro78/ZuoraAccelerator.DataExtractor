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
    public class ProductsService : IProductsService
    {
        public readonly IApiClient _apiClient;

        private readonly List<string> expand;

        private List<string> filter;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductsService"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of _apiClient (optional)</param>
        /// <returns></returns>
        public ProductsService(ApiClient apiClient)
        {
            _apiClient = apiClient;
            expand = new Expands().ProductExpand;
            filter = new List<string>
                {
                    "enabled.EQ:true",
                    "subscriptions.state.EQ:active",
                };
        }

        /// <summary>
        /// Fill Products Table
        /// </summary>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        public void  FillProductsTable(string zuoraTrackId, bool? async)
        {
            var path = $"v2/products";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;

            filter = new List<string>();    

            if (expand.Any()) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (filter.Any()) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter


             _apiClient.FillPersistentTable<ProductListResponse>(path, queryParams, postBody);

        }



    }
}