using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    /// The custom object data.
    /// </summary>
    [DataContract]
    public class CustomObject : Dictionary<String, Object>
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid? Id { get; set; }

        
    }
}