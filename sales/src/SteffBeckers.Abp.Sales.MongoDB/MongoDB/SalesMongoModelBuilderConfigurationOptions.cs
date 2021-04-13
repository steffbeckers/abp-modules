using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace SteffBeckers.Abp.Sales.MongoDB
{
    public class SalesMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public SalesMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}