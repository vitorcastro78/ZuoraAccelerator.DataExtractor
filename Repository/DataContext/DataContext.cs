﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ZIP2GO.Repository.Models;

namespace Repository.DataContext
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
        {
        }

        public DbSet<Account> Account { get; set; }

        public DbSet<Address> Address { get; set; }

        public DbSet<Amounts> Amounts { get; set; }

        public DbSet<ArTransactions> ArTransaction { get; set; }

        public DbSet<BillingDocument> BillingDocument { get; set; }

        public DbSet<BillingDocumentItem> BillingDocumentItem { get; set; }

        public DbSet<BillingDocumentSettings> BillingDocumentSetting { get; set; }

        public DbSet<BillRun> BillRun { get; set; }

        public DbSet<BillTo> BillTo { get; set; }

        public DbSet<Contact> Contact { get; set; }

        public DbSet<CreditMemo> CreditMemo { get; set; }

        public DbSet<CreditMemoAppliedTo> CreditMemoAppliedTo { get; set; }

        public DbSet<CreditMemoItem> CreditMemoItem { get; set; }

        public DbSet<CustomObject> CustomObject { get; set; }

        public DbSet<DebitMemo> DebitMemo { get; set; }

        public DbSet<DebitMemoItem> DebitMemoItem { get; set; }

        public DbSet<Fulfillment> Fulfillment { get; set; }

        public DbSet<FulfillmentItem> FulfillmentItem { get; set; }

        public DbSet<Invoice> Invoice { get; set; }

        public DbSet<InvoiceItem> InvoiceItem { get; set; }

        public DbSet<Money> Money { get; set; }

        public DbSet<Order> Order { get; set; }

        public DbSet<OrderItem> OrderLineItem { get; set; }

        public DbSet<Payment> Payment { get; set; }

        public DbSet<PaymentMethod> PaymentMethod { get; set; }

        public DbSet<PaymentsAppliedTo> PaymentsAppliedTo { get; set; }

        public DbSet<PaymentScheduleItem> PaymentScheduleItem { get; set; }

        public DbSet<PaymentTransactions> PaymentTransaction { get; set; }

        public DbSet<Plan> Plan { get; set; }

        public DbSet<Price> Price { get; set; }

        public DbSet<Product> Product { get; set; }

        public DbSet<ProductPlan> ProductPlan { get; set; }

        public DbSet<ProductPrice> ProductPrice { get; set; }

        public DbSet<ProductTier> ProductTier { get; set; }

        public DbSet<Refund> Refund { get; set; }

        public DbSet<RefundTransactions> RefundTransaction { get; set; }

        public DbSet<SoldTo> SoldTo { get; set; }

        public DbSet<Subscription> Subscription { get; set; }

        public DbSet<SubscriptionAddPlan> SubscriptionAddPlan { get; set; }

        public DbSet<SubscriptionCancel> SubscriptionCancel { get; set; }

        public DbSet<SubscriptionItem> SubscriptionItem { get; set; }

        public DbSet<SubscriptionPause> SubscriptionPause { get; set; }

        public DbSet<SubscriptionPlan> SubscriptionPlan { get; set; }

        public DbSet<SubscriptionRemovePlan> SubscriptionRemovePlan { get; set; }

        public DbSet<SubscriptionRenew> SubscriptionRenew { get; set; }

        public DbSet<SubscriptionTerm> SubscriptionTerm { get; set; }

        public DbSet<TaxationItem> TaxationItem { get; set; }

        public DbSet<TaxCertificate> TaxCertificate { get; set; }

        public DbSet<TaxIdentifier> TaxIdentifier { get; set; }

        public DbSet<Tier> Tier { get; set; }

        public DbSet<TransactionsState> TransactionsState { get; set; }

        public DbSet<Usage> Usage { get; set; }

        // Novos DbSets adicionados
        //public DbSet<AddressFieldDefinitions> AddressFieldDefinitions { get; set; }
        //public DbSet<ApplePay> ApplePay { get; set; }
        //public DbSet<ApplePayCreate> ApplePayCreate { get; set; }
        //public DbSet<AchDebit> AchDebit { get; set; }
        //public DbSet<AchDebitUpdate> AchDebitUpdate { get; set; }
        //public DbSet<BillRunPreview> BillRunPreview { get; set; }
        //public DbSet<CardMandate> CardMandate { get; set; }
        //public DbSet<CustomFields> CustomFields { get; set; }
        //public DbSet<Detail> Detail { get; set; }
        //public DbSet<Error> Error { get; set; }
        //public DbSet<FulfillmentProcessingOption> FulfillmentProcessingOption { get; set; }
        //public DbSet<GetByIdQueryParams> GetByIdQueryParams { get; set; }
        //public DbSet<Headers> Headers { get; set; }
        //public DbSet<OrderAction> OrderAction { get; set; }
        //public DbSet<PadDebit> PadDebit { get; set; }
        //public DbSet<PaymentRun> PaymentRun { get; set; }
        //public DbSet<PaymentRunSummary> PaymentRunSummary { get; set; }
        //public DbSet<PaymentSchedule> PaymentSchedule { get; set; }
        //public DbSet<PaymentScheduleItemLink> PaymentScheduleItemLink { get; set; }
        //public DbSet<PaymentScheduleItemPatch> PaymentScheduleItemPatch { get; set; }
        //public DbSet<PaymentScheduleItemPayments> PaymentScheduleItemPayments { get; set; }
        //public DbSet<PaymentScheduleItemPaymentOption> PaymentScheduleItemPaymentOption { get; set; }
        //public DbSet<PaymentScheduleItemRetry> PaymentScheduleItemRetry { get; set; }
        //public DbSet<PaymentScheduleItemRetryBulk> PaymentScheduleItemRetryBulk { get; set; }
        //public DbSet<PaymentScheduleItemUnlink> PaymentScheduleItemUnlink { get; set; }
        //public DbSet<PaypalExpress> PaypalExpress { get; set; }
        //public DbSet<PaypalExpressNative> PaypalExpressNative { get; set; }
        //public DbSet<PrepaidBalance> PrepaidBalance { get; set; }
        //public DbSet<Prepayment> Prepayment { get; set; }
        //public DbSet<ProcessingOptions> ProcessingOptions { get; set; }
        //public DbSet<QueryRun> QueryRun { get; set; }
        //public DbSet<QueryRunFile> QueryRunFile { get; set; }
        //public DbSet<RefundAppliedToItem> RefundAppliedToItem { get; set; }
        //public DbSet<RefundsAppliedTo> RefundsAppliedTo { get; set; }
        //public DbSet<RefundStateTransitions> RefundStateTransitions { get; set; }
        //public DbSet<ResumeSubscription> ResumeSubscription { get; set; }
        //public DbSet<Revenue> Revenue { get; set; }
        //public DbSet<SepaDebit> SepaDebit { get; set; }
        //public DbSet<StartOn> StartOn { get; set; }
        //public DbSet<StateTransitions> StateTransitions { get; set; }
        //public DbSet<SubscriptionItemDrawdownField> SubscriptionItemDrawdownField { get; set; }
        //public DbSet<SubscriptionItemPrepaymentField> SubscriptionItemPrepaymentField { get; set; }
        //public DbSet<SubscriptionReplacePlan> SubscriptionReplacePlan { get; set; }
        //public DbSet<SubscriptionUpdatePlanPatchResponse> SubscriptionUpdatePlanPatchResponse { get; set; }
        //public DbSet<SubscriptionVersion> SubscriptionVersion { get; set; }
        //public DbSet<SubscriptionVersionOrder> SubscriptionVersionOrder { get; set; }
        //public DbSet<ValidityPeriod> ValidityPeriod { get; set; }
        //public DbSet<WorkflowRun> WorkflowRun { get; set; }
        //public DbSet<WriteOff> WriteOff { get; set; }
        //public DbSet<WriteOffState> WriteOffState { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                foreach (var foreignKey in entityType.GetForeignKeys())
                {
                    foreignKey.DeleteBehavior = DeleteBehavior.ClientSetNull;
                }
            }


            base.OnModelCreating(modelBuilder);


            // Mapear entidades para tabelas específicas no esquema "DataExtractor"
            //modelBuilder.Entity<Address>().ToTable("Address", "DataExtractor");
            //modelBuilder.Entity<Account>().ToTable("Account", "DataExtractor");
            //modelBuilder.Entity<Subscription>().ToTable("Subscription", "DataExtractor");
            //modelBuilder.Entity<SubscriptionAddPlan>().ToTable("SubscriptionAddPlan", "DataExtractor");
            //modelBuilder.Entity<SubscriptionCancel>().ToTable("SubscriptionCancel", "DataExtractor");
            //modelBuilder.Entity<SubscriptionPause>().ToTable("SubscriptionPause", "DataExtractor");
            //modelBuilder.Entity<SubscriptionRemovePlan>().ToTable("SubscriptionRemovePlan", "DataExtractor");
            //modelBuilder.Entity<SubscriptionRenew>().ToTable("SubscriptionRenew", "DataExtractor");
            //modelBuilder.Entity<ArTransactions>().ToTable("ArTransactions", "DataExtractor");
            //modelBuilder.Entity<CreditMemo>().ToTable("CreditMemo", "DataExtractor");
            //modelBuilder.Entity<Invoice>().ToTable("Invoice", "DataExtractor");
            //modelBuilder.Entity<PaymentTransactions>().ToTable("PaymentTransactions", "DataExtractor");
            //modelBuilder.Entity<RefundTransactions>().ToTable("RefundTransactions", "DataExtractor");
            //modelBuilder.Entity<TransactionsState>().ToTable("TransactionsState", "DataExtractor");
            //modelBuilder.Entity<Usage>().ToTable("Usage", "DataExtractor");
            //modelBuilder.Entity<CreditMemoItem>().ToTable("CreditMemoItem", "DataExtractor");
            //modelBuilder.Entity<InvoiceItem>().ToTable("InvoiceItem", "DataExtractor");
            //modelBuilder.Entity<Refund>().ToTable("Refund", "DataExtractor");
            //modelBuilder.Entity<SubscriptionPlan>().ToTable("SubscriptionPlan", "DataExtractor");
            //modelBuilder.Entity<SubscriptionTerm>().ToTable("SubscriptionTerm", "DataExtractor");
            //modelBuilder.Entity<TaxCertificate>().ToTable("TaxCertificate", "DataExtractor");
            //modelBuilder.Entity<SubscriptionItem>().ToTable("SubscriptionItem", "DataExtractor");
            //modelBuilder.Entity<BillingDocument>().ToTable("BillingDocument", "DataExtractor");
            //modelBuilder.Entity<BillingDocumentSettings>().ToTable("BillingDocumentSettings", "DataExtractor");
            //modelBuilder.Entity<Contact>().ToTable("Contact", "DataExtractor");
            //modelBuilder.Entity<CustomObject>().ToTable("CustomObject", "DataExtractor");
            //modelBuilder.Entity<DebitMemo>().ToTable("DebitMemo", "DataExtractor");
            //modelBuilder.Entity<PaymentMethod>().ToTable("PaymentMethod", "DataExtractor");
            //modelBuilder.Entity<Payment>().ToTable("Payment", "DataExtractor");
            //modelBuilder.Entity<TaxIdentifier>().ToTable("TaxIdentifier", "DataExtractor");
            //modelBuilder.Entity<BillingDocumentItem>().ToTable("BillingDocumentItem", "DataExtractor");
            //modelBuilder.Entity<PaymentScheduleItem>().ToTable("PaymentScheduleItem", "DataExtractor");
            //modelBuilder.Entity<OrderItem>().ToTable("OrderLineItem", "DataExtractor");
            //modelBuilder.Entity<PaymentsAppliedTo>().ToTable("PaymentsAppliedTo", "DataExtractor");
            //modelBuilder.Entity<CreditMemoAppliedTo>().ToTable("CreditMemoAppliedTo", "DataExtractor");
            //modelBuilder.Entity<DebitMemoItem>().ToTable("DebitMemoItem", "DataExtractor");
            //modelBuilder.Entity<TaxationItem>().ToTable("TaxationItem", "DataExtractor");
        }
    }
}