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
    public class DebitMemosService : IDebitMemosService
    {
        public readonly IApiClient _apiClient;

        private readonly List<string> expand;

        private List<string> filter;

        /// <summary>
        /// Initializes a new instance of the <see cref="DebitMemosService"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of _apiClient (optional)</param>
        /// <returns></returns>
        public DebitMemosService(ApiClient apiClient)
        {
            _apiClient = apiClient;
            expand = new Expands().DebitMemoExpand;
            filter = new List<string>
                {
                    "enabled.EQ:true",
                    "subscriptions.state.EQ:active",
                };
        }



        /// <summary>
        /// List debit memo items Returns a dictionary with a data property that contains an array of debit memo items, starting after cursor. Each entry in the array is a separate debit memo item object. If no more debit memo items are available, the resulting array will be empty. This request should never return an error.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        public DebitMemoItemListResponse GetDebitMemoItems(string zuoraTrackId, bool? async)
        {
            var path = $"v2/debit_memo_items";
            

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();


            string postBody = null;

            if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            // make the HTTP request
            _apiClient.FillPersistentTable<DebitMemoItemListResponse>(path, queryParams, postBody);
            return new DebitMemoItemListResponse();
        }

        /// <summary>
        /// List debit memos Returns a dictionary with a data property that contains an array of debit memos, starting after cursor. Each entry in the array is a separate debit memo object. If no more debit memos are available, the resulting array will be empty. This request should never return an error.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        public DebitMemoListResponse GetDebitMemos(string zuoraTrackId, bool? async)
        {
            var path = $"v2/debit_memos";
            

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();


            string postBody = null;


            if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter));
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            // make the HTTP request
            _apiClient.FillPersistentTable<DebitMemoListResponse>(path, queryParams, postBody);
            return new DebitMemoListResponse();
        }

    }
}