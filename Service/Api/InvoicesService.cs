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
    public class InvoicesService :IInvoicesService
    {
        public readonly IApiClient _apiClient;

        private readonly List<string> expand;

        private List<string> filter;

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicesService"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of _apiClient (optional)</param>
        /// <returns></returns>
        public InvoicesService(ApiClient apiClient)
        {
            _apiClient = apiClient;
            expand = new Expands().InvoicesExpand;
            filter = new List<string>
                {
                    "state.EQ:posted",
                };
        }


        /// <summary>
        /// Fill Invoices Table
        /// </summary>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        public void FillInvoicesItemsTable(string zuoraTrackId, bool async)
        {
            var path = $"v2/invoice_items";
            path = path.Replace("{format}", "json");

            filter = new List<string>
                {
                    "state.EQ:posted",
                };

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();

            string postBody = null;

            if (expand.Any()) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (filter.Any()) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter

            _apiClient.FillPersistentTable<InvoiceListResponse>(path, queryParams, postBody);

        }


        /// <summary>
        /// Fill Invoices Table
        /// </summary>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        public void FillInvoicesTable(string zuoraTrackId, bool async)
        {
            var path = $"v2/invoices";
            path = path.Replace("{format}", "json");

            filter = new List<string>
                {
                    "state.EQ:posted",
                };

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();

            string postBody = null;

            if (expand.Any()) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (filter.Any()) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter

            _apiClient.FillPersistentTable<InvoiceListResponse>(path, queryParams, postBody);

        }


    }
}