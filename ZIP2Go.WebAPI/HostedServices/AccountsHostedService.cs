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
            _logger.LogInformation("Accounts Cache loading start.");
            using (var scope = _services.CreateScope())
            {
                var service = scope.ServiceProvider.GetRequiredService<IAccountsService>();
         
                service.FillAccountsCache(zuoraTrackId, async);
            }
            _logger.LogInformation("Accounts Cache loading finished.");

            _logger.LogInformation("Subscriptions Cache loading start.");
            using (var scope = _services.CreateScope())
            {
                var service = scope.ServiceProvider.GetRequiredService<ISubscriptionsService>();
              
                service.FillSubscriptionsCache(zuoraTrackId, async);
            }
            _logger.LogInformation("Subscriptions Cache loading finished.");

            _logger.LogInformation("Products Cache loading start.");
            using (var scope = _services.CreateScope())
            {
                var service = scope.ServiceProvider.GetRequiredService<IProductsService>();

                service.FillProductsCache(zuoraTrackId, async);
            }
            _logger.LogInformation("Products Cache loading finished.");

            _logger.LogInformation("Invoices Cache loading start.");
            using (var scope = _services.CreateScope())
            {
                var service = scope.ServiceProvider.GetRequiredService<IInvoicesService>();

                service.FillInvoicesCache(zuoraTrackId, async);
            }
            _logger.LogInformation("Plan Cache loading started.");
            using (var scope = _services.CreateScope())
            {
                var service = scope.ServiceProvider.GetRequiredService<IPlansService>();

                service.FillPlansCache(zuoraTrackId, async);
            }
            _logger.LogInformation("Plan Cache loading finished.");

            _logger.LogInformation("Plan Cache loading started.");
            using (var scope = _services.CreateScope())
            {
                var service = scope.ServiceProvider.GetRequiredService<ISubscriptionPlansService>();

                service.FillSubscriptionPlansCached();
            }
            _logger.LogInformation("Plan Cache loading finished.");
        }


    }
}