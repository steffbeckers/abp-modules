using Microsoft.Extensions.DependencyInjection;
using SteffBeckers.Abp.Sales.Accounts;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace SteffBeckers.Abp.Sales.EntityFrameworkCore
{
    [DependsOn(
        typeof(SalesDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class SalesEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<SalesDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
                options.AddRepository<Account, EfCoreAccountRepository>();
            });
        }
    }
}