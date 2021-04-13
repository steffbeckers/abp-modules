using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace SteffBeckers.Abp.Sales.Accounts.Dto
{
    public class AccountDto : AuditedEntityDto<Guid>//, IValidatableObject
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Website { get; set; }
    }
}
