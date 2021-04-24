using SteffBeckers.Abp.Sales.Accounts.Dto;
using SteffBeckers.Abp.Sales.Permissions;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace SteffBeckers.Abp.Sales.Accounts
{
    public class AccountsAppService :
        CrudAppService<
            Account,
            AccountDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateAccountDto,
            UpdateAccountDto
        >,
        IAccountsAppService
    {
        public AccountsAppService(IRepository<Account, Guid> accountRepository) : base(accountRepository)
        {
            GetListPolicyName = SalesPermissions.Accounts;
            GetPolicyName = SalesPermissions.Accounts;
            CreatePolicyName = SalesPermissions.CreateAccounts;
            UpdatePolicyName = SalesPermissions.EditAccounts;
            DeletePolicyName = SalesPermissions.DeleteAccounts;
        }
    }
}
