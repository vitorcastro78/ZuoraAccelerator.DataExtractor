using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class Payment
    {
        /// <summary>
        /// The customer account associated with this payment.
        /// </summary>
        /// <value>The customer account associated with this payment.</value>
        [DataMember(Name = "account")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account")]
        public AllOfpaymentAccount Account { get; set; }

        /// <summary>
        /// Identifier of the customer account associated with this payment.
        /// </summary>
        /// <value>Identifier of the customer account associated with this payment.</value>
        [DataMember(Name = "account_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account_id")]
        public Guid AccountId { get; set; }

        /// <summary>
        /// Human-readable identifier of the account associated with this payment. It can be user-supplied.
        /// </summary>
        /// <value>Human-readable identifier of the account associated with this payment. It can be user-supplied.</value>
        [DataMember(Name = "account_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// The total amount of the payment.
        /// </summary>
        /// <value>The total amount of the payment.</value>
        [DataMember(Name = "amount")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// The total amount applied.
        /// </summary>
        /// <value>The total amount applied.</value>
        [DataMember(Name = "amount_applied")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount_applied")]
        public decimal? AmountApplied { get; set; }

        /// <summary>
        /// The total amount refunded.
        /// </summary>
        /// <value>The total amount refunded.</value>
        [DataMember(Name = "amount_refunded")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount_refunded")]
        public decimal? AmountRefunded { get; set; }

        /// <summary>
        /// Gets or Sets AppliedTo
        /// </summary>
        [DataMember(Name = "applied_to")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "applied_to")]
        public List<PaymentsAppliedToResponse> AppliedTo { get; set; }

        /// <summary>
        /// Identifier of the authorization transaction from the payment gateway.
        /// </summary>
        /// <value>Identifier of the authorization transaction from the payment gateway.</value>
        [DataMember(Name = "authorization_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "authorization_id")]
        public Guid AuthorizationId { get; set; }

        /// <summary>
        /// Unique identifier of the Zuora user who created the object
        /// </summary>
        /// <value>Unique identifier of the Zuora user who created the object</value>
        [DataMember(Name = "created_by_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "created_by_id")]
        public Guid CreatedById { get; set; }

        /// <summary>
        /// The date and time when the object was created in ISO 8601 UTC format.
        /// </summary>
        /// <value>The date and time when the object was created in ISO 8601 UTC format.</value>
        [DataMember(Name = "created_time")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "created_time")]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// 3-letter ISO 4217 currency code.
        /// </summary>
        /// <value>3-letter ISO 4217 currency code.</value>
        [DataMember(Name = "currency")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.
        /// </summary>
        /// <value>Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.</value>
        [DataMember(Name = "custom_fields")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_fields")]
        public Dictionary<string, Object> CustomFields { get; set; }

        /// <summary>
        /// The custom objects associated with a Zuora standard object.
        /// </summary>
        /// <value>The custom objects associated with a Zuora standard object.</value>
        [DataMember(Name = "custom_objects")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_objects")]
        public OneOfpaymentCustomObjects CustomObjects { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        /// <value>An arbitrary string attached to the object. Often useful for displaying to users.</value>
        [DataMember(Name = "description")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// If true, indicates that this payment is not handled by Zuora.
        /// </summary>
        /// <value>If true, indicates that this payment is not handled by Zuora.</value>
        [DataMember(Name = "external")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "external")]
        public bool? External { get; set; }

        /// <summary>
        /// Identifier of the payment gateway that Zuora will use to authorize this payment.
        /// </summary>
        /// <value>Identifier of the payment gateway that Zuora will use to authorize this payment.</value>
        [DataMember(Name = "gateway_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "gateway_id")]
        public Guid GatewayId { get; set; }

        /// <summary>
        /// Gets or Sets GatewayOptions
        /// </summary>
        [DataMember(Name = "gateway_options")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "gateway_options")]
        public Dictionary<string, string> GatewayOptions { get; set; }

        /// <summary>
        /// A merchant-specified natural key value that can be passed to the payment gateway when a payment is created. If not specified, the payment number will be passed in instead.
        /// </summary>
        /// <value>A merchant-specified natural key value that can be passed to the payment gateway when a payment is created. If not specified, the payment number will be passed in instead.</value>
        [DataMember(Name = "gateway_order_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "gateway_order_id")]
        public Guid GatewayOrderId { get; set; }

        /// <summary>
        /// Gateway reconciliation reason.
        /// </summary>
        /// <value>Gateway reconciliation reason.</value>
        [DataMember(Name = "gateway_reconciliation_reason")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "gateway_reconciliation_reason")]
        public string GatewayReconciliationReason { get; set; }

        /// <summary>
        /// Gateway reconciliation state.
        /// </summary>
        /// <value>Gateway reconciliation state.</value>
        [DataMember(Name = "gateway_reconciliation_status")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "gateway_reconciliation_status")]
        public string GatewayReconciliationStatus { get; set; }

        /// <summary>
        /// Message returned by the payment gateway for this payment.
        /// </summary>
        /// <value>Message returned by the payment gateway for this payment.</value>
        [DataMember(Name = "gateway_response")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "gateway_response")]
        public string GatewayResponse { get; set; }

        /// <summary>
        /// Code returned by the payment gateway for this payment.
        /// </summary>
        /// <value>Code returned by the payment gateway for this payment.</value>
        [DataMember(Name = "gateway_response_code")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "gateway_response_code")]
        public string GatewayResponseCode { get; set; }

        /// <summary>
        /// The payment gateway state of the payment.
        /// </summary>
        /// <value>The payment gateway state of the payment.</value>
        [DataMember(Name = "gateway_state")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "gateway_state")]
        public string GatewayState { get; set; }

        /// <summary>
        /// Gets or Sets GatewayStateTransitions
        /// </summary>
        [DataMember(Name = "gateway_state_transitions")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "gateway_state_transitions")]
        public GatewayStateTransitions GatewayStateTransitions { get; set; }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The date and time when the payment takes effect.
        /// </summary>
        /// <value>The date and time when the payment takes effect.</value>
        [DataMember(Name = "payment_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_date")]
        public DateTime? PaymentDate { get; set; }

        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name = "payment_method")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_method")]
        public PaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Identifier of the payment method used to create this payment.
        /// </summary>
        /// <value>Identifier of the payment method used to create this payment.</value>
        [DataMember(Name = "payment_method_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_method_id")]
        public Guid PaymentMethodId { get; set; }

        /// <summary>
        /// Human-readable identifier for this object; may be user-supplied.
        /// </summary>
        /// <value>Human-readable identifier for this object; may be user-supplied.</value>
        [DataMember(Name = "payment_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_number")]
        public string PaymentNumber { get; set; }

        /// <summary>
        /// Gets or Sets PaymentScheduleItems
        /// </summary>
        [DataMember(Name = "payment_schedule_items")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_schedule_items")]
        public List<PaymentScheduleItem> PaymentScheduleItems { get; set; }

        /// <summary>
        /// Identifier of the payout associated with this payment.
        /// </summary>
        /// <value>Identifier of the payout associated with this payment.</value>
        [DataMember(Name = "payout_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payout_id")]
        public Guid PayoutId { get; set; }

        /// <summary>
        /// Transaction identifier returned by the payment gateway. You may use this field to reconcile payments between your payment gateway and Zuora Payments.
        /// </summary>
        /// <value>Transaction identifier returned by the payment gateway. You may use this field to reconcile payments between your payment gateway and Zuora Payments.</value>
        [DataMember(Name = "reference_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reference_id")]
        public Guid ReferenceId { get; set; }

        /// <summary>
        /// The total remaining balance.
        /// </summary>
        /// <value>The total remaining balance.</value>
        [DataMember(Name = "remaining_balance")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "remaining_balance")]
        public decimal? RemainingBalance { get; set; }

        /// <summary>
        /// A second transaction identifier returned by the payment gateway if there is an additional transaction for the refunds. You may use this field to reconcile payments between your payment gateway and Zuora Payments.
        /// </summary>
        /// <value>A second transaction identifier returned by the payment gateway if there is an additional transaction for the refunds. You may use this field to reconcile payments between your payment gateway and Zuora Payments.</value>
        [DataMember(Name = "second_reference_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "second_reference_id")]
        public Guid SecondReferenceId { get; set; }

        /// <summary>
        /// The state of the payment.
        /// </summary>
        /// <value>The state of the payment.</value>
        [DataMember(Name = "state")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// A payment gateway-specific field used by Orbital, Vantiv and Verifi.
        /// </summary>
        /// <value>A payment gateway-specific field used by Orbital, Vantiv and Verifi.</value>
        [DataMember(Name = "statement_descriptor")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// A payment gateway-specific field used by Orbital, Vantiv and Verifi.
        /// </summary>
        /// <value>A payment gateway-specific field used by Orbital, Vantiv and Verifi.</value>
        [DataMember(Name = "statement_descriptor_phone")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "statement_descriptor_phone")]
        public string StatementDescriptorPhone { get; set; }

        /// <summary>
        /// Gets or Sets StateTransitions
        /// </summary>
        [DataMember(Name = "state_transitions")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state_transitions")]
        public PaymentStateTransitions StateTransitions { get; set; }

        /// <summary>
        /// Unique identifier of the Zuora user who last updated the object
        /// </summary>
        /// <value>Unique identifier of the Zuora user who last updated the object</value>
        [DataMember(Name = "updated_by_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "updated_by_id")]
        public Guid UpdatedById { get; set; }

        /// <summary>
        /// The date and time when the object was last updated in ISO 8601 UTC format.
        /// </summary>
        /// <value>The date and time when the object was last updated in ISO 8601 UTC format.</value>
        [DataMember(Name = "updated_time")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "updated_time")]
        public DateTime? UpdatedTime { get; set; }

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
            sb.Append("class Payment {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UpdatedById: ").Append(UpdatedById).Append("\n");
            sb.Append("  UpdatedTime: ").Append(UpdatedTime).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  CustomObjects: ").Append(CustomObjects).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  AuthorizationId: ").Append(AuthorizationId).Append("\n");
            sb.Append("  PaymentDate: ").Append(PaymentDate).Append("\n");
            sb.Append("  PaymentMethodId: ").Append(PaymentMethodId).Append("\n");
            sb.Append("  GatewayId: ").Append(GatewayId).Append("\n");
            sb.Append("  GatewayOrderId: ").Append(GatewayOrderId).Append("\n");
            sb.Append("  SecondReferenceId: ").Append(SecondReferenceId).Append("\n");
            sb.Append("  GatewayOptions: ").Append(GatewayOptions).Append("\n");
            sb.Append("  StatementDescriptor: ").Append(StatementDescriptor).Append("\n");
            sb.Append("  StatementDescriptorPhone: ").Append(StatementDescriptorPhone).Append("\n");
            sb.Append("  External: ").Append(External).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  AmountApplied: ").Append(AmountApplied).Append("\n");
            sb.Append("  RemainingBalance: ").Append(RemainingBalance).Append("\n");
            sb.Append("  AmountRefunded: ").Append(AmountRefunded).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  PayoutId: ").Append(PayoutId).Append("\n");
            sb.Append("  PaymentNumber: ").Append(PaymentNumber).Append("\n");
            sb.Append("  GatewayResponseCode: ").Append(GatewayResponseCode).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  GatewayResponse: ").Append(GatewayResponse).Append("\n");
            sb.Append("  GatewayReconciliationStatus: ").Append(GatewayReconciliationStatus).Append("\n");
            sb.Append("  GatewayReconciliationReason: ").Append(GatewayReconciliationReason).Append("\n");
            sb.Append("  GatewayState: ").Append(GatewayState).Append("\n");
            sb.Append("  AppliedTo: ").Append(AppliedTo).Append("\n");
            sb.Append("  PaymentScheduleItems: ").Append(PaymentScheduleItems).Append("\n");
            sb.Append("  StateTransitions: ").Append(StateTransitions).Append("\n");
            sb.Append("  GatewayStateTransitions: ").Append(GatewayStateTransitions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}