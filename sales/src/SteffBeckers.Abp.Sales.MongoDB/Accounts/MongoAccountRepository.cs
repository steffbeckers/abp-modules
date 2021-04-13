
using MongoDB.Driver;
using SteffBeckers.Abp.Sales.MongoDB;
using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.MongoDB;
using Volo.Abp.MongoDB;

namespace SteffBeckers.Abp.Sales.Accounts
{
    public class MongoAccountRepository :
        MongoDbRepository<SalesMongoDbContext, Account, Guid>,
        IAccountRepository
    {
        public MongoAccountRepository(
            IMongoDbContextProvider<SalesMongoDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        public async Task<Account> FindByNameAsync(string name)
        {
            IMongoCollection<Account> collection = await GetCollectionAsync();
            return await collection.Find(x => x.Name == name).SingleOrDefaultAsync();
        }
    }
}
