using SteffBeckers.Abp.Sales.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace SteffBeckers.Abp.Sales
{
    public abstract class SalesController : AbpController
    {
        protected SalesController()
        {
            LocalizationResource = typeof(SalesResource);
        }
    }
}
