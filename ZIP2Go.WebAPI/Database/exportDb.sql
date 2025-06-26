-- Script Date: 23/06/2025 15:59  - ErikEJ.SqlCeScripting version 3.5.2.95
-- Database information:
-- Database: C:\Users\vitor\source\repos\vitorcastro78\ZuoraAccelerator.DataExtractor\ZIP2Go.WebAPI\Database\subscription.db
-- ServerVersion: 3.40.0
-- DatabaseSize: 1,758 MB
-- Created: 12/06/2025 10:12

-- User Table information:
-- Number of tables: 97
-- __EFMigrationsHistory: -1 row(s)
-- __EFMigrationsLock: -1 row(s)
-- Accounts: -1 row(s)
-- AchDebit: -1 row(s)
-- Address: -1 row(s)
-- AddressFieldDefinitions: -1 row(s)
-- Amounts: -1 row(s)
-- ApplePay: -1 row(s)
-- ArTransactions: -1 row(s)
-- AuBecsDebit: -1 row(s)
-- AutogiroDebit: -1 row(s)
-- BacsDebit: -1 row(s)
-- BetalingsDebit: -1 row(s)
-- BillingDetails: -1 row(s)
-- BillingDocumentItems: -1 row(s)
-- BillingDocuments: -1 row(s)
-- BillingDocumentSettings: -1 row(s)
-- BillingDocumentStateTransitions: -1 row(s)
-- Card: -1 row(s)
-- CardMandate: -1 row(s)
-- CcRef: -1 row(s)
-- CcRefCard: -1 row(s)
-- Contacts: -1 row(s)
-- CreditMemoAppliedTo: -1 row(s)
-- CreditMemoItems: -1 row(s)
-- CreditMemos: -1 row(s)
-- CustomerAcceptanceMandate: -1 row(s)
-- CustomFields: -1 row(s)
-- CustomObjects: -1 row(s)
-- DebitMemoItems: -1 row(s)
-- DebitMemos: -1 row(s)
-- Detail: -1 row(s)
-- Drawdown: -1 row(s)
-- GatewayOptions: -1 row(s)
-- GatewayStateTransitions: -1 row(s)
-- GetCardList: -1 row(s)
-- GooglePay: -1 row(s)
-- InvoiceItems: -1 row(s)
-- Invoices: -1 row(s)
-- ItemTier: -1 row(s)
-- Mandate: -1 row(s)
-- Money: -1 row(s)
-- NzBecsDebit: -1 row(s)
-- Order: -1 row(s)
-- OrderLineItemRevenue: -1 row(s)
-- OrderLineItems: -1 row(s)
-- Overage: -1 row(s)
-- PadDebit: -1 row(s)
-- PaymentMethods: -1 row(s)
-- PaymentOption: -1 row(s)
-- Payments: -1 row(s)
-- PaymentsAppliedTo: -1 row(s)
-- PaymentSchedule: -1 row(s)
-- PaymentScheduleItemPayments: -1 row(s)
-- PaymentScheduleItems: -1 row(s)
-- PaymentStateTransitions: -1 row(s)
-- PaymentTransactions: -1 row(s)
-- PaypalAdaptive: -1 row(s)
-- PaypalExpress: -1 row(s)
-- PaypalExpressNative: -1 row(s)
-- Plan: -1 row(s)
-- PrepaidBalance: -1 row(s)
-- PrepaidBalances: -1 row(s)
-- PrepaidBalanceTransaction: -1 row(s)
-- Prepayment: -1 row(s)
-- Price: -1 row(s)
-- ProductPlan: -1 row(s)
-- ProductPrice: -1 row(s)
-- Products: -1 row(s)
-- ProductTier: -1 row(s)
-- Recurring: -1 row(s)
-- RefundAppliedToItem: -1 row(s)
-- Refunds: -1 row(s)
-- RefundsAppliedTo: -1 row(s)
-- RefundStateTransitions: -1 row(s)
-- RefundTransactions: -1 row(s)
-- ResumeSubscription: -1 row(s)
-- Revenue: -1 row(s)
-- SepaDebit: -1 row(s)
-- StateTransitions: -1 row(s)
-- SubscriptionAddPlans: -1 row(s)
-- SubscriptionCancels: -1 row(s)
-- SubscriptionItems: -1 row(s)
-- SubscriptionPauses: -1 row(s)
-- SubscriptionPlans: -1 row(s)
-- SubscriptionRemovePlans: -1 row(s)
-- SubscriptionRenews: -1 row(s)
-- Subscriptions: -1 row(s)
-- SubscriptionTerms: -1 row(s)
-- TaxationItems: -1 row(s)
-- TaxCertificates: -1 row(s)
-- TaxIdentifiers: -1 row(s)
-- Term: -1 row(s)
-- Tier: -1 row(s)
-- TransactionsState: -1 row(s)
-- Usages: -1 row(s)
-- ValidityPeriod: -1 row(s)

-- Warning - circular reference preventing proper sorting of tables
SELECT 1;
PRAGMA foreign_keys=OFF;
BEGIN TRANSACTION;
CREATE TABLE [__EFMigrationsHistory] (
  [MigrationId] text NOT NULL
, [ProductVersion] text NOT NULL
, CONSTRAINT [sqlite_autoindex___EFMigrationsHistory_1] PRIMARY KEY ([MigrationId])
);
CREATE TABLE [__EFMigrationsLock] (
  [Id] bigint NOT NULL
, [Timestamp] text NOT NULL
, CONSTRAINT [sqlite_master_PK___EFMigrationsLock] PRIMARY KEY ([Id])
);
CREATE TABLE [Accounts] (
  [Id] text NOT NULL
, [AccountNumber] text NOT NULL
, [AutoPay] bigint NULL
, [Batch] text NOT NULL
, [BillCycleDay] bigint NULL
, [BillingDocumentsId] text NOT NULL
, [BillingDocumentSettingsId] text NOT NULL
, [BillToId1] text NOT NULL
, [BillToId] text NOT NULL
, [CommunicationProfileId] text NOT NULL
, [CreatedById] text NOT NULL
, [CreatedTime] text NULL
, [CrmId] text NOT NULL
, [Currency] text NOT NULL
, [CustomFieldsId] text NOT NULL
, [CustomObjectsId] text NOT NULL
, [DefaultPaymentMethodId] text NOT NULL
, [Description] text NOT NULL
, [Enabled] bigint NULL
, [Name] text NOT NULL
, [ParentAccountId] text NOT NULL
, [PaymentGateway] text NOT NULL
, [PaymentTerms] text NOT NULL
, [RemainingCreditMemoBalance] text NULL
, [RemainingDebitMemoBalance] text NULL
, [RemainingInvoiceBalance] text NULL
, [RemainingPaymentBalance] text NULL
, [SalesRep] text NOT NULL
, [SequenceSetId] text NOT NULL
, [SoldToId1] text NOT NULL
, [SoldToId] text NOT NULL
, [TaxCertificateId] text NOT NULL
, [TaxIdentifierId] text NOT NULL
, [UpdatedById] text NOT NULL
, [UpdatedTime] text NULL
, CONSTRAINT [sqlite_autoindex_Accounts_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_Accounts_0_0] FOREIGN KEY ([BillingDocumentSettingsId]) REFERENCES [BillingDocumentSettings] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Accounts_1_0] FOREIGN KEY ([TaxIdentifierId]) REFERENCES [TaxIdentifiers] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Accounts_2_0] FOREIGN KEY ([TaxCertificateId]) REFERENCES [TaxCertificates] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Accounts_3_0] FOREIGN KEY ([CustomObjectsId]) REFERENCES [CustomObjects] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Accounts_4_0] FOREIGN KEY ([CustomFieldsId]) REFERENCES [CustomFields] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Accounts_5_0] FOREIGN KEY ([SoldToId1]) REFERENCES [Contacts] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Accounts_6_0] FOREIGN KEY ([BillToId1]) REFERENCES [Contacts] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Accounts_7_0] FOREIGN KEY ([BillingDocumentsId]) REFERENCES [BillingDocuments] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [AchDebit] (
  [Id] text NOT NULL
, [BankAbaCode] text NOT NULL
, [BankAccountName] text NOT NULL
, [BankAccountNumber] text NOT NULL
, [BankAccountType] text NOT NULL
, [BankName] text NOT NULL
, [MandateId] text NOT NULL
, CONSTRAINT [sqlite_autoindex_AchDebit_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_AchDebit_0_0] FOREIGN KEY ([MandateId]) REFERENCES [Mandate] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [Address] (
  [Id] text NOT NULL
, [City] text NOT NULL
, [Country] text NOT NULL
, [County] text NOT NULL
, [Line1] text NOT NULL
, [Line2] text NOT NULL
, [PostalCode] text NOT NULL
, [State] text NOT NULL
, CONSTRAINT [sqlite_autoindex_Address_1] PRIMARY KEY ([Id])
);
CREATE TABLE [AddressFieldDefinitions] (
  [Id] text NOT NULL
, [City] text NOT NULL
, [Country] text NOT NULL
, [Line1] text NOT NULL
, [Line2] text NOT NULL
, [PostalCode] text NOT NULL
, [State] text NOT NULL
, CONSTRAINT [sqlite_autoindex_AddressFieldDefinitions_1] PRIMARY KEY ([Id])
);
CREATE TABLE [Amounts] (
  [Id] text NOT NULL
, CONSTRAINT [sqlite_autoindex_Amounts_1] PRIMARY KEY ([Id])
);
CREATE TABLE [ApplePay] (
  [Id] text NOT NULL
, [CardId] text NOT NULL
, [MandateId] text NOT NULL
, [PaymentId] text NOT NULL
, [Token] text NOT NULL
, CONSTRAINT [sqlite_autoindex_ApplePay_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_ApplePay_0_0] FOREIGN KEY ([MandateId]) REFERENCES [Mandate] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_ApplePay_1_0] FOREIGN KEY ([CardId]) REFERENCES [Card] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [ArTransactions] (
  [Id] text NOT NULL
, [CreditMemoNumbers] text NOT NULL
, [InvoiceNumbers] text NOT NULL
, CONSTRAINT [sqlite_autoindex_ArTransactions_1] PRIMARY KEY ([Id])
);
CREATE TABLE [AuBecsDebit] (
  [Id] text NOT NULL
, [AccountNumber] text NOT NULL
, [BranchCode] text NOT NULL
, [MandateId] text NOT NULL
, CONSTRAINT [sqlite_autoindex_AuBecsDebit_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_AuBecsDebit_0_0] FOREIGN KEY ([MandateId]) REFERENCES [Mandate] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [AutogiroDebit] (
  [Id] text NOT NULL
, [AccountNumber] text NOT NULL
, [BranchCode] text NOT NULL
, [IdentityNumber] text NOT NULL
, [MandateId] text NOT NULL
, CONSTRAINT [sqlite_autoindex_AutogiroDebit_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_AutogiroDebit_0_0] FOREIGN KEY ([MandateId]) REFERENCES [Mandate] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [BacsDebit] (
  [Id] text NOT NULL
, [AccountNumber] text NOT NULL
, [BankCode] text NOT NULL
, [MandateId] text NOT NULL
, CONSTRAINT [sqlite_autoindex_BacsDebit_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_BacsDebit_0_0] FOREIGN KEY ([MandateId]) REFERENCES [Mandate] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [BetalingsDebit] (
  [Id] text NOT NULL
, [AccountNumber] text NOT NULL
, [BankCode] text NOT NULL
, [IdentityNumber] text NOT NULL
, [MandateId] text NOT NULL
, CONSTRAINT [sqlite_autoindex_BetalingsDebit_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_BetalingsDebit_0_0] FOREIGN KEY ([MandateId]) REFERENCES [Mandate] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [BillingDetails] (
  [Id] text NOT NULL
, [AddressId] text NOT NULL
, [Email] text NOT NULL
, [Name] text NOT NULL
, [Phone] text NOT NULL
, CONSTRAINT [sqlite_autoindex_BillingDetails_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_BillingDetails_0_0] FOREIGN KEY ([AddressId]) REFERENCES [AddressFieldDefinitions] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [BillingDocumentItems] (
  [Id] text NOT NULL
, [AccountingCode] text NOT NULL
, [AccountsReceivableAccount] text NOT NULL
, [Amount] text NULL
, [AppliedToItemId] text NOT NULL
, [BillingDocumentId1] text NOT NULL
, [BillingDocumentId] text NOT NULL
, [BookingReference] text NOT NULL
, [CreatedById] text NOT NULL
, [CreatedTime] text NULL
, [CustomFieldsId] text NOT NULL
, [CustomObjectsId] text NOT NULL
, [DeferredRevenueAccount] text NOT NULL
, [Description] text NOT NULL
, [DiscountItem] bigint NULL
, [DocumentItemDate] text NULL
, [InvoiceItemId] text NOT NULL
, [Name] text NOT NULL
, [OnAccountAccount] text NOT NULL
, [PriceDescription] text NOT NULL
, [PriceId] text NOT NULL
, [ProductName] text NOT NULL
, [PurchaseOrderNumber] text NOT NULL
, [Quantity] text NULL
, [RecognizedRevenueAccount] text NOT NULL
, [RemainingBalance] text NULL
, [RevenueRecognitionRuleName] text NOT NULL
, [ServiceEnd] text NOT NULL
, [ServiceStart] text NOT NULL
, [Sku] text NOT NULL
, [SubscriptionId1] text NOT NULL
, [SubscriptionId] text NOT NULL
, [SubscriptionItemId1] text NOT NULL
, [SubscriptionItemId] text NOT NULL
, [Subtotal] text NULL
, [Tax] text NULL
, [TaxCode] text NOT NULL
, [TaxInclusive] bigint NULL
, [Type] text NOT NULL
, [UnitAmount] text NULL
, [UnitOfMeasure] text NOT NULL
, [UpdatedById] text NOT NULL
, [UpdatedTime] text NULL
, [PaymentsAppliedToId] text NULL
, CONSTRAINT [sqlite_autoindex_BillingDocumentItems_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_BillingDocumentItems_0_0] FOREIGN KEY ([SubscriptionId1]) REFERENCES [Subscriptions] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_BillingDocumentItems_1_0] FOREIGN KEY ([SubscriptionItemId1]) REFERENCES [SubscriptionItems] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_BillingDocumentItems_2_0] FOREIGN KEY ([PaymentsAppliedToId]) REFERENCES [PaymentsAppliedTo] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
, CONSTRAINT [FK_BillingDocumentItems_3_0] FOREIGN KEY ([CustomObjectsId]) REFERENCES [CustomObjects] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_BillingDocumentItems_4_0] FOREIGN KEY ([CustomFieldsId]) REFERENCES [CustomFields] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_BillingDocumentItems_5_0] FOREIGN KEY ([BillingDocumentId1]) REFERENCES [BillingDocuments] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [BillingDocuments] (
  [Id] text NOT NULL
, [AccountId] text NOT NULL
, [AccountNumber] text NOT NULL
, [AmountPaid] text NULL
, [AmountRefunded] text NULL
, [Balance] text NULL
, [BillingDocumentNumber] text NOT NULL
, [CreatedById] text NOT NULL
, [CreatedTime] text NULL
, [CustomFieldsId] text NOT NULL
, [CustomObjectsId] text NOT NULL
, [Description] text NOT NULL
, [DocumentDate] text NULL
, [DueDate] text NULL
, [ExcludeFromAutoApplyRules] bigint NULL
, [InvoiceId] text NOT NULL
, [Paid] bigint NULL
, [PastDue] bigint NULL
, [Pay] bigint NULL
, [PostedById] text NOT NULL
, [ReasonCode] text NOT NULL
, [RemainingBalance] text NULL
, [State] text NOT NULL
, [Subtotal] text NULL
, [Tax] text NULL
, [Total] text NULL
, [TransferToAccounting] bigint NULL
, [Type] text NOT NULL
, [UpdatedById] text NOT NULL
, [UpdatedTime] text NULL
, CONSTRAINT [sqlite_autoindex_BillingDocuments_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_BillingDocuments_0_0] FOREIGN KEY ([CustomObjectsId]) REFERENCES [CustomObjects] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_BillingDocuments_1_0] FOREIGN KEY ([CustomFieldsId]) REFERENCES [CustomFields] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [BillingDocumentSettings] (
  [Id] text NOT NULL
, [AdditionalEmail] text NOT NULL
, [CreditMemoTemplateId] text NOT NULL
, [DebitMemoTemplateId] text NOT NULL
, [EmailDocuments] bigint NULL
, [InvoiceTemplateId] text NOT NULL
, [PrintDocuments] bigint NULL
, [CreditMemoId] text NULL
, CONSTRAINT [sqlite_autoindex_BillingDocumentSettings_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_BillingDocumentSettings_0_0] FOREIGN KEY ([CreditMemoId]) REFERENCES [CreditMemos] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
);
CREATE TABLE [BillingDocumentStateTransitions] (
  [Id] text NOT NULL
, [CanceledTime] text NOT NULL
, [PostedTime] text NOT NULL
, [BillingDocumentId] text NULL
, CONSTRAINT [sqlite_autoindex_BillingDocumentStateTransitions_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_BillingDocumentStateTransitions_0_0] FOREIGN KEY ([BillingDocumentId]) REFERENCES [BillingDocuments] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
);
CREATE TABLE [Card] (
  [Id] text NOT NULL
, [Brand] text NOT NULL
, [CardNumber] text NOT NULL
, [ExpiryMonth] text NULL
, [ExpiryYear] text NULL
, [Last4] text NOT NULL
, [MandateId] text NOT NULL
, [SecurityCode] text NOT NULL
, CONSTRAINT [sqlite_autoindex_Card_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_Card_0_0] FOREIGN KEY ([MandateId]) REFERENCES [CardMandate] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [CardMandate] (
  [Id] text NOT NULL
, [CustomerAcceptanceId] text NOT NULL
, [NetworkTransactionId] text NOT NULL
, [Reason] text NOT NULL
, [State] text NOT NULL
, [Type] text NOT NULL
, [Verified] bigint NULL
, [Verify] bigint NULL
, CONSTRAINT [sqlite_autoindex_CardMandate_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_CardMandate_0_0] FOREIGN KEY ([CustomerAcceptanceId]) REFERENCES [CustomerAcceptanceMandate] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [CcRef] (
  [Id] text NOT NULL
, [CardId] text NOT NULL
, [MandateId] text NOT NULL
, [SecondToken] text NOT NULL
, [Token] text NOT NULL
, CONSTRAINT [sqlite_autoindex_CcRef_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_CcRef_0_0] FOREIGN KEY ([MandateId]) REFERENCES [Mandate] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_CcRef_1_0] FOREIGN KEY ([CardId]) REFERENCES [CcRefCard] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [CcRefCard] (
  [Id] text NOT NULL
, [Brand] text NOT NULL
, [ExpiryMonth] text NULL
, [ExpiryYear] text NULL
, [Last4] text NOT NULL
, CONSTRAINT [sqlite_autoindex_CcRefCard_1] PRIMARY KEY ([Id])
);
CREATE TABLE [Contacts] (
  [Id] text NOT NULL
, [AccountId] text NOT NULL
, [AddressId] text NOT NULL
, [CreatedById] text NOT NULL
, [CreatedTime] text NULL
, [CustomFieldsId] text NOT NULL
, [CustomObjectsId] text NOT NULL
, [Email] text NOT NULL
, [Fax] text NOT NULL
, [FirstName] text NOT NULL
, [HomePhone] text NOT NULL
, [LastName] text NOT NULL
, [MobilePhone] text NOT NULL
, [Nickname] text NOT NULL
, [OtherPhone] text NOT NULL
, [OtherPhoneType] text NOT NULL
, [TaxRegion] text NOT NULL
, [UpdatedById] text NOT NULL
, [UpdatedTime] text NULL
, [WorkEmail] text NOT NULL
, [WorkPhone] text NOT NULL
, CONSTRAINT [sqlite_autoindex_Contacts_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_Contacts_0_0] FOREIGN KEY ([CustomObjectsId]) REFERENCES [CustomObjects] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Contacts_1_0] FOREIGN KEY ([CustomFieldsId]) REFERENCES [CustomFields] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Contacts_2_0] FOREIGN KEY ([AddressId]) REFERENCES [Address] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [CreditMemoAppliedTo] (
  [Id] text NOT NULL
, [Amount] text NULL
, [BillingDocumentId1] text NOT NULL
, [BillingDocumentId] text NOT NULL
, [BillingDocumentType] text NOT NULL
, CONSTRAINT [sqlite_autoindex_CreditMemoAppliedTo_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_CreditMemoAppliedTo_0_0] FOREIGN KEY ([BillingDocumentId1]) REFERENCES [BillingDocuments] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [CreditMemoItems] (
  [Id] text NOT NULL
, [AccountingCode] text NOT NULL
, [AccountsReceivableAccount] text NOT NULL
, [Amount] text NULL
, [AppliedToItemId] text NOT NULL
, [CreatedById] text NOT NULL
, [CreatedTime] text NULL
, [CreditMemoId1] text NOT NULL
, [CreditMemoId] text NOT NULL
, [CustomFieldsId] text NOT NULL
, [CustomObjectsId] text NOT NULL
, [DeferredRevenueAccount] text NOT NULL
, [Description] text NOT NULL
, [DiscountItem] bigint NULL
, [DocumentItemDate] text NULL
, [InvoiceItemId] text NOT NULL
, [Name] text NOT NULL
, [OnAccountAccount] text NOT NULL
, [PriceId] text NOT NULL
, [PurchaseOrderNumber] text NOT NULL
, [Quantity] text NULL
, [RecognizedRevenueAccount] text NOT NULL
, [RemainingBalance] text NULL
, [RevenueRecognitionRuleName] text NOT NULL
, [ServiceEnd] text NOT NULL
, [ServiceStart] text NOT NULL
, [Sku] text NOT NULL
, [SubscriptionId1] text NOT NULL
, [SubscriptionId] text NOT NULL
, [SubscriptionItemId1] text NOT NULL
, [SubscriptionItemId] text NOT NULL
, [Subtotal] text NULL
, [Tax] text NULL
, [TaxCode] text NOT NULL
, [TaxInclusive] bigint NULL
, [UnitAmount] text NULL
, [UnitOfMeasure] text NOT NULL
, [UpdatedById] text NOT NULL
, [UpdatedTime] text NULL
, CONSTRAINT [sqlite_autoindex_CreditMemoItems_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_CreditMemoItems_0_0] FOREIGN KEY ([SubscriptionId1]) REFERENCES [Subscriptions] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_CreditMemoItems_1_0] FOREIGN KEY ([SubscriptionItemId1]) REFERENCES [SubscriptionItems] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_CreditMemoItems_2_0] FOREIGN KEY ([CustomObjectsId]) REFERENCES [CustomObjects] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_CreditMemoItems_3_0] FOREIGN KEY ([CustomFieldsId]) REFERENCES [CustomFields] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_CreditMemoItems_4_0] FOREIGN KEY ([CreditMemoId1]) REFERENCES [CreditMemos] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [CreditMemos] (
  [Id] text NOT NULL
, [AccountId1] text NOT NULL
, [AccountId] text NOT NULL
, [AccountNumber] text NOT NULL
, [AmountRefunded] text NULL
, [Balance] text NULL
, [BillToId1] text NOT NULL
, [BillToId] text NOT NULL
, [CreatedById] text NOT NULL
, [CreatedTime] text NULL
, [CreditMemoNumber] text NOT NULL
, [Currency] text NOT NULL
, [CustomFieldsId] text NOT NULL
, [CustomObjectsId] text NOT NULL
, [Description] text NOT NULL
, [DocumentDate] text NULL
, [ExcludeFromAutoApplyRules] bigint NULL
, [InvoiceId] text NOT NULL
, [PostedById] text NOT NULL
, [ReasonCode] text NOT NULL
, [RemainingBalance] text NULL
, [State] text NOT NULL
, [StateTransitionsId] text NOT NULL
, [Subtotal] text NULL
, [Tax] text NULL
, [Total] text NULL
, [TransferToAccounting] bigint NULL
, [UpdatedById] text NOT NULL
, [UpdatedTime] text NULL
, [ArTransactionsId] text NULL
, [CreditMemoId] text NULL
, CONSTRAINT [sqlite_autoindex_CreditMemos_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_CreditMemos_0_0] FOREIGN KEY ([StateTransitionsId]) REFERENCES [StateTransitions] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_CreditMemos_1_0] FOREIGN KEY ([CustomObjectsId]) REFERENCES [CustomObjects] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_CreditMemos_2_0] FOREIGN KEY ([CustomFieldsId]) REFERENCES [CustomFields] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_CreditMemos_3_0] FOREIGN KEY ([CreditMemoId]) REFERENCES [CreditMemos] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
, CONSTRAINT [FK_CreditMemos_4_0] FOREIGN KEY ([BillToId1]) REFERENCES [Contacts] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_CreditMemos_5_0] FOREIGN KEY ([ArTransactionsId]) REFERENCES [ArTransactions] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
, CONSTRAINT [FK_CreditMemos_6_0] FOREIGN KEY ([AccountId1]) REFERENCES [Accounts] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [CustomerAcceptanceMandate] (
  [Id] text NOT NULL
, [Date] text NULL
, CONSTRAINT [sqlite_autoindex_CustomerAcceptanceMandate_1] PRIMARY KEY ([Id])
);
CREATE TABLE [CustomFields] (
  [Id] text NOT NULL
, CONSTRAINT [sqlite_autoindex_CustomFields_1] PRIMARY KEY ([Id])
);
CREATE TABLE [CustomObjects] (
  [Id] text NOT NULL
, CONSTRAINT [sqlite_autoindex_CustomObjects_1] PRIMARY KEY ([Id])
);
CREATE TABLE [DebitMemoItems] (
  [Id] text NOT NULL
, [AccountingCode] text NOT NULL
, [AccountsReceivableAccount] text NOT NULL
, [Amount] text NULL
, [AppliedToItemId] text NOT NULL
, [CreatedById] text NOT NULL
, [CreatedTime] text NULL
, [CustomFieldsId] text NOT NULL
, [CustomObjectsId] text NOT NULL
, [DebitMemoId1] text NOT NULL
, [DebitMemoId] text NOT NULL
, [DeferredRevenueAccount] text NOT NULL
, [Description] text NOT NULL
, [DiscountItem] bigint NULL
, [DocumentItemDate] text NULL
, [InvoiceItemId] text NOT NULL
, [Name] text NOT NULL
, [OnAccountAccount] text NOT NULL
, [PriceId] text NOT NULL
, [PurchaseOrderNumber] text NOT NULL
, [Quantity] text NULL
, [RecognizedRevenueAccount] text NOT NULL
, [RemainingBalance] text NULL
, [RevenueRecognitionRuleName] text NOT NULL
, [ServiceEnd] text NOT NULL
, [ServiceStart] text NOT NULL
, [Sku] text NOT NULL
, [SubscriptionId1] text NOT NULL
, [SubscriptionId] text NOT NULL
, [SubscriptionItemId1] text NOT NULL
, [SubscriptionItemId] text NOT NULL
, [Subtotal] text NULL
, [Tax] text NULL
, [TaxCode] text NOT NULL
, [TaxInclusive] bigint NULL
, [UnitAmount] text NULL
, [UnitOfMeasure] text NOT NULL
, [UpdatedById] text NOT NULL
, [UpdatedTime] text NULL
, CONSTRAINT [sqlite_autoindex_DebitMemoItems_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_DebitMemoItems_0_0] FOREIGN KEY ([SubscriptionId1]) REFERENCES [Subscriptions] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_DebitMemoItems_1_0] FOREIGN KEY ([SubscriptionItemId1]) REFERENCES [SubscriptionItems] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_DebitMemoItems_2_0] FOREIGN KEY ([DebitMemoId1]) REFERENCES [DebitMemos] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_DebitMemoItems_3_0] FOREIGN KEY ([CustomObjectsId]) REFERENCES [CustomObjects] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_DebitMemoItems_4_0] FOREIGN KEY ([CustomFieldsId]) REFERENCES [CustomFields] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [DebitMemos] (
  [Id] text NOT NULL
, [AccountId1] text NOT NULL
, [AccountId] text NOT NULL
, [AccountNumber] text NOT NULL
, [AmountPaid] text NULL
, [AmountRefunded] text NULL
, [Balance] text NULL
, [BillingDocumentSettingsId] text NOT NULL
, [BillToId1] text NOT NULL
, [BillToId] text NOT NULL
, [CreatedById] text NOT NULL
, [CreatedTime] text NULL
, [Currency] text NOT NULL
, [CustomFieldsId] text NOT NULL
, [CustomObjectsId] text NOT NULL
, [DebitMemoNumber] text NOT NULL
, [Description] text NOT NULL
, [DocumentDate] text NULL
, [DueDate] text NULL
, [ExcludeFromAutoApplyRules] bigint NULL
, [InvoiceId] text NOT NULL
, [Paid] bigint NULL
, [PastDue] bigint NULL
, [Pay] bigint NULL
, [PaymentTerms] text NOT NULL
, [PostedById] text NOT NULL
, [ReasonCode] text NOT NULL
, [RemainingBalance] text NULL
, [State] text NOT NULL
, [StateTransitionsId] text NOT NULL
, [Subtotal] text NULL
, [Tax] text NULL
, [Total] text NULL
, [TransferToAccounting] bigint NULL
, [UpdatedById] text NOT NULL
, [UpdatedTime] text NULL
, CONSTRAINT [sqlite_autoindex_DebitMemos_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_DebitMemos_0_0] FOREIGN KEY ([StateTransitionsId]) REFERENCES [StateTransitions] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_DebitMemos_1_0] FOREIGN KEY ([CustomObjectsId]) REFERENCES [CustomObjects] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_DebitMemos_2_0] FOREIGN KEY ([CustomFieldsId]) REFERENCES [CustomFields] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_DebitMemos_3_0] FOREIGN KEY ([BillToId1]) REFERENCES [Contacts] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_DebitMemos_4_0] FOREIGN KEY ([BillingDocumentSettingsId]) REFERENCES [BillingDocumentSettings] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_DebitMemos_5_0] FOREIGN KEY ([AccountId1]) REFERENCES [Accounts] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [Detail] (
  [Id] text NOT NULL
, CONSTRAINT [sqlite_autoindex_Detail_1] PRIMARY KEY ([Id])
);
CREATE TABLE [Drawdown] (
  [Id] text NOT NULL
, [ConversionRate] text NULL
, [UnitOfMeasure] text NOT NULL
, CONSTRAINT [sqlite_autoindex_Drawdown_1] PRIMARY KEY ([Id])
);
CREATE TABLE [GatewayOptions] (
  [Id] text NOT NULL
, CONSTRAINT [sqlite_autoindex_GatewayOptions_1] PRIMARY KEY ([Id])
);
CREATE TABLE [GatewayStateTransitions] (
  [Id] text NOT NULL
, [MarkedForSubmissionTime] text NULL
, [SettledTime] text NULL
, [SubmittedTime] text NULL
, CONSTRAINT [sqlite_autoindex_GatewayStateTransitions_1] PRIMARY KEY ([Id])
);
CREATE TABLE [GetCardList] (
  [Id] text NOT NULL
, [Brand] text NOT NULL
, [ExpiryMonth] text NULL
, [ExpiryYear] text NULL
, [Last4] text NOT NULL
, [MandateId] text NOT NULL
, CONSTRAINT [sqlite_autoindex_GetCardList_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_GetCardList_0_0] FOREIGN KEY ([MandateId]) REFERENCES [Mandate] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [GooglePay] (
  [Id] text NOT NULL
, [CardId] text NOT NULL
, [Token] text NOT NULL
, CONSTRAINT [sqlite_autoindex_GooglePay_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_GooglePay_0_0] FOREIGN KEY ([CardId]) REFERENCES [Card] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [InvoiceItems] (
  [Id] text NOT NULL
, [AccountingCode] text NOT NULL
, [AccountsReceivableAccount] text NOT NULL
, [Amount] text NULL
, [AppliedToItemId] text NOT NULL
, [BookingReference] text NOT NULL
, [CreatedById] text NOT NULL
, [CreatedTime] text NULL
, [CustomFieldsId] text NOT NULL
, [CustomObjectsId] text NOT NULL
, [DeferredRevenueAccount] text NOT NULL
, [Description] text NOT NULL
, [DiscountItem] bigint NULL
, [DocumentItemDate] text NULL
, [InvoiceId1] text NOT NULL
, [InvoiceId] text NOT NULL
, [LineItemId] text NOT NULL
, [Name] text NOT NULL
, [PriceId] text NOT NULL
, [PurchaseOrderNumber] text NOT NULL
, [Quantity] text NULL
, [RecognizedRevenueAccount] text NOT NULL
, [RemainingBalance] text NULL
, [RevenueRecognitionRuleName] text NOT NULL
, [ServiceEnd] text NOT NULL
, [ServiceStart] text NOT NULL
, [Sku] text NOT NULL
, [SubscriptionId1] text NOT NULL
, [SubscriptionId] text NOT NULL
, [SubscriptionItemId1] text NOT NULL
, [SubscriptionItemId] text NOT NULL
, [Tax] text NULL
, [TaxCode] text NOT NULL
, [TaxInclusive] bigint NULL
, [UnitAmount] text NULL
, [UnitOfMeasure] text NOT NULL
, [UpdatedById] text NOT NULL
, [UpdatedTime] text NULL
, CONSTRAINT [sqlite_autoindex_InvoiceItems_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_InvoiceItems_0_0] FOREIGN KEY ([SubscriptionId1]) REFERENCES [Subscriptions] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_InvoiceItems_1_0] FOREIGN KEY ([SubscriptionItemId1]) REFERENCES [SubscriptionItems] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_InvoiceItems_2_0] FOREIGN KEY ([LineItemId]) REFERENCES [OrderLineItems] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_InvoiceItems_3_0] FOREIGN KEY ([InvoiceId1]) REFERENCES [Invoices] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_InvoiceItems_4_0] FOREIGN KEY ([CustomObjectsId]) REFERENCES [CustomObjects] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_InvoiceItems_5_0] FOREIGN KEY ([CustomFieldsId]) REFERENCES [CustomFields] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [Invoices] (
  [Id] text NOT NULL
, [AccountId1] text NOT NULL
, [AccountId] text NOT NULL
, [AccountNumber] text NOT NULL
, [Balance] text NULL
, [BillingDocumentSettingsId] text NOT NULL
, [BillToId1] text NOT NULL
, [BillToId] text NOT NULL
, [CreatedById] text NOT NULL
, [CreatedTime] text NULL
, [Currency] text NOT NULL
, [CustomFieldsId] text NOT NULL
, [CustomObjectsId] text NOT NULL
, [Description] text NOT NULL
, [DocumentDate] text NULL
, [DueDate] text NULL
, [InvoiceNumber] text NOT NULL
, [Paid] bigint NULL
, [PastDue] bigint NULL
, [Pay] bigint NULL
, [PaymentTerms] text NOT NULL
, [PostedById] text NOT NULL
, [RemainingBalance] text NULL
, [SoldToId1] text NOT NULL
, [SoldToId] text NOT NULL
, [State] text NOT NULL
, [StateTransitionsId] text NOT NULL
, [Subtotal] text NULL
, [Tax] text NULL
, [Total] text NULL
, [TransferToAccounting] bigint NULL
, [UpdatedById] text NOT NULL
, [UpdatedTime] text NULL
, [ArTransactionsId] text NULL
, CONSTRAINT [sqlite_autoindex_Invoices_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_Invoices_0_0] FOREIGN KEY ([StateTransitionsId]) REFERENCES [StateTransitions] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Invoices_1_0] FOREIGN KEY ([CustomObjectsId]) REFERENCES [CustomObjects] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Invoices_2_0] FOREIGN KEY ([CustomFieldsId]) REFERENCES [CustomFields] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Invoices_3_0] FOREIGN KEY ([SoldToId1]) REFERENCES [Contacts] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Invoices_4_0] FOREIGN KEY ([BillToId1]) REFERENCES [Contacts] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Invoices_5_0] FOREIGN KEY ([BillingDocumentSettingsId]) REFERENCES [BillingDocumentSettings] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Invoices_6_0] FOREIGN KEY ([ArTransactionsId]) REFERENCES [ArTransactions] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
, CONSTRAINT [FK_Invoices_7_0] FOREIGN KEY ([AccountId1]) REFERENCES [Accounts] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [ItemTier] (
  [Id] text NOT NULL
, [Amount] text NULL
, [UnitAmount] text NULL
, [UpTo] text NULL
, [SubscriptionItemId] text NULL
, CONSTRAINT [sqlite_autoindex_ItemTier_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_ItemTier_0_0] FOREIGN KEY ([SubscriptionItemId]) REFERENCES [SubscriptionItems] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
);
CREATE TABLE [Mandate] (
  [Id] text NOT NULL
, [Reason] text NOT NULL
, [State] text NOT NULL
, CONSTRAINT [sqlite_autoindex_Mandate_1] PRIMARY KEY ([Id])
);
CREATE TABLE [Money] (
  [Id] text NOT NULL
, CONSTRAINT [sqlite_autoindex_Money_1] PRIMARY KEY ([Id])
);
CREATE TABLE [NzBecsDebit] (
  [Id] text NOT NULL
, [AccountNumber] text NOT NULL
, [BankCode] text NOT NULL
, [BranchCode] text NOT NULL
, [MandateId] text NOT NULL
, CONSTRAINT [sqlite_autoindex_NzBecsDebit_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_NzBecsDebit_0_0] FOREIGN KEY ([MandateId]) REFERENCES [Mandate] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [Order] (
  [Id] text NOT NULL
, [AccountId1] text NOT NULL
, [AccountId] text NOT NULL
, [Category] text NOT NULL
, [CreatedById] text NOT NULL
, [CreatedTime] text NULL
, [CustomFieldsId] text NOT NULL
, [CustomObjectsId] text NOT NULL
, [Description] text NOT NULL
, [OrderDate] text NULL
, [OrderNumber] text NOT NULL
, [State] text NOT NULL
, [UpdatedById] text NOT NULL
, [UpdatedTime] text NULL
, CONSTRAINT [sqlite_autoindex_Order_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_Order_0_0] FOREIGN KEY ([CustomObjectsId]) REFERENCES [CustomObjects] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Order_1_0] FOREIGN KEY ([CustomFieldsId]) REFERENCES [CustomFields] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Order_2_0] FOREIGN KEY ([AccountId1]) REFERENCES [Accounts] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [OrderLineItemRevenue] (
  [Id] text NOT NULL
, [AdjustmentRevenueAccount] text NOT NULL
, [ContractRecognizedRevenueAccount] text NOT NULL
, [DeferredRevenueAccount] text NOT NULL
, [ExcludeItemBillingFromRevenueAccounting] bigint NULL
, [ExcludeItemBookingFromRevenueAccounting] bigint NULL
, [RecognizedRevenueAccount] text NOT NULL
, [RevenueRecognitionRuleName] text NOT NULL
, CONSTRAINT [sqlite_autoindex_OrderLineItemRevenue_1] PRIMARY KEY ([Id])
);
CREATE TABLE [OrderLineItems] (
  [Id] text NOT NULL
, [AccountingCode] text NOT NULL
, [AdjustmentLiabilityAccount] text NOT NULL
, [BillingRule] text NOT NULL
, [Category] text NOT NULL
, [ContractAssetAccount] text NOT NULL
, [ContractLiabilityAccount] text NOT NULL
, [CreatedById] text NOT NULL
, [CreatedTime] text NULL
, [CustomFieldsId] text NOT NULL
, [CustomObjectsId] text NOT NULL
, [Description] text NOT NULL
, [DiscountPercent] text NULL
, [DiscountTotal] text NULL
, [DiscountUnitAmount] text NULL
, [EndDate] text NULL
, [ItemNumber] text NOT NULL
, [ListPrice] text NULL
, [ListUnitPrice] text NULL
, [Name] text NOT NULL
, [OrderId] text NOT NULL
, [OriginalOrderDate] text NULL
, [OriginalOrderId] text NOT NULL
, [OriginalOrderLineItemId] text NOT NULL
, [OriginalOrderLineItemNumber] text NOT NULL
, [OriginalOrderNumber] text NOT NULL
, [OriginalSoldToId] text NOT NULL
, [PriceId] text NOT NULL
, [ProductCode] text NOT NULL
, [PurchaseOrderNumber] text NOT NULL
, [Quantity] text NULL
, [QuantityAvailableForReturn] text NULL
, [QuantityFulfilled] text NULL
, [QuantityPendingFulfillment] text NULL
, [RelatedSubscriptionNumber] text NOT NULL
, [RequiresFulfillment] bigint NULL
, [RevenueId] text NOT NULL
, [SoldToId] text NOT NULL
, [StartDate] text NULL
, [State] text NOT NULL
, [Subtotal] text NULL
, [TargetDate] text NULL
, [TaxCode] text NOT NULL
, [TaxInclusive] bigint NULL
, [Total] text NULL
, [Type] text NOT NULL
, [UnbilledReceivablesAccount] text NOT NULL
, [UnitAmount] text NULL
, [UnitOfMeasure] text NOT NULL
, [UpdatedById] text NOT NULL
, [UpdatedTime] text NULL
, [OrderId1] text NULL
, CONSTRAINT [sqlite_autoindex_OrderLineItems_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_OrderLineItems_0_0] FOREIGN KEY ([OrderId1]) REFERENCES [Order] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
, CONSTRAINT [FK_OrderLineItems_1_0] FOREIGN KEY ([RevenueId]) REFERENCES [OrderLineItemRevenue] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_OrderLineItems_2_0] FOREIGN KEY ([CustomObjectsId]) REFERENCES [CustomObjects] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_OrderLineItems_3_0] FOREIGN KEY ([CustomFieldsId]) REFERENCES [CustomFields] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [Overage] (
  [Id] text NOT NULL
, [ApplyAtEndOfSmoothingPeriod] bigint NULL
, [CreditUnusedUnits] bigint NULL
, [IncludedUnits] text NULL
, [IntervalCount] bigint NULL
, [Type] text NOT NULL
, CONSTRAINT [sqlite_autoindex_Overage_1] PRIMARY KEY ([Id])
);
CREATE TABLE [PadDebit] (
  [Id] text NOT NULL
, [AccountNumber] text NOT NULL
, [BankCode] text NOT NULL
, [BranchCode] text NOT NULL
, [MandateId] text NOT NULL
, CONSTRAINT [sqlite_autoindex_PadDebit_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_PadDebit_0_0] FOREIGN KEY ([MandateId]) REFERENCES [Mandate] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [PaymentMethods] (
  [Id] text NOT NULL
, [AccountId1] text NOT NULL
, [AccountId] text NOT NULL
, [AchDebitId] text NOT NULL
, [ApplePayId] text NOT NULL
, [AuBecsDebitId] text NOT NULL
, [AutoGenerated] bigint NULL
, [AutogiroDebitId] text NOT NULL
, [BacsDebitId] text NOT NULL
, [BankIdentificationNumber] text NOT NULL
, [BetalingsDebitId] text NOT NULL
, [BillingDetailsId] text NOT NULL
, [CardId] text NOT NULL
, [CcRefId] text NOT NULL
, [CreatedById] text NOT NULL
, [CreatedTime] text NULL
, [CustomFieldsId] text NOT NULL
, [CustomObjectsId] text NOT NULL
, [CustomType] text NOT NULL
, [DeviceSessionId] text NOT NULL
, [ExistingMandate] bigint NULL
, [GooglePayId] text NOT NULL
, [IpAddress] text NOT NULL
, [LastFailedSaleTransactionTime] text NULL
, [LastTransactionStatus] text NOT NULL
, [LastTransactionTime] text NULL
, [MaximumPaymentAttempts] text NULL
, [NumberOfConsecutiveFailures] bigint NULL
, [NzBecsDebitId] text NOT NULL
, [PadDebitId] text NOT NULL
, [PaymentRetryInterval] bigint NULL
, [PaypalAdaptiveId] text NOT NULL
, [PaypalExpressId] text NOT NULL
, [PaypalExpressNativeId] text NOT NULL
, [SepaDebitId] text NOT NULL
, [State] text NOT NULL
, [TotalNumberOfErrorPayments] bigint NULL
, [TotalNumberOfProcessedPayments] bigint NULL
, [Type] text NOT NULL
, [UpdatedById] text NOT NULL
, [UpdatedTime] text NULL
, [UseDefaultRetryRule] bigint NULL
, CONSTRAINT [sqlite_autoindex_PaymentMethods_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_PaymentMethods_0_0] FOREIGN KEY ([SepaDebitId]) REFERENCES [SepaDebit] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_PaymentMethods_1_0] FOREIGN KEY ([PaypalExpressId]) REFERENCES [PaypalExpress] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_PaymentMethods_2_0] FOREIGN KEY ([PaypalExpressNativeId]) REFERENCES [PaypalExpressNative] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_PaymentMethods_3_0] FOREIGN KEY ([PaypalAdaptiveId]) REFERENCES [PaypalAdaptive] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_PaymentMethods_4_0] FOREIGN KEY ([PadDebitId]) REFERENCES [PadDebit] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_PaymentMethods_5_0] FOREIGN KEY ([NzBecsDebitId]) REFERENCES [NzBecsDebit] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_PaymentMethods_6_0] FOREIGN KEY ([GooglePayId]) REFERENCES [GooglePay] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_PaymentMethods_7_0] FOREIGN KEY ([CardId]) REFERENCES [GetCardList] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_PaymentMethods_8_0] FOREIGN KEY ([CustomObjectsId]) REFERENCES [CustomObjects] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_PaymentMethods_9_0] FOREIGN KEY ([CustomFieldsId]) REFERENCES [CustomFields] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_PaymentMethods_10_0] FOREIGN KEY ([CcRefId]) REFERENCES [CcRef] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_PaymentMethods_11_0] FOREIGN KEY ([BillingDetailsId]) REFERENCES [BillingDetails] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_PaymentMethods_12_0] FOREIGN KEY ([BetalingsDebitId]) REFERENCES [BetalingsDebit] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_PaymentMethods_13_0] FOREIGN KEY ([BacsDebitId]) REFERENCES [BacsDebit] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_PaymentMethods_14_0] FOREIGN KEY ([AutogiroDebitId]) REFERENCES [AutogiroDebit] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_PaymentMethods_15_0] FOREIGN KEY ([AuBecsDebitId]) REFERENCES [AuBecsDebit] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_PaymentMethods_16_0] FOREIGN KEY ([ApplePayId]) REFERENCES [ApplePay] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_PaymentMethods_17_0] FOREIGN KEY ([AchDebitId]) REFERENCES [AchDebit] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_PaymentMethods_18_0] FOREIGN KEY ([AccountId1]) REFERENCES [Accounts] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [PaymentOption] (
  [Id] text NOT NULL
, [DetailId] text NOT NULL
, [Type] bigint NULL
, [PaymentScheduleId] text NULL
, CONSTRAINT [sqlite_autoindex_PaymentOption_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_PaymentOption_0_0] FOREIGN KEY ([PaymentScheduleId]) REFERENCES [PaymentSchedule] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
, CONSTRAINT [FK_PaymentOption_1_0] FOREIGN KEY ([DetailId]) REFERENCES [Detail] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [Payments] (
  [Id] text NOT NULL
, [AccountId1] text NOT NULL
, [AccountId] text NOT NULL
, [AccountNumber] text NOT NULL
, [Amount] text NULL
, [AmountApplied] text NULL
, [AmountRefunded] text NULL
, [AuthorizationId] text NOT NULL
, [CreatedById] text NOT NULL
, [CreatedTime] text NULL
, [Currency] text NOT NULL
, [CustomFieldsId] text NOT NULL
, [CustomObjectsId] text NOT NULL
, [Description] text NOT NULL
, [External] bigint NULL
, [GatewayId] text NOT NULL
, [GatewayOptionsId] text NOT NULL
, [GatewayOrderId] text NOT NULL
, [GatewayReconciliationReason] text NOT NULL
, [GatewayReconciliationStatus] text NOT NULL
, [GatewayResponse] text NOT NULL
, [GatewayResponseCode] text NOT NULL
, [GatewayState] text NOT NULL
, [GatewayStateTransitionsId] text NOT NULL
, [PaymentDate] text NULL
, [PaymentMethodId1] text NOT NULL
, [PaymentMethodId] text NOT NULL
, [PaymentNumber] text NOT NULL
, [PayoutId] text NOT NULL
, [ReferenceId] text NOT NULL
, [RemainingBalance] text NULL
, [SecondReferenceId] text NOT NULL
, [State] text NOT NULL
, [StatementDescriptor] text NOT NULL
, [StatementDescriptorPhone] text NOT NULL
, [StateTransitionsId] text NOT NULL
, [UpdatedById] text NOT NULL
, [UpdatedTime] text NULL
, [PaymentTransactionsId] text NULL
, CONSTRAINT [sqlite_autoindex_Payments_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_Payments_0_0] FOREIGN KEY ([PaymentTransactionsId]) REFERENCES [PaymentTransactions] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
, CONSTRAINT [FK_Payments_1_0] FOREIGN KEY ([StateTransitionsId]) REFERENCES [PaymentStateTransitions] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Payments_2_0] FOREIGN KEY ([PaymentMethodId1]) REFERENCES [PaymentMethods] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Payments_3_0] FOREIGN KEY ([GatewayStateTransitionsId]) REFERENCES [GatewayStateTransitions] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Payments_4_0] FOREIGN KEY ([GatewayOptionsId]) REFERENCES [GatewayOptions] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Payments_5_0] FOREIGN KEY ([CustomObjectsId]) REFERENCES [CustomObjects] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Payments_6_0] FOREIGN KEY ([CustomFieldsId]) REFERENCES [CustomFields] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Payments_7_0] FOREIGN KEY ([AccountId1]) REFERENCES [Accounts] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [PaymentsAppliedTo] (
  [Id] text NOT NULL
, [Amount] text NULL
, [BillingDocumentId1] text NOT NULL
, [BillingDocumentId] text NOT NULL
, [BillingDocumentType] text NOT NULL
, [State] text NOT NULL
, [PaymentId] text NULL
, CONSTRAINT [sqlite_autoindex_PaymentsAppliedTo_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_PaymentsAppliedTo_0_0] FOREIGN KEY ([PaymentId]) REFERENCES [Payments] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
, CONSTRAINT [FK_PaymentsAppliedTo_1_0] FOREIGN KEY ([BillingDocumentId1]) REFERENCES [BillingDocuments] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [PaymentSchedule] (
  [Id] text NOT NULL
, [AccountId] text NOT NULL
, [AccountNumber] text NOT NULL
, [Amount] text NULL
, [BillingDocumentId] text NOT NULL
, [CreatedById] text NOT NULL
, [CreatedTime] text NULL
, [Currency] text NOT NULL
, [Custom] bigint NULL
, [CustomFieldsId] text NOT NULL
, [CustomObjectsId] text NOT NULL
, [Description] text NOT NULL
, [NextPaymentDate] text NULL
, [NumberOfPayments] bigint NULL
, [PaymentGatewayId] text NOT NULL
, [PaymentMethodId] text NOT NULL
, [PaymentScheduleNumber] text NOT NULL
, [Period] text NOT NULL
, [Prepayment] bigint NULL
, [RecentPaymentDate] text NULL
, [RunHour] bigint NULL
, [Standalone] bigint NULL
, [StartDate] text NULL
, [State] text NOT NULL
, [TotalAmount] text NULL
, [TotalPaymentsErrored] bigint NULL
, [TotalPaymentsProcessed] bigint NULL
, [UpdatedById] text NOT NULL
, [UpdatedTime] text NULL
, CONSTRAINT [sqlite_autoindex_PaymentSchedule_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_PaymentSchedule_0_0] FOREIGN KEY ([CustomObjectsId]) REFERENCES [CustomObjects] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_PaymentSchedule_1_0] FOREIGN KEY ([CustomFieldsId]) REFERENCES [CustomFields] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_PaymentSchedule_2_0] FOREIGN KEY ([BillingDocumentId]) REFERENCES [BillingDocuments] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [PaymentScheduleItemPayments] (
  [Id] text NOT NULL
, [PaymentScheduleItemId] text NULL
, CONSTRAINT [sqlite_autoindex_PaymentScheduleItemPayments_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_PaymentScheduleItemPayments_0_0] FOREIGN KEY ([PaymentScheduleItemId]) REFERENCES [PaymentScheduleItems] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
);
CREATE TABLE [PaymentScheduleItems] (
  [Id] text NOT NULL
, [AccountId] text NOT NULL
, [Amount] text NULL
, [Balance] text NULL
, [BillingDocumentId] text NOT NULL
, [CancellationReason] text NOT NULL
, [CreatedById] text NOT NULL
, [CreatedTime] text NULL
, [Currency] text NOT NULL
, [CustomFieldsId] text NOT NULL
, [CustomObjectsId] text NOT NULL
, [Description] text NOT NULL
, [ErrorMessage] text NOT NULL
, [PaymentId] text NOT NULL
, [PaymentGatewayId] text NOT NULL
, [PaymentMethodId] text NOT NULL
, [PaymentOptionId] text NOT NULL
, [PaymentScheduleId1] text NOT NULL
, [PaymentScheduleId] text NOT NULL
, [PaymentScheduleItemNumber] text NOT NULL
, [PaymentScheduleNumber] text NOT NULL
, [RunHour] bigint NULL
, [ScheduledDate] text NULL
, [Standalone] bigint NULL
, [State] text NOT NULL
, [UpdatedById] text NOT NULL
, [UpdatedTime] text NULL
, CONSTRAINT [sqlite_autoindex_PaymentScheduleItems_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_PaymentScheduleItems_0_0] FOREIGN KEY ([PaymentId]) REFERENCES [Payments] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_PaymentScheduleItems_1_0] FOREIGN KEY ([PaymentScheduleId1]) REFERENCES [PaymentSchedule] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_PaymentScheduleItems_2_0] FOREIGN KEY ([CustomObjectsId]) REFERENCES [CustomObjects] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_PaymentScheduleItems_3_0] FOREIGN KEY ([CustomFieldsId]) REFERENCES [CustomFields] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_PaymentScheduleItems_4_0] FOREIGN KEY ([BillingDocumentId]) REFERENCES [BillingDocuments] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [PaymentStateTransitions] (
  [Id] text NOT NULL
, [CanceledTime] text NULL
, CONSTRAINT [sqlite_autoindex_PaymentStateTransitions_1] PRIMARY KEY ([Id])
);
CREATE TABLE [PaymentTransactions] (
  [Id] text NOT NULL
, [Amount] text NOT NULL
, [PaymentNumber] text NOT NULL
, [StateId] text NOT NULL
, [ArTransactionsId] text NULL
, CONSTRAINT [sqlite_autoindex_PaymentTransactions_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_PaymentTransactions_0_0] FOREIGN KEY ([StateId]) REFERENCES [TransactionsState] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_PaymentTransactions_1_0] FOREIGN KEY ([ArTransactionsId]) REFERENCES [ArTransactions] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
);
CREATE TABLE [PaypalAdaptive] (
  [Id] text NOT NULL
, [Email] text NOT NULL
, [PreapprovalKey] text NOT NULL
, CONSTRAINT [sqlite_autoindex_PaypalAdaptive_1] PRIMARY KEY ([Id])
);
CREATE TABLE [PaypalExpress] (
  [Id] text NOT NULL
, [Baid] text NOT NULL
, [Email] text NOT NULL
, CONSTRAINT [sqlite_autoindex_PaypalExpress_1] PRIMARY KEY ([Id])
);
CREATE TABLE [PaypalExpressNative] (
  [Id] text NOT NULL
, [Baid] text NOT NULL
, [Email] text NOT NULL
, CONSTRAINT [sqlite_autoindex_PaypalExpressNative_1] PRIMARY KEY ([Id])
);
CREATE TABLE [Plan] (
  [Id] text NOT NULL
, [Active] bigint NULL
, [ActiveCurrencies] text NOT NULL
, [CreatedById] text NOT NULL
, [CreatedTime] text NULL
, [CustomFieldsId] text NOT NULL
, [CustomObjectsId] text NOT NULL
, [Description] text NOT NULL
, [EndDate] text NULL
, [Name] text NOT NULL
, [PlanNumber] text NOT NULL
, [ProductId1] text NOT NULL
, [ProductId] text NOT NULL
, [Sku] text NOT NULL
, [StartDate] text NULL
, [UpdatedById] text NOT NULL
, [UpdatedTime] text NULL
, CONSTRAINT [sqlite_autoindex_Plan_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_Plan_0_0] FOREIGN KEY ([ProductId1]) REFERENCES [Products] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Plan_1_0] FOREIGN KEY ([CustomObjectsId]) REFERENCES [CustomObjects] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Plan_2_0] FOREIGN KEY ([CustomFieldsId]) REFERENCES [CustomFields] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [PrepaidBalance] (
  [Id] text NOT NULL
, [EndDate] text NULL
, [PrepaidUOM] text NOT NULL
, [RemainingBalance] text NULL
, [StartDate] text NULL
, [TotalBalance] text NULL
, [SubscriptionId] text NULL
, CONSTRAINT [sqlite_autoindex_PrepaidBalance_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_PrepaidBalance_0_0] FOREIGN KEY ([SubscriptionId]) REFERENCES [Subscriptions] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
);
CREATE TABLE [PrepaidBalances] (
  [Id] text NOT NULL
, [SubscriptionId] text NULL
, CONSTRAINT [sqlite_autoindex_PrepaidBalances_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_PrepaidBalances_0_0] FOREIGN KEY ([SubscriptionId]) REFERENCES [Subscriptions] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
);
CREATE TABLE [PrepaidBalanceTransaction] (
  [Id] text NOT NULL
, [Quantity] text NULL
, [TransactionDate] text NOT NULL
, [Type] text NOT NULL
, [PrepaidBalanceId] text NULL
, [ValidityPeriodId] text NULL
, CONSTRAINT [sqlite_autoindex_PrepaidBalanceTransaction_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_PrepaidBalanceTransaction_0_0] FOREIGN KEY ([ValidityPeriodId]) REFERENCES [ValidityPeriod] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
, CONSTRAINT [FK_PrepaidBalanceTransaction_1_0] FOREIGN KEY ([PrepaidBalanceId]) REFERENCES [PrepaidBalance] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
);
CREATE TABLE [Prepayment] (
  [Id] text NOT NULL
, [CreditOption] text NOT NULL
, [Quantity] text NULL
, [TotalQuantity] text NULL
, [UnitOfMeasure] text NOT NULL
, [ValidityPeriod] text NOT NULL
, CONSTRAINT [sqlite_autoindex_Prepayment_1] PRIMARY KEY ([Id])
);
CREATE TABLE [Price] (
  [Id] text NOT NULL
, [AccountingCode] text NOT NULL
, [Active] bigint NULL
, [AmountsId] text NOT NULL
, [ApplyDiscountTo] text NOT NULL
, [ChargeModel] text NOT NULL
, [ChargeType] text NOT NULL
, [CreatedById] text NOT NULL
, [CreatedTime] text NULL
, [CustomFieldPerUnitRate] text NOT NULL
, [CustomFieldsId] text NOT NULL
, [CustomFieldTotalAmount] text NOT NULL
, [CustomObjectsId] text NOT NULL
, [DeferredRevenueAccountingCode] text NOT NULL
, [Description] text NOT NULL
, [DiscountAmountsId] text NOT NULL
, [DiscountLevel] text NOT NULL
, [DiscountPercent] text NULL
, [DrawdownId] text NOT NULL
, [MaxQuantity] text NULL
, [MinQuantity] text NULL
, [Name] text NOT NULL
, [OverageId] text NOT NULL
, [PlanId] text NOT NULL
, [PlanNumber] text NOT NULL
, [PrepaymentId] text NOT NULL
, [PriceBaseInterval] text NOT NULL
, [Quantity] text NULL
, [RecognizedRevenueAccountingCode] text NOT NULL
, [RecurringId] text NOT NULL
, [RevenueId] text NOT NULL
, [RevenueRecognitionRule] text NOT NULL
, [StackedDiscount] bigint NULL
, [StartEvent] text NOT NULL
, [Taxable] bigint NULL
, [TaxCode] text NOT NULL
, [TaxInclusive] bigint NULL
, [TiersMode] text NOT NULL
, [UnitAmountsId] text NOT NULL
, [UnitOfMeasure] text NOT NULL
, [UpdatedById] text NOT NULL
, [UpdatedTime] text NULL
, [PlanId1] text NULL
, CONSTRAINT [sqlite_autoindex_Price_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_Price_0_0] FOREIGN KEY ([RevenueId]) REFERENCES [Revenue] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Price_1_0] FOREIGN KEY ([RecurringId]) REFERENCES [Recurring] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Price_2_0] FOREIGN KEY ([PrepaymentId]) REFERENCES [Prepayment] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Price_3_0] FOREIGN KEY ([PlanId1]) REFERENCES [Plan] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
, CONSTRAINT [FK_Price_4_0] FOREIGN KEY ([OverageId]) REFERENCES [Overage] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Price_5_0] FOREIGN KEY ([DrawdownId]) REFERENCES [Drawdown] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Price_6_0] FOREIGN KEY ([CustomObjectsId]) REFERENCES [CustomObjects] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Price_7_0] FOREIGN KEY ([CustomFieldsId]) REFERENCES [CustomFields] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Price_8_0] FOREIGN KEY ([UnitAmountsId]) REFERENCES [Amounts] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Price_9_0] FOREIGN KEY ([DiscountAmountsId]) REFERENCES [Amounts] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Price_10_0] FOREIGN KEY ([AmountsId]) REFERENCES [Amounts] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [ProductPlan] (
  [Id] text NOT NULL
, [Active] bigint NULL
, [ActiveCurrencies] text NOT NULL
, [CreatedById] text NOT NULL
, [CreatedTime] text NULL
, [CustomFieldsId] text NOT NULL
, [CustomObjectsId] text NOT NULL
, [Description] text NOT NULL
, [EndDate] text NULL
, [Name] text NOT NULL
, [PlanNumber] text NOT NULL
, [ProductId1] text NOT NULL
, [ProductId] text NOT NULL
, [Sku] text NOT NULL
, [StartDate] text NULL
, [UpdatedById] text NOT NULL
, [UpdatedTime] text NULL
, CONSTRAINT [sqlite_autoindex_ProductPlan_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_ProductPlan_0_0] FOREIGN KEY ([ProductId1]) REFERENCES [Products] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_ProductPlan_1_0] FOREIGN KEY ([CustomObjectsId]) REFERENCES [CustomObjects] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_ProductPlan_2_0] FOREIGN KEY ([CustomFieldsId]) REFERENCES [CustomFields] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [ProductPrice] (
  [Id] text NOT NULL
, [AccountingCode] text NOT NULL
, [Active] bigint NULL
, [AmountsId] text NOT NULL
, [ApplyDiscountTo] text NOT NULL
, [ChargeModel] text NOT NULL
, [ChargeType] text NOT NULL
, [CreatedById] text NOT NULL
, [CreatedTime] text NULL
, [CustomFieldPerUnitRate] text NOT NULL
, [CustomFieldsId] text NOT NULL
, [CustomFieldTotalAmount] text NOT NULL
, [CustomObjectsId] text NOT NULL
, [DeferredRevenueAccountingCode] text NOT NULL
, [Description] text NOT NULL
, [DiscountAmountsId] text NOT NULL
, [DiscountLevel] text NOT NULL
, [DiscountPercent] text NULL
, [DrawdownId] text NOT NULL
, [MaxQuantity] text NULL
, [MinQuantity] text NULL
, [Name] text NOT NULL
, [OverageId] text NOT NULL
, [ProductPlanId] text NOT NULL
, [PlanNumber] text NOT NULL
, [PrepaymentId] text NOT NULL
, [PriceBaseInterval] text NOT NULL
, [Quantity] text NULL
, [RecognizedRevenueAccountingCode] text NOT NULL
, [RecurringId] text NOT NULL
, [RevenueId] text NOT NULL
, [RevenueRecognitionRule] text NOT NULL
, [StackedDiscount] bigint NULL
, [StartEvent] text NOT NULL
, [Taxable] bigint NULL
, [TaxCode] text NOT NULL
, [TaxInclusive] bigint NULL
, [TiersMode] text NOT NULL
, [UnitAmountsId] text NOT NULL
, [UnitOfMeasure] text NOT NULL
, [UpdatedById] text NOT NULL
, [UpdatedTime] text NULL
, [ProductPlanId1] text NULL
, CONSTRAINT [sqlite_autoindex_ProductPrice_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_ProductPrice_0_0] FOREIGN KEY ([RevenueId]) REFERENCES [Revenue] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_ProductPrice_1_0] FOREIGN KEY ([RecurringId]) REFERENCES [Recurring] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_ProductPrice_2_0] FOREIGN KEY ([ProductPlanId1]) REFERENCES [ProductPlan] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
, CONSTRAINT [FK_ProductPrice_3_0] FOREIGN KEY ([PrepaymentId]) REFERENCES [Prepayment] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_ProductPrice_4_0] FOREIGN KEY ([OverageId]) REFERENCES [Overage] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_ProductPrice_5_0] FOREIGN KEY ([DrawdownId]) REFERENCES [Drawdown] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_ProductPrice_6_0] FOREIGN KEY ([CustomObjectsId]) REFERENCES [CustomObjects] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_ProductPrice_7_0] FOREIGN KEY ([CustomFieldsId]) REFERENCES [CustomFields] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_ProductPrice_8_0] FOREIGN KEY ([UnitAmountsId]) REFERENCES [Amounts] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_ProductPrice_9_0] FOREIGN KEY ([DiscountAmountsId]) REFERENCES [Amounts] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_ProductPrice_10_0] FOREIGN KEY ([AmountsId]) REFERENCES [Amounts] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [Products] (
  [Id] text NOT NULL
, [Active] bigint NULL
, [CreatedById] text NOT NULL
, [CreatedTime] text NULL
, [CustomFieldsId] text NOT NULL
, [CustomObjectsId] text NOT NULL
, [Description] text NOT NULL
, [EndDate] text NULL
, [Name] text NOT NULL
, [Sku] text NOT NULL
, [StartDate] text NULL
, [Type] text NOT NULL
, [UpdatedById] text NOT NULL
, [UpdatedTime] text NULL
, CONSTRAINT [sqlite_autoindex_Products_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_Products_0_0] FOREIGN KEY ([CustomObjectsId]) REFERENCES [CustomObjects] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Products_1_0] FOREIGN KEY ([CustomFieldsId]) REFERENCES [CustomFields] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [ProductTier] (
  [Id] text NOT NULL
, [AmountsId] text NOT NULL
, [UnitAmountsId] text NOT NULL
, [UpTo] text NULL
, [ProductPriceId] text NULL
, CONSTRAINT [sqlite_autoindex_ProductTier_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_ProductTier_0_0] FOREIGN KEY ([ProductPriceId]) REFERENCES [ProductPrice] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
, CONSTRAINT [FK_ProductTier_1_0] FOREIGN KEY ([UnitAmountsId]) REFERENCES [Money] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_ProductTier_2_0] FOREIGN KEY ([AmountsId]) REFERENCES [Money] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [Recurring] (
  [Id] text NOT NULL
, [AlignmentBehavior] text NOT NULL
, [DurationInterval] text NOT NULL
, [DurationIntervalCount] bigint NULL
, [Formula] text NOT NULL
, [Interval] text NOT NULL
, [IntervalCount] bigint NULL
, [On] text NOT NULL
, [RatingGroup] text NOT NULL
, [RecurringOn] text NOT NULL
, [Timing] text NOT NULL
, [Usage] bigint NULL
, CONSTRAINT [sqlite_autoindex_Recurring_1] PRIMARY KEY ([Id])
);
CREATE TABLE [RefundAppliedToItem] (
  [Id] text NOT NULL
, [Amount] text NULL
, [CreditMemoItemId] text NOT NULL
, [TaxationItemId] text NOT NULL
, [RefundsAppliedToId] text NULL
, CONSTRAINT [sqlite_autoindex_RefundAppliedToItem_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_RefundAppliedToItem_0_0] FOREIGN KEY ([RefundsAppliedToId]) REFERENCES [RefundsAppliedTo] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
);
CREATE TABLE [Refunds] (
  [Id] text NOT NULL
, [AccountId1] text NOT NULL
, [AccountId] text NOT NULL
, [Amount] text NULL
, [BankAccountAccount] text NOT NULL
, [Comment] text NOT NULL
, [CreatedById] text NOT NULL
, [CreatedTime] text NULL
, [CreditMemoId] text NOT NULL
, [CustomFieldsId] text NOT NULL
, [CustomObjectsId] text NOT NULL
, [Description] text NOT NULL
, [External] bigint NULL
, [GatewayId] text NOT NULL
, [GatewayOptionsId] text NOT NULL
, [GatewayReconciliationReason] text NOT NULL
, [GatewayReconciliationStatus] text NOT NULL
, [GatewayResponse] text NOT NULL
, [GatewayResponseCode] text NOT NULL
, [GatewayState] text NOT NULL
, [OnAccountAccount] text NOT NULL
, [PaymentId] text NOT NULL
, [PaymentMethodId1] text NOT NULL
, [PaymentMethodId] text NOT NULL
, [PayoutId] text NOT NULL
, [ReasonCode] text NOT NULL
, [ReferenceId] text NOT NULL
, [RefundDate] text NULL
, [RefundMethodType] text NOT NULL
, [RefundNumber] text NOT NULL
, [SecondReferenceId] text NOT NULL
, [State] text NOT NULL
, [StatementDescriptor] text NOT NULL
, [StatementDescriptorPhone] text NOT NULL
, [StateTransitionsId] text NOT NULL
, [UnappliedPaymentAccount] text NOT NULL
, [UpdatedById] text NOT NULL
, [UpdatedTime] text NULL
, [RefundTransactionsId] text NULL
, CONSTRAINT [sqlite_autoindex_Refunds_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_Refunds_0_0] FOREIGN KEY ([RefundTransactionsId]) REFERENCES [RefundTransactions] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
, CONSTRAINT [FK_Refunds_1_0] FOREIGN KEY ([StateTransitionsId]) REFERENCES [RefundStateTransitions] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Refunds_2_0] FOREIGN KEY ([PaymentMethodId1]) REFERENCES [PaymentMethods] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Refunds_3_0] FOREIGN KEY ([GatewayOptionsId]) REFERENCES [GatewayOptions] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Refunds_4_0] FOREIGN KEY ([CustomObjectsId]) REFERENCES [CustomObjects] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Refunds_5_0] FOREIGN KEY ([CustomFieldsId]) REFERENCES [CustomFields] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Refunds_6_0] FOREIGN KEY ([CreditMemoId]) REFERENCES [CreditMemos] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Refunds_7_0] FOREIGN KEY ([AccountId1]) REFERENCES [Accounts] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [RefundsAppliedTo] (
  [Id] text NOT NULL
, [Amount] text NULL
, [BillingDocumentId1] text NOT NULL
, [BillingDocumentId] text NOT NULL
, [BillingDocumentType] text NOT NULL
, [PaymentId] text NOT NULL
, [RefundId] text NULL
, CONSTRAINT [sqlite_autoindex_RefundsAppliedTo_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_RefundsAppliedTo_0_0] FOREIGN KEY ([RefundId]) REFERENCES [Refunds] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
, CONSTRAINT [FK_RefundsAppliedTo_1_0] FOREIGN KEY ([PaymentId]) REFERENCES [Payments] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_RefundsAppliedTo_2_0] FOREIGN KEY ([BillingDocumentId1]) REFERENCES [BillingDocuments] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [RefundStateTransitions] (
  [Id] text NOT NULL
, [CanceledTime] text NULL
, [RefundedTime] text NULL
, CONSTRAINT [sqlite_autoindex_RefundStateTransitions_1] PRIMARY KEY ([Id])
);
CREATE TABLE [RefundTransactions] (
  [Id] text NOT NULL
, [InvoiceNumbers] text NOT NULL
, [RefundNumber] text NOT NULL
, [StateId] text NOT NULL
, [ArTransactionsId] text NULL
, CONSTRAINT [sqlite_autoindex_RefundTransactions_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_RefundTransactions_0_0] FOREIGN KEY ([StateId]) REFERENCES [TransactionsState] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_RefundTransactions_1_0] FOREIGN KEY ([ArTransactionsId]) REFERENCES [ArTransactions] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
);
CREATE TABLE [ResumeSubscription] (
  [Id] text NOT NULL
, [CustomFieldsId] text NOT NULL
, [ExtendTerm] bigint NULL
, [ResumeAt] text NOT NULL
, [ResumeDate] text NOT NULL
, CONSTRAINT [sqlite_autoindex_ResumeSubscription_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_ResumeSubscription_0_0] FOREIGN KEY ([CustomFieldsId]) REFERENCES [CustomFields] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [Revenue] (
  [Id] text NOT NULL
, [ExcludeItemBillingFromRevenueAccounting] bigint NULL
, [ExcludeItemBookingFromRevenueAccounting] bigint NULL
, CONSTRAINT [sqlite_autoindex_Revenue_1] PRIMARY KEY ([Id])
);
CREATE TABLE [SepaDebit] (
  [Id] text NOT NULL
, [BusinessIdentificationCode] text NOT NULL
, [IBAN] text NOT NULL
, [MandateId] text NOT NULL
, CONSTRAINT [sqlite_autoindex_SepaDebit_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_SepaDebit_0_0] FOREIGN KEY ([MandateId]) REFERENCES [Mandate] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [StateTransitions] (
  [Id] text NOT NULL
, [CanceledTime] text NOT NULL
, [PostedTime] text NOT NULL
, CONSTRAINT [sqlite_autoindex_StateTransitions_1] PRIMARY KEY ([Id])
);
CREATE TABLE [SubscriptionAddPlans] (
  [Id] text NOT NULL
, [CustomFieldsId] text NOT NULL
, [PlanId] text NOT NULL
, [UniqueToken] text NOT NULL
, CONSTRAINT [sqlite_autoindex_SubscriptionAddPlans_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_SubscriptionAddPlans_0_0] FOREIGN KEY ([CustomFieldsId]) REFERENCES [CustomFields] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [SubscriptionCancels] (
  [Id] text NOT NULL
, [CancelAt] text NOT NULL
, [CancelDate] text NULL
, CONSTRAINT [sqlite_autoindex_SubscriptionCancels_1] PRIMARY KEY ([Id])
);
CREATE TABLE [SubscriptionItems] (
  [Id] text NOT NULL
, [Active] bigint NULL
, [Amount] text NULL
, [ApplyDiscountTo] text NOT NULL
, [ChargedThroughDate] text NULL
, [ChargeModel] text NOT NULL
, [ChargeType] text NOT NULL
, [CreatedById] text NOT NULL
, [CreatedTime] text NULL
, [CustomFieldsId] text NOT NULL
, [CustomObjectsId] text NOT NULL
, [Description] text NOT NULL
, [DiscountAmount] text NULL
, [DiscountLevel] text NOT NULL
, [DiscountPercent] text NULL
, [EndDate] text NULL
, [Name] text NOT NULL
, [OverageId] text NOT NULL
, [PriceId1] text NOT NULL
, [PriceBaseInterval] text NOT NULL
, [PriceId] text NOT NULL
, [ProcessedThroughDate] text NULL
, [ProductId] text NOT NULL
, [Quantity] text NULL
, [RecurringId] text NOT NULL
, [StartDate] text NULL
, [StartEvent] text NOT NULL
, [State] text NOT NULL
, [SubscriptionItemNumber] text NOT NULL
, [SubscriptionPlanId1] text NOT NULL
, [SubscriptionPlanId] text NOT NULL
, [TaxCode] text NOT NULL
, [TaxInclusive] bigint NULL
, [TiersMode] text NOT NULL
, [UnitAmount] text NULL
, [UnitOfMeasure] text NOT NULL
, [UpdatedById] text NOT NULL
, [UpdatedTime] text NULL
, [SubscriptionAddPlanId] text NULL
, CONSTRAINT [sqlite_autoindex_SubscriptionItems_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_SubscriptionItems_0_0] FOREIGN KEY ([SubscriptionPlanId1]) REFERENCES [SubscriptionPlans] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_SubscriptionItems_1_0] FOREIGN KEY ([SubscriptionAddPlanId]) REFERENCES [SubscriptionAddPlans] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
, CONSTRAINT [FK_SubscriptionItems_2_0] FOREIGN KEY ([RecurringId]) REFERENCES [Recurring] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_SubscriptionItems_3_0] FOREIGN KEY ([PriceId1]) REFERENCES [Price] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_SubscriptionItems_4_0] FOREIGN KEY ([OverageId]) REFERENCES [Overage] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_SubscriptionItems_5_0] FOREIGN KEY ([CustomObjectsId]) REFERENCES [CustomObjects] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_SubscriptionItems_6_0] FOREIGN KEY ([CustomFieldsId]) REFERENCES [CustomFields] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [SubscriptionPauses] (
  [Id] text NOT NULL
, [CustomFieldsId] text NOT NULL
, [PauseAt] text NOT NULL
, [PauseDate] text NOT NULL
, [PauseInterval] text NOT NULL
, [PauseIntervalCount] text NULL
, [ResumeBehaviorId] text NOT NULL
, CONSTRAINT [sqlite_autoindex_SubscriptionPauses_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_SubscriptionPauses_0_0] FOREIGN KEY ([ResumeBehaviorId]) REFERENCES [ResumeSubscription] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_SubscriptionPauses_1_0] FOREIGN KEY ([CustomFieldsId]) REFERENCES [CustomFields] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [SubscriptionPlans] (
  [Id] text NOT NULL
, [CreatedById] text NOT NULL
, [CreatedTime] text NULL
, [CustomFieldsId] text NOT NULL
, [CustomObjectsId] text NOT NULL
, [Name] text NOT NULL
, [PlanId1] text NOT NULL
, [PlanId] text NOT NULL
, [ProductId1] text NOT NULL
, [ProductId] text NOT NULL
, [SubscriptionId1] text NOT NULL
, [SubscriptionId] text NOT NULL
, [UpdatedById] text NOT NULL
, [UpdatedTime] text NULL
, CONSTRAINT [sqlite_autoindex_SubscriptionPlans_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_SubscriptionPlans_0_0] FOREIGN KEY ([SubscriptionId1]) REFERENCES [Subscriptions] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_SubscriptionPlans_1_0] FOREIGN KEY ([ProductId1]) REFERENCES [Products] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_SubscriptionPlans_2_0] FOREIGN KEY ([PlanId1]) REFERENCES [Plan] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_SubscriptionPlans_3_0] FOREIGN KEY ([CustomObjectsId]) REFERENCES [CustomObjects] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_SubscriptionPlans_4_0] FOREIGN KEY ([CustomFieldsId]) REFERENCES [CustomFields] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [SubscriptionRemovePlans] (
  [Id] text NOT NULL
, [SubscriptionPlanId] text NOT NULL
, CONSTRAINT [sqlite_autoindex_SubscriptionRemovePlans_1] PRIMARY KEY ([Id])
);
CREATE TABLE [SubscriptionRenews] (
  [Id] text NOT NULL
, [TermsId] text NOT NULL
, CONSTRAINT [sqlite_autoindex_SubscriptionRenews_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_SubscriptionRenews_0_0] FOREIGN KEY ([TermsId]) REFERENCES [SubscriptionTerms] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [Subscriptions] (
  [Id] text NOT NULL
, [AccountId1] text NOT NULL
, [AccountId] text NOT NULL
, [AutoRenew] bigint NULL
, [BillingDocumentSettingsId] text NOT NULL
, [BillToId1] text NOT NULL
, [BillToId] text NOT NULL
, [CancelReason] text NOT NULL
, [ContractedMrr] text NOT NULL
, [ContractEffective] text NULL
, [CreatedById] text NOT NULL
, [CreatedTime] text NULL
, [Currency] text NOT NULL
, [CurrentTermId] text NOT NULL
, [CustomerAcceptance] text NULL
, [CustomFieldsId] text NOT NULL
, [CustomObjectsId] text NOT NULL
, [Description] text NOT NULL
, [EndDate] text NULL
, [InitialTermId] text NOT NULL
, [InvoiceOwnerAccountId1] text NOT NULL
, [InvoiceOwnerAccountId] text NOT NULL
, [InvoiceSeparately] bigint NULL
, [LastBookingDate] text NULL
, [LatestVersion] bigint NULL
, [OrderNumber] text NOT NULL
, [PaymentTerms] text NOT NULL
, [RenewalTermId] text NOT NULL
, [ServiceActivation] text NULL
, [SoldToId1] text NOT NULL
, [SoldToId] text NOT NULL
, [StartDate] text NULL
, [State] text NOT NULL
, [SubscriptionNumber] text NOT NULL
, [UpdatedById] text NOT NULL
, [UpdatedTime] text NULL
, [Version] bigint NULL
, [OrderId] text NULL
, CONSTRAINT [sqlite_autoindex_Subscriptions_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_Subscriptions_0_0] FOREIGN KEY ([RenewalTermId]) REFERENCES [Term] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Subscriptions_1_0] FOREIGN KEY ([InitialTermId]) REFERENCES [Term] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Subscriptions_2_0] FOREIGN KEY ([CurrentTermId]) REFERENCES [Term] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Subscriptions_3_0] FOREIGN KEY ([OrderId]) REFERENCES [Order] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
, CONSTRAINT [FK_Subscriptions_4_0] FOREIGN KEY ([CustomObjectsId]) REFERENCES [CustomObjects] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Subscriptions_5_0] FOREIGN KEY ([CustomFieldsId]) REFERENCES [CustomFields] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Subscriptions_6_0] FOREIGN KEY ([SoldToId1]) REFERENCES [Contacts] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Subscriptions_7_0] FOREIGN KEY ([BillToId1]) REFERENCES [Contacts] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Subscriptions_8_0] FOREIGN KEY ([BillingDocumentSettingsId]) REFERENCES [BillingDocumentSettings] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Subscriptions_9_0] FOREIGN KEY ([InvoiceOwnerAccountId1]) REFERENCES [Accounts] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Subscriptions_10_0] FOREIGN KEY ([AccountId1]) REFERENCES [Accounts] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [SubscriptionTerms] (
  [Id] text NOT NULL
, [AutoRenew] bigint NULL
, [CurrentTermId] text NOT NULL
, [RenewalTermId] text NOT NULL
, CONSTRAINT [sqlite_autoindex_SubscriptionTerms_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_SubscriptionTerms_0_0] FOREIGN KEY ([RenewalTermId]) REFERENCES [Term] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_SubscriptionTerms_1_0] FOREIGN KEY ([CurrentTermId]) REFERENCES [Term] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [TaxationItems] (
  [Id] text NOT NULL
, [Amount] text NULL
, [AmountApplied] text NULL
, [AmountCredited] text NULL
, [AmountExempt] text NULL
, [AmountPaid] text NULL
, [AmountRefunded] text NULL
, [CreatedById] text NOT NULL
, [CreatedTime] text NULL
, [CustomFieldsId] text NOT NULL
, [CustomObjectsId] text NOT NULL
, [Jurisdiction] text NOT NULL
, [LocationCode] text NOT NULL
, [Name] text NOT NULL
, [OnAccountAccount] text NOT NULL
, [RemainingBalance] text NULL
, [SalesTaxPayableAccount] text NOT NULL
, [SourceTaxItemId] text NOT NULL
, [TaxCode] text NOT NULL
, [TaxCodeName] text NOT NULL
, [TaxDate] text NULL
, [TaxInclusive] bigint NULL
, [TaxRate] text NULL
, [TaxRateName] text NOT NULL
, [TaxRateType] text NOT NULL
, [UpdatedById] text NOT NULL
, [UpdatedTime] text NULL
, [BillingDocumentItemId] text NULL
, [CreditMemoItemId] text NULL
, [DebitMemoItemId] text NULL
, [InvoiceItemId] text NULL
, CONSTRAINT [sqlite_autoindex_TaxationItems_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_TaxationItems_0_0] FOREIGN KEY ([InvoiceItemId]) REFERENCES [InvoiceItems] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
, CONSTRAINT [FK_TaxationItems_1_0] FOREIGN KEY ([DebitMemoItemId]) REFERENCES [DebitMemoItems] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
, CONSTRAINT [FK_TaxationItems_2_0] FOREIGN KEY ([CustomObjectsId]) REFERENCES [CustomObjects] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_TaxationItems_3_0] FOREIGN KEY ([CustomFieldsId]) REFERENCES [CustomFields] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_TaxationItems_4_0] FOREIGN KEY ([CreditMemoItemId]) REFERENCES [CreditMemoItems] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
, CONSTRAINT [FK_TaxationItems_5_0] FOREIGN KEY ([BillingDocumentItemId]) REFERENCES [BillingDocumentItems] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
);
CREATE TABLE [TaxCertificates] (
  [Id] text NOT NULL
, [CompanyCode] text NOT NULL
, [Description] text NOT NULL
, [EndDate] text NULL
, [EntityUseCode] text NOT NULL
, [IssuingJurisdiction] text NOT NULL
, [StartDate] text NULL
, [State] text NOT NULL
, [TaxIdentifier] text NOT NULL
, CONSTRAINT [sqlite_autoindex_TaxCertificates_1] PRIMARY KEY ([Id])
);
CREATE TABLE [TaxIdentifiers] (
  [Id] text NOT NULL
, CONSTRAINT [sqlite_autoindex_TaxIdentifiers_1] PRIMARY KEY ([Id])
);
CREATE TABLE [Term] (
  [Id] text NOT NULL
, [EndDate] text NULL
, [Interval] text NOT NULL
, [IntervalCount] bigint NULL
, [StartDate] text NULL
, [Type] text NOT NULL
, CONSTRAINT [sqlite_autoindex_Term_1] PRIMARY KEY ([Id])
);
CREATE TABLE [Tier] (
  [Id] text NOT NULL
, [AmountsId] text NOT NULL
, [UnitAmountsId] text NOT NULL
, [UpTo] text NULL
, [PriceId] text NULL
, CONSTRAINT [sqlite_autoindex_Tier_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_Tier_0_0] FOREIGN KEY ([PriceId]) REFERENCES [Price] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
, CONSTRAINT [FK_Tier_1_0] FOREIGN KEY ([UnitAmountsId]) REFERENCES [Money] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Tier_2_0] FOREIGN KEY ([AmountsId]) REFERENCES [Money] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [TransactionsState] (
  [Id] text NOT NULL
, [Failed] text NOT NULL
, [Succeeded] text NOT NULL
, CONSTRAINT [sqlite_autoindex_TransactionsState_1] PRIMARY KEY ([Id])
);
CREATE TABLE [Usages] (
  [Id] text NOT NULL
, [AccountId1] text NOT NULL
, [AccountId] text NOT NULL
, [AccountNumber] text NOT NULL
, [CreatedById] text NOT NULL
, [CreatedTime] text NULL
, [CustomFieldsId] text NOT NULL
, [CustomObjectsId] text NOT NULL
, [Description] text NOT NULL
, [EndTime] text NULL
, [Quantity] text NULL
, [StartTime] text NULL
, [State] text NOT NULL
, [SubscriptionId] text NOT NULL
, [SubscriptionItemId] text NOT NULL
, [SubscriptionItemNumber] text NOT NULL
, [SubscriptionNumber] text NOT NULL
, [UnitOfMeasure] text NOT NULL
, [UpdatedById] text NOT NULL
, [UpdatedTime] text NULL
, CONSTRAINT [sqlite_autoindex_Usages_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_Usages_0_0] FOREIGN KEY ([CustomObjectsId]) REFERENCES [CustomObjects] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Usages_1_0] FOREIGN KEY ([CustomFieldsId]) REFERENCES [CustomFields] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_Usages_2_0] FOREIGN KEY ([AccountId1]) REFERENCES [Accounts] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [ValidityPeriod] (
  [Id] text NOT NULL
, [EndDate] text NULL
, [OverageRatedAmount] text NULL
, [OverageRatedQuantity] text NULL
, [PrepaidUOM] text NOT NULL
, [RemainingBalance] text NULL
, [StartDate] text NULL
, [TotalBalance] text NULL
, [PrepaidBalancesId] text NULL
, CONSTRAINT [sqlite_autoindex_ValidityPeriod_1] PRIMARY KEY ([Id])
, CONSTRAINT [FK_ValidityPeriod_0_0] FOREIGN KEY ([PrepaidBalancesId]) REFERENCES [PrepaidBalances] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
);
CREATE INDEX [Accounts_IX_Accounts_TaxIdentifierId] ON [Accounts] ([TaxIdentifierId] ASC);
CREATE INDEX [Accounts_IX_Accounts_TaxCertificateId] ON [Accounts] ([TaxCertificateId] ASC);
CREATE INDEX [Accounts_IX_Accounts_SoldToId1] ON [Accounts] ([SoldToId1] ASC);
CREATE INDEX [Accounts_IX_Accounts_CustomObjectsId] ON [Accounts] ([CustomObjectsId] ASC);
CREATE INDEX [Accounts_IX_Accounts_CustomFieldsId] ON [Accounts] ([CustomFieldsId] ASC);
CREATE INDEX [Accounts_IX_Accounts_BillToId1] ON [Accounts] ([BillToId1] ASC);
CREATE INDEX [Accounts_IX_Accounts_BillingDocumentsId] ON [Accounts] ([BillingDocumentsId] ASC);
CREATE INDEX [Accounts_IX_Accounts_BillingDocumentSettingsId] ON [Accounts] ([BillingDocumentSettingsId] ASC);
CREATE INDEX [AchDebit_IX_AchDebit_MandateId] ON [AchDebit] ([MandateId] ASC);
CREATE INDEX [ApplePay_IX_ApplePay_MandateId] ON [ApplePay] ([MandateId] ASC);
CREATE INDEX [ApplePay_IX_ApplePay_CardId] ON [ApplePay] ([CardId] ASC);
CREATE INDEX [AuBecsDebit_IX_AuBecsDebit_MandateId] ON [AuBecsDebit] ([MandateId] ASC);
CREATE INDEX [AutogiroDebit_IX_AutogiroDebit_MandateId] ON [AutogiroDebit] ([MandateId] ASC);
CREATE INDEX [BacsDebit_IX_BacsDebit_MandateId] ON [BacsDebit] ([MandateId] ASC);
CREATE INDEX [BetalingsDebit_IX_BetalingsDebit_MandateId] ON [BetalingsDebit] ([MandateId] ASC);
CREATE INDEX [BillingDetails_IX_BillingDetails_AddressId] ON [BillingDetails] ([AddressId] ASC);
CREATE INDEX [BillingDocumentItems_IX_BillingDocumentItems_SubscriptionItemId1] ON [BillingDocumentItems] ([SubscriptionItemId1] ASC);
CREATE INDEX [BillingDocumentItems_IX_BillingDocumentItems_SubscriptionId1] ON [BillingDocumentItems] ([SubscriptionId1] ASC);
CREATE INDEX [BillingDocumentItems_IX_BillingDocumentItems_PaymentsAppliedToId] ON [BillingDocumentItems] ([PaymentsAppliedToId] ASC);
CREATE INDEX [BillingDocumentItems_IX_BillingDocumentItems_CustomObjectsId] ON [BillingDocumentItems] ([CustomObjectsId] ASC);
CREATE INDEX [BillingDocumentItems_IX_BillingDocumentItems_CustomFieldsId] ON [BillingDocumentItems] ([CustomFieldsId] ASC);
CREATE INDEX [BillingDocumentItems_IX_BillingDocumentItems_BillingDocumentId1] ON [BillingDocumentItems] ([BillingDocumentId1] ASC);
CREATE INDEX [BillingDocuments_IX_BillingDocuments_CustomObjectsId] ON [BillingDocuments] ([CustomObjectsId] ASC);
CREATE INDEX [BillingDocuments_IX_BillingDocuments_CustomFieldsId] ON [BillingDocuments] ([CustomFieldsId] ASC);
CREATE INDEX [BillingDocumentSettings_IX_BillingDocumentSettings_CreditMemoId] ON [BillingDocumentSettings] ([CreditMemoId] ASC);
CREATE INDEX [BillingDocumentStateTransitions_IX_BillingDocumentStateTransitions_BillingDocumentId] ON [BillingDocumentStateTransitions] ([BillingDocumentId] ASC);
CREATE INDEX [Card_IX_Card_MandateId] ON [Card] ([MandateId] ASC);
CREATE INDEX [CardMandate_IX_CardMandate_CustomerAcceptanceId] ON [CardMandate] ([CustomerAcceptanceId] ASC);
CREATE INDEX [CcRef_IX_CcRef_MandateId] ON [CcRef] ([MandateId] ASC);
CREATE INDEX [CcRef_IX_CcRef_CardId] ON [CcRef] ([CardId] ASC);
CREATE INDEX [Contacts_IX_Contacts_CustomObjectsId] ON [Contacts] ([CustomObjectsId] ASC);
CREATE INDEX [Contacts_IX_Contacts_CustomFieldsId] ON [Contacts] ([CustomFieldsId] ASC);
CREATE INDEX [Contacts_IX_Contacts_AddressId] ON [Contacts] ([AddressId] ASC);
CREATE INDEX [CreditMemoAppliedTo_IX_CreditMemoAppliedTo_BillingDocumentId1] ON [CreditMemoAppliedTo] ([BillingDocumentId1] ASC);
CREATE INDEX [CreditMemoItems_IX_CreditMemoItems_SubscriptionItemId1] ON [CreditMemoItems] ([SubscriptionItemId1] ASC);
CREATE INDEX [CreditMemoItems_IX_CreditMemoItems_SubscriptionId1] ON [CreditMemoItems] ([SubscriptionId1] ASC);
CREATE INDEX [CreditMemoItems_IX_CreditMemoItems_CustomObjectsId] ON [CreditMemoItems] ([CustomObjectsId] ASC);
CREATE INDEX [CreditMemoItems_IX_CreditMemoItems_CustomFieldsId] ON [CreditMemoItems] ([CustomFieldsId] ASC);
CREATE INDEX [CreditMemoItems_IX_CreditMemoItems_CreditMemoId1] ON [CreditMemoItems] ([CreditMemoId1] ASC);
CREATE INDEX [CreditMemos_IX_CreditMemos_StateTransitionsId] ON [CreditMemos] ([StateTransitionsId] ASC);
CREATE INDEX [CreditMemos_IX_CreditMemos_CustomObjectsId] ON [CreditMemos] ([CustomObjectsId] ASC);
CREATE INDEX [CreditMemos_IX_CreditMemos_CustomFieldsId] ON [CreditMemos] ([CustomFieldsId] ASC);
CREATE INDEX [CreditMemos_IX_CreditMemos_CreditMemoId] ON [CreditMemos] ([CreditMemoId] ASC);
CREATE INDEX [CreditMemos_IX_CreditMemos_BillToId1] ON [CreditMemos] ([BillToId1] ASC);
CREATE INDEX [CreditMemos_IX_CreditMemos_ArTransactionsId] ON [CreditMemos] ([ArTransactionsId] ASC);
CREATE INDEX [CreditMemos_IX_CreditMemos_AccountId1] ON [CreditMemos] ([AccountId1] ASC);
CREATE INDEX [DebitMemoItems_IX_DebitMemoItems_SubscriptionItemId1] ON [DebitMemoItems] ([SubscriptionItemId1] ASC);
CREATE INDEX [DebitMemoItems_IX_DebitMemoItems_SubscriptionId1] ON [DebitMemoItems] ([SubscriptionId1] ASC);
CREATE INDEX [DebitMemoItems_IX_DebitMemoItems_DebitMemoId1] ON [DebitMemoItems] ([DebitMemoId1] ASC);
CREATE INDEX [DebitMemoItems_IX_DebitMemoItems_CustomObjectsId] ON [DebitMemoItems] ([CustomObjectsId] ASC);
CREATE INDEX [DebitMemoItems_IX_DebitMemoItems_CustomFieldsId] ON [DebitMemoItems] ([CustomFieldsId] ASC);
CREATE INDEX [DebitMemos_IX_DebitMemos_StateTransitionsId] ON [DebitMemos] ([StateTransitionsId] ASC);
CREATE INDEX [DebitMemos_IX_DebitMemos_CustomObjectsId] ON [DebitMemos] ([CustomObjectsId] ASC);
CREATE INDEX [DebitMemos_IX_DebitMemos_CustomFieldsId] ON [DebitMemos] ([CustomFieldsId] ASC);
CREATE INDEX [DebitMemos_IX_DebitMemos_BillToId1] ON [DebitMemos] ([BillToId1] ASC);
CREATE INDEX [DebitMemos_IX_DebitMemos_BillingDocumentSettingsId] ON [DebitMemos] ([BillingDocumentSettingsId] ASC);
CREATE INDEX [DebitMemos_IX_DebitMemos_AccountId1] ON [DebitMemos] ([AccountId1] ASC);
CREATE INDEX [GetCardList_IX_GetCardList_MandateId] ON [GetCardList] ([MandateId] ASC);
CREATE INDEX [GooglePay_IX_GooglePay_CardId] ON [GooglePay] ([CardId] ASC);
CREATE INDEX [InvoiceItems_IX_InvoiceItems_SubscriptionItemId1] ON [InvoiceItems] ([SubscriptionItemId1] ASC);
CREATE INDEX [InvoiceItems_IX_InvoiceItems_SubscriptionId1] ON [InvoiceItems] ([SubscriptionId1] ASC);
CREATE INDEX [InvoiceItems_IX_InvoiceItems_LineItemId] ON [InvoiceItems] ([LineItemId] ASC);
CREATE INDEX [InvoiceItems_IX_InvoiceItems_InvoiceId1] ON [InvoiceItems] ([InvoiceId1] ASC);
CREATE INDEX [InvoiceItems_IX_InvoiceItems_CustomObjectsId] ON [InvoiceItems] ([CustomObjectsId] ASC);
CREATE INDEX [InvoiceItems_IX_InvoiceItems_CustomFieldsId] ON [InvoiceItems] ([CustomFieldsId] ASC);
CREATE INDEX [Invoices_IX_Invoices_StateTransitionsId] ON [Invoices] ([StateTransitionsId] ASC);
CREATE INDEX [Invoices_IX_Invoices_SoldToId1] ON [Invoices] ([SoldToId1] ASC);
CREATE INDEX [Invoices_IX_Invoices_CustomObjectsId] ON [Invoices] ([CustomObjectsId] ASC);
CREATE INDEX [Invoices_IX_Invoices_CustomFieldsId] ON [Invoices] ([CustomFieldsId] ASC);
CREATE INDEX [Invoices_IX_Invoices_BillToId1] ON [Invoices] ([BillToId1] ASC);
CREATE INDEX [Invoices_IX_Invoices_BillingDocumentSettingsId] ON [Invoices] ([BillingDocumentSettingsId] ASC);
CREATE INDEX [Invoices_IX_Invoices_ArTransactionsId] ON [Invoices] ([ArTransactionsId] ASC);
CREATE INDEX [Invoices_IX_Invoices_AccountId1] ON [Invoices] ([AccountId1] ASC);
CREATE INDEX [ItemTier_IX_ItemTier_SubscriptionItemId] ON [ItemTier] ([SubscriptionItemId] ASC);
CREATE INDEX [NzBecsDebit_IX_NzBecsDebit_MandateId] ON [NzBecsDebit] ([MandateId] ASC);
CREATE INDEX [Order_IX_Order_CustomObjectsId] ON [Order] ([CustomObjectsId] ASC);
CREATE INDEX [Order_IX_Order_CustomFieldsId] ON [Order] ([CustomFieldsId] ASC);
CREATE INDEX [Order_IX_Order_AccountId1] ON [Order] ([AccountId1] ASC);
CREATE INDEX [OrderLineItems_IX_OrderLineItems_RevenueId] ON [OrderLineItems] ([RevenueId] ASC);
CREATE INDEX [OrderLineItems_IX_OrderLineItems_OrderId1] ON [OrderLineItems] ([OrderId1] ASC);
CREATE INDEX [OrderLineItems_IX_OrderLineItems_CustomObjectsId] ON [OrderLineItems] ([CustomObjectsId] ASC);
CREATE INDEX [OrderLineItems_IX_OrderLineItems_CustomFieldsId] ON [OrderLineItems] ([CustomFieldsId] ASC);
CREATE INDEX [PadDebit_IX_PadDebit_MandateId] ON [PadDebit] ([MandateId] ASC);
CREATE INDEX [PaymentMethods_IX_PaymentMethods_SepaDebitId] ON [PaymentMethods] ([SepaDebitId] ASC);
CREATE INDEX [PaymentMethods_IX_PaymentMethods_PaypalExpressNativeId] ON [PaymentMethods] ([PaypalExpressNativeId] ASC);
CREATE INDEX [PaymentMethods_IX_PaymentMethods_PaypalExpressId] ON [PaymentMethods] ([PaypalExpressId] ASC);
CREATE INDEX [PaymentMethods_IX_PaymentMethods_PaypalAdaptiveId] ON [PaymentMethods] ([PaypalAdaptiveId] ASC);
CREATE INDEX [PaymentMethods_IX_PaymentMethods_PadDebitId] ON [PaymentMethods] ([PadDebitId] ASC);
CREATE INDEX [PaymentMethods_IX_PaymentMethods_NzBecsDebitId] ON [PaymentMethods] ([NzBecsDebitId] ASC);
CREATE INDEX [PaymentMethods_IX_PaymentMethods_GooglePayId] ON [PaymentMethods] ([GooglePayId] ASC);
CREATE INDEX [PaymentMethods_IX_PaymentMethods_CustomObjectsId] ON [PaymentMethods] ([CustomObjectsId] ASC);
CREATE INDEX [PaymentMethods_IX_PaymentMethods_CustomFieldsId] ON [PaymentMethods] ([CustomFieldsId] ASC);
CREATE INDEX [PaymentMethods_IX_PaymentMethods_CcRefId] ON [PaymentMethods] ([CcRefId] ASC);
CREATE INDEX [PaymentMethods_IX_PaymentMethods_CardId] ON [PaymentMethods] ([CardId] ASC);
CREATE INDEX [PaymentMethods_IX_PaymentMethods_BillingDetailsId] ON [PaymentMethods] ([BillingDetailsId] ASC);
CREATE INDEX [PaymentMethods_IX_PaymentMethods_BetalingsDebitId] ON [PaymentMethods] ([BetalingsDebitId] ASC);
CREATE INDEX [PaymentMethods_IX_PaymentMethods_BacsDebitId] ON [PaymentMethods] ([BacsDebitId] ASC);
CREATE INDEX [PaymentMethods_IX_PaymentMethods_AutogiroDebitId] ON [PaymentMethods] ([AutogiroDebitId] ASC);
CREATE INDEX [PaymentMethods_IX_PaymentMethods_AuBecsDebitId] ON [PaymentMethods] ([AuBecsDebitId] ASC);
CREATE INDEX [PaymentMethods_IX_PaymentMethods_ApplePayId] ON [PaymentMethods] ([ApplePayId] ASC);
CREATE INDEX [PaymentMethods_IX_PaymentMethods_AchDebitId] ON [PaymentMethods] ([AchDebitId] ASC);
CREATE INDEX [PaymentMethods_IX_PaymentMethods_AccountId1] ON [PaymentMethods] ([AccountId1] ASC);
CREATE INDEX [PaymentOption_IX_PaymentOption_PaymentScheduleId] ON [PaymentOption] ([PaymentScheduleId] ASC);
CREATE INDEX [PaymentOption_IX_PaymentOption_DetailId] ON [PaymentOption] ([DetailId] ASC);
CREATE INDEX [Payments_IX_Payments_StateTransitionsId] ON [Payments] ([StateTransitionsId] ASC);
CREATE INDEX [Payments_IX_Payments_PaymentTransactionsId] ON [Payments] ([PaymentTransactionsId] ASC);
CREATE INDEX [Payments_IX_Payments_PaymentMethodId1] ON [Payments] ([PaymentMethodId1] ASC);
CREATE INDEX [Payments_IX_Payments_GatewayStateTransitionsId] ON [Payments] ([GatewayStateTransitionsId] ASC);
CREATE INDEX [Payments_IX_Payments_GatewayOptionsId] ON [Payments] ([GatewayOptionsId] ASC);
CREATE INDEX [Payments_IX_Payments_CustomObjectsId] ON [Payments] ([CustomObjectsId] ASC);
CREATE INDEX [Payments_IX_Payments_CustomFieldsId] ON [Payments] ([CustomFieldsId] ASC);
CREATE INDEX [Payments_IX_Payments_AccountId1] ON [Payments] ([AccountId1] ASC);
CREATE INDEX [PaymentsAppliedTo_IX_PaymentsAppliedTo_PaymentId] ON [PaymentsAppliedTo] ([PaymentId] ASC);
CREATE INDEX [PaymentsAppliedTo_IX_PaymentsAppliedTo_BillingDocumentId1] ON [PaymentsAppliedTo] ([BillingDocumentId1] ASC);
CREATE INDEX [PaymentSchedule_IX_PaymentSchedule_CustomObjectsId] ON [PaymentSchedule] ([CustomObjectsId] ASC);
CREATE INDEX [PaymentSchedule_IX_PaymentSchedule_CustomFieldsId] ON [PaymentSchedule] ([CustomFieldsId] ASC);
CREATE INDEX [PaymentSchedule_IX_PaymentSchedule_BillingDocumentId] ON [PaymentSchedule] ([BillingDocumentId] ASC);
CREATE INDEX [PaymentScheduleItemPayments_IX_PaymentScheduleItemPayments_PaymentScheduleItemId] ON [PaymentScheduleItemPayments] ([PaymentScheduleItemId] ASC);
CREATE INDEX [PaymentScheduleItems_IX_PaymentScheduleItems_PaymentScheduleId1] ON [PaymentScheduleItems] ([PaymentScheduleId1] ASC);
CREATE INDEX [PaymentScheduleItems_IX_PaymentScheduleItems_PaymentId] ON [PaymentScheduleItems] ([PaymentId] ASC);
CREATE INDEX [PaymentScheduleItems_IX_PaymentScheduleItems_CustomObjectsId] ON [PaymentScheduleItems] ([CustomObjectsId] ASC);
CREATE INDEX [PaymentScheduleItems_IX_PaymentScheduleItems_CustomFieldsId] ON [PaymentScheduleItems] ([CustomFieldsId] ASC);
CREATE INDEX [PaymentScheduleItems_IX_PaymentScheduleItems_BillingDocumentId] ON [PaymentScheduleItems] ([BillingDocumentId] ASC);
CREATE INDEX [PaymentTransactions_IX_PaymentTransactions_StateId] ON [PaymentTransactions] ([StateId] ASC);
CREATE INDEX [PaymentTransactions_IX_PaymentTransactions_ArTransactionsId] ON [PaymentTransactions] ([ArTransactionsId] ASC);
CREATE INDEX [Plan_IX_Plan_ProductId1] ON [Plan] ([ProductId1] ASC);
CREATE INDEX [Plan_IX_Plan_CustomObjectsId] ON [Plan] ([CustomObjectsId] ASC);
CREATE INDEX [Plan_IX_Plan_CustomFieldsId] ON [Plan] ([CustomFieldsId] ASC);
CREATE INDEX [PrepaidBalance_IX_PrepaidBalance_SubscriptionId] ON [PrepaidBalance] ([SubscriptionId] ASC);
CREATE INDEX [PrepaidBalances_IX_PrepaidBalances_SubscriptionId] ON [PrepaidBalances] ([SubscriptionId] ASC);
CREATE INDEX [PrepaidBalanceTransaction_IX_PrepaidBalanceTransaction_ValidityPeriodId] ON [PrepaidBalanceTransaction] ([ValidityPeriodId] ASC);
CREATE INDEX [PrepaidBalanceTransaction_IX_PrepaidBalanceTransaction_PrepaidBalanceId] ON [PrepaidBalanceTransaction] ([PrepaidBalanceId] ASC);
CREATE INDEX [Price_IX_Price_UnitAmountsId] ON [Price] ([UnitAmountsId] ASC);
CREATE INDEX [Price_IX_Price_RevenueId] ON [Price] ([RevenueId] ASC);
CREATE INDEX [Price_IX_Price_RecurringId] ON [Price] ([RecurringId] ASC);
CREATE INDEX [Price_IX_Price_PrepaymentId] ON [Price] ([PrepaymentId] ASC);
CREATE INDEX [Price_IX_Price_PlanId1] ON [Price] ([PlanId1] ASC);
CREATE INDEX [Price_IX_Price_OverageId] ON [Price] ([OverageId] ASC);
CREATE INDEX [Price_IX_Price_DrawdownId] ON [Price] ([DrawdownId] ASC);
CREATE INDEX [Price_IX_Price_DiscountAmountsId] ON [Price] ([DiscountAmountsId] ASC);
CREATE INDEX [Price_IX_Price_CustomObjectsId] ON [Price] ([CustomObjectsId] ASC);
CREATE INDEX [Price_IX_Price_CustomFieldsId] ON [Price] ([CustomFieldsId] ASC);
CREATE INDEX [Price_IX_Price_AmountsId] ON [Price] ([AmountsId] ASC);
CREATE INDEX [ProductPlan_IX_ProductPlan_ProductId1] ON [ProductPlan] ([ProductId1] ASC);
CREATE INDEX [ProductPlan_IX_ProductPlan_CustomObjectsId] ON [ProductPlan] ([CustomObjectsId] ASC);
CREATE INDEX [ProductPlan_IX_ProductPlan_CustomFieldsId] ON [ProductPlan] ([CustomFieldsId] ASC);
CREATE INDEX [ProductPrice_IX_ProductPrice_UnitAmountsId] ON [ProductPrice] ([UnitAmountsId] ASC);
CREATE INDEX [ProductPrice_IX_ProductPrice_RevenueId] ON [ProductPrice] ([RevenueId] ASC);
CREATE INDEX [ProductPrice_IX_ProductPrice_RecurringId] ON [ProductPrice] ([RecurringId] ASC);
CREATE INDEX [ProductPrice_IX_ProductPrice_ProductPlanId1] ON [ProductPrice] ([ProductPlanId1] ASC);
CREATE INDEX [ProductPrice_IX_ProductPrice_PrepaymentId] ON [ProductPrice] ([PrepaymentId] ASC);
CREATE INDEX [ProductPrice_IX_ProductPrice_OverageId] ON [ProductPrice] ([OverageId] ASC);
CREATE INDEX [ProductPrice_IX_ProductPrice_DrawdownId] ON [ProductPrice] ([DrawdownId] ASC);
CREATE INDEX [ProductPrice_IX_ProductPrice_DiscountAmountsId] ON [ProductPrice] ([DiscountAmountsId] ASC);
CREATE INDEX [ProductPrice_IX_ProductPrice_CustomObjectsId] ON [ProductPrice] ([CustomObjectsId] ASC);
CREATE INDEX [ProductPrice_IX_ProductPrice_CustomFieldsId] ON [ProductPrice] ([CustomFieldsId] ASC);
CREATE INDEX [ProductPrice_IX_ProductPrice_AmountsId] ON [ProductPrice] ([AmountsId] ASC);
CREATE INDEX [Products_IX_Products_CustomObjectsId] ON [Products] ([CustomObjectsId] ASC);
CREATE INDEX [Products_IX_Products_CustomFieldsId] ON [Products] ([CustomFieldsId] ASC);
CREATE INDEX [ProductTier_IX_ProductTier_UnitAmountsId] ON [ProductTier] ([UnitAmountsId] ASC);
CREATE INDEX [ProductTier_IX_ProductTier_ProductPriceId] ON [ProductTier] ([ProductPriceId] ASC);
CREATE INDEX [ProductTier_IX_ProductTier_AmountsId] ON [ProductTier] ([AmountsId] ASC);
CREATE INDEX [RefundAppliedToItem_IX_RefundAppliedToItem_RefundsAppliedToId] ON [RefundAppliedToItem] ([RefundsAppliedToId] ASC);
CREATE INDEX [Refunds_IX_Refunds_StateTransitionsId] ON [Refunds] ([StateTransitionsId] ASC);
CREATE INDEX [Refunds_IX_Refunds_RefundTransactionsId] ON [Refunds] ([RefundTransactionsId] ASC);
CREATE INDEX [Refunds_IX_Refunds_PaymentMethodId1] ON [Refunds] ([PaymentMethodId1] ASC);
CREATE INDEX [Refunds_IX_Refunds_GatewayOptionsId] ON [Refunds] ([GatewayOptionsId] ASC);
CREATE INDEX [Refunds_IX_Refunds_CustomObjectsId] ON [Refunds] ([CustomObjectsId] ASC);
CREATE INDEX [Refunds_IX_Refunds_CustomFieldsId] ON [Refunds] ([CustomFieldsId] ASC);
CREATE INDEX [Refunds_IX_Refunds_CreditMemoId] ON [Refunds] ([CreditMemoId] ASC);
CREATE INDEX [Refunds_IX_Refunds_AccountId1] ON [Refunds] ([AccountId1] ASC);
CREATE INDEX [RefundsAppliedTo_IX_RefundsAppliedTo_RefundId] ON [RefundsAppliedTo] ([RefundId] ASC);
CREATE INDEX [RefundsAppliedTo_IX_RefundsAppliedTo_PaymentId] ON [RefundsAppliedTo] ([PaymentId] ASC);
CREATE INDEX [RefundsAppliedTo_IX_RefundsAppliedTo_BillingDocumentId1] ON [RefundsAppliedTo] ([BillingDocumentId1] ASC);
CREATE INDEX [RefundTransactions_IX_RefundTransactions_StateId] ON [RefundTransactions] ([StateId] ASC);
CREATE INDEX [RefundTransactions_IX_RefundTransactions_ArTransactionsId] ON [RefundTransactions] ([ArTransactionsId] ASC);
CREATE INDEX [ResumeSubscription_IX_ResumeSubscription_CustomFieldsId] ON [ResumeSubscription] ([CustomFieldsId] ASC);
CREATE INDEX [SepaDebit_IX_SepaDebit_MandateId] ON [SepaDebit] ([MandateId] ASC);
CREATE INDEX [SubscriptionAddPlans_IX_SubscriptionAddPlans_CustomFieldsId] ON [SubscriptionAddPlans] ([CustomFieldsId] ASC);
CREATE INDEX [SubscriptionItems_IX_SubscriptionItems_SubscriptionPlanId1] ON [SubscriptionItems] ([SubscriptionPlanId1] ASC);
CREATE INDEX [SubscriptionItems_IX_SubscriptionItems_SubscriptionAddPlanId] ON [SubscriptionItems] ([SubscriptionAddPlanId] ASC);
CREATE INDEX [SubscriptionItems_IX_SubscriptionItems_RecurringId] ON [SubscriptionItems] ([RecurringId] ASC);
CREATE INDEX [SubscriptionItems_IX_SubscriptionItems_PriceId1] ON [SubscriptionItems] ([PriceId1] ASC);
CREATE INDEX [SubscriptionItems_IX_SubscriptionItems_OverageId] ON [SubscriptionItems] ([OverageId] ASC);
CREATE INDEX [SubscriptionItems_IX_SubscriptionItems_CustomObjectsId] ON [SubscriptionItems] ([CustomObjectsId] ASC);
CREATE INDEX [SubscriptionItems_IX_SubscriptionItems_CustomFieldsId] ON [SubscriptionItems] ([CustomFieldsId] ASC);
CREATE INDEX [SubscriptionPauses_IX_SubscriptionPauses_ResumeBehaviorId] ON [SubscriptionPauses] ([ResumeBehaviorId] ASC);
CREATE INDEX [SubscriptionPauses_IX_SubscriptionPauses_CustomFieldsId] ON [SubscriptionPauses] ([CustomFieldsId] ASC);
CREATE INDEX [SubscriptionPlans_IX_SubscriptionPlans_SubscriptionId1] ON [SubscriptionPlans] ([SubscriptionId1] ASC);
CREATE INDEX [SubscriptionPlans_IX_SubscriptionPlans_ProductId1] ON [SubscriptionPlans] ([ProductId1] ASC);
CREATE INDEX [SubscriptionPlans_IX_SubscriptionPlans_PlanId1] ON [SubscriptionPlans] ([PlanId1] ASC);
CREATE INDEX [SubscriptionPlans_IX_SubscriptionPlans_CustomObjectsId] ON [SubscriptionPlans] ([CustomObjectsId] ASC);
CREATE INDEX [SubscriptionPlans_IX_SubscriptionPlans_CustomFieldsId] ON [SubscriptionPlans] ([CustomFieldsId] ASC);
CREATE INDEX [SubscriptionRenews_IX_SubscriptionRenews_TermsId] ON [SubscriptionRenews] ([TermsId] ASC);
CREATE INDEX [Subscriptions_IX_Subscriptions_SoldToId1] ON [Subscriptions] ([SoldToId1] ASC);
CREATE INDEX [Subscriptions_IX_Subscriptions_RenewalTermId] ON [Subscriptions] ([RenewalTermId] ASC);
CREATE INDEX [Subscriptions_IX_Subscriptions_OrderId] ON [Subscriptions] ([OrderId] ASC);
CREATE INDEX [Subscriptions_IX_Subscriptions_InvoiceOwnerAccountId1] ON [Subscriptions] ([InvoiceOwnerAccountId1] ASC);
CREATE INDEX [Subscriptions_IX_Subscriptions_InitialTermId] ON [Subscriptions] ([InitialTermId] ASC);
CREATE INDEX [Subscriptions_IX_Subscriptions_CustomObjectsId] ON [Subscriptions] ([CustomObjectsId] ASC);
CREATE INDEX [Subscriptions_IX_Subscriptions_CustomFieldsId] ON [Subscriptions] ([CustomFieldsId] ASC);
CREATE INDEX [Subscriptions_IX_Subscriptions_CurrentTermId] ON [Subscriptions] ([CurrentTermId] ASC);
CREATE INDEX [Subscriptions_IX_Subscriptions_BillToId1] ON [Subscriptions] ([BillToId1] ASC);
CREATE INDEX [Subscriptions_IX_Subscriptions_BillingDocumentSettingsId] ON [Subscriptions] ([BillingDocumentSettingsId] ASC);
CREATE INDEX [Subscriptions_IX_Subscriptions_AccountId1] ON [Subscriptions] ([AccountId1] ASC);
CREATE INDEX [SubscriptionTerms_IX_SubscriptionTerms_RenewalTermId] ON [SubscriptionTerms] ([RenewalTermId] ASC);
CREATE INDEX [SubscriptionTerms_IX_SubscriptionTerms_CurrentTermId] ON [SubscriptionTerms] ([CurrentTermId] ASC);
CREATE INDEX [TaxationItems_IX_TaxationItems_InvoiceItemId] ON [TaxationItems] ([InvoiceItemId] ASC);
CREATE INDEX [TaxationItems_IX_TaxationItems_DebitMemoItemId] ON [TaxationItems] ([DebitMemoItemId] ASC);
CREATE INDEX [TaxationItems_IX_TaxationItems_CustomObjectsId] ON [TaxationItems] ([CustomObjectsId] ASC);
CREATE INDEX [TaxationItems_IX_TaxationItems_CustomFieldsId] ON [TaxationItems] ([CustomFieldsId] ASC);
CREATE INDEX [TaxationItems_IX_TaxationItems_CreditMemoItemId] ON [TaxationItems] ([CreditMemoItemId] ASC);
CREATE INDEX [TaxationItems_IX_TaxationItems_BillingDocumentItemId] ON [TaxationItems] ([BillingDocumentItemId] ASC);
CREATE INDEX [Tier_IX_Tier_UnitAmountsId] ON [Tier] ([UnitAmountsId] ASC);
CREATE INDEX [Tier_IX_Tier_PriceId] ON [Tier] ([PriceId] ASC);
CREATE INDEX [Tier_IX_Tier_AmountsId] ON [Tier] ([AmountsId] ASC);
CREATE INDEX [Usages_IX_Usages_CustomObjectsId] ON [Usages] ([CustomObjectsId] ASC);
CREATE INDEX [Usages_IX_Usages_CustomFieldsId] ON [Usages] ([CustomFieldsId] ASC);
CREATE INDEX [Usages_IX_Usages_AccountId1] ON [Usages] ([AccountId1] ASC);
CREATE INDEX [ValidityPeriod_IX_ValidityPeriod_PrepaidBalancesId] ON [ValidityPeriod] ([PrepaidBalancesId] ASC);
CREATE TRIGGER [fki_Accounts_BillingDocumentSettingsId_BillingDocumentSettings_Id] BEFORE Insert ON [Accounts] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Accounts violates foreign key constraint FK_Accounts_0_0') WHERE (SELECT Id FROM BillingDocumentSettings WHERE  Id = NEW.BillingDocumentSettingsId) IS NULL; END;
CREATE TRIGGER [fku_Accounts_BillingDocumentSettingsId_BillingDocumentSettings_Id] BEFORE Update ON [Accounts] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Accounts violates foreign key constraint FK_Accounts_0_0') WHERE (SELECT Id FROM BillingDocumentSettings WHERE  Id = NEW.BillingDocumentSettingsId) IS NULL; END;
CREATE TRIGGER [fki_Accounts_TaxIdentifierId_TaxIdentifiers_Id] BEFORE Insert ON [Accounts] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Accounts violates foreign key constraint FK_Accounts_1_0') WHERE (SELECT Id FROM TaxIdentifiers WHERE  Id = NEW.TaxIdentifierId) IS NULL; END;
CREATE TRIGGER [fku_Accounts_TaxIdentifierId_TaxIdentifiers_Id] BEFORE Update ON [Accounts] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Accounts violates foreign key constraint FK_Accounts_1_0') WHERE (SELECT Id FROM TaxIdentifiers WHERE  Id = NEW.TaxIdentifierId) IS NULL; END;
CREATE TRIGGER [fki_Accounts_TaxCertificateId_TaxCertificates_Id] BEFORE Insert ON [Accounts] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Accounts violates foreign key constraint FK_Accounts_2_0') WHERE (SELECT Id FROM TaxCertificates WHERE  Id = NEW.TaxCertificateId) IS NULL; END;
CREATE TRIGGER [fku_Accounts_TaxCertificateId_TaxCertificates_Id] BEFORE Update ON [Accounts] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Accounts violates foreign key constraint FK_Accounts_2_0') WHERE (SELECT Id FROM TaxCertificates WHERE  Id = NEW.TaxCertificateId) IS NULL; END;
CREATE TRIGGER [fki_Accounts_CustomObjectsId_CustomObjects_Id] BEFORE Insert ON [Accounts] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Accounts violates foreign key constraint FK_Accounts_3_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fku_Accounts_CustomObjectsId_CustomObjects_Id] BEFORE Update ON [Accounts] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Accounts violates foreign key constraint FK_Accounts_3_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fki_Accounts_CustomFieldsId_CustomFields_Id] BEFORE Insert ON [Accounts] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Accounts violates foreign key constraint FK_Accounts_4_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fku_Accounts_CustomFieldsId_CustomFields_Id] BEFORE Update ON [Accounts] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Accounts violates foreign key constraint FK_Accounts_4_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fki_Accounts_SoldToId1_Contacts_Id] BEFORE Insert ON [Accounts] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Accounts violates foreign key constraint FK_Accounts_5_0') WHERE (SELECT Id FROM Contacts WHERE  Id = NEW.SoldToId1) IS NULL; END;
CREATE TRIGGER [fku_Accounts_SoldToId1_Contacts_Id] BEFORE Update ON [Accounts] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Accounts violates foreign key constraint FK_Accounts_5_0') WHERE (SELECT Id FROM Contacts WHERE  Id = NEW.SoldToId1) IS NULL; END;
CREATE TRIGGER [fki_Accounts_BillToId1_Contacts_Id] BEFORE Insert ON [Accounts] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Accounts violates foreign key constraint FK_Accounts_6_0') WHERE (SELECT Id FROM Contacts WHERE  Id = NEW.BillToId1) IS NULL; END;
CREATE TRIGGER [fku_Accounts_BillToId1_Contacts_Id] BEFORE Update ON [Accounts] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Accounts violates foreign key constraint FK_Accounts_6_0') WHERE (SELECT Id FROM Contacts WHERE  Id = NEW.BillToId1) IS NULL; END;
CREATE TRIGGER [fki_Accounts_BillingDocumentsId_BillingDocuments_Id] BEFORE Insert ON [Accounts] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Accounts violates foreign key constraint FK_Accounts_7_0') WHERE (SELECT Id FROM BillingDocuments WHERE  Id = NEW.BillingDocumentsId) IS NULL; END;
CREATE TRIGGER [fku_Accounts_BillingDocumentsId_BillingDocuments_Id] BEFORE Update ON [Accounts] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Accounts violates foreign key constraint FK_Accounts_7_0') WHERE (SELECT Id FROM BillingDocuments WHERE  Id = NEW.BillingDocumentsId) IS NULL; END;
CREATE TRIGGER [fki_AchDebit_MandateId_Mandate_Id] BEFORE Insert ON [AchDebit] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table AchDebit violates foreign key constraint FK_AchDebit_0_0') WHERE (SELECT Id FROM Mandate WHERE  Id = NEW.MandateId) IS NULL; END;
CREATE TRIGGER [fku_AchDebit_MandateId_Mandate_Id] BEFORE Update ON [AchDebit] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table AchDebit violates foreign key constraint FK_AchDebit_0_0') WHERE (SELECT Id FROM Mandate WHERE  Id = NEW.MandateId) IS NULL; END;
CREATE TRIGGER [fki_ApplePay_MandateId_Mandate_Id] BEFORE Insert ON [ApplePay] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table ApplePay violates foreign key constraint FK_ApplePay_0_0') WHERE (SELECT Id FROM Mandate WHERE  Id = NEW.MandateId) IS NULL; END;
CREATE TRIGGER [fku_ApplePay_MandateId_Mandate_Id] BEFORE Update ON [ApplePay] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table ApplePay violates foreign key constraint FK_ApplePay_0_0') WHERE (SELECT Id FROM Mandate WHERE  Id = NEW.MandateId) IS NULL; END;
CREATE TRIGGER [fki_ApplePay_CardId_Card_Id] BEFORE Insert ON [ApplePay] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table ApplePay violates foreign key constraint FK_ApplePay_1_0') WHERE (SELECT Id FROM Card WHERE  Id = NEW.CardId) IS NULL; END;
CREATE TRIGGER [fku_ApplePay_CardId_Card_Id] BEFORE Update ON [ApplePay] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table ApplePay violates foreign key constraint FK_ApplePay_1_0') WHERE (SELECT Id FROM Card WHERE  Id = NEW.CardId) IS NULL; END;
CREATE TRIGGER [fki_AuBecsDebit_MandateId_Mandate_Id] BEFORE Insert ON [AuBecsDebit] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table AuBecsDebit violates foreign key constraint FK_AuBecsDebit_0_0') WHERE (SELECT Id FROM Mandate WHERE  Id = NEW.MandateId) IS NULL; END;
CREATE TRIGGER [fku_AuBecsDebit_MandateId_Mandate_Id] BEFORE Update ON [AuBecsDebit] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table AuBecsDebit violates foreign key constraint FK_AuBecsDebit_0_0') WHERE (SELECT Id FROM Mandate WHERE  Id = NEW.MandateId) IS NULL; END;
CREATE TRIGGER [fki_AutogiroDebit_MandateId_Mandate_Id] BEFORE Insert ON [AutogiroDebit] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table AutogiroDebit violates foreign key constraint FK_AutogiroDebit_0_0') WHERE (SELECT Id FROM Mandate WHERE  Id = NEW.MandateId) IS NULL; END;
CREATE TRIGGER [fku_AutogiroDebit_MandateId_Mandate_Id] BEFORE Update ON [AutogiroDebit] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table AutogiroDebit violates foreign key constraint FK_AutogiroDebit_0_0') WHERE (SELECT Id FROM Mandate WHERE  Id = NEW.MandateId) IS NULL; END;
CREATE TRIGGER [fki_BacsDebit_MandateId_Mandate_Id] BEFORE Insert ON [BacsDebit] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table BacsDebit violates foreign key constraint FK_BacsDebit_0_0') WHERE (SELECT Id FROM Mandate WHERE  Id = NEW.MandateId) IS NULL; END;
CREATE TRIGGER [fku_BacsDebit_MandateId_Mandate_Id] BEFORE Update ON [BacsDebit] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table BacsDebit violates foreign key constraint FK_BacsDebit_0_0') WHERE (SELECT Id FROM Mandate WHERE  Id = NEW.MandateId) IS NULL; END;
CREATE TRIGGER [fki_BetalingsDebit_MandateId_Mandate_Id] BEFORE Insert ON [BetalingsDebit] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table BetalingsDebit violates foreign key constraint FK_BetalingsDebit_0_0') WHERE (SELECT Id FROM Mandate WHERE  Id = NEW.MandateId) IS NULL; END;
CREATE TRIGGER [fku_BetalingsDebit_MandateId_Mandate_Id] BEFORE Update ON [BetalingsDebit] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table BetalingsDebit violates foreign key constraint FK_BetalingsDebit_0_0') WHERE (SELECT Id FROM Mandate WHERE  Id = NEW.MandateId) IS NULL; END;
CREATE TRIGGER [fki_BillingDetails_AddressId_AddressFieldDefinitions_Id] BEFORE Insert ON [BillingDetails] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table BillingDetails violates foreign key constraint FK_BillingDetails_0_0') WHERE (SELECT Id FROM AddressFieldDefinitions WHERE  Id = NEW.AddressId) IS NULL; END;
CREATE TRIGGER [fku_BillingDetails_AddressId_AddressFieldDefinitions_Id] BEFORE Update ON [BillingDetails] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table BillingDetails violates foreign key constraint FK_BillingDetails_0_0') WHERE (SELECT Id FROM AddressFieldDefinitions WHERE  Id = NEW.AddressId) IS NULL; END;
CREATE TRIGGER [fki_BillingDocumentItems_SubscriptionId1_Subscriptions_Id] BEFORE Insert ON [BillingDocumentItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table BillingDocumentItems violates foreign key constraint FK_BillingDocumentItems_0_0') WHERE (SELECT Id FROM Subscriptions WHERE  Id = NEW.SubscriptionId1) IS NULL; END;
CREATE TRIGGER [fku_BillingDocumentItems_SubscriptionId1_Subscriptions_Id] BEFORE Update ON [BillingDocumentItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table BillingDocumentItems violates foreign key constraint FK_BillingDocumentItems_0_0') WHERE (SELECT Id FROM Subscriptions WHERE  Id = NEW.SubscriptionId1) IS NULL; END;
CREATE TRIGGER [fki_BillingDocumentItems_SubscriptionItemId1_SubscriptionItems_Id] BEFORE Insert ON [BillingDocumentItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table BillingDocumentItems violates foreign key constraint FK_BillingDocumentItems_1_0') WHERE (SELECT Id FROM SubscriptionItems WHERE  Id = NEW.SubscriptionItemId1) IS NULL; END;
CREATE TRIGGER [fku_BillingDocumentItems_SubscriptionItemId1_SubscriptionItems_Id] BEFORE Update ON [BillingDocumentItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table BillingDocumentItems violates foreign key constraint FK_BillingDocumentItems_1_0') WHERE (SELECT Id FROM SubscriptionItems WHERE  Id = NEW.SubscriptionItemId1) IS NULL; END;
CREATE TRIGGER [fki_BillingDocumentItems_PaymentsAppliedToId_PaymentsAppliedTo_Id] BEFORE Insert ON [BillingDocumentItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table BillingDocumentItems violates foreign key constraint FK_BillingDocumentItems_2_0') WHERE NEW.PaymentsAppliedToId IS NOT NULL AND(SELECT Id FROM PaymentsAppliedTo WHERE  Id = NEW.PaymentsAppliedToId) IS NULL; END;
CREATE TRIGGER [fku_BillingDocumentItems_PaymentsAppliedToId_PaymentsAppliedTo_Id] BEFORE Update ON [BillingDocumentItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table BillingDocumentItems violates foreign key constraint FK_BillingDocumentItems_2_0') WHERE NEW.PaymentsAppliedToId IS NOT NULL AND(SELECT Id FROM PaymentsAppliedTo WHERE  Id = NEW.PaymentsAppliedToId) IS NULL; END;
CREATE TRIGGER [fki_BillingDocumentItems_CustomObjectsId_CustomObjects_Id] BEFORE Insert ON [BillingDocumentItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table BillingDocumentItems violates foreign key constraint FK_BillingDocumentItems_3_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fku_BillingDocumentItems_CustomObjectsId_CustomObjects_Id] BEFORE Update ON [BillingDocumentItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table BillingDocumentItems violates foreign key constraint FK_BillingDocumentItems_3_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fki_BillingDocumentItems_CustomFieldsId_CustomFields_Id] BEFORE Insert ON [BillingDocumentItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table BillingDocumentItems violates foreign key constraint FK_BillingDocumentItems_4_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fku_BillingDocumentItems_CustomFieldsId_CustomFields_Id] BEFORE Update ON [BillingDocumentItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table BillingDocumentItems violates foreign key constraint FK_BillingDocumentItems_4_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fki_BillingDocumentItems_BillingDocumentId1_BillingDocuments_Id] BEFORE Insert ON [BillingDocumentItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table BillingDocumentItems violates foreign key constraint FK_BillingDocumentItems_5_0') WHERE (SELECT Id FROM BillingDocuments WHERE  Id = NEW.BillingDocumentId1) IS NULL; END;
CREATE TRIGGER [fku_BillingDocumentItems_BillingDocumentId1_BillingDocuments_Id] BEFORE Update ON [BillingDocumentItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table BillingDocumentItems violates foreign key constraint FK_BillingDocumentItems_5_0') WHERE (SELECT Id FROM BillingDocuments WHERE  Id = NEW.BillingDocumentId1) IS NULL; END;
CREATE TRIGGER [fki_BillingDocuments_CustomObjectsId_CustomObjects_Id] BEFORE Insert ON [BillingDocuments] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table BillingDocuments violates foreign key constraint FK_BillingDocuments_0_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fku_BillingDocuments_CustomObjectsId_CustomObjects_Id] BEFORE Update ON [BillingDocuments] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table BillingDocuments violates foreign key constraint FK_BillingDocuments_0_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fki_BillingDocuments_CustomFieldsId_CustomFields_Id] BEFORE Insert ON [BillingDocuments] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table BillingDocuments violates foreign key constraint FK_BillingDocuments_1_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fku_BillingDocuments_CustomFieldsId_CustomFields_Id] BEFORE Update ON [BillingDocuments] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table BillingDocuments violates foreign key constraint FK_BillingDocuments_1_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fki_BillingDocumentSettings_CreditMemoId_CreditMemos_Id] BEFORE Insert ON [BillingDocumentSettings] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table BillingDocumentSettings violates foreign key constraint FK_BillingDocumentSettings_0_0') WHERE NEW.CreditMemoId IS NOT NULL AND(SELECT Id FROM CreditMemos WHERE  Id = NEW.CreditMemoId) IS NULL; END;
CREATE TRIGGER [fku_BillingDocumentSettings_CreditMemoId_CreditMemos_Id] BEFORE Update ON [BillingDocumentSettings] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table BillingDocumentSettings violates foreign key constraint FK_BillingDocumentSettings_0_0') WHERE NEW.CreditMemoId IS NOT NULL AND(SELECT Id FROM CreditMemos WHERE  Id = NEW.CreditMemoId) IS NULL; END;
CREATE TRIGGER [fki_BillingDocumentStateTransitions_BillingDocumentId_BillingDocuments_Id] BEFORE Insert ON [BillingDocumentStateTransitions] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table BillingDocumentStateTransitions violates foreign key constraint FK_BillingDocumentStateTransitions_0_0') WHERE NEW.BillingDocumentId IS NOT NULL AND(SELECT Id FROM BillingDocuments WHERE  Id = NEW.BillingDocumentId) IS NULL; END;
CREATE TRIGGER [fku_BillingDocumentStateTransitions_BillingDocumentId_BillingDocuments_Id] BEFORE Update ON [BillingDocumentStateTransitions] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table BillingDocumentStateTransitions violates foreign key constraint FK_BillingDocumentStateTransitions_0_0') WHERE NEW.BillingDocumentId IS NOT NULL AND(SELECT Id FROM BillingDocuments WHERE  Id = NEW.BillingDocumentId) IS NULL; END;
CREATE TRIGGER [fki_Card_MandateId_CardMandate_Id] BEFORE Insert ON [Card] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Card violates foreign key constraint FK_Card_0_0') WHERE (SELECT Id FROM CardMandate WHERE  Id = NEW.MandateId) IS NULL; END;
CREATE TRIGGER [fku_Card_MandateId_CardMandate_Id] BEFORE Update ON [Card] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Card violates foreign key constraint FK_Card_0_0') WHERE (SELECT Id FROM CardMandate WHERE  Id = NEW.MandateId) IS NULL; END;
CREATE TRIGGER [fki_CardMandate_CustomerAcceptanceId_CustomerAcceptanceMandate_Id] BEFORE Insert ON [CardMandate] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table CardMandate violates foreign key constraint FK_CardMandate_0_0') WHERE (SELECT Id FROM CustomerAcceptanceMandate WHERE  Id = NEW.CustomerAcceptanceId) IS NULL; END;
CREATE TRIGGER [fku_CardMandate_CustomerAcceptanceId_CustomerAcceptanceMandate_Id] BEFORE Update ON [CardMandate] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table CardMandate violates foreign key constraint FK_CardMandate_0_0') WHERE (SELECT Id FROM CustomerAcceptanceMandate WHERE  Id = NEW.CustomerAcceptanceId) IS NULL; END;
CREATE TRIGGER [fki_CcRef_MandateId_Mandate_Id] BEFORE Insert ON [CcRef] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table CcRef violates foreign key constraint FK_CcRef_0_0') WHERE (SELECT Id FROM Mandate WHERE  Id = NEW.MandateId) IS NULL; END;
CREATE TRIGGER [fku_CcRef_MandateId_Mandate_Id] BEFORE Update ON [CcRef] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table CcRef violates foreign key constraint FK_CcRef_0_0') WHERE (SELECT Id FROM Mandate WHERE  Id = NEW.MandateId) IS NULL; END;
CREATE TRIGGER [fki_CcRef_CardId_CcRefCard_Id] BEFORE Insert ON [CcRef] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table CcRef violates foreign key constraint FK_CcRef_1_0') WHERE (SELECT Id FROM CcRefCard WHERE  Id = NEW.CardId) IS NULL; END;
CREATE TRIGGER [fku_CcRef_CardId_CcRefCard_Id] BEFORE Update ON [CcRef] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table CcRef violates foreign key constraint FK_CcRef_1_0') WHERE (SELECT Id FROM CcRefCard WHERE  Id = NEW.CardId) IS NULL; END;
CREATE TRIGGER [fki_Contacts_CustomObjectsId_CustomObjects_Id] BEFORE Insert ON [Contacts] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Contacts violates foreign key constraint FK_Contacts_0_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fku_Contacts_CustomObjectsId_CustomObjects_Id] BEFORE Update ON [Contacts] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Contacts violates foreign key constraint FK_Contacts_0_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fki_Contacts_CustomFieldsId_CustomFields_Id] BEFORE Insert ON [Contacts] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Contacts violates foreign key constraint FK_Contacts_1_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fku_Contacts_CustomFieldsId_CustomFields_Id] BEFORE Update ON [Contacts] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Contacts violates foreign key constraint FK_Contacts_1_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fki_Contacts_AddressId_Address_Id] BEFORE Insert ON [Contacts] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Contacts violates foreign key constraint FK_Contacts_2_0') WHERE (SELECT Id FROM Address WHERE  Id = NEW.AddressId) IS NULL; END;
CREATE TRIGGER [fku_Contacts_AddressId_Address_Id] BEFORE Update ON [Contacts] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Contacts violates foreign key constraint FK_Contacts_2_0') WHERE (SELECT Id FROM Address WHERE  Id = NEW.AddressId) IS NULL; END;
CREATE TRIGGER [fki_CreditMemoAppliedTo_BillingDocumentId1_BillingDocuments_Id] BEFORE Insert ON [CreditMemoAppliedTo] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table CreditMemoAppliedTo violates foreign key constraint FK_CreditMemoAppliedTo_0_0') WHERE (SELECT Id FROM BillingDocuments WHERE  Id = NEW.BillingDocumentId1) IS NULL; END;
CREATE TRIGGER [fku_CreditMemoAppliedTo_BillingDocumentId1_BillingDocuments_Id] BEFORE Update ON [CreditMemoAppliedTo] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table CreditMemoAppliedTo violates foreign key constraint FK_CreditMemoAppliedTo_0_0') WHERE (SELECT Id FROM BillingDocuments WHERE  Id = NEW.BillingDocumentId1) IS NULL; END;
CREATE TRIGGER [fki_CreditMemoItems_SubscriptionId1_Subscriptions_Id] BEFORE Insert ON [CreditMemoItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table CreditMemoItems violates foreign key constraint FK_CreditMemoItems_0_0') WHERE (SELECT Id FROM Subscriptions WHERE  Id = NEW.SubscriptionId1) IS NULL; END;
CREATE TRIGGER [fku_CreditMemoItems_SubscriptionId1_Subscriptions_Id] BEFORE Update ON [CreditMemoItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table CreditMemoItems violates foreign key constraint FK_CreditMemoItems_0_0') WHERE (SELECT Id FROM Subscriptions WHERE  Id = NEW.SubscriptionId1) IS NULL; END;
CREATE TRIGGER [fki_CreditMemoItems_SubscriptionItemId1_SubscriptionItems_Id] BEFORE Insert ON [CreditMemoItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table CreditMemoItems violates foreign key constraint FK_CreditMemoItems_1_0') WHERE (SELECT Id FROM SubscriptionItems WHERE  Id = NEW.SubscriptionItemId1) IS NULL; END;
CREATE TRIGGER [fku_CreditMemoItems_SubscriptionItemId1_SubscriptionItems_Id] BEFORE Update ON [CreditMemoItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table CreditMemoItems violates foreign key constraint FK_CreditMemoItems_1_0') WHERE (SELECT Id FROM SubscriptionItems WHERE  Id = NEW.SubscriptionItemId1) IS NULL; END;
CREATE TRIGGER [fki_CreditMemoItems_CustomObjectsId_CustomObjects_Id] BEFORE Insert ON [CreditMemoItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table CreditMemoItems violates foreign key constraint FK_CreditMemoItems_2_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fku_CreditMemoItems_CustomObjectsId_CustomObjects_Id] BEFORE Update ON [CreditMemoItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table CreditMemoItems violates foreign key constraint FK_CreditMemoItems_2_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fki_CreditMemoItems_CustomFieldsId_CustomFields_Id] BEFORE Insert ON [CreditMemoItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table CreditMemoItems violates foreign key constraint FK_CreditMemoItems_3_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fku_CreditMemoItems_CustomFieldsId_CustomFields_Id] BEFORE Update ON [CreditMemoItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table CreditMemoItems violates foreign key constraint FK_CreditMemoItems_3_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fki_CreditMemoItems_CreditMemoId1_CreditMemos_Id] BEFORE Insert ON [CreditMemoItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table CreditMemoItems violates foreign key constraint FK_CreditMemoItems_4_0') WHERE (SELECT Id FROM CreditMemos WHERE  Id = NEW.CreditMemoId1) IS NULL; END;
CREATE TRIGGER [fku_CreditMemoItems_CreditMemoId1_CreditMemos_Id] BEFORE Update ON [CreditMemoItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table CreditMemoItems violates foreign key constraint FK_CreditMemoItems_4_0') WHERE (SELECT Id FROM CreditMemos WHERE  Id = NEW.CreditMemoId1) IS NULL; END;
CREATE TRIGGER [fki_CreditMemos_StateTransitionsId_StateTransitions_Id] BEFORE Insert ON [CreditMemos] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table CreditMemos violates foreign key constraint FK_CreditMemos_0_0') WHERE (SELECT Id FROM StateTransitions WHERE  Id = NEW.StateTransitionsId) IS NULL; END;
CREATE TRIGGER [fku_CreditMemos_StateTransitionsId_StateTransitions_Id] BEFORE Update ON [CreditMemos] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table CreditMemos violates foreign key constraint FK_CreditMemos_0_0') WHERE (SELECT Id FROM StateTransitions WHERE  Id = NEW.StateTransitionsId) IS NULL; END;
CREATE TRIGGER [fki_CreditMemos_CustomObjectsId_CustomObjects_Id] BEFORE Insert ON [CreditMemos] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table CreditMemos violates foreign key constraint FK_CreditMemos_1_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fku_CreditMemos_CustomObjectsId_CustomObjects_Id] BEFORE Update ON [CreditMemos] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table CreditMemos violates foreign key constraint FK_CreditMemos_1_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fki_CreditMemos_CustomFieldsId_CustomFields_Id] BEFORE Insert ON [CreditMemos] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table CreditMemos violates foreign key constraint FK_CreditMemos_2_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fku_CreditMemos_CustomFieldsId_CustomFields_Id] BEFORE Update ON [CreditMemos] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table CreditMemos violates foreign key constraint FK_CreditMemos_2_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fki_CreditMemos_CreditMemoId_CreditMemos_Id] BEFORE Insert ON [CreditMemos] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table CreditMemos violates foreign key constraint FK_CreditMemos_3_0') WHERE NEW.CreditMemoId IS NOT NULL AND(SELECT Id FROM CreditMemos WHERE  Id = NEW.CreditMemoId) IS NULL; END;
CREATE TRIGGER [fku_CreditMemos_CreditMemoId_CreditMemos_Id] BEFORE Update ON [CreditMemos] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table CreditMemos violates foreign key constraint FK_CreditMemos_3_0') WHERE NEW.CreditMemoId IS NOT NULL AND(SELECT Id FROM CreditMemos WHERE  Id = NEW.CreditMemoId) IS NULL; END;
CREATE TRIGGER [fki_CreditMemos_BillToId1_Contacts_Id] BEFORE Insert ON [CreditMemos] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table CreditMemos violates foreign key constraint FK_CreditMemos_4_0') WHERE (SELECT Id FROM Contacts WHERE  Id = NEW.BillToId1) IS NULL; END;
CREATE TRIGGER [fku_CreditMemos_BillToId1_Contacts_Id] BEFORE Update ON [CreditMemos] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table CreditMemos violates foreign key constraint FK_CreditMemos_4_0') WHERE (SELECT Id FROM Contacts WHERE  Id = NEW.BillToId1) IS NULL; END;
CREATE TRIGGER [fki_CreditMemos_ArTransactionsId_ArTransactions_Id] BEFORE Insert ON [CreditMemos] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table CreditMemos violates foreign key constraint FK_CreditMemos_5_0') WHERE NEW.ArTransactionsId IS NOT NULL AND(SELECT Id FROM ArTransactions WHERE  Id = NEW.ArTransactionsId) IS NULL; END;
CREATE TRIGGER [fku_CreditMemos_ArTransactionsId_ArTransactions_Id] BEFORE Update ON [CreditMemos] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table CreditMemos violates foreign key constraint FK_CreditMemos_5_0') WHERE NEW.ArTransactionsId IS NOT NULL AND(SELECT Id FROM ArTransactions WHERE  Id = NEW.ArTransactionsId) IS NULL; END;
CREATE TRIGGER [fki_CreditMemos_AccountId1_Accounts_Id] BEFORE Insert ON [CreditMemos] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table CreditMemos violates foreign key constraint FK_CreditMemos_6_0') WHERE (SELECT Id FROM Accounts WHERE  Id = NEW.AccountId1) IS NULL; END;
CREATE TRIGGER [fku_CreditMemos_AccountId1_Accounts_Id] BEFORE Update ON [CreditMemos] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table CreditMemos violates foreign key constraint FK_CreditMemos_6_0') WHERE (SELECT Id FROM Accounts WHERE  Id = NEW.AccountId1) IS NULL; END;
CREATE TRIGGER [fki_DebitMemoItems_SubscriptionId1_Subscriptions_Id] BEFORE Insert ON [DebitMemoItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table DebitMemoItems violates foreign key constraint FK_DebitMemoItems_0_0') WHERE (SELECT Id FROM Subscriptions WHERE  Id = NEW.SubscriptionId1) IS NULL; END;
CREATE TRIGGER [fku_DebitMemoItems_SubscriptionId1_Subscriptions_Id] BEFORE Update ON [DebitMemoItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table DebitMemoItems violates foreign key constraint FK_DebitMemoItems_0_0') WHERE (SELECT Id FROM Subscriptions WHERE  Id = NEW.SubscriptionId1) IS NULL; END;
CREATE TRIGGER [fki_DebitMemoItems_SubscriptionItemId1_SubscriptionItems_Id] BEFORE Insert ON [DebitMemoItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table DebitMemoItems violates foreign key constraint FK_DebitMemoItems_1_0') WHERE (SELECT Id FROM SubscriptionItems WHERE  Id = NEW.SubscriptionItemId1) IS NULL; END;
CREATE TRIGGER [fku_DebitMemoItems_SubscriptionItemId1_SubscriptionItems_Id] BEFORE Update ON [DebitMemoItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table DebitMemoItems violates foreign key constraint FK_DebitMemoItems_1_0') WHERE (SELECT Id FROM SubscriptionItems WHERE  Id = NEW.SubscriptionItemId1) IS NULL; END;
CREATE TRIGGER [fki_DebitMemoItems_DebitMemoId1_DebitMemos_Id] BEFORE Insert ON [DebitMemoItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table DebitMemoItems violates foreign key constraint FK_DebitMemoItems_2_0') WHERE (SELECT Id FROM DebitMemos WHERE  Id = NEW.DebitMemoId1) IS NULL; END;
CREATE TRIGGER [fku_DebitMemoItems_DebitMemoId1_DebitMemos_Id] BEFORE Update ON [DebitMemoItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table DebitMemoItems violates foreign key constraint FK_DebitMemoItems_2_0') WHERE (SELECT Id FROM DebitMemos WHERE  Id = NEW.DebitMemoId1) IS NULL; END;
CREATE TRIGGER [fki_DebitMemoItems_CustomObjectsId_CustomObjects_Id] BEFORE Insert ON [DebitMemoItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table DebitMemoItems violates foreign key constraint FK_DebitMemoItems_3_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fku_DebitMemoItems_CustomObjectsId_CustomObjects_Id] BEFORE Update ON [DebitMemoItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table DebitMemoItems violates foreign key constraint FK_DebitMemoItems_3_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fki_DebitMemoItems_CustomFieldsId_CustomFields_Id] BEFORE Insert ON [DebitMemoItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table DebitMemoItems violates foreign key constraint FK_DebitMemoItems_4_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fku_DebitMemoItems_CustomFieldsId_CustomFields_Id] BEFORE Update ON [DebitMemoItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table DebitMemoItems violates foreign key constraint FK_DebitMemoItems_4_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fki_DebitMemos_StateTransitionsId_StateTransitions_Id] BEFORE Insert ON [DebitMemos] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table DebitMemos violates foreign key constraint FK_DebitMemos_0_0') WHERE (SELECT Id FROM StateTransitions WHERE  Id = NEW.StateTransitionsId) IS NULL; END;
CREATE TRIGGER [fku_DebitMemos_StateTransitionsId_StateTransitions_Id] BEFORE Update ON [DebitMemos] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table DebitMemos violates foreign key constraint FK_DebitMemos_0_0') WHERE (SELECT Id FROM StateTransitions WHERE  Id = NEW.StateTransitionsId) IS NULL; END;
CREATE TRIGGER [fki_DebitMemos_CustomObjectsId_CustomObjects_Id] BEFORE Insert ON [DebitMemos] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table DebitMemos violates foreign key constraint FK_DebitMemos_1_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fku_DebitMemos_CustomObjectsId_CustomObjects_Id] BEFORE Update ON [DebitMemos] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table DebitMemos violates foreign key constraint FK_DebitMemos_1_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fki_DebitMemos_CustomFieldsId_CustomFields_Id] BEFORE Insert ON [DebitMemos] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table DebitMemos violates foreign key constraint FK_DebitMemos_2_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fku_DebitMemos_CustomFieldsId_CustomFields_Id] BEFORE Update ON [DebitMemos] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table DebitMemos violates foreign key constraint FK_DebitMemos_2_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fki_DebitMemos_BillToId1_Contacts_Id] BEFORE Insert ON [DebitMemos] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table DebitMemos violates foreign key constraint FK_DebitMemos_3_0') WHERE (SELECT Id FROM Contacts WHERE  Id = NEW.BillToId1) IS NULL; END;
CREATE TRIGGER [fku_DebitMemos_BillToId1_Contacts_Id] BEFORE Update ON [DebitMemos] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table DebitMemos violates foreign key constraint FK_DebitMemos_3_0') WHERE (SELECT Id FROM Contacts WHERE  Id = NEW.BillToId1) IS NULL; END;
CREATE TRIGGER [fki_DebitMemos_BillingDocumentSettingsId_BillingDocumentSettings_Id] BEFORE Insert ON [DebitMemos] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table DebitMemos violates foreign key constraint FK_DebitMemos_4_0') WHERE (SELECT Id FROM BillingDocumentSettings WHERE  Id = NEW.BillingDocumentSettingsId) IS NULL; END;
CREATE TRIGGER [fku_DebitMemos_BillingDocumentSettingsId_BillingDocumentSettings_Id] BEFORE Update ON [DebitMemos] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table DebitMemos violates foreign key constraint FK_DebitMemos_4_0') WHERE (SELECT Id FROM BillingDocumentSettings WHERE  Id = NEW.BillingDocumentSettingsId) IS NULL; END;
CREATE TRIGGER [fki_DebitMemos_AccountId1_Accounts_Id] BEFORE Insert ON [DebitMemos] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table DebitMemos violates foreign key constraint FK_DebitMemos_5_0') WHERE (SELECT Id FROM Accounts WHERE  Id = NEW.AccountId1) IS NULL; END;
CREATE TRIGGER [fku_DebitMemos_AccountId1_Accounts_Id] BEFORE Update ON [DebitMemos] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table DebitMemos violates foreign key constraint FK_DebitMemos_5_0') WHERE (SELECT Id FROM Accounts WHERE  Id = NEW.AccountId1) IS NULL; END;
CREATE TRIGGER [fki_GetCardList_MandateId_Mandate_Id] BEFORE Insert ON [GetCardList] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table GetCardList violates foreign key constraint FK_GetCardList_0_0') WHERE (SELECT Id FROM Mandate WHERE  Id = NEW.MandateId) IS NULL; END;
CREATE TRIGGER [fku_GetCardList_MandateId_Mandate_Id] BEFORE Update ON [GetCardList] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table GetCardList violates foreign key constraint FK_GetCardList_0_0') WHERE (SELECT Id FROM Mandate WHERE  Id = NEW.MandateId) IS NULL; END;
CREATE TRIGGER [fki_GooglePay_CardId_Card_Id] BEFORE Insert ON [GooglePay] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table GooglePay violates foreign key constraint FK_GooglePay_0_0') WHERE (SELECT Id FROM Card WHERE  Id = NEW.CardId) IS NULL; END;
CREATE TRIGGER [fku_GooglePay_CardId_Card_Id] BEFORE Update ON [GooglePay] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table GooglePay violates foreign key constraint FK_GooglePay_0_0') WHERE (SELECT Id FROM Card WHERE  Id = NEW.CardId) IS NULL; END;
CREATE TRIGGER [fki_InvoiceItems_SubscriptionId1_Subscriptions_Id] BEFORE Insert ON [InvoiceItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table InvoiceItems violates foreign key constraint FK_InvoiceItems_0_0') WHERE (SELECT Id FROM Subscriptions WHERE  Id = NEW.SubscriptionId1) IS NULL; END;
CREATE TRIGGER [fku_InvoiceItems_SubscriptionId1_Subscriptions_Id] BEFORE Update ON [InvoiceItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table InvoiceItems violates foreign key constraint FK_InvoiceItems_0_0') WHERE (SELECT Id FROM Subscriptions WHERE  Id = NEW.SubscriptionId1) IS NULL; END;
CREATE TRIGGER [fki_InvoiceItems_SubscriptionItemId1_SubscriptionItems_Id] BEFORE Insert ON [InvoiceItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table InvoiceItems violates foreign key constraint FK_InvoiceItems_1_0') WHERE (SELECT Id FROM SubscriptionItems WHERE  Id = NEW.SubscriptionItemId1) IS NULL; END;
CREATE TRIGGER [fku_InvoiceItems_SubscriptionItemId1_SubscriptionItems_Id] BEFORE Update ON [InvoiceItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table InvoiceItems violates foreign key constraint FK_InvoiceItems_1_0') WHERE (SELECT Id FROM SubscriptionItems WHERE  Id = NEW.SubscriptionItemId1) IS NULL; END;
CREATE TRIGGER [fki_InvoiceItems_LineItemId_OrderLineItems_Id] BEFORE Insert ON [InvoiceItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table InvoiceItems violates foreign key constraint FK_InvoiceItems_2_0') WHERE (SELECT Id FROM OrderLineItems WHERE  Id = NEW.LineItemId) IS NULL; END;
CREATE TRIGGER [fku_InvoiceItems_LineItemId_OrderLineItems_Id] BEFORE Update ON [InvoiceItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table InvoiceItems violates foreign key constraint FK_InvoiceItems_2_0') WHERE (SELECT Id FROM OrderLineItems WHERE  Id = NEW.LineItemId) IS NULL; END;
CREATE TRIGGER [fki_InvoiceItems_InvoiceId1_Invoices_Id] BEFORE Insert ON [InvoiceItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table InvoiceItems violates foreign key constraint FK_InvoiceItems_3_0') WHERE (SELECT Id FROM Invoices WHERE  Id = NEW.InvoiceId1) IS NULL; END;
CREATE TRIGGER [fku_InvoiceItems_InvoiceId1_Invoices_Id] BEFORE Update ON [InvoiceItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table InvoiceItems violates foreign key constraint FK_InvoiceItems_3_0') WHERE (SELECT Id FROM Invoices WHERE  Id = NEW.InvoiceId1) IS NULL; END;
CREATE TRIGGER [fki_InvoiceItems_CustomObjectsId_CustomObjects_Id] BEFORE Insert ON [InvoiceItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table InvoiceItems violates foreign key constraint FK_InvoiceItems_4_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fku_InvoiceItems_CustomObjectsId_CustomObjects_Id] BEFORE Update ON [InvoiceItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table InvoiceItems violates foreign key constraint FK_InvoiceItems_4_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fki_InvoiceItems_CustomFieldsId_CustomFields_Id] BEFORE Insert ON [InvoiceItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table InvoiceItems violates foreign key constraint FK_InvoiceItems_5_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fku_InvoiceItems_CustomFieldsId_CustomFields_Id] BEFORE Update ON [InvoiceItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table InvoiceItems violates foreign key constraint FK_InvoiceItems_5_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fki_Invoices_StateTransitionsId_StateTransitions_Id] BEFORE Insert ON [Invoices] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Invoices violates foreign key constraint FK_Invoices_0_0') WHERE (SELECT Id FROM StateTransitions WHERE  Id = NEW.StateTransitionsId) IS NULL; END;
CREATE TRIGGER [fku_Invoices_StateTransitionsId_StateTransitions_Id] BEFORE Update ON [Invoices] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Invoices violates foreign key constraint FK_Invoices_0_0') WHERE (SELECT Id FROM StateTransitions WHERE  Id = NEW.StateTransitionsId) IS NULL; END;
CREATE TRIGGER [fki_Invoices_CustomObjectsId_CustomObjects_Id] BEFORE Insert ON [Invoices] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Invoices violates foreign key constraint FK_Invoices_1_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fku_Invoices_CustomObjectsId_CustomObjects_Id] BEFORE Update ON [Invoices] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Invoices violates foreign key constraint FK_Invoices_1_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fki_Invoices_CustomFieldsId_CustomFields_Id] BEFORE Insert ON [Invoices] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Invoices violates foreign key constraint FK_Invoices_2_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fku_Invoices_CustomFieldsId_CustomFields_Id] BEFORE Update ON [Invoices] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Invoices violates foreign key constraint FK_Invoices_2_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fki_Invoices_SoldToId1_Contacts_Id] BEFORE Insert ON [Invoices] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Invoices violates foreign key constraint FK_Invoices_3_0') WHERE (SELECT Id FROM Contacts WHERE  Id = NEW.SoldToId1) IS NULL; END;
CREATE TRIGGER [fku_Invoices_SoldToId1_Contacts_Id] BEFORE Update ON [Invoices] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Invoices violates foreign key constraint FK_Invoices_3_0') WHERE (SELECT Id FROM Contacts WHERE  Id = NEW.SoldToId1) IS NULL; END;
CREATE TRIGGER [fki_Invoices_BillToId1_Contacts_Id] BEFORE Insert ON [Invoices] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Invoices violates foreign key constraint FK_Invoices_4_0') WHERE (SELECT Id FROM Contacts WHERE  Id = NEW.BillToId1) IS NULL; END;
CREATE TRIGGER [fku_Invoices_BillToId1_Contacts_Id] BEFORE Update ON [Invoices] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Invoices violates foreign key constraint FK_Invoices_4_0') WHERE (SELECT Id FROM Contacts WHERE  Id = NEW.BillToId1) IS NULL; END;
CREATE TRIGGER [fki_Invoices_BillingDocumentSettingsId_BillingDocumentSettings_Id] BEFORE Insert ON [Invoices] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Invoices violates foreign key constraint FK_Invoices_5_0') WHERE (SELECT Id FROM BillingDocumentSettings WHERE  Id = NEW.BillingDocumentSettingsId) IS NULL; END;
CREATE TRIGGER [fku_Invoices_BillingDocumentSettingsId_BillingDocumentSettings_Id] BEFORE Update ON [Invoices] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Invoices violates foreign key constraint FK_Invoices_5_0') WHERE (SELECT Id FROM BillingDocumentSettings WHERE  Id = NEW.BillingDocumentSettingsId) IS NULL; END;
CREATE TRIGGER [fki_Invoices_ArTransactionsId_ArTransactions_Id] BEFORE Insert ON [Invoices] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Invoices violates foreign key constraint FK_Invoices_6_0') WHERE NEW.ArTransactionsId IS NOT NULL AND(SELECT Id FROM ArTransactions WHERE  Id = NEW.ArTransactionsId) IS NULL; END;
CREATE TRIGGER [fku_Invoices_ArTransactionsId_ArTransactions_Id] BEFORE Update ON [Invoices] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Invoices violates foreign key constraint FK_Invoices_6_0') WHERE NEW.ArTransactionsId IS NOT NULL AND(SELECT Id FROM ArTransactions WHERE  Id = NEW.ArTransactionsId) IS NULL; END;
CREATE TRIGGER [fki_Invoices_AccountId1_Accounts_Id] BEFORE Insert ON [Invoices] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Invoices violates foreign key constraint FK_Invoices_7_0') WHERE (SELECT Id FROM Accounts WHERE  Id = NEW.AccountId1) IS NULL; END;
CREATE TRIGGER [fku_Invoices_AccountId1_Accounts_Id] BEFORE Update ON [Invoices] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Invoices violates foreign key constraint FK_Invoices_7_0') WHERE (SELECT Id FROM Accounts WHERE  Id = NEW.AccountId1) IS NULL; END;
CREATE TRIGGER [fki_ItemTier_SubscriptionItemId_SubscriptionItems_Id] BEFORE Insert ON [ItemTier] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table ItemTier violates foreign key constraint FK_ItemTier_0_0') WHERE NEW.SubscriptionItemId IS NOT NULL AND(SELECT Id FROM SubscriptionItems WHERE  Id = NEW.SubscriptionItemId) IS NULL; END;
CREATE TRIGGER [fku_ItemTier_SubscriptionItemId_SubscriptionItems_Id] BEFORE Update ON [ItemTier] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table ItemTier violates foreign key constraint FK_ItemTier_0_0') WHERE NEW.SubscriptionItemId IS NOT NULL AND(SELECT Id FROM SubscriptionItems WHERE  Id = NEW.SubscriptionItemId) IS NULL; END;
CREATE TRIGGER [fki_NzBecsDebit_MandateId_Mandate_Id] BEFORE Insert ON [NzBecsDebit] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table NzBecsDebit violates foreign key constraint FK_NzBecsDebit_0_0') WHERE (SELECT Id FROM Mandate WHERE  Id = NEW.MandateId) IS NULL; END;
CREATE TRIGGER [fku_NzBecsDebit_MandateId_Mandate_Id] BEFORE Update ON [NzBecsDebit] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table NzBecsDebit violates foreign key constraint FK_NzBecsDebit_0_0') WHERE (SELECT Id FROM Mandate WHERE  Id = NEW.MandateId) IS NULL; END;
CREATE TRIGGER [fki_Order_CustomObjectsId_CustomObjects_Id] BEFORE Insert ON [Order] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Order violates foreign key constraint FK_Order_0_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fku_Order_CustomObjectsId_CustomObjects_Id] BEFORE Update ON [Order] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Order violates foreign key constraint FK_Order_0_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fki_Order_CustomFieldsId_CustomFields_Id] BEFORE Insert ON [Order] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Order violates foreign key constraint FK_Order_1_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fku_Order_CustomFieldsId_CustomFields_Id] BEFORE Update ON [Order] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Order violates foreign key constraint FK_Order_1_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fki_Order_AccountId1_Accounts_Id] BEFORE Insert ON [Order] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Order violates foreign key constraint FK_Order_2_0') WHERE (SELECT Id FROM Accounts WHERE  Id = NEW.AccountId1) IS NULL; END;
CREATE TRIGGER [fku_Order_AccountId1_Accounts_Id] BEFORE Update ON [Order] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Order violates foreign key constraint FK_Order_2_0') WHERE (SELECT Id FROM Accounts WHERE  Id = NEW.AccountId1) IS NULL; END;
CREATE TRIGGER [fki_OrderLineItems_OrderId1_Order_Id] BEFORE Insert ON [OrderLineItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table OrderLineItems violates foreign key constraint FK_OrderLineItems_0_0') WHERE NEW.OrderId1 IS NOT NULL AND(SELECT Id FROM Order WHERE  Id = NEW.OrderId1) IS NULL; END;
CREATE TRIGGER [fku_OrderLineItems_OrderId1_Order_Id] BEFORE Update ON [OrderLineItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table OrderLineItems violates foreign key constraint FK_OrderLineItems_0_0') WHERE NEW.OrderId1 IS NOT NULL AND(SELECT Id FROM Order WHERE  Id = NEW.OrderId1) IS NULL; END;
CREATE TRIGGER [fki_OrderLineItems_RevenueId_OrderLineItemRevenue_Id] BEFORE Insert ON [OrderLineItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table OrderLineItems violates foreign key constraint FK_OrderLineItems_1_0') WHERE (SELECT Id FROM OrderLineItemRevenue WHERE  Id = NEW.RevenueId) IS NULL; END;
CREATE TRIGGER [fku_OrderLineItems_RevenueId_OrderLineItemRevenue_Id] BEFORE Update ON [OrderLineItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table OrderLineItems violates foreign key constraint FK_OrderLineItems_1_0') WHERE (SELECT Id FROM OrderLineItemRevenue WHERE  Id = NEW.RevenueId) IS NULL; END;
CREATE TRIGGER [fki_OrderLineItems_CustomObjectsId_CustomObjects_Id] BEFORE Insert ON [OrderLineItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table OrderLineItems violates foreign key constraint FK_OrderLineItems_2_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fku_OrderLineItems_CustomObjectsId_CustomObjects_Id] BEFORE Update ON [OrderLineItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table OrderLineItems violates foreign key constraint FK_OrderLineItems_2_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fki_OrderLineItems_CustomFieldsId_CustomFields_Id] BEFORE Insert ON [OrderLineItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table OrderLineItems violates foreign key constraint FK_OrderLineItems_3_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fku_OrderLineItems_CustomFieldsId_CustomFields_Id] BEFORE Update ON [OrderLineItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table OrderLineItems violates foreign key constraint FK_OrderLineItems_3_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fki_PadDebit_MandateId_Mandate_Id] BEFORE Insert ON [PadDebit] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table PadDebit violates foreign key constraint FK_PadDebit_0_0') WHERE (SELECT Id FROM Mandate WHERE  Id = NEW.MandateId) IS NULL; END;
CREATE TRIGGER [fku_PadDebit_MandateId_Mandate_Id] BEFORE Update ON [PadDebit] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table PadDebit violates foreign key constraint FK_PadDebit_0_0') WHERE (SELECT Id FROM Mandate WHERE  Id = NEW.MandateId) IS NULL; END;
CREATE TRIGGER [fki_PaymentMethods_SepaDebitId_SepaDebit_Id] BEFORE Insert ON [PaymentMethods] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table PaymentMethods violates foreign key constraint FK_PaymentMethods_0_0') WHERE (SELECT Id FROM SepaDebit WHERE  Id = NEW.SepaDebitId) IS NULL; END;
CREATE TRIGGER [fku_PaymentMethods_SepaDebitId_SepaDebit_Id] BEFORE Update ON [PaymentMethods] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table PaymentMethods violates foreign key constraint FK_PaymentMethods_0_0') WHERE (SELECT Id FROM SepaDebit WHERE  Id = NEW.SepaDebitId) IS NULL; END;
CREATE TRIGGER [fki_PaymentMethods_PaypalExpressId_PaypalExpress_Id] BEFORE Insert ON [PaymentMethods] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table PaymentMethods violates foreign key constraint FK_PaymentMethods_1_0') WHERE (SELECT Id FROM PaypalExpress WHERE  Id = NEW.PaypalExpressId) IS NULL; END;
CREATE TRIGGER [fku_PaymentMethods_PaypalExpressId_PaypalExpress_Id] BEFORE Update ON [PaymentMethods] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table PaymentMethods violates foreign key constraint FK_PaymentMethods_1_0') WHERE (SELECT Id FROM PaypalExpress WHERE  Id = NEW.PaypalExpressId) IS NULL; END;
CREATE TRIGGER [fki_PaymentMethods_PaypalExpressNativeId_PaypalExpressNative_Id] BEFORE Insert ON [PaymentMethods] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table PaymentMethods violates foreign key constraint FK_PaymentMethods_2_0') WHERE (SELECT Id FROM PaypalExpressNative WHERE  Id = NEW.PaypalExpressNativeId) IS NULL; END;
CREATE TRIGGER [fku_PaymentMethods_PaypalExpressNativeId_PaypalExpressNative_Id] BEFORE Update ON [PaymentMethods] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table PaymentMethods violates foreign key constraint FK_PaymentMethods_2_0') WHERE (SELECT Id FROM PaypalExpressNative WHERE  Id = NEW.PaypalExpressNativeId) IS NULL; END;
CREATE TRIGGER [fki_PaymentMethods_PaypalAdaptiveId_PaypalAdaptive_Id] BEFORE Insert ON [PaymentMethods] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table PaymentMethods violates foreign key constraint FK_PaymentMethods_3_0') WHERE (SELECT Id FROM PaypalAdaptive WHERE  Id = NEW.PaypalAdaptiveId) IS NULL; END;
CREATE TRIGGER [fku_PaymentMethods_PaypalAdaptiveId_PaypalAdaptive_Id] BEFORE Update ON [PaymentMethods] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table PaymentMethods violates foreign key constraint FK_PaymentMethods_3_0') WHERE (SELECT Id FROM PaypalAdaptive WHERE  Id = NEW.PaypalAdaptiveId) IS NULL; END;
CREATE TRIGGER [fki_PaymentMethods_PadDebitId_PadDebit_Id] BEFORE Insert ON [PaymentMethods] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table PaymentMethods violates foreign key constraint FK_PaymentMethods_4_0') WHERE (SELECT Id FROM PadDebit WHERE  Id = NEW.PadDebitId) IS NULL; END;
CREATE TRIGGER [fku_PaymentMethods_PadDebitId_PadDebit_Id] BEFORE Update ON [PaymentMethods] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table PaymentMethods violates foreign key constraint FK_PaymentMethods_4_0') WHERE (SELECT Id FROM PadDebit WHERE  Id = NEW.PadDebitId) IS NULL; END;
CREATE TRIGGER [fki_PaymentMethods_NzBecsDebitId_NzBecsDebit_Id] BEFORE Insert ON [PaymentMethods] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table PaymentMethods violates foreign key constraint FK_PaymentMethods_5_0') WHERE (SELECT Id FROM NzBecsDebit WHERE  Id = NEW.NzBecsDebitId) IS NULL; END;
CREATE TRIGGER [fku_PaymentMethods_NzBecsDebitId_NzBecsDebit_Id] BEFORE Update ON [PaymentMethods] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table PaymentMethods violates foreign key constraint FK_PaymentMethods_5_0') WHERE (SELECT Id FROM NzBecsDebit WHERE  Id = NEW.NzBecsDebitId) IS NULL; END;
CREATE TRIGGER [fki_PaymentMethods_GooglePayId_GooglePay_Id] BEFORE Insert ON [PaymentMethods] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table PaymentMethods violates foreign key constraint FK_PaymentMethods_6_0') WHERE (SELECT Id FROM GooglePay WHERE  Id = NEW.GooglePayId) IS NULL; END;
CREATE TRIGGER [fku_PaymentMethods_GooglePayId_GooglePay_Id] BEFORE Update ON [PaymentMethods] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table PaymentMethods violates foreign key constraint FK_PaymentMethods_6_0') WHERE (SELECT Id FROM GooglePay WHERE  Id = NEW.GooglePayId) IS NULL; END;
CREATE TRIGGER [fki_PaymentMethods_CardId_GetCardList_Id] BEFORE Insert ON [PaymentMethods] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table PaymentMethods violates foreign key constraint FK_PaymentMethods_7_0') WHERE (SELECT Id FROM GetCardList WHERE  Id = NEW.CardId) IS NULL; END;
CREATE TRIGGER [fku_PaymentMethods_CardId_GetCardList_Id] BEFORE Update ON [PaymentMethods] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table PaymentMethods violates foreign key constraint FK_PaymentMethods_7_0') WHERE (SELECT Id FROM GetCardList WHERE  Id = NEW.CardId) IS NULL; END;
CREATE TRIGGER [fki_PaymentMethods_CustomObjectsId_CustomObjects_Id] BEFORE Insert ON [PaymentMethods] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table PaymentMethods violates foreign key constraint FK_PaymentMethods_8_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fku_PaymentMethods_CustomObjectsId_CustomObjects_Id] BEFORE Update ON [PaymentMethods] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table PaymentMethods violates foreign key constraint FK_PaymentMethods_8_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fki_PaymentMethods_CustomFieldsId_CustomFields_Id] BEFORE Insert ON [PaymentMethods] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table PaymentMethods violates foreign key constraint FK_PaymentMethods_9_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fku_PaymentMethods_CustomFieldsId_CustomFields_Id] BEFORE Update ON [PaymentMethods] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table PaymentMethods violates foreign key constraint FK_PaymentMethods_9_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fki_PaymentMethods_CcRefId_CcRef_Id] BEFORE Insert ON [PaymentMethods] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table PaymentMethods violates foreign key constraint FK_PaymentMethods_10_0') WHERE (SELECT Id FROM CcRef WHERE  Id = NEW.CcRefId) IS NULL; END;
CREATE TRIGGER [fku_PaymentMethods_CcRefId_CcRef_Id] BEFORE Update ON [PaymentMethods] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table PaymentMethods violates foreign key constraint FK_PaymentMethods_10_0') WHERE (SELECT Id FROM CcRef WHERE  Id = NEW.CcRefId) IS NULL; END;
CREATE TRIGGER [fki_PaymentMethods_BillingDetailsId_BillingDetails_Id] BEFORE Insert ON [PaymentMethods] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table PaymentMethods violates foreign key constraint FK_PaymentMethods_11_0') WHERE (SELECT Id FROM BillingDetails WHERE  Id = NEW.BillingDetailsId) IS NULL; END;
CREATE TRIGGER [fku_PaymentMethods_BillingDetailsId_BillingDetails_Id] BEFORE Update ON [PaymentMethods] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table PaymentMethods violates foreign key constraint FK_PaymentMethods_11_0') WHERE (SELECT Id FROM BillingDetails WHERE  Id = NEW.BillingDetailsId) IS NULL; END;
CREATE TRIGGER [fki_PaymentMethods_BetalingsDebitId_BetalingsDebit_Id] BEFORE Insert ON [PaymentMethods] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table PaymentMethods violates foreign key constraint FK_PaymentMethods_12_0') WHERE (SELECT Id FROM BetalingsDebit WHERE  Id = NEW.BetalingsDebitId) IS NULL; END;
CREATE TRIGGER [fku_PaymentMethods_BetalingsDebitId_BetalingsDebit_Id] BEFORE Update ON [PaymentMethods] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table PaymentMethods violates foreign key constraint FK_PaymentMethods_12_0') WHERE (SELECT Id FROM BetalingsDebit WHERE  Id = NEW.BetalingsDebitId) IS NULL; END;
CREATE TRIGGER [fki_PaymentMethods_BacsDebitId_BacsDebit_Id] BEFORE Insert ON [PaymentMethods] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table PaymentMethods violates foreign key constraint FK_PaymentMethods_13_0') WHERE (SELECT Id FROM BacsDebit WHERE  Id = NEW.BacsDebitId) IS NULL; END;
CREATE TRIGGER [fku_PaymentMethods_BacsDebitId_BacsDebit_Id] BEFORE Update ON [PaymentMethods] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table PaymentMethods violates foreign key constraint FK_PaymentMethods_13_0') WHERE (SELECT Id FROM BacsDebit WHERE  Id = NEW.BacsDebitId) IS NULL; END;
CREATE TRIGGER [fki_PaymentMethods_AutogiroDebitId_AutogiroDebit_Id] BEFORE Insert ON [PaymentMethods] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table PaymentMethods violates foreign key constraint FK_PaymentMethods_14_0') WHERE (SELECT Id FROM AutogiroDebit WHERE  Id = NEW.AutogiroDebitId) IS NULL; END;
CREATE TRIGGER [fku_PaymentMethods_AutogiroDebitId_AutogiroDebit_Id] BEFORE Update ON [PaymentMethods] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table PaymentMethods violates foreign key constraint FK_PaymentMethods_14_0') WHERE (SELECT Id FROM AutogiroDebit WHERE  Id = NEW.AutogiroDebitId) IS NULL; END;
CREATE TRIGGER [fki_PaymentMethods_AuBecsDebitId_AuBecsDebit_Id] BEFORE Insert ON [PaymentMethods] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table PaymentMethods violates foreign key constraint FK_PaymentMethods_15_0') WHERE (SELECT Id FROM AuBecsDebit WHERE  Id = NEW.AuBecsDebitId) IS NULL; END;
CREATE TRIGGER [fku_PaymentMethods_AuBecsDebitId_AuBecsDebit_Id] BEFORE Update ON [PaymentMethods] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table PaymentMethods violates foreign key constraint FK_PaymentMethods_15_0') WHERE (SELECT Id FROM AuBecsDebit WHERE  Id = NEW.AuBecsDebitId) IS NULL; END;
CREATE TRIGGER [fki_PaymentMethods_ApplePayId_ApplePay_Id] BEFORE Insert ON [PaymentMethods] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table PaymentMethods violates foreign key constraint FK_PaymentMethods_16_0') WHERE (SELECT Id FROM ApplePay WHERE  Id = NEW.ApplePayId) IS NULL; END;
CREATE TRIGGER [fku_PaymentMethods_ApplePayId_ApplePay_Id] BEFORE Update ON [PaymentMethods] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table PaymentMethods violates foreign key constraint FK_PaymentMethods_16_0') WHERE (SELECT Id FROM ApplePay WHERE  Id = NEW.ApplePayId) IS NULL; END;
CREATE TRIGGER [fki_PaymentMethods_AchDebitId_AchDebit_Id] BEFORE Insert ON [PaymentMethods] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table PaymentMethods violates foreign key constraint FK_PaymentMethods_17_0') WHERE (SELECT Id FROM AchDebit WHERE  Id = NEW.AchDebitId) IS NULL; END;
CREATE TRIGGER [fku_PaymentMethods_AchDebitId_AchDebit_Id] BEFORE Update ON [PaymentMethods] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table PaymentMethods violates foreign key constraint FK_PaymentMethods_17_0') WHERE (SELECT Id FROM AchDebit WHERE  Id = NEW.AchDebitId) IS NULL; END;
CREATE TRIGGER [fki_PaymentMethods_AccountId1_Accounts_Id] BEFORE Insert ON [PaymentMethods] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table PaymentMethods violates foreign key constraint FK_PaymentMethods_18_0') WHERE (SELECT Id FROM Accounts WHERE  Id = NEW.AccountId1) IS NULL; END;
CREATE TRIGGER [fku_PaymentMethods_AccountId1_Accounts_Id] BEFORE Update ON [PaymentMethods] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table PaymentMethods violates foreign key constraint FK_PaymentMethods_18_0') WHERE (SELECT Id FROM Accounts WHERE  Id = NEW.AccountId1) IS NULL; END;
CREATE TRIGGER [fki_PaymentOption_PaymentScheduleId_PaymentSchedule_Id] BEFORE Insert ON [PaymentOption] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table PaymentOption violates foreign key constraint FK_PaymentOption_0_0') WHERE NEW.PaymentScheduleId IS NOT NULL AND(SELECT Id FROM PaymentSchedule WHERE  Id = NEW.PaymentScheduleId) IS NULL; END;
CREATE TRIGGER [fku_PaymentOption_PaymentScheduleId_PaymentSchedule_Id] BEFORE Update ON [PaymentOption] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table PaymentOption violates foreign key constraint FK_PaymentOption_0_0') WHERE NEW.PaymentScheduleId IS NOT NULL AND(SELECT Id FROM PaymentSchedule WHERE  Id = NEW.PaymentScheduleId) IS NULL; END;
CREATE TRIGGER [fki_PaymentOption_DetailId_Detail_Id] BEFORE Insert ON [PaymentOption] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table PaymentOption violates foreign key constraint FK_PaymentOption_1_0') WHERE (SELECT Id FROM Detail WHERE  Id = NEW.DetailId) IS NULL; END;
CREATE TRIGGER [fku_PaymentOption_DetailId_Detail_Id] BEFORE Update ON [PaymentOption] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table PaymentOption violates foreign key constraint FK_PaymentOption_1_0') WHERE (SELECT Id FROM Detail WHERE  Id = NEW.DetailId) IS NULL; END;
CREATE TRIGGER [fki_Payments_PaymentTransactionsId_PaymentTransactions_Id] BEFORE Insert ON [Payments] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Payments violates foreign key constraint FK_Payments_0_0') WHERE NEW.PaymentTransactionsId IS NOT NULL AND(SELECT Id FROM PaymentTransactions WHERE  Id = NEW.PaymentTransactionsId) IS NULL; END;
CREATE TRIGGER [fku_Payments_PaymentTransactionsId_PaymentTransactions_Id] BEFORE Update ON [Payments] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Payments violates foreign key constraint FK_Payments_0_0') WHERE NEW.PaymentTransactionsId IS NOT NULL AND(SELECT Id FROM PaymentTransactions WHERE  Id = NEW.PaymentTransactionsId) IS NULL; END;
CREATE TRIGGER [fki_Payments_StateTransitionsId_PaymentStateTransitions_Id] BEFORE Insert ON [Payments] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Payments violates foreign key constraint FK_Payments_1_0') WHERE (SELECT Id FROM PaymentStateTransitions WHERE  Id = NEW.StateTransitionsId) IS NULL; END;
CREATE TRIGGER [fku_Payments_StateTransitionsId_PaymentStateTransitions_Id] BEFORE Update ON [Payments] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Payments violates foreign key constraint FK_Payments_1_0') WHERE (SELECT Id FROM PaymentStateTransitions WHERE  Id = NEW.StateTransitionsId) IS NULL; END;
CREATE TRIGGER [fki_Payments_PaymentMethodId1_PaymentMethods_Id] BEFORE Insert ON [Payments] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Payments violates foreign key constraint FK_Payments_2_0') WHERE (SELECT Id FROM PaymentMethods WHERE  Id = NEW.PaymentMethodId1) IS NULL; END;
CREATE TRIGGER [fku_Payments_PaymentMethodId1_PaymentMethods_Id] BEFORE Update ON [Payments] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Payments violates foreign key constraint FK_Payments_2_0') WHERE (SELECT Id FROM PaymentMethods WHERE  Id = NEW.PaymentMethodId1) IS NULL; END;
CREATE TRIGGER [fki_Payments_GatewayStateTransitionsId_GatewayStateTransitions_Id] BEFORE Insert ON [Payments] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Payments violates foreign key constraint FK_Payments_3_0') WHERE (SELECT Id FROM GatewayStateTransitions WHERE  Id = NEW.GatewayStateTransitionsId) IS NULL; END;
CREATE TRIGGER [fku_Payments_GatewayStateTransitionsId_GatewayStateTransitions_Id] BEFORE Update ON [Payments] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Payments violates foreign key constraint FK_Payments_3_0') WHERE (SELECT Id FROM GatewayStateTransitions WHERE  Id = NEW.GatewayStateTransitionsId) IS NULL; END;
CREATE TRIGGER [fki_Payments_GatewayOptionsId_GatewayOptions_Id] BEFORE Insert ON [Payments] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Payments violates foreign key constraint FK_Payments_4_0') WHERE (SELECT Id FROM GatewayOptions WHERE  Id = NEW.GatewayOptionsId) IS NULL; END;
CREATE TRIGGER [fku_Payments_GatewayOptionsId_GatewayOptions_Id] BEFORE Update ON [Payments] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Payments violates foreign key constraint FK_Payments_4_0') WHERE (SELECT Id FROM GatewayOptions WHERE  Id = NEW.GatewayOptionsId) IS NULL; END;
CREATE TRIGGER [fki_Payments_CustomObjectsId_CustomObjects_Id] BEFORE Insert ON [Payments] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Payments violates foreign key constraint FK_Payments_5_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fku_Payments_CustomObjectsId_CustomObjects_Id] BEFORE Update ON [Payments] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Payments violates foreign key constraint FK_Payments_5_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fki_Payments_CustomFieldsId_CustomFields_Id] BEFORE Insert ON [Payments] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Payments violates foreign key constraint FK_Payments_6_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fku_Payments_CustomFieldsId_CustomFields_Id] BEFORE Update ON [Payments] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Payments violates foreign key constraint FK_Payments_6_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fki_Payments_AccountId1_Accounts_Id] BEFORE Insert ON [Payments] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Payments violates foreign key constraint FK_Payments_7_0') WHERE (SELECT Id FROM Accounts WHERE  Id = NEW.AccountId1) IS NULL; END;
CREATE TRIGGER [fku_Payments_AccountId1_Accounts_Id] BEFORE Update ON [Payments] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Payments violates foreign key constraint FK_Payments_7_0') WHERE (SELECT Id FROM Accounts WHERE  Id = NEW.AccountId1) IS NULL; END;
CREATE TRIGGER [fki_PaymentsAppliedTo_PaymentId_Payments_Id] BEFORE Insert ON [PaymentsAppliedTo] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table PaymentsAppliedTo violates foreign key constraint FK_PaymentsAppliedTo_0_0') WHERE NEW.PaymentId IS NOT NULL AND(SELECT Id FROM Payments WHERE  Id = NEW.PaymentId) IS NULL; END;
CREATE TRIGGER [fku_PaymentsAppliedTo_PaymentId_Payments_Id] BEFORE Update ON [PaymentsAppliedTo] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table PaymentsAppliedTo violates foreign key constraint FK_PaymentsAppliedTo_0_0') WHERE NEW.PaymentId IS NOT NULL AND(SELECT Id FROM Payments WHERE  Id = NEW.PaymentId) IS NULL; END;
CREATE TRIGGER [fki_PaymentsAppliedTo_BillingDocumentId1_BillingDocuments_Id] BEFORE Insert ON [PaymentsAppliedTo] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table PaymentsAppliedTo violates foreign key constraint FK_PaymentsAppliedTo_1_0') WHERE (SELECT Id FROM BillingDocuments WHERE  Id = NEW.BillingDocumentId1) IS NULL; END;
CREATE TRIGGER [fku_PaymentsAppliedTo_BillingDocumentId1_BillingDocuments_Id] BEFORE Update ON [PaymentsAppliedTo] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table PaymentsAppliedTo violates foreign key constraint FK_PaymentsAppliedTo_1_0') WHERE (SELECT Id FROM BillingDocuments WHERE  Id = NEW.BillingDocumentId1) IS NULL; END;
CREATE TRIGGER [fki_PaymentSchedule_CustomObjectsId_CustomObjects_Id] BEFORE Insert ON [PaymentSchedule] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table PaymentSchedule violates foreign key constraint FK_PaymentSchedule_0_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fku_PaymentSchedule_CustomObjectsId_CustomObjects_Id] BEFORE Update ON [PaymentSchedule] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table PaymentSchedule violates foreign key constraint FK_PaymentSchedule_0_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fki_PaymentSchedule_CustomFieldsId_CustomFields_Id] BEFORE Insert ON [PaymentSchedule] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table PaymentSchedule violates foreign key constraint FK_PaymentSchedule_1_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fku_PaymentSchedule_CustomFieldsId_CustomFields_Id] BEFORE Update ON [PaymentSchedule] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table PaymentSchedule violates foreign key constraint FK_PaymentSchedule_1_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fki_PaymentSchedule_BillingDocumentId_BillingDocuments_Id] BEFORE Insert ON [PaymentSchedule] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table PaymentSchedule violates foreign key constraint FK_PaymentSchedule_2_0') WHERE (SELECT Id FROM BillingDocuments WHERE  Id = NEW.BillingDocumentId) IS NULL; END;
CREATE TRIGGER [fku_PaymentSchedule_BillingDocumentId_BillingDocuments_Id] BEFORE Update ON [PaymentSchedule] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table PaymentSchedule violates foreign key constraint FK_PaymentSchedule_2_0') WHERE (SELECT Id FROM BillingDocuments WHERE  Id = NEW.BillingDocumentId) IS NULL; END;
CREATE TRIGGER [fki_PaymentScheduleItemPayments_PaymentScheduleItemId_PaymentScheduleItems_Id] BEFORE Insert ON [PaymentScheduleItemPayments] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table PaymentScheduleItemPayments violates foreign key constraint FK_PaymentScheduleItemPayments_0_0') WHERE NEW.PaymentScheduleItemId IS NOT NULL AND(SELECT Id FROM PaymentScheduleItems WHERE  Id = NEW.PaymentScheduleItemId) IS NULL; END;
CREATE TRIGGER [fku_PaymentScheduleItemPayments_PaymentScheduleItemId_PaymentScheduleItems_Id] BEFORE Update ON [PaymentScheduleItemPayments] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table PaymentScheduleItemPayments violates foreign key constraint FK_PaymentScheduleItemPayments_0_0') WHERE NEW.PaymentScheduleItemId IS NOT NULL AND(SELECT Id FROM PaymentScheduleItems WHERE  Id = NEW.PaymentScheduleItemId) IS NULL; END;
CREATE TRIGGER [fki_PaymentScheduleItems_PaymentId_Payments_Id] BEFORE Insert ON [PaymentScheduleItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table PaymentScheduleItems violates foreign key constraint FK_PaymentScheduleItems_0_0') WHERE (SELECT Id FROM Payments WHERE  Id = NEW.PaymentId) IS NULL; END;
CREATE TRIGGER [fku_PaymentScheduleItems_PaymentId_Payments_Id] BEFORE Update ON [PaymentScheduleItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table PaymentScheduleItems violates foreign key constraint FK_PaymentScheduleItems_0_0') WHERE (SELECT Id FROM Payments WHERE  Id = NEW.PaymentId) IS NULL; END;
CREATE TRIGGER [fki_PaymentScheduleItems_PaymentScheduleId1_PaymentSchedule_Id] BEFORE Insert ON [PaymentScheduleItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table PaymentScheduleItems violates foreign key constraint FK_PaymentScheduleItems_1_0') WHERE (SELECT Id FROM PaymentSchedule WHERE  Id = NEW.PaymentScheduleId1) IS NULL; END;
CREATE TRIGGER [fku_PaymentScheduleItems_PaymentScheduleId1_PaymentSchedule_Id] BEFORE Update ON [PaymentScheduleItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table PaymentScheduleItems violates foreign key constraint FK_PaymentScheduleItems_1_0') WHERE (SELECT Id FROM PaymentSchedule WHERE  Id = NEW.PaymentScheduleId1) IS NULL; END;
CREATE TRIGGER [fki_PaymentScheduleItems_CustomObjectsId_CustomObjects_Id] BEFORE Insert ON [PaymentScheduleItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table PaymentScheduleItems violates foreign key constraint FK_PaymentScheduleItems_2_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fku_PaymentScheduleItems_CustomObjectsId_CustomObjects_Id] BEFORE Update ON [PaymentScheduleItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table PaymentScheduleItems violates foreign key constraint FK_PaymentScheduleItems_2_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fki_PaymentScheduleItems_CustomFieldsId_CustomFields_Id] BEFORE Insert ON [PaymentScheduleItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table PaymentScheduleItems violates foreign key constraint FK_PaymentScheduleItems_3_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fku_PaymentScheduleItems_CustomFieldsId_CustomFields_Id] BEFORE Update ON [PaymentScheduleItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table PaymentScheduleItems violates foreign key constraint FK_PaymentScheduleItems_3_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fki_PaymentScheduleItems_BillingDocumentId_BillingDocuments_Id] BEFORE Insert ON [PaymentScheduleItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table PaymentScheduleItems violates foreign key constraint FK_PaymentScheduleItems_4_0') WHERE (SELECT Id FROM BillingDocuments WHERE  Id = NEW.BillingDocumentId) IS NULL; END;
CREATE TRIGGER [fku_PaymentScheduleItems_BillingDocumentId_BillingDocuments_Id] BEFORE Update ON [PaymentScheduleItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table PaymentScheduleItems violates foreign key constraint FK_PaymentScheduleItems_4_0') WHERE (SELECT Id FROM BillingDocuments WHERE  Id = NEW.BillingDocumentId) IS NULL; END;
CREATE TRIGGER [fki_PaymentTransactions_StateId_TransactionsState_Id] BEFORE Insert ON [PaymentTransactions] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table PaymentTransactions violates foreign key constraint FK_PaymentTransactions_0_0') WHERE (SELECT Id FROM TransactionsState WHERE  Id = NEW.StateId) IS NULL; END;
CREATE TRIGGER [fku_PaymentTransactions_StateId_TransactionsState_Id] BEFORE Update ON [PaymentTransactions] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table PaymentTransactions violates foreign key constraint FK_PaymentTransactions_0_0') WHERE (SELECT Id FROM TransactionsState WHERE  Id = NEW.StateId) IS NULL; END;
CREATE TRIGGER [fki_PaymentTransactions_ArTransactionsId_ArTransactions_Id] BEFORE Insert ON [PaymentTransactions] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table PaymentTransactions violates foreign key constraint FK_PaymentTransactions_1_0') WHERE NEW.ArTransactionsId IS NOT NULL AND(SELECT Id FROM ArTransactions WHERE  Id = NEW.ArTransactionsId) IS NULL; END;
CREATE TRIGGER [fku_PaymentTransactions_ArTransactionsId_ArTransactions_Id] BEFORE Update ON [PaymentTransactions] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table PaymentTransactions violates foreign key constraint FK_PaymentTransactions_1_0') WHERE NEW.ArTransactionsId IS NOT NULL AND(SELECT Id FROM ArTransactions WHERE  Id = NEW.ArTransactionsId) IS NULL; END;
CREATE TRIGGER [fki_Plan_ProductId1_Products_Id] BEFORE Insert ON [Plan] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Plan violates foreign key constraint FK_Plan_0_0') WHERE (SELECT Id FROM Products WHERE  Id = NEW.ProductId1) IS NULL; END;
CREATE TRIGGER [fku_Plan_ProductId1_Products_Id] BEFORE Update ON [Plan] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Plan violates foreign key constraint FK_Plan_0_0') WHERE (SELECT Id FROM Products WHERE  Id = NEW.ProductId1) IS NULL; END;
CREATE TRIGGER [fki_Plan_CustomObjectsId_CustomObjects_Id] BEFORE Insert ON [Plan] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Plan violates foreign key constraint FK_Plan_1_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fku_Plan_CustomObjectsId_CustomObjects_Id] BEFORE Update ON [Plan] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Plan violates foreign key constraint FK_Plan_1_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fki_Plan_CustomFieldsId_CustomFields_Id] BEFORE Insert ON [Plan] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Plan violates foreign key constraint FK_Plan_2_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fku_Plan_CustomFieldsId_CustomFields_Id] BEFORE Update ON [Plan] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Plan violates foreign key constraint FK_Plan_2_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fki_PrepaidBalance_SubscriptionId_Subscriptions_Id] BEFORE Insert ON [PrepaidBalance] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table PrepaidBalance violates foreign key constraint FK_PrepaidBalance_0_0') WHERE NEW.SubscriptionId IS NOT NULL AND(SELECT Id FROM Subscriptions WHERE  Id = NEW.SubscriptionId) IS NULL; END;
CREATE TRIGGER [fku_PrepaidBalance_SubscriptionId_Subscriptions_Id] BEFORE Update ON [PrepaidBalance] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table PrepaidBalance violates foreign key constraint FK_PrepaidBalance_0_0') WHERE NEW.SubscriptionId IS NOT NULL AND(SELECT Id FROM Subscriptions WHERE  Id = NEW.SubscriptionId) IS NULL; END;
CREATE TRIGGER [fki_PrepaidBalances_SubscriptionId_Subscriptions_Id] BEFORE Insert ON [PrepaidBalances] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table PrepaidBalances violates foreign key constraint FK_PrepaidBalances_0_0') WHERE NEW.SubscriptionId IS NOT NULL AND(SELECT Id FROM Subscriptions WHERE  Id = NEW.SubscriptionId) IS NULL; END;
CREATE TRIGGER [fku_PrepaidBalances_SubscriptionId_Subscriptions_Id] BEFORE Update ON [PrepaidBalances] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table PrepaidBalances violates foreign key constraint FK_PrepaidBalances_0_0') WHERE NEW.SubscriptionId IS NOT NULL AND(SELECT Id FROM Subscriptions WHERE  Id = NEW.SubscriptionId) IS NULL; END;
CREATE TRIGGER [fki_PrepaidBalanceTransaction_ValidityPeriodId_ValidityPeriod_Id] BEFORE Insert ON [PrepaidBalanceTransaction] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table PrepaidBalanceTransaction violates foreign key constraint FK_PrepaidBalanceTransaction_0_0') WHERE NEW.ValidityPeriodId IS NOT NULL AND(SELECT Id FROM ValidityPeriod WHERE  Id = NEW.ValidityPeriodId) IS NULL; END;
CREATE TRIGGER [fku_PrepaidBalanceTransaction_ValidityPeriodId_ValidityPeriod_Id] BEFORE Update ON [PrepaidBalanceTransaction] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table PrepaidBalanceTransaction violates foreign key constraint FK_PrepaidBalanceTransaction_0_0') WHERE NEW.ValidityPeriodId IS NOT NULL AND(SELECT Id FROM ValidityPeriod WHERE  Id = NEW.ValidityPeriodId) IS NULL; END;
CREATE TRIGGER [fki_PrepaidBalanceTransaction_PrepaidBalanceId_PrepaidBalance_Id] BEFORE Insert ON [PrepaidBalanceTransaction] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table PrepaidBalanceTransaction violates foreign key constraint FK_PrepaidBalanceTransaction_1_0') WHERE NEW.PrepaidBalanceId IS NOT NULL AND(SELECT Id FROM PrepaidBalance WHERE  Id = NEW.PrepaidBalanceId) IS NULL; END;
CREATE TRIGGER [fku_PrepaidBalanceTransaction_PrepaidBalanceId_PrepaidBalance_Id] BEFORE Update ON [PrepaidBalanceTransaction] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table PrepaidBalanceTransaction violates foreign key constraint FK_PrepaidBalanceTransaction_1_0') WHERE NEW.PrepaidBalanceId IS NOT NULL AND(SELECT Id FROM PrepaidBalance WHERE  Id = NEW.PrepaidBalanceId) IS NULL; END;
CREATE TRIGGER [fki_Price_RevenueId_Revenue_Id] BEFORE Insert ON [Price] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Price violates foreign key constraint FK_Price_0_0') WHERE (SELECT Id FROM Revenue WHERE  Id = NEW.RevenueId) IS NULL; END;
CREATE TRIGGER [fku_Price_RevenueId_Revenue_Id] BEFORE Update ON [Price] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Price violates foreign key constraint FK_Price_0_0') WHERE (SELECT Id FROM Revenue WHERE  Id = NEW.RevenueId) IS NULL; END;
CREATE TRIGGER [fki_Price_RecurringId_Recurring_Id] BEFORE Insert ON [Price] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Price violates foreign key constraint FK_Price_1_0') WHERE (SELECT Id FROM Recurring WHERE  Id = NEW.RecurringId) IS NULL; END;
CREATE TRIGGER [fku_Price_RecurringId_Recurring_Id] BEFORE Update ON [Price] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Price violates foreign key constraint FK_Price_1_0') WHERE (SELECT Id FROM Recurring WHERE  Id = NEW.RecurringId) IS NULL; END;
CREATE TRIGGER [fki_Price_PrepaymentId_Prepayment_Id] BEFORE Insert ON [Price] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Price violates foreign key constraint FK_Price_2_0') WHERE (SELECT Id FROM Prepayment WHERE  Id = NEW.PrepaymentId) IS NULL; END;
CREATE TRIGGER [fku_Price_PrepaymentId_Prepayment_Id] BEFORE Update ON [Price] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Price violates foreign key constraint FK_Price_2_0') WHERE (SELECT Id FROM Prepayment WHERE  Id = NEW.PrepaymentId) IS NULL; END;
CREATE TRIGGER [fki_Price_PlanId1_Plan_Id] BEFORE Insert ON [Price] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Price violates foreign key constraint FK_Price_3_0') WHERE NEW.PlanId1 IS NOT NULL AND(SELECT Id FROM Plan WHERE  Id = NEW.PlanId1) IS NULL; END;
CREATE TRIGGER [fku_Price_PlanId1_Plan_Id] BEFORE Update ON [Price] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Price violates foreign key constraint FK_Price_3_0') WHERE NEW.PlanId1 IS NOT NULL AND(SELECT Id FROM Plan WHERE  Id = NEW.PlanId1) IS NULL; END;
CREATE TRIGGER [fki_Price_OverageId_Overage_Id] BEFORE Insert ON [Price] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Price violates foreign key constraint FK_Price_4_0') WHERE (SELECT Id FROM Overage WHERE  Id = NEW.OverageId) IS NULL; END;
CREATE TRIGGER [fku_Price_OverageId_Overage_Id] BEFORE Update ON [Price] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Price violates foreign key constraint FK_Price_4_0') WHERE (SELECT Id FROM Overage WHERE  Id = NEW.OverageId) IS NULL; END;
CREATE TRIGGER [fki_Price_DrawdownId_Drawdown_Id] BEFORE Insert ON [Price] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Price violates foreign key constraint FK_Price_5_0') WHERE (SELECT Id FROM Drawdown WHERE  Id = NEW.DrawdownId) IS NULL; END;
CREATE TRIGGER [fku_Price_DrawdownId_Drawdown_Id] BEFORE Update ON [Price] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Price violates foreign key constraint FK_Price_5_0') WHERE (SELECT Id FROM Drawdown WHERE  Id = NEW.DrawdownId) IS NULL; END;
CREATE TRIGGER [fki_Price_CustomObjectsId_CustomObjects_Id] BEFORE Insert ON [Price] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Price violates foreign key constraint FK_Price_6_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fku_Price_CustomObjectsId_CustomObjects_Id] BEFORE Update ON [Price] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Price violates foreign key constraint FK_Price_6_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fki_Price_CustomFieldsId_CustomFields_Id] BEFORE Insert ON [Price] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Price violates foreign key constraint FK_Price_7_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fku_Price_CustomFieldsId_CustomFields_Id] BEFORE Update ON [Price] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Price violates foreign key constraint FK_Price_7_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fki_Price_UnitAmountsId_Amounts_Id] BEFORE Insert ON [Price] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Price violates foreign key constraint FK_Price_8_0') WHERE (SELECT Id FROM Amounts WHERE  Id = NEW.UnitAmountsId) IS NULL; END;
CREATE TRIGGER [fku_Price_UnitAmountsId_Amounts_Id] BEFORE Update ON [Price] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Price violates foreign key constraint FK_Price_8_0') WHERE (SELECT Id FROM Amounts WHERE  Id = NEW.UnitAmountsId) IS NULL; END;
CREATE TRIGGER [fki_Price_DiscountAmountsId_Amounts_Id] BEFORE Insert ON [Price] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Price violates foreign key constraint FK_Price_9_0') WHERE (SELECT Id FROM Amounts WHERE  Id = NEW.DiscountAmountsId) IS NULL; END;
CREATE TRIGGER [fku_Price_DiscountAmountsId_Amounts_Id] BEFORE Update ON [Price] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Price violates foreign key constraint FK_Price_9_0') WHERE (SELECT Id FROM Amounts WHERE  Id = NEW.DiscountAmountsId) IS NULL; END;
CREATE TRIGGER [fki_Price_AmountsId_Amounts_Id] BEFORE Insert ON [Price] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Price violates foreign key constraint FK_Price_10_0') WHERE (SELECT Id FROM Amounts WHERE  Id = NEW.AmountsId) IS NULL; END;
CREATE TRIGGER [fku_Price_AmountsId_Amounts_Id] BEFORE Update ON [Price] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Price violates foreign key constraint FK_Price_10_0') WHERE (SELECT Id FROM Amounts WHERE  Id = NEW.AmountsId) IS NULL; END;
CREATE TRIGGER [fki_ProductPlan_ProductId1_Products_Id] BEFORE Insert ON [ProductPlan] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table ProductPlan violates foreign key constraint FK_ProductPlan_0_0') WHERE (SELECT Id FROM Products WHERE  Id = NEW.ProductId1) IS NULL; END;
CREATE TRIGGER [fku_ProductPlan_ProductId1_Products_Id] BEFORE Update ON [ProductPlan] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table ProductPlan violates foreign key constraint FK_ProductPlan_0_0') WHERE (SELECT Id FROM Products WHERE  Id = NEW.ProductId1) IS NULL; END;
CREATE TRIGGER [fki_ProductPlan_CustomObjectsId_CustomObjects_Id] BEFORE Insert ON [ProductPlan] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table ProductPlan violates foreign key constraint FK_ProductPlan_1_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fku_ProductPlan_CustomObjectsId_CustomObjects_Id] BEFORE Update ON [ProductPlan] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table ProductPlan violates foreign key constraint FK_ProductPlan_1_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fki_ProductPlan_CustomFieldsId_CustomFields_Id] BEFORE Insert ON [ProductPlan] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table ProductPlan violates foreign key constraint FK_ProductPlan_2_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fku_ProductPlan_CustomFieldsId_CustomFields_Id] BEFORE Update ON [ProductPlan] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table ProductPlan violates foreign key constraint FK_ProductPlan_2_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fki_ProductPrice_RevenueId_Revenue_Id] BEFORE Insert ON [ProductPrice] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table ProductPrice violates foreign key constraint FK_ProductPrice_0_0') WHERE (SELECT Id FROM Revenue WHERE  Id = NEW.RevenueId) IS NULL; END;
CREATE TRIGGER [fku_ProductPrice_RevenueId_Revenue_Id] BEFORE Update ON [ProductPrice] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table ProductPrice violates foreign key constraint FK_ProductPrice_0_0') WHERE (SELECT Id FROM Revenue WHERE  Id = NEW.RevenueId) IS NULL; END;
CREATE TRIGGER [fki_ProductPrice_RecurringId_Recurring_Id] BEFORE Insert ON [ProductPrice] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table ProductPrice violates foreign key constraint FK_ProductPrice_1_0') WHERE (SELECT Id FROM Recurring WHERE  Id = NEW.RecurringId) IS NULL; END;
CREATE TRIGGER [fku_ProductPrice_RecurringId_Recurring_Id] BEFORE Update ON [ProductPrice] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table ProductPrice violates foreign key constraint FK_ProductPrice_1_0') WHERE (SELECT Id FROM Recurring WHERE  Id = NEW.RecurringId) IS NULL; END;
CREATE TRIGGER [fki_ProductPrice_ProductPlanId1_ProductPlan_Id] BEFORE Insert ON [ProductPrice] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table ProductPrice violates foreign key constraint FK_ProductPrice_2_0') WHERE NEW.ProductPlanId1 IS NOT NULL AND(SELECT Id FROM ProductPlan WHERE  Id = NEW.ProductPlanId1) IS NULL; END;
CREATE TRIGGER [fku_ProductPrice_ProductPlanId1_ProductPlan_Id] BEFORE Update ON [ProductPrice] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table ProductPrice violates foreign key constraint FK_ProductPrice_2_0') WHERE NEW.ProductPlanId1 IS NOT NULL AND(SELECT Id FROM ProductPlan WHERE  Id = NEW.ProductPlanId1) IS NULL; END;
CREATE TRIGGER [fki_ProductPrice_PrepaymentId_Prepayment_Id] BEFORE Insert ON [ProductPrice] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table ProductPrice violates foreign key constraint FK_ProductPrice_3_0') WHERE (SELECT Id FROM Prepayment WHERE  Id = NEW.PrepaymentId) IS NULL; END;
CREATE TRIGGER [fku_ProductPrice_PrepaymentId_Prepayment_Id] BEFORE Update ON [ProductPrice] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table ProductPrice violates foreign key constraint FK_ProductPrice_3_0') WHERE (SELECT Id FROM Prepayment WHERE  Id = NEW.PrepaymentId) IS NULL; END;
CREATE TRIGGER [fki_ProductPrice_OverageId_Overage_Id] BEFORE Insert ON [ProductPrice] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table ProductPrice violates foreign key constraint FK_ProductPrice_4_0') WHERE (SELECT Id FROM Overage WHERE  Id = NEW.OverageId) IS NULL; END;
CREATE TRIGGER [fku_ProductPrice_OverageId_Overage_Id] BEFORE Update ON [ProductPrice] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table ProductPrice violates foreign key constraint FK_ProductPrice_4_0') WHERE (SELECT Id FROM Overage WHERE  Id = NEW.OverageId) IS NULL; END;
CREATE TRIGGER [fki_ProductPrice_DrawdownId_Drawdown_Id] BEFORE Insert ON [ProductPrice] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table ProductPrice violates foreign key constraint FK_ProductPrice_5_0') WHERE (SELECT Id FROM Drawdown WHERE  Id = NEW.DrawdownId) IS NULL; END;
CREATE TRIGGER [fku_ProductPrice_DrawdownId_Drawdown_Id] BEFORE Update ON [ProductPrice] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table ProductPrice violates foreign key constraint FK_ProductPrice_5_0') WHERE (SELECT Id FROM Drawdown WHERE  Id = NEW.DrawdownId) IS NULL; END;
CREATE TRIGGER [fki_ProductPrice_CustomObjectsId_CustomObjects_Id] BEFORE Insert ON [ProductPrice] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table ProductPrice violates foreign key constraint FK_ProductPrice_6_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fku_ProductPrice_CustomObjectsId_CustomObjects_Id] BEFORE Update ON [ProductPrice] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table ProductPrice violates foreign key constraint FK_ProductPrice_6_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fki_ProductPrice_CustomFieldsId_CustomFields_Id] BEFORE Insert ON [ProductPrice] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table ProductPrice violates foreign key constraint FK_ProductPrice_7_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fku_ProductPrice_CustomFieldsId_CustomFields_Id] BEFORE Update ON [ProductPrice] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table ProductPrice violates foreign key constraint FK_ProductPrice_7_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fki_ProductPrice_UnitAmountsId_Amounts_Id] BEFORE Insert ON [ProductPrice] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table ProductPrice violates foreign key constraint FK_ProductPrice_8_0') WHERE (SELECT Id FROM Amounts WHERE  Id = NEW.UnitAmountsId) IS NULL; END;
CREATE TRIGGER [fku_ProductPrice_UnitAmountsId_Amounts_Id] BEFORE Update ON [ProductPrice] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table ProductPrice violates foreign key constraint FK_ProductPrice_8_0') WHERE (SELECT Id FROM Amounts WHERE  Id = NEW.UnitAmountsId) IS NULL; END;
CREATE TRIGGER [fki_ProductPrice_DiscountAmountsId_Amounts_Id] BEFORE Insert ON [ProductPrice] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table ProductPrice violates foreign key constraint FK_ProductPrice_9_0') WHERE (SELECT Id FROM Amounts WHERE  Id = NEW.DiscountAmountsId) IS NULL; END;
CREATE TRIGGER [fku_ProductPrice_DiscountAmountsId_Amounts_Id] BEFORE Update ON [ProductPrice] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table ProductPrice violates foreign key constraint FK_ProductPrice_9_0') WHERE (SELECT Id FROM Amounts WHERE  Id = NEW.DiscountAmountsId) IS NULL; END;
CREATE TRIGGER [fki_ProductPrice_AmountsId_Amounts_Id] BEFORE Insert ON [ProductPrice] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table ProductPrice violates foreign key constraint FK_ProductPrice_10_0') WHERE (SELECT Id FROM Amounts WHERE  Id = NEW.AmountsId) IS NULL; END;
CREATE TRIGGER [fku_ProductPrice_AmountsId_Amounts_Id] BEFORE Update ON [ProductPrice] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table ProductPrice violates foreign key constraint FK_ProductPrice_10_0') WHERE (SELECT Id FROM Amounts WHERE  Id = NEW.AmountsId) IS NULL; END;
CREATE TRIGGER [fki_Products_CustomObjectsId_CustomObjects_Id] BEFORE Insert ON [Products] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Products violates foreign key constraint FK_Products_0_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fku_Products_CustomObjectsId_CustomObjects_Id] BEFORE Update ON [Products] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Products violates foreign key constraint FK_Products_0_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fki_Products_CustomFieldsId_CustomFields_Id] BEFORE Insert ON [Products] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Products violates foreign key constraint FK_Products_1_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fku_Products_CustomFieldsId_CustomFields_Id] BEFORE Update ON [Products] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Products violates foreign key constraint FK_Products_1_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fki_ProductTier_ProductPriceId_ProductPrice_Id] BEFORE Insert ON [ProductTier] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table ProductTier violates foreign key constraint FK_ProductTier_0_0') WHERE NEW.ProductPriceId IS NOT NULL AND(SELECT Id FROM ProductPrice WHERE  Id = NEW.ProductPriceId) IS NULL; END;
CREATE TRIGGER [fku_ProductTier_ProductPriceId_ProductPrice_Id] BEFORE Update ON [ProductTier] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table ProductTier violates foreign key constraint FK_ProductTier_0_0') WHERE NEW.ProductPriceId IS NOT NULL AND(SELECT Id FROM ProductPrice WHERE  Id = NEW.ProductPriceId) IS NULL; END;
CREATE TRIGGER [fki_ProductTier_UnitAmountsId_Money_Id] BEFORE Insert ON [ProductTier] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table ProductTier violates foreign key constraint FK_ProductTier_1_0') WHERE (SELECT Id FROM Money WHERE  Id = NEW.UnitAmountsId) IS NULL; END;
CREATE TRIGGER [fku_ProductTier_UnitAmountsId_Money_Id] BEFORE Update ON [ProductTier] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table ProductTier violates foreign key constraint FK_ProductTier_1_0') WHERE (SELECT Id FROM Money WHERE  Id = NEW.UnitAmountsId) IS NULL; END;
CREATE TRIGGER [fki_ProductTier_AmountsId_Money_Id] BEFORE Insert ON [ProductTier] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table ProductTier violates foreign key constraint FK_ProductTier_2_0') WHERE (SELECT Id FROM Money WHERE  Id = NEW.AmountsId) IS NULL; END;
CREATE TRIGGER [fku_ProductTier_AmountsId_Money_Id] BEFORE Update ON [ProductTier] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table ProductTier violates foreign key constraint FK_ProductTier_2_0') WHERE (SELECT Id FROM Money WHERE  Id = NEW.AmountsId) IS NULL; END;
CREATE TRIGGER [fki_RefundAppliedToItem_RefundsAppliedToId_RefundsAppliedTo_Id] BEFORE Insert ON [RefundAppliedToItem] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table RefundAppliedToItem violates foreign key constraint FK_RefundAppliedToItem_0_0') WHERE NEW.RefundsAppliedToId IS NOT NULL AND(SELECT Id FROM RefundsAppliedTo WHERE  Id = NEW.RefundsAppliedToId) IS NULL; END;
CREATE TRIGGER [fku_RefundAppliedToItem_RefundsAppliedToId_RefundsAppliedTo_Id] BEFORE Update ON [RefundAppliedToItem] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table RefundAppliedToItem violates foreign key constraint FK_RefundAppliedToItem_0_0') WHERE NEW.RefundsAppliedToId IS NOT NULL AND(SELECT Id FROM RefundsAppliedTo WHERE  Id = NEW.RefundsAppliedToId) IS NULL; END;
CREATE TRIGGER [fki_Refunds_RefundTransactionsId_RefundTransactions_Id] BEFORE Insert ON [Refunds] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Refunds violates foreign key constraint FK_Refunds_0_0') WHERE NEW.RefundTransactionsId IS NOT NULL AND(SELECT Id FROM RefundTransactions WHERE  Id = NEW.RefundTransactionsId) IS NULL; END;
CREATE TRIGGER [fku_Refunds_RefundTransactionsId_RefundTransactions_Id] BEFORE Update ON [Refunds] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Refunds violates foreign key constraint FK_Refunds_0_0') WHERE NEW.RefundTransactionsId IS NOT NULL AND(SELECT Id FROM RefundTransactions WHERE  Id = NEW.RefundTransactionsId) IS NULL; END;
CREATE TRIGGER [fki_Refunds_StateTransitionsId_RefundStateTransitions_Id] BEFORE Insert ON [Refunds] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Refunds violates foreign key constraint FK_Refunds_1_0') WHERE (SELECT Id FROM RefundStateTransitions WHERE  Id = NEW.StateTransitionsId) IS NULL; END;
CREATE TRIGGER [fku_Refunds_StateTransitionsId_RefundStateTransitions_Id] BEFORE Update ON [Refunds] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Refunds violates foreign key constraint FK_Refunds_1_0') WHERE (SELECT Id FROM RefundStateTransitions WHERE  Id = NEW.StateTransitionsId) IS NULL; END;
CREATE TRIGGER [fki_Refunds_PaymentMethodId1_PaymentMethods_Id] BEFORE Insert ON [Refunds] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Refunds violates foreign key constraint FK_Refunds_2_0') WHERE (SELECT Id FROM PaymentMethods WHERE  Id = NEW.PaymentMethodId1) IS NULL; END;
CREATE TRIGGER [fku_Refunds_PaymentMethodId1_PaymentMethods_Id] BEFORE Update ON [Refunds] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Refunds violates foreign key constraint FK_Refunds_2_0') WHERE (SELECT Id FROM PaymentMethods WHERE  Id = NEW.PaymentMethodId1) IS NULL; END;
CREATE TRIGGER [fki_Refunds_GatewayOptionsId_GatewayOptions_Id] BEFORE Insert ON [Refunds] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Refunds violates foreign key constraint FK_Refunds_3_0') WHERE (SELECT Id FROM GatewayOptions WHERE  Id = NEW.GatewayOptionsId) IS NULL; END;
CREATE TRIGGER [fku_Refunds_GatewayOptionsId_GatewayOptions_Id] BEFORE Update ON [Refunds] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Refunds violates foreign key constraint FK_Refunds_3_0') WHERE (SELECT Id FROM GatewayOptions WHERE  Id = NEW.GatewayOptionsId) IS NULL; END;
CREATE TRIGGER [fki_Refunds_CustomObjectsId_CustomObjects_Id] BEFORE Insert ON [Refunds] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Refunds violates foreign key constraint FK_Refunds_4_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fku_Refunds_CustomObjectsId_CustomObjects_Id] BEFORE Update ON [Refunds] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Refunds violates foreign key constraint FK_Refunds_4_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fki_Refunds_CustomFieldsId_CustomFields_Id] BEFORE Insert ON [Refunds] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Refunds violates foreign key constraint FK_Refunds_5_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fku_Refunds_CustomFieldsId_CustomFields_Id] BEFORE Update ON [Refunds] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Refunds violates foreign key constraint FK_Refunds_5_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fki_Refunds_CreditMemoId_CreditMemos_Id] BEFORE Insert ON [Refunds] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Refunds violates foreign key constraint FK_Refunds_6_0') WHERE (SELECT Id FROM CreditMemos WHERE  Id = NEW.CreditMemoId) IS NULL; END;
CREATE TRIGGER [fku_Refunds_CreditMemoId_CreditMemos_Id] BEFORE Update ON [Refunds] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Refunds violates foreign key constraint FK_Refunds_6_0') WHERE (SELECT Id FROM CreditMemos WHERE  Id = NEW.CreditMemoId) IS NULL; END;
CREATE TRIGGER [fki_Refunds_AccountId1_Accounts_Id] BEFORE Insert ON [Refunds] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Refunds violates foreign key constraint FK_Refunds_7_0') WHERE (SELECT Id FROM Accounts WHERE  Id = NEW.AccountId1) IS NULL; END;
CREATE TRIGGER [fku_Refunds_AccountId1_Accounts_Id] BEFORE Update ON [Refunds] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Refunds violates foreign key constraint FK_Refunds_7_0') WHERE (SELECT Id FROM Accounts WHERE  Id = NEW.AccountId1) IS NULL; END;
CREATE TRIGGER [fki_RefundsAppliedTo_RefundId_Refunds_Id] BEFORE Insert ON [RefundsAppliedTo] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table RefundsAppliedTo violates foreign key constraint FK_RefundsAppliedTo_0_0') WHERE NEW.RefundId IS NOT NULL AND(SELECT Id FROM Refunds WHERE  Id = NEW.RefundId) IS NULL; END;
CREATE TRIGGER [fku_RefundsAppliedTo_RefundId_Refunds_Id] BEFORE Update ON [RefundsAppliedTo] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table RefundsAppliedTo violates foreign key constraint FK_RefundsAppliedTo_0_0') WHERE NEW.RefundId IS NOT NULL AND(SELECT Id FROM Refunds WHERE  Id = NEW.RefundId) IS NULL; END;
CREATE TRIGGER [fki_RefundsAppliedTo_PaymentId_Payments_Id] BEFORE Insert ON [RefundsAppliedTo] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table RefundsAppliedTo violates foreign key constraint FK_RefundsAppliedTo_1_0') WHERE (SELECT Id FROM Payments WHERE  Id = NEW.PaymentId) IS NULL; END;
CREATE TRIGGER [fku_RefundsAppliedTo_PaymentId_Payments_Id] BEFORE Update ON [RefundsAppliedTo] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table RefundsAppliedTo violates foreign key constraint FK_RefundsAppliedTo_1_0') WHERE (SELECT Id FROM Payments WHERE  Id = NEW.PaymentId) IS NULL; END;
CREATE TRIGGER [fki_RefundsAppliedTo_BillingDocumentId1_BillingDocuments_Id] BEFORE Insert ON [RefundsAppliedTo] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table RefundsAppliedTo violates foreign key constraint FK_RefundsAppliedTo_2_0') WHERE (SELECT Id FROM BillingDocuments WHERE  Id = NEW.BillingDocumentId1) IS NULL; END;
CREATE TRIGGER [fku_RefundsAppliedTo_BillingDocumentId1_BillingDocuments_Id] BEFORE Update ON [RefundsAppliedTo] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table RefundsAppliedTo violates foreign key constraint FK_RefundsAppliedTo_2_0') WHERE (SELECT Id FROM BillingDocuments WHERE  Id = NEW.BillingDocumentId1) IS NULL; END;
CREATE TRIGGER [fki_RefundTransactions_StateId_TransactionsState_Id] BEFORE Insert ON [RefundTransactions] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table RefundTransactions violates foreign key constraint FK_RefundTransactions_0_0') WHERE (SELECT Id FROM TransactionsState WHERE  Id = NEW.StateId) IS NULL; END;
CREATE TRIGGER [fku_RefundTransactions_StateId_TransactionsState_Id] BEFORE Update ON [RefundTransactions] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table RefundTransactions violates foreign key constraint FK_RefundTransactions_0_0') WHERE (SELECT Id FROM TransactionsState WHERE  Id = NEW.StateId) IS NULL; END;
CREATE TRIGGER [fki_RefundTransactions_ArTransactionsId_ArTransactions_Id] BEFORE Insert ON [RefundTransactions] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table RefundTransactions violates foreign key constraint FK_RefundTransactions_1_0') WHERE NEW.ArTransactionsId IS NOT NULL AND(SELECT Id FROM ArTransactions WHERE  Id = NEW.ArTransactionsId) IS NULL; END;
CREATE TRIGGER [fku_RefundTransactions_ArTransactionsId_ArTransactions_Id] BEFORE Update ON [RefundTransactions] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table RefundTransactions violates foreign key constraint FK_RefundTransactions_1_0') WHERE NEW.ArTransactionsId IS NOT NULL AND(SELECT Id FROM ArTransactions WHERE  Id = NEW.ArTransactionsId) IS NULL; END;
CREATE TRIGGER [fki_ResumeSubscription_CustomFieldsId_CustomFields_Id] BEFORE Insert ON [ResumeSubscription] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table ResumeSubscription violates foreign key constraint FK_ResumeSubscription_0_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fku_ResumeSubscription_CustomFieldsId_CustomFields_Id] BEFORE Update ON [ResumeSubscription] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table ResumeSubscription violates foreign key constraint FK_ResumeSubscription_0_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fki_SepaDebit_MandateId_Mandate_Id] BEFORE Insert ON [SepaDebit] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table SepaDebit violates foreign key constraint FK_SepaDebit_0_0') WHERE (SELECT Id FROM Mandate WHERE  Id = NEW.MandateId) IS NULL; END;
CREATE TRIGGER [fku_SepaDebit_MandateId_Mandate_Id] BEFORE Update ON [SepaDebit] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table SepaDebit violates foreign key constraint FK_SepaDebit_0_0') WHERE (SELECT Id FROM Mandate WHERE  Id = NEW.MandateId) IS NULL; END;
CREATE TRIGGER [fki_SubscriptionAddPlans_CustomFieldsId_CustomFields_Id] BEFORE Insert ON [SubscriptionAddPlans] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table SubscriptionAddPlans violates foreign key constraint FK_SubscriptionAddPlans_0_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fku_SubscriptionAddPlans_CustomFieldsId_CustomFields_Id] BEFORE Update ON [SubscriptionAddPlans] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table SubscriptionAddPlans violates foreign key constraint FK_SubscriptionAddPlans_0_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fki_SubscriptionItems_SubscriptionPlanId1_SubscriptionPlans_Id] BEFORE Insert ON [SubscriptionItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table SubscriptionItems violates foreign key constraint FK_SubscriptionItems_0_0') WHERE (SELECT Id FROM SubscriptionPlans WHERE  Id = NEW.SubscriptionPlanId1) IS NULL; END;
CREATE TRIGGER [fku_SubscriptionItems_SubscriptionPlanId1_SubscriptionPlans_Id] BEFORE Update ON [SubscriptionItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table SubscriptionItems violates foreign key constraint FK_SubscriptionItems_0_0') WHERE (SELECT Id FROM SubscriptionPlans WHERE  Id = NEW.SubscriptionPlanId1) IS NULL; END;
CREATE TRIGGER [fki_SubscriptionItems_SubscriptionAddPlanId_SubscriptionAddPlans_Id] BEFORE Insert ON [SubscriptionItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table SubscriptionItems violates foreign key constraint FK_SubscriptionItems_1_0') WHERE NEW.SubscriptionAddPlanId IS NOT NULL AND(SELECT Id FROM SubscriptionAddPlans WHERE  Id = NEW.SubscriptionAddPlanId) IS NULL; END;
CREATE TRIGGER [fku_SubscriptionItems_SubscriptionAddPlanId_SubscriptionAddPlans_Id] BEFORE Update ON [SubscriptionItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table SubscriptionItems violates foreign key constraint FK_SubscriptionItems_1_0') WHERE NEW.SubscriptionAddPlanId IS NOT NULL AND(SELECT Id FROM SubscriptionAddPlans WHERE  Id = NEW.SubscriptionAddPlanId) IS NULL; END;
CREATE TRIGGER [fki_SubscriptionItems_RecurringId_Recurring_Id] BEFORE Insert ON [SubscriptionItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table SubscriptionItems violates foreign key constraint FK_SubscriptionItems_2_0') WHERE (SELECT Id FROM Recurring WHERE  Id = NEW.RecurringId) IS NULL; END;
CREATE TRIGGER [fku_SubscriptionItems_RecurringId_Recurring_Id] BEFORE Update ON [SubscriptionItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table SubscriptionItems violates foreign key constraint FK_SubscriptionItems_2_0') WHERE (SELECT Id FROM Recurring WHERE  Id = NEW.RecurringId) IS NULL; END;
CREATE TRIGGER [fki_SubscriptionItems_PriceId1_Price_Id] BEFORE Insert ON [SubscriptionItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table SubscriptionItems violates foreign key constraint FK_SubscriptionItems_3_0') WHERE (SELECT Id FROM Price WHERE  Id = NEW.PriceId1) IS NULL; END;
CREATE TRIGGER [fku_SubscriptionItems_PriceId1_Price_Id] BEFORE Update ON [SubscriptionItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table SubscriptionItems violates foreign key constraint FK_SubscriptionItems_3_0') WHERE (SELECT Id FROM Price WHERE  Id = NEW.PriceId1) IS NULL; END;
CREATE TRIGGER [fki_SubscriptionItems_OverageId_Overage_Id] BEFORE Insert ON [SubscriptionItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table SubscriptionItems violates foreign key constraint FK_SubscriptionItems_4_0') WHERE (SELECT Id FROM Overage WHERE  Id = NEW.OverageId) IS NULL; END;
CREATE TRIGGER [fku_SubscriptionItems_OverageId_Overage_Id] BEFORE Update ON [SubscriptionItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table SubscriptionItems violates foreign key constraint FK_SubscriptionItems_4_0') WHERE (SELECT Id FROM Overage WHERE  Id = NEW.OverageId) IS NULL; END;
CREATE TRIGGER [fki_SubscriptionItems_CustomObjectsId_CustomObjects_Id] BEFORE Insert ON [SubscriptionItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table SubscriptionItems violates foreign key constraint FK_SubscriptionItems_5_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fku_SubscriptionItems_CustomObjectsId_CustomObjects_Id] BEFORE Update ON [SubscriptionItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table SubscriptionItems violates foreign key constraint FK_SubscriptionItems_5_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fki_SubscriptionItems_CustomFieldsId_CustomFields_Id] BEFORE Insert ON [SubscriptionItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table SubscriptionItems violates foreign key constraint FK_SubscriptionItems_6_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fku_SubscriptionItems_CustomFieldsId_CustomFields_Id] BEFORE Update ON [SubscriptionItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table SubscriptionItems violates foreign key constraint FK_SubscriptionItems_6_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fki_SubscriptionPauses_ResumeBehaviorId_ResumeSubscription_Id] BEFORE Insert ON [SubscriptionPauses] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table SubscriptionPauses violates foreign key constraint FK_SubscriptionPauses_0_0') WHERE (SELECT Id FROM ResumeSubscription WHERE  Id = NEW.ResumeBehaviorId) IS NULL; END;
CREATE TRIGGER [fku_SubscriptionPauses_ResumeBehaviorId_ResumeSubscription_Id] BEFORE Update ON [SubscriptionPauses] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table SubscriptionPauses violates foreign key constraint FK_SubscriptionPauses_0_0') WHERE (SELECT Id FROM ResumeSubscription WHERE  Id = NEW.ResumeBehaviorId) IS NULL; END;
CREATE TRIGGER [fki_SubscriptionPauses_CustomFieldsId_CustomFields_Id] BEFORE Insert ON [SubscriptionPauses] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table SubscriptionPauses violates foreign key constraint FK_SubscriptionPauses_1_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fku_SubscriptionPauses_CustomFieldsId_CustomFields_Id] BEFORE Update ON [SubscriptionPauses] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table SubscriptionPauses violates foreign key constraint FK_SubscriptionPauses_1_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fki_SubscriptionPlans_SubscriptionId1_Subscriptions_Id] BEFORE Insert ON [SubscriptionPlans] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table SubscriptionPlans violates foreign key constraint FK_SubscriptionPlans_0_0') WHERE (SELECT Id FROM Subscriptions WHERE  Id = NEW.SubscriptionId1) IS NULL; END;
CREATE TRIGGER [fku_SubscriptionPlans_SubscriptionId1_Subscriptions_Id] BEFORE Update ON [SubscriptionPlans] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table SubscriptionPlans violates foreign key constraint FK_SubscriptionPlans_0_0') WHERE (SELECT Id FROM Subscriptions WHERE  Id = NEW.SubscriptionId1) IS NULL; END;
CREATE TRIGGER [fki_SubscriptionPlans_ProductId1_Products_Id] BEFORE Insert ON [SubscriptionPlans] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table SubscriptionPlans violates foreign key constraint FK_SubscriptionPlans_1_0') WHERE (SELECT Id FROM Products WHERE  Id = NEW.ProductId1) IS NULL; END;
CREATE TRIGGER [fku_SubscriptionPlans_ProductId1_Products_Id] BEFORE Update ON [SubscriptionPlans] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table SubscriptionPlans violates foreign key constraint FK_SubscriptionPlans_1_0') WHERE (SELECT Id FROM Products WHERE  Id = NEW.ProductId1) IS NULL; END;
CREATE TRIGGER [fki_SubscriptionPlans_PlanId1_Plan_Id] BEFORE Insert ON [SubscriptionPlans] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table SubscriptionPlans violates foreign key constraint FK_SubscriptionPlans_2_0') WHERE (SELECT Id FROM Plan WHERE  Id = NEW.PlanId1) IS NULL; END;
CREATE TRIGGER [fku_SubscriptionPlans_PlanId1_Plan_Id] BEFORE Update ON [SubscriptionPlans] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table SubscriptionPlans violates foreign key constraint FK_SubscriptionPlans_2_0') WHERE (SELECT Id FROM Plan WHERE  Id = NEW.PlanId1) IS NULL; END;
CREATE TRIGGER [fki_SubscriptionPlans_CustomObjectsId_CustomObjects_Id] BEFORE Insert ON [SubscriptionPlans] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table SubscriptionPlans violates foreign key constraint FK_SubscriptionPlans_3_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fku_SubscriptionPlans_CustomObjectsId_CustomObjects_Id] BEFORE Update ON [SubscriptionPlans] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table SubscriptionPlans violates foreign key constraint FK_SubscriptionPlans_3_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fki_SubscriptionPlans_CustomFieldsId_CustomFields_Id] BEFORE Insert ON [SubscriptionPlans] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table SubscriptionPlans violates foreign key constraint FK_SubscriptionPlans_4_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fku_SubscriptionPlans_CustomFieldsId_CustomFields_Id] BEFORE Update ON [SubscriptionPlans] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table SubscriptionPlans violates foreign key constraint FK_SubscriptionPlans_4_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fki_SubscriptionRenews_TermsId_SubscriptionTerms_Id] BEFORE Insert ON [SubscriptionRenews] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table SubscriptionRenews violates foreign key constraint FK_SubscriptionRenews_0_0') WHERE (SELECT Id FROM SubscriptionTerms WHERE  Id = NEW.TermsId) IS NULL; END;
CREATE TRIGGER [fku_SubscriptionRenews_TermsId_SubscriptionTerms_Id] BEFORE Update ON [SubscriptionRenews] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table SubscriptionRenews violates foreign key constraint FK_SubscriptionRenews_0_0') WHERE (SELECT Id FROM SubscriptionTerms WHERE  Id = NEW.TermsId) IS NULL; END;
CREATE TRIGGER [fki_Subscriptions_RenewalTermId_Term_Id] BEFORE Insert ON [Subscriptions] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Subscriptions violates foreign key constraint FK_Subscriptions_0_0') WHERE (SELECT Id FROM Term WHERE  Id = NEW.RenewalTermId) IS NULL; END;
CREATE TRIGGER [fku_Subscriptions_RenewalTermId_Term_Id] BEFORE Update ON [Subscriptions] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Subscriptions violates foreign key constraint FK_Subscriptions_0_0') WHERE (SELECT Id FROM Term WHERE  Id = NEW.RenewalTermId) IS NULL; END;
CREATE TRIGGER [fki_Subscriptions_InitialTermId_Term_Id] BEFORE Insert ON [Subscriptions] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Subscriptions violates foreign key constraint FK_Subscriptions_1_0') WHERE (SELECT Id FROM Term WHERE  Id = NEW.InitialTermId) IS NULL; END;
CREATE TRIGGER [fku_Subscriptions_InitialTermId_Term_Id] BEFORE Update ON [Subscriptions] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Subscriptions violates foreign key constraint FK_Subscriptions_1_0') WHERE (SELECT Id FROM Term WHERE  Id = NEW.InitialTermId) IS NULL; END;
CREATE TRIGGER [fki_Subscriptions_CurrentTermId_Term_Id] BEFORE Insert ON [Subscriptions] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Subscriptions violates foreign key constraint FK_Subscriptions_2_0') WHERE (SELECT Id FROM Term WHERE  Id = NEW.CurrentTermId) IS NULL; END;
CREATE TRIGGER [fku_Subscriptions_CurrentTermId_Term_Id] BEFORE Update ON [Subscriptions] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Subscriptions violates foreign key constraint FK_Subscriptions_2_0') WHERE (SELECT Id FROM Term WHERE  Id = NEW.CurrentTermId) IS NULL; END;
CREATE TRIGGER [fki_Subscriptions_OrderId_Order_Id] BEFORE Insert ON [Subscriptions] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Subscriptions violates foreign key constraint FK_Subscriptions_3_0') WHERE NEW.OrderId IS NOT NULL AND(SELECT Id FROM Order WHERE  Id = NEW.OrderId) IS NULL; END;
CREATE TRIGGER [fku_Subscriptions_OrderId_Order_Id] BEFORE Update ON [Subscriptions] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Subscriptions violates foreign key constraint FK_Subscriptions_3_0') WHERE NEW.OrderId IS NOT NULL AND(SELECT Id FROM Order WHERE  Id = NEW.OrderId) IS NULL; END;
CREATE TRIGGER [fki_Subscriptions_CustomObjectsId_CustomObjects_Id] BEFORE Insert ON [Subscriptions] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Subscriptions violates foreign key constraint FK_Subscriptions_4_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fku_Subscriptions_CustomObjectsId_CustomObjects_Id] BEFORE Update ON [Subscriptions] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Subscriptions violates foreign key constraint FK_Subscriptions_4_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fki_Subscriptions_CustomFieldsId_CustomFields_Id] BEFORE Insert ON [Subscriptions] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Subscriptions violates foreign key constraint FK_Subscriptions_5_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fku_Subscriptions_CustomFieldsId_CustomFields_Id] BEFORE Update ON [Subscriptions] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Subscriptions violates foreign key constraint FK_Subscriptions_5_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fki_Subscriptions_SoldToId1_Contacts_Id] BEFORE Insert ON [Subscriptions] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Subscriptions violates foreign key constraint FK_Subscriptions_6_0') WHERE (SELECT Id FROM Contacts WHERE  Id = NEW.SoldToId1) IS NULL; END;
CREATE TRIGGER [fku_Subscriptions_SoldToId1_Contacts_Id] BEFORE Update ON [Subscriptions] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Subscriptions violates foreign key constraint FK_Subscriptions_6_0') WHERE (SELECT Id FROM Contacts WHERE  Id = NEW.SoldToId1) IS NULL; END;
CREATE TRIGGER [fki_Subscriptions_BillToId1_Contacts_Id] BEFORE Insert ON [Subscriptions] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Subscriptions violates foreign key constraint FK_Subscriptions_7_0') WHERE (SELECT Id FROM Contacts WHERE  Id = NEW.BillToId1) IS NULL; END;
CREATE TRIGGER [fku_Subscriptions_BillToId1_Contacts_Id] BEFORE Update ON [Subscriptions] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Subscriptions violates foreign key constraint FK_Subscriptions_7_0') WHERE (SELECT Id FROM Contacts WHERE  Id = NEW.BillToId1) IS NULL; END;
CREATE TRIGGER [fki_Subscriptions_BillingDocumentSettingsId_BillingDocumentSettings_Id] BEFORE Insert ON [Subscriptions] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Subscriptions violates foreign key constraint FK_Subscriptions_8_0') WHERE (SELECT Id FROM BillingDocumentSettings WHERE  Id = NEW.BillingDocumentSettingsId) IS NULL; END;
CREATE TRIGGER [fku_Subscriptions_BillingDocumentSettingsId_BillingDocumentSettings_Id] BEFORE Update ON [Subscriptions] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Subscriptions violates foreign key constraint FK_Subscriptions_8_0') WHERE (SELECT Id FROM BillingDocumentSettings WHERE  Id = NEW.BillingDocumentSettingsId) IS NULL; END;
CREATE TRIGGER [fki_Subscriptions_InvoiceOwnerAccountId1_Accounts_Id] BEFORE Insert ON [Subscriptions] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Subscriptions violates foreign key constraint FK_Subscriptions_9_0') WHERE (SELECT Id FROM Accounts WHERE  Id = NEW.InvoiceOwnerAccountId1) IS NULL; END;
CREATE TRIGGER [fku_Subscriptions_InvoiceOwnerAccountId1_Accounts_Id] BEFORE Update ON [Subscriptions] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Subscriptions violates foreign key constraint FK_Subscriptions_9_0') WHERE (SELECT Id FROM Accounts WHERE  Id = NEW.InvoiceOwnerAccountId1) IS NULL; END;
CREATE TRIGGER [fki_Subscriptions_AccountId1_Accounts_Id] BEFORE Insert ON [Subscriptions] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Subscriptions violates foreign key constraint FK_Subscriptions_10_0') WHERE (SELECT Id FROM Accounts WHERE  Id = NEW.AccountId1) IS NULL; END;
CREATE TRIGGER [fku_Subscriptions_AccountId1_Accounts_Id] BEFORE Update ON [Subscriptions] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Subscriptions violates foreign key constraint FK_Subscriptions_10_0') WHERE (SELECT Id FROM Accounts WHERE  Id = NEW.AccountId1) IS NULL; END;
CREATE TRIGGER [fki_SubscriptionTerms_RenewalTermId_Term_Id] BEFORE Insert ON [SubscriptionTerms] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table SubscriptionTerms violates foreign key constraint FK_SubscriptionTerms_0_0') WHERE (SELECT Id FROM Term WHERE  Id = NEW.RenewalTermId) IS NULL; END;
CREATE TRIGGER [fku_SubscriptionTerms_RenewalTermId_Term_Id] BEFORE Update ON [SubscriptionTerms] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table SubscriptionTerms violates foreign key constraint FK_SubscriptionTerms_0_0') WHERE (SELECT Id FROM Term WHERE  Id = NEW.RenewalTermId) IS NULL; END;
CREATE TRIGGER [fki_SubscriptionTerms_CurrentTermId_Term_Id] BEFORE Insert ON [SubscriptionTerms] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table SubscriptionTerms violates foreign key constraint FK_SubscriptionTerms_1_0') WHERE (SELECT Id FROM Term WHERE  Id = NEW.CurrentTermId) IS NULL; END;
CREATE TRIGGER [fku_SubscriptionTerms_CurrentTermId_Term_Id] BEFORE Update ON [SubscriptionTerms] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table SubscriptionTerms violates foreign key constraint FK_SubscriptionTerms_1_0') WHERE (SELECT Id FROM Term WHERE  Id = NEW.CurrentTermId) IS NULL; END;
CREATE TRIGGER [fki_TaxationItems_InvoiceItemId_InvoiceItems_Id] BEFORE Insert ON [TaxationItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table TaxationItems violates foreign key constraint FK_TaxationItems_0_0') WHERE NEW.InvoiceItemId IS NOT NULL AND(SELECT Id FROM InvoiceItems WHERE  Id = NEW.InvoiceItemId) IS NULL; END;
CREATE TRIGGER [fku_TaxationItems_InvoiceItemId_InvoiceItems_Id] BEFORE Update ON [TaxationItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table TaxationItems violates foreign key constraint FK_TaxationItems_0_0') WHERE NEW.InvoiceItemId IS NOT NULL AND(SELECT Id FROM InvoiceItems WHERE  Id = NEW.InvoiceItemId) IS NULL; END;
CREATE TRIGGER [fki_TaxationItems_DebitMemoItemId_DebitMemoItems_Id] BEFORE Insert ON [TaxationItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table TaxationItems violates foreign key constraint FK_TaxationItems_1_0') WHERE NEW.DebitMemoItemId IS NOT NULL AND(SELECT Id FROM DebitMemoItems WHERE  Id = NEW.DebitMemoItemId) IS NULL; END;
CREATE TRIGGER [fku_TaxationItems_DebitMemoItemId_DebitMemoItems_Id] BEFORE Update ON [TaxationItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table TaxationItems violates foreign key constraint FK_TaxationItems_1_0') WHERE NEW.DebitMemoItemId IS NOT NULL AND(SELECT Id FROM DebitMemoItems WHERE  Id = NEW.DebitMemoItemId) IS NULL; END;
CREATE TRIGGER [fki_TaxationItems_CustomObjectsId_CustomObjects_Id] BEFORE Insert ON [TaxationItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table TaxationItems violates foreign key constraint FK_TaxationItems_2_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fku_TaxationItems_CustomObjectsId_CustomObjects_Id] BEFORE Update ON [TaxationItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table TaxationItems violates foreign key constraint FK_TaxationItems_2_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fki_TaxationItems_CustomFieldsId_CustomFields_Id] BEFORE Insert ON [TaxationItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table TaxationItems violates foreign key constraint FK_TaxationItems_3_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fku_TaxationItems_CustomFieldsId_CustomFields_Id] BEFORE Update ON [TaxationItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table TaxationItems violates foreign key constraint FK_TaxationItems_3_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fki_TaxationItems_CreditMemoItemId_CreditMemoItems_Id] BEFORE Insert ON [TaxationItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table TaxationItems violates foreign key constraint FK_TaxationItems_4_0') WHERE NEW.CreditMemoItemId IS NOT NULL AND(SELECT Id FROM CreditMemoItems WHERE  Id = NEW.CreditMemoItemId) IS NULL; END;
CREATE TRIGGER [fku_TaxationItems_CreditMemoItemId_CreditMemoItems_Id] BEFORE Update ON [TaxationItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table TaxationItems violates foreign key constraint FK_TaxationItems_4_0') WHERE NEW.CreditMemoItemId IS NOT NULL AND(SELECT Id FROM CreditMemoItems WHERE  Id = NEW.CreditMemoItemId) IS NULL; END;
CREATE TRIGGER [fki_TaxationItems_BillingDocumentItemId_BillingDocumentItems_Id] BEFORE Insert ON [TaxationItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table TaxationItems violates foreign key constraint FK_TaxationItems_5_0') WHERE NEW.BillingDocumentItemId IS NOT NULL AND(SELECT Id FROM BillingDocumentItems WHERE  Id = NEW.BillingDocumentItemId) IS NULL; END;
CREATE TRIGGER [fku_TaxationItems_BillingDocumentItemId_BillingDocumentItems_Id] BEFORE Update ON [TaxationItems] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table TaxationItems violates foreign key constraint FK_TaxationItems_5_0') WHERE NEW.BillingDocumentItemId IS NOT NULL AND(SELECT Id FROM BillingDocumentItems WHERE  Id = NEW.BillingDocumentItemId) IS NULL; END;
CREATE TRIGGER [fki_Tier_PriceId_Price_Id] BEFORE Insert ON [Tier] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Tier violates foreign key constraint FK_Tier_0_0') WHERE NEW.PriceId IS NOT NULL AND(SELECT Id FROM Price WHERE  Id = NEW.PriceId) IS NULL; END;
CREATE TRIGGER [fku_Tier_PriceId_Price_Id] BEFORE Update ON [Tier] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Tier violates foreign key constraint FK_Tier_0_0') WHERE NEW.PriceId IS NOT NULL AND(SELECT Id FROM Price WHERE  Id = NEW.PriceId) IS NULL; END;
CREATE TRIGGER [fki_Tier_UnitAmountsId_Money_Id] BEFORE Insert ON [Tier] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Tier violates foreign key constraint FK_Tier_1_0') WHERE (SELECT Id FROM Money WHERE  Id = NEW.UnitAmountsId) IS NULL; END;
CREATE TRIGGER [fku_Tier_UnitAmountsId_Money_Id] BEFORE Update ON [Tier] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Tier violates foreign key constraint FK_Tier_1_0') WHERE (SELECT Id FROM Money WHERE  Id = NEW.UnitAmountsId) IS NULL; END;
CREATE TRIGGER [fki_Tier_AmountsId_Money_Id] BEFORE Insert ON [Tier] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Tier violates foreign key constraint FK_Tier_2_0') WHERE (SELECT Id FROM Money WHERE  Id = NEW.AmountsId) IS NULL; END;
CREATE TRIGGER [fku_Tier_AmountsId_Money_Id] BEFORE Update ON [Tier] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Tier violates foreign key constraint FK_Tier_2_0') WHERE (SELECT Id FROM Money WHERE  Id = NEW.AmountsId) IS NULL; END;
CREATE TRIGGER [fki_Usages_CustomObjectsId_CustomObjects_Id] BEFORE Insert ON [Usages] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Usages violates foreign key constraint FK_Usages_0_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fku_Usages_CustomObjectsId_CustomObjects_Id] BEFORE Update ON [Usages] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Usages violates foreign key constraint FK_Usages_0_0') WHERE (SELECT Id FROM CustomObjects WHERE  Id = NEW.CustomObjectsId) IS NULL; END;
CREATE TRIGGER [fki_Usages_CustomFieldsId_CustomFields_Id] BEFORE Insert ON [Usages] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Usages violates foreign key constraint FK_Usages_1_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fku_Usages_CustomFieldsId_CustomFields_Id] BEFORE Update ON [Usages] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Usages violates foreign key constraint FK_Usages_1_0') WHERE (SELECT Id FROM CustomFields WHERE  Id = NEW.CustomFieldsId) IS NULL; END;
CREATE TRIGGER [fki_Usages_AccountId1_Accounts_Id] BEFORE Insert ON [Usages] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Usages violates foreign key constraint FK_Usages_2_0') WHERE (SELECT Id FROM Accounts WHERE  Id = NEW.AccountId1) IS NULL; END;
CREATE TRIGGER [fku_Usages_AccountId1_Accounts_Id] BEFORE Update ON [Usages] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Usages violates foreign key constraint FK_Usages_2_0') WHERE (SELECT Id FROM Accounts WHERE  Id = NEW.AccountId1) IS NULL; END;
CREATE TRIGGER [fki_ValidityPeriod_PrepaidBalancesId_PrepaidBalances_Id] BEFORE Insert ON [ValidityPeriod] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table ValidityPeriod violates foreign key constraint FK_ValidityPeriod_0_0') WHERE NEW.PrepaidBalancesId IS NOT NULL AND(SELECT Id FROM PrepaidBalances WHERE  Id = NEW.PrepaidBalancesId) IS NULL; END;
CREATE TRIGGER [fku_ValidityPeriod_PrepaidBalancesId_PrepaidBalances_Id] BEFORE Update ON [ValidityPeriod] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table ValidityPeriod violates foreign key constraint FK_ValidityPeriod_0_0') WHERE NEW.PrepaidBalancesId IS NOT NULL AND(SELECT Id FROM PrepaidBalances WHERE  Id = NEW.PrepaidBalancesId) IS NULL; END;
COMMIT;

