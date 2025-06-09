using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    Country = table.Column<string>(type: "TEXT", nullable: true),
                    County = table.Column<string>(type: "TEXT", nullable: true),
                    Line1 = table.Column<string>(type: "TEXT", nullable: true),
                    Line2 = table.Column<string>(type: "TEXT", nullable: true),
                    PostalCode = table.Column<string>(type: "TEXT", nullable: true),
                    State = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AddressFieldDefinitions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    Country = table.Column<string>(type: "TEXT", nullable: true),
                    Line1 = table.Column<string>(type: "TEXT", nullable: true),
                    Line2 = table.Column<string>(type: "TEXT", nullable: true),
                    PostalCode = table.Column<string>(type: "TEXT", nullable: true),
                    State = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressFieldDefinitions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Amounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArTransaction",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreditMemoNumbers = table.Column<string>(type: "TEXT", nullable: false),
                    InvoiceNumbers = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArTransaction", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CcRefCard",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Brand = table.Column<string>(type: "TEXT", nullable: false),
                    ExpiryMonth = table.Column<decimal>(type: "TEXT", nullable: true),
                    ExpiryYear = table.Column<decimal>(type: "TEXT", nullable: true),
                    Last4 = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CcRefCard", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerAcceptanceMandate",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAcceptanceMandate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomFields",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomFields", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomObject",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomObject", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Detail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drawdown",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ConversionRate = table.Column<decimal>(type: "TEXT", nullable: true),
                    UnitOfMeasure = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drawdown", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GatewayOptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GatewayOptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GatewayStateTransitions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    MarkedForSubmissionTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    SettledTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    SubmittedTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GatewayStateTransitions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mandate",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Reason = table.Column<string>(type: "TEXT", nullable: false),
                    State = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mandate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Money",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Money", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Overage",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ApplyAtEndOfSmoothingPeriod = table.Column<bool>(type: "INTEGER", nullable: true),
                    CreditUnusedUnits = table.Column<bool>(type: "INTEGER", nullable: true),
                    IncludedUnits = table.Column<decimal>(type: "TEXT", nullable: true),
                    IntervalCount = table.Column<int>(type: "INTEGER", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Overage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentStateTransitions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CanceledTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentStateTransitions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaypalAdaptive",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    PreapprovalKey = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaypalAdaptive", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaypalExpress",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Baid = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaypalExpress", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaypalExpressNative",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Baid = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaypalExpressNative", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PrepaidBalance",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    PrepaidUOM = table.Column<Guid>(type: "TEXT", nullable: false),
                    RemainingBalance = table.Column<decimal>(type: "TEXT", nullable: true),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    TotalBalance = table.Column<decimal>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrepaidBalance", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prepayment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreditOption = table.Column<string>(type: "TEXT", nullable: false),
                    Quantity = table.Column<decimal>(type: "TEXT", nullable: true),
                    TotalQuantity = table.Column<decimal>(type: "TEXT", nullable: true),
                    UnitOfMeasure = table.Column<string>(type: "TEXT", nullable: false),
                    ValidityPeriod = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prepayment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recurring",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AlignmentBehavior = table.Column<string>(type: "TEXT", nullable: false),
                    DurationInterval = table.Column<string>(type: "TEXT", nullable: false),
                    DurationIntervalCount = table.Column<int>(type: "INTEGER", nullable: true),
                    Formula = table.Column<string>(type: "TEXT", nullable: false),
                    Interval = table.Column<string>(type: "TEXT", nullable: false),
                    IntervalCount = table.Column<int>(type: "INTEGER", nullable: true),
                    On = table.Column<string>(type: "TEXT", nullable: false),
                    RatingGroup = table.Column<string>(type: "TEXT", nullable: false),
                    RecurringOn = table.Column<string>(type: "TEXT", nullable: false),
                    Timing = table.Column<string>(type: "TEXT", nullable: false),
                    Usage = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recurring", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Revenue",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ExcludeItemBillingFromRevenueAccounting = table.Column<bool>(type: "INTEGER", nullable: true),
                    ExcludeItemBookingFromRevenueAccounting = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Revenue", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StateTransitions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CanceledTime = table.Column<string>(type: "TEXT", nullable: false),
                    PostedTime = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateTransitions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionCancel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CancelAt = table.Column<string>(type: "TEXT", nullable: false),
                    CancelDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionCancel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionRemovePlan",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    SubscriptionPlanId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionRemovePlan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaxCertificate",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CompanyCode = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    EntityUseCode = table.Column<string>(type: "TEXT", nullable: true),
                    IssuingJurisdiction = table.Column<string>(type: "TEXT", nullable: true),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    State = table.Column<string>(type: "TEXT", nullable: true),
                    TaxIdentifier = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxCertificate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaxIdentifier",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxIdentifier", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Term",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Interval = table.Column<string>(type: "TEXT", nullable: true),
                    IntervalCount = table.Column<int>(type: "INTEGER", nullable: true),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Term", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransactionsState",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Failed = table.Column<string>(type: "TEXT", nullable: false),
                    Succeeded = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionsState", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BillingDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AddressId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BillingDetails_AddressFieldDefinitions_AddressId",
                        column: x => x.AddressId,
                        principalTable: "AddressFieldDefinitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CardMandate",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomerAcceptanceId = table.Column<Guid>(type: "TEXT", nullable: false),
                    NetworkTransactionId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Reason = table.Column<string>(type: "TEXT", nullable: false),
                    State = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    Verified = table.Column<bool>(type: "INTEGER", nullable: true),
                    Verify = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardMandate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardMandate_CustomerAcceptanceMandate_CustomerAcceptanceId",
                        column: x => x.CustomerAcceptanceId,
                        principalTable: "CustomerAcceptanceMandate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResumeSubscription",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ExtendTerm = table.Column<bool>(type: "INTEGER", nullable: true),
                    ResumeAt = table.Column<string>(type: "TEXT", nullable: false),
                    ResumeDate = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumeSubscription", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResumeSubscription_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionAddPlan",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PlanId = table.Column<Guid>(type: "TEXT", nullable: true),
                    UniqueToken = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionAddPlan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubscriptionAddPlan_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountId = table.Column<Guid>(type: "TEXT", nullable: true),
                    AddressId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Fax = table.Column<string>(type: "TEXT", nullable: true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    HomePhone = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    MobilePhone = table.Column<string>(type: "TEXT", nullable: true),
                    Nickname = table.Column<string>(type: "TEXT", nullable: true),
                    OtherPhone = table.Column<string>(type: "TEXT", nullable: true),
                    OtherPhoneType = table.Column<string>(type: "TEXT", nullable: true),
                    TaxRegion = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    WorkEmail = table.Column<string>(type: "TEXT", nullable: true),
                    WorkPhone = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contact_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Contact_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Contact_CustomObject_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObject",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Active = table.Column<bool>(type: "INTEGER", nullable: true),
                    CreatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Sku = table.Column<string>(type: "TEXT", nullable: true),
                    EffectiveStartDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    EffectiveEndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Product_CustomObject_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObject",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AchDebit",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    BankAbaCode = table.Column<string>(type: "TEXT", nullable: false),
                    BankAccountName = table.Column<string>(type: "TEXT", nullable: false),
                    BankAccountNumber = table.Column<string>(type: "TEXT", nullable: false),
                    BankAccountType = table.Column<string>(type: "TEXT", nullable: false),
                    BankName = table.Column<string>(type: "TEXT", nullable: false),
                    MandateId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AchDebit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AchDebit_Mandate_MandateId",
                        column: x => x.MandateId,
                        principalTable: "Mandate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AuBecsDebit",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountNumber = table.Column<string>(type: "TEXT", nullable: false),
                    BranchCode = table.Column<string>(type: "TEXT", nullable: false),
                    MandateId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuBecsDebit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuBecsDebit_Mandate_MandateId",
                        column: x => x.MandateId,
                        principalTable: "Mandate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AutogiroDebit",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountNumber = table.Column<string>(type: "TEXT", nullable: false),
                    BranchCode = table.Column<string>(type: "TEXT", nullable: false),
                    IdentityNumber = table.Column<string>(type: "TEXT", nullable: false),
                    MandateId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutogiroDebit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AutogiroDebit_Mandate_MandateId",
                        column: x => x.MandateId,
                        principalTable: "Mandate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BacsDebit",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountNumber = table.Column<string>(type: "TEXT", nullable: false),
                    BankCode = table.Column<string>(type: "TEXT", nullable: false),
                    MandateId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BacsDebit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BacsDebit_Mandate_MandateId",
                        column: x => x.MandateId,
                        principalTable: "Mandate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BetalingsDebit",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountNumber = table.Column<string>(type: "TEXT", nullable: false),
                    BankCode = table.Column<string>(type: "TEXT", nullable: false),
                    IdentityNumber = table.Column<string>(type: "TEXT", nullable: false),
                    MandateId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BetalingsDebit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BetalingsDebit_Mandate_MandateId",
                        column: x => x.MandateId,
                        principalTable: "Mandate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CcRef",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CardId = table.Column<Guid>(type: "TEXT", nullable: false),
                    MandateId = table.Column<Guid>(type: "TEXT", nullable: false),
                    SecondToken = table.Column<string>(type: "TEXT", nullable: false),
                    Token = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CcRef", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CcRef_CcRefCard_CardId",
                        column: x => x.CardId,
                        principalTable: "CcRefCard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CcRef_Mandate_MandateId",
                        column: x => x.MandateId,
                        principalTable: "Mandate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GetCardList",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Brand = table.Column<string>(type: "TEXT", nullable: false),
                    ExpiryMonth = table.Column<decimal>(type: "TEXT", nullable: true),
                    ExpiryYear = table.Column<decimal>(type: "TEXT", nullable: true),
                    Last4 = table.Column<string>(type: "TEXT", nullable: false),
                    MandateId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GetCardList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GetCardList_Mandate_MandateId",
                        column: x => x.MandateId,
                        principalTable: "Mandate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NzBecsDebit",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountNumber = table.Column<string>(type: "TEXT", nullable: false),
                    BankCode = table.Column<string>(type: "TEXT", nullable: false),
                    BranchCode = table.Column<string>(type: "TEXT", nullable: false),
                    MandateId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NzBecsDebit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NzBecsDebit_Mandate_MandateId",
                        column: x => x.MandateId,
                        principalTable: "Mandate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PadDebit",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountNumber = table.Column<string>(type: "TEXT", nullable: false),
                    BankCode = table.Column<string>(type: "TEXT", nullable: false),
                    BranchCode = table.Column<string>(type: "TEXT", nullable: false),
                    MandateId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PadDebit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PadDebit_Mandate_MandateId",
                        column: x => x.MandateId,
                        principalTable: "Mandate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SepaDebit",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    BusinessIdentificationCode = table.Column<Guid>(type: "TEXT", nullable: false),
                    IBAN = table.Column<string>(type: "TEXT", nullable: false),
                    MandateId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SepaDebit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SepaDebit_Mandate_MandateId",
                        column: x => x.MandateId,
                        principalTable: "Mandate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionTerm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AutoRenew = table.Column<bool>(type: "INTEGER", nullable: true),
                    CurrentTermId = table.Column<Guid>(type: "TEXT", nullable: false),
                    RenewalTermId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionTerm", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubscriptionTerm_Term_CurrentTermId",
                        column: x => x.CurrentTermId,
                        principalTable: "Term",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubscriptionTerm_Term_RenewalTermId",
                        column: x => x.RenewalTermId,
                        principalTable: "Term",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTransaction",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Amount = table.Column<string>(type: "TEXT", nullable: false),
                    PaymentNumber = table.Column<string>(type: "TEXT", nullable: false),
                    StateId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ArTransactionsId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTransaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentTransaction_ArTransaction_ArTransactionsId",
                        column: x => x.ArTransactionsId,
                        principalTable: "ArTransaction",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PaymentTransaction_TransactionsState_StateId",
                        column: x => x.StateId,
                        principalTable: "TransactionsState",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RefundTransaction",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    InvoiceNumbers = table.Column<string>(type: "TEXT", nullable: false),
                    RefundNumber = table.Column<string>(type: "TEXT", nullable: false),
                    StateId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ArTransactionsId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefundTransaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefundTransaction_ArTransaction_ArTransactionsId",
                        column: x => x.ArTransactionsId,
                        principalTable: "ArTransaction",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RefundTransaction_TransactionsState_StateId",
                        column: x => x.StateId,
                        principalTable: "TransactionsState",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Card",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Brand = table.Column<string>(type: "TEXT", nullable: false),
                    CardNumber = table.Column<string>(type: "TEXT", nullable: false),
                    ExpiryMonth = table.Column<decimal>(type: "TEXT", nullable: true),
                    ExpiryYear = table.Column<decimal>(type: "TEXT", nullable: true),
                    Last4 = table.Column<string>(type: "TEXT", nullable: false),
                    MandateId = table.Column<Guid>(type: "TEXT", nullable: false),
                    SecurityCode = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Card", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Card_CardMandate_MandateId",
                        column: x => x.MandateId,
                        principalTable: "CardMandate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionPause",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PauseAt = table.Column<string>(type: "TEXT", nullable: false),
                    PauseDate = table.Column<string>(type: "TEXT", nullable: false),
                    PauseInterval = table.Column<string>(type: "TEXT", nullable: false),
                    PauseIntervalCount = table.Column<decimal>(type: "TEXT", nullable: true),
                    ResumeBehaviorId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionPause", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubscriptionPause_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubscriptionPause_ResumeSubscription_ResumeBehaviorId",
                        column: x => x.ResumeBehaviorId,
                        principalTable: "ResumeSubscription",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Plan",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Active = table.Column<bool>(type: "INTEGER", nullable: true),
                    ActiveCurrencies = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    PlanNumber = table.Column<string>(type: "TEXT", nullable: true),
                    ProductId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Sku = table.Column<string>(type: "TEXT", nullable: true),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    EffectiveStartDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    EffectiveEndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    Status = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plan_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Plan_CustomObject_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObject",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Plan_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductPlan",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Active = table.Column<bool>(type: "INTEGER", nullable: true),
                    ActiveCurrencies = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    PlanNumber = table.Column<string>(type: "TEXT", nullable: true),
                    ProductId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Sku = table.Column<string>(type: "TEXT", nullable: true),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPlan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductPlan_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductPlan_CustomObject_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObject",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductPlan_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionRenew",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    TermsId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionRenew", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubscriptionRenew_SubscriptionTerm_TermsId",
                        column: x => x.TermsId,
                        principalTable: "SubscriptionTerm",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplePay",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CardId = table.Column<Guid>(type: "TEXT", nullable: false),
                    MandateId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PaymentId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Token = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplePay", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplePay_Card_CardId",
                        column: x => x.CardId,
                        principalTable: "Card",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplePay_Mandate_MandateId",
                        column: x => x.MandateId,
                        principalTable: "Mandate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GooglePay",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CardId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Token = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GooglePay", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GooglePay_Card_CardId",
                        column: x => x.CardId,
                        principalTable: "Card",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Price",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountingCode = table.Column<string>(type: "TEXT", nullable: true),
                    Active = table.Column<bool>(type: "INTEGER", nullable: true),
                    AmountsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ApplyDiscountTo = table.Column<string>(type: "TEXT", nullable: true),
                    ChargeModel = table.Column<string>(type: "TEXT", nullable: true),
                    ChargeType = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CustomFieldPerUnitRate = table.Column<string>(type: "TEXT", nullable: true),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CustomFieldTotalAmount = table.Column<string>(type: "TEXT", nullable: true),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    DeferredRevenueAccountingCode = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    DiscountAmountsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    DiscountLevel = table.Column<string>(type: "TEXT", nullable: true),
                    DiscountPercent = table.Column<decimal>(type: "TEXT", nullable: true),
                    DrawdownId = table.Column<Guid>(type: "TEXT", nullable: true),
                    MaxQuantity = table.Column<decimal>(type: "TEXT", nullable: true),
                    MinQuantity = table.Column<decimal>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    OverageId = table.Column<Guid>(type: "TEXT", nullable: true),
                    PlanId = table.Column<Guid>(type: "TEXT", nullable: true),
                    PlanNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PrepaymentId = table.Column<Guid>(type: "TEXT", nullable: true),
                    PriceBaseInterval = table.Column<string>(type: "TEXT", nullable: true),
                    Quantity = table.Column<decimal>(type: "TEXT", nullable: true),
                    RecognizedRevenueAccountingCode = table.Column<string>(type: "TEXT", nullable: true),
                    RecurringId = table.Column<Guid>(type: "TEXT", nullable: true),
                    RevenueId = table.Column<Guid>(type: "TEXT", nullable: true),
                    RevenueRecognitionRule = table.Column<string>(type: "TEXT", nullable: true),
                    StackedDiscount = table.Column<bool>(type: "INTEGER", nullable: true),
                    StartEvent = table.Column<string>(type: "TEXT", nullable: true),
                    Taxable = table.Column<bool>(type: "INTEGER", nullable: true),
                    TaxCode = table.Column<string>(type: "TEXT", nullable: true),
                    TaxInclusive = table.Column<bool>(type: "INTEGER", nullable: true),
                    TiersMode = table.Column<string>(type: "TEXT", nullable: true),
                    UnitAmountsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    UnitOfMeasure = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Price", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Price_Amounts_AmountsId",
                        column: x => x.AmountsId,
                        principalTable: "Amounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Price_Amounts_DiscountAmountsId",
                        column: x => x.DiscountAmountsId,
                        principalTable: "Amounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Price_Amounts_UnitAmountsId",
                        column: x => x.UnitAmountsId,
                        principalTable: "Amounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Price_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Price_CustomObject_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObject",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Price_Drawdown_DrawdownId",
                        column: x => x.DrawdownId,
                        principalTable: "Drawdown",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Price_Overage_OverageId",
                        column: x => x.OverageId,
                        principalTable: "Overage",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Price_Plan_PlanId",
                        column: x => x.PlanId,
                        principalTable: "Plan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Price_Prepayment_PrepaymentId",
                        column: x => x.PrepaymentId,
                        principalTable: "Prepayment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Price_Recurring_RecurringId",
                        column: x => x.RecurringId,
                        principalTable: "Recurring",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Price_Revenue_RevenueId",
                        column: x => x.RevenueId,
                        principalTable: "Revenue",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductPrice",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountingCode = table.Column<string>(type: "TEXT", nullable: true),
                    Active = table.Column<bool>(type: "INTEGER", nullable: true),
                    AmountsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ApplyDiscountTo = table.Column<string>(type: "TEXT", nullable: true),
                    ChargeModel = table.Column<string>(type: "TEXT", nullable: true),
                    ChargeType = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CustomFieldPerUnitRate = table.Column<string>(type: "TEXT", nullable: true),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CustomFieldTotalAmount = table.Column<string>(type: "TEXT", nullable: true),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    DeferredRevenueAccountingCode = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    DiscountAmountsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    DiscountLevel = table.Column<string>(type: "TEXT", nullable: true),
                    DiscountPercent = table.Column<decimal>(type: "TEXT", nullable: true),
                    DrawdownId = table.Column<Guid>(type: "TEXT", nullable: true),
                    MaxQuantity = table.Column<decimal>(type: "TEXT", nullable: true),
                    MinQuantity = table.Column<decimal>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    OverageId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PlanNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PrepaymentId = table.Column<Guid>(type: "TEXT", nullable: true),
                    PriceBaseInterval = table.Column<string>(type: "TEXT", nullable: true),
                    PlanId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Quantity = table.Column<decimal>(type: "TEXT", nullable: true),
                    RecognizedRevenueAccountingCode = table.Column<string>(type: "TEXT", nullable: true),
                    RecurringId = table.Column<Guid>(type: "TEXT", nullable: true),
                    RevenueId = table.Column<Guid>(type: "TEXT", nullable: true),
                    RevenueRecognitionRule = table.Column<string>(type: "TEXT", nullable: true),
                    StackedDiscount = table.Column<bool>(type: "INTEGER", nullable: true),
                    StartEvent = table.Column<string>(type: "TEXT", nullable: true),
                    Taxable = table.Column<bool>(type: "INTEGER", nullable: true),
                    TaxCode = table.Column<string>(type: "TEXT", nullable: true),
                    TaxInclusive = table.Column<bool>(type: "INTEGER", nullable: true),
                    TiersMode = table.Column<string>(type: "TEXT", nullable: true),
                    UnitAmountsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    UnitOfMeasure = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ProductPlanId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPrice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductPrice_Amounts_AmountsId",
                        column: x => x.AmountsId,
                        principalTable: "Amounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductPrice_Amounts_DiscountAmountsId",
                        column: x => x.DiscountAmountsId,
                        principalTable: "Amounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductPrice_Amounts_UnitAmountsId",
                        column: x => x.UnitAmountsId,
                        principalTable: "Amounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductPrice_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductPrice_CustomObject_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObject",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductPrice_Drawdown_DrawdownId",
                        column: x => x.DrawdownId,
                        principalTable: "Drawdown",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductPrice_Overage_OverageId",
                        column: x => x.OverageId,
                        principalTable: "Overage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductPrice_Prepayment_PrepaymentId",
                        column: x => x.PrepaymentId,
                        principalTable: "Prepayment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductPrice_ProductPlan_ProductPlanId",
                        column: x => x.ProductPlanId,
                        principalTable: "ProductPlan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductPrice_Recurring_RecurringId",
                        column: x => x.RecurringId,
                        principalTable: "Recurring",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductPrice_Revenue_RevenueId",
                        column: x => x.RevenueId,
                        principalTable: "Revenue",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tier",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AmountsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    UnitAmountsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    UpTo = table.Column<decimal>(type: "TEXT", nullable: true),
                    PriceId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tier", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tier_Money_AmountsId",
                        column: x => x.AmountsId,
                        principalTable: "Money",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tier_Money_UnitAmountsId",
                        column: x => x.UnitAmountsId,
                        principalTable: "Money",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tier_Price_PriceId",
                        column: x => x.PriceId,
                        principalTable: "Price",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductTier",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AmountsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    UnitAmountsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    UpTo = table.Column<decimal>(type: "TEXT", nullable: true),
                    ProductPriceId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTier", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductTier_Money_AmountsId",
                        column: x => x.AmountsId,
                        principalTable: "Money",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTier_Money_UnitAmountsId",
                        column: x => x.UnitAmountsId,
                        principalTable: "Money",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTier_ProductPrice_ProductPriceId",
                        column: x => x.ProductPriceId,
                        principalTable: "ProductPrice",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountNumber = table.Column<string>(type: "TEXT", nullable: true),
                    AutoPay = table.Column<bool>(type: "INTEGER", nullable: true),
                    Batch = table.Column<string>(type: "TEXT", nullable: true),
                    BillCycleDay = table.Column<int>(type: "INTEGER", nullable: true),
                    BillingDocumentSettingsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CommunicationProfileId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CrmId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Currency = table.Column<string>(type: "TEXT", nullable: true),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    DefaultPaymentMethodId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Enabled = table.Column<bool>(type: "INTEGER", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    ParentAccountId = table.Column<Guid>(type: "TEXT", nullable: true),
                    PaymentGateway = table.Column<string>(type: "TEXT", nullable: true),
                    PaymentTerms = table.Column<string>(type: "TEXT", nullable: true),
                    RemainingCreditMemoBalance = table.Column<decimal>(type: "TEXT", nullable: true),
                    RemainingDebitMemoBalance = table.Column<decimal>(type: "TEXT", nullable: true),
                    RemainingInvoiceBalance = table.Column<decimal>(type: "TEXT", nullable: true),
                    RemainingPaymentBalance = table.Column<decimal>(type: "TEXT", nullable: true),
                    SalesRep = table.Column<string>(type: "TEXT", nullable: true),
                    SequenceSetId = table.Column<Guid>(type: "TEXT", nullable: true),
                    TaxCertificateId = table.Column<Guid>(type: "TEXT", nullable: true),
                    TaxIdentifierId = table.Column<Guid>(type: "TEXT", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Account_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Account_CustomObject_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObject",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Account_TaxCertificate_TaxCertificateId",
                        column: x => x.TaxCertificateId,
                        principalTable: "TaxCertificate",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Account_TaxIdentifier_TaxIdentifierId",
                        column: x => x.TaxIdentifierId,
                        principalTable: "TaxIdentifier",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BillingDocument",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountId = table.Column<Guid>(type: "TEXT", nullable: true),
                    AccountNumber = table.Column<string>(type: "TEXT", nullable: true),
                    AmountPaid = table.Column<decimal>(type: "TEXT", nullable: true),
                    AmountRefunded = table.Column<decimal>(type: "TEXT", nullable: true),
                    Balance = table.Column<decimal>(type: "TEXT", nullable: true),
                    BillingDocumentNumber = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    DocumentDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DueDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ExcludeFromAutoApplyRules = table.Column<bool>(type: "INTEGER", nullable: true),
                    InvoiceId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Paid = table.Column<bool>(type: "INTEGER", nullable: true),
                    PastDue = table.Column<bool>(type: "INTEGER", nullable: true),
                    Pay = table.Column<bool>(type: "INTEGER", nullable: true),
                    PostedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    ReasonCode = table.Column<string>(type: "TEXT", nullable: true),
                    RemainingBalance = table.Column<decimal>(type: "TEXT", nullable: true),
                    State = table.Column<string>(type: "TEXT", nullable: true),
                    Subtotal = table.Column<decimal>(type: "TEXT", nullable: true),
                    Tax = table.Column<decimal>(type: "TEXT", nullable: true),
                    Total = table.Column<decimal>(type: "TEXT", nullable: true),
                    TransferToAccounting = table.Column<bool>(type: "INTEGER", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingDocument", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BillingDocument_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BillingDocument_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BillingDocument_CustomObject_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObject",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BillTo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountId = table.Column<Guid>(type: "TEXT", nullable: true),
                    AddressId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Fax = table.Column<string>(type: "TEXT", nullable: true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    HomePhone = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    MobilePhone = table.Column<string>(type: "TEXT", nullable: true),
                    Nickname = table.Column<string>(type: "TEXT", nullable: true),
                    OtherPhone = table.Column<string>(type: "TEXT", nullable: true),
                    OtherPhoneType = table.Column<string>(type: "TEXT", nullable: true),
                    TaxRegion = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    WorkEmail = table.Column<string>(type: "TEXT", nullable: true),
                    WorkPhone = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillTo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BillTo_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BillTo_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BillTo_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BillTo_CustomObject_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObject",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CreditMemo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountId = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountNumber = table.Column<string>(type: "TEXT", nullable: false),
                    AmountRefunded = table.Column<decimal>(type: "TEXT", nullable: true),
                    Balance = table.Column<decimal>(type: "TEXT", nullable: true),
                    BillToId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedById = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CreditMemoNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Currency = table.Column<string>(type: "TEXT", nullable: false),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    DocumentDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ExcludeFromAutoApplyRules = table.Column<bool>(type: "INTEGER", nullable: true),
                    InvoiceId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PostedById = table.Column<Guid>(type: "TEXT", nullable: false),
                    ReasonCode = table.Column<string>(type: "TEXT", nullable: false),
                    RemainingBalance = table.Column<decimal>(type: "TEXT", nullable: true),
                    State = table.Column<string>(type: "TEXT", nullable: false),
                    StateTransitionsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Subtotal = table.Column<decimal>(type: "TEXT", nullable: true),
                    Tax = table.Column<decimal>(type: "TEXT", nullable: true),
                    Total = table.Column<decimal>(type: "TEXT", nullable: true),
                    TransferToAccounting = table.Column<bool>(type: "INTEGER", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ArTransactionsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreditMemoId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditMemo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CreditMemo_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CreditMemo_ArTransaction_ArTransactionsId",
                        column: x => x.ArTransactionsId,
                        principalTable: "ArTransaction",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CreditMemo_Contact_BillToId",
                        column: x => x.BillToId,
                        principalTable: "Contact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CreditMemo_CreditMemo_CreditMemoId",
                        column: x => x.CreditMemoId,
                        principalTable: "CreditMemo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CreditMemo_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CreditMemo_CustomObject_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CreditMemo_StateTransitions_StateTransitionsId",
                        column: x => x.StateTransitionsId,
                        principalTable: "StateTransitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Category = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    OrderNumber = table.Column<string>(type: "TEXT", nullable: true),
                    State = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Order_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Order_CustomObject_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObject",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethod",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountId = table.Column<Guid>(type: "TEXT", nullable: true),
                    AchDebitId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ApplePayId = table.Column<Guid>(type: "TEXT", nullable: true),
                    AuBecsDebitId = table.Column<Guid>(type: "TEXT", nullable: true),
                    AutoGenerated = table.Column<bool>(type: "INTEGER", nullable: true),
                    AutogiroDebitId = table.Column<Guid>(type: "TEXT", nullable: true),
                    BacsDebitId = table.Column<Guid>(type: "TEXT", nullable: true),
                    BankIdentificationNumber = table.Column<Guid>(type: "TEXT", nullable: true),
                    BetalingsDebitId = table.Column<Guid>(type: "TEXT", nullable: true),
                    BillingDetailsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CardId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CcRefId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CustomType = table.Column<string>(type: "TEXT", nullable: true),
                    DeviceSessionId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ExistingMandate = table.Column<bool>(type: "INTEGER", nullable: true),
                    GooglePayId = table.Column<Guid>(type: "TEXT", nullable: true),
                    IpAddress = table.Column<string>(type: "TEXT", nullable: true),
                    LastFailedSaleTransactionTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    LastTransactionStatus = table.Column<string>(type: "TEXT", nullable: true),
                    LastTransactionTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    MaximumPaymentAttempts = table.Column<int>(type: "INTEGER", nullable: true),
                    NumberOfConsecutiveFailures = table.Column<int>(type: "INTEGER", nullable: true),
                    NzBecsDebitId = table.Column<Guid>(type: "TEXT", nullable: true),
                    PadDebitId = table.Column<Guid>(type: "TEXT", nullable: true),
                    PaymentRetryInterval = table.Column<int>(type: "INTEGER", nullable: true),
                    PaypalAdaptiveId = table.Column<Guid>(type: "TEXT", nullable: true),
                    PaypalExpressId = table.Column<Guid>(type: "TEXT", nullable: true),
                    PaypalExpressNativeId = table.Column<Guid>(type: "TEXT", nullable: true),
                    SepaDebitId = table.Column<Guid>(type: "TEXT", nullable: true),
                    State = table.Column<string>(type: "TEXT", nullable: true),
                    TotalNumberOfErrorPayments = table.Column<int>(type: "INTEGER", nullable: true),
                    TotalNumberOfProcessedPayments = table.Column<int>(type: "INTEGER", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UseDefaultRetryRule = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethod", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentMethod_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PaymentMethod_AchDebit_AchDebitId",
                        column: x => x.AchDebitId,
                        principalTable: "AchDebit",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PaymentMethod_ApplePay_ApplePayId",
                        column: x => x.ApplePayId,
                        principalTable: "ApplePay",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PaymentMethod_AuBecsDebit_AuBecsDebitId",
                        column: x => x.AuBecsDebitId,
                        principalTable: "AuBecsDebit",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PaymentMethod_AutogiroDebit_AutogiroDebitId",
                        column: x => x.AutogiroDebitId,
                        principalTable: "AutogiroDebit",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PaymentMethod_BacsDebit_BacsDebitId",
                        column: x => x.BacsDebitId,
                        principalTable: "BacsDebit",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PaymentMethod_BetalingsDebit_BetalingsDebitId",
                        column: x => x.BetalingsDebitId,
                        principalTable: "BetalingsDebit",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PaymentMethod_BillingDetails_BillingDetailsId",
                        column: x => x.BillingDetailsId,
                        principalTable: "BillingDetails",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PaymentMethod_CcRef_CcRefId",
                        column: x => x.CcRefId,
                        principalTable: "CcRef",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PaymentMethod_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PaymentMethod_CustomObject_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObject",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PaymentMethod_GetCardList_CardId",
                        column: x => x.CardId,
                        principalTable: "GetCardList",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PaymentMethod_GooglePay_GooglePayId",
                        column: x => x.GooglePayId,
                        principalTable: "GooglePay",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PaymentMethod_NzBecsDebit_NzBecsDebitId",
                        column: x => x.NzBecsDebitId,
                        principalTable: "NzBecsDebit",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PaymentMethod_PadDebit_PadDebitId",
                        column: x => x.PadDebitId,
                        principalTable: "PadDebit",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PaymentMethod_PaypalAdaptive_PaypalAdaptiveId",
                        column: x => x.PaypalAdaptiveId,
                        principalTable: "PaypalAdaptive",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PaymentMethod_PaypalExpressNative_PaypalExpressNativeId",
                        column: x => x.PaypalExpressNativeId,
                        principalTable: "PaypalExpressNative",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PaymentMethod_PaypalExpress_PaypalExpressId",
                        column: x => x.PaypalExpressId,
                        principalTable: "PaypalExpress",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PaymentMethod_SepaDebit_SepaDebitId",
                        column: x => x.SepaDebitId,
                        principalTable: "SepaDebit",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SoldTo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountId = table.Column<Guid>(type: "TEXT", nullable: true),
                    AddressId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Fax = table.Column<string>(type: "TEXT", nullable: true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    HomePhone = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    MobilePhone = table.Column<string>(type: "TEXT", nullable: true),
                    Nickname = table.Column<string>(type: "TEXT", nullable: true),
                    OtherPhone = table.Column<string>(type: "TEXT", nullable: true),
                    OtherPhoneType = table.Column<string>(type: "TEXT", nullable: true),
                    TaxRegion = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    WorkEmail = table.Column<string>(type: "TEXT", nullable: true),
                    WorkPhone = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoldTo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SoldTo_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SoldTo_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SoldTo_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SoldTo_CustomObject_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObject",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Usage",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountId = table.Column<Guid>(type: "TEXT", nullable: true),
                    AccountNumber = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    EndTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Quantity = table.Column<double>(type: "REAL", nullable: true),
                    StartTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    State = table.Column<string>(type: "TEXT", nullable: true),
                    SubscriptionId = table.Column<Guid>(type: "TEXT", nullable: true),
                    SubscriptionItemId = table.Column<Guid>(type: "TEXT", nullable: true),
                    SubscriptionItemNumber = table.Column<string>(type: "TEXT", nullable: true),
                    SubscriptionNumber = table.Column<string>(type: "TEXT", nullable: true),
                    UnitOfMeasure = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usage_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Usage_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Usage_CustomObject_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObject",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BillingDocumentStateTransitions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CanceledTime = table.Column<string>(type: "TEXT", nullable: true),
                    PostedTime = table.Column<string>(type: "TEXT", nullable: true),
                    BillingDocumentId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingDocumentStateTransitions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BillingDocumentStateTransitions_BillingDocument_BillingDocumentId",
                        column: x => x.BillingDocumentId,
                        principalTable: "BillingDocument",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CreditMemoAppliedTo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: true),
                    BillingDocumentId = table.Column<Guid>(type: "TEXT", nullable: false),
                    BillingDocumentType = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditMemoAppliedTo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CreditMemoAppliedTo_BillingDocument_BillingDocumentId",
                        column: x => x.BillingDocumentId,
                        principalTable: "BillingDocument",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentSchedule",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountId = table.Column<Guid>(type: "TEXT", nullable: true),
                    AccountNumber = table.Column<string>(type: "TEXT", nullable: true),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: true),
                    BillingDocumentId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Currency = table.Column<string>(type: "TEXT", nullable: true),
                    Custom = table.Column<bool>(type: "INTEGER", nullable: true),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    NextPaymentDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    NumberOfPayments = table.Column<int>(type: "INTEGER", nullable: true),
                    PaymentGatewayId = table.Column<string>(type: "TEXT", nullable: true),
                    PaymentMethodId = table.Column<string>(type: "TEXT", nullable: true),
                    PaymentScheduleNumber = table.Column<string>(type: "TEXT", nullable: true),
                    Period = table.Column<string>(type: "TEXT", nullable: true),
                    Prepayment = table.Column<bool>(type: "INTEGER", nullable: true),
                    RecentPaymentDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    RunHour = table.Column<int>(type: "INTEGER", nullable: true),
                    Standalone = table.Column<bool>(type: "INTEGER", nullable: true),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    State = table.Column<string>(type: "TEXT", nullable: true),
                    TotalAmount = table.Column<decimal>(type: "TEXT", nullable: true),
                    TotalPaymentsErrored = table.Column<int>(type: "INTEGER", nullable: true),
                    TotalPaymentsProcessed = table.Column<int>(type: "INTEGER", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentSchedule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentSchedule_BillingDocument_BillingDocumentId",
                        column: x => x.BillingDocumentId,
                        principalTable: "BillingDocument",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PaymentSchedule_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PaymentSchedule_CustomObject_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObject",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BillingDocumentSetting",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AdditionalEmail = table.Column<string>(type: "TEXT", nullable: false),
                    CreditMemoTemplateId = table.Column<string>(type: "TEXT", nullable: false),
                    DebitMemoTemplateId = table.Column<Guid>(type: "TEXT", nullable: false),
                    EmailDocuments = table.Column<bool>(type: "INTEGER", nullable: true),
                    InvoiceTemplateId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PrintDocuments = table.Column<bool>(type: "INTEGER", nullable: true),
                    CreditMemoId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingDocumentSetting", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BillingDocumentSetting_CreditMemo_CreditMemoId",
                        column: x => x.CreditMemoId,
                        principalTable: "CreditMemo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrderLineItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountingCode = table.Column<string>(type: "TEXT", nullable: true),
                    AdjustmentLiabilityAccount = table.Column<string>(type: "TEXT", nullable: true),
                    BillingRule = table.Column<string>(type: "TEXT", nullable: true),
                    Category = table.Column<string>(type: "TEXT", nullable: true),
                    ContractAssetAccount = table.Column<string>(type: "TEXT", nullable: true),
                    ContractLiabilityAccount = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    DiscountPercent = table.Column<decimal>(type: "TEXT", nullable: true),
                    DiscountTotal = table.Column<decimal>(type: "TEXT", nullable: true),
                    DiscountUnitAmount = table.Column<decimal>(type: "TEXT", nullable: true),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ItemNumber = table.Column<string>(type: "TEXT", nullable: true),
                    ListPrice = table.Column<decimal>(type: "TEXT", nullable: true),
                    ListUnitPrice = table.Column<decimal>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    OrderId = table.Column<Guid>(type: "TEXT", nullable: true),
                    OriginalOrderDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    OriginalOrderId = table.Column<Guid>(type: "TEXT", nullable: true),
                    OriginalOrderLineItemId = table.Column<Guid>(type: "TEXT", nullable: true),
                    OriginalOrderLineItemNumber = table.Column<string>(type: "TEXT", nullable: true),
                    OriginalOrderNumber = table.Column<string>(type: "TEXT", nullable: true),
                    OriginalSoldToId = table.Column<Guid>(type: "TEXT", nullable: true),
                    PriceId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ProductCode = table.Column<string>(type: "TEXT", nullable: true),
                    PurchaseOrderNumber = table.Column<string>(type: "TEXT", nullable: true),
                    Quantity = table.Column<decimal>(type: "TEXT", nullable: true),
                    QuantityAvailableForReturn = table.Column<decimal>(type: "TEXT", nullable: true),
                    QuantityFulfilled = table.Column<decimal>(type: "TEXT", nullable: true),
                    QuantityPendingFulfillment = table.Column<decimal>(type: "TEXT", nullable: true),
                    RelatedSubscriptionNumber = table.Column<string>(type: "TEXT", nullable: true),
                    RequiresFulfillment = table.Column<bool>(type: "INTEGER", nullable: true),
                    Revenue = table.Column<decimal>(type: "TEXT", nullable: true),
                    SoldToId = table.Column<Guid>(type: "TEXT", nullable: true),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    State = table.Column<string>(type: "TEXT", nullable: true),
                    Subtotal = table.Column<decimal>(type: "TEXT", nullable: true),
                    TargetDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    TaxCode = table.Column<string>(type: "TEXT", nullable: true),
                    TaxInclusive = table.Column<bool>(type: "INTEGER", nullable: true),
                    Total = table.Column<decimal>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    UnbilledReceivablesAccount = table.Column<string>(type: "TEXT", nullable: true),
                    UnitAmount = table.Column<decimal>(type: "TEXT", nullable: true),
                    UnitOfMeasure = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderLineItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderLineItem_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderLineItem_CustomObject_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObject",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderLineItem_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountId = table.Column<Guid>(type: "TEXT", nullable: true),
                    AccountNumber = table.Column<string>(type: "TEXT", nullable: true),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: true),
                    AmountApplied = table.Column<decimal>(type: "TEXT", nullable: true),
                    AmountRefunded = table.Column<decimal>(type: "TEXT", nullable: true),
                    AuthorizationId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Currency = table.Column<string>(type: "TEXT", nullable: true),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    External = table.Column<bool>(type: "INTEGER", nullable: true),
                    GatewayId = table.Column<Guid>(type: "TEXT", nullable: true),
                    GatewayOptionsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    GatewayOrderId = table.Column<Guid>(type: "TEXT", nullable: true),
                    GatewayReconciliationReason = table.Column<string>(type: "TEXT", nullable: true),
                    GatewayReconciliationStatus = table.Column<string>(type: "TEXT", nullable: true),
                    GatewayResponse = table.Column<string>(type: "TEXT", nullable: true),
                    GatewayResponseCode = table.Column<string>(type: "TEXT", nullable: true),
                    GatewayState = table.Column<string>(type: "TEXT", nullable: true),
                    GatewayStateTransitionsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    PaymentMethodId = table.Column<Guid>(type: "TEXT", nullable: true),
                    PaymentNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PayoutId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ReferenceId = table.Column<Guid>(type: "TEXT", nullable: false),
                    RemainingBalance = table.Column<decimal>(type: "TEXT", nullable: true),
                    SecondReferenceId = table.Column<Guid>(type: "TEXT", nullable: false),
                    State = table.Column<string>(type: "TEXT", nullable: false),
                    StatementDescriptor = table.Column<string>(type: "TEXT", nullable: false),
                    StatementDescriptorPhone = table.Column<string>(type: "TEXT", nullable: false),
                    StateTransitionsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    PaymentTransactionsId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payment_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Payment_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Payment_CustomObject_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObject",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Payment_GatewayOptions_GatewayOptionsId",
                        column: x => x.GatewayOptionsId,
                        principalTable: "GatewayOptions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Payment_GatewayStateTransitions_GatewayStateTransitionsId",
                        column: x => x.GatewayStateTransitionsId,
                        principalTable: "GatewayStateTransitions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Payment_PaymentMethod_PaymentMethodId",
                        column: x => x.PaymentMethodId,
                        principalTable: "PaymentMethod",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Payment_PaymentStateTransitions_StateTransitionsId",
                        column: x => x.StateTransitionsId,
                        principalTable: "PaymentStateTransitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payment_PaymentTransaction_PaymentTransactionsId",
                        column: x => x.PaymentTransactionsId,
                        principalTable: "PaymentTransaction",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Refund",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: true),
                    BankAccountAccount = table.Column<string>(type: "TEXT", nullable: true),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CreditMemoId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    External = table.Column<bool>(type: "INTEGER", nullable: true),
                    GatewayId = table.Column<Guid>(type: "TEXT", nullable: true),
                    GatewayOptionsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    GatewayReconciliationReason = table.Column<string>(type: "TEXT", nullable: true),
                    GatewayReconciliationStatus = table.Column<string>(type: "TEXT", nullable: true),
                    GatewayResponse = table.Column<string>(type: "TEXT", nullable: true),
                    GatewayResponseCode = table.Column<string>(type: "TEXT", nullable: true),
                    GatewayState = table.Column<string>(type: "TEXT", nullable: true),
                    OnAccountAccount = table.Column<string>(type: "TEXT", nullable: true),
                    PaymentId = table.Column<Guid>(type: "TEXT", nullable: true),
                    PaymentMethodId = table.Column<Guid>(type: "TEXT", nullable: true),
                    PayoutId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ReasonCode = table.Column<string>(type: "TEXT", nullable: true),
                    ReferenceId = table.Column<Guid>(type: "TEXT", nullable: true),
                    RefundDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    RefundMethodType = table.Column<string>(type: "TEXT", nullable: true),
                    RefundNumber = table.Column<string>(type: "TEXT", nullable: true),
                    SecondReferenceId = table.Column<Guid>(type: "TEXT", nullable: true),
                    State = table.Column<string>(type: "TEXT", nullable: true),
                    StatementDescriptor = table.Column<string>(type: "TEXT", nullable: true),
                    StatementDescriptorPhone = table.Column<string>(type: "TEXT", nullable: true),
                    UnappliedPaymentAccount = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    RefundTransactionsId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Refund", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Refund_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Refund_CreditMemo_CreditMemoId",
                        column: x => x.CreditMemoId,
                        principalTable: "CreditMemo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Refund_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Refund_CustomObject_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObject",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Refund_GatewayOptions_GatewayOptionsId",
                        column: x => x.GatewayOptionsId,
                        principalTable: "GatewayOptions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Refund_PaymentMethod_PaymentMethodId",
                        column: x => x.PaymentMethodId,
                        principalTable: "PaymentMethod",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Refund_RefundTransaction_RefundTransactionsId",
                        column: x => x.RefundTransactionsId,
                        principalTable: "RefundTransaction",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PaymentOption",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    DetailId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Type = table.Column<bool>(type: "INTEGER", nullable: true),
                    PaymentScheduleId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentOption", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentOption_Detail_DetailId",
                        column: x => x.DetailId,
                        principalTable: "Detail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentOption_PaymentSchedule_PaymentScheduleId",
                        column: x => x.PaymentScheduleId,
                        principalTable: "PaymentSchedule",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DebitMemo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountId = table.Column<Guid>(type: "TEXT", nullable: true),
                    AccountNumber = table.Column<string>(type: "TEXT", nullable: true),
                    AmountPaid = table.Column<decimal>(type: "TEXT", nullable: true),
                    AmountRefunded = table.Column<decimal>(type: "TEXT", nullable: true),
                    Balance = table.Column<decimal>(type: "TEXT", nullable: true),
                    BillingDocumentSettingsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    BillToId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Currency = table.Column<string>(type: "TEXT", nullable: true),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    DebitMemoNumber = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    DocumentDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DueDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ExcludeFromAutoApplyRules = table.Column<bool>(type: "INTEGER", nullable: true),
                    InvoiceId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Paid = table.Column<bool>(type: "INTEGER", nullable: true),
                    PastDue = table.Column<bool>(type: "INTEGER", nullable: true),
                    Pay = table.Column<bool>(type: "INTEGER", nullable: true),
                    PaymentTerms = table.Column<string>(type: "TEXT", nullable: false),
                    PostedById = table.Column<Guid>(type: "TEXT", nullable: false),
                    ReasonCode = table.Column<string>(type: "TEXT", nullable: false),
                    RemainingBalance = table.Column<decimal>(type: "TEXT", nullable: true),
                    State = table.Column<string>(type: "TEXT", nullable: false),
                    StateTransitionsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Subtotal = table.Column<decimal>(type: "TEXT", nullable: true),
                    Tax = table.Column<decimal>(type: "TEXT", nullable: true),
                    Total = table.Column<decimal>(type: "TEXT", nullable: true),
                    TransferToAccounting = table.Column<bool>(type: "INTEGER", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DebitMemo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DebitMemo_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DebitMemo_BillingDocumentSetting_BillingDocumentSettingsId",
                        column: x => x.BillingDocumentSettingsId,
                        principalTable: "BillingDocumentSetting",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DebitMemo_Contact_BillToId",
                        column: x => x.BillToId,
                        principalTable: "Contact",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DebitMemo_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DebitMemo_CustomObject_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObject",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DebitMemo_StateTransitions_StateTransitionsId",
                        column: x => x.StateTransitionsId,
                        principalTable: "StateTransitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Invoice",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountId = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Balance = table.Column<decimal>(type: "TEXT", nullable: true),
                    BillingDocumentSettingsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    BillToId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedById = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Currency = table.Column<string>(type: "TEXT", nullable: false),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    DocumentDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DueDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    InvoiceNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Paid = table.Column<bool>(type: "INTEGER", nullable: true),
                    PastDue = table.Column<bool>(type: "INTEGER", nullable: true),
                    Pay = table.Column<bool>(type: "INTEGER", nullable: true),
                    PaymentTerms = table.Column<string>(type: "TEXT", nullable: false),
                    PostedById = table.Column<Guid>(type: "TEXT", nullable: false),
                    RemainingBalance = table.Column<decimal>(type: "TEXT", nullable: true),
                    SoldToId = table.Column<Guid>(type: "TEXT", nullable: false),
                    State = table.Column<string>(type: "TEXT", nullable: false),
                    StateTransitionsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Subtotal = table.Column<decimal>(type: "TEXT", nullable: true),
                    Tax = table.Column<decimal>(type: "TEXT", nullable: true),
                    Total = table.Column<decimal>(type: "TEXT", nullable: true),
                    TransferToAccounting = table.Column<bool>(type: "INTEGER", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ArTransactionsId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoice_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invoice_ArTransaction_ArTransactionsId",
                        column: x => x.ArTransactionsId,
                        principalTable: "ArTransaction",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Invoice_BillingDocumentSetting_BillingDocumentSettingsId",
                        column: x => x.BillingDocumentSettingsId,
                        principalTable: "BillingDocumentSetting",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invoice_Contact_BillToId",
                        column: x => x.BillToId,
                        principalTable: "Contact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invoice_Contact_SoldToId",
                        column: x => x.SoldToId,
                        principalTable: "Contact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invoice_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invoice_CustomObject_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invoice_StateTransitions_StateTransitionsId",
                        column: x => x.StateTransitionsId,
                        principalTable: "StateTransitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subscription",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountId = table.Column<Guid>(type: "TEXT", nullable: true),
                    AutoRenew = table.Column<bool>(type: "INTEGER", nullable: true),
                    BillingDocumentSettingsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    BillToId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CancelReason = table.Column<string>(type: "TEXT", nullable: true),
                    ContractedMrr = table.Column<string>(type: "TEXT", nullable: true),
                    ContractEffective = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CreatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Currency = table.Column<string>(type: "TEXT", nullable: false),
                    CurrentTermId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CustomerAcceptance = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    InitialTermId = table.Column<Guid>(type: "TEXT", nullable: true),
                    InvoiceOwnerAccountId = table.Column<Guid>(type: "TEXT", nullable: true),
                    InvoiceSeparately = table.Column<bool>(type: "INTEGER", nullable: true),
                    LastBookingDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    LatestVersion = table.Column<bool>(type: "INTEGER", nullable: true),
                    OrderNumber = table.Column<string>(type: "TEXT", nullable: false),
                    PaymentTerms = table.Column<string>(type: "TEXT", nullable: true),
                    PrepaidBalanceId = table.Column<Guid>(type: "TEXT", nullable: true),
                    RenewalTermId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ServiceActivation = table.Column<DateTime>(type: "TEXT", nullable: true),
                    SoldToId = table.Column<Guid>(type: "TEXT", nullable: true),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    State = table.Column<string>(type: "TEXT", nullable: true),
                    SubscriptionNumber = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Version = table.Column<int>(type: "INTEGER", nullable: true),
                    OrderId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscription", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subscription_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Subscription_Account_InvoiceOwnerAccountId",
                        column: x => x.InvoiceOwnerAccountId,
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Subscription_BillingDocumentSetting_BillingDocumentSettingsId",
                        column: x => x.BillingDocumentSettingsId,
                        principalTable: "BillingDocumentSetting",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Subscription_Contact_BillToId",
                        column: x => x.BillToId,
                        principalTable: "Contact",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Subscription_Contact_SoldToId",
                        column: x => x.SoldToId,
                        principalTable: "Contact",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Subscription_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Subscription_CustomObject_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObject",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Subscription_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Subscription_PrepaidBalance_PrepaidBalanceId",
                        column: x => x.PrepaidBalanceId,
                        principalTable: "PrepaidBalance",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Subscription_Term_CurrentTermId",
                        column: x => x.CurrentTermId,
                        principalTable: "Term",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Subscription_Term_InitialTermId",
                        column: x => x.InitialTermId,
                        principalTable: "Term",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Subscription_Term_RenewalTermId",
                        column: x => x.RenewalTermId,
                        principalTable: "Term",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PaymentsAppliedTo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: true),
                    BillingDocumentId = table.Column<Guid>(type: "TEXT", nullable: false),
                    BillingDocumentType = table.Column<string>(type: "TEXT", nullable: false),
                    State = table.Column<string>(type: "TEXT", nullable: false),
                    PaymentId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentsAppliedTo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentsAppliedTo_BillingDocument_BillingDocumentId",
                        column: x => x.BillingDocumentId,
                        principalTable: "BillingDocument",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentsAppliedTo_Payment_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payment",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PaymentScheduleItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: true),
                    Balance = table.Column<decimal>(type: "TEXT", nullable: true),
                    BillingDocumentId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CancellationReason = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Currency = table.Column<string>(type: "TEXT", nullable: true),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    ErrorMessage = table.Column<string>(type: "TEXT", nullable: true),
                    PaymentId = table.Column<Guid>(type: "TEXT", nullable: true),
                    PaymentGatewayId = table.Column<Guid>(type: "TEXT", nullable: true),
                    PaymentMethodId = table.Column<Guid>(type: "TEXT", nullable: true),
                    PaymentOptionId = table.Column<Guid>(type: "TEXT", nullable: true),
                    PaymentScheduleId = table.Column<Guid>(type: "TEXT", nullable: true),
                    PaymentScheduleItemNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PaymentScheduleNumber = table.Column<string>(type: "TEXT", nullable: true),
                    RunHour = table.Column<int>(type: "INTEGER", nullable: true),
                    ScheduledDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Standalone = table.Column<bool>(type: "INTEGER", nullable: true),
                    State = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentScheduleItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentScheduleItem_BillingDocument_BillingDocumentId",
                        column: x => x.BillingDocumentId,
                        principalTable: "BillingDocument",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PaymentScheduleItem_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PaymentScheduleItem_CustomObject_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObject",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PaymentScheduleItem_PaymentSchedule_PaymentScheduleId",
                        column: x => x.PaymentScheduleId,
                        principalTable: "PaymentSchedule",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PaymentScheduleItem_Payment_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payment",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RefundsAppliedTo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: true),
                    BillingDocumentId = table.Column<Guid>(type: "TEXT", nullable: true),
                    BillingDocumentType = table.Column<string>(type: "TEXT", nullable: true),
                    PaymentId = table.Column<Guid>(type: "TEXT", nullable: true),
                    RefundId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefundsAppliedTo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefundsAppliedTo_BillingDocument_BillingDocumentId",
                        column: x => x.BillingDocumentId,
                        principalTable: "BillingDocument",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RefundsAppliedTo_Payment_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RefundsAppliedTo_Refund_RefundId",
                        column: x => x.RefundId,
                        principalTable: "Refund",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RefundStateTransitions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CanceledTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    RefundedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    RefundId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefundStateTransitions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefundStateTransitions_Refund_RefundId",
                        column: x => x.RefundId,
                        principalTable: "Refund",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PrepaidBalances",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    SubscriptionId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrepaidBalances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrepaidBalances_Subscription_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "Subscription",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionPlan",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    PlanId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ProductId = table.Column<Guid>(type: "TEXT", nullable: true),
                    SubscriptionId = table.Column<Guid>(type: "TEXT", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionPlan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubscriptionPlan_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SubscriptionPlan_CustomObject_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObject",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SubscriptionPlan_Plan_PlanId",
                        column: x => x.PlanId,
                        principalTable: "Plan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SubscriptionPlan_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SubscriptionPlan_Subscription_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "Subscription",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PaymentScheduleItemPayments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    PaymentScheduleItemId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentScheduleItemPayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentScheduleItemPayments_PaymentScheduleItem_PaymentScheduleItemId",
                        column: x => x.PaymentScheduleItemId,
                        principalTable: "PaymentScheduleItem",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RefundAppliedToItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: true),
                    CreditMemoItemId = table.Column<string>(type: "TEXT", nullable: true),
                    TaxationItemId = table.Column<string>(type: "TEXT", nullable: true),
                    RefundsAppliedToId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefundAppliedToItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefundAppliedToItem_RefundsAppliedTo_RefundsAppliedToId",
                        column: x => x.RefundsAppliedToId,
                        principalTable: "RefundsAppliedTo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ValidityPeriod",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    OverageRatedAmount = table.Column<decimal>(type: "TEXT", nullable: true),
                    OverageRatedQuantity = table.Column<decimal>(type: "TEXT", nullable: true),
                    PrepaidUOM = table.Column<Guid>(type: "TEXT", nullable: false),
                    RemainingBalance = table.Column<decimal>(type: "TEXT", nullable: true),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    TotalBalance = table.Column<decimal>(type: "TEXT", nullable: true),
                    PrepaidBalancesId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValidityPeriod", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ValidityPeriod_PrepaidBalances_PrepaidBalancesId",
                        column: x => x.PrepaidBalancesId,
                        principalTable: "PrepaidBalances",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Active = table.Column<bool>(type: "INTEGER", nullable: true),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: true),
                    ApplyDiscountTo = table.Column<string>(type: "TEXT", nullable: true),
                    ChargedThroughDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ChargeModel = table.Column<string>(type: "TEXT", nullable: true),
                    ChargeType = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    DiscountAmount = table.Column<decimal>(type: "TEXT", nullable: true),
                    DiscountLevel = table.Column<string>(type: "TEXT", nullable: true),
                    DiscountPercent = table.Column<decimal>(type: "TEXT", nullable: true),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    OverageId = table.Column<Guid>(type: "TEXT", nullable: true),
                    PriceBaseInterval = table.Column<string>(type: "TEXT", nullable: true),
                    PriceId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ProcessedThroughDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ProductId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Quantity = table.Column<decimal>(type: "TEXT", nullable: true),
                    RecurringId = table.Column<Guid>(type: "TEXT", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    StartEvent = table.Column<string>(type: "TEXT", nullable: false),
                    State = table.Column<string>(type: "TEXT", nullable: false),
                    SubscriptionItemNumber = table.Column<string>(type: "TEXT", nullable: false),
                    SubscriptionPlanId = table.Column<Guid>(type: "TEXT", nullable: true),
                    TaxCode = table.Column<string>(type: "TEXT", nullable: false),
                    TaxInclusive = table.Column<bool>(type: "INTEGER", nullable: true),
                    TiersMode = table.Column<string>(type: "TEXT", nullable: false),
                    UnitAmount = table.Column<decimal>(type: "TEXT", nullable: true),
                    UnitOfMeasure = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    SubscriptionAddPlanId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubscriptionItem_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SubscriptionItem_CustomObject_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObject",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SubscriptionItem_Overage_OverageId",
                        column: x => x.OverageId,
                        principalTable: "Overage",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SubscriptionItem_Price_PriceId",
                        column: x => x.PriceId,
                        principalTable: "Price",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SubscriptionItem_Recurring_RecurringId",
                        column: x => x.RecurringId,
                        principalTable: "Recurring",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubscriptionItem_SubscriptionAddPlan_SubscriptionAddPlanId",
                        column: x => x.SubscriptionAddPlanId,
                        principalTable: "SubscriptionAddPlan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SubscriptionItem_SubscriptionPlan_SubscriptionPlanId",
                        column: x => x.SubscriptionPlanId,
                        principalTable: "SubscriptionPlan",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PrepaidBalanceTransaction",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Quantity = table.Column<decimal>(type: "TEXT", nullable: true),
                    TransactionDate = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    PrepaidBalanceId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ValidityPeriodId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrepaidBalanceTransaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrepaidBalanceTransaction_PrepaidBalance_PrepaidBalanceId",
                        column: x => x.PrepaidBalanceId,
                        principalTable: "PrepaidBalance",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PrepaidBalanceTransaction_ValidityPeriod_ValidityPeriodId",
                        column: x => x.ValidityPeriodId,
                        principalTable: "ValidityPeriod",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BillingDocumentItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountingCode = table.Column<string>(type: "TEXT", nullable: true),
                    AccountsReceivableAccount = table.Column<string>(type: "TEXT", nullable: true),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: true),
                    AppliedToItemId = table.Column<Guid>(type: "TEXT", nullable: true),
                    BillingDocumentId = table.Column<Guid>(type: "TEXT", nullable: true),
                    BookingReference = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    DeferredRevenueAccount = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    DiscountItem = table.Column<bool>(type: "INTEGER", nullable: true),
                    DocumentItemDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    InvoiceItemId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    OnAccountAccount = table.Column<string>(type: "TEXT", nullable: true),
                    PriceDescription = table.Column<string>(type: "TEXT", nullable: true),
                    PriceId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ProductName = table.Column<string>(type: "TEXT", nullable: true),
                    PurchaseOrderNumber = table.Column<string>(type: "TEXT", nullable: true),
                    Quantity = table.Column<decimal>(type: "TEXT", nullable: true),
                    RecognizedRevenueAccount = table.Column<string>(type: "TEXT", nullable: true),
                    RemainingBalance = table.Column<decimal>(type: "TEXT", nullable: true),
                    RevenueRecognitionRuleName = table.Column<string>(type: "TEXT", nullable: true),
                    ServiceEnd = table.Column<string>(type: "TEXT", nullable: true),
                    ServiceStart = table.Column<string>(type: "TEXT", nullable: true),
                    Sku = table.Column<string>(type: "TEXT", nullable: true),
                    SubscriptionId = table.Column<Guid>(type: "TEXT", nullable: false),
                    SubscriptionItemId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Subtotal = table.Column<decimal>(type: "TEXT", nullable: true),
                    Tax = table.Column<decimal>(type: "TEXT", nullable: true),
                    TaxCode = table.Column<string>(type: "TEXT", nullable: false),
                    TaxInclusive = table.Column<bool>(type: "INTEGER", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    UnitAmount = table.Column<decimal>(type: "TEXT", nullable: true),
                    UnitOfMeasure = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    PaymentsAppliedToId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingDocumentItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BillingDocumentItem_BillingDocument_BillingDocumentId",
                        column: x => x.BillingDocumentId,
                        principalTable: "BillingDocument",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BillingDocumentItem_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BillingDocumentItem_CustomObject_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObject",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BillingDocumentItem_PaymentsAppliedTo_PaymentsAppliedToId",
                        column: x => x.PaymentsAppliedToId,
                        principalTable: "PaymentsAppliedTo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BillingDocumentItem_SubscriptionItem_SubscriptionItemId",
                        column: x => x.SubscriptionItemId,
                        principalTable: "SubscriptionItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BillingDocumentItem_Subscription_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "Subscription",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CreditMemoItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountingCode = table.Column<string>(type: "TEXT", nullable: false),
                    AccountsReceivableAccount = table.Column<string>(type: "TEXT", nullable: false),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: true),
                    AppliedToItemId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedById = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CreditMemoId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    DeferredRevenueAccount = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    DiscountItem = table.Column<bool>(type: "INTEGER", nullable: true),
                    DocumentItemDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    InvoiceItemId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    OnAccountAccount = table.Column<string>(type: "TEXT", nullable: false),
                    PriceId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PurchaseOrderNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Quantity = table.Column<decimal>(type: "TEXT", nullable: true),
                    RecognizedRevenueAccount = table.Column<string>(type: "TEXT", nullable: false),
                    RemainingBalance = table.Column<decimal>(type: "TEXT", nullable: true),
                    RevenueRecognitionRuleName = table.Column<string>(type: "TEXT", nullable: false),
                    ServiceEnd = table.Column<string>(type: "TEXT", nullable: false),
                    ServiceStart = table.Column<string>(type: "TEXT", nullable: false),
                    Sku = table.Column<string>(type: "TEXT", nullable: false),
                    SubscriptionId = table.Column<Guid>(type: "TEXT", nullable: false),
                    SubscriptionItemId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Subtotal = table.Column<decimal>(type: "TEXT", nullable: true),
                    Tax = table.Column<decimal>(type: "TEXT", nullable: true),
                    TaxCode = table.Column<string>(type: "TEXT", nullable: false),
                    TaxInclusive = table.Column<bool>(type: "INTEGER", nullable: true),
                    UnitAmount = table.Column<decimal>(type: "TEXT", nullable: true),
                    UnitOfMeasure = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditMemoItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CreditMemoItem_CreditMemo_CreditMemoId",
                        column: x => x.CreditMemoId,
                        principalTable: "CreditMemo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CreditMemoItem_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CreditMemoItem_CustomObject_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CreditMemoItem_SubscriptionItem_SubscriptionItemId",
                        column: x => x.SubscriptionItemId,
                        principalTable: "SubscriptionItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CreditMemoItem_Subscription_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "Subscription",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DebitMemoItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountingCode = table.Column<string>(type: "TEXT", nullable: false),
                    AccountsReceivableAccount = table.Column<string>(type: "TEXT", nullable: false),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: true),
                    AppliedToItemId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedById = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    DebitMemoId = table.Column<Guid>(type: "TEXT", nullable: false),
                    DeferredRevenueAccount = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    DiscountItem = table.Column<bool>(type: "INTEGER", nullable: true),
                    DocumentItemDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    InvoiceItemId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    OnAccountAccount = table.Column<string>(type: "TEXT", nullable: false),
                    PriceId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PurchaseOrderNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Quantity = table.Column<decimal>(type: "TEXT", nullable: true),
                    RecognizedRevenueAccount = table.Column<string>(type: "TEXT", nullable: false),
                    RemainingBalance = table.Column<decimal>(type: "TEXT", nullable: true),
                    RevenueRecognitionRuleName = table.Column<string>(type: "TEXT", nullable: false),
                    ServiceEnd = table.Column<string>(type: "TEXT", nullable: false),
                    ServiceStart = table.Column<string>(type: "TEXT", nullable: false),
                    Sku = table.Column<string>(type: "TEXT", nullable: false),
                    SubscriptionId = table.Column<Guid>(type: "TEXT", nullable: false),
                    SubscriptionItemId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Subtotal = table.Column<decimal>(type: "TEXT", nullable: true),
                    Tax = table.Column<decimal>(type: "TEXT", nullable: true),
                    TaxCode = table.Column<string>(type: "TEXT", nullable: false),
                    TaxInclusive = table.Column<bool>(type: "INTEGER", nullable: true),
                    UnitAmount = table.Column<decimal>(type: "TEXT", nullable: true),
                    UnitOfMeasure = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DebitMemoItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DebitMemoItem_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DebitMemoItem_CustomObject_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DebitMemoItem_DebitMemo_DebitMemoId",
                        column: x => x.DebitMemoId,
                        principalTable: "DebitMemo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DebitMemoItem_SubscriptionItem_SubscriptionItemId",
                        column: x => x.SubscriptionItemId,
                        principalTable: "SubscriptionItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DebitMemoItem_Subscription_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "Subscription",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountingCode = table.Column<string>(type: "TEXT", nullable: true),
                    AccountsReceivableAccount = table.Column<string>(type: "TEXT", nullable: true),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: true),
                    AppliedToItemId = table.Column<Guid>(type: "TEXT", nullable: true),
                    BookingReference = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    DeferredRevenueAccount = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    DiscountItem = table.Column<bool>(type: "INTEGER", nullable: true),
                    DocumentItemDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    InvoiceId = table.Column<Guid>(type: "TEXT", nullable: true),
                    LineItemId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    PriceId = table.Column<Guid>(type: "TEXT", nullable: true),
                    PurchaseOrderNumber = table.Column<string>(type: "TEXT", nullable: true),
                    Quantity = table.Column<decimal>(type: "TEXT", nullable: true),
                    RecognizedRevenueAccount = table.Column<string>(type: "TEXT", nullable: true),
                    RemainingBalance = table.Column<decimal>(type: "TEXT", nullable: true),
                    RevenueRecognitionRuleName = table.Column<string>(type: "TEXT", nullable: false),
                    ServiceEnd = table.Column<string>(type: "TEXT", nullable: false),
                    ServiceStart = table.Column<string>(type: "TEXT", nullable: false),
                    Sku = table.Column<string>(type: "TEXT", nullable: false),
                    SubscriptionId = table.Column<Guid>(type: "TEXT", nullable: false),
                    SubscriptionItemId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Tax = table.Column<decimal>(type: "TEXT", nullable: true),
                    TaxCode = table.Column<string>(type: "TEXT", nullable: false),
                    TaxInclusive = table.Column<bool>(type: "INTEGER", nullable: true),
                    UnitAmount = table.Column<decimal>(type: "TEXT", nullable: true),
                    UnitOfMeasure = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvoiceItem_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InvoiceItem_CustomObject_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObject",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InvoiceItem_Invoice_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoice",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InvoiceItem_OrderLineItem_LineItemId",
                        column: x => x.LineItemId,
                        principalTable: "OrderLineItem",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InvoiceItem_SubscriptionItem_SubscriptionItemId",
                        column: x => x.SubscriptionItemId,
                        principalTable: "SubscriptionItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvoiceItem_Subscription_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "Subscription",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemTier",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: true),
                    UnitAmount = table.Column<decimal>(type: "TEXT", nullable: true),
                    UpTo = table.Column<decimal>(type: "TEXT", nullable: true),
                    SubscriptionItemId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemTier", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemTier_SubscriptionItem_SubscriptionItemId",
                        column: x => x.SubscriptionItemId,
                        principalTable: "SubscriptionItem",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TaxationItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: true),
                    AmountApplied = table.Column<decimal>(type: "TEXT", nullable: true),
                    AmountCredited = table.Column<decimal>(type: "TEXT", nullable: true),
                    AmountExempt = table.Column<decimal>(type: "TEXT", nullable: true),
                    AmountPaid = table.Column<decimal>(type: "TEXT", nullable: true),
                    AmountRefunded = table.Column<decimal>(type: "TEXT", nullable: true),
                    CreatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Jurisdiction = table.Column<string>(type: "TEXT", nullable: true),
                    LocationCode = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    OnAccountAccount = table.Column<string>(type: "TEXT", nullable: true),
                    RemainingBalance = table.Column<decimal>(type: "TEXT", nullable: true),
                    SalesTaxPayableAccount = table.Column<string>(type: "TEXT", nullable: true),
                    SourceTaxItemId = table.Column<string>(type: "TEXT", nullable: true),
                    TaxCode = table.Column<string>(type: "TEXT", nullable: true),
                    TaxCodeName = table.Column<string>(type: "TEXT", nullable: true),
                    TaxDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    TaxInclusive = table.Column<bool>(type: "INTEGER", nullable: true),
                    TaxRate = table.Column<decimal>(type: "TEXT", nullable: true),
                    TaxRateName = table.Column<string>(type: "TEXT", nullable: true),
                    TaxRateType = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "TEXT", nullable: true),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    BillingDocumentItemId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreditMemoItemId = table.Column<Guid>(type: "TEXT", nullable: true),
                    DebitMemoItemId = table.Column<Guid>(type: "TEXT", nullable: true),
                    InvoiceItemId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxationItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaxationItem_BillingDocumentItem_BillingDocumentItemId",
                        column: x => x.BillingDocumentItemId,
                        principalTable: "BillingDocumentItem",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TaxationItem_CreditMemoItem_CreditMemoItemId",
                        column: x => x.CreditMemoItemId,
                        principalTable: "CreditMemoItem",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TaxationItem_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TaxationItem_CustomObject_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObject",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TaxationItem_DebitMemoItem_DebitMemoItemId",
                        column: x => x.DebitMemoItemId,
                        principalTable: "DebitMemoItem",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TaxationItem_InvoiceItem_InvoiceItemId",
                        column: x => x.InvoiceItemId,
                        principalTable: "InvoiceItem",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Account_BillingDocumentSettingsId",
                table: "Account",
                column: "BillingDocumentSettingsId");

            migrationBuilder.CreateIndex(
                name: "IX_Account_CustomFieldsId",
                table: "Account",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_Account_CustomObjectsId",
                table: "Account",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_Account_TaxCertificateId",
                table: "Account",
                column: "TaxCertificateId");

            migrationBuilder.CreateIndex(
                name: "IX_Account_TaxIdentifierId",
                table: "Account",
                column: "TaxIdentifierId");

            migrationBuilder.CreateIndex(
                name: "IX_AchDebit_MandateId",
                table: "AchDebit",
                column: "MandateId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplePay_CardId",
                table: "ApplePay",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplePay_MandateId",
                table: "ApplePay",
                column: "MandateId");

            migrationBuilder.CreateIndex(
                name: "IX_AuBecsDebit_MandateId",
                table: "AuBecsDebit",
                column: "MandateId");

            migrationBuilder.CreateIndex(
                name: "IX_AutogiroDebit_MandateId",
                table: "AutogiroDebit",
                column: "MandateId");

            migrationBuilder.CreateIndex(
                name: "IX_BacsDebit_MandateId",
                table: "BacsDebit",
                column: "MandateId");

            migrationBuilder.CreateIndex(
                name: "IX_BetalingsDebit_MandateId",
                table: "BetalingsDebit",
                column: "MandateId");

            migrationBuilder.CreateIndex(
                name: "IX_BillingDetails_AddressId",
                table: "BillingDetails",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_BillingDocument_AccountId",
                table: "BillingDocument",
                column: "AccountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BillingDocument_CustomFieldsId",
                table: "BillingDocument",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_BillingDocument_CustomObjectsId",
                table: "BillingDocument",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_BillingDocumentItem_BillingDocumentId",
                table: "BillingDocumentItem",
                column: "BillingDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_BillingDocumentItem_CustomFieldsId",
                table: "BillingDocumentItem",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_BillingDocumentItem_CustomObjectsId",
                table: "BillingDocumentItem",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_BillingDocumentItem_PaymentsAppliedToId",
                table: "BillingDocumentItem",
                column: "PaymentsAppliedToId");

            migrationBuilder.CreateIndex(
                name: "IX_BillingDocumentItem_SubscriptionId",
                table: "BillingDocumentItem",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_BillingDocumentItem_SubscriptionItemId",
                table: "BillingDocumentItem",
                column: "SubscriptionItemId");

            migrationBuilder.CreateIndex(
                name: "IX_BillingDocumentSetting_CreditMemoId",
                table: "BillingDocumentSetting",
                column: "CreditMemoId");

            migrationBuilder.CreateIndex(
                name: "IX_BillingDocumentStateTransitions_BillingDocumentId",
                table: "BillingDocumentStateTransitions",
                column: "BillingDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_BillTo_AccountId",
                table: "BillTo",
                column: "AccountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BillTo_AddressId",
                table: "BillTo",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_BillTo_CustomFieldsId",
                table: "BillTo",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_BillTo_CustomObjectsId",
                table: "BillTo",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_Card_MandateId",
                table: "Card",
                column: "MandateId");

            migrationBuilder.CreateIndex(
                name: "IX_CardMandate_CustomerAcceptanceId",
                table: "CardMandate",
                column: "CustomerAcceptanceId");

            migrationBuilder.CreateIndex(
                name: "IX_CcRef_CardId",
                table: "CcRef",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_CcRef_MandateId",
                table: "CcRef",
                column: "MandateId");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_AddressId",
                table: "Contact",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_CustomFieldsId",
                table: "Contact",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_CustomObjectsId",
                table: "Contact",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_CreditMemo_AccountId",
                table: "CreditMemo",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_CreditMemo_ArTransactionsId",
                table: "CreditMemo",
                column: "ArTransactionsId");

            migrationBuilder.CreateIndex(
                name: "IX_CreditMemo_BillToId",
                table: "CreditMemo",
                column: "BillToId");

            migrationBuilder.CreateIndex(
                name: "IX_CreditMemo_CreditMemoId",
                table: "CreditMemo",
                column: "CreditMemoId");

            migrationBuilder.CreateIndex(
                name: "IX_CreditMemo_CustomFieldsId",
                table: "CreditMemo",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_CreditMemo_CustomObjectsId",
                table: "CreditMemo",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_CreditMemo_StateTransitionsId",
                table: "CreditMemo",
                column: "StateTransitionsId");

            migrationBuilder.CreateIndex(
                name: "IX_CreditMemoAppliedTo_BillingDocumentId",
                table: "CreditMemoAppliedTo",
                column: "BillingDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_CreditMemoItem_CreditMemoId",
                table: "CreditMemoItem",
                column: "CreditMemoId");

            migrationBuilder.CreateIndex(
                name: "IX_CreditMemoItem_CustomFieldsId",
                table: "CreditMemoItem",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_CreditMemoItem_CustomObjectsId",
                table: "CreditMemoItem",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_CreditMemoItem_SubscriptionId",
                table: "CreditMemoItem",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_CreditMemoItem_SubscriptionItemId",
                table: "CreditMemoItem",
                column: "SubscriptionItemId");

            migrationBuilder.CreateIndex(
                name: "IX_DebitMemo_AccountId",
                table: "DebitMemo",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_DebitMemo_BillingDocumentSettingsId",
                table: "DebitMemo",
                column: "BillingDocumentSettingsId");

            migrationBuilder.CreateIndex(
                name: "IX_DebitMemo_BillToId",
                table: "DebitMemo",
                column: "BillToId");

            migrationBuilder.CreateIndex(
                name: "IX_DebitMemo_CustomFieldsId",
                table: "DebitMemo",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_DebitMemo_CustomObjectsId",
                table: "DebitMemo",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_DebitMemo_StateTransitionsId",
                table: "DebitMemo",
                column: "StateTransitionsId");

            migrationBuilder.CreateIndex(
                name: "IX_DebitMemoItem_CustomFieldsId",
                table: "DebitMemoItem",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_DebitMemoItem_CustomObjectsId",
                table: "DebitMemoItem",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_DebitMemoItem_DebitMemoId",
                table: "DebitMemoItem",
                column: "DebitMemoId");

            migrationBuilder.CreateIndex(
                name: "IX_DebitMemoItem_SubscriptionId",
                table: "DebitMemoItem",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_DebitMemoItem_SubscriptionItemId",
                table: "DebitMemoItem",
                column: "SubscriptionItemId");

            migrationBuilder.CreateIndex(
                name: "IX_GetCardList_MandateId",
                table: "GetCardList",
                column: "MandateId");

            migrationBuilder.CreateIndex(
                name: "IX_GooglePay_CardId",
                table: "GooglePay",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_AccountId",
                table: "Invoice",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_ArTransactionsId",
                table: "Invoice",
                column: "ArTransactionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_BillingDocumentSettingsId",
                table: "Invoice",
                column: "BillingDocumentSettingsId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_BillToId",
                table: "Invoice",
                column: "BillToId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_CustomFieldsId",
                table: "Invoice",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_CustomObjectsId",
                table: "Invoice",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_SoldToId",
                table: "Invoice",
                column: "SoldToId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_StateTransitionsId",
                table: "Invoice",
                column: "StateTransitionsId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceItem_CustomFieldsId",
                table: "InvoiceItem",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceItem_CustomObjectsId",
                table: "InvoiceItem",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceItem_InvoiceId",
                table: "InvoiceItem",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceItem_LineItemId",
                table: "InvoiceItem",
                column: "LineItemId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceItem_SubscriptionId",
                table: "InvoiceItem",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceItem_SubscriptionItemId",
                table: "InvoiceItem",
                column: "SubscriptionItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemTier_SubscriptionItemId",
                table: "ItemTier",
                column: "SubscriptionItemId");

            migrationBuilder.CreateIndex(
                name: "IX_NzBecsDebit_MandateId",
                table: "NzBecsDebit",
                column: "MandateId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_AccountId",
                table: "Order",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomFieldsId",
                table: "Order",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomObjectsId",
                table: "Order",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderLineItem_CustomFieldsId",
                table: "OrderLineItem",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderLineItem_CustomObjectsId",
                table: "OrderLineItem",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderLineItem_OrderId",
                table: "OrderLineItem",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_PadDebit_MandateId",
                table: "PadDebit",
                column: "MandateId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_AccountId",
                table: "Payment",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_CustomFieldsId",
                table: "Payment",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_CustomObjectsId",
                table: "Payment",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_GatewayOptionsId",
                table: "Payment",
                column: "GatewayOptionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_GatewayStateTransitionsId",
                table: "Payment",
                column: "GatewayStateTransitionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_PaymentMethodId",
                table: "Payment",
                column: "PaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_PaymentTransactionsId",
                table: "Payment",
                column: "PaymentTransactionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_StateTransitionsId",
                table: "Payment",
                column: "StateTransitionsId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethod_AccountId",
                table: "PaymentMethod",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethod_AchDebitId",
                table: "PaymentMethod",
                column: "AchDebitId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethod_ApplePayId",
                table: "PaymentMethod",
                column: "ApplePayId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethod_AuBecsDebitId",
                table: "PaymentMethod",
                column: "AuBecsDebitId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethod_AutogiroDebitId",
                table: "PaymentMethod",
                column: "AutogiroDebitId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethod_BacsDebitId",
                table: "PaymentMethod",
                column: "BacsDebitId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethod_BetalingsDebitId",
                table: "PaymentMethod",
                column: "BetalingsDebitId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethod_BillingDetailsId",
                table: "PaymentMethod",
                column: "BillingDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethod_CardId",
                table: "PaymentMethod",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethod_CcRefId",
                table: "PaymentMethod",
                column: "CcRefId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethod_CustomFieldsId",
                table: "PaymentMethod",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethod_CustomObjectsId",
                table: "PaymentMethod",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethod_GooglePayId",
                table: "PaymentMethod",
                column: "GooglePayId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethod_NzBecsDebitId",
                table: "PaymentMethod",
                column: "NzBecsDebitId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethod_PadDebitId",
                table: "PaymentMethod",
                column: "PadDebitId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethod_PaypalAdaptiveId",
                table: "PaymentMethod",
                column: "PaypalAdaptiveId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethod_PaypalExpressId",
                table: "PaymentMethod",
                column: "PaypalExpressId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethod_PaypalExpressNativeId",
                table: "PaymentMethod",
                column: "PaypalExpressNativeId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethod_SepaDebitId",
                table: "PaymentMethod",
                column: "SepaDebitId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentOption_DetailId",
                table: "PaymentOption",
                column: "DetailId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentOption_PaymentScheduleId",
                table: "PaymentOption",
                column: "PaymentScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentsAppliedTo_BillingDocumentId",
                table: "PaymentsAppliedTo",
                column: "BillingDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentsAppliedTo_PaymentId",
                table: "PaymentsAppliedTo",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentSchedule_BillingDocumentId",
                table: "PaymentSchedule",
                column: "BillingDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentSchedule_CustomFieldsId",
                table: "PaymentSchedule",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentSchedule_CustomObjectsId",
                table: "PaymentSchedule",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentScheduleItem_BillingDocumentId",
                table: "PaymentScheduleItem",
                column: "BillingDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentScheduleItem_CustomFieldsId",
                table: "PaymentScheduleItem",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentScheduleItem_CustomObjectsId",
                table: "PaymentScheduleItem",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentScheduleItem_PaymentId",
                table: "PaymentScheduleItem",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentScheduleItem_PaymentScheduleId",
                table: "PaymentScheduleItem",
                column: "PaymentScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentScheduleItemPayments_PaymentScheduleItemId",
                table: "PaymentScheduleItemPayments",
                column: "PaymentScheduleItemId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentTransaction_ArTransactionsId",
                table: "PaymentTransaction",
                column: "ArTransactionsId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentTransaction_StateId",
                table: "PaymentTransaction",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Plan_CustomFieldsId",
                table: "Plan",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_Plan_CustomObjectsId",
                table: "Plan",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_Plan_ProductId",
                table: "Plan",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_PrepaidBalances_SubscriptionId",
                table: "PrepaidBalances",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_PrepaidBalanceTransaction_PrepaidBalanceId",
                table: "PrepaidBalanceTransaction",
                column: "PrepaidBalanceId");

            migrationBuilder.CreateIndex(
                name: "IX_PrepaidBalanceTransaction_ValidityPeriodId",
                table: "PrepaidBalanceTransaction",
                column: "ValidityPeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_Price_AmountsId",
                table: "Price",
                column: "AmountsId");

            migrationBuilder.CreateIndex(
                name: "IX_Price_CustomFieldsId",
                table: "Price",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_Price_CustomObjectsId",
                table: "Price",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_Price_DiscountAmountsId",
                table: "Price",
                column: "DiscountAmountsId");

            migrationBuilder.CreateIndex(
                name: "IX_Price_DrawdownId",
                table: "Price",
                column: "DrawdownId");

            migrationBuilder.CreateIndex(
                name: "IX_Price_OverageId",
                table: "Price",
                column: "OverageId");

            migrationBuilder.CreateIndex(
                name: "IX_Price_PlanId",
                table: "Price",
                column: "PlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Price_PrepaymentId",
                table: "Price",
                column: "PrepaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Price_RecurringId",
                table: "Price",
                column: "RecurringId");

            migrationBuilder.CreateIndex(
                name: "IX_Price_RevenueId",
                table: "Price",
                column: "RevenueId");

            migrationBuilder.CreateIndex(
                name: "IX_Price_UnitAmountsId",
                table: "Price",
                column: "UnitAmountsId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CustomFieldsId",
                table: "Product",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CustomObjectsId",
                table: "Product",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPlan_CustomFieldsId",
                table: "ProductPlan",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPlan_CustomObjectsId",
                table: "ProductPlan",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPlan_ProductId",
                table: "ProductPlan",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrice_AmountsId",
                table: "ProductPrice",
                column: "AmountsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrice_CustomFieldsId",
                table: "ProductPrice",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrice_CustomObjectsId",
                table: "ProductPrice",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrice_DiscountAmountsId",
                table: "ProductPrice",
                column: "DiscountAmountsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrice_DrawdownId",
                table: "ProductPrice",
                column: "DrawdownId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrice_OverageId",
                table: "ProductPrice",
                column: "OverageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrice_PrepaymentId",
                table: "ProductPrice",
                column: "PrepaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrice_ProductPlanId",
                table: "ProductPrice",
                column: "ProductPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrice_RecurringId",
                table: "ProductPrice",
                column: "RecurringId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrice_RevenueId",
                table: "ProductPrice",
                column: "RevenueId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrice_UnitAmountsId",
                table: "ProductPrice",
                column: "UnitAmountsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTier_AmountsId",
                table: "ProductTier",
                column: "AmountsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTier_ProductPriceId",
                table: "ProductTier",
                column: "ProductPriceId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTier_UnitAmountsId",
                table: "ProductTier",
                column: "UnitAmountsId");

            migrationBuilder.CreateIndex(
                name: "IX_Refund_AccountId",
                table: "Refund",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Refund_CreditMemoId",
                table: "Refund",
                column: "CreditMemoId");

            migrationBuilder.CreateIndex(
                name: "IX_Refund_CustomFieldsId",
                table: "Refund",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_Refund_CustomObjectsId",
                table: "Refund",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_Refund_GatewayOptionsId",
                table: "Refund",
                column: "GatewayOptionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Refund_PaymentMethodId",
                table: "Refund",
                column: "PaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Refund_RefundTransactionsId",
                table: "Refund",
                column: "RefundTransactionsId");

            migrationBuilder.CreateIndex(
                name: "IX_RefundAppliedToItem_RefundsAppliedToId",
                table: "RefundAppliedToItem",
                column: "RefundsAppliedToId");

            migrationBuilder.CreateIndex(
                name: "IX_RefundsAppliedTo_BillingDocumentId",
                table: "RefundsAppliedTo",
                column: "BillingDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_RefundsAppliedTo_PaymentId",
                table: "RefundsAppliedTo",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_RefundsAppliedTo_RefundId",
                table: "RefundsAppliedTo",
                column: "RefundId");

            migrationBuilder.CreateIndex(
                name: "IX_RefundStateTransitions_RefundId",
                table: "RefundStateTransitions",
                column: "RefundId");

            migrationBuilder.CreateIndex(
                name: "IX_RefundTransaction_ArTransactionsId",
                table: "RefundTransaction",
                column: "ArTransactionsId");

            migrationBuilder.CreateIndex(
                name: "IX_RefundTransaction_StateId",
                table: "RefundTransaction",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_ResumeSubscription_CustomFieldsId",
                table: "ResumeSubscription",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_SepaDebit_MandateId",
                table: "SepaDebit",
                column: "MandateId");

            migrationBuilder.CreateIndex(
                name: "IX_SoldTo_AccountId",
                table: "SoldTo",
                column: "AccountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SoldTo_AddressId",
                table: "SoldTo",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_SoldTo_CustomFieldsId",
                table: "SoldTo",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_SoldTo_CustomObjectsId",
                table: "SoldTo",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscription_AccountId",
                table: "Subscription",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscription_BillingDocumentSettingsId",
                table: "Subscription",
                column: "BillingDocumentSettingsId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscription_BillToId",
                table: "Subscription",
                column: "BillToId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscription_CurrentTermId",
                table: "Subscription",
                column: "CurrentTermId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscription_CustomFieldsId",
                table: "Subscription",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscription_CustomObjectsId",
                table: "Subscription",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscription_InitialTermId",
                table: "Subscription",
                column: "InitialTermId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscription_InvoiceOwnerAccountId",
                table: "Subscription",
                column: "InvoiceOwnerAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscription_OrderId",
                table: "Subscription",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscription_PrepaidBalanceId",
                table: "Subscription",
                column: "PrepaidBalanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscription_RenewalTermId",
                table: "Subscription",
                column: "RenewalTermId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscription_SoldToId",
                table: "Subscription",
                column: "SoldToId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionAddPlan_CustomFieldsId",
                table: "SubscriptionAddPlan",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionItem_CustomFieldsId",
                table: "SubscriptionItem",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionItem_CustomObjectsId",
                table: "SubscriptionItem",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionItem_OverageId",
                table: "SubscriptionItem",
                column: "OverageId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionItem_PriceId",
                table: "SubscriptionItem",
                column: "PriceId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionItem_RecurringId",
                table: "SubscriptionItem",
                column: "RecurringId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionItem_SubscriptionAddPlanId",
                table: "SubscriptionItem",
                column: "SubscriptionAddPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionItem_SubscriptionPlanId",
                table: "SubscriptionItem",
                column: "SubscriptionPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionPause_CustomFieldsId",
                table: "SubscriptionPause",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionPause_ResumeBehaviorId",
                table: "SubscriptionPause",
                column: "ResumeBehaviorId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionPlan_CustomFieldsId",
                table: "SubscriptionPlan",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionPlan_CustomObjectsId",
                table: "SubscriptionPlan",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionPlan_PlanId",
                table: "SubscriptionPlan",
                column: "PlanId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionPlan_ProductId",
                table: "SubscriptionPlan",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionPlan_SubscriptionId",
                table: "SubscriptionPlan",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionRenew_TermsId",
                table: "SubscriptionRenew",
                column: "TermsId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionTerm_CurrentTermId",
                table: "SubscriptionTerm",
                column: "CurrentTermId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionTerm_RenewalTermId",
                table: "SubscriptionTerm",
                column: "RenewalTermId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxationItem_BillingDocumentItemId",
                table: "TaxationItem",
                column: "BillingDocumentItemId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxationItem_CreditMemoItemId",
                table: "TaxationItem",
                column: "CreditMemoItemId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxationItem_CustomFieldsId",
                table: "TaxationItem",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxationItem_CustomObjectsId",
                table: "TaxationItem",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxationItem_DebitMemoItemId",
                table: "TaxationItem",
                column: "DebitMemoItemId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxationItem_InvoiceItemId",
                table: "TaxationItem",
                column: "InvoiceItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Tier_AmountsId",
                table: "Tier",
                column: "AmountsId");

            migrationBuilder.CreateIndex(
                name: "IX_Tier_PriceId",
                table: "Tier",
                column: "PriceId");

            migrationBuilder.CreateIndex(
                name: "IX_Tier_UnitAmountsId",
                table: "Tier",
                column: "UnitAmountsId");

            migrationBuilder.CreateIndex(
                name: "IX_Usage_AccountId",
                table: "Usage",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Usage_CustomFieldsId",
                table: "Usage",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_Usage_CustomObjectsId",
                table: "Usage",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_ValidityPeriod_PrepaidBalancesId",
                table: "ValidityPeriod",
                column: "PrepaidBalancesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Account_BillingDocumentSetting_BillingDocumentSettingsId",
                table: "Account",
                column: "BillingDocumentSettingsId",
                principalTable: "BillingDocumentSetting",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Account_BillingDocumentSetting_BillingDocumentSettingsId",
                table: "Account");

            migrationBuilder.DropTable(
                name: "BillingDocumentStateTransitions");

            migrationBuilder.DropTable(
                name: "BillTo");

            migrationBuilder.DropTable(
                name: "CreditMemoAppliedTo");

            migrationBuilder.DropTable(
                name: "ItemTier");

            migrationBuilder.DropTable(
                name: "PaymentOption");

            migrationBuilder.DropTable(
                name: "PaymentScheduleItemPayments");

            migrationBuilder.DropTable(
                name: "PrepaidBalanceTransaction");

            migrationBuilder.DropTable(
                name: "ProductTier");

            migrationBuilder.DropTable(
                name: "RefundAppliedToItem");

            migrationBuilder.DropTable(
                name: "RefundStateTransitions");

            migrationBuilder.DropTable(
                name: "SoldTo");

            migrationBuilder.DropTable(
                name: "SubscriptionCancel");

            migrationBuilder.DropTable(
                name: "SubscriptionPause");

            migrationBuilder.DropTable(
                name: "SubscriptionRemovePlan");

            migrationBuilder.DropTable(
                name: "SubscriptionRenew");

            migrationBuilder.DropTable(
                name: "TaxationItem");

            migrationBuilder.DropTable(
                name: "Tier");

            migrationBuilder.DropTable(
                name: "Usage");

            migrationBuilder.DropTable(
                name: "Detail");

            migrationBuilder.DropTable(
                name: "PaymentScheduleItem");

            migrationBuilder.DropTable(
                name: "ValidityPeriod");

            migrationBuilder.DropTable(
                name: "ProductPrice");

            migrationBuilder.DropTable(
                name: "RefundsAppliedTo");

            migrationBuilder.DropTable(
                name: "ResumeSubscription");

            migrationBuilder.DropTable(
                name: "SubscriptionTerm");

            migrationBuilder.DropTable(
                name: "BillingDocumentItem");

            migrationBuilder.DropTable(
                name: "CreditMemoItem");

            migrationBuilder.DropTable(
                name: "DebitMemoItem");

            migrationBuilder.DropTable(
                name: "InvoiceItem");

            migrationBuilder.DropTable(
                name: "Money");

            migrationBuilder.DropTable(
                name: "PaymentSchedule");

            migrationBuilder.DropTable(
                name: "PrepaidBalances");

            migrationBuilder.DropTable(
                name: "ProductPlan");

            migrationBuilder.DropTable(
                name: "Refund");

            migrationBuilder.DropTable(
                name: "PaymentsAppliedTo");

            migrationBuilder.DropTable(
                name: "DebitMemo");

            migrationBuilder.DropTable(
                name: "Invoice");

            migrationBuilder.DropTable(
                name: "OrderLineItem");

            migrationBuilder.DropTable(
                name: "SubscriptionItem");

            migrationBuilder.DropTable(
                name: "RefundTransaction");

            migrationBuilder.DropTable(
                name: "BillingDocument");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "Price");

            migrationBuilder.DropTable(
                name: "SubscriptionAddPlan");

            migrationBuilder.DropTable(
                name: "SubscriptionPlan");

            migrationBuilder.DropTable(
                name: "GatewayOptions");

            migrationBuilder.DropTable(
                name: "GatewayStateTransitions");

            migrationBuilder.DropTable(
                name: "PaymentMethod");

            migrationBuilder.DropTable(
                name: "PaymentStateTransitions");

            migrationBuilder.DropTable(
                name: "PaymentTransaction");

            migrationBuilder.DropTable(
                name: "Amounts");

            migrationBuilder.DropTable(
                name: "Drawdown");

            migrationBuilder.DropTable(
                name: "Overage");

            migrationBuilder.DropTable(
                name: "Prepayment");

            migrationBuilder.DropTable(
                name: "Recurring");

            migrationBuilder.DropTable(
                name: "Revenue");

            migrationBuilder.DropTable(
                name: "Plan");

            migrationBuilder.DropTable(
                name: "Subscription");

            migrationBuilder.DropTable(
                name: "AchDebit");

            migrationBuilder.DropTable(
                name: "ApplePay");

            migrationBuilder.DropTable(
                name: "AuBecsDebit");

            migrationBuilder.DropTable(
                name: "AutogiroDebit");

            migrationBuilder.DropTable(
                name: "BacsDebit");

            migrationBuilder.DropTable(
                name: "BetalingsDebit");

            migrationBuilder.DropTable(
                name: "BillingDetails");

            migrationBuilder.DropTable(
                name: "CcRef");

            migrationBuilder.DropTable(
                name: "GetCardList");

            migrationBuilder.DropTable(
                name: "GooglePay");

            migrationBuilder.DropTable(
                name: "NzBecsDebit");

            migrationBuilder.DropTable(
                name: "PadDebit");

            migrationBuilder.DropTable(
                name: "PaypalAdaptive");

            migrationBuilder.DropTable(
                name: "PaypalExpressNative");

            migrationBuilder.DropTable(
                name: "PaypalExpress");

            migrationBuilder.DropTable(
                name: "SepaDebit");

            migrationBuilder.DropTable(
                name: "TransactionsState");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "PrepaidBalance");

            migrationBuilder.DropTable(
                name: "Term");

            migrationBuilder.DropTable(
                name: "AddressFieldDefinitions");

            migrationBuilder.DropTable(
                name: "CcRefCard");

            migrationBuilder.DropTable(
                name: "Card");

            migrationBuilder.DropTable(
                name: "Mandate");

            migrationBuilder.DropTable(
                name: "CardMandate");

            migrationBuilder.DropTable(
                name: "CustomerAcceptanceMandate");

            migrationBuilder.DropTable(
                name: "BillingDocumentSetting");

            migrationBuilder.DropTable(
                name: "CreditMemo");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "ArTransaction");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "StateTransitions");

            migrationBuilder.DropTable(
                name: "TaxCertificate");

            migrationBuilder.DropTable(
                name: "TaxIdentifier");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "CustomFields");

            migrationBuilder.DropTable(
                name: "CustomObject");
        }
    }
}
