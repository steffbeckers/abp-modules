using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace SteffBeckers.Abp.Sales.Accounts
{
    public interface IAccountRepository : IRepository<Account, Guid>
    {
        Task<Account> FindByNameAsync(string name);
    }
}
