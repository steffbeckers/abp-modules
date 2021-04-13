using AutoMapper;
using SteffBeckers.Abp.Sales.Accounts;
using SteffBeckers.Abp.Sales.Accounts.Dto;

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
                .ForMember(x => x.IsDeleted, x => x.Ignore())
                .ForMember(x => x.DeleterId, x => x.Ignore())
                .ForMember(x => x.DeletionTime, x => x.Ignore())
                .ForMember(x => x.LastModificationTime, x => x.Ignore())
                .ForMember(x => x.LastModifierId, x => x.Ignore())
                .ForMember(x => x.CreationTime, x => x.Ignore())
                .ForMember(x => x.CreatorId, x => x.Ignore())
                .ForMember(x => x.ExtraProperties, x => x.Ignore())
                .ForMember(x => x.ConcurrencyStamp, x => x.Ignore());
            CreateMap<UpdateAccountDto, Account>()
                .ForMember(x => x.IsDeleted, x => x.Ignore())
                .ForMember(x => x.DeleterId, x => x.Ignore())
                .ForMember(x => x.DeletionTime, x => x.Ignore())
                .ForMember(x => x.LastModificationTime, x => x.Ignore())
                .ForMember(x => x.LastModifierId, x => x.Ignore())
                .ForMember(x => x.CreationTime, x => x.Ignore())
                .ForMember(x => x.CreatorId, x => x.Ignore())
                .ForMember(x => x.ExtraProperties, x => x.Ignore())
                .ForMember(x => x.ConcurrencyStamp, x => x.Ignore());
        }
    }
}