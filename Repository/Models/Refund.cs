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
    public class Refund
    {
        /// <summary>
        /// The account that owns the refund
        /// </summary>
        /// <value>The account that owns the refund</value>
        [DataMember(Name = "account")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account")]
        public Account? Account { get; set; }

        /// <summary>
        /// Identifier of the customer this refund is for, if one exists.
        /// </summary>
        /// <value>Identifier of the customer this refund is for, if one exists.</value>
        [DataMember(Name = "account_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account_id")]
        public Guid? AccountId { get; set; }

        /// <summary>
        /// Refund amount.
        /// </summary>
        /// <value>Refund amount.</value>
        [DataMember(Name = "amount")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Gets or Sets AppliedTo
        /// </summary>
        [DataMember(Name = "applied_to")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "applied_to")]
        public List<RefundsAppliedTo>? AppliedTo { get; set; }

        /// <summary>
        /// An active account in your Zuora Chart of Accounts.
        /// </summary>
        /// <value>An active account in your Zuora Chart of Accounts.</value>
        [DataMember(Name = "bank_account_account")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bank_account_account")]
        public string? BankAccountAccount { get; set; }

        /// <summary>
        /// Comments about the refund.
        /// </summary>
        /// <value>Comments about the refund.</value>
        [DataMember(Name = "comment")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// The ID of the user who created the refund.
        /// </summary>
        /// <value>The ID of the user who created the refund.</value>
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
        /// The related credit memo.
        /// </summary>
        /// <value>The related credit memo.</value>
        [DataMember(Name = "credit_memo")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "credit_memo")]
        public CreditMemo? CreditMemo { get; set; }

        /// <summary>
        /// Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.
        /// </summary>
        /// <value>Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.</value>
        [DataMember(Name = "custom_fields")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_fields")]
        public CustomFields? CustomFields { get; set; }

        /// <summary>
        /// The custom objects associated with a Zuora standard object.
        /// </summary>
        /// <value>The custom objects associated with a Zuora standard object.</value>
        [DataMember(Name = "custom_objects")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_objects")]
        public CustomObject? CustomObjects { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        /// <value>An arbitrary string attached to the object. Often useful for displaying to users.</value>
        [DataMember(Name = "description")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description")]
        public string? Description { get; set; }

        /// <summary>
        /// If true, indicates that this refund is not handled by Zuora.
        /// </summary>
        /// <value>If true, indicates that this refund is not handled by Zuora.</value>
        [DataMember(Name = "external")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "external")]
        public bool? External { get; set; }

        /// <summary>
        /// The ID of the gateway.
        /// </summary>
        /// <value>The ID of the gateway.</value>
        [DataMember(Name = "gateway_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "gateway_id")]
        public Guid? GatewayId { get; set; }

        /// <summary>
        /// Gets or Sets GatewayOptions
        /// </summary>
        [DataMember(Name = "gateway_options")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "gateway_options")]
        public GatewayOptions? GatewayOptions { get; set; }

        /// <summary>
        /// Gateway reconciliation reason.
        /// </summary>
        /// <value>Gateway reconciliation reason.</value>
        [DataMember(Name = "gateway_reconciliation_reason")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "gateway_reconciliation_reason")]
        public string? GatewayReconciliationReason { get; set; }

        /// <summary>
        /// Gateway reconciliation state.
        /// </summary>
        /// <value>Gateway reconciliation state.</value>
        [DataMember(Name = "gateway_reconciliation_status")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "gateway_reconciliation_status")]
        public string? GatewayReconciliationStatus { get; set; }

        /// <summary>
        /// Message returned by the payment gateway for this refund.
        /// </summary>
        /// <value>Message returned by the payment gateway for this refund.</value>
        [DataMember(Name = "gateway_response")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "gateway_response")]
        public string? GatewayResponse { get; set; }

        /// <summary>
        /// Code returned by the payment gateway for this refund.
        /// </summary>
        /// <value>Code returned by the payment gateway for this refund.</value>
        [DataMember(Name = "gateway_response_code")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "gateway_response_code")]
        public string? GatewayResponseCode { get; set; }

        /// <summary>
        /// The payment gateway state of the refund.
        /// </summary>
        /// <value>The payment gateway state of the refund.</value>
        [DataMember(Name = "gateway_state")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "gateway_state")]
        public string? GatewayState { get; set; }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid? Id { get; set; }

        /// <summary>
        /// An active account in your Zuora Chart of Accounts.
        /// </summary>
        /// <value>An active account in your Zuora Chart of Accounts.</value>
        [DataMember(Name = "on_account_account")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "on_account_account")]
        public string? OnAccountAccount { get; set; }

        /// <summary>
        /// The ID of the payment.
        /// </summary>
        /// <value>The ID of the payment.</value>
        [DataMember(Name = "payment_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_id")]
        public Guid? PaymentId { get; set; }

        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name = "payment_method")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_method")]
        public PaymentMethod? PaymentMethod { get; set; }

        /// <summary>
        /// The ID of the payment method.
        /// </summary>
        /// <value>The ID of the payment method.</value>
        [DataMember(Name = "payment_method_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_method_id")]
        public Guid? PaymentMethodId { get; set; }

        /// <summary>
        /// The ID of the payout.
        /// </summary>
        /// <value>The ID of the payout.</value>
        [DataMember(Name = "payout_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payout_id")]
        public Guid? PayoutId { get; set; }

        /// <summary>
        /// User-provided reason for the refund.
        /// </summary>
        /// <value>User-provided reason for the refund.</value>
        [DataMember(Name = "reason_code")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reason_code")]
        public string? ReasonCode { get; set; }

        /// <summary>
        /// The ID of the reference.
        /// </summary>
        /// <value>The ID of the reference.</value>
        [DataMember(Name = "reference_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reference_id")]
        public Guid? ReferenceId { get; set; }

        /// <summary>
        /// The date when the refund takes effect.
        /// </summary>
        /// <value>The date when the refund takes effect.</value>
        [DataMember(Name = "refund_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "refund_date")]
        public DateTime? RefundDate { get; set; }

        /// <summary>
        /// Gets or Sets RefundMethodType
        /// </summary>
        [DataMember(Name = "refund_method_type")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "refund_method_type")]
        public string? RefundMethodType { get; set; }

        /// <summary>
        /// Human-readable identifier for this object; may be user-supplied.
        /// </summary>
        /// <value>Human-readable identifier for this object; may be user-supplied.</value>
        [DataMember(Name = "refund_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "refund_number")]
        public string? RefundNumber { get; set; }

        /// <summary>
        /// The ID of the second reference.
        /// </summary>
        /// <value>The ID of the second reference.</value>
        [DataMember(Name = "second_reference_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "second_reference_id")]
        public Guid? SecondReferenceId { get; set; }

        /// <summary>
        /// The state of the refund.
        /// </summary>
        /// <value>The state of the refund.</value>
        [DataMember(Name = "state")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state")]
        public string? State { get; set; }

        /// <summary>
        /// A payment gateway-specific field used by Orbital, Vantiv and Verifi.
        /// </summary>
        /// <value>A payment gateway-specific field used by Orbital, Vantiv and Verifi.</value>
        [DataMember(Name = "statement_descriptor")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "statement_descriptor")]
        public string? StatementDescriptor { get; set; }

        /// <summary>
        /// A payment gateway-specific field used by Orbital, Vantiv and Verifi.
        /// </summary>
        /// <value>A payment gateway-specific field used by Orbital, Vantiv and Verifi.</value>
        [DataMember(Name = "statement_descriptor_phone")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "statement_descriptor_phone")]
        public string? StatementDescriptorPhone { get; set; }

        /// <summary>
        /// Gets or Sets StateTransitions
        /// </summary>
        [DataMember(Name = "state_transitions")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state_transitions")]
        public List<RefundStateTransitions>? StateTransitions { get; set; }

        /// <summary>
        /// An active account in your Zuora Chart of Accounts.
        /// </summary>
        /// <value>An active account in your Zuora Chart of Accounts.</value>
        [DataMember(Name = "unapplied_payment_account")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "unapplied_payment_account")]
        public string? UnappliedPaymentAccount { get; set; }

        /// <summary>
        /// The ID of the user who last updated the refund.
        /// </summary>
        /// <value>The ID of the user who last updated the refund.</value>
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