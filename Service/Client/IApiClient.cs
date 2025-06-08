

using RestSharp;

namespace Service.Client
{
    public interface IApiClient
    {
        /// <summary>
        /// Fill Persistent Table
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <param name="queryParams"></param>
        /// <param name="postBody"></param>
        void FillPersistentTable<T>(string path, Dictionary<string, string> queryParams, string postBody);
        
        /// <summary>
        /// Converts an object to a string representation for use in query parameters or headers.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        string ParameterToString(object obj);
        
        /// <summary>
        /// Deserializes a JSON string into a dynamic object of the specified type.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="type"></param>
        /// <param name="headers"></param>
        /// <returns></returns>
        public dynamic Deserialize(string content, Type type, IList<Parameter> headers = null);
        
        /// <summary>
        /// Serializes an object to a JSON string representation.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public string? Serialize(object obj);

        /// <summary>
        /// Calls the API with the specified parameters and returns a RestResponse.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pathRoute"></param>
        /// <param name="method"></param>
        /// <param name="queryParams"></param>
        /// <param name="postBody"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        public RestResponse CallApi<T>(string pathRoute, RestSharp.Method method, Dictionary<string, string>? queryParams, string postBody, bool? async = true);
    }
}