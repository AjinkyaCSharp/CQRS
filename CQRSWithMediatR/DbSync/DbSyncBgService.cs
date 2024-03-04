using CQRSWithMediatR.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace CQRSWithMediatR.DbSync
{
    public class DbSyncBgService : BackgroundService
    {
        readonly IServiceProvider _serviceProvider;
        public DbSyncBgService(IServiceProvider _serviceProvider)
        {
            this._serviceProvider = _serviceProvider;
        }
        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while(!stoppingToken.IsCancellationRequested)
            {
                Task.Delay(100000);
                var employeeWriteRepo = _serviceProvider.GetRequiredService<EmployeeWriteRepository>();
                var employeeReadRepo = _serviceProvider.GetService<EmployeeReadRepository>();
                var emplyees= employeeWriteRepo.GetEmployees();
                employeeReadRepo.SyncDb(emplyees);
            }
            return Task.CompletedTask;
        }
    }
}