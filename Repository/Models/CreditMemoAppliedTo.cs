using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class CreditMemoAppliedTo
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
        public Guid? BillingDocumentId { get; set; }

        /// <summary>
        /// The type of billing document. Can be one of the debit memo or invoice.
        /// </summary>
        /// <value>The type of billing document. Can be one of the debit memo or invoice.</value>
        [DataMember(Name = "billing_document_type")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "billing_document_type")]
        public string? BillingDocumentType { get; set; }

        /// <summary>
        /// Identifier of the credit memo application
        /// </summary>
        /// <value>Identifier of the credit memo application</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid? Id { get; set; }

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
       
    }
}