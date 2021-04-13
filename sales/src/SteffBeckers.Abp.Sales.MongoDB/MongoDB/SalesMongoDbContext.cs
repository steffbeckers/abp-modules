using MongoDB.Driver;
using SteffBeckers.Abp.Sales.Accounts;
using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace SteffBeckers.Abp.Sales.MongoDB
{
    [ConnectionStringName(SalesDbProperties.ConnectionStringName)]
    public class SalesMongoDbContext : AbpMongoDbContext, ISalesMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */
        public IMongoCollection<Account> Accounts => Collection<Account>();

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureSales();
        }
    }
}