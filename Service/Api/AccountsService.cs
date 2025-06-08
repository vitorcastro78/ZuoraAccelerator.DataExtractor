using Microsoft.Extensions.Logging;
using RestSharp;
using Service.Client;
using Service.Constants;
using Service.Interfaces;
using Service.Models;

namespace Service
{
    /// <summary>
    /// Service responsible for managing accounts in the system.
    /// Provides methods for creating, updating, deleting, and querying accounts.
    /// </summary>
    public class AccountsService : IAccountsService
    {
        public readonly IApiClient _apiClient;

        private readonly List<string> expand;

        private List<string> filter;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactsService"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of _apiClient (optional)</param>
        /// <returns></returns>
        public AccountsService(ApiClient apiClient)
        {
            _apiClient = apiClient;
            expand = new Expands().AccountExpand;
            filter = new List<string>
                {
                    "enabled.EQ:true",
                    "subscriptions.state.EQ:active",
                };
        }


        /// <summary>
        /// List accounts Returns a dictionary with a data property that contains an array of accounts, starting after the cursor, if used. Each entry in the array is a separate account object. If no more accounts are available, the resulting array will be empty. This request should never return an error.
        /// </summary>
        /// <returns>ListAccountResponse</returns>
        public void FillAccountsTable(string zuoraTrackId, bool? async)
        {
            var path = $"v2/accounts";
            path = path.Replace("{format}", "json");
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            

            //if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            //if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

             _apiClient.FillPersistentTable<ListAccountResponse>(path, queryParams, null);

        }


    }
}