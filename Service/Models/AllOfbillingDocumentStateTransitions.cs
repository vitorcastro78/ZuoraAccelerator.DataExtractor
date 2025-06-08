using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class AllOfbillingDocumentStateTransitions
    {
        /// <summary>
        /// Gets or Sets CanceledTime
        /// </summary>
        [DataMember(Name = "canceled_time")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "canceled_time")]
        public string CanceledTime { get; set; }

        /// <summary>
        /// Gets or Sets PostedTime
        /// </summary>
        [DataMember(Name = "posted_time")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "posted_time")]
        public string PostedTime { get; set; }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AllOfbillingDocumentStateTransitions {\n");
            sb.Append("  PostedTime: ").Append(PostedTime).Append("\n");
            sb.Append("  CanceledTime: ").Append(CanceledTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}