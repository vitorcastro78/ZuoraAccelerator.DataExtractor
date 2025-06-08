using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class changeTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_BillingDocumentSettings_BillingDocumentSettingsId",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_BillingDocuments_BillingDocumentsId",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Contacts_BillToId1",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Contacts_SoldToId1",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_CustomFields_CustomFieldsId",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_CustomObjects_CustomObjectsId",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_TaxCertificates_TaxCertificateId",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_TaxIdentifiers_TaxIdentifierId",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_BillingDocumentItems_BillingDocuments_BillingDocumentId1",
                table: "BillingDocumentItems");

            migrationBuilder.DropForeignKey(
                name: "FK_BillingDocumentItems_CustomFields_CustomFieldsId",
                table: "BillingDocumentItems");

            migrationBuilder.DropForeignKey(
                name: "FK_BillingDocumentItems_CustomObjects_CustomObjectsId",
                table: "BillingDocumentItems");

            migrationBuilder.DropForeignKey(
                name: "FK_BillingDocumentItems_PaymentsAppliedTo_PaymentsAppliedToId",
                table: "BillingDocumentItems");

            migrationBuilder.DropForeignKey(
                name: "FK_BillingDocumentItems_SubscriptionItems_SubscriptionItemId1",
                table: "BillingDocumentItems");

            migrationBuilder.DropForeignKey(
                name: "FK_BillingDocumentItems_Subscriptions_SubscriptionId1",
                table: "BillingDocumentItems");

            migrationBuilder.DropForeignKey(
                name: "FK_BillingDocuments_CustomFields_CustomFieldsId",
                table: "BillingDocuments");

            migrationBuilder.DropForeignKey(
                name: "FK_BillingDocuments_CustomObjects_CustomObjectsId",
                table: "BillingDocuments");

            migrationBuilder.DropForeignKey(
                name: "FK_BillingDocumentSettings_CreditMemos_CreditMemoId",
                table: "BillingDocumentSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_BillingDocumentStateTransitions_BillingDocuments_BillingDocumentId",
                table: "BillingDocumentStateTransitions");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Address_AddressId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_CustomFields_CustomFieldsId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_CustomObjects_CustomObjectsId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_CreditMemoAppliedTo_BillingDocuments_BillingDocumentId1",
                table: "CreditMemoAppliedTo");

            migrationBuilder.DropForeignKey(
                name: "FK_CreditMemoItems_CreditMemos_CreditMemoId1",
                table: "CreditMemoItems");

            migrationBuilder.DropForeignKey(
                name: "FK_CreditMemoItems_CustomFields_CustomFieldsId",
                table: "CreditMemoItems");

            migrationBuilder.DropForeignKey(
                name: "FK_CreditMemoItems_CustomObjects_CustomObjectsId",
                table: "CreditMemoItems");

            migrationBuilder.DropForeignKey(
                name: "FK_CreditMemoItems_SubscriptionItems_SubscriptionItemId1",
                table: "CreditMemoItems");

            migrationBuilder.DropForeignKey(
                name: "FK_CreditMemoItems_Subscriptions_SubscriptionId1",
                table: "CreditMemoItems");

            migrationBuilder.DropForeignKey(
                name: "FK_CreditMemos_Accounts_AccountId1",
                table: "CreditMemos");

            migrationBuilder.DropForeignKey(
                name: "FK_CreditMemos_ArTransactions_ArTransactionsId",
                table: "CreditMemos");

            migrationBuilder.DropForeignKey(
                name: "FK_CreditMemos_Contacts_BillToId1",
                table: "CreditMemos");

            migrationBuilder.DropForeignKey(
                name: "FK_CreditMemos_CreditMemos_CreditMemoId",
                table: "CreditMemos");

            migrationBuilder.DropForeignKey(
                name: "FK_CreditMemos_CustomFields_CustomFieldsId",
                table: "CreditMemos");

            migrationBuilder.DropForeignKey(
                name: "FK_CreditMemos_CustomObjects_CustomObjectsId",
                table: "CreditMemos");

            migrationBuilder.DropForeignKey(
                name: "FK_CreditMemos_StateTransitions_StateTransitionsId",
                table: "CreditMemos");

            migrationBuilder.DropForeignKey(
                name: "FK_DebitMemoItems_CustomFields_CustomFieldsId",
                table: "DebitMemoItems");

            migrationBuilder.DropForeignKey(
                name: "FK_DebitMemoItems_CustomObjects_CustomObjectsId",
                table: "DebitMemoItems");

            migrationBuilder.DropForeignKey(
                name: "FK_DebitMemoItems_DebitMemos_DebitMemoId1",
                table: "DebitMemoItems");

            migrationBuilder.DropForeignKey(
                name: "FK_DebitMemoItems_SubscriptionItems_SubscriptionItemId1",
                table: "DebitMemoItems");

            migrationBuilder.DropForeignKey(
                name: "FK_DebitMemoItems_Subscriptions_SubscriptionId1",
                table: "DebitMemoItems");

            migrationBuilder.DropForeignKey(
                name: "FK_DebitMemos_Accounts_AccountId1",
                table: "DebitMemos");

            migrationBuilder.DropForeignKey(
                name: "FK_DebitMemos_BillingDocumentSettings_BillingDocumentSettingsId",
                table: "DebitMemos");

            migrationBuilder.DropForeignKey(
                name: "FK_DebitMemos_Contacts_BillToId1",
                table: "DebitMemos");

            migrationBuilder.DropForeignKey(
                name: "FK_DebitMemos_CustomFields_CustomFieldsId",
                table: "DebitMemos");

            migrationBuilder.DropForeignKey(
                name: "FK_DebitMemos_CustomObjects_CustomObjectsId",
                table: "DebitMemos");

            migrationBuilder.DropForeignKey(
                name: "FK_DebitMemos_StateTransitions_StateTransitionsId",
                table: "DebitMemos");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceItems_CustomFields_CustomFieldsId",
                table: "InvoiceItems");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceItems_CustomObjects_CustomObjectsId",
                table: "InvoiceItems");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceItems_Invoices_InvoiceId1",
                table: "InvoiceItems");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceItems_OrderLineItems_LineItemId",
                table: "InvoiceItems");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceItems_SubscriptionItems_SubscriptionItemId1",
                table: "InvoiceItems");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceItems_Subscriptions_SubscriptionId1",
                table: "InvoiceItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Accounts_AccountId1",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_ArTransactions_ArTransactionsId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_BillingDocumentSettings_BillingDocumentSettingsId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Contacts_BillToId1",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Contacts_SoldToId1",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_CustomFields_CustomFieldsId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_CustomObjects_CustomObjectsId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_StateTransitions_StateTransitionsId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemTier_SubscriptionItems_SubscriptionItemId",
                table: "ItemTier");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Accounts_AccountId1",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_CustomObjects_CustomObjectsId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderLineItems_CustomFields_CustomFieldsId",
                table: "OrderLineItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderLineItems_CustomObjects_CustomObjectsId",
                table: "OrderLineItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderLineItems_OrderLineItemRevenue_RevenueId",
                table: "OrderLineItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderLineItems_Order_OrderId1",
                table: "OrderLineItems");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethods_Accounts_AccountId1",
                table: "PaymentMethods");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethods_AchDebit_AchDebitId",
                table: "PaymentMethods");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethods_ApplePay_ApplePayId",
                table: "PaymentMethods");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethods_AuBecsDebit_AuBecsDebitId",
                table: "PaymentMethods");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethods_AutogiroDebit_AutogiroDebitId",
                table: "PaymentMethods");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethods_BacsDebit_BacsDebitId",
                table: "PaymentMethods");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethods_BetalingsDebit_BetalingsDebitId",
                table: "PaymentMethods");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethods_BillingDetails_BillingDetailsId",
                table: "PaymentMethods");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethods_CcRef_CcRefId",
                table: "PaymentMethods");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethods_CustomFields_CustomFieldsId",
                table: "PaymentMethods");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethods_CustomObjects_CustomObjectsId",
                table: "PaymentMethods");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethods_GetCardList_CardId",
                table: "PaymentMethods");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethods_GooglePay_GooglePayId",
                table: "PaymentMethods");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethods_NzBecsDebit_NzBecsDebitId",
                table: "PaymentMethods");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethods_PadDebit_PadDebitId",
                table: "PaymentMethods");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethods_PaypalAdaptive_PaypalAdaptiveId",
                table: "PaymentMethods");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethods_PaypalExpressNative_PaypalExpressNativeId",
                table: "PaymentMethods");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethods_PaypalExpress_PaypalExpressId",
                table: "PaymentMethods");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethods_SepaDebit_SepaDebitId",
                table: "PaymentMethods");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Accounts_AccountId1",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_CustomFields_CustomFieldsId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_CustomObjects_CustomObjectsId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_GatewayOptions_GatewayOptionsId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_GatewayStateTransitions_GatewayStateTransitionsId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_PaymentMethods_PaymentMethodId1",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_PaymentStateTransitions_StateTransitionsId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_PaymentTransactions_PaymentTransactionsId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentsAppliedTo_BillingDocuments_BillingDocumentId1",
                table: "PaymentsAppliedTo");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentsAppliedTo_Payments_PaymentId",
                table: "PaymentsAppliedTo");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentSchedule_BillingDocuments_BillingDocumentId",
                table: "PaymentSchedule");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentSchedule_CustomObjects_CustomObjectsId",
                table: "PaymentSchedule");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentScheduleItemPayments_PaymentScheduleItems_PaymentScheduleItemId",
                table: "PaymentScheduleItemPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentScheduleItems_BillingDocuments_BillingDocumentId",
                table: "PaymentScheduleItems");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentScheduleItems_CustomFields_CustomFieldsId",
                table: "PaymentScheduleItems");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentScheduleItems_CustomObjects_CustomObjectsId",
                table: "PaymentScheduleItems");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentScheduleItems_PaymentSchedule_PaymentScheduleId1",
                table: "PaymentScheduleItems");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentScheduleItems_Payments_PaymentId",
                table: "PaymentScheduleItems");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentTransactions_ArTransactions_ArTransactionsId",
                table: "PaymentTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentTransactions_TransactionsState_StateId",
                table: "PaymentTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Plan_CustomObjects_CustomObjectsId",
                table: "Plan");

            migrationBuilder.DropForeignKey(
                name: "FK_Plan_Products_ProductId1",
                table: "Plan");

            migrationBuilder.DropForeignKey(
                name: "FK_PrepaidBalance_Subscriptions_SubscriptionId",
                table: "PrepaidBalance");

            migrationBuilder.DropForeignKey(
                name: "FK_PrepaidBalances_Subscriptions_SubscriptionId",
                table: "PrepaidBalances");

            migrationBuilder.DropForeignKey(
                name: "FK_Price_CustomObjects_CustomObjectsId",
                table: "Price");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductPlan_CustomObjects_CustomObjectsId",
                table: "ProductPlan");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductPlan_Products_ProductId1",
                table: "ProductPlan");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductPrice_CustomObjects_CustomObjectsId",
                table: "ProductPrice");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_CustomFields_CustomFieldsId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_CustomObjects_CustomObjectsId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Refunds_Accounts_AccountId1",
                table: "Refunds");

            migrationBuilder.DropForeignKey(
                name: "FK_Refunds_CreditMemos_CreditMemoId",
                table: "Refunds");

            migrationBuilder.DropForeignKey(
                name: "FK_Refunds_CustomFields_CustomFieldsId",
                table: "Refunds");

            migrationBuilder.DropForeignKey(
                name: "FK_Refunds_CustomObjects_CustomObjectsId",
                table: "Refunds");

            migrationBuilder.DropForeignKey(
                name: "FK_Refunds_GatewayOptions_GatewayOptionsId",
                table: "Refunds");

            migrationBuilder.DropForeignKey(
                name: "FK_Refunds_PaymentMethods_PaymentMethodId1",
                table: "Refunds");

            migrationBuilder.DropForeignKey(
                name: "FK_Refunds_RefundStateTransitions_StateTransitionsId",
                table: "Refunds");

            migrationBuilder.DropForeignKey(
                name: "FK_Refunds_RefundTransactions_RefundTransactionsId",
                table: "Refunds");

            migrationBuilder.DropForeignKey(
                name: "FK_RefundsAppliedTo_BillingDocuments_BillingDocumentId1",
                table: "RefundsAppliedTo");

            migrationBuilder.DropForeignKey(
                name: "FK_RefundsAppliedTo_Payments_PaymentId",
                table: "RefundsAppliedTo");

            migrationBuilder.DropForeignKey(
                name: "FK_RefundsAppliedTo_Refunds_RefundId",
                table: "RefundsAppliedTo");

            migrationBuilder.DropForeignKey(
                name: "FK_RefundTransactions_ArTransactions_ArTransactionsId",
                table: "RefundTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_RefundTransactions_TransactionsState_StateId",
                table: "RefundTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionAddPlans_CustomFields_CustomFieldsId",
                table: "SubscriptionAddPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionItems_CustomFields_CustomFieldsId",
                table: "SubscriptionItems");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionItems_CustomObjects_CustomObjectsId",
                table: "SubscriptionItems");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionItems_Overage_OverageId",
                table: "SubscriptionItems");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionItems_Price_PriceId1",
                table: "SubscriptionItems");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionItems_Recurring_RecurringId",
                table: "SubscriptionItems");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionItems_SubscriptionAddPlans_SubscriptionAddPlanId",
                table: "SubscriptionItems");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionItems_SubscriptionPlans_SubscriptionPlanId1",
                table: "SubscriptionItems");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionPauses_CustomFields_CustomFieldsId",
                table: "SubscriptionPauses");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionPauses_ResumeSubscription_ResumeBehaviorId",
                table: "SubscriptionPauses");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionPlans_CustomFields_CustomFieldsId",
                table: "SubscriptionPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionPlans_CustomObjects_CustomObjectsId",
                table: "SubscriptionPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionPlans_Plan_PlanId1",
                table: "SubscriptionPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionPlans_Products_ProductId1",
                table: "SubscriptionPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionPlans_Subscriptions_SubscriptionId1",
                table: "SubscriptionPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionRenews_SubscriptionTerms_TermsId",
                table: "SubscriptionRenews");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptions_Accounts_AccountId1",
                table: "Subscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptions_Accounts_InvoiceOwnerAccountId1",
                table: "Subscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptions_BillingDocumentSettings_BillingDocumentSettingsId",
                table: "Subscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptions_Contacts_BillToId1",
                table: "Subscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptions_Contacts_SoldToId1",
                table: "Subscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptions_CustomFields_CustomFieldsId",
                table: "Subscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptions_CustomObjects_CustomObjectsId",
                table: "Subscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptions_Order_OrderId",
                table: "Subscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptions_Term_CurrentTermId",
                table: "Subscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptions_Term_InitialTermId",
                table: "Subscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptions_Term_RenewalTermId",
                table: "Subscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionTerms_Term_CurrentTermId",
                table: "SubscriptionTerms");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionTerms_Term_RenewalTermId",
                table: "SubscriptionTerms");

            migrationBuilder.DropForeignKey(
                name: "FK_TaxationItems_BillingDocumentItems_BillingDocumentItemId",
                table: "TaxationItems");

            migrationBuilder.DropForeignKey(
                name: "FK_TaxationItems_CreditMemoItems_CreditMemoItemId",
                table: "TaxationItems");

            migrationBuilder.DropForeignKey(
                name: "FK_TaxationItems_CustomFields_CustomFieldsId",
                table: "TaxationItems");

            migrationBuilder.DropForeignKey(
                name: "FK_TaxationItems_CustomObjects_CustomObjectsId",
                table: "TaxationItems");

            migrationBuilder.DropForeignKey(
                name: "FK_TaxationItems_DebitMemoItems_DebitMemoItemId",
                table: "TaxationItems");

            migrationBuilder.DropForeignKey(
                name: "FK_TaxationItems_InvoiceItems_InvoiceItemId",
                table: "TaxationItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Usages_Accounts_AccountId1",
                table: "Usages");

            migrationBuilder.DropForeignKey(
                name: "FK_Usages_CustomFields_CustomFieldsId",
                table: "Usages");

            migrationBuilder.DropForeignKey(
                name: "FK_Usages_CustomObjects_CustomObjectsId",
                table: "Usages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usages",
                table: "Usages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaxIdentifiers",
                table: "TaxIdentifiers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaxCertificates",
                table: "TaxCertificates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaxationItems",
                table: "TaxationItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubscriptionTerms",
                table: "SubscriptionTerms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subscriptions",
                table: "Subscriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubscriptionRenews",
                table: "SubscriptionRenews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubscriptionRemovePlans",
                table: "SubscriptionRemovePlans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubscriptionPlans",
                table: "SubscriptionPlans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubscriptionPauses",
                table: "SubscriptionPauses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubscriptionItems",
                table: "SubscriptionItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubscriptionCancels",
                table: "SubscriptionCancels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubscriptionAddPlans",
                table: "SubscriptionAddPlans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RefundTransactions",
                table: "RefundTransactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Refunds",
                table: "Refunds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentTransactions",
                table: "PaymentTransactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentScheduleItems",
                table: "PaymentScheduleItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payments",
                table: "Payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentMethods",
                table: "PaymentMethods");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderLineItems",
                table: "OrderLineItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Invoices",
                table: "Invoices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InvoiceItems",
                table: "InvoiceItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DebitMemos",
                table: "DebitMemos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DebitMemoItems",
                table: "DebitMemoItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomObjects",
                table: "CustomObjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CreditMemos",
                table: "CreditMemos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CreditMemoItems",
                table: "CreditMemoItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BillingDocumentSettings",
                table: "BillingDocumentSettings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BillingDocuments",
                table: "BillingDocuments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BillingDocumentItems",
                table: "BillingDocumentItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ArTransactions",
                table: "ArTransactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Accounts",
                table: "Accounts");

            migrationBuilder.RenameTable(
                name: "Usages",
                newName: "Usage");

            migrationBuilder.RenameTable(
                name: "TaxIdentifiers",
                newName: "TaxIdentifier");

            migrationBuilder.RenameTable(
                name: "TaxCertificates",
                newName: "TaxCertificate");

            migrationBuilder.RenameTable(
                name: "TaxationItems",
                newName: "TaxationItem");

            migrationBuilder.RenameTable(
                name: "SubscriptionTerms",
                newName: "SubscriptionTerm");

            migrationBuilder.RenameTable(
                name: "Subscriptions",
                newName: "Subscription");

            migrationBuilder.RenameTable(
                name: "SubscriptionRenews",
                newName: "SubscriptionRenew");

            migrationBuilder.RenameTable(
                name: "SubscriptionRemovePlans",
                newName: "SubscriptionRemovePlan");

            migrationBuilder.RenameTable(
                name: "SubscriptionPlans",
                newName: "SubscriptionPlan");

            migrationBuilder.RenameTable(
                name: "SubscriptionPauses",
                newName: "SubscriptionPause");

            migrationBuilder.RenameTable(
                name: "SubscriptionItems",
                newName: "SubscriptionItem");

            migrationBuilder.RenameTable(
                name: "SubscriptionCancels",
                newName: "SubscriptionCancel");

            migrationBuilder.RenameTable(
                name: "SubscriptionAddPlans",
                newName: "SubscriptionAddPlan");

            migrationBuilder.RenameTable(
                name: "RefundTransactions",
                newName: "RefundTransaction");

            migrationBuilder.RenameTable(
                name: "Refunds",
                newName: "Refund");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameTable(
                name: "PaymentTransactions",
                newName: "PaymentTransaction");

            migrationBuilder.RenameTable(
                name: "PaymentScheduleItems",
                newName: "PaymentScheduleItem");

            migrationBuilder.RenameTable(
                name: "Payments",
                newName: "Payment");

            migrationBuilder.RenameTable(
                name: "PaymentMethods",
                newName: "PaymentMethod");

            migrationBuilder.RenameTable(
                name: "OrderLineItems",
                newName: "OrderLineItem");

            migrationBuilder.RenameTable(
                name: "Invoices",
                newName: "Invoice");

            migrationBuilder.RenameTable(
                name: "InvoiceItems",
                newName: "InvoiceItem");

            migrationBuilder.RenameTable(
                name: "DebitMemos",
                newName: "DebitMemo");

            migrationBuilder.RenameTable(
                name: "DebitMemoItems",
                newName: "DebitMemoItem");

            migrationBuilder.RenameTable(
                name: "CustomObjects",
                newName: "CustomObject");

            migrationBuilder.RenameTable(
                name: "CreditMemos",
                newName: "CreditMemo");

            migrationBuilder.RenameTable(
                name: "CreditMemoItems",
                newName: "CreditMemoItem");

            migrationBuilder.RenameTable(
                name: "Contacts",
                newName: "Contact");

            migrationBuilder.RenameTable(
                name: "BillingDocumentSettings",
                newName: "BillingDocumentSetting");

            migrationBuilder.RenameTable(
                name: "BillingDocuments",
                newName: "BillingDocument");

            migrationBuilder.RenameTable(
                name: "BillingDocumentItems",
                newName: "BillingDocumentItem");

            migrationBuilder.RenameTable(
                name: "ArTransactions",
                newName: "ArTransaction");

            migrationBuilder.RenameTable(
                name: "Accounts",
                newName: "Account");

            migrationBuilder.RenameIndex(
                name: "IX_Usages_CustomObjectsId",
                table: "Usage",
                newName: "IX_Usage_CustomObjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_Usages_CustomFieldsId",
                table: "Usage",
                newName: "IX_Usage_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_Usages_AccountId1",
                table: "Usage",
                newName: "IX_Usage_AccountId1");

            migrationBuilder.RenameIndex(
                name: "IX_TaxationItems_InvoiceItemId",
                table: "TaxationItem",
                newName: "IX_TaxationItem_InvoiceItemId");

            migrationBuilder.RenameIndex(
                name: "IX_TaxationItems_DebitMemoItemId",
                table: "TaxationItem",
                newName: "IX_TaxationItem_DebitMemoItemId");

            migrationBuilder.RenameIndex(
                name: "IX_TaxationItems_CustomObjectsId",
                table: "TaxationItem",
                newName: "IX_TaxationItem_CustomObjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_TaxationItems_CustomFieldsId",
                table: "TaxationItem",
                newName: "IX_TaxationItem_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_TaxationItems_CreditMemoItemId",
                table: "TaxationItem",
                newName: "IX_TaxationItem_CreditMemoItemId");

            migrationBuilder.RenameIndex(
                name: "IX_TaxationItems_BillingDocumentItemId",
                table: "TaxationItem",
                newName: "IX_TaxationItem_BillingDocumentItemId");

            migrationBuilder.RenameIndex(
                name: "IX_SubscriptionTerms_RenewalTermId",
                table: "SubscriptionTerm",
                newName: "IX_SubscriptionTerm_RenewalTermId");

            migrationBuilder.RenameIndex(
                name: "IX_SubscriptionTerms_CurrentTermId",
                table: "SubscriptionTerm",
                newName: "IX_SubscriptionTerm_CurrentTermId");

            migrationBuilder.RenameIndex(
                name: "IX_Subscriptions_SoldToId1",
                table: "Subscription",
                newName: "IX_Subscription_SoldToId1");

            migrationBuilder.RenameIndex(
                name: "IX_Subscriptions_RenewalTermId",
                table: "Subscription",
                newName: "IX_Subscription_RenewalTermId");

            migrationBuilder.RenameIndex(
                name: "IX_Subscriptions_OrderId",
                table: "Subscription",
                newName: "IX_Subscription_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Subscriptions_InvoiceOwnerAccountId1",
                table: "Subscription",
                newName: "IX_Subscription_InvoiceOwnerAccountId1");

            migrationBuilder.RenameIndex(
                name: "IX_Subscriptions_InitialTermId",
                table: "Subscription",
                newName: "IX_Subscription_InitialTermId");

            migrationBuilder.RenameIndex(
                name: "IX_Subscriptions_CustomObjectsId",
                table: "Subscription",
                newName: "IX_Subscription_CustomObjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_Subscriptions_CustomFieldsId",
                table: "Subscription",
                newName: "IX_Subscription_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_Subscriptions_CurrentTermId",
                table: "Subscription",
                newName: "IX_Subscription_CurrentTermId");

            migrationBuilder.RenameIndex(
                name: "IX_Subscriptions_BillToId1",
                table: "Subscription",
                newName: "IX_Subscription_BillToId1");

            migrationBuilder.RenameIndex(
                name: "IX_Subscriptions_BillingDocumentSettingsId",
                table: "Subscription",
                newName: "IX_Subscription_BillingDocumentSettingsId");

            migrationBuilder.RenameIndex(
                name: "IX_Subscriptions_AccountId1",
                table: "Subscription",
                newName: "IX_Subscription_AccountId1");

            migrationBuilder.RenameIndex(
                name: "IX_SubscriptionRenews_TermsId",
                table: "SubscriptionRenew",
                newName: "IX_SubscriptionRenew_TermsId");

            migrationBuilder.RenameIndex(
                name: "IX_SubscriptionPlans_SubscriptionId1",
                table: "SubscriptionPlan",
                newName: "IX_SubscriptionPlan_SubscriptionId1");

            migrationBuilder.RenameIndex(
                name: "IX_SubscriptionPlans_ProductId1",
                table: "SubscriptionPlan",
                newName: "IX_SubscriptionPlan_ProductId1");

            migrationBuilder.RenameIndex(
                name: "IX_SubscriptionPlans_PlanId1",
                table: "SubscriptionPlan",
                newName: "IX_SubscriptionPlan_PlanId1");

            migrationBuilder.RenameIndex(
                name: "IX_SubscriptionPlans_CustomObjectsId",
                table: "SubscriptionPlan",
                newName: "IX_SubscriptionPlan_CustomObjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_SubscriptionPlans_CustomFieldsId",
                table: "SubscriptionPlan",
                newName: "IX_SubscriptionPlan_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_SubscriptionPauses_ResumeBehaviorId",
                table: "SubscriptionPause",
                newName: "IX_SubscriptionPause_ResumeBehaviorId");

            migrationBuilder.RenameIndex(
                name: "IX_SubscriptionPauses_CustomFieldsId",
                table: "SubscriptionPause",
                newName: "IX_SubscriptionPause_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_SubscriptionItems_SubscriptionPlanId1",
                table: "SubscriptionItem",
                newName: "IX_SubscriptionItem_SubscriptionPlanId1");

            migrationBuilder.RenameIndex(
                name: "IX_SubscriptionItems_SubscriptionAddPlanId",
                table: "SubscriptionItem",
                newName: "IX_SubscriptionItem_SubscriptionAddPlanId");

            migrationBuilder.RenameIndex(
                name: "IX_SubscriptionItems_RecurringId",
                table: "SubscriptionItem",
                newName: "IX_SubscriptionItem_RecurringId");

            migrationBuilder.RenameIndex(
                name: "IX_SubscriptionItems_PriceId1",
                table: "SubscriptionItem",
                newName: "IX_SubscriptionItem_PriceId1");

            migrationBuilder.RenameIndex(
                name: "IX_SubscriptionItems_OverageId",
                table: "SubscriptionItem",
                newName: "IX_SubscriptionItem_OverageId");

            migrationBuilder.RenameIndex(
                name: "IX_SubscriptionItems_CustomObjectsId",
                table: "SubscriptionItem",
                newName: "IX_SubscriptionItem_CustomObjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_SubscriptionItems_CustomFieldsId",
                table: "SubscriptionItem",
                newName: "IX_SubscriptionItem_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_SubscriptionAddPlans_CustomFieldsId",
                table: "SubscriptionAddPlan",
                newName: "IX_SubscriptionAddPlan_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_RefundTransactions_StateId",
                table: "RefundTransaction",
                newName: "IX_RefundTransaction_StateId");

            migrationBuilder.RenameIndex(
                name: "IX_RefundTransactions_ArTransactionsId",
                table: "RefundTransaction",
                newName: "IX_RefundTransaction_ArTransactionsId");

            migrationBuilder.RenameIndex(
                name: "IX_Refunds_StateTransitionsId",
                table: "Refund",
                newName: "IX_Refund_StateTransitionsId");

            migrationBuilder.RenameIndex(
                name: "IX_Refunds_RefundTransactionsId",
                table: "Refund",
                newName: "IX_Refund_RefundTransactionsId");

            migrationBuilder.RenameIndex(
                name: "IX_Refunds_PaymentMethodId1",
                table: "Refund",
                newName: "IX_Refund_PaymentMethodId1");

            migrationBuilder.RenameIndex(
                name: "IX_Refunds_GatewayOptionsId",
                table: "Refund",
                newName: "IX_Refund_GatewayOptionsId");

            migrationBuilder.RenameIndex(
                name: "IX_Refunds_CustomObjectsId",
                table: "Refund",
                newName: "IX_Refund_CustomObjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_Refunds_CustomFieldsId",
                table: "Refund",
                newName: "IX_Refund_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_Refunds_CreditMemoId",
                table: "Refund",
                newName: "IX_Refund_CreditMemoId");

            migrationBuilder.RenameIndex(
                name: "IX_Refunds_AccountId1",
                table: "Refund",
                newName: "IX_Refund_AccountId1");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CustomObjectsId",
                table: "Product",
                newName: "IX_Product_CustomObjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CustomFieldsId",
                table: "Product",
                newName: "IX_Product_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentTransactions_StateId",
                table: "PaymentTransaction",
                newName: "IX_PaymentTransaction_StateId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentTransactions_ArTransactionsId",
                table: "PaymentTransaction",
                newName: "IX_PaymentTransaction_ArTransactionsId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentScheduleItems_PaymentScheduleId1",
                table: "PaymentScheduleItem",
                newName: "IX_PaymentScheduleItem_PaymentScheduleId1");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentScheduleItems_PaymentId",
                table: "PaymentScheduleItem",
                newName: "IX_PaymentScheduleItem_PaymentId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentScheduleItems_CustomObjectsId",
                table: "PaymentScheduleItem",
                newName: "IX_PaymentScheduleItem_CustomObjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentScheduleItems_CustomFieldsId",
                table: "PaymentScheduleItem",
                newName: "IX_PaymentScheduleItem_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentScheduleItems_BillingDocumentId",
                table: "PaymentScheduleItem",
                newName: "IX_PaymentScheduleItem_BillingDocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_StateTransitionsId",
                table: "Payment",
                newName: "IX_Payment_StateTransitionsId");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_PaymentTransactionsId",
                table: "Payment",
                newName: "IX_Payment_PaymentTransactionsId");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_PaymentMethodId1",
                table: "Payment",
                newName: "IX_Payment_PaymentMethodId1");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_GatewayStateTransitionsId",
                table: "Payment",
                newName: "IX_Payment_GatewayStateTransitionsId");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_GatewayOptionsId",
                table: "Payment",
                newName: "IX_Payment_GatewayOptionsId");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_CustomObjectsId",
                table: "Payment",
                newName: "IX_Payment_CustomObjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_CustomFieldsId",
                table: "Payment",
                newName: "IX_Payment_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_AccountId1",
                table: "Payment",
                newName: "IX_Payment_AccountId1");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethods_SepaDebitId",
                table: "PaymentMethod",
                newName: "IX_PaymentMethod_SepaDebitId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethods_PaypalExpressNativeId",
                table: "PaymentMethod",
                newName: "IX_PaymentMethod_PaypalExpressNativeId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethods_PaypalExpressId",
                table: "PaymentMethod",
                newName: "IX_PaymentMethod_PaypalExpressId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethods_PaypalAdaptiveId",
                table: "PaymentMethod",
                newName: "IX_PaymentMethod_PaypalAdaptiveId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethods_PadDebitId",
                table: "PaymentMethod",
                newName: "IX_PaymentMethod_PadDebitId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethods_NzBecsDebitId",
                table: "PaymentMethod",
                newName: "IX_PaymentMethod_NzBecsDebitId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethods_GooglePayId",
                table: "PaymentMethod",
                newName: "IX_PaymentMethod_GooglePayId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethods_CustomObjectsId",
                table: "PaymentMethod",
                newName: "IX_PaymentMethod_CustomObjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethods_CustomFieldsId",
                table: "PaymentMethod",
                newName: "IX_PaymentMethod_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethods_CcRefId",
                table: "PaymentMethod",
                newName: "IX_PaymentMethod_CcRefId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethods_CardId",
                table: "PaymentMethod",
                newName: "IX_PaymentMethod_CardId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethods_BillingDetailsId",
                table: "PaymentMethod",
                newName: "IX_PaymentMethod_BillingDetailsId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethods_BetalingsDebitId",
                table: "PaymentMethod",
                newName: "IX_PaymentMethod_BetalingsDebitId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethods_BacsDebitId",
                table: "PaymentMethod",
                newName: "IX_PaymentMethod_BacsDebitId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethods_AutogiroDebitId",
                table: "PaymentMethod",
                newName: "IX_PaymentMethod_AutogiroDebitId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethods_AuBecsDebitId",
                table: "PaymentMethod",
                newName: "IX_PaymentMethod_AuBecsDebitId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethods_ApplePayId",
                table: "PaymentMethod",
                newName: "IX_PaymentMethod_ApplePayId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethods_AchDebitId",
                table: "PaymentMethod",
                newName: "IX_PaymentMethod_AchDebitId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethods_AccountId1",
                table: "PaymentMethod",
                newName: "IX_PaymentMethod_AccountId1");

            migrationBuilder.RenameIndex(
                name: "IX_OrderLineItems_RevenueId",
                table: "OrderLineItem",
                newName: "IX_OrderLineItem_RevenueId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderLineItems_OrderId1",
                table: "OrderLineItem",
                newName: "IX_OrderLineItem_OrderId1");

            migrationBuilder.RenameIndex(
                name: "IX_OrderLineItems_CustomObjectsId",
                table: "OrderLineItem",
                newName: "IX_OrderLineItem_CustomObjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderLineItems_CustomFieldsId",
                table: "OrderLineItem",
                newName: "IX_OrderLineItem_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_Invoices_StateTransitionsId",
                table: "Invoice",
                newName: "IX_Invoice_StateTransitionsId");

            migrationBuilder.RenameIndex(
                name: "IX_Invoices_SoldToId1",
                table: "Invoice",
                newName: "IX_Invoice_SoldToId1");

            migrationBuilder.RenameIndex(
                name: "IX_Invoices_CustomObjectsId",
                table: "Invoice",
                newName: "IX_Invoice_CustomObjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_Invoices_CustomFieldsId",
                table: "Invoice",
                newName: "IX_Invoice_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_Invoices_BillToId1",
                table: "Invoice",
                newName: "IX_Invoice_BillToId1");

            migrationBuilder.RenameIndex(
                name: "IX_Invoices_BillingDocumentSettingsId",
                table: "Invoice",
                newName: "IX_Invoice_BillingDocumentSettingsId");

            migrationBuilder.RenameIndex(
                name: "IX_Invoices_ArTransactionsId",
                table: "Invoice",
                newName: "IX_Invoice_ArTransactionsId");

            migrationBuilder.RenameIndex(
                name: "IX_Invoices_AccountId1",
                table: "Invoice",
                newName: "IX_Invoice_AccountId1");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceItems_SubscriptionItemId1",
                table: "InvoiceItem",
                newName: "IX_InvoiceItem_SubscriptionItemId1");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceItems_SubscriptionId1",
                table: "InvoiceItem",
                newName: "IX_InvoiceItem_SubscriptionId1");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceItems_LineItemId",
                table: "InvoiceItem",
                newName: "IX_InvoiceItem_LineItemId");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceItems_InvoiceId1",
                table: "InvoiceItem",
                newName: "IX_InvoiceItem_InvoiceId1");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceItems_CustomObjectsId",
                table: "InvoiceItem",
                newName: "IX_InvoiceItem_CustomObjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceItems_CustomFieldsId",
                table: "InvoiceItem",
                newName: "IX_InvoiceItem_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_DebitMemos_StateTransitionsId",
                table: "DebitMemo",
                newName: "IX_DebitMemo_StateTransitionsId");

            migrationBuilder.RenameIndex(
                name: "IX_DebitMemos_CustomObjectsId",
                table: "DebitMemo",
                newName: "IX_DebitMemo_CustomObjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_DebitMemos_CustomFieldsId",
                table: "DebitMemo",
                newName: "IX_DebitMemo_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_DebitMemos_BillToId1",
                table: "DebitMemo",
                newName: "IX_DebitMemo_BillToId1");

            migrationBuilder.RenameIndex(
                name: "IX_DebitMemos_BillingDocumentSettingsId",
                table: "DebitMemo",
                newName: "IX_DebitMemo_BillingDocumentSettingsId");

            migrationBuilder.RenameIndex(
                name: "IX_DebitMemos_AccountId1",
                table: "DebitMemo",
                newName: "IX_DebitMemo_AccountId1");

            migrationBuilder.RenameIndex(
                name: "IX_DebitMemoItems_SubscriptionItemId1",
                table: "DebitMemoItem",
                newName: "IX_DebitMemoItem_SubscriptionItemId1");

            migrationBuilder.RenameIndex(
                name: "IX_DebitMemoItems_SubscriptionId1",
                table: "DebitMemoItem",
                newName: "IX_DebitMemoItem_SubscriptionId1");

            migrationBuilder.RenameIndex(
                name: "IX_DebitMemoItems_DebitMemoId1",
                table: "DebitMemoItem",
                newName: "IX_DebitMemoItem_DebitMemoId1");

            migrationBuilder.RenameIndex(
                name: "IX_DebitMemoItems_CustomObjectsId",
                table: "DebitMemoItem",
                newName: "IX_DebitMemoItem_CustomObjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_DebitMemoItems_CustomFieldsId",
                table: "DebitMemoItem",
                newName: "IX_DebitMemoItem_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_CreditMemos_StateTransitionsId",
                table: "CreditMemo",
                newName: "IX_CreditMemo_StateTransitionsId");

            migrationBuilder.RenameIndex(
                name: "IX_CreditMemos_CustomObjectsId",
                table: "CreditMemo",
                newName: "IX_CreditMemo_CustomObjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_CreditMemos_CustomFieldsId",
                table: "CreditMemo",
                newName: "IX_CreditMemo_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_CreditMemos_CreditMemoId",
                table: "CreditMemo",
                newName: "IX_CreditMemo_CreditMemoId");

            migrationBuilder.RenameIndex(
                name: "IX_CreditMemos_BillToId1",
                table: "CreditMemo",
                newName: "IX_CreditMemo_BillToId1");

            migrationBuilder.RenameIndex(
                name: "IX_CreditMemos_ArTransactionsId",
                table: "CreditMemo",
                newName: "IX_CreditMemo_ArTransactionsId");

            migrationBuilder.RenameIndex(
                name: "IX_CreditMemos_AccountId1",
                table: "CreditMemo",
                newName: "IX_CreditMemo_AccountId1");

            migrationBuilder.RenameIndex(
                name: "IX_CreditMemoItems_SubscriptionItemId1",
                table: "CreditMemoItem",
                newName: "IX_CreditMemoItem_SubscriptionItemId1");

            migrationBuilder.RenameIndex(
                name: "IX_CreditMemoItems_SubscriptionId1",
                table: "CreditMemoItem",
                newName: "IX_CreditMemoItem_SubscriptionId1");

            migrationBuilder.RenameIndex(
                name: "IX_CreditMemoItems_CustomObjectsId",
                table: "CreditMemoItem",
                newName: "IX_CreditMemoItem_CustomObjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_CreditMemoItems_CustomFieldsId",
                table: "CreditMemoItem",
                newName: "IX_CreditMemoItem_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_CreditMemoItems_CreditMemoId1",
                table: "CreditMemoItem",
                newName: "IX_CreditMemoItem_CreditMemoId1");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_CustomObjectsId",
                table: "Contact",
                newName: "IX_Contact_CustomObjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_CustomFieldsId",
                table: "Contact",
                newName: "IX_Contact_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_AddressId",
                table: "Contact",
                newName: "IX_Contact_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_BillingDocumentSettings_CreditMemoId",
                table: "BillingDocumentSetting",
                newName: "IX_BillingDocumentSetting_CreditMemoId");

            migrationBuilder.RenameIndex(
                name: "IX_BillingDocuments_CustomObjectsId",
                table: "BillingDocument",
                newName: "IX_BillingDocument_CustomObjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_BillingDocuments_CustomFieldsId",
                table: "BillingDocument",
                newName: "IX_BillingDocument_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_BillingDocumentItems_SubscriptionItemId1",
                table: "BillingDocumentItem",
                newName: "IX_BillingDocumentItem_SubscriptionItemId1");

            migrationBuilder.RenameIndex(
                name: "IX_BillingDocumentItems_SubscriptionId1",
                table: "BillingDocumentItem",
                newName: "IX_BillingDocumentItem_SubscriptionId1");

            migrationBuilder.RenameIndex(
                name: "IX_BillingDocumentItems_PaymentsAppliedToId",
                table: "BillingDocumentItem",
                newName: "IX_BillingDocumentItem_PaymentsAppliedToId");

            migrationBuilder.RenameIndex(
                name: "IX_BillingDocumentItems_CustomObjectsId",
                table: "BillingDocumentItem",
                newName: "IX_BillingDocumentItem_CustomObjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_BillingDocumentItems_CustomFieldsId",
                table: "BillingDocumentItem",
                newName: "IX_BillingDocumentItem_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_BillingDocumentItems_BillingDocumentId1",
                table: "BillingDocumentItem",
                newName: "IX_BillingDocumentItem_BillingDocumentId1");

            migrationBuilder.RenameIndex(
                name: "IX_Accounts_TaxIdentifierId",
                table: "Account",
                newName: "IX_Account_TaxIdentifierId");

            migrationBuilder.RenameIndex(
                name: "IX_Accounts_TaxCertificateId",
                table: "Account",
                newName: "IX_Account_TaxCertificateId");

            migrationBuilder.RenameIndex(
                name: "IX_Accounts_SoldToId1",
                table: "Account",
                newName: "IX_Account_SoldToId1");

            migrationBuilder.RenameIndex(
                name: "IX_Accounts_CustomObjectsId",
                table: "Account",
                newName: "IX_Account_CustomObjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_Accounts_CustomFieldsId",
                table: "Account",
                newName: "IX_Account_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_Accounts_BillToId1",
                table: "Account",
                newName: "IX_Account_BillToId1");

            migrationBuilder.RenameIndex(
                name: "IX_Accounts_BillingDocumentsId",
                table: "Account",
                newName: "IX_Account_BillingDocumentsId");

            migrationBuilder.RenameIndex(
                name: "IX_Accounts_BillingDocumentSettingsId",
                table: "Account",
                newName: "IX_Account_BillingDocumentSettingsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usage",
                table: "Usage",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaxIdentifier",
                table: "TaxIdentifier",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaxCertificate",
                table: "TaxCertificate",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaxationItem",
                table: "TaxationItem",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubscriptionTerm",
                table: "SubscriptionTerm",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subscription",
                table: "Subscription",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubscriptionRenew",
                table: "SubscriptionRenew",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubscriptionRemovePlan",
                table: "SubscriptionRemovePlan",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubscriptionPlan",
                table: "SubscriptionPlan",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubscriptionPause",
                table: "SubscriptionPause",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubscriptionItem",
                table: "SubscriptionItem",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubscriptionCancel",
                table: "SubscriptionCancel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubscriptionAddPlan",
                table: "SubscriptionAddPlan",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RefundTransaction",
                table: "RefundTransaction",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Refund",
                table: "Refund",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentTransaction",
                table: "PaymentTransaction",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentScheduleItem",
                table: "PaymentScheduleItem",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payment",
                table: "Payment",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentMethod",
                table: "PaymentMethod",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderLineItem",
                table: "OrderLineItem",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Invoice",
                table: "Invoice",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InvoiceItem",
                table: "InvoiceItem",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DebitMemo",
                table: "DebitMemo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DebitMemoItem",
                table: "DebitMemoItem",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomObject",
                table: "CustomObject",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CreditMemo",
                table: "CreditMemo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CreditMemoItem",
                table: "CreditMemoItem",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contact",
                table: "Contact",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BillingDocumentSetting",
                table: "BillingDocumentSetting",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BillingDocument",
                table: "BillingDocument",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BillingDocumentItem",
                table: "BillingDocumentItem",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArTransaction",
                table: "ArTransaction",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Account",
                table: "Account",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Account_BillingDocumentSetting_BillingDocumentSettingsId",
                table: "Account",
                column: "BillingDocumentSettingsId",
                principalTable: "BillingDocumentSetting",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Account_BillingDocument_BillingDocumentsId",
                table: "Account",
                column: "BillingDocumentsId",
                principalTable: "BillingDocument",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Account_Contact_BillToId1",
                table: "Account",
                column: "BillToId1",
                principalTable: "Contact",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Account_Contact_SoldToId1",
                table: "Account",
                column: "SoldToId1",
                principalTable: "Contact",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Account_CustomFields_CustomFieldsId",
                table: "Account",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Account_CustomObject_CustomObjectsId",
                table: "Account",
                column: "CustomObjectsId",
                principalTable: "CustomObject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Account_TaxCertificate_TaxCertificateId",
                table: "Account",
                column: "TaxCertificateId",
                principalTable: "TaxCertificate",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Account_TaxIdentifier_TaxIdentifierId",
                table: "Account",
                column: "TaxIdentifierId",
                principalTable: "TaxIdentifier",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BillingDocument_CustomFields_CustomFieldsId",
                table: "BillingDocument",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BillingDocument_CustomObject_CustomObjectsId",
                table: "BillingDocument",
                column: "CustomObjectsId",
                principalTable: "CustomObject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BillingDocumentItem_BillingDocument_BillingDocumentId1",
                table: "BillingDocumentItem",
                column: "BillingDocumentId1",
                principalTable: "BillingDocument",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BillingDocumentItem_CustomFields_CustomFieldsId",
                table: "BillingDocumentItem",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BillingDocumentItem_CustomObject_CustomObjectsId",
                table: "BillingDocumentItem",
                column: "CustomObjectsId",
                principalTable: "CustomObject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BillingDocumentItem_PaymentsAppliedTo_PaymentsAppliedToId",
                table: "BillingDocumentItem",
                column: "PaymentsAppliedToId",
                principalTable: "PaymentsAppliedTo",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BillingDocumentItem_SubscriptionItem_SubscriptionItemId1",
                table: "BillingDocumentItem",
                column: "SubscriptionItemId1",
                principalTable: "SubscriptionItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BillingDocumentItem_Subscription_SubscriptionId1",
                table: "BillingDocumentItem",
                column: "SubscriptionId1",
                principalTable: "Subscription",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BillingDocumentSetting_CreditMemo_CreditMemoId",
                table: "BillingDocumentSetting",
                column: "CreditMemoId",
                principalTable: "CreditMemo",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BillingDocumentStateTransitions_BillingDocument_BillingDocumentId",
                table: "BillingDocumentStateTransitions",
                column: "BillingDocumentId",
                principalTable: "BillingDocument",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Address_AddressId",
                table: "Contact",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_CustomFields_CustomFieldsId",
                table: "Contact",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_CustomObject_CustomObjectsId",
                table: "Contact",
                column: "CustomObjectsId",
                principalTable: "CustomObject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreditMemo_Account_AccountId1",
                table: "CreditMemo",
                column: "AccountId1",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreditMemo_ArTransaction_ArTransactionsId",
                table: "CreditMemo",
                column: "ArTransactionsId",
                principalTable: "ArTransaction",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CreditMemo_Contact_BillToId1",
                table: "CreditMemo",
                column: "BillToId1",
                principalTable: "Contact",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreditMemo_CreditMemo_CreditMemoId",
                table: "CreditMemo",
                column: "CreditMemoId",
                principalTable: "CreditMemo",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CreditMemo_CustomFields_CustomFieldsId",
                table: "CreditMemo",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreditMemo_CustomObject_CustomObjectsId",
                table: "CreditMemo",
                column: "CustomObjectsId",
                principalTable: "CustomObject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreditMemo_StateTransitions_StateTransitionsId",
                table: "CreditMemo",
                column: "StateTransitionsId",
                principalTable: "StateTransitions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreditMemoAppliedTo_BillingDocument_BillingDocumentId1",
                table: "CreditMemoAppliedTo",
                column: "BillingDocumentId1",
                principalTable: "BillingDocument",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreditMemoItem_CreditMemo_CreditMemoId1",
                table: "CreditMemoItem",
                column: "CreditMemoId1",
                principalTable: "CreditMemo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreditMemoItem_CustomFields_CustomFieldsId",
                table: "CreditMemoItem",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreditMemoItem_CustomObject_CustomObjectsId",
                table: "CreditMemoItem",
                column: "CustomObjectsId",
                principalTable: "CustomObject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreditMemoItem_SubscriptionItem_SubscriptionItemId1",
                table: "CreditMemoItem",
                column: "SubscriptionItemId1",
                principalTable: "SubscriptionItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreditMemoItem_Subscription_SubscriptionId1",
                table: "CreditMemoItem",
                column: "SubscriptionId1",
                principalTable: "Subscription",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DebitMemo_Account_AccountId1",
                table: "DebitMemo",
                column: "AccountId1",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DebitMemo_BillingDocumentSetting_BillingDocumentSettingsId",
                table: "DebitMemo",
                column: "BillingDocumentSettingsId",
                principalTable: "BillingDocumentSetting",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DebitMemo_Contact_BillToId1",
                table: "DebitMemo",
                column: "BillToId1",
                principalTable: "Contact",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DebitMemo_CustomFields_CustomFieldsId",
                table: "DebitMemo",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DebitMemo_CustomObject_CustomObjectsId",
                table: "DebitMemo",
                column: "CustomObjectsId",
                principalTable: "CustomObject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DebitMemo_StateTransitions_StateTransitionsId",
                table: "DebitMemo",
                column: "StateTransitionsId",
                principalTable: "StateTransitions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DebitMemoItem_CustomFields_CustomFieldsId",
                table: "DebitMemoItem",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DebitMemoItem_CustomObject_CustomObjectsId",
                table: "DebitMemoItem",
                column: "CustomObjectsId",
                principalTable: "CustomObject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DebitMemoItem_DebitMemo_DebitMemoId1",
                table: "DebitMemoItem",
                column: "DebitMemoId1",
                principalTable: "DebitMemo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DebitMemoItem_SubscriptionItem_SubscriptionItemId1",
                table: "DebitMemoItem",
                column: "SubscriptionItemId1",
                principalTable: "SubscriptionItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DebitMemoItem_Subscription_SubscriptionId1",
                table: "DebitMemoItem",
                column: "SubscriptionId1",
                principalTable: "Subscription",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_Account_AccountId1",
                table: "Invoice",
                column: "AccountId1",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_ArTransaction_ArTransactionsId",
                table: "Invoice",
                column: "ArTransactionsId",
                principalTable: "ArTransaction",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_BillingDocumentSetting_BillingDocumentSettingsId",
                table: "Invoice",
                column: "BillingDocumentSettingsId",
                principalTable: "BillingDocumentSetting",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_Contact_BillToId1",
                table: "Invoice",
                column: "BillToId1",
                principalTable: "Contact",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_Contact_SoldToId1",
                table: "Invoice",
                column: "SoldToId1",
                principalTable: "Contact",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_CustomFields_CustomFieldsId",
                table: "Invoice",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_CustomObject_CustomObjectsId",
                table: "Invoice",
                column: "CustomObjectsId",
                principalTable: "CustomObject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_StateTransitions_StateTransitionsId",
                table: "Invoice",
                column: "StateTransitionsId",
                principalTable: "StateTransitions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceItem_CustomFields_CustomFieldsId",
                table: "InvoiceItem",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceItem_CustomObject_CustomObjectsId",
                table: "InvoiceItem",
                column: "CustomObjectsId",
                principalTable: "CustomObject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceItem_Invoice_InvoiceId1",
                table: "InvoiceItem",
                column: "InvoiceId1",
                principalTable: "Invoice",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceItem_OrderLineItem_LineItemId",
                table: "InvoiceItem",
                column: "LineItemId",
                principalTable: "OrderLineItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceItem_SubscriptionItem_SubscriptionItemId1",
                table: "InvoiceItem",
                column: "SubscriptionItemId1",
                principalTable: "SubscriptionItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceItem_Subscription_SubscriptionId1",
                table: "InvoiceItem",
                column: "SubscriptionId1",
                principalTable: "Subscription",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemTier_SubscriptionItem_SubscriptionItemId",
                table: "ItemTier",
                column: "SubscriptionItemId",
                principalTable: "SubscriptionItem",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Account_AccountId1",
                table: "Order",
                column: "AccountId1",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_CustomObject_CustomObjectsId",
                table: "Order",
                column: "CustomObjectsId",
                principalTable: "CustomObject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderLineItem_CustomFields_CustomFieldsId",
                table: "OrderLineItem",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderLineItem_CustomObject_CustomObjectsId",
                table: "OrderLineItem",
                column: "CustomObjectsId",
                principalTable: "CustomObject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderLineItem_OrderLineItemRevenue_RevenueId",
                table: "OrderLineItem",
                column: "RevenueId",
                principalTable: "OrderLineItemRevenue",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderLineItem_Order_OrderId1",
                table: "OrderLineItem",
                column: "OrderId1",
                principalTable: "Order",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Account_AccountId1",
                table: "Payment",
                column: "AccountId1",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_CustomFields_CustomFieldsId",
                table: "Payment",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_CustomObject_CustomObjectsId",
                table: "Payment",
                column: "CustomObjectsId",
                principalTable: "CustomObject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_GatewayOptions_GatewayOptionsId",
                table: "Payment",
                column: "GatewayOptionsId",
                principalTable: "GatewayOptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_GatewayStateTransitions_GatewayStateTransitionsId",
                table: "Payment",
                column: "GatewayStateTransitionsId",
                principalTable: "GatewayStateTransitions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_PaymentMethod_PaymentMethodId1",
                table: "Payment",
                column: "PaymentMethodId1",
                principalTable: "PaymentMethod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_PaymentStateTransitions_StateTransitionsId",
                table: "Payment",
                column: "StateTransitionsId",
                principalTable: "PaymentStateTransitions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_PaymentTransaction_PaymentTransactionsId",
                table: "Payment",
                column: "PaymentTransactionsId",
                principalTable: "PaymentTransaction",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethod_Account_AccountId1",
                table: "PaymentMethod",
                column: "AccountId1",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethod_AchDebit_AchDebitId",
                table: "PaymentMethod",
                column: "AchDebitId",
                principalTable: "AchDebit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethod_ApplePay_ApplePayId",
                table: "PaymentMethod",
                column: "ApplePayId",
                principalTable: "ApplePay",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethod_AuBecsDebit_AuBecsDebitId",
                table: "PaymentMethod",
                column: "AuBecsDebitId",
                principalTable: "AuBecsDebit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethod_AutogiroDebit_AutogiroDebitId",
                table: "PaymentMethod",
                column: "AutogiroDebitId",
                principalTable: "AutogiroDebit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethod_BacsDebit_BacsDebitId",
                table: "PaymentMethod",
                column: "BacsDebitId",
                principalTable: "BacsDebit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethod_BetalingsDebit_BetalingsDebitId",
                table: "PaymentMethod",
                column: "BetalingsDebitId",
                principalTable: "BetalingsDebit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethod_BillingDetails_BillingDetailsId",
                table: "PaymentMethod",
                column: "BillingDetailsId",
                principalTable: "BillingDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethod_CcRef_CcRefId",
                table: "PaymentMethod",
                column: "CcRefId",
                principalTable: "CcRef",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethod_CustomFields_CustomFieldsId",
                table: "PaymentMethod",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethod_CustomObject_CustomObjectsId",
                table: "PaymentMethod",
                column: "CustomObjectsId",
                principalTable: "CustomObject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethod_GetCardList_CardId",
                table: "PaymentMethod",
                column: "CardId",
                principalTable: "GetCardList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethod_GooglePay_GooglePayId",
                table: "PaymentMethod",
                column: "GooglePayId",
                principalTable: "GooglePay",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethod_NzBecsDebit_NzBecsDebitId",
                table: "PaymentMethod",
                column: "NzBecsDebitId",
                principalTable: "NzBecsDebit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethod_PadDebit_PadDebitId",
                table: "PaymentMethod",
                column: "PadDebitId",
                principalTable: "PadDebit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethod_PaypalAdaptive_PaypalAdaptiveId",
                table: "PaymentMethod",
                column: "PaypalAdaptiveId",
                principalTable: "PaypalAdaptive",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethod_PaypalExpressNative_PaypalExpressNativeId",
                table: "PaymentMethod",
                column: "PaypalExpressNativeId",
                principalTable: "PaypalExpressNative",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethod_PaypalExpress_PaypalExpressId",
                table: "PaymentMethod",
                column: "PaypalExpressId",
                principalTable: "PaypalExpress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethod_SepaDebit_SepaDebitId",
                table: "PaymentMethod",
                column: "SepaDebitId",
                principalTable: "SepaDebit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentsAppliedTo_BillingDocument_BillingDocumentId1",
                table: "PaymentsAppliedTo",
                column: "BillingDocumentId1",
                principalTable: "BillingDocument",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentsAppliedTo_Payment_PaymentId",
                table: "PaymentsAppliedTo",
                column: "PaymentId",
                principalTable: "Payment",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentSchedule_BillingDocument_BillingDocumentId",
                table: "PaymentSchedule",
                column: "BillingDocumentId",
                principalTable: "BillingDocument",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentSchedule_CustomObject_CustomObjectsId",
                table: "PaymentSchedule",
                column: "CustomObjectsId",
                principalTable: "CustomObject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentScheduleItem_BillingDocument_BillingDocumentId",
                table: "PaymentScheduleItem",
                column: "BillingDocumentId",
                principalTable: "BillingDocument",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentScheduleItem_CustomFields_CustomFieldsId",
                table: "PaymentScheduleItem",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentScheduleItem_CustomObject_CustomObjectsId",
                table: "PaymentScheduleItem",
                column: "CustomObjectsId",
                principalTable: "CustomObject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentScheduleItem_PaymentSchedule_PaymentScheduleId1",
                table: "PaymentScheduleItem",
                column: "PaymentScheduleId1",
                principalTable: "PaymentSchedule",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentScheduleItem_Payment_PaymentId",
                table: "PaymentScheduleItem",
                column: "PaymentId",
                principalTable: "Payment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentScheduleItemPayments_PaymentScheduleItem_PaymentScheduleItemId",
                table: "PaymentScheduleItemPayments",
                column: "PaymentScheduleItemId",
                principalTable: "PaymentScheduleItem",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentTransaction_ArTransaction_ArTransactionsId",
                table: "PaymentTransaction",
                column: "ArTransactionsId",
                principalTable: "ArTransaction",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentTransaction_TransactionsState_StateId",
                table: "PaymentTransaction",
                column: "StateId",
                principalTable: "TransactionsState",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Plan_CustomObject_CustomObjectsId",
                table: "Plan",
                column: "CustomObjectsId",
                principalTable: "CustomObject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Plan_Product_ProductId1",
                table: "Plan",
                column: "ProductId1",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PrepaidBalance_Subscription_SubscriptionId",
                table: "PrepaidBalance",
                column: "SubscriptionId",
                principalTable: "Subscription",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PrepaidBalances_Subscription_SubscriptionId",
                table: "PrepaidBalances",
                column: "SubscriptionId",
                principalTable: "Subscription",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Price_CustomObject_CustomObjectsId",
                table: "Price",
                column: "CustomObjectsId",
                principalTable: "CustomObject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_CustomFields_CustomFieldsId",
                table: "Product",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_CustomObject_CustomObjectsId",
                table: "Product",
                column: "CustomObjectsId",
                principalTable: "CustomObject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductPlan_CustomObject_CustomObjectsId",
                table: "ProductPlan",
                column: "CustomObjectsId",
                principalTable: "CustomObject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductPlan_Product_ProductId1",
                table: "ProductPlan",
                column: "ProductId1",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductPrice_CustomObject_CustomObjectsId",
                table: "ProductPrice",
                column: "CustomObjectsId",
                principalTable: "CustomObject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Refund_Account_AccountId1",
                table: "Refund",
                column: "AccountId1",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Refund_CreditMemo_CreditMemoId",
                table: "Refund",
                column: "CreditMemoId",
                principalTable: "CreditMemo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Refund_CustomFields_CustomFieldsId",
                table: "Refund",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Refund_CustomObject_CustomObjectsId",
                table: "Refund",
                column: "CustomObjectsId",
                principalTable: "CustomObject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Refund_GatewayOptions_GatewayOptionsId",
                table: "Refund",
                column: "GatewayOptionsId",
                principalTable: "GatewayOptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Refund_PaymentMethod_PaymentMethodId1",
                table: "Refund",
                column: "PaymentMethodId1",
                principalTable: "PaymentMethod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Refund_RefundStateTransitions_StateTransitionsId",
                table: "Refund",
                column: "StateTransitionsId",
                principalTable: "RefundStateTransitions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Refund_RefundTransaction_RefundTransactionsId",
                table: "Refund",
                column: "RefundTransactionsId",
                principalTable: "RefundTransaction",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RefundsAppliedTo_BillingDocument_BillingDocumentId1",
                table: "RefundsAppliedTo",
                column: "BillingDocumentId1",
                principalTable: "BillingDocument",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RefundsAppliedTo_Payment_PaymentId",
                table: "RefundsAppliedTo",
                column: "PaymentId",
                principalTable: "Payment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RefundsAppliedTo_Refund_RefundId",
                table: "RefundsAppliedTo",
                column: "RefundId",
                principalTable: "Refund",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RefundTransaction_ArTransaction_ArTransactionsId",
                table: "RefundTransaction",
                column: "ArTransactionsId",
                principalTable: "ArTransaction",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RefundTransaction_TransactionsState_StateId",
                table: "RefundTransaction",
                column: "StateId",
                principalTable: "TransactionsState",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscription_Account_AccountId1",
                table: "Subscription",
                column: "AccountId1",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscription_Account_InvoiceOwnerAccountId1",
                table: "Subscription",
                column: "InvoiceOwnerAccountId1",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscription_BillingDocumentSetting_BillingDocumentSettingsId",
                table: "Subscription",
                column: "BillingDocumentSettingsId",
                principalTable: "BillingDocumentSetting",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscription_Contact_BillToId1",
                table: "Subscription",
                column: "BillToId1",
                principalTable: "Contact",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscription_Contact_SoldToId1",
                table: "Subscription",
                column: "SoldToId1",
                principalTable: "Contact",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscription_CustomFields_CustomFieldsId",
                table: "Subscription",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscription_CustomObject_CustomObjectsId",
                table: "Subscription",
                column: "CustomObjectsId",
                principalTable: "CustomObject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscription_Order_OrderId",
                table: "Subscription",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Subscription_Term_CurrentTermId",
                table: "Subscription",
                column: "CurrentTermId",
                principalTable: "Term",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscription_Term_InitialTermId",
                table: "Subscription",
                column: "InitialTermId",
                principalTable: "Term",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscription_Term_RenewalTermId",
                table: "Subscription",
                column: "RenewalTermId",
                principalTable: "Term",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionAddPlan_CustomFields_CustomFieldsId",
                table: "SubscriptionAddPlan",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionItem_CustomFields_CustomFieldsId",
                table: "SubscriptionItem",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionItem_CustomObject_CustomObjectsId",
                table: "SubscriptionItem",
                column: "CustomObjectsId",
                principalTable: "CustomObject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionItem_Overage_OverageId",
                table: "SubscriptionItem",
                column: "OverageId",
                principalTable: "Overage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionItem_Price_PriceId1",
                table: "SubscriptionItem",
                column: "PriceId1",
                principalTable: "Price",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionItem_Recurring_RecurringId",
                table: "SubscriptionItem",
                column: "RecurringId",
                principalTable: "Recurring",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionItem_SubscriptionAddPlan_SubscriptionAddPlanId",
                table: "SubscriptionItem",
                column: "SubscriptionAddPlanId",
                principalTable: "SubscriptionAddPlan",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionItem_SubscriptionPlan_SubscriptionPlanId1",
                table: "SubscriptionItem",
                column: "SubscriptionPlanId1",
                principalTable: "SubscriptionPlan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionPause_CustomFields_CustomFieldsId",
                table: "SubscriptionPause",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionPause_ResumeSubscription_ResumeBehaviorId",
                table: "SubscriptionPause",
                column: "ResumeBehaviorId",
                principalTable: "ResumeSubscription",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionPlan_CustomFields_CustomFieldsId",
                table: "SubscriptionPlan",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionPlan_CustomObject_CustomObjectsId",
                table: "SubscriptionPlan",
                column: "CustomObjectsId",
                principalTable: "CustomObject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionPlan_Plan_PlanId1",
                table: "SubscriptionPlan",
                column: "PlanId1",
                principalTable: "Plan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionPlan_Product_ProductId1",
                table: "SubscriptionPlan",
                column: "ProductId1",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionPlan_Subscription_SubscriptionId1",
                table: "SubscriptionPlan",
                column: "SubscriptionId1",
                principalTable: "Subscription",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionRenew_SubscriptionTerm_TermsId",
                table: "SubscriptionRenew",
                column: "TermsId",
                principalTable: "SubscriptionTerm",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionTerm_Term_CurrentTermId",
                table: "SubscriptionTerm",
                column: "CurrentTermId",
                principalTable: "Term",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionTerm_Term_RenewalTermId",
                table: "SubscriptionTerm",
                column: "RenewalTermId",
                principalTable: "Term",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaxationItem_BillingDocumentItem_BillingDocumentItemId",
                table: "TaxationItem",
                column: "BillingDocumentItemId",
                principalTable: "BillingDocumentItem",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TaxationItem_CreditMemoItem_CreditMemoItemId",
                table: "TaxationItem",
                column: "CreditMemoItemId",
                principalTable: "CreditMemoItem",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TaxationItem_CustomFields_CustomFieldsId",
                table: "TaxationItem",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaxationItem_CustomObject_CustomObjectsId",
                table: "TaxationItem",
                column: "CustomObjectsId",
                principalTable: "CustomObject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaxationItem_DebitMemoItem_DebitMemoItemId",
                table: "TaxationItem",
                column: "DebitMemoItemId",
                principalTable: "DebitMemoItem",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TaxationItem_InvoiceItem_InvoiceItemId",
                table: "TaxationItem",
                column: "InvoiceItemId",
                principalTable: "InvoiceItem",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Usage_Account_AccountId1",
                table: "Usage",
                column: "AccountId1",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usage_CustomFields_CustomFieldsId",
                table: "Usage",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usage_CustomObject_CustomObjectsId",
                table: "Usage",
                column: "CustomObjectsId",
                principalTable: "CustomObject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Account_BillingDocumentSetting_BillingDocumentSettingsId",
                table: "Account");

            migrationBuilder.DropForeignKey(
                name: "FK_Account_BillingDocument_BillingDocumentsId",
                table: "Account");

            migrationBuilder.DropForeignKey(
                name: "FK_Account_Contact_BillToId1",
                table: "Account");

            migrationBuilder.DropForeignKey(
                name: "FK_Account_Contact_SoldToId1",
                table: "Account");

            migrationBuilder.DropForeignKey(
                name: "FK_Account_CustomFields_CustomFieldsId",
                table: "Account");

            migrationBuilder.DropForeignKey(
                name: "FK_Account_CustomObject_CustomObjectsId",
                table: "Account");

            migrationBuilder.DropForeignKey(
                name: "FK_Account_TaxCertificate_TaxCertificateId",
                table: "Account");

            migrationBuilder.DropForeignKey(
                name: "FK_Account_TaxIdentifier_TaxIdentifierId",
                table: "Account");

            migrationBuilder.DropForeignKey(
                name: "FK_BillingDocument_CustomFields_CustomFieldsId",
                table: "BillingDocument");

            migrationBuilder.DropForeignKey(
                name: "FK_BillingDocument_CustomObject_CustomObjectsId",
                table: "BillingDocument");

            migrationBuilder.DropForeignKey(
                name: "FK_BillingDocumentItem_BillingDocument_BillingDocumentId1",
                table: "BillingDocumentItem");

            migrationBuilder.DropForeignKey(
                name: "FK_BillingDocumentItem_CustomFields_CustomFieldsId",
                table: "BillingDocumentItem");

            migrationBuilder.DropForeignKey(
                name: "FK_BillingDocumentItem_CustomObject_CustomObjectsId",
                table: "BillingDocumentItem");

            migrationBuilder.DropForeignKey(
                name: "FK_BillingDocumentItem_PaymentsAppliedTo_PaymentsAppliedToId",
                table: "BillingDocumentItem");

            migrationBuilder.DropForeignKey(
                name: "FK_BillingDocumentItem_SubscriptionItem_SubscriptionItemId1",
                table: "BillingDocumentItem");

            migrationBuilder.DropForeignKey(
                name: "FK_BillingDocumentItem_Subscription_SubscriptionId1",
                table: "BillingDocumentItem");

            migrationBuilder.DropForeignKey(
                name: "FK_BillingDocumentSetting_CreditMemo_CreditMemoId",
                table: "BillingDocumentSetting");

            migrationBuilder.DropForeignKey(
                name: "FK_BillingDocumentStateTransitions_BillingDocument_BillingDocumentId",
                table: "BillingDocumentStateTransitions");

            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Address_AddressId",
                table: "Contact");

            migrationBuilder.DropForeignKey(
                name: "FK_Contact_CustomFields_CustomFieldsId",
                table: "Contact");

            migrationBuilder.DropForeignKey(
                name: "FK_Contact_CustomObject_CustomObjectsId",
                table: "Contact");

            migrationBuilder.DropForeignKey(
                name: "FK_CreditMemo_Account_AccountId1",
                table: "CreditMemo");

            migrationBuilder.DropForeignKey(
                name: "FK_CreditMemo_ArTransaction_ArTransactionsId",
                table: "CreditMemo");

            migrationBuilder.DropForeignKey(
                name: "FK_CreditMemo_Contact_BillToId1",
                table: "CreditMemo");

            migrationBuilder.DropForeignKey(
                name: "FK_CreditMemo_CreditMemo_CreditMemoId",
                table: "CreditMemo");

            migrationBuilder.DropForeignKey(
                name: "FK_CreditMemo_CustomFields_CustomFieldsId",
                table: "CreditMemo");

            migrationBuilder.DropForeignKey(
                name: "FK_CreditMemo_CustomObject_CustomObjectsId",
                table: "CreditMemo");

            migrationBuilder.DropForeignKey(
                name: "FK_CreditMemo_StateTransitions_StateTransitionsId",
                table: "CreditMemo");

            migrationBuilder.DropForeignKey(
                name: "FK_CreditMemoAppliedTo_BillingDocument_BillingDocumentId1",
                table: "CreditMemoAppliedTo");

            migrationBuilder.DropForeignKey(
                name: "FK_CreditMemoItem_CreditMemo_CreditMemoId1",
                table: "CreditMemoItem");

            migrationBuilder.DropForeignKey(
                name: "FK_CreditMemoItem_CustomFields_CustomFieldsId",
                table: "CreditMemoItem");

            migrationBuilder.DropForeignKey(
                name: "FK_CreditMemoItem_CustomObject_CustomObjectsId",
                table: "CreditMemoItem");

            migrationBuilder.DropForeignKey(
                name: "FK_CreditMemoItem_SubscriptionItem_SubscriptionItemId1",
                table: "CreditMemoItem");

            migrationBuilder.DropForeignKey(
                name: "FK_CreditMemoItem_Subscription_SubscriptionId1",
                table: "CreditMemoItem");

            migrationBuilder.DropForeignKey(
                name: "FK_DebitMemo_Account_AccountId1",
                table: "DebitMemo");

            migrationBuilder.DropForeignKey(
                name: "FK_DebitMemo_BillingDocumentSetting_BillingDocumentSettingsId",
                table: "DebitMemo");

            migrationBuilder.DropForeignKey(
                name: "FK_DebitMemo_Contact_BillToId1",
                table: "DebitMemo");

            migrationBuilder.DropForeignKey(
                name: "FK_DebitMemo_CustomFields_CustomFieldsId",
                table: "DebitMemo");

            migrationBuilder.DropForeignKey(
                name: "FK_DebitMemo_CustomObject_CustomObjectsId",
                table: "DebitMemo");

            migrationBuilder.DropForeignKey(
                name: "FK_DebitMemo_StateTransitions_StateTransitionsId",
                table: "DebitMemo");

            migrationBuilder.DropForeignKey(
                name: "FK_DebitMemoItem_CustomFields_CustomFieldsId",
                table: "DebitMemoItem");

            migrationBuilder.DropForeignKey(
                name: "FK_DebitMemoItem_CustomObject_CustomObjectsId",
                table: "DebitMemoItem");

            migrationBuilder.DropForeignKey(
                name: "FK_DebitMemoItem_DebitMemo_DebitMemoId1",
                table: "DebitMemoItem");

            migrationBuilder.DropForeignKey(
                name: "FK_DebitMemoItem_SubscriptionItem_SubscriptionItemId1",
                table: "DebitMemoItem");

            migrationBuilder.DropForeignKey(
                name: "FK_DebitMemoItem_Subscription_SubscriptionId1",
                table: "DebitMemoItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Account_AccountId1",
                table: "Invoice");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_ArTransaction_ArTransactionsId",
                table: "Invoice");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_BillingDocumentSetting_BillingDocumentSettingsId",
                table: "Invoice");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Contact_BillToId1",
                table: "Invoice");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Contact_SoldToId1",
                table: "Invoice");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_CustomFields_CustomFieldsId",
                table: "Invoice");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_CustomObject_CustomObjectsId",
                table: "Invoice");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_StateTransitions_StateTransitionsId",
                table: "Invoice");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceItem_CustomFields_CustomFieldsId",
                table: "InvoiceItem");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceItem_CustomObject_CustomObjectsId",
                table: "InvoiceItem");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceItem_Invoice_InvoiceId1",
                table: "InvoiceItem");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceItem_OrderLineItem_LineItemId",
                table: "InvoiceItem");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceItem_SubscriptionItem_SubscriptionItemId1",
                table: "InvoiceItem");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceItem_Subscription_SubscriptionId1",
                table: "InvoiceItem");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemTier_SubscriptionItem_SubscriptionItemId",
                table: "ItemTier");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Account_AccountId1",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_CustomObject_CustomObjectsId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderLineItem_CustomFields_CustomFieldsId",
                table: "OrderLineItem");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderLineItem_CustomObject_CustomObjectsId",
                table: "OrderLineItem");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderLineItem_OrderLineItemRevenue_RevenueId",
                table: "OrderLineItem");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderLineItem_Order_OrderId1",
                table: "OrderLineItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Account_AccountId1",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_CustomFields_CustomFieldsId",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_CustomObject_CustomObjectsId",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_GatewayOptions_GatewayOptionsId",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_GatewayStateTransitions_GatewayStateTransitionsId",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_PaymentMethod_PaymentMethodId1",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_PaymentStateTransitions_StateTransitionsId",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_PaymentTransaction_PaymentTransactionsId",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethod_Account_AccountId1",
                table: "PaymentMethod");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethod_AchDebit_AchDebitId",
                table: "PaymentMethod");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethod_ApplePay_ApplePayId",
                table: "PaymentMethod");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethod_AuBecsDebit_AuBecsDebitId",
                table: "PaymentMethod");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethod_AutogiroDebit_AutogiroDebitId",
                table: "PaymentMethod");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethod_BacsDebit_BacsDebitId",
                table: "PaymentMethod");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethod_BetalingsDebit_BetalingsDebitId",
                table: "PaymentMethod");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethod_BillingDetails_BillingDetailsId",
                table: "PaymentMethod");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethod_CcRef_CcRefId",
                table: "PaymentMethod");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethod_CustomFields_CustomFieldsId",
                table: "PaymentMethod");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethod_CustomObject_CustomObjectsId",
                table: "PaymentMethod");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethod_GetCardList_CardId",
                table: "PaymentMethod");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethod_GooglePay_GooglePayId",
                table: "PaymentMethod");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethod_NzBecsDebit_NzBecsDebitId",
                table: "PaymentMethod");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethod_PadDebit_PadDebitId",
                table: "PaymentMethod");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethod_PaypalAdaptive_PaypalAdaptiveId",
                table: "PaymentMethod");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethod_PaypalExpressNative_PaypalExpressNativeId",
                table: "PaymentMethod");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethod_PaypalExpress_PaypalExpressId",
                table: "PaymentMethod");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethod_SepaDebit_SepaDebitId",
                table: "PaymentMethod");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentsAppliedTo_BillingDocument_BillingDocumentId1",
                table: "PaymentsAppliedTo");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentsAppliedTo_Payment_PaymentId",
                table: "PaymentsAppliedTo");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentSchedule_BillingDocument_BillingDocumentId",
                table: "PaymentSchedule");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentSchedule_CustomObject_CustomObjectsId",
                table: "PaymentSchedule");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentScheduleItem_BillingDocument_BillingDocumentId",
                table: "PaymentScheduleItem");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentScheduleItem_CustomFields_CustomFieldsId",
                table: "PaymentScheduleItem");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentScheduleItem_CustomObject_CustomObjectsId",
                table: "PaymentScheduleItem");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentScheduleItem_PaymentSchedule_PaymentScheduleId1",
                table: "PaymentScheduleItem");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentScheduleItem_Payment_PaymentId",
                table: "PaymentScheduleItem");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentScheduleItemPayments_PaymentScheduleItem_PaymentScheduleItemId",
                table: "PaymentScheduleItemPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentTransaction_ArTransaction_ArTransactionsId",
                table: "PaymentTransaction");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentTransaction_TransactionsState_StateId",
                table: "PaymentTransaction");

            migrationBuilder.DropForeignKey(
                name: "FK_Plan_CustomObject_CustomObjectsId",
                table: "Plan");

            migrationBuilder.DropForeignKey(
                name: "FK_Plan_Product_ProductId1",
                table: "Plan");

            migrationBuilder.DropForeignKey(
                name: "FK_PrepaidBalance_Subscription_SubscriptionId",
                table: "PrepaidBalance");

            migrationBuilder.DropForeignKey(
                name: "FK_PrepaidBalances_Subscription_SubscriptionId",
                table: "PrepaidBalances");

            migrationBuilder.DropForeignKey(
                name: "FK_Price_CustomObject_CustomObjectsId",
                table: "Price");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_CustomFields_CustomFieldsId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_CustomObject_CustomObjectsId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductPlan_CustomObject_CustomObjectsId",
                table: "ProductPlan");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductPlan_Product_ProductId1",
                table: "ProductPlan");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductPrice_CustomObject_CustomObjectsId",
                table: "ProductPrice");

            migrationBuilder.DropForeignKey(
                name: "FK_Refund_Account_AccountId1",
                table: "Refund");

            migrationBuilder.DropForeignKey(
                name: "FK_Refund_CreditMemo_CreditMemoId",
                table: "Refund");

            migrationBuilder.DropForeignKey(
                name: "FK_Refund_CustomFields_CustomFieldsId",
                table: "Refund");

            migrationBuilder.DropForeignKey(
                name: "FK_Refund_CustomObject_CustomObjectsId",
                table: "Refund");

            migrationBuilder.DropForeignKey(
                name: "FK_Refund_GatewayOptions_GatewayOptionsId",
                table: "Refund");

            migrationBuilder.DropForeignKey(
                name: "FK_Refund_PaymentMethod_PaymentMethodId1",
                table: "Refund");

            migrationBuilder.DropForeignKey(
                name: "FK_Refund_RefundStateTransitions_StateTransitionsId",
                table: "Refund");

            migrationBuilder.DropForeignKey(
                name: "FK_Refund_RefundTransaction_RefundTransactionsId",
                table: "Refund");

            migrationBuilder.DropForeignKey(
                name: "FK_RefundsAppliedTo_BillingDocument_BillingDocumentId1",
                table: "RefundsAppliedTo");

            migrationBuilder.DropForeignKey(
                name: "FK_RefundsAppliedTo_Payment_PaymentId",
                table: "RefundsAppliedTo");

            migrationBuilder.DropForeignKey(
                name: "FK_RefundsAppliedTo_Refund_RefundId",
                table: "RefundsAppliedTo");

            migrationBuilder.DropForeignKey(
                name: "FK_RefundTransaction_ArTransaction_ArTransactionsId",
                table: "RefundTransaction");

            migrationBuilder.DropForeignKey(
                name: "FK_RefundTransaction_TransactionsState_StateId",
                table: "RefundTransaction");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscription_Account_AccountId1",
                table: "Subscription");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscription_Account_InvoiceOwnerAccountId1",
                table: "Subscription");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscription_BillingDocumentSetting_BillingDocumentSettingsId",
                table: "Subscription");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscription_Contact_BillToId1",
                table: "Subscription");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscription_Contact_SoldToId1",
                table: "Subscription");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscription_CustomFields_CustomFieldsId",
                table: "Subscription");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscription_CustomObject_CustomObjectsId",
                table: "Subscription");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscription_Order_OrderId",
                table: "Subscription");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscription_Term_CurrentTermId",
                table: "Subscription");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscription_Term_InitialTermId",
                table: "Subscription");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscription_Term_RenewalTermId",
                table: "Subscription");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionAddPlan_CustomFields_CustomFieldsId",
                table: "SubscriptionAddPlan");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionItem_CustomFields_CustomFieldsId",
                table: "SubscriptionItem");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionItem_CustomObject_CustomObjectsId",
                table: "SubscriptionItem");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionItem_Overage_OverageId",
                table: "SubscriptionItem");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionItem_Price_PriceId1",
                table: "SubscriptionItem");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionItem_Recurring_RecurringId",
                table: "SubscriptionItem");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionItem_SubscriptionAddPlan_SubscriptionAddPlanId",
                table: "SubscriptionItem");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionItem_SubscriptionPlan_SubscriptionPlanId1",
                table: "SubscriptionItem");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionPause_CustomFields_CustomFieldsId",
                table: "SubscriptionPause");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionPause_ResumeSubscription_ResumeBehaviorId",
                table: "SubscriptionPause");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionPlan_CustomFields_CustomFieldsId",
                table: "SubscriptionPlan");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionPlan_CustomObject_CustomObjectsId",
                table: "SubscriptionPlan");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionPlan_Plan_PlanId1",
                table: "SubscriptionPlan");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionPlan_Product_ProductId1",
                table: "SubscriptionPlan");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionPlan_Subscription_SubscriptionId1",
                table: "SubscriptionPlan");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionRenew_SubscriptionTerm_TermsId",
                table: "SubscriptionRenew");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionTerm_Term_CurrentTermId",
                table: "SubscriptionTerm");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionTerm_Term_RenewalTermId",
                table: "SubscriptionTerm");

            migrationBuilder.DropForeignKey(
                name: "FK_TaxationItem_BillingDocumentItem_BillingDocumentItemId",
                table: "TaxationItem");

            migrationBuilder.DropForeignKey(
                name: "FK_TaxationItem_CreditMemoItem_CreditMemoItemId",
                table: "TaxationItem");

            migrationBuilder.DropForeignKey(
                name: "FK_TaxationItem_CustomFields_CustomFieldsId",
                table: "TaxationItem");

            migrationBuilder.DropForeignKey(
                name: "FK_TaxationItem_CustomObject_CustomObjectsId",
                table: "TaxationItem");

            migrationBuilder.DropForeignKey(
                name: "FK_TaxationItem_DebitMemoItem_DebitMemoItemId",
                table: "TaxationItem");

            migrationBuilder.DropForeignKey(
                name: "FK_TaxationItem_InvoiceItem_InvoiceItemId",
                table: "TaxationItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Usage_Account_AccountId1",
                table: "Usage");

            migrationBuilder.DropForeignKey(
                name: "FK_Usage_CustomFields_CustomFieldsId",
                table: "Usage");

            migrationBuilder.DropForeignKey(
                name: "FK_Usage_CustomObject_CustomObjectsId",
                table: "Usage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usage",
                table: "Usage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaxIdentifier",
                table: "TaxIdentifier");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaxCertificate",
                table: "TaxCertificate");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaxationItem",
                table: "TaxationItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubscriptionTerm",
                table: "SubscriptionTerm");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubscriptionRenew",
                table: "SubscriptionRenew");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubscriptionRemovePlan",
                table: "SubscriptionRemovePlan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubscriptionPlan",
                table: "SubscriptionPlan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubscriptionPause",
                table: "SubscriptionPause");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubscriptionItem",
                table: "SubscriptionItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubscriptionCancel",
                table: "SubscriptionCancel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubscriptionAddPlan",
                table: "SubscriptionAddPlan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subscription",
                table: "Subscription");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RefundTransaction",
                table: "RefundTransaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Refund",
                table: "Refund");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentTransaction",
                table: "PaymentTransaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentScheduleItem",
                table: "PaymentScheduleItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentMethod",
                table: "PaymentMethod");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payment",
                table: "Payment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderLineItem",
                table: "OrderLineItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InvoiceItem",
                table: "InvoiceItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Invoice",
                table: "Invoice");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DebitMemoItem",
                table: "DebitMemoItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DebitMemo",
                table: "DebitMemo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomObject",
                table: "CustomObject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CreditMemoItem",
                table: "CreditMemoItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CreditMemo",
                table: "CreditMemo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contact",
                table: "Contact");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BillingDocumentSetting",
                table: "BillingDocumentSetting");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BillingDocumentItem",
                table: "BillingDocumentItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BillingDocument",
                table: "BillingDocument");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ArTransaction",
                table: "ArTransaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Account",
                table: "Account");

            migrationBuilder.RenameTable(
                name: "Usage",
                newName: "Usages");

            migrationBuilder.RenameTable(
                name: "TaxIdentifier",
                newName: "TaxIdentifiers");

            migrationBuilder.RenameTable(
                name: "TaxCertificate",
                newName: "TaxCertificates");

            migrationBuilder.RenameTable(
                name: "TaxationItem",
                newName: "TaxationItems");

            migrationBuilder.RenameTable(
                name: "SubscriptionTerm",
                newName: "SubscriptionTerms");

            migrationBuilder.RenameTable(
                name: "SubscriptionRenew",
                newName: "SubscriptionRenews");

            migrationBuilder.RenameTable(
                name: "SubscriptionRemovePlan",
                newName: "SubscriptionRemovePlans");

            migrationBuilder.RenameTable(
                name: "SubscriptionPlan",
                newName: "SubscriptionPlans");

            migrationBuilder.RenameTable(
                name: "SubscriptionPause",
                newName: "SubscriptionPauses");

            migrationBuilder.RenameTable(
                name: "SubscriptionItem",
                newName: "SubscriptionItems");

            migrationBuilder.RenameTable(
                name: "SubscriptionCancel",
                newName: "SubscriptionCancels");

            migrationBuilder.RenameTable(
                name: "SubscriptionAddPlan",
                newName: "SubscriptionAddPlans");

            migrationBuilder.RenameTable(
                name: "Subscription",
                newName: "Subscriptions");

            migrationBuilder.RenameTable(
                name: "RefundTransaction",
                newName: "RefundTransactions");

            migrationBuilder.RenameTable(
                name: "Refund",
                newName: "Refunds");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "PaymentTransaction",
                newName: "PaymentTransactions");

            migrationBuilder.RenameTable(
                name: "PaymentScheduleItem",
                newName: "PaymentScheduleItems");

            migrationBuilder.RenameTable(
                name: "PaymentMethod",
                newName: "PaymentMethods");

            migrationBuilder.RenameTable(
                name: "Payment",
                newName: "Payments");

            migrationBuilder.RenameTable(
                name: "OrderLineItem",
                newName: "OrderLineItems");

            migrationBuilder.RenameTable(
                name: "InvoiceItem",
                newName: "InvoiceItems");

            migrationBuilder.RenameTable(
                name: "Invoice",
                newName: "Invoices");

            migrationBuilder.RenameTable(
                name: "DebitMemoItem",
                newName: "DebitMemoItems");

            migrationBuilder.RenameTable(
                name: "DebitMemo",
                newName: "DebitMemos");

            migrationBuilder.RenameTable(
                name: "CustomObject",
                newName: "CustomObjects");

            migrationBuilder.RenameTable(
                name: "CreditMemoItem",
                newName: "CreditMemoItems");

            migrationBuilder.RenameTable(
                name: "CreditMemo",
                newName: "CreditMemos");

            migrationBuilder.RenameTable(
                name: "Contact",
                newName: "Contacts");

            migrationBuilder.RenameTable(
                name: "BillingDocumentSetting",
                newName: "BillingDocumentSettings");

            migrationBuilder.RenameTable(
                name: "BillingDocumentItem",
                newName: "BillingDocumentItems");

            migrationBuilder.RenameTable(
                name: "BillingDocument",
                newName: "BillingDocuments");

            migrationBuilder.RenameTable(
                name: "ArTransaction",
                newName: "ArTransactions");

            migrationBuilder.RenameTable(
                name: "Account",
                newName: "Accounts");

            migrationBuilder.RenameIndex(
                name: "IX_Usage_CustomObjectsId",
                table: "Usages",
                newName: "IX_Usages_CustomObjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_Usage_CustomFieldsId",
                table: "Usages",
                newName: "IX_Usages_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_Usage_AccountId1",
                table: "Usages",
                newName: "IX_Usages_AccountId1");

            migrationBuilder.RenameIndex(
                name: "IX_TaxationItem_InvoiceItemId",
                table: "TaxationItems",
                newName: "IX_TaxationItems_InvoiceItemId");

            migrationBuilder.RenameIndex(
                name: "IX_TaxationItem_DebitMemoItemId",
                table: "TaxationItems",
                newName: "IX_TaxationItems_DebitMemoItemId");

            migrationBuilder.RenameIndex(
                name: "IX_TaxationItem_CustomObjectsId",
                table: "TaxationItems",
                newName: "IX_TaxationItems_CustomObjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_TaxationItem_CustomFieldsId",
                table: "TaxationItems",
                newName: "IX_TaxationItems_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_TaxationItem_CreditMemoItemId",
                table: "TaxationItems",
                newName: "IX_TaxationItems_CreditMemoItemId");

            migrationBuilder.RenameIndex(
                name: "IX_TaxationItem_BillingDocumentItemId",
                table: "TaxationItems",
                newName: "IX_TaxationItems_BillingDocumentItemId");

            migrationBuilder.RenameIndex(
                name: "IX_SubscriptionTerm_RenewalTermId",
                table: "SubscriptionTerms",
                newName: "IX_SubscriptionTerms_RenewalTermId");

            migrationBuilder.RenameIndex(
                name: "IX_SubscriptionTerm_CurrentTermId",
                table: "SubscriptionTerms",
                newName: "IX_SubscriptionTerms_CurrentTermId");

            migrationBuilder.RenameIndex(
                name: "IX_SubscriptionRenew_TermsId",
                table: "SubscriptionRenews",
                newName: "IX_SubscriptionRenews_TermsId");

            migrationBuilder.RenameIndex(
                name: "IX_SubscriptionPlan_SubscriptionId1",
                table: "SubscriptionPlans",
                newName: "IX_SubscriptionPlans_SubscriptionId1");

            migrationBuilder.RenameIndex(
                name: "IX_SubscriptionPlan_ProductId1",
                table: "SubscriptionPlans",
                newName: "IX_SubscriptionPlans_ProductId1");

            migrationBuilder.RenameIndex(
                name: "IX_SubscriptionPlan_PlanId1",
                table: "SubscriptionPlans",
                newName: "IX_SubscriptionPlans_PlanId1");

            migrationBuilder.RenameIndex(
                name: "IX_SubscriptionPlan_CustomObjectsId",
                table: "SubscriptionPlans",
                newName: "IX_SubscriptionPlans_CustomObjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_SubscriptionPlan_CustomFieldsId",
                table: "SubscriptionPlans",
                newName: "IX_SubscriptionPlans_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_SubscriptionPause_ResumeBehaviorId",
                table: "SubscriptionPauses",
                newName: "IX_SubscriptionPauses_ResumeBehaviorId");

            migrationBuilder.RenameIndex(
                name: "IX_SubscriptionPause_CustomFieldsId",
                table: "SubscriptionPauses",
                newName: "IX_SubscriptionPauses_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_SubscriptionItem_SubscriptionPlanId1",
                table: "SubscriptionItems",
                newName: "IX_SubscriptionItems_SubscriptionPlanId1");

            migrationBuilder.RenameIndex(
                name: "IX_SubscriptionItem_SubscriptionAddPlanId",
                table: "SubscriptionItems",
                newName: "IX_SubscriptionItems_SubscriptionAddPlanId");

            migrationBuilder.RenameIndex(
                name: "IX_SubscriptionItem_RecurringId",
                table: "SubscriptionItems",
                newName: "IX_SubscriptionItems_RecurringId");

            migrationBuilder.RenameIndex(
                name: "IX_SubscriptionItem_PriceId1",
                table: "SubscriptionItems",
                newName: "IX_SubscriptionItems_PriceId1");

            migrationBuilder.RenameIndex(
                name: "IX_SubscriptionItem_OverageId",
                table: "SubscriptionItems",
                newName: "IX_SubscriptionItems_OverageId");

            migrationBuilder.RenameIndex(
                name: "IX_SubscriptionItem_CustomObjectsId",
                table: "SubscriptionItems",
                newName: "IX_SubscriptionItems_CustomObjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_SubscriptionItem_CustomFieldsId",
                table: "SubscriptionItems",
                newName: "IX_SubscriptionItems_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_SubscriptionAddPlan_CustomFieldsId",
                table: "SubscriptionAddPlans",
                newName: "IX_SubscriptionAddPlans_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_Subscription_SoldToId1",
                table: "Subscriptions",
                newName: "IX_Subscriptions_SoldToId1");

            migrationBuilder.RenameIndex(
                name: "IX_Subscription_RenewalTermId",
                table: "Subscriptions",
                newName: "IX_Subscriptions_RenewalTermId");

            migrationBuilder.RenameIndex(
                name: "IX_Subscription_OrderId",
                table: "Subscriptions",
                newName: "IX_Subscriptions_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Subscription_InvoiceOwnerAccountId1",
                table: "Subscriptions",
                newName: "IX_Subscriptions_InvoiceOwnerAccountId1");

            migrationBuilder.RenameIndex(
                name: "IX_Subscription_InitialTermId",
                table: "Subscriptions",
                newName: "IX_Subscriptions_InitialTermId");

            migrationBuilder.RenameIndex(
                name: "IX_Subscription_CustomObjectsId",
                table: "Subscriptions",
                newName: "IX_Subscriptions_CustomObjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_Subscription_CustomFieldsId",
                table: "Subscriptions",
                newName: "IX_Subscriptions_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_Subscription_CurrentTermId",
                table: "Subscriptions",
                newName: "IX_Subscriptions_CurrentTermId");

            migrationBuilder.RenameIndex(
                name: "IX_Subscription_BillToId1",
                table: "Subscriptions",
                newName: "IX_Subscriptions_BillToId1");

            migrationBuilder.RenameIndex(
                name: "IX_Subscription_BillingDocumentSettingsId",
                table: "Subscriptions",
                newName: "IX_Subscriptions_BillingDocumentSettingsId");

            migrationBuilder.RenameIndex(
                name: "IX_Subscription_AccountId1",
                table: "Subscriptions",
                newName: "IX_Subscriptions_AccountId1");

            migrationBuilder.RenameIndex(
                name: "IX_RefundTransaction_StateId",
                table: "RefundTransactions",
                newName: "IX_RefundTransactions_StateId");

            migrationBuilder.RenameIndex(
                name: "IX_RefundTransaction_ArTransactionsId",
                table: "RefundTransactions",
                newName: "IX_RefundTransactions_ArTransactionsId");

            migrationBuilder.RenameIndex(
                name: "IX_Refund_StateTransitionsId",
                table: "Refunds",
                newName: "IX_Refunds_StateTransitionsId");

            migrationBuilder.RenameIndex(
                name: "IX_Refund_RefundTransactionsId",
                table: "Refunds",
                newName: "IX_Refunds_RefundTransactionsId");

            migrationBuilder.RenameIndex(
                name: "IX_Refund_PaymentMethodId1",
                table: "Refunds",
                newName: "IX_Refunds_PaymentMethodId1");

            migrationBuilder.RenameIndex(
                name: "IX_Refund_GatewayOptionsId",
                table: "Refunds",
                newName: "IX_Refunds_GatewayOptionsId");

            migrationBuilder.RenameIndex(
                name: "IX_Refund_CustomObjectsId",
                table: "Refunds",
                newName: "IX_Refunds_CustomObjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_Refund_CustomFieldsId",
                table: "Refunds",
                newName: "IX_Refunds_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_Refund_CreditMemoId",
                table: "Refunds",
                newName: "IX_Refunds_CreditMemoId");

            migrationBuilder.RenameIndex(
                name: "IX_Refund_AccountId1",
                table: "Refunds",
                newName: "IX_Refunds_AccountId1");

            migrationBuilder.RenameIndex(
                name: "IX_Product_CustomObjectsId",
                table: "Products",
                newName: "IX_Products_CustomObjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_CustomFieldsId",
                table: "Products",
                newName: "IX_Products_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentTransaction_StateId",
                table: "PaymentTransactions",
                newName: "IX_PaymentTransactions_StateId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentTransaction_ArTransactionsId",
                table: "PaymentTransactions",
                newName: "IX_PaymentTransactions_ArTransactionsId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentScheduleItem_PaymentScheduleId1",
                table: "PaymentScheduleItems",
                newName: "IX_PaymentScheduleItems_PaymentScheduleId1");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentScheduleItem_PaymentId",
                table: "PaymentScheduleItems",
                newName: "IX_PaymentScheduleItems_PaymentId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentScheduleItem_CustomObjectsId",
                table: "PaymentScheduleItems",
                newName: "IX_PaymentScheduleItems_CustomObjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentScheduleItem_CustomFieldsId",
                table: "PaymentScheduleItems",
                newName: "IX_PaymentScheduleItems_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentScheduleItem_BillingDocumentId",
                table: "PaymentScheduleItems",
                newName: "IX_PaymentScheduleItems_BillingDocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethod_SepaDebitId",
                table: "PaymentMethods",
                newName: "IX_PaymentMethods_SepaDebitId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethod_PaypalExpressNativeId",
                table: "PaymentMethods",
                newName: "IX_PaymentMethods_PaypalExpressNativeId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethod_PaypalExpressId",
                table: "PaymentMethods",
                newName: "IX_PaymentMethods_PaypalExpressId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethod_PaypalAdaptiveId",
                table: "PaymentMethods",
                newName: "IX_PaymentMethods_PaypalAdaptiveId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethod_PadDebitId",
                table: "PaymentMethods",
                newName: "IX_PaymentMethods_PadDebitId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethod_NzBecsDebitId",
                table: "PaymentMethods",
                newName: "IX_PaymentMethods_NzBecsDebitId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethod_GooglePayId",
                table: "PaymentMethods",
                newName: "IX_PaymentMethods_GooglePayId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethod_CustomObjectsId",
                table: "PaymentMethods",
                newName: "IX_PaymentMethods_CustomObjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethod_CustomFieldsId",
                table: "PaymentMethods",
                newName: "IX_PaymentMethods_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethod_CcRefId",
                table: "PaymentMethods",
                newName: "IX_PaymentMethods_CcRefId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethod_CardId",
                table: "PaymentMethods",
                newName: "IX_PaymentMethods_CardId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethod_BillingDetailsId",
                table: "PaymentMethods",
                newName: "IX_PaymentMethods_BillingDetailsId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethod_BetalingsDebitId",
                table: "PaymentMethods",
                newName: "IX_PaymentMethods_BetalingsDebitId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethod_BacsDebitId",
                table: "PaymentMethods",
                newName: "IX_PaymentMethods_BacsDebitId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethod_AutogiroDebitId",
                table: "PaymentMethods",
                newName: "IX_PaymentMethods_AutogiroDebitId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethod_AuBecsDebitId",
                table: "PaymentMethods",
                newName: "IX_PaymentMethods_AuBecsDebitId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethod_ApplePayId",
                table: "PaymentMethods",
                newName: "IX_PaymentMethods_ApplePayId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethod_AchDebitId",
                table: "PaymentMethods",
                newName: "IX_PaymentMethods_AchDebitId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethod_AccountId1",
                table: "PaymentMethods",
                newName: "IX_PaymentMethods_AccountId1");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_StateTransitionsId",
                table: "Payments",
                newName: "IX_Payments_StateTransitionsId");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_PaymentTransactionsId",
                table: "Payments",
                newName: "IX_Payments_PaymentTransactionsId");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_PaymentMethodId1",
                table: "Payments",
                newName: "IX_Payments_PaymentMethodId1");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_GatewayStateTransitionsId",
                table: "Payments",
                newName: "IX_Payments_GatewayStateTransitionsId");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_GatewayOptionsId",
                table: "Payments",
                newName: "IX_Payments_GatewayOptionsId");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_CustomObjectsId",
                table: "Payments",
                newName: "IX_Payments_CustomObjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_CustomFieldsId",
                table: "Payments",
                newName: "IX_Payments_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_AccountId1",
                table: "Payments",
                newName: "IX_Payments_AccountId1");

            migrationBuilder.RenameIndex(
                name: "IX_OrderLineItem_RevenueId",
                table: "OrderLineItems",
                newName: "IX_OrderLineItems_RevenueId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderLineItem_OrderId1",
                table: "OrderLineItems",
                newName: "IX_OrderLineItems_OrderId1");

            migrationBuilder.RenameIndex(
                name: "IX_OrderLineItem_CustomObjectsId",
                table: "OrderLineItems",
                newName: "IX_OrderLineItems_CustomObjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderLineItem_CustomFieldsId",
                table: "OrderLineItems",
                newName: "IX_OrderLineItems_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceItem_SubscriptionItemId1",
                table: "InvoiceItems",
                newName: "IX_InvoiceItems_SubscriptionItemId1");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceItem_SubscriptionId1",
                table: "InvoiceItems",
                newName: "IX_InvoiceItems_SubscriptionId1");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceItem_LineItemId",
                table: "InvoiceItems",
                newName: "IX_InvoiceItems_LineItemId");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceItem_InvoiceId1",
                table: "InvoiceItems",
                newName: "IX_InvoiceItems_InvoiceId1");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceItem_CustomObjectsId",
                table: "InvoiceItems",
                newName: "IX_InvoiceItems_CustomObjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceItem_CustomFieldsId",
                table: "InvoiceItems",
                newName: "IX_InvoiceItems_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_Invoice_StateTransitionsId",
                table: "Invoices",
                newName: "IX_Invoices_StateTransitionsId");

            migrationBuilder.RenameIndex(
                name: "IX_Invoice_SoldToId1",
                table: "Invoices",
                newName: "IX_Invoices_SoldToId1");

            migrationBuilder.RenameIndex(
                name: "IX_Invoice_CustomObjectsId",
                table: "Invoices",
                newName: "IX_Invoices_CustomObjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_Invoice_CustomFieldsId",
                table: "Invoices",
                newName: "IX_Invoices_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_Invoice_BillToId1",
                table: "Invoices",
                newName: "IX_Invoices_BillToId1");

            migrationBuilder.RenameIndex(
                name: "IX_Invoice_BillingDocumentSettingsId",
                table: "Invoices",
                newName: "IX_Invoices_BillingDocumentSettingsId");

            migrationBuilder.RenameIndex(
                name: "IX_Invoice_ArTransactionsId",
                table: "Invoices",
                newName: "IX_Invoices_ArTransactionsId");

            migrationBuilder.RenameIndex(
                name: "IX_Invoice_AccountId1",
                table: "Invoices",
                newName: "IX_Invoices_AccountId1");

            migrationBuilder.RenameIndex(
                name: "IX_DebitMemoItem_SubscriptionItemId1",
                table: "DebitMemoItems",
                newName: "IX_DebitMemoItems_SubscriptionItemId1");

            migrationBuilder.RenameIndex(
                name: "IX_DebitMemoItem_SubscriptionId1",
                table: "DebitMemoItems",
                newName: "IX_DebitMemoItems_SubscriptionId1");

            migrationBuilder.RenameIndex(
                name: "IX_DebitMemoItem_DebitMemoId1",
                table: "DebitMemoItems",
                newName: "IX_DebitMemoItems_DebitMemoId1");

            migrationBuilder.RenameIndex(
                name: "IX_DebitMemoItem_CustomObjectsId",
                table: "DebitMemoItems",
                newName: "IX_DebitMemoItems_CustomObjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_DebitMemoItem_CustomFieldsId",
                table: "DebitMemoItems",
                newName: "IX_DebitMemoItems_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_DebitMemo_StateTransitionsId",
                table: "DebitMemos",
                newName: "IX_DebitMemos_StateTransitionsId");

            migrationBuilder.RenameIndex(
                name: "IX_DebitMemo_CustomObjectsId",
                table: "DebitMemos",
                newName: "IX_DebitMemos_CustomObjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_DebitMemo_CustomFieldsId",
                table: "DebitMemos",
                newName: "IX_DebitMemos_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_DebitMemo_BillToId1",
                table: "DebitMemos",
                newName: "IX_DebitMemos_BillToId1");

            migrationBuilder.RenameIndex(
                name: "IX_DebitMemo_BillingDocumentSettingsId",
                table: "DebitMemos",
                newName: "IX_DebitMemos_BillingDocumentSettingsId");

            migrationBuilder.RenameIndex(
                name: "IX_DebitMemo_AccountId1",
                table: "DebitMemos",
                newName: "IX_DebitMemos_AccountId1");

            migrationBuilder.RenameIndex(
                name: "IX_CreditMemoItem_SubscriptionItemId1",
                table: "CreditMemoItems",
                newName: "IX_CreditMemoItems_SubscriptionItemId1");

            migrationBuilder.RenameIndex(
                name: "IX_CreditMemoItem_SubscriptionId1",
                table: "CreditMemoItems",
                newName: "IX_CreditMemoItems_SubscriptionId1");

            migrationBuilder.RenameIndex(
                name: "IX_CreditMemoItem_CustomObjectsId",
                table: "CreditMemoItems",
                newName: "IX_CreditMemoItems_CustomObjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_CreditMemoItem_CustomFieldsId",
                table: "CreditMemoItems",
                newName: "IX_CreditMemoItems_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_CreditMemoItem_CreditMemoId1",
                table: "CreditMemoItems",
                newName: "IX_CreditMemoItems_CreditMemoId1");

            migrationBuilder.RenameIndex(
                name: "IX_CreditMemo_StateTransitionsId",
                table: "CreditMemos",
                newName: "IX_CreditMemos_StateTransitionsId");

            migrationBuilder.RenameIndex(
                name: "IX_CreditMemo_CustomObjectsId",
                table: "CreditMemos",
                newName: "IX_CreditMemos_CustomObjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_CreditMemo_CustomFieldsId",
                table: "CreditMemos",
                newName: "IX_CreditMemos_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_CreditMemo_CreditMemoId",
                table: "CreditMemos",
                newName: "IX_CreditMemos_CreditMemoId");

            migrationBuilder.RenameIndex(
                name: "IX_CreditMemo_BillToId1",
                table: "CreditMemos",
                newName: "IX_CreditMemos_BillToId1");

            migrationBuilder.RenameIndex(
                name: "IX_CreditMemo_ArTransactionsId",
                table: "CreditMemos",
                newName: "IX_CreditMemos_ArTransactionsId");

            migrationBuilder.RenameIndex(
                name: "IX_CreditMemo_AccountId1",
                table: "CreditMemos",
                newName: "IX_CreditMemos_AccountId1");

            migrationBuilder.RenameIndex(
                name: "IX_Contact_CustomObjectsId",
                table: "Contacts",
                newName: "IX_Contacts_CustomObjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_Contact_CustomFieldsId",
                table: "Contacts",
                newName: "IX_Contacts_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_Contact_AddressId",
                table: "Contacts",
                newName: "IX_Contacts_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_BillingDocumentSetting_CreditMemoId",
                table: "BillingDocumentSettings",
                newName: "IX_BillingDocumentSettings_CreditMemoId");

            migrationBuilder.RenameIndex(
                name: "IX_BillingDocumentItem_SubscriptionItemId1",
                table: "BillingDocumentItems",
                newName: "IX_BillingDocumentItems_SubscriptionItemId1");

            migrationBuilder.RenameIndex(
                name: "IX_BillingDocumentItem_SubscriptionId1",
                table: "BillingDocumentItems",
                newName: "IX_BillingDocumentItems_SubscriptionId1");

            migrationBuilder.RenameIndex(
                name: "IX_BillingDocumentItem_PaymentsAppliedToId",
                table: "BillingDocumentItems",
                newName: "IX_BillingDocumentItems_PaymentsAppliedToId");

            migrationBuilder.RenameIndex(
                name: "IX_BillingDocumentItem_CustomObjectsId",
                table: "BillingDocumentItems",
                newName: "IX_BillingDocumentItems_CustomObjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_BillingDocumentItem_CustomFieldsId",
                table: "BillingDocumentItems",
                newName: "IX_BillingDocumentItems_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_BillingDocumentItem_BillingDocumentId1",
                table: "BillingDocumentItems",
                newName: "IX_BillingDocumentItems_BillingDocumentId1");

            migrationBuilder.RenameIndex(
                name: "IX_BillingDocument_CustomObjectsId",
                table: "BillingDocuments",
                newName: "IX_BillingDocuments_CustomObjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_BillingDocument_CustomFieldsId",
                table: "BillingDocuments",
                newName: "IX_BillingDocuments_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_Account_TaxIdentifierId",
                table: "Accounts",
                newName: "IX_Accounts_TaxIdentifierId");

            migrationBuilder.RenameIndex(
                name: "IX_Account_TaxCertificateId",
                table: "Accounts",
                newName: "IX_Accounts_TaxCertificateId");

            migrationBuilder.RenameIndex(
                name: "IX_Account_SoldToId1",
                table: "Accounts",
                newName: "IX_Accounts_SoldToId1");

            migrationBuilder.RenameIndex(
                name: "IX_Account_CustomObjectsId",
                table: "Accounts",
                newName: "IX_Accounts_CustomObjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_Account_CustomFieldsId",
                table: "Accounts",
                newName: "IX_Accounts_CustomFieldsId");

            migrationBuilder.RenameIndex(
                name: "IX_Account_BillToId1",
                table: "Accounts",
                newName: "IX_Accounts_BillToId1");

            migrationBuilder.RenameIndex(
                name: "IX_Account_BillingDocumentsId",
                table: "Accounts",
                newName: "IX_Accounts_BillingDocumentsId");

            migrationBuilder.RenameIndex(
                name: "IX_Account_BillingDocumentSettingsId",
                table: "Accounts",
                newName: "IX_Accounts_BillingDocumentSettingsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usages",
                table: "Usages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaxIdentifiers",
                table: "TaxIdentifiers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaxCertificates",
                table: "TaxCertificates",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaxationItems",
                table: "TaxationItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubscriptionTerms",
                table: "SubscriptionTerms",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubscriptionRenews",
                table: "SubscriptionRenews",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubscriptionRemovePlans",
                table: "SubscriptionRemovePlans",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubscriptionPlans",
                table: "SubscriptionPlans",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubscriptionPauses",
                table: "SubscriptionPauses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubscriptionItems",
                table: "SubscriptionItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubscriptionCancels",
                table: "SubscriptionCancels",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubscriptionAddPlans",
                table: "SubscriptionAddPlans",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subscriptions",
                table: "Subscriptions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RefundTransactions",
                table: "RefundTransactions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Refunds",
                table: "Refunds",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentTransactions",
                table: "PaymentTransactions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentScheduleItems",
                table: "PaymentScheduleItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentMethods",
                table: "PaymentMethods",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payments",
                table: "Payments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderLineItems",
                table: "OrderLineItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InvoiceItems",
                table: "InvoiceItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Invoices",
                table: "Invoices",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DebitMemoItems",
                table: "DebitMemoItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DebitMemos",
                table: "DebitMemos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomObjects",
                table: "CustomObjects",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CreditMemoItems",
                table: "CreditMemoItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CreditMemos",
                table: "CreditMemos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BillingDocumentSettings",
                table: "BillingDocumentSettings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BillingDocumentItems",
                table: "BillingDocumentItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BillingDocuments",
                table: "BillingDocuments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArTransactions",
                table: "ArTransactions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Accounts",
                table: "Accounts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_BillingDocumentSettings_BillingDocumentSettingsId",
                table: "Accounts",
                column: "BillingDocumentSettingsId",
                principalTable: "BillingDocumentSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_BillingDocuments_BillingDocumentsId",
                table: "Accounts",
                column: "BillingDocumentsId",
                principalTable: "BillingDocuments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Contacts_BillToId1",
                table: "Accounts",
                column: "BillToId1",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Contacts_SoldToId1",
                table: "Accounts",
                column: "SoldToId1",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_CustomFields_CustomFieldsId",
                table: "Accounts",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_CustomObjects_CustomObjectsId",
                table: "Accounts",
                column: "CustomObjectsId",
                principalTable: "CustomObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_TaxCertificates_TaxCertificateId",
                table: "Accounts",
                column: "TaxCertificateId",
                principalTable: "TaxCertificates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_TaxIdentifiers_TaxIdentifierId",
                table: "Accounts",
                column: "TaxIdentifierId",
                principalTable: "TaxIdentifiers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BillingDocumentItems_BillingDocuments_BillingDocumentId1",
                table: "BillingDocumentItems",
                column: "BillingDocumentId1",
                principalTable: "BillingDocuments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BillingDocumentItems_CustomFields_CustomFieldsId",
                table: "BillingDocumentItems",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BillingDocumentItems_CustomObjects_CustomObjectsId",
                table: "BillingDocumentItems",
                column: "CustomObjectsId",
                principalTable: "CustomObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BillingDocumentItems_PaymentsAppliedTo_PaymentsAppliedToId",
                table: "BillingDocumentItems",
                column: "PaymentsAppliedToId",
                principalTable: "PaymentsAppliedTo",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BillingDocumentItems_SubscriptionItems_SubscriptionItemId1",
                table: "BillingDocumentItems",
                column: "SubscriptionItemId1",
                principalTable: "SubscriptionItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BillingDocumentItems_Subscriptions_SubscriptionId1",
                table: "BillingDocumentItems",
                column: "SubscriptionId1",
                principalTable: "Subscriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BillingDocuments_CustomFields_CustomFieldsId",
                table: "BillingDocuments",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BillingDocuments_CustomObjects_CustomObjectsId",
                table: "BillingDocuments",
                column: "CustomObjectsId",
                principalTable: "CustomObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BillingDocumentSettings_CreditMemos_CreditMemoId",
                table: "BillingDocumentSettings",
                column: "CreditMemoId",
                principalTable: "CreditMemos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BillingDocumentStateTransitions_BillingDocuments_BillingDocumentId",
                table: "BillingDocumentStateTransitions",
                column: "BillingDocumentId",
                principalTable: "BillingDocuments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Address_AddressId",
                table: "Contacts",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_CustomFields_CustomFieldsId",
                table: "Contacts",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_CustomObjects_CustomObjectsId",
                table: "Contacts",
                column: "CustomObjectsId",
                principalTable: "CustomObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreditMemoAppliedTo_BillingDocuments_BillingDocumentId1",
                table: "CreditMemoAppliedTo",
                column: "BillingDocumentId1",
                principalTable: "BillingDocuments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreditMemoItems_CreditMemos_CreditMemoId1",
                table: "CreditMemoItems",
                column: "CreditMemoId1",
                principalTable: "CreditMemos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreditMemoItems_CustomFields_CustomFieldsId",
                table: "CreditMemoItems",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreditMemoItems_CustomObjects_CustomObjectsId",
                table: "CreditMemoItems",
                column: "CustomObjectsId",
                principalTable: "CustomObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreditMemoItems_SubscriptionItems_SubscriptionItemId1",
                table: "CreditMemoItems",
                column: "SubscriptionItemId1",
                principalTable: "SubscriptionItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreditMemoItems_Subscriptions_SubscriptionId1",
                table: "CreditMemoItems",
                column: "SubscriptionId1",
                principalTable: "Subscriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreditMemos_Accounts_AccountId1",
                table: "CreditMemos",
                column: "AccountId1",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreditMemos_ArTransactions_ArTransactionsId",
                table: "CreditMemos",
                column: "ArTransactionsId",
                principalTable: "ArTransactions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CreditMemos_Contacts_BillToId1",
                table: "CreditMemos",
                column: "BillToId1",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreditMemos_CreditMemos_CreditMemoId",
                table: "CreditMemos",
                column: "CreditMemoId",
                principalTable: "CreditMemos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CreditMemos_CustomFields_CustomFieldsId",
                table: "CreditMemos",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreditMemos_CustomObjects_CustomObjectsId",
                table: "CreditMemos",
                column: "CustomObjectsId",
                principalTable: "CustomObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreditMemos_StateTransitions_StateTransitionsId",
                table: "CreditMemos",
                column: "StateTransitionsId",
                principalTable: "StateTransitions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DebitMemoItems_CustomFields_CustomFieldsId",
                table: "DebitMemoItems",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DebitMemoItems_CustomObjects_CustomObjectsId",
                table: "DebitMemoItems",
                column: "CustomObjectsId",
                principalTable: "CustomObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DebitMemoItems_DebitMemos_DebitMemoId1",
                table: "DebitMemoItems",
                column: "DebitMemoId1",
                principalTable: "DebitMemos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DebitMemoItems_SubscriptionItems_SubscriptionItemId1",
                table: "DebitMemoItems",
                column: "SubscriptionItemId1",
                principalTable: "SubscriptionItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DebitMemoItems_Subscriptions_SubscriptionId1",
                table: "DebitMemoItems",
                column: "SubscriptionId1",
                principalTable: "Subscriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DebitMemos_Accounts_AccountId1",
                table: "DebitMemos",
                column: "AccountId1",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DebitMemos_BillingDocumentSettings_BillingDocumentSettingsId",
                table: "DebitMemos",
                column: "BillingDocumentSettingsId",
                principalTable: "BillingDocumentSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DebitMemos_Contacts_BillToId1",
                table: "DebitMemos",
                column: "BillToId1",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DebitMemos_CustomFields_CustomFieldsId",
                table: "DebitMemos",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DebitMemos_CustomObjects_CustomObjectsId",
                table: "DebitMemos",
                column: "CustomObjectsId",
                principalTable: "CustomObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DebitMemos_StateTransitions_StateTransitionsId",
                table: "DebitMemos",
                column: "StateTransitionsId",
                principalTable: "StateTransitions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceItems_CustomFields_CustomFieldsId",
                table: "InvoiceItems",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceItems_CustomObjects_CustomObjectsId",
                table: "InvoiceItems",
                column: "CustomObjectsId",
                principalTable: "CustomObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceItems_Invoices_InvoiceId1",
                table: "InvoiceItems",
                column: "InvoiceId1",
                principalTable: "Invoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceItems_OrderLineItems_LineItemId",
                table: "InvoiceItems",
                column: "LineItemId",
                principalTable: "OrderLineItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceItems_SubscriptionItems_SubscriptionItemId1",
                table: "InvoiceItems",
                column: "SubscriptionItemId1",
                principalTable: "SubscriptionItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceItems_Subscriptions_SubscriptionId1",
                table: "InvoiceItems",
                column: "SubscriptionId1",
                principalTable: "Subscriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Accounts_AccountId1",
                table: "Invoices",
                column: "AccountId1",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_ArTransactions_ArTransactionsId",
                table: "Invoices",
                column: "ArTransactionsId",
                principalTable: "ArTransactions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_BillingDocumentSettings_BillingDocumentSettingsId",
                table: "Invoices",
                column: "BillingDocumentSettingsId",
                principalTable: "BillingDocumentSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Contacts_BillToId1",
                table: "Invoices",
                column: "BillToId1",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Contacts_SoldToId1",
                table: "Invoices",
                column: "SoldToId1",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_CustomFields_CustomFieldsId",
                table: "Invoices",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_CustomObjects_CustomObjectsId",
                table: "Invoices",
                column: "CustomObjectsId",
                principalTable: "CustomObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_StateTransitions_StateTransitionsId",
                table: "Invoices",
                column: "StateTransitionsId",
                principalTable: "StateTransitions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemTier_SubscriptionItems_SubscriptionItemId",
                table: "ItemTier",
                column: "SubscriptionItemId",
                principalTable: "SubscriptionItems",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Accounts_AccountId1",
                table: "Order",
                column: "AccountId1",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_CustomObjects_CustomObjectsId",
                table: "Order",
                column: "CustomObjectsId",
                principalTable: "CustomObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderLineItems_CustomFields_CustomFieldsId",
                table: "OrderLineItems",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderLineItems_CustomObjects_CustomObjectsId",
                table: "OrderLineItems",
                column: "CustomObjectsId",
                principalTable: "CustomObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderLineItems_OrderLineItemRevenue_RevenueId",
                table: "OrderLineItems",
                column: "RevenueId",
                principalTable: "OrderLineItemRevenue",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderLineItems_Order_OrderId1",
                table: "OrderLineItems",
                column: "OrderId1",
                principalTable: "Order",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethods_Accounts_AccountId1",
                table: "PaymentMethods",
                column: "AccountId1",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethods_AchDebit_AchDebitId",
                table: "PaymentMethods",
                column: "AchDebitId",
                principalTable: "AchDebit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethods_ApplePay_ApplePayId",
                table: "PaymentMethods",
                column: "ApplePayId",
                principalTable: "ApplePay",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethods_AuBecsDebit_AuBecsDebitId",
                table: "PaymentMethods",
                column: "AuBecsDebitId",
                principalTable: "AuBecsDebit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethods_AutogiroDebit_AutogiroDebitId",
                table: "PaymentMethods",
                column: "AutogiroDebitId",
                principalTable: "AutogiroDebit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethods_BacsDebit_BacsDebitId",
                table: "PaymentMethods",
                column: "BacsDebitId",
                principalTable: "BacsDebit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethods_BetalingsDebit_BetalingsDebitId",
                table: "PaymentMethods",
                column: "BetalingsDebitId",
                principalTable: "BetalingsDebit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethods_BillingDetails_BillingDetailsId",
                table: "PaymentMethods",
                column: "BillingDetailsId",
                principalTable: "BillingDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethods_CcRef_CcRefId",
                table: "PaymentMethods",
                column: "CcRefId",
                principalTable: "CcRef",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethods_CustomFields_CustomFieldsId",
                table: "PaymentMethods",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethods_CustomObjects_CustomObjectsId",
                table: "PaymentMethods",
                column: "CustomObjectsId",
                principalTable: "CustomObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethods_GetCardList_CardId",
                table: "PaymentMethods",
                column: "CardId",
                principalTable: "GetCardList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethods_GooglePay_GooglePayId",
                table: "PaymentMethods",
                column: "GooglePayId",
                principalTable: "GooglePay",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethods_NzBecsDebit_NzBecsDebitId",
                table: "PaymentMethods",
                column: "NzBecsDebitId",
                principalTable: "NzBecsDebit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethods_PadDebit_PadDebitId",
                table: "PaymentMethods",
                column: "PadDebitId",
                principalTable: "PadDebit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethods_PaypalAdaptive_PaypalAdaptiveId",
                table: "PaymentMethods",
                column: "PaypalAdaptiveId",
                principalTable: "PaypalAdaptive",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethods_PaypalExpressNative_PaypalExpressNativeId",
                table: "PaymentMethods",
                column: "PaypalExpressNativeId",
                principalTable: "PaypalExpressNative",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethods_PaypalExpress_PaypalExpressId",
                table: "PaymentMethods",
                column: "PaypalExpressId",
                principalTable: "PaypalExpress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethods_SepaDebit_SepaDebitId",
                table: "PaymentMethods",
                column: "SepaDebitId",
                principalTable: "SepaDebit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Accounts_AccountId1",
                table: "Payments",
                column: "AccountId1",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_CustomFields_CustomFieldsId",
                table: "Payments",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_CustomObjects_CustomObjectsId",
                table: "Payments",
                column: "CustomObjectsId",
                principalTable: "CustomObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_GatewayOptions_GatewayOptionsId",
                table: "Payments",
                column: "GatewayOptionsId",
                principalTable: "GatewayOptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_GatewayStateTransitions_GatewayStateTransitionsId",
                table: "Payments",
                column: "GatewayStateTransitionsId",
                principalTable: "GatewayStateTransitions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_PaymentMethods_PaymentMethodId1",
                table: "Payments",
                column: "PaymentMethodId1",
                principalTable: "PaymentMethods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_PaymentStateTransitions_StateTransitionsId",
                table: "Payments",
                column: "StateTransitionsId",
                principalTable: "PaymentStateTransitions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_PaymentTransactions_PaymentTransactionsId",
                table: "Payments",
                column: "PaymentTransactionsId",
                principalTable: "PaymentTransactions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentsAppliedTo_BillingDocuments_BillingDocumentId1",
                table: "PaymentsAppliedTo",
                column: "BillingDocumentId1",
                principalTable: "BillingDocuments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentsAppliedTo_Payments_PaymentId",
                table: "PaymentsAppliedTo",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentSchedule_BillingDocuments_BillingDocumentId",
                table: "PaymentSchedule",
                column: "BillingDocumentId",
                principalTable: "BillingDocuments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentSchedule_CustomObjects_CustomObjectsId",
                table: "PaymentSchedule",
                column: "CustomObjectsId",
                principalTable: "CustomObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentScheduleItemPayments_PaymentScheduleItems_PaymentScheduleItemId",
                table: "PaymentScheduleItemPayments",
                column: "PaymentScheduleItemId",
                principalTable: "PaymentScheduleItems",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentScheduleItems_BillingDocuments_BillingDocumentId",
                table: "PaymentScheduleItems",
                column: "BillingDocumentId",
                principalTable: "BillingDocuments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentScheduleItems_CustomFields_CustomFieldsId",
                table: "PaymentScheduleItems",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentScheduleItems_CustomObjects_CustomObjectsId",
                table: "PaymentScheduleItems",
                column: "CustomObjectsId",
                principalTable: "CustomObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentScheduleItems_PaymentSchedule_PaymentScheduleId1",
                table: "PaymentScheduleItems",
                column: "PaymentScheduleId1",
                principalTable: "PaymentSchedule",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentScheduleItems_Payments_PaymentId",
                table: "PaymentScheduleItems",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentTransactions_ArTransactions_ArTransactionsId",
                table: "PaymentTransactions",
                column: "ArTransactionsId",
                principalTable: "ArTransactions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentTransactions_TransactionsState_StateId",
                table: "PaymentTransactions",
                column: "StateId",
                principalTable: "TransactionsState",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Plan_CustomObjects_CustomObjectsId",
                table: "Plan",
                column: "CustomObjectsId",
                principalTable: "CustomObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Plan_Products_ProductId1",
                table: "Plan",
                column: "ProductId1",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PrepaidBalance_Subscriptions_SubscriptionId",
                table: "PrepaidBalance",
                column: "SubscriptionId",
                principalTable: "Subscriptions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PrepaidBalances_Subscriptions_SubscriptionId",
                table: "PrepaidBalances",
                column: "SubscriptionId",
                principalTable: "Subscriptions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Price_CustomObjects_CustomObjectsId",
                table: "Price",
                column: "CustomObjectsId",
                principalTable: "CustomObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductPlan_CustomObjects_CustomObjectsId",
                table: "ProductPlan",
                column: "CustomObjectsId",
                principalTable: "CustomObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductPlan_Products_ProductId1",
                table: "ProductPlan",
                column: "ProductId1",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductPrice_CustomObjects_CustomObjectsId",
                table: "ProductPrice",
                column: "CustomObjectsId",
                principalTable: "CustomObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_CustomFields_CustomFieldsId",
                table: "Products",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_CustomObjects_CustomObjectsId",
                table: "Products",
                column: "CustomObjectsId",
                principalTable: "CustomObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Refunds_Accounts_AccountId1",
                table: "Refunds",
                column: "AccountId1",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Refunds_CreditMemos_CreditMemoId",
                table: "Refunds",
                column: "CreditMemoId",
                principalTable: "CreditMemos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Refunds_CustomFields_CustomFieldsId",
                table: "Refunds",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Refunds_CustomObjects_CustomObjectsId",
                table: "Refunds",
                column: "CustomObjectsId",
                principalTable: "CustomObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Refunds_GatewayOptions_GatewayOptionsId",
                table: "Refunds",
                column: "GatewayOptionsId",
                principalTable: "GatewayOptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Refunds_PaymentMethods_PaymentMethodId1",
                table: "Refunds",
                column: "PaymentMethodId1",
                principalTable: "PaymentMethods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Refunds_RefundStateTransitions_StateTransitionsId",
                table: "Refunds",
                column: "StateTransitionsId",
                principalTable: "RefundStateTransitions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Refunds_RefundTransactions_RefundTransactionsId",
                table: "Refunds",
                column: "RefundTransactionsId",
                principalTable: "RefundTransactions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RefundsAppliedTo_BillingDocuments_BillingDocumentId1",
                table: "RefundsAppliedTo",
                column: "BillingDocumentId1",
                principalTable: "BillingDocuments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RefundsAppliedTo_Payments_PaymentId",
                table: "RefundsAppliedTo",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RefundsAppliedTo_Refunds_RefundId",
                table: "RefundsAppliedTo",
                column: "RefundId",
                principalTable: "Refunds",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RefundTransactions_ArTransactions_ArTransactionsId",
                table: "RefundTransactions",
                column: "ArTransactionsId",
                principalTable: "ArTransactions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RefundTransactions_TransactionsState_StateId",
                table: "RefundTransactions",
                column: "StateId",
                principalTable: "TransactionsState",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionAddPlans_CustomFields_CustomFieldsId",
                table: "SubscriptionAddPlans",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionItems_CustomFields_CustomFieldsId",
                table: "SubscriptionItems",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionItems_CustomObjects_CustomObjectsId",
                table: "SubscriptionItems",
                column: "CustomObjectsId",
                principalTable: "CustomObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionItems_Overage_OverageId",
                table: "SubscriptionItems",
                column: "OverageId",
                principalTable: "Overage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionItems_Price_PriceId1",
                table: "SubscriptionItems",
                column: "PriceId1",
                principalTable: "Price",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionItems_Recurring_RecurringId",
                table: "SubscriptionItems",
                column: "RecurringId",
                principalTable: "Recurring",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionItems_SubscriptionAddPlans_SubscriptionAddPlanId",
                table: "SubscriptionItems",
                column: "SubscriptionAddPlanId",
                principalTable: "SubscriptionAddPlans",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionItems_SubscriptionPlans_SubscriptionPlanId1",
                table: "SubscriptionItems",
                column: "SubscriptionPlanId1",
                principalTable: "SubscriptionPlans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionPauses_CustomFields_CustomFieldsId",
                table: "SubscriptionPauses",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionPauses_ResumeSubscription_ResumeBehaviorId",
                table: "SubscriptionPauses",
                column: "ResumeBehaviorId",
                principalTable: "ResumeSubscription",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionPlans_CustomFields_CustomFieldsId",
                table: "SubscriptionPlans",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionPlans_CustomObjects_CustomObjectsId",
                table: "SubscriptionPlans",
                column: "CustomObjectsId",
                principalTable: "CustomObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionPlans_Plan_PlanId1",
                table: "SubscriptionPlans",
                column: "PlanId1",
                principalTable: "Plan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionPlans_Products_ProductId1",
                table: "SubscriptionPlans",
                column: "ProductId1",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionPlans_Subscriptions_SubscriptionId1",
                table: "SubscriptionPlans",
                column: "SubscriptionId1",
                principalTable: "Subscriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionRenews_SubscriptionTerms_TermsId",
                table: "SubscriptionRenews",
                column: "TermsId",
                principalTable: "SubscriptionTerms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptions_Accounts_AccountId1",
                table: "Subscriptions",
                column: "AccountId1",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptions_Accounts_InvoiceOwnerAccountId1",
                table: "Subscriptions",
                column: "InvoiceOwnerAccountId1",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptions_BillingDocumentSettings_BillingDocumentSettingsId",
                table: "Subscriptions",
                column: "BillingDocumentSettingsId",
                principalTable: "BillingDocumentSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptions_Contacts_BillToId1",
                table: "Subscriptions",
                column: "BillToId1",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptions_Contacts_SoldToId1",
                table: "Subscriptions",
                column: "SoldToId1",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptions_CustomFields_CustomFieldsId",
                table: "Subscriptions",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptions_CustomObjects_CustomObjectsId",
                table: "Subscriptions",
                column: "CustomObjectsId",
                principalTable: "CustomObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptions_Order_OrderId",
                table: "Subscriptions",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptions_Term_CurrentTermId",
                table: "Subscriptions",
                column: "CurrentTermId",
                principalTable: "Term",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptions_Term_InitialTermId",
                table: "Subscriptions",
                column: "InitialTermId",
                principalTable: "Term",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptions_Term_RenewalTermId",
                table: "Subscriptions",
                column: "RenewalTermId",
                principalTable: "Term",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionTerms_Term_CurrentTermId",
                table: "SubscriptionTerms",
                column: "CurrentTermId",
                principalTable: "Term",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionTerms_Term_RenewalTermId",
                table: "SubscriptionTerms",
                column: "RenewalTermId",
                principalTable: "Term",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaxationItems_BillingDocumentItems_BillingDocumentItemId",
                table: "TaxationItems",
                column: "BillingDocumentItemId",
                principalTable: "BillingDocumentItems",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TaxationItems_CreditMemoItems_CreditMemoItemId",
                table: "TaxationItems",
                column: "CreditMemoItemId",
                principalTable: "CreditMemoItems",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TaxationItems_CustomFields_CustomFieldsId",
                table: "TaxationItems",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaxationItems_CustomObjects_CustomObjectsId",
                table: "TaxationItems",
                column: "CustomObjectsId",
                principalTable: "CustomObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaxationItems_DebitMemoItems_DebitMemoItemId",
                table: "TaxationItems",
                column: "DebitMemoItemId",
                principalTable: "DebitMemoItems",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TaxationItems_InvoiceItems_InvoiceItemId",
                table: "TaxationItems",
                column: "InvoiceItemId",
                principalTable: "InvoiceItems",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Usages_Accounts_AccountId1",
                table: "Usages",
                column: "AccountId1",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usages_CustomFields_CustomFieldsId",
                table: "Usages",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usages_CustomObjects_CustomObjectsId",
                table: "Usages",
                column: "CustomObjectsId",
                principalTable: "CustomObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
