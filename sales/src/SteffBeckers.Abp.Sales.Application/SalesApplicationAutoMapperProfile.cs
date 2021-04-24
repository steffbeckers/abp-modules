using AutoMapper;
using SteffBeckers.Abp.Sales.Accounts;
using SteffBeckers.Abp.Sales.Accounts.Dto;
using Volo.Abp.AutoMapper;

namespace SteffBeckers.Abp.Sales
{
    public class SalesApplicationAutoMapperProfile : Profile
    {
        public SalesApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<Account, AccountDto>();
            CreateMap<CreateAccountDto, Account>()
                .ForMember(x => x.ExtraProperties, x => x.Ignore())
                .ForMember(x => x.ConcurrencyStamp, x => x.Ignore())
                .IgnoreFullAuditedObjectProperties();
            CreateMap<UpdateAccountDto, Account>()
                .ForMember(x => x.ExtraProperties, x => x.Ignore())
                .ForMember(x => x.ConcurrencyStamp, x => x.Ignore())
                .IgnoreFullAuditedObjectProperties();
        }
    }
}