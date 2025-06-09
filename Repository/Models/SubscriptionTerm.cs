using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    /// Term information of the subscription.
    /// </summary>
    [DataContract]
    public class SubscriptionTerm
    {
        /// <summary>
        /// If true, the subscription automatically renews at the end of the current term.
        /// </summary>
        /// <value>If true, the subscription automatically renews at the end of the current term.</value>
        [DataMember(Name = "auto_renew")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "auto_renew")]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// Current term information for the subscription.
        /// </summary>
        /// <value>Current term information for the subscription.</value>
        [DataMember(Name = "current_term")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "current_term")]
        public Term CurrentTerm { get; set; }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid? Id { get; set; }

        /// <summary>
        /// Renewal term information for the subscription.
        /// </summary>
        /// <value>Renewal term information for the subscription.</value>
        [DataMember(Name = "renewal_term")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "renewal_term")]
        public Term RenewalTerm { get; set; }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string? ToJson()
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
            sb.Append("class SubscriptionTermPatchResponse {\n");
            sb.Append("  CurrentTerm: ").Append(CurrentTerm).Append("\n");
            sb.Append("  RenewalTerm: ").Append(RenewalTerm).Append("\n");
            sb.Append("  AutoRenew: ").Append(AutoRenew).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}