using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;
using System;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    /// If the &#x60;type&#x60; of the payment method is &#x60;apple_pay&#x60;, this hash contains details about the Apple Pay payment method. See [Supported payment methods](https://knowledgecenter.zuora.com/Billing/Billing_and_Payments/L_Payment_Methods/A_Supported_Payment_Methods) for payment gateways that support this type of payment method.
    /// </summary>
    [DataContract]
    public class ApplePay
    {
        /// <summary>
        /// Credit card information. When providing a card number, you must meet the requirements for PCI compliance. We strongly recommend using Zuora.js instead of interacting with this API directly.
        /// </summary>
        /// <value>Credit card information. When providing a card number, you must meet the requirements for PCI compliance. We strongly recommend using Zuora.js instead of interacting with this API directly.</value>
        [DataMember(Name = "card")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "card")]
        public Card Card { get; set; }

        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid? Id { get; set; }

        /// <summary>
        /// Gets or Sets Mandate
        /// </summary>
        [DataMember(Name = "mandate")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mandate")]
        public Mandate Mandate { get; set; }

        /// <summary>
        /// The ID of newly processed payment. Only available in the response of the Create Payment Method API request.
        /// </summary>
        /// <value>The ID of newly processed payment. Only available in the response of the Create Payment Method API request.</value>
        [DataMember(Name = "payment_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_id")]
        public Guid? PaymentId { get; set; }

        /// <summary>
        /// A gateway unique identifier that replaces sensitive payment method data or represents a gateway's unique customer profile. When `token` is used to represent a customer profile, `second_token` is conditionally required for representing the underlying tokenized payment method.
        /// </summary>
        /// <value>A gateway unique identifier that replaces sensitive payment method data or represents a gateway's unique customer profile. When `token` is used to represent a customer profile, `second_token` is conditionally required for representing the underlying tokenized payment method.</value>
        [DataMember(Name = "token")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "token")]
        public string? Token { get; set; }

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
            sb.Append("class ApplePay {\n");
            sb.Append("  Card: ").Append(Card).Append("\n");
            sb.Append("  Mandate: ").Append(Mandate).Append("\n");
            sb.Append("  PaymentId: ").Append(PaymentId).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}