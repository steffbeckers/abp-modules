using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using SteffBeckers.Abp.Sales.EntityFrameworkCore;

namespace SteffBeckers.Abp.Sales.Accounts
{
    public class EfCoreAccountRepository
        : EfCoreRepository<SalesDbContext, Account, Guid>,
            IAccountRepository
    {
        public EfCoreAccountRepository(
            IDbContextProvider<SalesDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        public async Task<Account> FindByNameAsync(string name)
        {
            DbSet<Account> dbSet = await GetDbSetAsync();
            return await dbSet.FirstOrDefaultAsync(account => account.Name == name);
        }
    }
}
