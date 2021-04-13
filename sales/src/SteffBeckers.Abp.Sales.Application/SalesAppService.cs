using SteffBeckers.Abp.Sales.Localization;
using Volo.Abp.Application.Services;

namespace SteffBeckers.Abp.Sales
{
    public abstract class SalesAppService : ApplicationService
    {
        protected SalesAppService()
        {
            LocalizationResource = typeof(SalesResource);
            ObjectMapperContext = typeof(SalesApplicationModule);
        }
    }
}
