using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;
using System;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class PaymentsAppliedTo
    {
        /// <summary>
        /// The amount of the payment that is applied to the specific billing document item or taxation item.
        /// </summary>
        /// <value>The amount of the payment that is applied to the specific billing document item or taxation item.</value>
        [DataMember(Name = "amount")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// The related billing document.
        /// </summary>
        /// <value>The related billing document.</value>
        [DataMember(Name = "billing_document")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "billing_document")]
        public BillingDocument BillingDocument { get; set; }

        /// <summary>
        /// Identifier of an invoice or a debit memo.
        /// </summary>
        /// <value>Identifier of an invoice or a debit memo.</value>
        [DataMember(Name = "billing_document_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "billing_document_id")]
        public Guid BillingDocumentId { get; set; }

        /// <summary>
        /// The type of billing document. Can be one of the debit memo or invoice.
        /// </summary>
        /// <value>The type of billing document. Can be one of the debit memo or invoice.</value>
        [DataMember(Name = "billing_document_type")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "billing_document_type")]
        public string BillingDocumentType { get; set; }

        /// <summary>
        /// Identifier of the payment application.
        /// </summary>
        /// <value>Identifier of the payment application.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid Id { get; set; }

        /// <summary>
        /// The related billing document item.
        /// </summary>
        /// <value>The related billing document item.</value>
        [DataMember(Name = "items")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "items")]
        public List<BillingDocumentItem> Items { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state")]
        public string State { get; set; }

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
            sb.Append("class PaymentsAppliedToResponse {\n");
            sb.Append("  BillingDocumentId: ").Append(BillingDocumentId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BillingDocument: ").Append(BillingDocument).Append("\n");
            sb.Append("  BillingDocumentType: ").Append(BillingDocumentType).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}