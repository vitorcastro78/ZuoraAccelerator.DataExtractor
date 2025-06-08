using RestSharp;
using Service.Interfaces;
using Service.Client;
using Service.Models;
using EasyCaching.Core;

namespace Service
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PaymentRunsService : IPaymentRunsService
    {
        public readonly IApiClient _apiClient;

        private readonly List<string> expand;

        private List<string> filter;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactsService"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of _apiClient (optional)</param>
        /// <returns></returns>
        public PaymentRunsService(ApiClient apiClient)
        {
            _apiClient = apiClient;
            expand = new List<string>();
            filter = new List<string>();
        }


        /// <summary>
        /// Create a payment run Creates a payment run on a single account, or a batch of customer accounts.
        /// </summary>
        /// <param name="body"></param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="async">Making asynchronous requests allows you to scale your applications more efficiently by leveraging Zuora&#x27;s infrastructure to enqueue and execute requests for you without blocking. These requests also use built-in retry semantics, which makes them much less likely to fail for non-deterministic reasons, even in extreme high-throughput scenarios. Meanwhile, when you send a request to one of these endpoints, you can expect to receive a response in less than 150 milliseconds and these calls are unlikely to trigger rate limit errors. If set to true, Zuora returns a 202 Accepted response, and the response body contains only a request ID.</param>
        /// <param name="zuoraEntityIds">An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="fields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;batch&#x60;, &#x60;bill_cycle_day&#x60;, &#x60;target_date&#x60;, &#x60;payment_run_number&#x60;, &#x60;state&#x60;, &#x60;apply_credit_memos&#x60;, &#x60;apply_unapplied_payments&#x60;, &#x60;bill_run_id&#x60;, &#x60;collect_payment&#x60;, &#x60;consolidate_payment&#x60;, &#x60;payment_run_date&#x60;, &#x60;payment_gateway_id&#x60;, &#x60;state_transitions&#x60;          &lt;/details&gt;</param>
        /// <param name="summaryFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;number_of_unprocessed_receivables&#x60;, &#x60;number_of_errors&#x60;, &#x60;number_of_invoices&#x60;, &#x60;number_of_payments&#x60;, &#x60;number_of_credit_memos&#x60;, &#x60;number_of_debit_memos&#x60;, &#x60;number_of_unprocessed_debit_memos&#x60;, &#x60;number_of_unapplied_payments&#x60;, &#x60;errors_total&#x60;, &#x60;invoices_total&#x60;, &#x60;payments_total&#x60;, &#x60;unprocessed_receivables_total&#x60;          &lt;/details&gt;</param>
        /// <param name="expand">Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://developer.zuora.com/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="filter">A case-sensitive filter on the list. See the [Filter lists](https://developer.zuora.com/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorial for detailed instructions.                         Note that the filters on this operation are only applicable to the related objects. For example, when you are calling the \&quot;Retrieve a billing document\&quot; operation, you can use the &#x60;filter[]&#x60; parameter on the related objects such as &#x60;filter[]&#x3D;items[accountId].EQ:8ad09e208858b5cf0188595208151c63&#x60;</param>
        /// <param name="pageSize">The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error.</param>
        /// <returns>PaymentRun</returns>
        public PaymentRun CreatePaymentRuns(PaymentRunCreateRequest body, string zuoraTrackId, bool? async )
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreatePaymentRuns");

            var path =$"v2/payment_runs";
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
            RestResponse response = (RestResponse)_apiClient.CallApi<PaymentRun>(path, Method.Post, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CreatePaymentRuns: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CreatePaymentRuns: " + response.ErrorMessage, response.ErrorMessage);

            return (PaymentRun)_apiClient.Deserialize(response.Content, typeof(PaymentRun));
        }

        /// <summary>
        /// Delete a payment run Deletes a payment run. Only the payment runs with the &#x60;canceled&#x60; or &#x60;pending&#x60; status can be deleted.
        /// </summary>
        /// <param name="paymentRunId">Identifier for the payment run, either &#x60;payment_run_number&#x60; or &#x60;paymentRunId&#x60;</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="async">Making asynchronous requests allows you to scale your applications more efficiently by leveraging Zuora&#x27;s infrastructure to enqueue and execute requests for you without blocking. These requests also use built-in retry semantics, which makes them much less likely to fail for non-deterministic reasons, even in extreme high-throughput scenarios. Meanwhile, when you send a request to one of these endpoints, you can expect to receive a response in less than 150 milliseconds and these calls are unlikely to trigger rate limit errors. If set to true, Zuora returns a 202 Accepted response, and the response body contains only a request ID.</param>
        /// <param name="zuoraEntityIds">An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <returns></returns>
        public void DeletePaymentRuns(string paymentRunId, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'paymentRunId' is set
            if (paymentRunId == null) throw new ApiException(400, "Missing required parameter 'paymentRunId' when calling DeletePaymentRuns");

            var path =$"v2/payment_runs/{paymentRunId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "paymentRunId" + "}", _apiClient.ParameterToString(paymentRunId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;

            if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<PaymentRun>(path, Method.Delete, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling DeletePaymentRuns: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling DeletePaymentRuns: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }


        /// <summary>
        /// Retrieve a payment run Retrieves the payment run information with the given ID.
        /// </summary>
        /// <param name="paymentRunId">Identifier for the payment run, either &#x60;payment_run_number&#x60; or &#x60;paymentRunId&#x60;</param>
        /// <param name="fields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;batch&#x60;, &#x60;bill_cycle_day&#x60;, &#x60;target_date&#x60;, &#x60;payment_run_number&#x60;, &#x60;state&#x60;, &#x60;apply_credit_memos&#x60;, &#x60;apply_unapplied_payments&#x60;, &#x60;bill_run_id&#x60;, &#x60;collect_payment&#x60;, &#x60;consolidate_payment&#x60;, &#x60;payment_run_date&#x60;, &#x60;payment_gateway_id&#x60;, &#x60;state_transitions&#x60;          &lt;/details&gt;</param>
        /// <param name="summaryFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;number_of_unprocessed_receivables&#x60;, &#x60;number_of_errors&#x60;, &#x60;number_of_invoices&#x60;, &#x60;number_of_payments&#x60;, &#x60;number_of_credit_memos&#x60;, &#x60;number_of_debit_memos&#x60;, &#x60;number_of_unprocessed_debit_memos&#x60;, &#x60;number_of_unapplied_payments&#x60;, &#x60;errors_total&#x60;, &#x60;invoices_total&#x60;, &#x60;payments_total&#x60;, &#x60;unprocessed_receivables_total&#x60;          &lt;/details&gt;</param>
        /// <param name="expand">Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://developer.zuora.com/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="filter">A case-sensitive filter on the list. See the [Filter lists](https://developer.zuora.com/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorial for detailed instructions.                         Note that the filters on this operation are only applicable to the related objects. For example, when you are calling the \&quot;Retrieve a billing document\&quot; operation, you can use the &#x60;filter[]&#x60; parameter on the related objects such as &#x60;filter[]&#x3D;items[accountId].EQ:8ad09e208858b5cf0188595208151c63&#x60;</param>
        /// <param name="pageSize">The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error.</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="zuoraEntityIds">An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <returns>PaymentRun</returns>
        public PaymentRun GetPaymentRun(string paymentRunId, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'paymentRunId' is set
            if (paymentRunId == null) throw new ApiException(400, "Missing required parameter 'paymentRunId' when calling GetPaymentRun");

            var path =$"v2/payment_runs/{paymentRunId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "paymentRunId" + "}", _apiClient.ParameterToString(paymentRunId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;


            if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<PaymentRun>(path, Method.Get, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetPaymentRun: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetPaymentRun: " + response.ErrorMessage, response.ErrorMessage);

            return (PaymentRun)_apiClient.Deserialize(response.Content, typeof(PaymentRun));
        }

        /// <summary>
        /// List payment runs Returns an array of payment runs. Each entry in the array is a separate payment run object.       If no more payment runs are available, the resulting array will be empty. This request should never return an error.
        /// </summary>
        /// <param name="cursor">A cursor for use in pagination. A cursor defines the starting place in a list. For instance, if you make a list request and receive 100 objects, ending with &#x60;next_page&#x3D;W3sib3JkZXJ&#x3D;&#x60;, your subsequent call can include &#x60;cursor&#x3D;W3sib3JkZXJ&#x3D;&#x60; in order to fetch the next page of the list.</param>
        /// <param name="expand">Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://developer.zuora.com/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="filter">A case-sensitive filter on the list. See the [Filter lists](https://developer.zuora.com/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="sort">A case-sensitive query parameter that specifies the sort order of the list, which can be either ascending (e.g. &#x60;account_number.asc&#x60;) or descending (e.g. &#x60;account_number.desc&#x60;). You cannot sort on properties that are arrays. If the array-type properties are specified for the &#x60;sort[]&#x60; parameter, they are ignored.</param>
        /// <param name="pageSize">The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error.</param>
        /// <param name="fields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;batch&#x60;, &#x60;bill_cycle_day&#x60;, &#x60;target_date&#x60;, &#x60;payment_run_number&#x60;, &#x60;state&#x60;, &#x60;apply_credit_memos&#x60;, &#x60;apply_unapplied_payments&#x60;, &#x60;bill_run_id&#x60;, &#x60;collect_payment&#x60;, &#x60;consolidate_payment&#x60;, &#x60;payment_run_date&#x60;, &#x60;payment_gateway_id&#x60;, &#x60;state_transitions&#x60;          &lt;/details&gt;</param>
        /// <param name="summaryFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;number_of_unprocessed_receivables&#x60;, &#x60;number_of_errors&#x60;, &#x60;number_of_invoices&#x60;, &#x60;number_of_payments&#x60;, &#x60;number_of_credit_memos&#x60;, &#x60;number_of_debit_memos&#x60;, &#x60;number_of_unprocessed_debit_memos&#x60;, &#x60;number_of_unapplied_payments&#x60;, &#x60;errors_total&#x60;, &#x60;invoices_total&#x60;, &#x60;payments_total&#x60;, &#x60;unprocessed_receivables_total&#x60;          &lt;/details&gt;</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="zuoraEntityIds">An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <returns>PaymentRunListResponse</returns>
        public PaymentRunListResponse GetPaymentRuns(string zuoraTrackId, bool? async)
        {
            var path =$"v2/payment_runs";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;

            //if (cursor != null) queryParams.Add("cursor", _apiClient.ParameterToString(cursor)); // query parameter
            //if (expand != null) queryParams.Add("expand[]", ApiClient.ParameterToString(expand)); // query parameter
            //if (filter != null) queryParams.Add("filter[]", ApiClient.ParameterToString(filter)); // query parameter
            //if (sort != null) queryParams.Add("sort[]", ApiClient.ParameterToString(sort)); // query parameter
            //if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
            //if (fields != null) queryParams.Add("fields[]", ApiClient.ParameterToString(fields)); // query parameter
            //if (summaryFields != null) queryParams.Add("summary.fields[]", _apiClient.ParameterToString(summaryFields)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<PaymentRunListResponse>(path, Method.Get, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetPaymentRuns: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetPaymentRuns: " + response.ErrorMessage, response.ErrorMessage);

            return (PaymentRunListResponse)_apiClient.Deserialize(response.Content, typeof(PaymentRunListResponse));
        }

        

        /// <summary>
        /// Update a payment run Updates a payment run by setting the values of the specified fields. Any fields not provided in the request remain unchanged.
        /// </summary>
        /// <param name="body"></param>
        /// <param name="paymentRunId">Identifier for the payment run, either &#x60;payment_run_number&#x60; or &#x60;paymentRunId&#x60;</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="async">Making asynchronous requests allows you to scale your applications more efficiently by leveraging Zuora&#x27;s infrastructure to enqueue and execute requests for you without blocking. These requests also use built-in retry semantics, which makes them much less likely to fail for non-deterministic reasons, even in extreme high-throughput scenarios. Meanwhile, when you send a request to one of these endpoints, you can expect to receive a response in less than 150 milliseconds and these calls are unlikely to trigger rate limit errors. If set to true, Zuora returns a 202 Accepted response, and the response body contains only a request ID.</param>
        /// <param name="zuoraEntityIds">An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="fields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;batch&#x60;, &#x60;bill_cycle_day&#x60;, &#x60;target_date&#x60;, &#x60;payment_run_number&#x60;, &#x60;state&#x60;, &#x60;apply_credit_memos&#x60;, &#x60;apply_unapplied_payments&#x60;, &#x60;bill_run_id&#x60;, &#x60;collect_payment&#x60;, &#x60;consolidate_payment&#x60;, &#x60;payment_run_date&#x60;, &#x60;payment_gateway_id&#x60;, &#x60;state_transitions&#x60;          &lt;/details&gt;</param>
        /// <param name="summaryFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;number_of_unprocessed_receivables&#x60;, &#x60;number_of_errors&#x60;, &#x60;number_of_invoices&#x60;, &#x60;number_of_payments&#x60;, &#x60;number_of_credit_memos&#x60;, &#x60;number_of_debit_memos&#x60;, &#x60;number_of_unprocessed_debit_memos&#x60;, &#x60;number_of_unapplied_payments&#x60;, &#x60;errors_total&#x60;, &#x60;invoices_total&#x60;, &#x60;payments_total&#x60;, &#x60;unprocessed_receivables_total&#x60;          &lt;/details&gt;</param>
        /// <param name="expand">Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://developer.zuora.com/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="filter">A case-sensitive filter on the list. See the [Filter lists](https://developer.zuora.com/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorial for detailed instructions.                         Note that the filters on this operation are only applicable to the related objects. For example, when you are calling the \&quot;Retrieve a billing document\&quot; operation, you can use the &#x60;filter[]&#x60; parameter on the related objects such as &#x60;filter[]&#x3D;items[accountId].EQ:8ad09e208858b5cf0188595208151c63&#x60;</param>
        /// <param name="pageSize">The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error.</param>
        /// <returns>PaymentRun</returns>
        public PaymentRun UpdatePaymentRuns(PaymentRunPatchRequest body, string paymentRunId, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdatePaymentRuns");
            // verify the required parameter 'paymentRunId' is set
            if (paymentRunId == null) throw new ApiException(400, "Missing required parameter 'paymentRunId' when calling UpdatePaymentRuns");

            var path =$"v2/payment_runs/{paymentRunId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "paymentRunId" + "}", _apiClient.ParameterToString(paymentRunId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;

            //if (fields != null) queryParams.Add("fields[]", ApiClient.ParameterToString(fields)); // query parameter
            //if (summaryFields != null) queryParams.Add("summary.fields[]", _apiClient.ParameterToString(summaryFields)); // query parameter
            //if (expand != null) queryParams.Add("expand[]", ApiClient.ParameterToString(expand)); // query parameter
            //if (filter != null) queryParams.Add("filter[]", ApiClient.ParameterToString(filter)); // query parameter
            //if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            postBody = _apiClient.Serialize(body); // http body (model) parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<PaymentRun>(path, Method.Patch, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling UpdatePaymentRuns: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling UpdatePaymentRuns: " + response.ErrorMessage, response.ErrorMessage);

            return (PaymentRun)_apiClient.Deserialize(response.Content, typeof(PaymentRun));
        }

    }
}