using RestSharp;
using Service.Client;
using Service.Interfaces;
using Service.Models;

namespace Service
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BillRunPreviewsService : IBillRunPreviewsService
    {
        public readonly IApiClient _apiClient;

        private readonly List<string> expand;

        private List<string> filter;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactsService"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of _apiClient (optional)</param>
        /// <returns></returns>
        public BillRunPreviewsService(ApiClient apiClient)
        {
            _apiClient = apiClient;
            expand = new List<string>();
            filter = new List<string>();
        }



        /// <summary>
        /// Create a bill run preview Creates a bill run preview for a batch of customer accounts.
        /// </summary>
        /// <param name="body"></param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="async">Making asynchronous requests allows you to scale your applications more efficiently by leveraging Zuora&#x27;s infrastructure to enqueue and execute requests for you without blocking. These requests also use built-in retry semantics, which makes them much less likely to fail for non-deterministic reasons, even in extreme high-throughput scenarios. Meanwhile, when you send a request to one of these endpoints, you can expect to receive a response in less than 150 milliseconds and these calls are unlikely to trigger rate limit errors. If set to true, Zuora returns a 202 Accepted response, and the response body contains only a request ID.</param>
        /// <param name="zuoraEntityIds">An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="fields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;assume_renewal&#x60;, &#x60;charges_excluded&#x60;, &#x60;batches&#x60;, &#x60;target_date&#x60;, &#x60;state&#x60;, &#x60;number_of_accounts&#x60;, &#x60;number_of_accounts_succeeded&#x60;, &#x60;state_transitions&#x60;, &#x60;billing_preview_run_number&#x60;, &#x60;file&#x60;, &#x60;include_draft_items&#x60;, &#x60;include_evergreen_subscriptions&#x60;          &lt;/details&gt;</param>
        /// <param name="expand">Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://developer.zuora.com/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="filter">A case-sensitive filter on the list. See the [Filter lists](https://developer.zuora.com/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorial for detailed instructions.                         Note that the filters on this operation are only applicable to the related objects. For example, when you are calling the \&quot;Retrieve a billing document\&quot; operation, you can use the &#x60;filter[]&#x60; parameter on the related objects such as &#x60;filter[]&#x3D;items[accountId].EQ:8ad09e208858b5cf0188595208151c63&#x60;</param>
        /// <param name="pageSize">The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error.</param>
        /// <returns>BillRunPreview</returns>
        public BillRunPreview CreateBillRunPreview(BillRunPreviewCreateRequest body, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateBillRunPreview");

            var path =$"v2/bill_run_previews";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;

            if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            postBody = _apiClient.Serialize(body); // http body (model) parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<BillRunPreview>(path, Method.Post, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CreateBillRunPreview: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CreateBillRunPreview: " + response.ErrorMessage, response.ErrorMessage);

            return (BillRunPreview)_apiClient.Deserialize(response.Content, typeof(BillRunPreview));
        }



        /// <summary>
        /// Retrieve a bill run preview Retrieves the bill run preview information with the given ID.
        /// </summary>
        /// <param name="billRunPreviewId">Identifier for the bill run preview.</param>
        /// <param name="fields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;assume_renewal&#x60;, &#x60;charges_excluded&#x60;, &#x60;batches&#x60;, &#x60;target_date&#x60;, &#x60;state&#x60;, &#x60;number_of_accounts&#x60;, &#x60;number_of_accounts_succeeded&#x60;, &#x60;state_transitions&#x60;, &#x60;billing_preview_run_number&#x60;, &#x60;file&#x60;, &#x60;include_draft_items&#x60;, &#x60;include_evergreen_subscriptions&#x60;          &lt;/details&gt;</param>
        /// <param name="expand">Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://developer.zuora.com/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="filter">A case-sensitive filter on the list. See the [Filter lists](https://developer.zuora.com/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorial for detailed instructions.                         Note that the filters on this operation are only applicable to the related objects. For example, when you are calling the \&quot;Retrieve a billing document\&quot; operation, you can use the &#x60;filter[]&#x60; parameter on the related objects such as &#x60;filter[]&#x3D;items[accountId].EQ:8ad09e208858b5cf0188595208151c63&#x60;</param>
        /// <param name="pageSize">The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error.</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="zuoraEntityIds">An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <returns>BillRunPreview</returns>
        public BillRunPreview GetBillRunPreview(string billRunPreviewId, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'billRunPreviewId' is set
            if (billRunPreviewId == null) throw new ApiException(400, "Missing required parameter 'billRunPreviewId' when calling GetBillRunPreview");

            var path =$"v2/bill_run_previews/{billRunPreviewId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "bill_run_preview_id" + "}", _apiClient.ParameterToString(billRunPreviewId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;

            //// if (fields != null) queryParams.Add("fields[]", ApiClient.ParameterToString(fields)); // query parameter
            //// if (expand != null) queryParams.Add("expand[]", ApiClient.ParameterToString(expand)); // query parameter
            //// if (filter != null) queryParams.Add("filter[]", ApiClient.ParameterToString(filter)); // query parameter
            //// if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<BillRunPreview>(path, Method.Get, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetBillRunPreview: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetBillRunPreview: " + response.ErrorMessage, response.ErrorMessage);

            return (BillRunPreview)_apiClient.Deserialize(response.Content, typeof(BillRunPreview));
        }
    }
}