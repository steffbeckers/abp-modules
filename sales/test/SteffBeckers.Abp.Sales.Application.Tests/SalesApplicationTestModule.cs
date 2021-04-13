using Volo.Abp.Modularity;

namespace SteffBeckers.Abp.Sales
{
    [DependsOn(
        typeof(SalesApplicationModule),
        typeof(SalesDomainTestModule)
        )]
    public class SalesApplicationTestModule : AbpModule
    {

    }
}
