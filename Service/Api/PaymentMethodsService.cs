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
    public class PaymentMethodsService : IPaymentMethodsService
    {
        public readonly IApiClient _apiClient;

        private readonly List<string> expand;

        private List<string> filter;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactsService"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of _apiClient (optional)</param>
        /// <returns></returns>
        public PaymentMethodsService(ApiClient apiClient)
        {
            _apiClient = apiClient;
            expand = new Expands().PaymentMethodExpand;
            filter = new List<string>();
        }

     
        /// <summary>
        /// Get a list of payment methods Returns a dictionary with a data property that contains an array of payment method objects. If no payment methods are found, the resulting data property will be an empty array. This request should never return an error.
        /// </summary>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        /// <exception cref="ApiException"></exception>
        public void GetPaymentMethods(string zuoraTrackId, bool? async)
        {
            var path =$"v2/payment_methods";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<string, string>();
            string postBody = null;


            if (expand.Any()) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (filter.Any()) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter
 
            // make the HTTP request
               _apiClient.FillPersistentTable<PaymentMethodListResponse>(path, queryParams, postBody);

         
        }

     

   
    }
}