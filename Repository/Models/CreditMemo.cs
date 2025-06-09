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
    public class CreditMemo
    {
        /// <summary>
        /// The account that owns the billing document. EXPANDABLE
        /// </summary>
        /// <value>The account that owns the billing document. EXPANDABLE</value>
        [DataMember(Name = "account")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account")]
        public Account Account { get; set; }

        /// <summary>
        /// Identifier of the account that owns the credit memo.     **Either this field or `account_number` is required when creating credit memos from a price(charge in the v1 API).**
        /// </summary>
        /// <value>Identifier of the account that owns the credit memo.     **Either this field or `account_number` is required when creating credit memos from a price(charge in the v1 API).**</value>
        [DataMember(Name = "account_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account_id")]
        public Guid? AccountId { get; set; }

        /// <summary>
        /// Human-readable identifier of the account that owns the credit memo.    **Either this field or `account_id` is required when creating credit memos from a price(charge in the v1 API).**
        /// </summary>
        /// <value>Human-readable identifier of the account that owns the credit memo.    **Either this field or `account_id` is required when creating credit memos from a price(charge in the v1 API).**</value>
        [DataMember(Name = "account_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account_number")]
        public string? AccountNumber { get; set; }

        /// <summary>
        /// The amount this billing document refunded.
        /// </summary>
        /// <value>The amount this billing document refunded.</value>
        [DataMember(Name = "amount_refunded")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount_refunded")]
        public decimal? AmountRefunded { get; set; }

        /// <summary>
        /// Gets or Sets AppliedTo
        /// </summary>
        [DataMember(Name = "applied_to")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "applied_to")]
        public List<CreditMemo> AppliedTo { get; set; }

        /// <summary>
        /// The total balance remaining.  This field is deprecated. Use `remaining_balance` field.
        /// </summary>
        /// <value>The total balance remaining.  This field is deprecated. Use `remaining_balance` field.</value>
        [DataMember(Name = "balance")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "balance")]
        public decimal? Balance { get; set; }

        /// <summary>
        /// The billing document settings for the customer.
        /// </summary>
        /// <value>The billing document settings for the customer.</value>
        [DataMember(Name = "billing_document_settings")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "billing_document_settings")]
        public List<BillingDocumentSettings> BillingDocumentSettings { get; set; }

        /// <summary>
        /// The billing address for the customer.
        /// </summary>
        /// <value>The billing address for the customer.</value>
        [DataMember(Name = "bill_to")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bill_to")]
        public Contact BillTo { get; set; }

        /// <summary>
        /// ID of the bill-to contact.
        /// </summary>
        /// <value>ID of the bill-to contact.</value>
        [DataMember(Name = "bill_to_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bill_to_id")]
        public Guid? BillToId { get; set; }

        /// <summary>
        /// Unique identifier of the Zuora user who created the object
        /// </summary>
        /// <value>Unique identifier of the Zuora user who created the object</value>
        [DataMember(Name = "created_by_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "created_by_id")]
        public Guid? CreatedById { get; set; }

        /// <summary>
        /// The date and time when the object was created in ISO 8601 UTC format.
        /// </summary>
        /// <value>The date and time when the object was created in ISO 8601 UTC format.</value>
        [DataMember(Name = "created_time")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "created_time")]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// A human-readable identifier for the billing document; may be user-supplied.
        /// </summary>
        /// <value>A human-readable identifier for the billing document; may be user-supplied.</value>
        [DataMember(Name = "credit_memo_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "credit_memo_number")]
        public string? CreditMemoNumber { get; set; }

        /// <summary>
        /// 3-letter ISO 4217 currency code. This field is available only if you have the [Multiple Currencies](https://knowledgecenter.zuora.com/Zuora_Billing/Bill_your_customers/Flexible_Billing/Multiple_Currencies) feature enabled and are creating a credit memo from a charge.
        /// </summary>
        /// <value>3-letter ISO 4217 currency code. This field is available only if you have the [Multiple Currencies](https://knowledgecenter.zuora.com/Zuora_Billing/Bill_your_customers/Flexible_Billing/Multiple_Currencies) feature enabled and are creating a credit memo from a charge.</value>
        [DataMember(Name = "currency")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "currency")]
        public string? Currency { get; set; }

        /// <summary>
        /// Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.
        /// </summary>
        /// <value>Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.</value>
        [DataMember(Name = "custom_fields")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_fields")]
        public CustomFields CustomFields { get; set; }

        /// <summary>
        /// The custom objects associated with a Zuora standard object.
        /// </summary>
        /// <value>The custom objects associated with a Zuora standard object.</value>
        [DataMember(Name = "custom_objects")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_objects")]
        public CustomObject CustomObjects { get; set; }

        /// <summary>
        /// An arbitrary string associated with the object. Often useful for displaying to users.
        /// </summary>
        /// <value>An arbitrary string associated with the object. Often useful for displaying to users.</value>
        [DataMember(Name = "description")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description")]
        public string? Description { get; set; }

        /// <summary>
        /// The date when the credit memo takes effect.
        /// </summary>
        /// <value>The date when the credit memo takes effect.</value>
        [DataMember(Name = "document_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "document_date")]
        public DateTime? DocumentDate { get; set; }

        /// <summary>
        /// Indicates whether to exclude this credit memo from the rule of automatically applying it to invoices.
        /// </summary>
        /// <value>Indicates whether to exclude this credit memo from the rule of automatically applying it to invoices.</value>
        [DataMember(Name = "exclude_from_auto_apply_rules")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "exclude_from_auto_apply_rules")]
        public bool? ExcludeFromAutoApplyRules { get; set; }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid? Id { get; set; }

        /// <summary>
        /// The identifier of the invoice billing document from which this credit memo is created.      **Required when creating credit memos from an invoice.**
        /// </summary>
        /// <value>The identifier of the invoice billing document from which this credit memo is created.      **Required when creating credit memos from an invoice.**</value>
        [DataMember(Name = "invoice_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "invoice_id")]
        public Guid? InvoiceId { get; set; }

        /// <summary>
        /// List of billing document items. EXPANDABLE
        /// </summary>
        /// <value>List of billing document items. EXPANDABLE</value>
        [DataMember(Name = "items")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "items")]
        public List<CreditMemoItem> Items { get; set; }

        /// <summary>
        /// Identifier of the Zuora user who posted the billing document.
        /// </summary>
        /// <value>Identifier of the Zuora user who posted the billing document.</value>
        [DataMember(Name = "posted_by_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "posted_by_id")]
        public Guid? PostedById { get; set; }

        /// <summary>
        /// Reason for issuing this credit memo
        /// </summary>
        /// <value>Reason for issuing this credit memo</value>
        [DataMember(Name = "reason_code")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reason_code")]
        public string? ReasonCode { get; set; }

        /// <summary>
        /// The total balance remaining.
        /// </summary>
        /// <value>The total balance remaining.</value>
        [DataMember(Name = "remaining_balance")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "remaining_balance")]
        public decimal? RemainingBalance { get; set; }

        /// <summary>
        /// The status of the billing document.
        /// </summary>
        /// <value>The status of the billing document.</value>
        [DataMember(Name = "state")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state")]
        public string? State { get; set; }

        /// <summary>
        /// Gets or Sets StateTransitions
        /// </summary>
        [DataMember(Name = "state_transitions")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state_transitions")]
        public StateTransitions StateTransitions { get; set; }

        /// <summary>
        /// The total amount exclusive of tax.
        /// </summary>
        /// <value>The total amount exclusive of tax.</value>
        [DataMember(Name = "subtotal")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subtotal")]
        public decimal? Subtotal { get; set; }

        /// <summary>
        /// The total tax amount.
        /// </summary>
        /// <value>The total tax amount.</value>
        [DataMember(Name = "tax")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tax")]
        public decimal? Tax { get; set; }

        /// <summary>
        /// The total amount.
        /// </summary>
        /// <value>The total amount.</value>
        [DataMember(Name = "total")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "total")]
        public decimal? Total { get; set; }

        /// <summary>
        /// Whether to transfer to an external accounting system.
        /// </summary>
        /// <value>Whether to transfer to an external accounting system.</value>
        [DataMember(Name = "transfer_to_accounting")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "transfer_to_accounting")]
        public bool? TransferToAccounting { get; set; }

        /// <summary>
        /// Unique identifier of the Zuora user who last updated the object
        /// </summary>
        /// <value>Unique identifier of the Zuora user who last updated the object</value>
        [DataMember(Name = "updated_by_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "updated_by_id")]
        public Guid? UpdatedById { get; set; }

        /// <summary>
        /// The date and time when the object was last updated in ISO 8601 UTC format.
        /// </summary>
        /// <value>The date and time when the object was last updated in ISO 8601 UTC format.</value>
        [DataMember(Name = "updated_time")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "updated_time")]
        public DateTime? UpdatedTime { get; set; }

       
    }
}