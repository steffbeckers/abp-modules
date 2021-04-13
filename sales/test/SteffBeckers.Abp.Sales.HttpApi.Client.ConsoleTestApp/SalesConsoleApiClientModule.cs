using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace SteffBeckers.Abp.Sales
{
    [DependsOn(
        typeof(SalesHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class SalesConsoleApiClientModule : AbpModule
    {
        
    }
}
