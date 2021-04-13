using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace SteffBeckers.Abp.Sales
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(SalesDomainSharedModule)
    )]
    public class SalesDomainModule : AbpModule
    {

    }
}
