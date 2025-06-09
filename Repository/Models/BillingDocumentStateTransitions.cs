using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BillingDocumentStateTransitions
    {
        /// <summary>
        /// Gets or Sets CanceledTime
        /// </summary>
        [DataMember(Name = "canceled_time")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "canceled_time")]
        public string? CanceledTime { get; set; }

        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid? Id { get; set; }

        /// <summary>
        /// Gets or Sets PostedTime
        /// </summary>
        [DataMember(Name = "posted_time")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "posted_time")]
        public string? PostedTime { get; set; }

        
    }
}