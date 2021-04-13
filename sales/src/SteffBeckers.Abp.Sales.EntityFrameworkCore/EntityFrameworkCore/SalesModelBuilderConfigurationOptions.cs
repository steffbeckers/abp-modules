using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace SteffBeckers.Abp.Sales.EntityFrameworkCore
{
    public class SalesModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public SalesModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}