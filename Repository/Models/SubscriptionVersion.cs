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
    public class SubscriptionVersion
    {
        /// <summary>
        /// Information of the new account associated with the subscription.
        /// </summary>
        /// <value>Information of the new account associated with the subscription.</value>
        [DataMember(Name = "account")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account")]
        public Account Account { get; set; }

        /// <summary>
        /// Identifier of the account associated with this subscription.
        /// </summary>
        /// <value>Identifier of the account associated with this subscription.</value>
        [DataMember(Name = "account_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account_id")]
        public Guid? AccountId { get; set; }

        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name = "actions")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "actions")]
        public List<OrderAction> Actions { get; set; }

        /// <summary>
        /// If this field is set to `true`, the subscription automatically renews at the end of the current term.
        /// </summary>
        /// <value>If this field is set to `true`, the subscription automatically renews at the end of the current term.</value>
        [DataMember(Name = "auto_renew")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "auto_renew")]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// The billing document settings for the customer.
        /// </summary>
        /// <value>The billing document settings for the customer.</value>
        [DataMember(Name = "billing_document_settings")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "billing_document_settings")]
        public BillingDocumentSettings BillingDocumentSettings { get; set; }

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
        public string? BillToId { get; set; }

        /// <summary>
        /// The reason for cancelling the subscription.
        /// </summary>
        /// <value>The reason for cancelling the subscription.</value>
        [DataMember(Name = "cancel_reason")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cancel_reason")]
        public string? CancelReason { get; set; }

        /// <summary>
        /// Monthly recurring revenue of the subscription.
        /// </summary>
        /// <value>Monthly recurring revenue of the subscription.</value>
        [DataMember(Name = "contracted_mrr")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contracted_mrr")]
        public string? ContractedMrr { get; set; }

        /// <summary>
        /// Date when the subscriber contract is effective.
        /// </summary>
        /// <value>Date when the subscriber contract is effective.</value>
        [DataMember(Name = "contract_effective")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contract_effective")]
        public DateTime? ContractEffective { get; set; }

        /// <summary>
        /// Unique identifier of the Zuora user who created the object
        /// </summary>
        /// <value>Unique identifier of the Zuora user who created the object</value>
        [DataMember(Name = "created_by_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "created_by_id")]
        public Guid? CreatedById  { get; set; }

        /// <summary>
        /// The date and time when the object was created in ISO 8601 UTC format.
        /// </summary>
        /// <value>The date and time when the object was created in ISO 8601 UTC format.</value>
        [DataMember(Name = "created_time")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "created_time")]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// 3-letter ISO 4217 currency code. This field is available only if you have the [Multiple Currencies](https://knowledgecenter.zuora.com/Zuora_Billing/Bill_your_customers/Flexible_Billing/Multiple_Currencies) feature enabled.
        /// </summary>
        /// <value>3-letter ISO 4217 currency code. This field is available only if you have the [Multiple Currencies](https://knowledgecenter.zuora.com/Zuora_Billing/Bill_your_customers/Flexible_Billing/Multiple_Currencies) feature enabled.</value>
        [DataMember(Name = "currency")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "currency")]
        public string? Currency { get; set; }

        /// <summary>
        /// Current term information for the subscription
        /// </summary>
        /// <value>Current term information for the subscription</value>
        [DataMember(Name = "current_term")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "current_term")]
        public Term CurrentTerm { get; set; }

        /// <summary>
        /// Date when all the services or products in the subscription are accepted by the subscriber.
        /// </summary>
        /// <value>Date when all the services or products in the subscription are accepted by the subscriber.</value>
        [DataMember(Name = "customer_acceptance")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customer_acceptance")]
        public DateTime? CustomerAcceptance { get; set; }

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
        /// Description of the subscription. Often useful for displaying to users.
        /// </summary>
        /// <value>Description of the subscription. Often useful for displaying to users.</value>
        [DataMember(Name = "description")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description")]
        public string? Description { get; set; }

        /// <summary>
        /// Date when the subscription ends.
        /// </summary>
        /// <value>Date when the subscription ends.</value>
        [DataMember(Name = "end_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "end_date")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid? Id { get; set; }

        /// <summary>
        /// Initial term information for the subscription.
        /// </summary>
        /// <value>Initial term information for the subscription.</value>
        [DataMember(Name = "initial_term")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "initial_term")]
        public Term InitialTerm { get; set; }

        /// <summary>
        /// List of invoice items.
        /// </summary>
        /// <value>List of invoice items.</value>
        [DataMember(Name = "invoice_items")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "invoice_items")]
        public List<InvoiceItem> InvoiceItems { get; set; }

        /// <summary>
        /// Identifier of the account that owns the subscription.
        /// </summary>
        /// <value>Identifier of the account that owns the subscription.</value>
        [DataMember(Name = "invoice_owner_account")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "invoice_owner_account")]
        public Account InvoiceOwnerAccount { get; set; }

        /// <summary>
        /// Identifier of the account that owns the invoice associated with this subscription.
        /// </summary>
        /// <value>Identifier of the account that owns the invoice associated with this subscription.</value>
        [DataMember(Name = "invoice_owner_account_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "invoice_owner_account_id")]
        public string? InvoiceOwnerAccountId { get; set; }

        /// <summary>
        /// If true, the subscription is billed separately from other subscriptions. If false, the subscription is included with other subscriptions in the account invoice. The default is false.
        /// </summary>
        /// <value>If true, the subscription is billed separately from other subscriptions. If false, the subscription is included with other subscriptions in the account invoice. The default is false.</value>
        [DataMember(Name = "invoice_separately")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "invoice_separately")]
        public bool? InvoiceSeparately { get; set; }

        /// <summary>
        /// The last booking date of the subscription object. You can override the date value when creating a subscription through the \"Subscribe and Amend\" API. The default value `today` is set per the user's timezone. The value of this field is as follows:    <ul>     <li>For a new subscription created by the [Subscribe and Amend](https://knowledgecenter.zuora.com/Billing/Subscriptions/Orders/Orders_Harmonization/Orders_Migration_Guidance#Subscribe_and_Amend_APIs_to_Migrate) APIs, this field has the value of the subscription creation date. </li>     <li>For a subscription changed by an amendment, this field has the value of the amendment booking date.</li>     <li>For a subscription created or changed by an order, this field has the value of the order date.</li>     </ul>
        /// </summary>
        /// <value>The last booking date of the subscription object. You can override the date value when creating a subscription through the \"Subscribe and Amend\" API. The default value `today` is set per the user's timezone. The value of this field is as follows:    <ul>     <li>For a new subscription created by the [Subscribe and Amend](https://knowledgecenter.zuora.com/Billing/Subscriptions/Orders/Orders_Harmonization/Orders_Migration_Guidance#Subscribe_and_Amend_APIs_to_Migrate) APIs, this field has the value of the subscription creation date. </li>     <li>For a subscription changed by an amendment, this field has the value of the amendment booking date.</li>     <li>For a subscription created or changed by an order, this field has the value of the order date.</li>     </ul>  </value>
        [DataMember(Name = "last_booking_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "last_booking_date")]
        public DateTime? LastBookingDate { get; set; }

        /// <summary>
        /// If true, this is the latest version of the subscription
        /// </summary>
        /// <value>If true, this is the latest version of the subscription</value>
        [DataMember(Name = "latest_version")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "latest_version")]
        public bool? LatestVersion { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name = "order")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "order")]
        public Order Order { get; set; }

        /// <summary>
        /// The order number of the order created by Zuora.
        /// </summary>
        /// <value>The order number of the order created by Zuora.</value>
        [DataMember(Name = "order_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "order_number")]
        public string? OrderNumber { get; set; }

        /// <summary>
        /// The name of payment term associated with the invoice.
        /// </summary>
        /// <value>The name of payment term associated with the invoice.</value>
        [DataMember(Name = "payment_terms")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_terms")]
        public string? PaymentTerms { get; set; }

        /// <summary>
        /// Total prepaid units available during a subscription. It is an aggregate of all funds under a subscription. **Deprecated, please use `prepaid_balances` instead.**
        /// </summary>
        /// <value>Total prepaid units available during a subscription. It is an aggregate of all funds under a subscription. **Deprecated, please use `prepaid_balances` instead.**</value>
        [DataMember(Name = "prepaid_balance")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "prepaid_balance")]
        public List<PrepaidBalance> PrepaidBalance { get; set; }

        /// <summary>
        /// Total prepaid units available during a subscription. It is an aggregate of all funds under a subscription.
        /// </summary>
        /// <value>Total prepaid units available during a subscription. It is an aggregate of all funds under a subscription.</value>
        [DataMember(Name = "prepaid_balances")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "prepaid_balances")]
        public List<PrepaidBalances> PrepaidBalances { get; set; }

        /// <summary>
        /// Renewal term information for the subscription.
        /// </summary>
        /// <value>Renewal term information for the subscription.</value>
        [DataMember(Name = "renewal_term")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "renewal_term")]
        public Term RenewalTerm { get; set; }

        /// <summary>
        /// Date when the subscribed-to service is activated.
        /// </summary>
        /// <value>Date when the subscribed-to service is activated.</value>
        [DataMember(Name = "service_activation")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "service_activation")]
        public DateTime? ServiceActivation { get; set; }

        /// <summary>
        /// The selling address for the customer.
        /// </summary>
        /// <value>The selling address for the customer.</value>
        [DataMember(Name = "sold_to")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sold_to")]
        public Contact SoldTo { get; set; }

        /// <summary>
        /// ID of the sold-to contact.
        /// </summary>
        /// <value>ID of the sold-to contact.</value>
        [DataMember(Name = "sold_to_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sold_to_id")]
        public string? SoldToId { get; set; }

        /// <summary>
        /// Date when the subscription starts.
        /// </summary>
        /// <value>Date when the subscription starts.</value>
        [DataMember(Name = "start_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "start_date")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Status of the subscription.
        /// </summary>
        /// <value>Status of the subscription.</value>
        [DataMember(Name = "state")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state")]
        public string? State { get; set; }

        /// <summary>
        /// Human-readable identifier of the subscription. It can be user-supplied.
        /// </summary>
        /// <value>Human-readable identifier of the subscription. It can be user-supplied.</value>
        [DataMember(Name = "subscription_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscription_number")]
        public string? SubscriptionNumber { get; set; }

        /// <summary>
        /// List of subscription plans.
        /// </summary>
        /// <value>List of subscription plans.</value>
        [DataMember(Name = "subscription_plans")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscription_plans")]
        public List<SubscriptionPlan> SubscriptionPlans { get; set; }

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

        /// <summary>
        /// The version of the subscription. This version can be used in the `filter[]` query parameter to filter subscriptions.
        /// </summary>
        /// <value>The version of the subscription. This version can be used in the `filter[]` query parameter to filter subscriptions.</value>
        [DataMember(Name = "version")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "version")]
        public int? Version { get; set; }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string? ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }


    }
}