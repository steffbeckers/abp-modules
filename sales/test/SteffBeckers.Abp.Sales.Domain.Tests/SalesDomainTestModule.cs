using SteffBeckers.Abp.Sales.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace SteffBeckers.Abp.Sales
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(SalesEntityFrameworkCoreTestModule)
        )]
    public class SalesDomainTestModule : AbpModule
    {
        
    }
}
