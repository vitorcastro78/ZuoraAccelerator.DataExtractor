using Microsoft.EntityFrameworkCore;
using ZIP2GO.Repository.Models;

namespace Repository.DataContext
{
    public class AppDataContext : DbContext
    {
        public DbSet<Account> Account{ get; set; }

        public DbSet<Address> Address { get; set; }

        public DbSet<ArTransactions> ArTransaction{ get; set; }

        public DbSet<BillingDocumentItem> BillingDocumentItem{ get; set; }

        public DbSet<BillingDocument> BillingDocument{ get; set; }

        public DbSet<BillingDocumentSettings> BillingDocumentSetting{ get; set; }

        public DbSet<Contact> Contact{ get; set; }

        public DbSet<CreditMemoAppliedTo> CreditMemoAppliedTo { get; set; }

        public DbSet<CreditMemoItem> CreditMemoItem{ get; set; }

        public DbSet<CreditMemo> CreditMemo{ get; set; }

        public DbSet<CustomObject> CustomObject{ get; set; }

        public DbSet<DebitMemoItem> DebitMemoItem{ get; set; }

        public DbSet<DebitMemo> DebitMemo{ get; set; }

        public DbSet<InvoiceItem> InvoiceItem{ get; set; }

        public DbSet<Invoice> Invoice{ get; set; }

        public DbSet<Order> Order { get; set; }

        public DbSet<OrderItem> OrderLineItem{ get; set; }

        public DbSet<PaymentMethod> PaymentMethod{ get; set; }

        public DbSet<Payment> Payment{ get; set; }

        public DbSet<PaymentsAppliedTo> PaymentsAppliedTo { get; set; }

        public DbSet<PaymentScheduleItem> PaymentScheduleItem{ get; set; }

        public DbSet<PaymentTransactions> PaymentTransaction{ get; set; }

        public DbSet<Product> Product{ get; set; }

        public DbSet<Refund> Refund{ get; set; }

        public DbSet<RefundTransactions> RefundTransaction{ get; set; }

        public DbSet<SubscriptionAddPlan> SubscriptionAddPlan{ get; set; }

        public DbSet<SubscriptionCancel> SubscriptionCancel{ get; set; }

        public DbSet<SubscriptionItem> SubscriptionItem{ get; set; }

        public DbSet<SubscriptionPause> SubscriptionPause{ get; set; }

        public DbSet<SubscriptionPlan> SubscriptionPlan{ get; set; }

        public DbSet<SubscriptionRemovePlan> SubscriptionRemovePlan{ get; set; }

        public DbSet<SubscriptionRenew> SubscriptionRenew{ get; set; }

        public DbSet<Subscription> Subscription{ get; set; }

        public DbSet<SubscriptionTerm> SubscriptionTerm{ get; set; }

        public DbSet<TaxationItem> TaxationItem{ get; set; }

        public DbSet<TaxCertificate> TaxCertificate{ get; set; }

        public DbSet<TaxIdentifier> TaxIdentifier{ get; set; }

        public DbSet<TransactionsState> TransactionsState { get; set; }

        public DbSet<Usage> Usage{ get; set; }

        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
        {
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Account>().ToTable("Account");
        //    modelBuilder.Entity<Subscription>().ToTable("Subscription");
        //    modelBuilder.Entity<SubscriptionAddPlan>().ToTable("SubscriptionAddPlan");
        //    modelBuilder.Entity<SubscriptionCancel>().ToTable("SubscriptionCancel");
        //    modelBuilder.Entity<SubscriptionPause>().ToTable("SubscriptionPause");
        //    modelBuilder.Entity<SubscriptionRemovePlan>().ToTable("SubscriptionRemovePlan");
        //    modelBuilder.Entity<SubscriptionRenew>().ToTable("SubscriptionRenew");
        //    modelBuilder.Entity<ArTransactions>().ToTable("ArTransactions");
        //    modelBuilder.Entity<CreditMemo>().ToTable("CreditMemo");
        //    modelBuilder.Entity<Invoice>().ToTable("Invoice");
        //    modelBuilder.Entity<PaymentTransactions>().ToTable("PaymentTransactions");
        //    modelBuilder.Entity<RefundTransactions>().ToTable("RefundTransactions");
        //    modelBuilder.Entity<TransactionsState>().ToTable("TransactionsState");
        //    modelBuilder.Entity<Usage>().ToTable("Usage");
        //    modelBuilder.Entity<CreditMemoItem>().ToTable("CreditMemoItem");
        //    modelBuilder.Entity<InvoiceItem>().ToTable("InvoiceItem");
        //    modelBuilder.Entity<Refund>().ToTable("Refund");
        //    modelBuilder.Entity<SubscriptionPlan>().ToTable("SubscriptionPlan");
        //    modelBuilder.Entity<SubscriptionTerm>().ToTable("SubscriptionTerm");
        //    modelBuilder.Entity<TaxCertificate>().ToTable("TaxCertificate");
        //    modelBuilder.Entity<SubscriptionItem>().ToTable("SubscriptionItem");
        //    modelBuilder.Entity<BillingDocument>().ToTable("BillingDocument");
        //    modelBuilder.Entity<BillingDocumentSettings>().ToTable("BillingDocumentSettings");
        //    modelBuilder.Entity<Contact>().ToTable("Contact");
        //    modelBuilder.Entity<CustomObject>().ToTable("CustomObject");
        //    modelBuilder.Entity<DebitMemo>().ToTable("DebitMemo");
        //    modelBuilder.Entity<PaymentMethod>().ToTable("PaymentMethod");
        //    modelBuilder.Entity<Payment>().ToTable("Payment");
        //    modelBuilder.Entity<TaxIdentifier>().ToTable("TaxIdentifier");
        //    modelBuilder.Entity<BillingDocumentItem>().ToTable("BillingDocumentItem");
        //    modelBuilder.Entity<PaymentScheduleItem>().ToTable("PaymentScheduleItem");
        //    modelBuilder.Entity<OrderItem>().ToTable("OrderLineItem");
        //    modelBuilder.Entity<PaymentsAppliedTo>().ToTable("PaymentsAppliedTo");
        //    modelBuilder.Entity<CreditMemoAppliedTo>().ToTable("CreditMemoAppliedTo");
        //    modelBuilder.Entity<DebitMemoItem>().ToTable("DebitMemoItem");
        //    modelBuilder.Entity<TaxationItem>().ToTable("TaxationItem");
        //}
    }
}