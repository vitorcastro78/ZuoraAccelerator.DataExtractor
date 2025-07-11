using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;
using System;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    /// The prepayment information.
    /// </summary>
    [DataContract]
    public class SubscriptionItemPrepaymentField
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid? Id { get; set; }

        /// <summary>
        /// The number of units included in a prepayment charge.
        /// </summary>
        /// <value>The number of units included in a prepayment charge.</value>
        [DataMember(Name = "quantity")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "quantity")]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// The period in which the prepayment units are valid to use as defined in a prepayment charge.
        /// </summary>
        /// <value>The period in which the prepayment units are valid to use as defined in a prepayment charge.</value>
        [DataMember(Name = "validity_period")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "validity_period")]
        public Guid? ValidityPeriod { get; set; }

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
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionItemPrepaymentField {\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  ValidityPeriod: ").Append(ValidityPeriod).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}