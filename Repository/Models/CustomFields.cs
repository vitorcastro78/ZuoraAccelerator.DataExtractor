using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    /// Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.
    /// </summary>
    [DataContract]
    public class CustomFields : Dictionary<String, Object>
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