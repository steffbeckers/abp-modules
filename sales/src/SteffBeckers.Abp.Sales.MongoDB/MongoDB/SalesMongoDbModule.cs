using Microsoft.Extensions.DependencyInjection;
using SteffBeckers.Abp.Sales.Accounts;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;

namespace SteffBeckers.Abp.Sales.MongoDB
{
    [DependsOn(
        typeof(SalesDomainModule),
        typeof(AbpMongoDbModule)
        )]
    public class SalesMongoDbModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddMongoDbContext<SalesMongoDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, MongoQuestionRepository>();
                 */
                options.AddRepository<Account, MongoAccountRepository>();
            });
        }
    }
}
