using Service.Interfaces;
using Service;
using Service.Client;
using Microsoft.Extensions.Options;
using EasyCaching.Core;
using Microsoft.Extensions.DependencyInjection;

namespace DataExtractor.WebAPI.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped(sp =>
            {
                return new ApiClient(
                    sp.GetService<IEasyCachingProvider>(),
                    sp.GetService<ILogger<ApiClient>>() 
                );
            });

            services.AddScoped<IAccountsService, AccountsService>();
            services.AddScoped<IPlansService, PlansService>();
            services.AddScoped<ITaxationItemsService, TaxationItemsService>();
            services.AddScoped<ICreditMemosService, CreditMemosService>();
            services.AddScoped<IDebitMemosService, DebitMemosService>();
            services.AddScoped<IContactsService, ContactsService>();
            services.AddScoped<IPricesService, PricesService>();
            services.AddScoped<IQueryRunsService, QueryRunsService>();
            services.AddScoped<IInvoicesService, InvoicesService>();
            services.AddScoped<ISubscriptionsService, SubscriptionsService>();
            services.AddScoped<ISubscriptionItemsService, SubscriptionItemsService>();
            services.AddScoped<ISubscriptionPlansService, SubscriptionPlansService>();
            services.AddScoped<IOrdersService, OrdersService>();
            services.AddScoped<IPaymentMethodsService, PaymentMethodsService>();
            services.AddScoped<IProductsService, ProductsService>();
            services.AddScoped<IBillingDocumentItemsService, BillingDocumentItemsService>();
            services.AddScoped<IBillingDocumentsService, BillingDocumentsService>();
            services.AddScoped<IWorkflowsService, WorkflowsService>();
            services.AddScoped<IUsageRecordsService, UsageRecordsService>();
            services.AddScoped<IRefundsService, RefundsService>();
            services.AddScoped<IPaymentsService, PaymentsService>();
            services.AddScoped<IPaymentSchedulesService, PaymentSchedulesService>();
            services.AddScoped<IPaymentScheduleItemsService, PaymentScheduleItemsService>();
            services.AddScoped<IPaymentRunsService, PaymentRunsService>();
            services.AddScoped<IOrderLineItemsService, OrderLineItemsService>();
            services.AddScoped<IFulfillmentsService, FulfillmentService>();
            services.AddScoped<IFulfillmentItemsService, FulfillmentItemsService>();
            services.AddScoped<ICustomObjectsService, CustomObjectsService>();
            services.AddScoped<IBillRunsService, BillRunsService>();
            services.AddScoped<IBillRunPreviewsService, BillRunPreviewsService>();

            return services;
        }
    }
}