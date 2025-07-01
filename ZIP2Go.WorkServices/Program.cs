using DataExtractor.WorkServices.HostedService;
using Service.Interfaces;
using Service;
using EasyCaching.Core;
using Service.Client;
using Microsoft.Extensions.Caching.Memory;
using Repository.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace DataExtractor.WorkServices
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Configuration.AddEnvironmentVariables().AddJsonFile("appsettings.Development.json");
            var connection = builder.Configuration.GetConnectionString("AZURE_SQL_CONNECTIONSTRING");
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            ConfigureService(builder.Services);
            ConfigureHostedService(builder.Services);
            builder.Services.AddMemoryCache();

            builder.Services.AddDbContext<AppDataContext>(options =>
                options.UseSqlServer(connection, sqlOptions =>
                {
                    sqlOptions.EnableRetryOnFailure(
                        maxRetryCount: 5,
                        maxRetryDelay: TimeSpan.FromSeconds(30),
                        errorNumbersToAdd: null);
                }));

            var app = builder.Build();

            //// Get memory cache instance
            //var cache = app.Services.GetRequiredService<IMemoryCache>();

            ////Set a value in cache
            //cache.Set("key", "value", new MemoryCacheEntryOptions
            //{
            //    AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(10000)
            //});

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();

            
        }

        static void ConfigureHostedService(IServiceCollection services)
        {
            services.AddHostedService<AccountsHostedService>();
            //services.AddHostedService<SubscriptionsHostedService>();
            //services.AddHostedService<InvoicesHostedService>();
        }

        static void ConfigureService(IServiceCollection services)
        {
            services.AddScoped(sp =>
            {
                return new ApiClient(
                    sp.GetService<ILogger<ApiClient>>(),
                    sp.GetService<IMemoryCache>(),
                    sp.GetService<AppDataContext>()
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
        }
    }
}