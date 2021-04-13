using SteffBeckers.Abp.Sales.Accounts.Dto;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SteffBeckers.Abp.Sales.Accounts
{
    public interface IAccountsAppService : ICrudAppService<AccountDto, Guid, PagedAndSortedResultRequestDto, CreateAccountDto, UpdateAccountDto>
    {
    }
}
