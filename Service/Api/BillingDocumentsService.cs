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
    public class BillingDocumentsService : IBillingDocumentsService
    {

        public readonly IApiClient _apiClient;

        private readonly List<string> expand;

        private List<string> filter;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactsService"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of _apiClient (optional)</param>
        /// <returns></returns>
        public BillingDocumentsService(ApiClient apiClient)
        {
            _apiClient = apiClient;
            expand = new Expands().BillingDocumentItemExpand;
            filter = new List<string>();
        }


        /// <summary>
        /// Retrieves a list of billing documents based on the specified parameters.
        /// </summary>
        /// <remarks>This method interacts with the Zuora API to retrieve billing documents. The response
        /// may include additional  metadata depending on the query parameters provided.</remarks>
        /// <param name="zuoraTrackId">The Zuora tracking ID used to correlate requests. This value is optional but recommended for tracing API
        /// calls.</param>
        /// <param name="async">A boolean value indicating whether the operation should be performed asynchronously.  If <see
        /// langword="true"/>, the operation is executed asynchronously; otherwise, it is executed synchronously.</param>
        /// <returns>A <see cref="BillingDocumentListResponse"/> object containing the list of billing documents.</returns>
        public void FillBillingDocumentsTable(string zuoraTrackId, bool? async)  
        {
            var path =$"v2/billing_documents";
            

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            string postBody = null;

            if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            // make the HTTP request
            _apiClient.FillPersistentTable<BillingDocumentListResponse>(path, queryParams, postBody);
     
        }

    }
}