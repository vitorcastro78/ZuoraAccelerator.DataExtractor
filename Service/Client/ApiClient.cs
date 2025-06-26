using Auth0.ManagementApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Repository.DataContext;
using RestSharp;
using Service.Helper;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Web;
using ZIP2GO.Repository.Models;

namespace Service.Client
{
    /// <summary>
    /// API client is mainly responible for making the HTTP call to the API backend.
    /// </summary>
    public class ApiClient : IApiClient
    {
        private readonly IMemoryCache _cache;

        private readonly AppDataContext _context;

        private readonly Dictionary<string, string> _defaultHeaderMap = new Dictionary<string, string>();

        private readonly ILogger<ApiClient> _logger;

        private bool? _allowAsync;

        private ZuoraOptions _options;

        private string acceptEncoding;

        private string contentEncoding;

        private string idempotencyKey;

        private string zuoraEntityIds;

        private string zuoraTrackId;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiClient" /> class.
        /// </summary>
        /// <param name="basePath">The base path.</param>
        public ApiClient(ILogger<ApiClient> logger, IMemoryCache cache, AppDataContext context)
        {
            _cache = cache ?? throw new ArgumentNullException(nameof(cache));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _context = context ?? throw new ArgumentNullException(nameof(context));
            Counter = 0;
            using (StreamReader r = new StreamReader("config.json"))
            {
                _options = JsonConvert.DeserializeObject<ZuoraOptions>(r.ReadToEnd().ToString());

                zuoraTrackId = _options.ZuoraTrackId.ToString();
                BasePath = _options.BaseUrl;
                zuoraEntityIds = _options.ZuoraEntityId;
                idempotencyKey = _options.ZuoraIdempotencyKey;
                RestClient = new RestClient(BasePath);
            }
        }

        public int Counter { get; set; }

        public string BasePath { get; set; }

        public Dictionary<string, string> DefaultHeader
        {
            get { return _defaultHeaderMap; }
        }

        public RestClient RestClient { get; set; }

        public void AddDefaultHeader(string key, string value)
        {
            _defaultHeaderMap.Add(key, value);
        }

        public string AddExpandParameter(Dictionary<string, string> paramtrs)
        {
            var parameters = new List<string>();
            if (paramtrs.Where(f => f.Key.Contains("expand")).Any())
            {
                parameters = paramtrs
                .Where(f => f.Key.Contains("expand"))
                .Select(f => f.Value)
                .FirstOrDefault()
                .Split(",")
                .ToList();
            }

            var expand = new StringBuilder();

            if (parameters == null || parameters.Count == 0)
                return string.Empty;

            foreach (var item in parameters)
            {
                if (parameters.IndexOf(item) == (parameters.Count - 1))
                {
                    expand.Append($"expand%5B%5D={item}");
                }
                else
                {
                    expand.Append($"expand%5B%5D={item}&");
                }
            }

            return expand.ToString();
        }

        public string AddFilterParameter(Dictionary<string, string> paramtrs)
        {
            var parameters = new List<string>();
            if (paramtrs.Where(f => f.Key.Contains("filter")).Any())
            {
                parameters = paramtrs
                .Where(f => f.Key.Contains("filter"))
                .Select(f => f.Value)
                .FirstOrDefault()
                .Split(",")
                .ToList();
            }

            var expand = new StringBuilder();

            if (parameters == null || parameters.Count == 0)
                return string.Empty;

            foreach (var item in parameters)
            {
                if (parameters.IndexOf(item) == (parameters.Count - 1))
                {
                    expand.Append($"filter%5B%5D={item}");
                }
                else
                {
                    expand.Append($"filter%5B%5D={item}&");
                }
            }

            return expand.ToString();
        }

        /// <summary>
        /// Create FileParameter based on Stream.
        /// </summary>
        /// <param name="name">Parameter name.</param>
        /// <param name="stream">Input stream.</param>
        /// <returns>FileParameter.</returns>
        //public FileParameter ParameterToFile(string name, Stream stream, CancellationToken cancellationToken)
        //{
        //    if (stream is FileStream)
        //        return FileParameter.Create(name, stream.(), Path.GetFileName(((FileStream)stream).Name));
        //    else
        //        return FileParameter.Create(name, stream.ReadAllBytes(), "no_file_name_provided");
        //}
        public string AddPageSizeParameter(Dictionary<string, string> paramtrs)
        {
            var parameters = new List<string>();
            if (paramtrs.Where(f => f.Key.Contains("page_size")).Any())
            {
                parameters = paramtrs
                .Where(f => f.Key.Contains("page_size"))
                .Select(f => f.Value)
                .FirstOrDefault()
                .Split(",")
                .ToList();
            }

            //expand%5B%5D=account.bill_to&expand%5B%5D=account.sold_to&expand%5B%5D=subscription_plans.subscription_items
            var expand = new StringBuilder();

            if (parameters == null || parameters.Count == 0)
                return string.Empty;

            foreach (var item in parameters)
            {
                expand.Append($"page_size={item}");
            }

            return expand.ToString();
        }

        /// <summary>
        /// Add cursor parameter to the query string.
        /// </summary>
        /// <param name="paramtrs"></param>
        /// <returns></returns>
        public string AddCursorParameter(Dictionary<string, string> paramtrs)
        {
            var parameters = new List<string>();
            if (paramtrs.Where(f => f.Key.Contains("cursor")).Any())
            {
                parameters = paramtrs
                .Where(f => f.Key.Contains("cursor"))
                .Select(f => f.Value)
                .FirstOrDefault()
                .Split(",")
                .ToList();
            }

            //expand%5B%5D=account.bill_to&expand%5B%5D=account.sold_to&expand%5B%5D=subscription_plans.subscription_items
            var expand = new StringBuilder();

            if (parameters == null || parameters.Count == 0)
                return string.Empty;

            foreach (var item in parameters)
            {
                expand.Append($"cursor={item}");
            }

            return expand.ToString();
        }

        /// <summary>
        /// Encode string in base64 format.
        /// </summary>
        /// <param name="text">string to be encoded.</param>
        /// <returns>Encoded string.</returns>
        public string Base64Encode(string text)
        {
            var textByte = System.Text.Encoding.UTF8.GetBytes(text);
            return System.Convert.ToBase64String(textByte);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="queryParams"></param>
        /// <returns></returns>
        private string BuildParameters(Dictionary<string, string> queryParams)
        {
            string path = string.Empty;

            if (queryParams.Any())
            {
                path += "?";
            }
            if (queryParams.Where(f => f.Key.Contains("expand")).Any())
            {
                path += AddExpandParameter(queryParams);
            }
            if (queryParams.Where(f => f.Key.Contains("filter")).Any())
            {
                path += "&";
                path += AddFilterParameter(queryParams);
            }
            if (queryParams.Where(f => f.Key.Contains("page_size")).Any())
            {
                path += "&";
                path += AddPageSizeParameter(queryParams);
            }
            if (queryParams.Where(f => f.Key.Contains("cursor")).Any())
            {
                path += "&";
                path += AddCursorParameter(queryParams);
            }

            return path;
        }

        public RestResponse CallApi<T>(string pathRoute, RestSharp.Method method, Dictionary<string, string>? queryParams, string postBody, bool? async = true)
        {
            var path = pathRoute;
            path += BuildParameters(queryParams);
            var headerParams = new Dictionary<string, string>();
            var request = new RestRequest(path, method);
            var response = new Object();

            var token = this.GetToken();

            if (!string.IsNullOrEmpty(_options.ZuoraTrackId.ToString()))
                headerParams.Add("zuora-track-id", _options.ZuoraTrackId.ToString());
            if (!string.IsNullOrEmpty(_options.ZuoraEntityId))
                headerParams.Add("zuora-entity-ids", _options.ZuoraEntityId);
            if (!string.IsNullOrEmpty(token))
                headerParams.Add("Authorization", "Bearer " + token);

            if (method == Method.Patch || method == Method.Post)
            {
                if (!string.IsNullOrEmpty(_options.ZuoraIdempotencyKey))
                    headerParams.Add("idempotency-key", _options.ZuoraIdempotencyKey); // header parameter
            }

            foreach (var defaultHeader in _defaultHeaderMap)
                request.AddHeader(defaultHeader.Key, defaultHeader.Value);

            foreach (var param in headerParams)
                request.AddHeader(param.Key, param.Value);

            //foreach (var param in queryParams)
            //    request.AddParameter(param.Key, param.Value, ParameterType.GetOrPost);

            if (postBody != null) // http body (model) parameter
                request.AddParameter("application/json", postBody, ParameterType.RequestBody);

            var result = RestClient.Execute(request);

            if (method != Method.Get && result.IsSuccessful)
            {
                var ret = Deserialize(result.Content, typeof(T));
                var newPath = $"{GetRoute(result.ResponseUri)}/{ret.Id}";
                result = CallApi<T>(newPath, Method.Get, queryParams, postBody, async);
                ret = Deserialize(result.Content, typeof(T));
                return ret;
            }
            else
            {
                return result;
            }
        }

        /// <summary>
        /// Dynamically cast the object into target type.
        /// </summary>
        /// <param name="fromObject">Object to be casted</param>
        /// <param name="toObject">Target type</param>
        /// <returns>Casted object</returns>
        private Object ConvertType(Object fromObject, Type toObject)
        {
            return Convert.ChangeType(fromObject, toObject);
        }

        /// <summary>
        /// Deserialize the JSON strireturn _apiClient.ExecuteRequest<ProductListResponse>(path, queryParams, postBody);ng into a proper object.
        /// </summary>
        /// <param name="content">HTTP body (e.g. string, JSON).</param>
        /// <param name="type">Object type.</param>
        /// <param name="headers">HTTP headers.</param>
        /// <returns>Object representation of the JSON string.</returns>
        public dynamic Deserialize(string content, Type type, IList<Parameter> headers = null)
        {
            if (type == typeof(Object)) // return an object
            {
                return content;
            }

            if (type == typeof(Stream))
            {
                var filePath = string.IsNullOrEmpty(Configuration.TempFolderPath)
                    ? Path.GetTempPath()
                    : Configuration.TempFolderPath;

                var fileName = filePath + Guid.NewGuid();
                if (headers != null)
                {
                    var regex = new Regex(@"Content-Disposition:.*filename=['""]?([^'""\s]+)['""]?$");
                    var match = regex.Match(headers.ToString());
                    if (match.Success)
                        fileName = filePath + match.Value.Replace("\"", "").Replace("'", "");
                }
                File.WriteAllText(fileName, content);
                return new FileStream(fileName, FileMode.Open);
            }

            if (type.Name.StartsWith("System.Nullable`1[[System.DateTime")) // return a datetime object
            {
                return DateTime.Parse(content, null, System.Globalization.DateTimeStyles.RoundtripKind);
            }

            if (type == typeof(string) || type.Name.StartsWith("System.Nullable")) // return primitive type
            {
                return ConvertType(content, type);
            }

            // at this point, it must be a model (json)



            try
            {
                return JsonConvert.DeserializeObject(content, type);
            }
            catch (IOException e)
            {
                throw new ApiException(500, e.Message);
            }
        }

        /// <summary>
        /// Escape string (url-encoded).
        /// </summary>
        /// <param name="str">string to be escaped.</param>
        /// <returns>Escaped string.</returns>
        private string EscapeString(string str)
        {
            return HttpUtility.UrlEncode(str);
        }

        public void FillPersistentTable<T>(string path, Dictionary<string, string> queryParams, string postBody)
        {
            queryParams.Add("page_size", ParameterToString(95));
            int counter = 0;

            var response = (RestResponse)CallApi<T>(path, Method.Get, queryParams, postBody);
            var responseObject = (dynamic)Deserialize(response.Content, typeof(T));
            var nextPage = responseObject.NextPage;

            FillDataBase(responseObject, out counter);

            if (response.IsSuccessful && !string.IsNullOrEmpty(responseObject.NextPage))
            {
                queryParams.Add("cursor", ParameterToString(responseObject.NextPage));

                while (!string.IsNullOrEmpty(nextPage))
                {
                    // query parameter
                    queryParams["cursor"] = nextPage;
                    response = (RestResponse)CallApi<T>(path, Method.Get, queryParams, postBody);
                    var contentResponse = Deserialize(response.Content, typeof(T));
                    FillDataBase(contentResponse, out counter);
                    nextPage = contentResponse.NextPage;
                }
                Counter += counter;
                _logger.LogInformation($"Total items processed: {Counter} for {typeof(T).Name}");
            }
            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, $"Error calling {path}: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, $"Error calling {path}: " + response.ErrorMessage, response.ErrorMessage);
        }

        public T ExecuteRequest<T>(string path, Dictionary<string, string> queryParams, string postBody)
        {
            queryParams.Add("page_size", ParameterToString(95));

            var response = (RestResponse)CallApi<T>(path, Method.Get, queryParams, postBody);
            var responseObject = (dynamic)Deserialize(response.Content, typeof(T));

            if (response.IsSuccessful && !string.IsNullOrEmpty(responseObject.NextPage))
            {
                queryParams.Add("cursor", ParameterToString(responseObject.NextPage));
                int counter = 0;
                while (!string.IsNullOrEmpty(responseObject.NextPage))
                {
                    // query parameter
                    queryParams["cursor"] = responseObject.NextPage;
                    response = (RestResponse)CallApi<T>(path, Method.Get, queryParams, postBody);
                    var contentResponse = (dynamic)Deserialize(response.Content, typeof(T));
                    responseObject.Data.AddRange(contentResponse.Data);
                    responseObject.NextPage = contentResponse.NextPage;
                    FillDataBase(contentResponse, out counter);

                }

                Counter += counter;

                _logger.LogInformation($"Total items processed: {Counter} for {typeof(T).Name}");
            }
            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, $"Error calling {path}: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, $"Error calling {path}: " + response.ErrorMessage, response.ErrorMessage);

            return responseObject;
        }

        public void ExecuteRequest<T>(string path, Dictionary<string, string> queryParams, string postBody, bool NoResponse)
        {
            queryParams.Add("page_size", ParameterToString(95));

            var response = (RestResponse)CallApi<T>(path, Method.Get, queryParams, postBody);
            var responseObject = (dynamic)Deserialize(response.Content, typeof(T));

            if (response.IsSuccessful && !string.IsNullOrEmpty(responseObject.NextPage))
            {
                queryParams.Add("cursor", ParameterToString(responseObject.NextPage));
                int counter = 0;
                while (!string.IsNullOrEmpty(responseObject.NextPage))
                {
                    // query parameter
                    queryParams["cursor"] = responseObject.NextPage;
                    response = (RestResponse)CallApi<T>(path, Method.Get, queryParams, postBody);
                    var contentResponse = (dynamic)Deserialize(response.Content, typeof(T));
                    FillDataBase(contentResponse, out counter);
                    responseObject.NextPage = contentResponse.NextPage;
                }

                Counter += counter;

                _logger.LogInformation($"Total items processed: {Counter} for {typeof(T).Name}");
            }
            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetAccounts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetAccounts: " + response.ErrorMessage, response.ErrorMessage);
        }

        /// <summary>
        /// Get the API key with prefix.
        /// </summary>
        /// <param name="apiKeyIdentifier">API key identifier (authentication scheme).</param>
        /// <returns>API key with prefix.</returns>
        public string GetApiKeyWithPrefix(string apiKeyIdentifier)
        {
            var apiKeyValue = "";
            Configuration.ApiKey.TryGetValue(apiKeyIdentifier, out apiKeyValue);
            var apiKeyPrefix = "";
            if (Configuration.ApiKeyPrefix.TryGetValue(apiKeyIdentifier, out apiKeyPrefix))
                return apiKeyPrefix + " " + apiKeyValue;
            else
                return apiKeyValue;
        }

        public string GetToken()
        {
            var token = new ZuoraToken();

            if (_cache != null && _cache.TryGetValue("ZuoraToken", out token))
            {
                token = _cache.Get<ZuoraToken>("ZuoraToken");
            }
            if (token != null && DateTime.UtcNow < token.ExpiresAt?.AddSeconds(-60))
            {
                return token.Access_token;
            }

            var nameValueCollection = new Dictionary<string, string>
                {
                    { "grant_type", "client_credentials" },
                    { "client_id", _options.ClientID },
                    { "client_secret", _options.ClientSecret }
                };

            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(_options.BaseUrl);
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


            var result = httpClient.PostAsync($"{_options.BaseUrl}oauth/token", new FormUrlEncodedContent(nameValueCollection)).Result;
            if (!result.IsSuccessStatusCode)
            {
                var errorMessage = result.Content.ReadAsStringAsync().Result;
                if (result.Headers.TryGetValues("zuora-request-id", out var values))
                {
                    errorMessage += $" Zuora-Request-Id: {string.Join(',', values)}";
                }

                throw new InvalidOperationException($"Get Zuora token failed. Details: {errorMessage}");
            }

            token = JsonConvert.DeserializeObject<ZuoraToken>(result.Content.ReadAsStringAsync().Result);
            token.ExpiresAt = DateTime.UtcNow.AddSeconds(token.Expires_in <= 0 ? 900 : token.Expires_in);
            _cache.Set("ZuoraToken", token, TimeSpan.FromSeconds(token.Expires_in <= 0 ? 900 : token.Expires_in)
            );

            return token.Access_token;
        }

        /// <summary>
        /// If parameter is DateTime, output in a formatted string (default ISO 8601), customizable with Configuration.DateTime.
        /// If parameter is a list of string, join the list with ",".
        /// Otherwise just return the string.
        /// </summary>
        /// <param name="obj">The parameter (header, path, query, form).</param>
        /// <returns>Formatted string.</returns>
        public string ParameterToString(object obj)
        {
            if (obj is DateTime)
                // Return a formatted date string - Can be customized with Configuration.DateTimeFormat
                // Defaults to an ISO 8601, using the known as a Round-trip date/time pattern ("o")
                // https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8
                // For example: 2009-06-15T13:45:30.0000000
                return ((DateTime)obj).ToString(Configuration.DateTimeFormat);
            else if (obj is List<string>)
                return string.Join(",", (obj as List<string>).ToArray());
            else
                return Convert.ToString(obj);
        }

        /// <summary>
        /// Serialize an object into JSON string.
        /// </summary>
        /// <param name="obj">Object.</param>
        /// <returns>JSON string.</returns>
        public string? Serialize(object obj)
        {
            try
            {
                return obj != null ? JsonConvert.SerializeObject(obj) : null;
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
        }

        /// <summary>
        /// Update parameters based on authentication.
        /// </summary>
        /// <param name="queryParams">Query parameters.</param>
        /// <param name="headerParams">Header parameters.</param>
        /// <param name="authSettings">Authentication settings.</param>
        public void UpdateParamsForAuth(Dictionary<string, string> queryParams, Dictionary<string, string> headerParams, string[] authSettings)
        {
            if (authSettings == null || authSettings.Length == 0)
                return;

            foreach (string auth in authSettings)
            {
                // determine which one to use
                switch (auth)
                {
                    case "bearerAuth":

                        break;

                    default:
                        //TODO show warning about security definition not found
                        break;
                }
            }
        }
        private void FillDataBase(dynamic resultData, out int counter)
        {
            if (resultData.Data != null)
            {
            
                foreach (var item in resultData.Data)
                {
                    dynamic mapped = null;
                    dynamic result = null;
                    var propriedadeDbSet = _context.GetType()
                            .GetProperties()
                            .FirstOrDefault(p => p.Name.Equals(item.GetType().Name, StringComparison.OrdinalIgnoreCase) && 
                            p.PropertyType.IsGenericType &&
                            p.PropertyType.GetGenericTypeDefinition() == typeof(DbSet<>));

                    switch (item.GetType().Name)
                    {
                        case "Account":

                            mapped = ObjectMapper.MapTo<Account>(item);
                            result = _context.Account.Find(mapped.Id);

                            if (result != null)
                            {
                                _context.Account.Update(result);
                            }
                            else
                            {
                                _context.Account.Add(mapped);
                            }

                            break;
                        case "Address":

                            mapped = ObjectMapper.MapTo<Address>(item);
                            result = _context.Address.Find(mapped.Id);

                            if (result != null)
                            {
                                _context.Address.Update(result);
                            }
                            else
                            {
                                _context.Address.Add(mapped);
                            }

                            break;
                        case "BillingDocumentItem":

                            mapped = ObjectMapper.MapTo<BillingDocumentItem>(item);
                            result = _context.BillingDocumentItem.Find(mapped.Id);

                            if (result != null)
                            {
                                _context.BillingDocumentItem.Update(result);
                            }
                            else
                            {
                                _context.BillingDocumentItem.Add(mapped);
                            }

                            break;
                        case "BillingDocument":
                            mapped = ObjectMapper.MapTo<BillingDocument>(item);
                            result = _context.BillingDocument.Find(mapped.Id);

                            if (result != null)
                            {
                                _context.BillingDocument.Update(result);
                            }
                            else
                            {
                                _context.BillingDocument.Add(mapped);
                            }
                            break;
                        case "Contact":
                            mapped = ObjectMapper.MapTo<Contact>(item);
                            result = _context.Contact.Find(mapped.Id);
                            if (result != null)
                            {
                                _context.Contact.Update(result);
                            }
                            else
                            {
                                _context.Contact.Add(mapped);
                            }
                            break;
                        case "Invoice":
                            mapped = ObjectMapper.MapTo<Invoice>(item);
                            result = _context.Invoice.Find(mapped.Id);

                            if (result != null)
                            {
                                _context.Invoice.Update(result);
                            }
                            else
                            {
                                _context.Invoice.Add(mapped);
                            }
                            break;
                        case "InvoiceItem":
                            mapped = ObjectMapper.MapTo<InvoiceItem>(item);
                            result = _context.InvoiceItem.Find(mapped.Id);

                            if (result != null)
                            {
                                _context.InvoiceItem.Update(result);
                            }
                            else
                            {
                                _context.InvoiceItem.Add(mapped);
                            }
                            break;
                        case "CreditMemo":
                            mapped = ObjectMapper.MapTo<CreditMemo>(item);
                            result = _context.CreditMemo.Find(mapped.Id);

                            if (result != null)
                            {
                                _context.CreditMemo.Update(result);
                            }
                            else
                            {
                                _context.CreditMemo.Add(mapped);
                            }
                            break;
                        case "CreditMemoItem":
                            mapped = ObjectMapper.MapTo<CreditMemoItem>(item);
                            result = _context.CreditMemoItem.Find(mapped.Id);

                            if (result != null)
                            {
                                _context.CreditMemoItem.Update(result);
                            }
                            else
                            {
                                _context.CreditMemoItem.Add(mapped);
                            }
                            break;
                        case "DebitMemo":
                            mapped = ObjectMapper.MapTo<DebitMemo>(item);
                            result = _context.DebitMemo.Find(mapped.Id);

                            if (result != null)
                            {
                                _context.DebitMemo.Update(result);
                            }
                            else
                            {
                                _context.DebitMemo.Add(mapped);
                            }
                            break;
                        case "DebitMemoItem":
                            mapped = ObjectMapper.MapTo<DebitMemoItem>(item);
                            result = _context.DebitMemoItem.Find(mapped.Id);

                            if (result != null)
                            {
                                _context.DebitMemoItem.Update(result);
                            }
                            else
                            {
                                _context.DebitMemoItem.Add(mapped);
                            }
                            break;
                        case "Payment":
                            mapped = ObjectMapper.MapTo<Payment>(item);
                            result = _context.Payment.Find(mapped.Id);

                            if (result != null)
                            {
                                _context.Payment.Update(result);
                            }
                            else
                            {
                                _context.Payment.Add(mapped);
                            }
                            break;
                        case "PaymentMethod":
                            mapped = ObjectMapper.MapTo<PaymentMethod>(item);
                            result = _context.PaymentMethod.Find(mapped.Id);

                            if (result != null)
                            {
                                _context.PaymentMethod.Update(result);
                            }
                            else
                            {
                                _context.PaymentMethod.Add(mapped);
                            }
                            break;
                        case "Refund":
                            mapped = ObjectMapper.MapTo<Refund>(item);
                            result = _context.Refund.Find(mapped.Id);

                            if (result != null)
                            {
                                _context.Refund.Update(result);
                            }
                            else
                            {
                                _context.Refund.Add(mapped);
                            }
                            break;
                        case "Subscription":
                            mapped = ObjectMapper.MapTo<Subscription>(item);
                            result = _context.Subscription.Find(mapped.Id);

                            if (result != null)
                            {
                                _context.Subscription.Update(result);
                            }
                            else
                            {
                                _context.Subscription.Add(mapped);
                            }
                            break;
                        case "SubscriptionAddPlan":
                            mapped = ObjectMapper.MapTo<SubscriptionAddPlan>(item);
                            result = _context.SubscriptionAddPlan.Find(mapped.Id);

                            if (result != null)
                            {
                                _context.SubscriptionAddPlan.Update(result);
                            }
                            else
                            {
                                _context.SubscriptionAddPlan.Add(mapped);
                            }
                            break;
                        case "SubscriptionCancel":
                            mapped = ObjectMapper.MapTo<SubscriptionCancel>(item);
                            result = _context.SubscriptionCancel.Find(mapped.Id);

                            if (result != null)
                            {
                                _context.SubscriptionCancel.Update(result);
                            }
                            else
                            {
                                _context.SubscriptionCancel.Add(mapped);
                            }
                            break;
                        case "SubscriptionItem":
                            mapped = ObjectMapper.MapTo<SubscriptionItem>(item);
                            result = _context.SubscriptionItem.Find(mapped.Id);

                            if (result != null)
                            {
                                _context.SubscriptionItem.Update(result);
                            }
                            else
                            {
                                _context.SubscriptionItem.Add(mapped);
                            }
                            break;
                        case "SubscriptionPause":
                            mapped = ObjectMapper.MapTo<SubscriptionPause>(item);
                            result = _context.SubscriptionPause.Find(mapped.Id);

                            if (result != null)
                            {
                                _context.SubscriptionPause.Update(result);
                            }
                            else
                            {
                                _context.SubscriptionPause.Add(mapped);
                            }
                            break;
                        case "SubscriptionPlan":
                            mapped = ObjectMapper.MapTo<SubscriptionPlan>(item);
                            result = _context.SubscriptionPlan.Find(mapped.Id);

                            if (result != null)
                            {
                                _context.SubscriptionPlan.Update(result);
                            }
                            else
                            {
                                _context.SubscriptionPlan.Add(mapped);
                            }
                            break;
                        case "SubscriptionRemovePlan":
                            mapped = ObjectMapper.MapTo<SubscriptionRemovePlan>(item);
                            result = _context.SubscriptionRemovePlan.Find(mapped.Id);

                            if (result != null)
                            {
                                _context.SubscriptionRemovePlan.Update(result);
                            }
                            else
                            {
                                _context.SubscriptionRemovePlan.Add(mapped);
                            }
                            break;
                        case "SubscriptionRenew":
                            mapped = ObjectMapper.MapTo<SubscriptionRenew>(item);
                            result = _context.SubscriptionRenew.Find(mapped.Id);

                            if (result != null)
                            {
                                _context.SubscriptionRenew.Update(result);
                            }
                            else
                            {
                                _context.SubscriptionRenew.Add(mapped);
                            }
                            break;
                        case "SubscriptionTerm":
                            mapped = ObjectMapper.MapTo<SubscriptionTerm>(item);
                            result = _context.SubscriptionTerm.Find(mapped.Id);

                            if (result != null)
                            {
                                _context.SubscriptionTerm.Update(result);
                            }
                            else
                            {
                                _context.SubscriptionTerm.Add(mapped);
                            }
                            break;
                        case "TaxCertificate":
                            mapped = ObjectMapper.MapTo<TaxCertificate>(item);
                            result = _context.TaxCertificate.Find(mapped.Id);

                            if (result != null)
                            {
                                _context.TaxCertificate.Update(result);
                            }
                            else
                            {
                                _context.TaxCertificate.Add(mapped);
                            }
                            break;
                        case "TaxIdentifier":
                            mapped = ObjectMapper.MapTo<TaxIdentifier>(item);
                            result = _context.TaxIdentifier.Find(mapped.Id);

                            if (result != null)
                            {
                                _context.TaxIdentifier.Update(result);
                            }
                            else
                            {
                                _context.TaxIdentifier.Add(mapped);
                            }
                            break;
                        case "TaxationItem":
                            mapped = ObjectMapper.MapTo<TaxationItem>(item);
                            result = _context.TaxationItem.Find(mapped.Id);

                            if (result != null)
                            {
                                _context.TaxationItem.Update(result);
                            }
                            else
                            {
                                _context.TaxationItem.Add(mapped);
                            }
                            break;
                        case "Product":
                            mapped = ObjectMapper.MapTo<Product>(item);
                            result = _context.Product.Find(mapped.Id);

                            if (result != null)
                            {
                                _context.Product.Update(result);
                            }
                            else
                            {
                                _context.Product.Add(mapped);
                            }
                            break;
                        case "Plan":
                            mapped = ObjectMapper.MapTo<Plan>(item);
                            result = _context.Plan.Find(mapped.Id);

                            if (result != null)
                            {
                                _context.Plan.Update(result);
                            }
                            else
                            {
                                _context.Plan.Add(mapped);
                            }
                            break;
                        case "Price":
                            mapped = ObjectMapper.MapTo<Price>(item);
                            result = _context.Price.Find(mapped.Id);

                            if (result != null)
                            {
                                _context.Price.Update(result);
                            }
                            else
                            {
                                _context.Price.Add(mapped);
                            }
                            break;
                        case "ProductPrice":
                            mapped = ObjectMapper.MapTo<ProductPrice>(item);
                            result = _context.ProductPrice.Find(mapped.Id);

                            if (result != null)
                            {
                                _context.ProductPrice.Update(result);
                            }
                            else
                            {
                                _context.ProductPrice.Add(mapped);
                            }
                            break;
                        case "ProductPlan":
                            mapped = ObjectMapper.MapTo<ProductPlan>(item);
                            result = _context.ProductPlan.Find(mapped.Id);

                            if (result != null)
                            {
                                _context.ProductPlan.Update(result);
                            }
                            else
                            {
                                _context.ProductPlan.Add(mapped);
                            }
                            break;
                        case "ProductTier":
                            mapped = ObjectMapper.MapTo<ProductTier>(item);
                            result = _context.ProductTier.Find(mapped.Id);

                            if (result != null)
                            {
                                _context.ProductTier.Update(result);
                            }
                            else
                            {
                                _context.ProductTier.Add(mapped);
                            }
                            break;
                        case "Tier":
                            mapped = ObjectMapper.MapTo<Tier>(item);
                            result = _context.Tier.Find(mapped.Id);

                            if (result != null)
                            {
                                _context.Tier.Update(result);
                            }
                            else
                            {
                                _context.Tier.Add(mapped);
                            }
                            break;
                        case "Order":
                            mapped = ObjectMapper.MapTo<Order>(item);
                            result = _context.Order.Find(mapped.Id);

                            if (result != null)
                            {
                                _context.Order.Update(result);
                            }
                            else
                            {
                                _context.Order.Add(mapped);
                            }
                            break;

                       
                        default:
                            break;
                    }

                    Counter++;
                }
                _context.SaveChanges();
            }
            else
            {
                Console.WriteLine($"No data found for {resultData.GetType().Name}");
            }
            counter = Counter;
        }
        private string GetRoute(Uri url)
        {
            Uri uri = url;
            string routeWithoutId = string.Empty;
            string path = uri.AbsolutePath;
            string[] segments = path.Split('/', StringSplitOptions.RemoveEmptyEntries);

            // Remove o último segmento (que seria o ID)
            if (segments.Length > 0)
            {
                // Junta todos os segmentos exceto o último
                routeWithoutId = "/" + string.Join("/", segments.Take(segments.Length - 1));
            }
            return routeWithoutId;
        }
        private object InserirEntidadeDinamica(string nomeTabela, object entidade)
        {
            var propriedadeDbSet = _context.GetType()
                .GetProperties()
                .FirstOrDefault(p => p.Name.Equals(nomeTabela, StringComparison.OrdinalIgnoreCase) &&
                               p.PropertyType.IsGenericType &&
                               p.PropertyType.GetGenericTypeDefinition() == typeof(DbSet<>));

            if (propriedadeDbSet == null)
                throw new ArgumentException($"DbSet '{nomeTabela}' não encontrado");

            var dbSet = propriedadeDbSet.GetValue(_context);
            var addMethod = dbSet.GetType().GetMethod("Add");

            var entry = addMethod.Invoke(dbSet, new[] { entidade });
            _context.SaveChanges();

            return entry;
        }

    }

    public static class ObjectMapper
    {
        public static T MapTo<T>(object source) where T : new()
        {
            if (source == null) return default(T);

            var destination = new T();
            MapValues(source, destination);
            return destination;
        }

        public static void MapTo<T>(object source, T destination)
        {
            if (source == null || destination == null) return;
            MapValues(source, destination);
        }

        private static void MapValues(object source, object destination)
        {
            var sourceType = source.GetType();
            var destinationType = destination.GetType();

            var sourceProperties = sourceType.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(p => p.CanRead);

            var destinationProperties = destinationType.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(p => p.CanWrite)
                .ToDictionary(p => p.Name, p => p);

            foreach (var sourceProp in sourceProperties)
            {
                if (destinationProperties.TryGetValue(sourceProp.Name, out var destProp))
                {
                    if (sourceProp.Name.Contains("Id"))
                    {
                        // If the property is an ID, we can skip the mapping if the value is null
                        var value = sourceProp.GetValue(source);
                        var guidId = new Guid();
                        if (value != null && Guid.TryParse(value.ToString(), out guidId))
                        {
                            //var convertedValue = ConvertValue(value, destProp.PropertyType);
                            destProp.SetValue(destination, guidId);
                        }
                    }

                    if (IsCompatibleType(sourceProp.PropertyType, destProp.PropertyType))
                    {
                        var value = sourceProp.GetValue(source);
                        if (value != null)
                        {
                            var convertedValue = ConvertValue(value, destProp.PropertyType);
                            destProp.SetValue(destination, convertedValue);
                        }
                    }
                }
            }
        }

        private static bool IsCompatibleType(Type sourceType, Type targetType)
        {
            if (sourceType == targetType) return true;
            if (targetType.IsAssignableFrom(sourceType)) return true;

            // Verificar tipos nullable
            var targetUnderlyingType = Nullable.GetUnderlyingType(targetType);
            var sourceUnderlyingType = Nullable.GetUnderlyingType(sourceType);

            if (targetUnderlyingType != null && sourceUnderlyingType != null)
                return targetUnderlyingType == sourceUnderlyingType;

            if (targetUnderlyingType != null)
                return targetUnderlyingType == sourceType;

            if (sourceUnderlyingType != null)
                return sourceUnderlyingType == targetType;

            return false;
        }

        private static object ConvertValue(object value, Type targetType)
        {
            if (value == null) return null;

            var targetUnderlyingType = Nullable.GetUnderlyingType(targetType) ?? targetType;

            if (targetUnderlyingType == value.GetType())
                return value;

            try
            {
                return Convert.ChangeType(value, targetUnderlyingType);
            }
            catch
            {
                return value;
            }
        }
    }

}
