using Microsoft.Extensions.DependencyInjection;
using Service.Interfaces;

namespace DataExtractor.WorkServices.HostedService
{
    public class AccountsHostedService : BackgroundService
    {
        private readonly ILogger<AccountsHostedService> _logger;

        private readonly IServiceScopeFactory _services;

        private Timer? _timer = null;


        public AccountsHostedService(
            IServiceScopeFactory services,
            ILogger<AccountsHostedService> logger)
        {
            _services = services;
            _logger = logger;
        }



        public override async Task StopAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation(
                "Consume Scoped Service Hosted Service is stopping.");

            await base.StopAsync(stoppingToken);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation(
                "Consume Scoped Service Hosted Service running.");
            _timer = new Timer(DoWork, null, TimeSpan.Zero,
             TimeSpan.FromHours(23));
        }

        private async void DoWork(object? state)
        {
            string zuoraTrackId = new Guid().ToString();
            bool async = true;

            using (var scope = _services.CreateScope())
            {
                var service = scope.ServiceProvider.GetRequiredService<IAccountsService>();
         
                service.FillAccountsTable(zuoraTrackId, async);
            }

            using (var scope = _services.CreateScope())
            {
                var service = scope.ServiceProvider.GetRequiredService<ISubscriptionsService>();
              
                service.FillSubscriptionsTable(zuoraTrackId, async);
            }
            using (var scope = _services.CreateScope())
            {
                var service = scope.ServiceProvider.GetRequiredService<IContactsService>();

                service.FillContactsTable(zuoraTrackId, async);
            }

            using (var scope = _services.CreateScope())
            {
                var service = scope.ServiceProvider.GetRequiredService<IProductsService>();

                service.FillProductsTable(zuoraTrackId, async);
            }

            using (var scope = _services.CreateScope())
            {
                var service = scope.ServiceProvider.GetRequiredService<IPricesService>();

                service.FillPricesTable(zuoraTrackId, async);
            }
           
            using (var scope = _services.CreateScope())
            {
                var service = scope.ServiceProvider.GetRequiredService<IInvoicesService>();

                service.FillInvoicesTable(zuoraTrackId, async);
                service.FillInvoicesItemsTable(zuoraTrackId, async);
            }
            using (var scope = _services.CreateScope())
            {
                var service = scope.ServiceProvider.GetRequiredService<ICreditMemosService>();

                service.FillCreditMemoTable(zuoraTrackId, async);
                service.FillCreditMemoItemsTable(zuoraTrackId, async);
            }

            using (var scope = _services.CreateScope())
            {
                var service = scope.ServiceProvider.GetRequiredService<IDebitMemosService>();

                service.FillDebitMemoTable(zuoraTrackId, async);
                service.FillDebitMemoItemsTable(zuoraTrackId, async);
            }

            using (var scope = _services.CreateScope())
            {
                var service = scope.ServiceProvider.GetRequiredService<IPlansService>();

                service.FillPlansTable(zuoraTrackId, async);
            }

            using (var scope = _services.CreateScope())
            {
                var service = scope.ServiceProvider.GetRequiredService<ISubscriptionPlansService>();

                service.FillSubscriptionPlansTable(zuoraTrackId,async);
            }
            using (var scope = _services.CreateScope())
            {
                var service = scope.ServiceProvider.GetRequiredService<IOrdersService>();

                service.FillOrdersTable(zuoraTrackId, async);
            }
            using (var scope = _services.CreateScope())
            {
                var service = scope.ServiceProvider.GetRequiredService<ISubscriptionItemsService>();

                service.FillSubscriptionItemsTable(zuoraTrackId, async);
            }


        }


    }
}